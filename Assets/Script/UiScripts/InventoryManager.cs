using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject theMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            if(theMenu.activeInHierarchy)
            {
                theMenu.SetActive(false);
            } else
            {
                theMenu.SetActive(true);
            }  
        }
    }
}
