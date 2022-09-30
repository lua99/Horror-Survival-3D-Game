using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    public GameObject theGun;
    public GameObject muzzleFlash;
    public AudioSource gunFire;
    public bool isFiring = false;
    public float targetDistance;
    public int DamageAmount = 5;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && GlobalAmmo.ammoCount>=1)
        {
            if (isFiring == false)
            {
                GlobalAmmo.ammoCount -= 1;
                StartCoroutine(FiringPistol());
            }
        }
    }

    IEnumerator FiringPistol()
    {
        RaycastHit Shot;
        isFiring = true;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            targetDistance = Shot.distance;
            Shot.transform.SendMessage("DamageZombie", DamageAmount, SendMessageOptions.DontRequireReceiver);
        }
        theGun.GetComponent<Animation>().Play("PistolShotAnim");
        muzzleFlash.SetActive(true);
        muzzleFlash.GetComponent<Animation>().Play("MuzzleAnim");
        
        gunFire.Play();
        yield return new WaitForSeconds(0.5f);
        isFiring = false;

    }
}
