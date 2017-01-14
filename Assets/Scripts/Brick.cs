using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public Sprite[] hitSprites;
	public static int breakableCount = 0;
	public AudioClip crack;
	public GameObject smoke;

	private int hits;
	private LevelManager manager;
	private bool isBreakable;

	// Use this for initialization
	void Start () {
		hits 	= 0;
		manager = GameObject.FindObjectOfType<LevelManager>();
		isBreakable = (this.tag == "unbreakable");
		//smoke.transform.position.y = this.transform.position.y;
		//smoke.transform.position.x = this.transform.position.x;
		breakableCount++;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D collision) {
		hits++;
//		AudioSource.PlayClipAtPoint(crack, transform.position);

		// Do not do anything with this brick
		if (isBreakable) {
			return;
		}

		if (hits >= hitSprites.Length + 1) {
			smoke.particleSystem.startColor = this.GetComponent<SpriteRenderer>().color;
			Instantiate(smoke, gameObject.transform.position, Quaternion.identity);
			breakableCount--;
			Destroy(gameObject);

			manager.BrickDestroyed();
		} else {
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[hits - 1];
		}
	}

	void CreateSmoke() {

	}

	void SimulateWin() {
		manager.LoadNextLevel();
	}
}
