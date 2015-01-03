using UnityEngine;
using System.Collections;

public class doSomething : MonoBehaviour {

	public void startGame()
	{
		
		Debug.Log("Let's begin ");
		Application.LoadLevel ("main");
		
	}

	public void exit()
	{
		
		Debug.Log("Let's leave ");
		Application.Quit ();

		}

	public void back()

	{
		Debug.Log("Let's go back to home ");
		Application.LoadLevel("home");

		}


	public void showCredits()
	{
		Debug.Log("Loading Credits Page ");
		Application.LoadLevel ("credits");

	}

	// Use this for initialization
	void Start () {

		Debug.Log("say something when i am made");
	
	}


	
	// Update is called once per frame
	void Update () {



	
	}
}
