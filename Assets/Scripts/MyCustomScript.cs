using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCustomScript : MonoBehaviour
{
    public float _springPower;
    private HingeJoint _hinge;
    public KeyCode _input;

    private void Start()
    {
        _hinge = GetComponent<HingeJoint>();
    }
    private void Update()
    {
        MoveInput();
    }
    private void MoveInput()
    {
        JointSpring _jointSpring = _hinge.spring;
        if (Input.GetKey(_input))
        {
            _jointSpring.spring = _springPower;
        }
        else
        {
            _jointSpring.spring = 0;
        }
        _hinge.spring = _jointSpring;
    }

}
