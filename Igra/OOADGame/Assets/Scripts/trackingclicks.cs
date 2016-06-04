using UnityEngine;
using System.Collections;

public class TrackingClicks : MonoBehaviour {

	public static int totalclicks=0;
	public KeyCode mouseclick;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (mouseclick))
		{
			totalclicks += 1;


		}

		if (totalclicks >= 3) 
		{
            ObserverScript.score -= 90;
			totalclicks = 0;
		}
	
	}
}
