using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class bullet : MonoBehaviour
{
    [SerializeField ] private GameObject _bulletPrefab;
    [SerializeField] private float _speedBullet = 100f;

    public void Create()
    {
      var bullet = Instantiate(_bulletPrefab, transform.position, transform.rotation);

      bullet.transform.SetParent(transform);
      bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * _speedBullet, ForceMode.VelocityChange);
    }
}
