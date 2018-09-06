using UnityEngine;
using System.Collections;

public class TranslatePlatform : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //transform.Translate(Vector3.forward*5*Time.deltaTime);
        GetComponent<Rigidbody>().MovePosition(transform.position + transform.forward * 5 * Time.deltaTime);
	}
}
