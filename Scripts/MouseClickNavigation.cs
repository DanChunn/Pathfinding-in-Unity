using UnityEngine;
using System.Collections;

/*
    Attach to an object with the NavMeshAgent component.
    Use the mouse to move in the world space.

*/


public class MouseClickNavigation : MonoBehaviour {

	NavMeshAgent pathfinder;
	Vector3 target;

	void Awake () {
		pathfinder = GetComponent<NavMeshAgent>();
	}
	
	void Update () {
		if (Input.GetMouseButton (0)) {
			target =  new Vector3 (Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 0, Camera.main.ScreenToWorldPoint(Input.mousePosition).z);
			Debug.Log ("Target Destination: "+target);
			StartCoroutine(UpdatePath());
		}
			
	}

/*

    Updates the NavMeshAgent's destination
    
*/

	IEnumerator UpdatePath()
	{
		float refreshRate = .25f;

			pathfinder.SetDestination(target);

			yield return new WaitForSeconds(refreshRate);

	}
}
