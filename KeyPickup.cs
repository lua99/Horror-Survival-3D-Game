using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPickup : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
   
    
    
    public GameObject extraCross;
    public GameObject theKey;
   
    



    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 3)
        {
            extraCross.SetActive(true);
            actionText.GetComponent<Text>().text = "Pickup Key";
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                
                extraCross.SetActive(false);
                theKey.SetActive(false);
                GlobalInventry.firstDoorKey = true;
                
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
