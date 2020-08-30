using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoonFaildScript : MonoBehaviour {
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "satellite"){
            SceneManager.LoadScene("title");
        }
    }
}
