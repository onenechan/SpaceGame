using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
    public static int playerHP;
    public float speed;
    public Text HP;

	// Use this for initialization
	void Start () {
        playerHP = 3;
	}
	
	// Update is called once per frame
	void Update () {
        Player_move();
        HP.text = "Rocket HP:" + playerHP.ToString();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy") {
            Debug.Log("hit");
            playerHP--;
            Destroy(col.gameObject);

        }
    }

    private void Player_move()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
