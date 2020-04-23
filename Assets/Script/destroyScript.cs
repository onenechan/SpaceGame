using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyScript : MonoBehaviour {
    public void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
    }
}
