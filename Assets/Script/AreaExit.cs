using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class areaexit : MonoBehaviour
{
    public string sceneToLoad;
    public string areaTransitionName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneToLoad);

            REALWALK.instance.areaTransitionName = areaTransitionName;
        }
    }
}
