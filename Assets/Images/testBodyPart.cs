using UnityEngine;
using System.Collections;

public class testBodyPart : MonoBehaviour {

	public GameObject[] bodyParts;

	// Use this for initialization
	void Start () {

		bodyParts = GameObject.FindGameObjectsWithTag("bodyPart"); // array of bodyParts searches for everything with the tag, "bodyPart"

		Debug.Log ("Number of body parts registered: " + bodyParts.Length);

		for(int i = 0; i < bodyParts.Length; i++)
		{
			Debug.Log(bodyParts[i].name);
		}
	}
	
	// Update is called once per frame
	void Update () {

		// Debug.Log ("Number of body parts registered: " + bodyParts.Length);

		// Debug.Log ("Message recieved from: "); // when a limb is toggled on and off, we want to know.
	
	}

	void showCurrentState() // used to print out current state of the body.
	{

	}

	public void onPress()
	{
		Debug.Log ("Message recieved from: " + this.name);
}
}
