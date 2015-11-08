using UnityEngine;
using System.Collections;

public class Reveal : MonoBehaviour {

	public SpriteRenderer text;

	void HiddenText (){
		GetComponent<SpriteRenderer>().enabled = false;
		text.enabled = true;
		if (Application.loadedLevel == 0 || Application.loadedLevel == 1){
		    Invoke("LoadNext",2f);
	}
	}


	void LoadNext (){
		Application.LoadLevel(Application.loadedLevel + 1);
	}

}
