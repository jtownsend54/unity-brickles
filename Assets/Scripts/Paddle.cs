using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	private float mousePosX;
	private Vector3 mousePos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mousePosX = Mathf.Clamp(Input.mousePosition.x / Screen.width * 16, 1.5f, 14.5f);
		mousePos = new Vector3(mousePosX, this.transform.position.y, 0f);

		this.transform.position = mousePos;
	}
}
