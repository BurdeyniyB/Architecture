using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourse;
    [SerializeField] private float _coeficientVolume;

    private void OnCollisionEnter(Collision collision)
    {
        float impulse = collision.impulse.magnitude;
        Debug.Log($"collision impulse {collision.impulse.magnitude}");

        _audioSourse.volume = impulse * _coeficientVolume;
        _audioSourse.Play();
    }
}
