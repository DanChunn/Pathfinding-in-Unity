using UnityEngine;
using System.Collections;

/*
    Attach to main camera to have the
    camera follow the player.

*/

public class CameraFollow : MonoBehaviour {


	Camera cam;
	Transform target;

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
	
	void FixedUpdate () {
		cam.transform.position = new Vector3(target.position.x, target.position.y+20f, target.position.z);
	}
}
