using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeThrough : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<Renderer>().material.renderQueue = 3002;
    }

    
}
