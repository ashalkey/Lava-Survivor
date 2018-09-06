using UnityEngine;
using System.Collections;

public class ItemPickUpAudio : MonoBehaviour {

	// Use this for initialization
    public void OnCollisionExit(Collision col)
    {
        if(col.gameObject.tag == "Score")
        {
            Debug.Log("I'm no longer on the object");
            GetComponent<AudioSource>().enabled = true;
        }
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
