using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

	public float speed;//public so that it is shown in inspector to chnge there itself otherwise we need to open the script again and change.
	public Text countText;
	private Rigidbody rb;//for creating  reference to the rigidbody;
	private int count;//for counting the cubes we have collected;
	public Text WinText;

	void Start(){
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		WinText.text = "";
	}
	void FixedUpdate()
	{
		float movehorizontal = Input.GetAxis ("Horizontal");
		float movevertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (movehorizontal,0.0f, movevertical);/*determines the direction of force on body ...x is horizontal,z
																	is vertical and y=0 as we do not want to move up*/
		rb.AddForce (movement * speed);
	}
	void OnTriggerEnter(Collider other)
	{
		//Destroy(other.gameObject); here we do not destroy instead we deactivate the other object the game object will touch.
		if (other.gameObject.CompareTag ("pick up"))
		{
			other.gameObject.SetActive (false);
			count++;
			SetCountText ();
		}

	}
	void SetCountText()
	{
		countText.text = "Count : " + count.ToString ();
		if (count >= 11)
		{
			WinText.text="You Win";
		}
	}
}
