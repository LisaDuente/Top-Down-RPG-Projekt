using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;//das ist vllt null

    public void TriggerDialogue()
    {
        Debug.Log("Dialog triggered!");
        FindObjectOfType<DialogManager>().StartDialogue(dialog);
    }

    public void GetTheNewSentence()
    {
        FindObjectOfType<DialogManager>().DisplayNextSentence();
    }

    public void EndDialogue()
    {
        FindObjectOfType<DialogManager>().EndDialogue();
    }
    
}
