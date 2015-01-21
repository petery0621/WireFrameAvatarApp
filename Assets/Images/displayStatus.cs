using UnityEngine.UI; // Must include to change color.
using UnityEngine;
using System.Collections;

public class displayStatus : MonoBehaviour {

	ArrayList bodyStorage;
	Text instruction;
	string defaultText;



	// Use this for initialization
	void Start () {
		instruction = this.GetComponent<Text>();
		bodyStorage = new ArrayList ();
		instruction.text = "I CAN CHANGE THIS";
		defaultText = "Body Parts that are injured: " + bodyStorage.Count + "\n";
	}
	
	// Update is called once per frame
	void Update () {

		string updatedText = defaultText;

		for (int i = 0; i < bodyStorage.Count; i++) {

			updatedText = updatedText + bodyStorage[i].ToString() + "\n";

				}

		instruction.text = updatedText;
	
	}

	public void updateStatus (string name)
	{
		Debug.Log ("Recieved update req from: " + name);
		bodyStorage.Add (name);
	

	}

	public void removeStatus (string name)
	{
		Debug.Log ("Recieved remove req from: " + name);
		bodyStorage.Remove (name);

	
	}
}
