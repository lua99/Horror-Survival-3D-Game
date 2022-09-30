using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BJumpTrigger : MonoBehaviour
{
    public AudioSource doorBang;
    public AudioSource doorJumpMusic;
    public GameObject theZombie;
    public GameObject theDoor;
    public AudioSource amMusic;


     void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        theDoor.GetComponent<Animation>().Play("JumpDoorAnim");
        doorBang.Play();
        theZombie.SetActive(true);
        StartCoroutine(PlayJumpMusic());


    }

    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.4f);
        amMusic.Stop();
        doorJumpMusic.Play();
    }

}
