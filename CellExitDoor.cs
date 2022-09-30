using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CellExitDoor : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    //public GameObject theDoor;
    // public AudioSource creackSound;
    public GameObject fadeOut;
  

    
    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

     void OnMouseOver()
    {
        if(theDistance <= 3)
        {
            actionText.GetComponent<Text>().text = "Open Door";
            //traCross.SetActive(true);
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
                fadeOut.SetActive(true);
                StartCoroutine(FadeToExit());
                //eDoor.GetComponent<Animation>().Play("FirstDoorOpenAnim");
                //eackSound.Play();
            }
        }
    }

     void OnMouseExit()
    {
       //extaCross.SetActive(false);
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

    IEnumerator FadeToExit()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(5);
        
        
    }
}
