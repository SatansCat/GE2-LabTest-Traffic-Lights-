using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChanger : MonoBehaviour
{
    public int Colour;
    // Start is called before the first frame update
    void Start()
    {
        Colour = Random.Range(1, 4);
        StartCoroutine("ColourChange");
    }

    // Update is called once per frame
    
    IEnumerator ColourChange()
    {
        switch(Colour)
        {
            //Green
            case 1:
                {
                    transform.GetComponent<Renderer>().material.color = Color.green;
                    yield return new WaitForSeconds(Random.Range(5, 11));
                    Colour = 2;
                    break;
                }
            //Yellow
            case 2:
                {
                    transform.GetComponent<Renderer>().material.color = Color.yellow;
                    yield return new WaitForSeconds(4);
                    Colour = 3;
                    break;
                }
            //Red
            case 3:
                {
                    transform.GetComponent<Renderer>().material.color = Color.red;
                    yield return new WaitForSeconds(Random.Range(5, 11));
                    Colour = 1;
                    break;
                }
        }
        StartCoroutine("ColourChange");
    }
}
