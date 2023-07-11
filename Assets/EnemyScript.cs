using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    
    public float movementSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         


        Vector2 direction = REALWALK.instance.transform.position - transform.position;
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * movementSpeed;


    }
}
