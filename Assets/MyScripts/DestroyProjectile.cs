using UnityEngine;
using System.Collections;

public class DestroyProjectile : MonoBehaviour {
    
    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject)
        {
            Destroy(gameObject);
            
        }
       //if (col.gameObject.tag == "MovingPlatform")
        {
           // if (col.gameObject.GetComponent<Rotate>().enabled == true)
           //     col.gameObject.GetComponent<Rotate>().enabled = false;
          //  else col.gameObject.GetComponent<Rotate>().enabled = true;
         
        }
        
        
    }
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
