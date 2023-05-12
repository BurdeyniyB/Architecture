using UnityEngine;
using UnityEngine.UI;

public class ModeForce : MonoBehaviour
{
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void AddForseObject()
    {
        //       _rb.AddForce(0, 10f, 0);
        //       _rb.AddForce(Vector3.up * 10f);
        _rb.AddForce(new Vector3(0, 90f, 0), ForceMode.Acceleration);
    }
}
