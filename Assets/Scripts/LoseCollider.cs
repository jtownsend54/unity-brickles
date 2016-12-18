using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	public LevelManager manager;

	void OnCollisionEnter2D(Collision2D collision) {
		print("Collision Enter");
		manager.LoadLevel("Win");
	}

//	Trigger ignores physics, so there is no collision. We get a collider instead. (what hit it?)
//	void OnTriggerEnter2D(Collider2D colider) {
//		print("Colider Enter");
//	}
}
