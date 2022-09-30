using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject theDoor;
    public AudioSource creackSound;
    public GameObject extraCross;
  

    
    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

     void OnMouseOver()
    {
        if(theDistance <= 3)
        {
            extraCross.SetActive(true);
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if(theDistance<= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                theDoor.GetComponent<Animation>().Play("FirstDoorOpenAnim");
                creackSound.Play();
            }
        }
    }

     void OnMouseExit()
    {
        extraCross.SetActive(false);
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}
