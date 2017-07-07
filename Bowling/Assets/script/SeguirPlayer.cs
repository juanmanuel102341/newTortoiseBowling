
using UnityEngine;

public class SeguirPlayer : MonoBehaviour {

	public Transform transformSpawn;
	private Transform cameraTransform;
	void Awake () {

		cameraTransform=GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		cameraTransform.position=new Vector3(transformSpawn.position.x,cameraTransform.position.y,cameraTransform.position.z);
	}
}
