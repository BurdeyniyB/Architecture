using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] private Transform _waterTransform;
    [SerializeField] private float _waterForce;
    private Rigidbody _rb;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (_waterTransform.position.y >= transform.position.y)
        {
            Debug.Log("Water");
            _rb.drag = 1f * Mathf.Abs(1 + _waterTransform.position.y - transform.position.y);
            _rb.AddForce(0, _waterForce * Mathf.Abs(1 + _waterTransform.position.y - transform.position.y), 0);
        }
    }
}
