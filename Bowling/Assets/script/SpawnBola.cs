using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBola : MonoBehaviour {
	public GameObject bola;
	public Transform limiteInferior;
	public Transform limiteSuperior;
	public Transform limiteFinal;
	private Transform transformCameraBola;

	// Use this for initialization
	private Transform tf;
	private float tiempo=0;
	private int direccion=1;

	private Rigidbody rb;
	private bool presion=false;
	private GameObject cb=null;
	public float velocity=0;
	private Transform transformCamera;
	private Transform transformCopiaBola;
	private float potencia=0;
	void Start () {

		tf=GetComponent<Transform>();
		rb=GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.Mouse0)){
			presion=true;
			potencia+=300.0f*Time.deltaTime;
			//print("potencia "+potencia);

		    }
		if(Input.GetKeyUp(KeyCode.Mouse0)&&presion){
			cb=Instantiate(bola,tf.position,tf.rotation);
			cb.GetComponent<Bola>().setPotencia=potencia;
			print("pot "+potencia);

			presion=false;
		}


	

	}
	void FixedUpdate(){
		if(rb.transform.position.x-tf.transform.localScale.x<limiteSuperior.position.x){

			direccion=-1;
		}else if(rb.transform.position.x+tf.transform.localScale.x>limiteInferior.position.x){
			direccion=1;
		}
		rb.transform.Translate(Vector3.right*velocity*Time.deltaTime*direccion,Space.Self);
	}

		
	
}