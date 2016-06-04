using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObserverScript : MonoBehaviour {
	public static bool gamestart;
	public static  SceneController main;
	public static int MaxTXT=6;
	public static int freeSpot;
	public  static  hintmeter hint;

	public static int score ;
    public static float time;
    public static float timebonus;
	public static int totalclicks;
	public KeyCode mouseclick;
	public static bool gameFinished ;


	public static string pause="n";

	// Use this for initialization
	void Start () {
        score = 0;
        totalclicks = 0;
        gameFinished = false;
        gamestart = true;
        time = 180;
        timebonus = time / 2;
		main=GameObject.FindWithTag("GameController").GetComponent<SceneController> ();
		hint=GameObject.FindWithTag("Hint").GetComponent<hintmeter> ();
		freeSpot = -1;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (main.obj.Count == 0)
			gameFinished = true;
		if (pause=="n" && timebonus>0)timebonus -= Time.deltaTime;
        if (pause == "n" && time > 0) time -= Time.deltaTime;


        if (main.obj.Count == 0 && timebonus >= 0) {
			score += 5 * Mathf.RoundToInt (timebonus);
			timebonus = 0;
		}

		if (Input.GetKeyDown (mouseclick))
		{
			totalclicks ++;
			
			
		}
		
		if (totalclicks == 5) 
		{

            if(pause == "n") ObserverScript.score -= 100;
		}

	
	}
}
