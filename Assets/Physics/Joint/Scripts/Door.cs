using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private HingeJoint _joint;
    private bool _isOpen;

    public void OpenOrClose()
    {
        JointSpring jointSpring = _joint.spring;

        if (!_isOpen)
        {
            jointSpring.targetPosition = 90f;
            _isOpen = true;
        }
        else
        {
            jointSpring.targetPosition = 0f;
            _isOpen = false;
        }

        _joint.spring = jointSpring;
    }
}
