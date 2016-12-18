using UnityEngine;
using System.Collections;

public class PaddleCollider : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision) {
		print("Something hit me.");
	}
}
