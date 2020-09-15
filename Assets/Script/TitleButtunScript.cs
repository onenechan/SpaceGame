using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtunScript : MonoBehaviour {

    public AudioClip se1;
    AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void H2Abutton() {
        SceneManager.LoadScene("game_h2a");
        audioSource.PlayOneShot(se1);
    }
    public void EpsilonButton() {
        SceneManager.LoadScene("game_epsilon");
        audioSource.PlayOneShot(se1);
    }
}
