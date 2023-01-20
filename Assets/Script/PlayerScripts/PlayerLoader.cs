using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        if(REALWALK.instance == null)
        {
            Instantiate(player);
            REALWALK.instance.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
