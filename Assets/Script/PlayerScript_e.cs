using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript_e : MonoBehaviour
{
    public static int playerHP;
    public float speed;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;
    public GameObject heart; //portion


    void Start()
    {
        playerHP = 3;
        heart1.SetActive(true);
        heart2.SetActive(true);
        heart3.SetActive(true);
    }

    void Update()
    {
        if (FieldManagement.flag < 2)
        {
            Player_move(); //flagを2にしたら動かない
            Debug.Log(playerHP);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            playerHP--;
        }
        if (col.gameObject.tag == "portion")
        {
            if (playerHP < 3)
            {
                playerHP++;
            }
        }

        if (playerHP == 5)
        {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
            heart4.SetActive(true);
            heart5.SetActive(true);
        }
        if (playerHP == 4)
        {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
            heart4.SetActive(true);
            heart5.SetActive(false);
        }
        if (playerHP == 3)
        {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
            heart4.SetActive(false);
            heart5.SetActive(false);
        }
        else if (playerHP == 2)
        {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(false);
            heart4.SetActive(false);
            heart5.SetActive(false);
        }
        else if (playerHP == 1)
        {
            heart1.SetActive(true);
            heart2.SetActive(false);
            heart3.SetActive(false);
            heart4.SetActive(false);
            heart5.SetActive(false);
        }
        else if (playerHP == 0)
        {
            heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(false);
            heart4.SetActive(false);
            heart5.SetActive(false);
        }
        Destroy(col.gameObject);
    }

    private void Player_move()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x >= -6)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x <= 6)
                transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
