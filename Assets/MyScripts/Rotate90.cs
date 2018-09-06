using UnityEngine;
using System.Collections;

public class Rotate90 : MonoBehaviour {
    private bool rotating = false;
    private float smoothTime = 0.5f;

	// Use this for initialization

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Projectile" && !rotating)
        {
            rotating = true;
            StartCoroutine(RotateOverTime(gameObject.transform.rotation.x, gameObject.transform.rotation.x +90,  smoothTime));
            //Debug.Log("I rotated!");
        }
    }
    public IEnumerator RotateOverTime (float currentRotation, float desiredRotation, float overTime)
    {
        float totalAmountRotated=0;
        float degreesPerSecond = 90 / overTime;
        while (totalAmountRotated<90)
        {
            float rotationThisFrame = degreesPerSecond * Time.deltaTime;
            totalAmountRotated += rotationThisFrame;
            if (totalAmountRotated>90)
            {
                rotationThisFrame = rotationThisFrame - (totalAmountRotated - 90);
            }
            transform.Rotate(Vector3.right*rotationThisFrame);
            yield return null;
            //Debug.Log("Desired rotation is: " + desiredRotation);
        }
        yield return new WaitForSeconds(overTime);
        //Debug.Log("I'm waiting...");
        rotating = false;
        
    }
	void Start () {
       
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
