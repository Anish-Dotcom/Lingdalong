using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barrier : MonoBehaviour
{
    public GameObject warningbox;
    public GameObject warningboxui;
    public Text warningtext;
    public string text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        warningtext.text = text;
        if (pickup.instance.soysauceimageactive == true) 
        {
            warningbox.SetActive(false);
        }
        if (pickup.instance.playerHasChild == true)
        {
            warningbox.SetActive(false);
        }
        if (pickup.instance.swordimageactive == true)
        {
            warningbox.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            warningboxui.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            warningboxui.SetActive(false);
    }
}
