using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject theMenu;

    public PlayerStats[] charstats;

    public Text[] nextText, hpText, lvlText, expText;
    public Slider[] expSlider;
    public Image[] charImage;
    public GameObject[] charStatHolder;
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

    public void updateMenuStats()
    {
        charstats = GameManager.instance.playerStats;

        for(int i = 0; i < charstats.Length; i++)
        {
            
        }
    }

}
