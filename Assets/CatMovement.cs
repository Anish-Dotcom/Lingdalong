using UnityEngine;

public class CatMovement : MonoBehaviour
{
    public GameObject cat;


    public float speed = 5f; // The speed at which the NPC moves
    public Vector2 targetPosition; // The target position to move towards
    public bool a = false;


    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (DialogueManager.instance.catIsMoving == true)
        {
            cat.transform.localScale = new Vector3(-1,1,1);

            // Calculate the direction vector towards the target
            Vector2 direction = (targetPosition - rb2d.position).normalized;
            
            // Calculate the velocity by multiplying the direction with the speed
            Vector2 velocity = direction * speed;
            

            // Assign the velocity to the Rigidbody2D's velocity property
            if (a == true)
            {
                rb2d.velocity = velocity;
            }
        }
    }
}
