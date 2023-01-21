using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEnterence : MonoBehaviour
{
    public string transitionName;

    // Start is called before the first frame update
    void Start()
    {

        if (transitionName == REALWALK.instance.areaTransitionName)
        {
            REALWALK.instance.transform.position = transform.position;
            
        } 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
