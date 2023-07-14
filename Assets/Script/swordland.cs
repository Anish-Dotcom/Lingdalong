using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordland : MonoBehaviour
{
    public GameObject sword;
    public bool active;

    public static swordland instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            sword.SetActive(true);
            active = true;
        }
    }

}
