using UnityEngine.UI; // Must include to change color.
using UnityEngine;
using System.Collections;


public class singlePart : MonoBehaviour {

	bool toggle; // 0 for not clicked, 1 for clicked. Simple.
	public GameObject thisButton; // so we can find our own object.

	public Button button;

	// Use this for initialization
	void Start () {

		thisButton = GameObject.Find(this.name); // locate this button, store as gameobject.

		Debug.Log ("This object: " + this.name + " status is: " + toggle);
		toggle = false; // set to false on init.

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void printStatus()
	{
		Debug.Log ("This object: " + this.name + " status is: " + toggle);

	}

	public void onSelect() // when button is pressed, run this method. 
	{
		toggle = !toggle; // swaps the value.
		Debug.Log ("This object: " + this.name + " was just pressed!");

		Image image = thisButton.GetComponent<Image> ();

		if (toggle) {
			GameObject.Find ("DisplayField").SendMessage ("updateStatus", this.name); 
			image.color = Color.red;
						// Debug.Log ("Image color" + image.color.ToString());
				} 
		else {
			GameObject.Find ("DisplayField").SendMessage ("removeStatus", this.name);
			image.color = Color.white;
				}
	
		// this.SendMessageUpwards ("onPress", GameObject.Find("Body"));
		GameObject obj = GameObject.Find ("Body");

		obj.SendMessage ("onPress", this.name);


	}

	// Accessor Method

	public bool getStatus()
	{
		return toggle; 
	}

}
