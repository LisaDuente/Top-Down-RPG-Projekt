using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;

    public void TriggerDialogue()
    {
        Debug.Log("Dialog triggered!");
        FindObjectOfType<DialogManager>().StartDialogue(dialog);
    }

    public void GetTheNewSentence()
    {
        FindObjectOfType<DialogManager>().DisplayNextSentence();
    }
    
}
