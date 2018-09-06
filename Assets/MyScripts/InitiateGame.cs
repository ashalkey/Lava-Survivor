using UnityEngine;
using System.Collections;

public class InitiateGame : MonoBehaviour {
    public GameObject Lava;
    public GameObject InitiateRamp;
    public GameObject Score;
    public 

    void OnControllerColliderHit(ControllerColliderHit col)

    {
        if (col.gameObject.name == "InitiateRamp")
        {
            InitiateRamp.GetComponent<AudioSource>().enabled = true;
            Lava.GetComponent<RisingLava>().enabled = true;
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Score")
        {
            Destroy(other.gameObject);
            ObjectTracker.TotalObjects--;
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
