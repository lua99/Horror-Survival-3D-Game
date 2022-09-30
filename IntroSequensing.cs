using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroSequensing : MonoBehaviour
{

    public GameObject textBox;
    public GameObject dateDisplay;
    public GameObject placeDisplay;
    public AudioSource line01;
    public AudioSource line02;
    public AudioSource line03;
    public AudioSource line04;
    public AudioSource line05;
    public AudioSource line06;
    public AudioSource thudSound;
    public GameObject allBlack;
    public GameObject loadText;
    void Start()
    {
        StartCoroutine(SequenceBegin());  
    }

    
    IEnumerator SequenceBegin()
    {
        yield return new WaitForSeconds(3);
        placeDisplay.SetActive(true);
        yield return new WaitForSeconds(1);
        dateDisplay.SetActive(true);
        yield return new WaitForSeconds(4);
        placeDisplay.SetActive(false);
        dateDisplay.SetActive(false);
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "The Night of november 28th,changed my life forever";
        line01.Play();
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "After they came on our planet,i always hear strange sounds from this forest";
        line02.Play();
        yield return new WaitForSeconds(6);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "One night i decided to check..";
        line03.Play();
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(4);
        textBox.GetComponent<Text>().text = "Suddenly i saw that Cabin in the distance";
        line04.Play();
        yield return new WaitForSeconds(4);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(6);
        textBox.GetComponent<Text>().text = "I could hear those sounds over and over again";
        line05.Play();
        yield return new WaitForSeconds(6);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(7);
        textBox.GetComponent<Text>().text = "But ,i did not know it was begining of something crazy";
        line06.Play();
        yield return new WaitForSeconds(9);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(9);
        allBlack.SetActive(true);
        thudSound.Play();
        yield return new WaitForSeconds(1);
        loadText.SetActive(true);
       
        SceneManager.LoadScene(2);












    }
}
