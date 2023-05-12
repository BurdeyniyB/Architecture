using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRay : MonoBehaviour
{
    public Transform Pointer;
    public Selectable CurrentSelectable;
    private void Update()
    {
        //Ray ray = new Ray();
        //ray.origin = transform.position;
        //ray.direction = transform.forward;

        //Ray ray = new Ray(transform.position, transform.forward);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, transform.forward * 100, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Pointer.position = hit.point;

            Selectable selectable = hit.collider.gameObject.GetComponent<Selectable>();
            if(selectable)
            {
                CheckSelectable(selectable);
                CurrentSelectable = selectable;
                selectable.Selected();
            }
            else
            {
                CheckSelectable();
            }
        }
        else
        {
            CheckSelectable();
        }
    }

    private void CheckSelectable(Selectable selectable)
    {
        if (CurrentSelectable && CurrentSelectable != selectable)
        {
            DeselectCheckSelectable();
        }
    }

    private void CheckSelectable()
    {
        if (CurrentSelectable)
        {
            DeselectCheckSelectable();
        }
    }

    private void DeselectCheckSelectable()
    {
        CurrentSelectable.Deselect();
        CurrentSelectable = null;
    }
}
