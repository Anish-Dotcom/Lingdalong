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
            Debug.Log("nay");
        } else
        {
            Debug.Log("nig");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
