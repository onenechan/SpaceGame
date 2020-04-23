using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
    int playerHP;
    public Text HP;
    public GameObject gameover;

	// Use this for initialization
	void Start () {
        playerHP = 3;
        gameover.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        HP.text = "Rocket HP:" + playerHP.ToString();
        if (playerHP <= 0) {
            gameover.SetActive(true);
        }
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy") {
            Debug.Log("hit");
            playerHP--;
            Destroy(col.gameObject);

        }
    }
}
