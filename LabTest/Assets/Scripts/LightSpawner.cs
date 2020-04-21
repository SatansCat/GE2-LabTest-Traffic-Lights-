using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSpawner : MonoBehaviour
{
    public int numLights = 10;
    public float radius = 10;
    public GameObject TrafficLight;
    public List<GameObject> Lights = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        CreateLights();
    }

    void CreateLights()
    {
        float theta = (Mathf.PI * 2.0f) / numLights;
        for (int i=0; i<numLights; i++)
        {
            Vector3 pos = new Vector3(
                Mathf.Sin(theta*i)*radius
                , 1
                , Mathf.Cos(theta*i)*radius);
            //pos = transform.TransformPoint(pos);

            GameObject Temp = Instantiate(TrafficLight, pos, Quaternion.identity);
            Lights.Add(Temp);
        }
        
    }
}
