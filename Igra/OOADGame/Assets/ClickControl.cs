using UnityEngine;
using System.Collections;

public class ClickControl : MonoBehaviour {

	public static string nameofobj;
	public GameObject objnametext;
	public Transform objnametextPos;
	public Transform sucessclick;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()

	{
		nameofobj = gameObject.name;
		//Debug.Log (nameofobj);
		Destroy (gameObject);
		Destroy (objnametext);
		TrackingClicks.totalclicks = 0;
		Instantiate (sucessclick, objnametextPos.position, sucessclick.rotation);
	}
}
