using UnityEngine;
using System.Collections;

public class StartWindowButton : MonoBehaviour {
		public GameObject window;
		
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}
		void OnMouseDown()
		{
			if (gameObject.name.Contains ("button1")) 
			{
				window.GetComponent<StartWindow>().OnClickButton1();
			}
		}
	}
