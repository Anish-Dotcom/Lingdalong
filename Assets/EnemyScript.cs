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
    public Rigidbody2D myRb;
    public Animator myAnim;

    public int health;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        myAnim.SetFloat("Yvel", myRb.velocity.y);
        myAnim.SetFloat("Xvel", myRb.velocity.x);


        if (playerInbounds == true)
        {
            Vector2 direction = REALWALK.instance.transform.position - transform.position;
            direction.Normalize();
            GetComponent<Rigidbody2D>().velocity = direction * movementSpeed;
        }

        if(REALWALK.instance.killmonster == true && REALWALK.instance.hitmonster == true && playerInbounds == true)
        {
            Debug.Log('Y');
            health -= 1;
        }
        if(health < 1)
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
            StartCoroutine(lives());
        }
    }

    IEnumerator lives()
    {
        yield return new WaitForSeconds(1);
        REALWALK.instance.lives -= 1;
    }
    
}
