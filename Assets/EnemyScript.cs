using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{

    public Collider2D Rad;
    public float movementSpeed = 5f;
    public bool playerInbounds = false;
 
    public GameObject Enemy;

    public Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        myAnim.SetFloat("MoveX", transform.position.x);
        myAnim.SetFloat("MoveY", transform.position.y);

        
        if (playerInbounds == true)
        {
            Vector2 direction = REALWALK.instance.transform.position - transform.position;
            direction.Normalize();
            GetComponent<Rigidbody2D>().velocity = direction * movementSpeed;
        }

        if(REALWALK.instance.killmonster == true && REALWALK.instance.hitmonster == true)
        {
            Enemy.SetActive(false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInbounds = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            #if UNITY_EDITOR
                        UnityEditor.EditorApplication.isPlaying = false;
            #elif UNITY_WEBPLAYER
                    Application.OpenURL(webplayerQuitURL);
            #else
                    Application.Quit();
            #endif
        }
    }
}
