using System.Collections;
using UnityEngine;

public class CatMovement2 : MonoBehaviour
{
    public GameObject cat;
    public Transform gato;

    public Transform[] targetPositions;
    public int currentTargetIndex = 0;

    public float speed = 5f;


    void Start()
    {
        DialogueTrigger.instance.catDialogue = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gato.transform.position == targetPositions[currentTargetIndex].position)
        {
            currentTargetIndex++;
            if (currentTargetIndex >= targetPositions.Length)
            {
                currentTargetIndex--;
                DialogueTrigger.instance.catDialogue = true;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPositions[currentTargetIndex].position, speed * Time.deltaTime);
    }
}
