using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{

    public string areaToLoad;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("NITG");
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(areaToLoad);
            Debug.Log("nay");
        }
    }
}
