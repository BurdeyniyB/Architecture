using UnityEngine;

public class ShowCenterOfMass : MonoBehaviour
{
    [SerializeField] private Transform _centerOfMassTransform;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _rb.centerOfMass = Vector3.Scale(_centerOfMassTransform.localPosition, transform.localScale);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(GetComponent<Rigidbody>().worldCenterOfMass, 0.3f);
    }
}
