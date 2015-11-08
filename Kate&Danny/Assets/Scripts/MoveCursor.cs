using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MoveCursor : MonoBehaviour {



	public float speed;
	
	void Update () {

		if(gameObject.tag == "RED"){
		Vector3 move = new Vector3(Input.GetAxis("Horizontal1"), Input.GetAxis("Vertical1"), 0);
		transform.position += move * speed * Time.deltaTime;
		}

		if(gameObject.tag == "BLUE"){
			Vector3 move = new Vector3(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"), 0);
			transform.position += move * speed * Time.deltaTime;
		}



	}
}
