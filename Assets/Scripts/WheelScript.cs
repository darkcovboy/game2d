using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelScript : MonoBehaviour {


    private WheelJoint2D wheel;
    private JointMotor2D motor;

    public float speed;

	// Use this for initialization
	void Start () {
        wheel = GetComponent<WheelJoint2D>();
        motor = wheel.motor;

	}
	
	// Update is called once per frame
	void Update () {

        float hForce = Input.GetAxis("Horizontal");

        motor.motorSpeed = speed * hForce;
        wheel.motor = motor;
	}
}
