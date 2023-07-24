using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REALWALK : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;

    public Animator myAnim;
    public static REALWALK instance;

    public Transform areaEnterence;

    private Vector3 bottemLeftLimit;
    private Vector3 TopRightLimit;

    public bool killmonster = false;
    public bool hitmonster = false;

    public string areaTransitionName;

    public GameObject sword;
    public float swordSpeed = 2;

    // Use this for initialization
    void Awake() {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }


    }
    

    // Update is called once per frame
    void Update() {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;

        myAnim.SetFloat("moveX", rb.velocity.x);
        myAnim.SetFloat("moveY", rb.velocity.y);

        

        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            myAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            myAnim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }


        if (Input.GetKeyDown(KeyCode.J) || Input.GetMouseButtonDown(0))
        {
            if(pickup.instance.swordimageactive == true)
            {
                StartCoroutine(startSwordAnim());
            }
        }

        if (Input.GetKeyDown(KeyCode.K) || Input.GetMouseButtonDown(1))
        {
            if (pickup.instance.swordimageactive == true)
            {
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                sword.transform.position = Vector2.MoveTowards(transform.position, mousePosition, swordSpeed * Time.deltaTime);
            }
        }

    }

    public void SetBounds(Vector3 botLeft, Vector3 topRight)
    {
        bottemLeftLimit = botLeft;
        TopRightLimit = topRight; 

        
    }
     IEnumerator startSwordAnim()
    {
        yield return new WaitForSeconds(0);
        myAnim.SetBool("Sword", true);
        StartCoroutine(endSwordAnim());
        hitmonster = true;
    }
    IEnumerator endSwordAnim()
    {
        yield return new WaitForSeconds(0.1f);
        myAnim.SetBool("Sword", false);
        hitmonster =false;
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            killmonster = true;
            Debug.Log("R");
        }
    }
}
