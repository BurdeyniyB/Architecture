using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollider : MonoBehaviour
{
    [SerializeField] private Collider _colliderA;
    [SerializeField] private Collider _colliderB;

    private void Start()
    {
        Physics.IgnoreCollision(_colliderB, _colliderA);
    }
}
