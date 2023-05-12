using UnityEngine;

public class BangAtPosition : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _forceValue = 100f;

    public ParticleSystem _system;

    public void AddPushForse()
    {
        _rb.AddForceAtPosition(transform.up * _forceValue, transform.position);

//        _system.Play();
    }

}
