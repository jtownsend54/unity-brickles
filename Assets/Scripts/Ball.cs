using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Paddle paddle;
	private bool isStarted = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(isStarted) {
			return;
		}

		this.transform.position = new Vector3(paddle.transform.position.x, this.transform.position.y, 0);

		if(Input.GetMouseButtonDown(0)) {
			isStarted = true;
			this.rigidbody2D.velocity = new Vector2(2f, 10f);
		}
	}
}
