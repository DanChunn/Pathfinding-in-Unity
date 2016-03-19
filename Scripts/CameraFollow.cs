using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	//Camera Follows Player Script

	Camera cam;
	Transform target;
	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera> ();
		target = GameObject.FindGameObjectWithTag("Player").transform;
		if (cam == null) {
			Debug.LogError ("Camera not found!");
		}
		if (target == null) {
			Debug.LogError ("Player not found!");
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		cam.transform.position = new Vector3(target.position.x, target.position.y+20f, target.position.z);
	}
}
