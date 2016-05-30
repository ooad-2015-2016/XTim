using UnityEngine;
using System.Collections;

public class hintmeter : MonoBehaviour {

	public float rb=1f;
	public float colortimer=0;

	public static string hintready ="n";
	public static string hintused = "n";

	public Transform hintglow;

	// Use this for initialization
	void Start () {
		hintglow.GetComponent<ParticleSystem>().enableEmission = false;

	}
	
	// Update is called once per frame
	void Update () {
		colortimer += Time.deltaTime;

		if ((colortimer >= .5) && (rb>0))
		{
			rb -= .05f;
			colortimer = 0;
		}

		GetComponent<SpriteRenderer>().color = new Color (rb,1,rb);
		if (rb <= 0)
		{
			hintready = "y";
			hintglow.GetComponent<ParticleSystem>().enableEmission = true;
		}
	}

	void OnMouseDown ()
	{
		if (hintready == "y")
		{
			hintused = "y";
			hintready = "n";
			rb = 1f;
			hintglow.GetComponent<ParticleSystem>().enableEmission = false;
		}
	}
}
