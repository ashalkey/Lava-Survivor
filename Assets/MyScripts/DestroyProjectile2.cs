﻿using UnityEngine;
using System.Collections;

public class DestroyProjectile2 : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject)
        {
            Destroy(gameObject);

        }
        if (col.gameObject.tag == "MovingPlatform")
        {
            if (col.gameObject.GetComponent<TranslatePlatform>().enabled == true)
                col.gameObject.GetComponent<TranslatePlatform>().enabled = false;
            else col.gameObject.GetComponent<TranslatePlatform>().enabled = true;

        }


    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
