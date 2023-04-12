using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTargetPosition : MonoBehaviour
{
    private HingeJoint _hinge;
    private float _TargetPressed;
    private float _TargetReleased;
    public KeyCode _input;

    private void Start()
    {
        _hinge = GetComponent<HingeJoint>();
        _TargetPressed = _hinge.limits.max;
        _TargetReleased = _hinge.limits.min;
    }

    private void Update()
    {
        readInput();
    }

    private void readInput()
    {
        JointSpring _jointSpring = _hinge.spring;
        if (Input.GetKey(_input))
        {
            _jointSpring.targetPosition = _TargetPressed;
        }
        else
        {
            _jointSpring.targetPosition = _TargetReleased;
        }
        _hinge.spring =  _jointSpring;
    }
}
