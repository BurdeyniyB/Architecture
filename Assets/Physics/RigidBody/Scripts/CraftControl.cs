using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftControl : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _rotationSpeed = 5f;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.maxAngularVelocity = Mathf.Infinity;
    }

    public void Forward()
    {
        _rb.AddForce(0, 0, _speed);
    }

    public void Backward()
    {
        _rb.AddForce(0, 0, -_speed);
    }

    public void Right()
    {
        _rb.AddForce(_speed, 0, 0);
        _rb.AddTorque(0, _rotationSpeed / 10, 0);
    }

    public void Left()
    {
        _rb.AddForce(-_speed, 0, 0);
        _rb.AddTorque(0, -_rotationSpeed / 10, 0);
    }
}
