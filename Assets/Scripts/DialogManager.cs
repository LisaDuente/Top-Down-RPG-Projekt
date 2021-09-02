using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public bool conversationOn = false;


    //keeps track of all the scentences in the dialog
    //Queue is a first in first out collection (FIFO)
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();

    }

    public void StartDialogue(Dialog dialog)
    {
        Debug.Log("starting conversation with " + dialog.name);
        conversationOn = true;

        //nameText.text = dialog.name;

        //clear all sentences
        sentences.Clear();
        //adds sentences in the queue
        foreach(string sentence in dialog.sentences)   //was meint das hier?
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        if (Input.GetButtonDown("dialogNext")) //if the r button gets pressed
        {
            string sentence = sentences.Dequeue();
            Debug.Log(sentence);
            //dialogueText.text = sentence;
        }
    }

    public void EndDialogue()
    {
        Debug.Log("End of conversation");
        conversationOn = false;
    }

   
}
