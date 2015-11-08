using UnityEngine;
using System.Collections;

public class Texts : MonoBehaviour {

	public GameObject [] text1; 
	public Transform [] TextMessages;
	//public float messagePosition;
	private int currentText = 0;
	private int currentPosition = 0;

	// Use this for initialization
	void Start () {
		//text1 = GameObject.FindGameObjectsWithTag ("message");

	//	messagePosition = 50.0f;
	}
	
	// Update is called once per frame
	void Update () {

		//if (Input.GetMouseButtonDown(0)) {
		if (Input.GetKeyDown("space")){
//			for(int i = 0; i < text1.Length; i++) {
//			Instantiate(text1[i], TextMessages.position, TextMessages.rotation);
//			Debug.Log ("text appeared");
			instantiateNextText();
		}
	}
	
	void instantiateNextText() {
		Instantiate(text1[currentText], TextMessages[currentPosition].transform.position, TextMessages[currentPosition].transform.rotation);
		currentText++;
		currentPosition++;
		currentText = currentText % text1.Length;
		currentPosition = currentPosition % TextMessages.Length;

	}
}
