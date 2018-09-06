using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

	// Use this for initialization
    public void NextLevelButton(string LavaScene)
    {

        SceneManager.LoadScene(LavaScene);
    }
    public void NextLevelButton2(string TutorialScene)
    {
        SceneManager.LoadScene(TutorialScene);
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
