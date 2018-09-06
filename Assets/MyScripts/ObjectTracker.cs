using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectTracker : InitiateGame {
    public GameObject WinMusic;
    public static int TotalObjects;
    Text myText;
    Text winText;
    void Awake()
    {
        myText = GetComponent<Text>();
        winText = GetComponent<Text>();
        TotalObjects = GameObject.FindGameObjectsWithTag("Score").Length;
    }
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        myText.text = "Survival gear and supplies left to collect: " + TotalObjects.ToString();
        if (TotalObjects == 0)
        {
            winText.text = "Congratulations!!!";
            InitiateRamp.GetComponent<AudioSource>().enabled = false;
            Lava.GetComponent<RisingLava>().enabled = false;
            WinMusic.GetComponent<AudioSource>().enabled = true;

        }
	}
}
