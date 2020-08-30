using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clear1Script : MonoBehaviour {

    public GameObject rankS;
    public GameObject rankA;
    public GameObject rankB;
    public GameObject rankC;
    public GameObject tweetbutton;
    float timer;
    // Use this for initialization
    void Start () {
        timer = 0;
        rankS.SetActive(false); rankA.SetActive(false); rankB.SetActive(false); rankC.SetActive(false); tweetbutton.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(PlayerScript.playerHP);
        timer += Time.deltaTime;
        if(timer >= 15)
        {
            tweetbutton.SetActive(true);
            if (PlayerScript.playerHP == 5)
            {
                rankS.SetActive(true);
            }
            if (PlayerScript.playerHP == 4)
            {
                rankA.SetActive(true);
            }
            if (PlayerScript.playerHP == 3)
            {
                rankB.SetActive(true);
            }
            if (PlayerScript.playerHP == 2)
            {
                rankB.SetActive(true);
            }
            if (PlayerScript.playerHP == 1)
            {
                rankC.SetActive(true);
            }
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("title");
        }
    }

    public void tweetbuttun()
    {
        if (PlayerScript.playerHP == 5)
        {
            naichilab.UnityRoomTweet.Tweet("https://unityroom.com/games/rocketadventure", "Sランクでした！君は最高のロケット！", "unityroom", "RocketAdventure");
        }
        if (PlayerScript.playerHP == 4)
        {
            naichilab.UnityRoomTweet.Tweet("https://unityroom.com/games/rocketadventure", "Aランクでした！まだまだ上を目指せるぞ！", "unityroom", "RocketAdventure");
        }
        if (PlayerScript.playerHP == 3)
        {
            naichilab.UnityRoomTweet.Tweet("https://unityroom.com/games/rocketadventure", "Bランクでした！まだまだ上を目指せるぞ！", "unityroom", "RocketAdventure");
        }
        if (PlayerScript.playerHP == 2)
        {
            naichilab.UnityRoomTweet.Tweet("https://unityroom.com/games/rocketadventure", "Bランクでした！もっと訓練が必要だな。", "unityroom", "RocketAdventure");
        }
        if (PlayerScript.playerHP == 1)
        {
            naichilab.UnityRoomTweet.Tweet("https://unityroom.com/games/rocketadventure", "Cランク！もう機体がボロボロだ！！", "unityroom", "RocketAdventure");
        }
    }
}
