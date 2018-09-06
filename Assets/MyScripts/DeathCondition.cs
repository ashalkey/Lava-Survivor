using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinDeathCondition : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Lava")
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () { }

}
