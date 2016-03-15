using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PinSetter : MonoBehaviour {

    public Text standingPinsDisplay;
    private int numPinsStanding = 0;
    private Pin[] pinArray;

    // Use this for initialization
    void Start () {
        pinArray = GameObject.FindObjectsOfType<Pin>();
    }
	
	// Update is called once per frame
	void Update () {
        standingPinsDisplay.text = CountStanding().ToString();
	}

    int CountStanding()
    {
        foreach (Pin currentPin in pinArray)
        {
            if (currentPin.isStanding())
            {
                numPinsStanding++;
            }
        }
        return numPinsStanding;
    }

}
