using UnityEngine;
using System.Collections;

public class singlePart : MonoBehaviour {

	bool toggle; // 0 for not clicked, 1 for clicked. Simple.

	// Use this for initialization
	void Start () {
		Debug.Log ("This object: " + this.name + " status is: " + toggle);
		toggle = false; // set to false on init.

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void printStatus()
	{
		Debug.Log ("This object: " + this.name + " status is: " + toggle);

    }

	public void onSelect() // when button is pressed, run this method. 
	{
		toggle = !toggle; // swaps the value.
		Debug.Log ("This object: " + this.name + " was just pressed!");
		// change color of object here.

		if (toggle)
			this.transform
		else
		this.renderer.material.color = Color.clear;
		
	}

	// Accessor Method

	public bool getStatus()
	{
		return toggle; 
	}

}
