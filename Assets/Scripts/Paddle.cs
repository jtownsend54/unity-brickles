using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	public bool autoPlay = false;

	private float mousePosX;
	private Vector3 mousePos;
	private Ball ball;

	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
	}

	// Update is called once per frame
	// Mouse Position and Ball position are not measured in the same units, 
	// which is why the mouse position needs to be converted into game units
	void Update () {
		float xPos = Input.mousePosition.x / Screen.width * 16;

		// Automatically move paddle with ball
		if(autoPlay) {
			xPos = ball.transform.position.x;
		}

		UpdatePaddlePos(xPos);
	}

	void UpdatePaddlePos(float xPos) {
		mousePosX = Mathf.Clamp(xPos, 1.5f, 14.5f);
		mousePos = new Vector3(mousePosX, this.transform.position.y, 0f);
		
		this.transform.position = mousePos;
	}
}
