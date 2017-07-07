using UnityEngine;

public class Bola : MonoBehaviour {
	//public float velocity;
	private Rigidbody rb;
	private float potencia=0;
	void Awake () {
		rb=GetComponent<Rigidbody>();

	}
	void Start(){
		rb.AddRelativeForce(Vector3.forward*1*potencia,ForceMode.Force);
	}
	
	// Update is called once per frame
	void FixedUpdate() {
	
	
	}
	public float setPotencia{
		set{
			potencia=value; 
		}
	}
}
