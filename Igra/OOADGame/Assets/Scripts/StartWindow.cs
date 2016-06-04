using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartWindow : MonoBehaviour {
	public Transform pMenuObj;
	public GameObject postitnote1;
	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {
		if (ObserverScript.gamestart) 
		{ObserverScript.pause="y";
			pMenuObj.GetComponent<Transform>().position=new Vector2(1,1);
			
		}
		postitnote1.GetComponent<TextMesh> ().text = "Broj bodova \npo predmetu: \n" + 120+"\n"+"Vremenska granica: \n"+ObserverScript.time/60+ " min";
        if (ObserverScript.gameFinished)
        {
            ObserverScript.pause = "y";
            pMenuObj.GetComponent<Transform>().position = new Vector2(1, 1);
            postitnote1.GetComponent<TextMesh>().text = "Bodovi: \n" + ObserverScript.score.ToString()+ "\nOstalo vremena: \n"+ Mathf.RoundToInt(ObserverScript.time / 60) + " min";
        }

            if (ObserverScript.score < 0 || ObserverScript.time == 0)
            {    
            ObserverScript.gameFinished = true;
            }




        }
		
	
	public void OnClickButton1()
	{ObserverScript.gamestart=false;

		ObserverScript.pause="n";
		pMenuObj.GetComponent<Transform>().position=new Vector2(-17,1);
		if (ObserverScript.gameFinished) 
		{
            ObserverScript.gameFinished = false;
            SceneManager.LoadScene(0); SceneManager.SetActiveScene(SceneManager.GetSceneAt(0));


            
        }
    }
}
