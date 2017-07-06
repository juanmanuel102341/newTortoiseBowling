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
	private float potencia=0;
	private Rigidbody rb;
	private bool presion=false;
	private GameObject cb;

	private Transform transformCamera;
	private Transform transformCopiaBola;

	void Start () {
		tf=GetComponent<Transform>();


	}
	
	// Update is called once per frame
	void Update () {
		
		//transformCamera.position.z=tf.position.z;
		tf.Translate(Vector3.right*Time.deltaTime*direccion,Space.Self);
		if(tf.transform.position.x-tf.transform.localScale.x<limiteSuperior.position.x){
	
			direccion=-1;
		}else if(tf.transform.position.x+tf.transform.localScale.x>limiteInferior.position.x){
			direccion=1;
		}

			
		if(Input.GetKeyDown(KeyCode.Mouse0)){
			
			transformCopiaBola=cb.GetComponent<Transform>();
		}
		if(Input.GetKey(KeyCode.Mouse0)){
			presion=true;
			potencia+=300.0f*Time.deltaTime;
			print("potencia "+potencia);
		    }else if(presion){
			cb=Instantiate(bola,tf.position,tf.rotation);
			rb=cb.GetComponent<Rigidbody>();
			rb.AddRelativeForce(Vector3.forward*potencia*1);
			potencia=0;
			presion=false;
				}

		if(cb!=null){
			//Camera cameraBola=CameraBola.GetComponent<Camera>();
			//CameraBola.transform.position=cb.transform.position;
		
				
		}

	

	}
		
	
}