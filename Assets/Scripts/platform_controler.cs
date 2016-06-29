using UnityEngine;
using System.Collections;

public class platform_controler : MonoBehaviour {
	// These variables are just reminder and for your convenient, delete them if you want to.
	public int platform_speed;
	public float limit_l, limit_r;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			/*
			 * To Do:
			 * 	  Move the platform left when the player is pressing left arrow.
			 * 
			 *    You can use the given platform_speed and Time.deltaTime, or anything  you want.
			 * 
			 *
			 *
			 */
		} 

		/*
		 * To Do:
		 * 	  1. Move the platform right when the player is pressing right arrow.
		 *    2. Don't forget to check the boundary after you move the platform!
		 * 
		 */
	}
}
