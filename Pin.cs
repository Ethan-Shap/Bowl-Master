using UnityEngine;
using System.Collections;

public class Pin : MonoBehaviour {

    public float standingThreshold;
    public float standingErrorCorrection = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool isStanding()
    {
        Vector3 pinRotation = transform.rotation.eulerAngles;

        float tiltInX = Mathf.DeltaAngle(pinRotation.x, 0) - standingErrorCorrection;
        float tiltInZ = Mathf.DeltaAngle(pinRotation.z, 0) - standingErrorCorrection;

        if(tiltInX <= standingThreshold && tiltInZ <= standingThreshold)
        {
            return true;
        }
        return false;
    }

}
