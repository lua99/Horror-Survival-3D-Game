using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{

    public static int currentHealth=20;
    public int internalHealth;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalHealth = currentHealth;
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
