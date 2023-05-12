using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _lifeTime = 2f;

    private void OnEnable()
    {
        this.StartCoroutine(LifeRoutine());
    }

    private void OnDisable()
    {
        this.StopCoroutine(LifeRoutine());
    }

    private IEnumerator LifeRoutine()
    {
        yield return new WaitForSeconds(this._lifeTime);

        this.OnDestroy();
    }

    private void OnDestroy()
    {
        this.gameObject.SetActive(false);
    }
}
