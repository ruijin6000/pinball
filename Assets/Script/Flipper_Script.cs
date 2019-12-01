using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper_Script : MonoBehaviour {
    public float restPosition = 0f;
    public float pressdPosition = 45f;
    public float hitStrenght = 50000f;
    public float flipperDamper = 150f;
    HingeJoint hinge;
    public string inputName;

	// Use this for initialization
	void Start () {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
	}
	
	// Update is called once per frame
	void Update () {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;

        if (Input.GetAxis(inputName) ==1) {
            spring.targetPosition = pressdPosition;
        }

        else {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;

	}
}
