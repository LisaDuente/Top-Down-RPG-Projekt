using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public GameObject canvas;
   


    //keeps track of all the scentences in the dialog
    //Queue is a first in first out collection (FIFO)
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();

    }

    public void FillDialogueQueue(Dialog dialog)
    {
        //If queue is empty, fill it with sentences
        if (sentences.Count == 0)
        {
            foreach(string sentence in dialog.sentences)   
            {
                sentences.Enqueue(sentence);
            }
        }
    }

    public void StartDialogue(Dialog dialog)
    {
        Debug.Log("starting conversation with " + dialog.name); 
        //nameText.text = dialog.name; //PROBLEM
        canvas.SetActive(true);
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count != 0)
        {
            string sentence = sentences.Dequeue();
            ShowingText showingText = canvas.GetComponent<ShowingText>();
            showingText.displayText(sentence);
            Debug.Log(sentence);
        }
        
        
    }

    public void EndDialogue()
    {
        Debug.Log("End of conversation");
        canvas.SetActive(false);
    }  
}
