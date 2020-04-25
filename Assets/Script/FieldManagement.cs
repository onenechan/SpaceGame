using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FieldManagement : MonoBehaviour {
   
    private float timer;
    public GameObject player;
    public GameObject luncher;
    public GameObject fire;
    public GameObject enemy_generater1;
    public GameObject enemy_generater2;
    public GameObject gameover;
    Rigidbody2D luncher_rb;
	
	void Start () {
        luncher_rb = luncher.GetComponent<Rigidbody2D>();
        luncher_rb.simulated = false;
        fire.SetActive(false);
        enemy_generater1.SetActive(false);
        enemy_generater2.SetActive(false);
        player.SetActive(true);
        gameover.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= 3) {
            luncher_rb.simulated = true;
            fire.SetActive(true);
            enemy_generater1.SetActive(true);
            enemy_generater2.SetActive(true);
        }
        if(PlayerScript.playerHP == 0)
        {
            player.SetActive(false);
            gameover.SetActive(true);
        }
        if (Input.GetKey(KeyCode.R)) {
            SceneManager.LoadScene("title");
        }
	}
}
