using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public string sceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startButton()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void controlsButton()
    {
        //gonna do this later
    }

    public void quitButton()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
