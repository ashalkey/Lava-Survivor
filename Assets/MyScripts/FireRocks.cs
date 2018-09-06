using UnityEngine;
using System.Collections;

public class FireRocks : MonoBehaviour {

    public GameObject Rock;
    public GameObject Rock2;

    // Use this for initialization
    void Start () {
        GetComponent<Camera>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject clone;
            clone = Instantiate(Rock, transform.position + transform.forward * 3, Quaternion.identity) as GameObject;

            clone.GetComponent<Rigidbody>().velocity = GetComponent<Camera>().transform.forward * 60;
            Destroy(clone, 3f);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            GameObject clone2;
            clone2 = Instantiate(Rock2, transform.position + transform.forward * 3, Quaternion.identity) as GameObject;
            clone2.GetComponent<Rigidbody>().velocity = GetComponent<Camera>().transform.forward * 60;
            Destroy(clone2, 3f);
        }
    }

     

            }
            

    
    

