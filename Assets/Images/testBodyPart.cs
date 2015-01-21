
using UnityEngine;
using System.Collections;

public class testBodyPart : MonoBehaviour {

	public GameObject[] bodyParts; // will use now for sake of seeing product

	public bodyPart[] bodyParts2; // i should use this eventually

	IEnumerator MyMethod() {
		Debug.Log("Before Waiting 2 seconds");
		yield return new WaitForSeconds(2);
		Debug.Log("After Waiting 2 Seconds");
	}

	// Use this for initialization
	void Start () {

		bodyParts = GameObject.FindGameObjectsWithTag("bodyPart"); // array of bodyParts searches for everything with the tag, "bodyPart"

		Debug.Log ("Number of body parts registered: " + bodyParts.Length);

		for(int i = 0; i < bodyParts.Length; i++)
		{
			Debug.Log(bodyParts[i].name);
			 // set them initially to off. can set individual ones if we have a preset file
		}
	}
	
	// Update is called once per frame
	void Update () {



		Debug.Log ("Number of body parts registered: " + bodyParts.Length);

		// Debug.Log ("Message recieved from: "); // when a limb is toggled on and off, we want to know.

		/*
		for(int i = 0; i < bodyParts.Length; i++)
		{
			GameObject obj = GameObject.Find(bodyParts[i].name);
			obj.SendMessage("printStatus");
		}
		*/

	
	}

	// StartCoroutine (MyMethod ());

	
	public void onPress(string obj)
	{
		Debug.Log ("Update: " + obj + " has status updated.");


     }



	public void printAllStatus()
	{
		for(int i = 0; i < bodyParts.Length; i++)
		{
			bodyParts[i].SendMessage("printStatus");
			// if the status happens to be true, the gameobject will update the textfield array.

	}
}

}