using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animated : MonoBehaviour
{
    [SerializeField] private PhysicMaterial _default;
    [SerializeField] private PhysicMaterial _zero;

    [SerializeField] private Collider _leftCollider;
    [SerializeField] private Collider _rightCollider;

    public void SetLeftFriction()
    {
        _leftCollider.material = _default;
        _rightCollider.material = _zero;
    }

    public void SetRightFriction()
    {
        _leftCollider.material = _zero;
        _rightCollider.material = _default;
    }
}
