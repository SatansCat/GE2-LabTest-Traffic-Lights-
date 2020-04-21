using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSpawner : MonoBehaviour
{
    public int numLights;
    // Start is called before the first frame update
    void Start()
    {
        CreateLights();
    }

    void CreateLights()
    {
        float theta = (Mathf.PI * 2.0f) / numLights;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
