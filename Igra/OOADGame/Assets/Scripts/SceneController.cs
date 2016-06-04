using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SceneController : MonoBehaviour {
	public  List<GameObject> obj = new List<GameObject> ();
	public  List<int> rand=new List<int>();
	public  List<GameObject> txtobj= new List<GameObject> ();

	// Use this for initialization
	void Start () {
		int buffer;
		for(int i=0;i<6;i++) 
		{
			buffer=Random.Range(1,21);
			if(!rand.Contains(buffer))rand.Add(buffer);
			else i--;
		}
		for (int i=0; i<6; i++) 
		{
			obj.Add (GameObject.Find ("Object" + rand [i].ToString ()));
		}
		for (int i=0; i<6; i++)
		{
			txtobj.Add (GameObject.Find ("Object" + (i+1).ToString ()+"txt"));

		}
		    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
