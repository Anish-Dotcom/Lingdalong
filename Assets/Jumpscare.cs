using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Jumpscare : MonoBehaviour
{
    public GameObject theJumpscare;
    public AudioSource theSCARE;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (theJumpscare.activeInHierarchy)
            {
                theJumpscare.SetActive(false);
            }
            else
            {
                theJumpscare.SetActive(true);
            }
            theSCARE.Play();
        }
    }
}
