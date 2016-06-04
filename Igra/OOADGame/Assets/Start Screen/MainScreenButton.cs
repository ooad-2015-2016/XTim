using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainScreenButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        if (gameObject.name.Contains("Play"))
        {
            SceneManager.LoadScene(1); SceneManager.SetActiveScene(SceneManager.GetSceneAt(1));
        }
        if (gameObject.name.Contains("Quit"))
        {
            Application.Quit();
        }
       
    }

}
