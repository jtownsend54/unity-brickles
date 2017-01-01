using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	private int hits;
	public int maxHits;
	private LevelManager manager;

	// Use this for initialization
	void Start () {
		hits = 0;
		manager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D collision) {
		hits++;

		if(hits >= maxHits) {
			Destroy(gameObject);
		}
	}

	void SimulateWin() {
		manager.LoadNextLevel();
	}
}
