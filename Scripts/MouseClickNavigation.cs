using UnityEngine;
using System.Collections;

public class MouseClickNavigation : MonoBehaviour {

	//Click to navigate script, path finding agent targets mouse click location
	//Uses Unity's NavMesh Agent

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

	IEnumerator UpdatePath()
	{
		float refreshRate = .25f;


			pathfinder.SetDestination(target);

			yield return new WaitForSeconds(refreshRate);


	}
}
