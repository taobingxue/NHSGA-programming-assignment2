using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
	// These variables are just reminder and for your convenient, delete them if you want to.
	public int speed;
	public GameObject platform;
	bool start = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && start == false) {
			/*
			 * To Do:
			 *    Let the Ball start move corectly when press space.
			 * 
			 */
		}

		if (transform.position.z < -12) {
			/*
			 * To Do:
			 *    Replace the Ball to the top of platform when the player lose.
			 * 
			 */
		}
	}
}
