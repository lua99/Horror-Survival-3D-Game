using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockedDoor : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
   
    
    
    public GameObject extraCross;
    public AudioSource lockedDoor;
    public GameObject firstKeyDoor;
    



    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 3)
        {
            extraCross.SetActive(true);
            actionText.GetComponent<Text>().text = "Open Door";
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
                StartCoroutine(doorReset());
                
            }
        }
    }

    void OnMouseExit()
    {
        extraCross.SetActive(false);
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }


    IEnumerator doorReset()
    {
        if (GlobalInventry.firstDoorKey == false)
        {
            lockedDoor.Play();
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
        else
        {
            firstKeyDoor.GetComponent<Animator>().Play("FirstKeydoor");
            yield return new WaitForSeconds(1.1f);
            this.GetComponent<BoxCollider>().enabled = false;
        }
        

    }
}
