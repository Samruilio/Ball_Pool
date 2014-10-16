using UnityEngine;
using System.Collections;

public class Reset_Balls : MonoBehaviour {

	public GameObject[] ballArray;
	public GameObject cueBall;

	// Use this for initialization
	void Start () {
		reset ();
		hit ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void reset() {
		Collider collider = cueBall.collider;
		float radius = ((SphereCollider)collider).radius * 0.7f;
		float y = this.transform.position.y;

		cueBall.transform.position = new Vector3 (cueBall.transform.position.x, 
		                                          y + radius, 
		                                          cueBall.transform.position.z);

		Vector3 start = GameObject.Find ("Anchor").transform.position;

		ballArray[0].transform.position = new Vector3 (start.x, y + radius, start.z);

		ballArray[1].transform.position = new Vector3 (start.x + 1.732f * radius, y + radius, start.z - radius);
		ballArray[2].transform.position = new Vector3 (start.x + 1.732f * radius, y + radius, start.z + radius);

		ballArray[3].transform.position = new Vector3 (start.x + 2 * 1.732f * radius, y + radius, start.z - 2 * radius);
		ballArray[4].transform.position = new Vector3 (start.x + 2 * 1.732f * radius, y + radius, start.z);
		ballArray[5].transform.position = new Vector3 (start.x + 2 * 1.732f * radius, y + radius, start.z + 2 * radius);

		ballArray[6].transform.position = new Vector3 (start.x + 3 * 1.732f * radius, y + radius, start.z - 3 * radius);
		ballArray[7].transform.position = new Vector3 (start.x + 3 * 1.732f * radius, y + radius, start.z - radius);
		ballArray[8].transform.position = new Vector3 (start.x + 3 * 1.732f * radius, y + radius, start.z + radius);
		ballArray[9].transform.position = new Vector3 (start.x + 3 * 1.732f * radius, y + radius, start.z + 3 * radius);

		ballArray[10].transform.position = new Vector3 (start.x + 4 * 1.732f * radius, y + radius, start.z - 4 * radius);
		ballArray[11].transform.position = new Vector3 (start.x + 4 * 1.732f * radius, y + radius, start.z - 2 * radius);
		ballArray[12].transform.position = new Vector3 (start.x + 4 * 1.732f * radius, y + radius, start.z);
		ballArray[13].transform.position = new Vector3 (start.x + 4 * 1.732f * radius, y + radius, start.z + 2 * radius);
		ballArray[14].transform.position = new Vector3 (start.x + 4 * 1.732f * radius, y + radius, start.z + 4 * radius);
	}

	void hit() {
		cueBall.rigidbody.AddForceAtPosition (new Vector3 (1000, 0, 0), new Vector3 (0, 0, 1.4f));
	}
}
