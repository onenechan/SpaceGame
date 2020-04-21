using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldManagement : MonoBehaviour {
   
    private float timer;
    public GameObject luncher;
    public GameObject fire;
    Rigidbody2D luncher_rb;
	
	void Start () {
        luncher_rb = luncher.GetComponent<Rigidbody2D>();
        luncher_rb.simulated = false;
        fire.SetActive(false);


    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= 3) {
            luncher_rb.simulated = true;
            fire.SetActive(true);
        }
	}
}
