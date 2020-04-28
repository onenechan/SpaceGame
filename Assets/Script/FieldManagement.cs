using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FieldManagement : MonoBehaviour {
   
    private float timer;
    public GameObject player;
    public GameObject H2A_SRB_R;
    public GameObject H2A_SRB_L;
    public GameObject luncher;
    public GameObject fire;
    public GameObject enemy_generater1;
    public GameObject enemy_generater2;
    public GameObject gameover;
    Rigidbody2D luncher_rb;

    Animation H2A_SRB_R_anim;
    Animation H2A_SRB_L_anim;

    //グローバルのタイマー禁止！

    enum Phase {
        SETUP,
        LAUNCH,　//ロケット発射
        STAGE1,　//SRB分離まで
        STAGE2,　//フェアリング分離まで
        STAGE3,　//1段目分離まで
    }
    Phase phase;

    void Start () { //GetCompはここ
        luncher_rb = luncher.GetComponent<Rigidbody2D>();
        H2A_SRB_R_anim = H2A_SRB_R.gameObject.GetComponent<Animation>();
        H2A_SRB_L_anim = H2A_SRB_L.gameObject.GetComponent<Animation>();

        phase = Phase.SETUP;
    }
	
	// Update is called once per frame
	void Update () {
        switch (phase)
        {
            case Phase.SETUP:
                SETUPPhase();
                break;
            case Phase.LAUNCH:
                LAUNCHPhase();
                break;
            case Phase.STAGE1:
                STAGE1Phase();
                break;
            case Phase.STAGE2:
                STAGE2Phase();
                break;
            case Phase.STAGE3:
                STAGE3Phase();
                break;
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

    public void SETUPPhase() {
        luncher_rb.simulated = false;
        fire.SetActive(false);
        enemy_generater1.SetActive(false);
        enemy_generater2.SetActive(false);
        player.SetActive(true);
        gameover.SetActive(false);
        phase = Phase.LAUNCH;
    }

    public void LAUNCHPhase(){
        luncher_rb.simulated = true;
        fire.SetActive(true);
        enemy_generater1.SetActive(true);
        enemy_generater2.SetActive(true);
    }

    public void STAGE1Phase(){
        if (Input.GetKey(KeyCode.Space))
        {
            H2A_SRB_R_anim.Play();
            H2A_SRB_L_anim.Play();
        }
    }

    public void STAGE2Phase(){
    }

    public void STAGE3Phase(){
    }
}
