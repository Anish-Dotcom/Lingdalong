using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public bool catIsMoving;

    public static DialogueManager instance;

    public GameObject diaBox;

    private Queue<string> sentences;
    void Start()
    {
        sentences = new Queue<string>();
        instance = this;
    }

    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            diaBox.SetActive(false);
            catIsMoving = true;
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

}
