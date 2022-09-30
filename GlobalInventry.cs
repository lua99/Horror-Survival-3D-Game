using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInventry : MonoBehaviour
{
    public static bool firstDoorKey = false;
    public bool internaldoorKey;

    
  

    
    void Update()
    {
        internaldoorKey = firstDoorKey;
    }
}
