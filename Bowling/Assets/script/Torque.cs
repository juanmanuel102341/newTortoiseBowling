using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour {
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb=GetComponent<Rigidbody>();
		rb.AddTorque(Vector3.right);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
