using UnityEngine;
using System.Collections;

public class Player {
	public string name;
	public int score;
	public bool isSolid;
	public bool isPlaying;

	public Player() {
		name = "null";
		score = 0;
		isSolid = true;
		isPlaying = false;
	}
}
