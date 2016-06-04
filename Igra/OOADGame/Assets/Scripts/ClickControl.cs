using UnityEngine;
using System.Collections;

public class ClickControl : MonoBehaviour {
	
	public GameObject objnametext;
	public Transform sucessclick;
	public Transform Hintglow;
	bool isUsable=false;


	// Use this for initialization
	void Start () {
		Hintglow.GetComponent<ParticleSystem>().enableEmission = false;


	
	}
	
	// Update is called once per frame
	void Update () {
		//osnovno
		if (ObserverScript.main.obj.Contains (gameObject)) {

			
			isUsable = true;
			objnametext = ObserverScript.main.txtobj [ObserverScript.main.obj.IndexOf (gameObject)] as GameObject;
				objnametext.GetComponent<TextMesh> ().text = this.GetComponent<ObjectInfo> ().ObjectName;

		}
			//za hint
			if (ObserverScript.hint.hintused == "y" && ObserverScript.main.obj [ObserverScript.hint.hintObj] == gameObject) {
				Hintglow.transform.position = Vector3.MoveTowards (Hintglow.transform.position, gameObject.transform.position, 20 * Time.deltaTime);



                Hintglow.GetComponent<ParticleSystem> ().enableEmission = true;
				//if (Hintglow.transform.position==gameObject.transform.position){ ObserverScript.hint.hintused="n";}

			}
	
		if (ObserverScript.pause == "y")
			gameObject.GetComponent<BoxCollider> ().enabled = false;
		if (ObserverScript.pause == "n")
			gameObject.GetComponent<BoxCollider> ().enabled = true;
	}

	void OnMouseDown()

	{ if (isUsable) {
			ObserverScript.hint.hintused="n";
			ObserverScript.score+=150;
			Hintglow.GetComponent<ParticleSystem>().enableEmission = false;
			Destroy (gameObject);
			objnametext.GetComponent<TextMesh> ().text ="";
			isUsable=false;
			ObserverScript.main.obj.Remove(gameObject);
			ObserverScript.main.txtobj.Remove(objnametext);
			ObserverScript.totalclicks = 0;
			Instantiate (sucessclick, objnametext.transform.position, sucessclick.rotation);
		}
	}

}
