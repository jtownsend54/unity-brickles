using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	private int hits;
	public Sprite[] hitSprites;
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

		if (hits >= hitSprites.Length + 1) {
			Destroy(gameObject);
		} else {
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[hits - 1];
		}
	}

	void SimulateWin() {
		manager.LoadNextLevel();
	}
}
