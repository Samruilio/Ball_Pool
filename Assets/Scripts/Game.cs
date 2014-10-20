using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public Player playerA;
	public Player playerB;

	public GameObject beam;
	public GameObject cue;

	// Use this for initialization
	void Start () {
		playerA = new Player ();
		playerB = new Player ();

		playerA.isPlaying = true;

		playerB.isPlaying = false;
	}
	
	// Update is called once per frame
	void Update () {
		bool isAllSleep = true;
		foreach (Transform child in GameObject.Find("Balls").transform) {
			if(child.rigidbody.angularVelocity.magnitude < child.rigidbody.sleepAngularVelocity){
				child.rigidbody.angularVelocity = Vector3.zero;
			}
			if(child.rigidbody.velocity.magnitude < child.rigidbody.sleepVelocity){
				child.rigidbody.velocity = Vector3.zero;
			}
			isAllSleep &= child.rigidbody.IsSleeping();
		}

		if(isAllSleep){
			showTrajectory();
		}else{
			hideTrajectory();
		}
	}

	void hit(Vector3 direction, float magnitude, Vector3 hitPosition) {
		cue.rigidbody.AddForceAtPosition (direction * magnitude, new Vector3 (0, 0, 0));
	}

	void showTrajectory(){
		LineRenderer lineRenderer = beam.GetComponent ("LineRenderer") as LineRenderer;
		if (cue != null) {
			Vector3 start = cue.transform.position;
			start.y = 0.1f;
			lineRenderer.SetPosition(0, start);
			Vector3 end = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			end.y = 0.1f;
			lineRenderer.SetPosition(1, end);
			
			if(Input.GetMouseButtonDown(0)){
				Vector3 direction = end - start;
				hit (direction.normalized, 1000, new Vector3 (0, 0, 0));
			}
		}
	}

	void hideTrajectory(){
		LineRenderer lineRenderer = beam.GetComponent ("LineRenderer") as LineRenderer;
		lineRenderer.SetPosition(0, Vector3.zero);
		lineRenderer.SetPosition(1, Vector3.zero);
	}
}
