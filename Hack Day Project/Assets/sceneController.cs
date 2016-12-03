using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnStartClicked()
    {
        Debug.Log("Start Button Clicked");
    }

    public void OnHighScoreClicked()
    {
        Debug.Log("HighScore Button Clicked");
    }

    public void OnQuitClicked()
    {
        Debug.Log("Quit button clicked");
    }
}

