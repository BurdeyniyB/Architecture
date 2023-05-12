using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.name = "Enter";
    }

    private void OnTriggerStay(Collider other)
    {
        other.gameObject.name = "Stay";
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.name = "Exit";
    }
}
