using UnityEngine;
using System.Collections;

public class PocketBehaviour : MonoBehaviour {

	public Game game;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		game.playerA.score += 1;
	}
}
