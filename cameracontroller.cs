using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour {
	public GameObject player;//reference to the player
	// Use this for initialization
	private Vector3 offset;
	void Start () {
		offset = transform.position - player.transform.position;//difference between player and camera position
	}
	
	// Update is called once per frame
	void LateUpdate () {//for camera position and all it is best to use late update.
		transform.position = player.transform.position + offset;//camera will move to a position as we move the ball. 
	}
}
