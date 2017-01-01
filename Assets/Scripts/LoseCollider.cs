using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	private LevelManager manager;

	void OnCollisionEnter2D(Collision2D collision) {
		print("Collision Enter");
		manager = GameObject.FindObjectOfType<LevelManager>();
		manager.LoadLevel("Lose");
	}

//	Trigger ignores physics, so there is no collision. We get a collider instead. (what hit it?)
//	void OnTriggerEnter2D(Collider2D colider) {
//		print("Colider Enter");
//	}
}
