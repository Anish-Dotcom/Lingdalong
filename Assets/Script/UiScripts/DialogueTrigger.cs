using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject diaBox;
    public Text diaText;
    public string dia;
    public bool playerInRange;
    public bool catDialogue = true;

    public static DialogueTrigger instance;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange && catDialogue == true)
        {
            if (diaBox.activeInHierarchy)
            {
                diaBox.SetActive(false);
            }
            else
            {
                diaBox.SetActive(true);
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            playerInRange = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            playerInRange = false;
            diaBox.SetActive(false);
    }
}
