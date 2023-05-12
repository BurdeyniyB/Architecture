using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    private bool _isActive = true;
    [SerializeField] private GameObject _markPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (!_isActive) return;
        _isActive = false;

        if(collision.gameObject.GetComponent<ShowCenterOfMass>())
        {
            Debug.Log("shot");
        }

        Vector3 position = collision.contacts[0].point;
        Quaternion rotation = Quaternion.LookRotation(collision.contacts[0].normal);

        Instantiate(_markPrefab, position, rotation, collision.transform);
    }
}
