using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    [SerializeField] float force;
    [SerializeField] float mass;
    [SerializeField] float acceleration;
    
    void CalculateForce()
    {
        mass = GetComponent<Rigidbody>().mass;
        force = mass * acceleration;
        GetComponent<Rigidbody>().AddForce(force, force, 0);
    }
    
    public void SetAcceleration250()
    {
        acceleration = 250;
        CalculateForce();
    }
    
    public void SetAcceleration300()
    {
        acceleration = 300;
        CalculateForce();
    }
    
    public void SetAcceleration350()
    {
        acceleration = 350;
        CalculateForce();
    }


}
