using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public int score;

	public void OnHitEnemy() {
		score += 15;
	}

	void Update () {
		TextMesh mesh = GetComponent<TextMesh> ();
		mesh.text = "" + score;
	}
}
