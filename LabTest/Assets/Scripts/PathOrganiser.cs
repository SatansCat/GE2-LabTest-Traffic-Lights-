using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathOrganiser : MonoBehaviour
{
    public LightSpawner Spawner;

    private GameObject CurrentTarget;
    private List<GameObject> NextTargets = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NextTargets.Clear();
        //Check if the car has reached the target.
        if(CurrentTarget == null || CurrentTarget.GetComponent<LightChanger>().Colour != 1 || Vector3.Distance(CurrentTarget.transform.position, transform.position) <= 1.0)
        {
            //Search the list in the spawner for greens.
            for(int i = 0; i < Spawner.Lights.Count; i++)
            {
                if(Spawner.Lights[i].GetComponent<LightChanger>().Colour == 1)
                {
                    //Put em in a new list.
                    NextTargets.Add(Spawner.Lights[i]);
                }
            }
            

            //Pick one at random to arrive at.
            CurrentTarget = NextTargets[Random.Range(0, NextTargets.Count+1)];
            transform.GetComponent<Arrive>().targetGameObject = CurrentTarget;
        }
        
    }
}
