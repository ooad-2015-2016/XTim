using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseWindow : MonoBehaviour {
	public KeyCode pauseclick;
	public Transform pMenuObj;
	public GameObject postitnote1;
	public GameObject postitnote2;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (pauseclick)) 
		{
			ObserverScript.pause="y";
			pMenuObj.GetComponent<Transform>().position=new Vector2(1,1);

		}
		postitnote1.GetComponent<TextMesh> ().text = "Bodovi: \n" + ObserverScript.score.ToString ();
        postitnote2.GetComponent<TextMesh>().text = "Ostalo vremena: \n" + Mathf.RoundToInt(ObserverScript.time/60).ToString()+" min";


    }
	public void OnClickButton1()
	{ObserverScript.pause="n";
		pMenuObj.GetComponent<Transform>().position=new Vector2(-17,1);}
	public void OnClickButton2(){
        SceneManager.LoadScene(0); SceneManager.SetActiveScene(SceneManager.GetSceneAt(0)); }
}
