using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RisingLava : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
	
	}

    
	void FixedUpdate () {
        gameObject.transform.Translate(Vector3.up*speed*Time.deltaTime);
	}

    
}
