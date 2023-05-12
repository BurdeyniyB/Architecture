using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Vector3 _offset;
    [Range(0.5f, 5f)] [SerializeField] private float _smoothing;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var nextPosition = Vector3.Lerp(this.transform.position, _targetTransform.position + _offset, Time.deltaTime * _smoothing);

        this.transform.position = nextPosition;
    }
}
