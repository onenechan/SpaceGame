using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtunScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void H2Abutton() {
        SceneManager.LoadScene("game_h2a");
    }
    public void EpsilonButton() {
        SceneManager.LoadScene("game_epsilon");
    }
}
