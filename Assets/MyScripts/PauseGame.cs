using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {
    private bool IsPaused = false;
	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!IsPaused)
            {
                Time.timeScale = 0;
                IsPaused = true;
            }
            else
            {
                Time.timeScale = 1;
                IsPaused = false;
            }
        }
    }
}
