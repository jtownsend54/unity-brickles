using UnityEngine;
using System.Collections;

public class BallCollider : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision) {
		print("I hit something!");
	}
}
