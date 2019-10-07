using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGenerate : MonoBehaviour {

    public GameObject enemy;
    float timer;
    float interval = 3.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > interval) {
            transform.position = new Vector2(Random.Range(-5.0f, 5.0f), transform.position.y);
            Instantiate(enemy, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
