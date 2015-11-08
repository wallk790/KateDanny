using UnityEngine;
using System.Collections;

public class Photo : MonoBehaviour {
	
	void OnTriggerEnter2D (Collider2D other){

		if(other.gameObject.tag == gameObject.tag){
			other.SendMessage ("HiddenText");
			other.transform.position = transform.position;
			Destroy (other.GetComponent<BoxCollider2D>());

		}

	}

}


