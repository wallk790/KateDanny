using UnityEngine;
using System.Collections;

public class MoveCursor : MonoBehaviour {


	
	public float speed;
	public bool fakeClick;

	void Update () {

		Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += move * speed * Time.deltaTime;
	
		if(Input.GetButtonDown("AButton")){
			// simulate a mouse press
			//parent other object to this transform
		}
	}
}
