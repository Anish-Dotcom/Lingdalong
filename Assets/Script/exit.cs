using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    public string sceneToLoad;
    public string areaTransitionName;

    public AreaEnterence TheEnterence;

    void Start()
    {
        TheEnterence.transitionName = areaTransitionName;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneToLoad);

            REALWALK.instance.areaTransitionName = areaTransitionName;
        }
    }
}
