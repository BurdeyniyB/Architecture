using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncAwaitExample : MonoBehaviour
{
    [SerializeField] private Transform[] _rotatingObject;
    [SerializeField] private float _rotatingSpeed;
    [SerializeField] private GameObject _goTextFinished;

    private Task[] _task;

    public void ActiveLifeRoutine()
    {
        _task = new Task[_rotatingObject.Length];
//        LifeAsync();
        LifeWhenAllTask();
    }

    private IEnumerator LifeRoutine()
    {
        for (int i = 0; i < _rotatingObject.Length; i++)
        {
            yield return StartCoroutine(RotateObjectRoutine(_rotatingObject[i], (i + 1)));
        }
    }

    private IEnumerator RotateObjectRoutine(Transform rotateObject, float duration)
    {
        var timer = 0f;
        while (timer < 1f)
        {
            timer = Mathf.Min(timer + Time.deltaTime / duration, 1f);
            rotateObject.Rotate(Vector3.up, _rotatingSpeed * Time.deltaTime);
            yield return null;
        }
    }

    private async void LifeAsync()
    {
        _goTextFinished.SetActive(false);

        for (int i = 0; i < _rotatingObject.Length; i++)
        {
            var duraction = await GetDeration();

            await RotateAsync(_rotatingObject[i], duraction);
        }

        _goTextFinished.SetActive(true);
    }

    private async void LifeWhenAllTask()
    {
        _goTextFinished.SetActive(false);

        for (int i = 0; i < _rotatingObject.Length; i++)
        {
           _task[i] = RotateAsync(_rotatingObject[i], (i + 1));
        }

        await Task.WhenAll(_task);

        _goTextFinished.SetActive(true);
    }

    private async Task RotateAsync(Transform rotateObject, float duration)
    {
        var timer = 0f;
        while (timer < 1f)
        {
            timer = Mathf.Min(timer + Time.deltaTime / duration, 1f);
            rotateObject.Rotate(Vector3.up, _rotatingSpeed * Time.deltaTime);
            await Task.Yield();
        }
    }

    private async Task<int> GetDeration()
    {
        await Task.Delay(1000);

        return Random.Range(1, 5);
    }
}
