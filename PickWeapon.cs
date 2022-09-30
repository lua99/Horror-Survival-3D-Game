using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickWeapon : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject fakePistol;
    public GameObject realPistol;
    public GameObject GuideArrow;
    public GameObject extraCross;
    public GameObject theJumpTrigger;



    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 3)
        {
            extraCross.SetActive(true);
            actionText.GetComponent<Text>().text = "Pick up Pistol";
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
                fakePistol.SetActive(false);
                realPistol.SetActive(true);
                extraCross.SetActive(false);
                GuideArrow.SetActive(false);
                theJumpTrigger.SetActive(true);
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
