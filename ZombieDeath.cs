using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public int enemyHealth = 20;
    public GameObject theEnemy;
    public int statusCheck;
    public AudioSource jumpScareMusic;
    public AudioSource amMusic;

    
    void DamageZombie(int DamageAmount)
    {
        enemyHealth -= DamageAmount;
    }





    void Update()
    {
        if(enemyHealth<=0 && statusCheck == 0)
        {
            this.GetComponent<ZombieAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            statusCheck = 2;
            theEnemy.GetComponent<Animation>().Stop("Walk");
            theEnemy.GetComponent<Animation>().Play("Death");
            jumpScareMusic.Stop();
            amMusic.Play();
        }
    }
}
