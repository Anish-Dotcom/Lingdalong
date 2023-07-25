using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    public GameObject soysauceimage;
    public bool soysauceimageactive;
    public GameObject carrotsimage;
    public GameObject swordimage;
    public bool swordimageactive;

    public Sprite itemsprite;
    public string itemname;
    public Image itemimage;
    public Text itemtext;
    public GameObject pickupbox;
    public GameObject item;
    public GameObject pickuptext;
    public bool playerInRange;

    public bool playerHasChild;

    public static pickup instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            if (item.activeInHierarchy)
            {
                pickupbox.SetActive(true);
                itemimage.sprite = itemsprite;
                itemtext.text = itemname;
                StartCoroutine(goaway());
            }
            if (itemname == "+soy sauce")
            {
                soysauceimage.SetActive(true);
                soysauceimageactive = true;
            }
            if (itemname == "+child")
            {
                playerHasChild = true;
            }
            if (itemname == "+carrots")
            {
                carrotsimage.SetActive(true);
            }
            if (itemname == "+sword")
            {
                swordimage.SetActive(true);
                if (swordland.instance.active == true)
                {
                    swordimageactive = true;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            playerInRange = true;
            pickuptext.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            playerInRange = false;
            pickuptext.SetActive(false);
    }

    IEnumerator goaway()
    {
        yield return new WaitForSeconds(2);
        pickupbox.SetActive(false);
        item.SetActive(false);
    }
}
