using UnityEngine;

public class EditRigidbody : MonoBehaviour
{
    private Rigidbody _body;

    private void Start()
    {
        _body = GetComponent<Rigidbody>();
    }

    public void Active()
    {
        _body.isKinematic = false;
        _body.mass = 10;
        _body.drag = 0.2f;
        _body.angularDrag = 0.1f;

        _body.useGravity = true;
    }
}
