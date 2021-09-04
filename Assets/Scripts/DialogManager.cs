using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogueText;
   


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
        //If queue is empty, fill it with sentences
        if (sentences.Count == 0)
        {
            foreach(string sentence in dialog.sentences)   
            {
                sentences.Enqueue(sentence);
            }
        }
        
        //nameText.text = dialog.name; //PROBLEM
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
        //dialogueText.text = sentence; //PROBLEM
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }   
        
        
        
    }

    public void EndDialogue()
    {
        Debug.Log("End of conversation");
        
    }  
}
