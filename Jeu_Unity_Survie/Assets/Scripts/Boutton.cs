using UnityEngine;
using System.Collections;

public class Boutton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		if (GUI.Button (new Rect (Screen.width / 2, Screen.height / 2, 50, 50), "Button")) 
		{
			Debug.Log ("Yo");
		}
	}
}
