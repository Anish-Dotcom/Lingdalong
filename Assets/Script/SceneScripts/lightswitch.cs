using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class lightswitch : MonoBehaviour
{
    public Tilemap myTilemap;
    public bool lightson;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;
    public GameObject light6;
    public bool playerInRange;
    public GameObject interact;

    public Tile lightswitchoff;
    public Tile lightswitchon;

    public int x;
    public int y;
    public int z;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange == true)
        {
            if (lightson == true)
            {
                Debug.Log("pp1");
                light1.SetActive(false);
                light2.SetActive(false);
                light3.SetActive(false);
                light4.SetActive(false);
                light5.SetActive(false);
                light6.SetActive(false);
                lightson = false;
                myTilemap.SetTile(new Vector3Int(x, y, z), lightswitchoff);
            }
            else
            {
                Debug.Log("pp");
                light1.SetActive(true);
                light2.SetActive(true);
                light3.SetActive(true);
                light4.SetActive(true);
                light5.SetActive(true);
                light6.SetActive(true);
                lightson = true;
                myTilemap.SetTile(new Vector3Int(x, y, z), lightswitchon);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            playerInRange = true;
            interact.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            playerInRange = false;
            interact.SetActive(false);
    }
}
