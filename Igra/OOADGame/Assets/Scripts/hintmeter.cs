using UnityEngine;
using System.Collections;

public class hintmeter : MonoBehaviour {

	public float rb=1f;
	public float colortimer=0;
    public float delay;

    public  string hintready ="n";
	public  string hintused = "n";
	public int hintObj;

	public Transform hintglow;

	// Use this for initialization
	void Start () {
		hintglow.GetComponent<ParticleSystem>().enableEmission = false;
        delay = .05f;


    }
	
	// Update is called once per frame
	void Update () {
		colortimer += Time.deltaTime;

		if ((colortimer >= .5) && (rb>0))
		{
			rb -= delay;
			if (ObserverScript.pause=="y")rb += delay;
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
			hintObj=Random.Range(0,ObserverScript.main.obj.Count);
            delay /= 2;


		}
	}
}
