using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Person_Interact : MonoBehaviour
{
    public GameObject currentPerson = null;

    void Update()
    {
        if(Input.GetButtonDown("Interact") && currentPerson) //Wenn wir den Interactbutton e drücken und ein currentIntObj gespeichert haben, dann...
        {
            if(currentPerson.name == "Tanz_Typ")
            {
                currentPerson.SendMessage("DoDanceInteraction");//referiert zu der Funktion DoDanceInteraction in Move_Dance_Dude
            }
            else
            {
               currentPerson.SendMessage("DoInteraction"); //refferiert zu funktion "DoInteraction" im Script des InteractableObjects 
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other) //Wenn ich in die CollideBox vom Interactable Object reinlaufe
    {
        if(other.CompareTag("InteractPerson")) //Wenn das Objekt als InteractableObject getagged ist
        {
            Debug.Log(other.name);
            currentPerson = other.gameObject;

        }
    }

    void OnTriggerExit2D(Collider2D other) //Wenn man die Colliderzone des InteractableObjects verlässt
    {
        if(other.CompareTag("InteractPerson")) //Wenn das Objekt als InteractablePerson getagged ist
        {
            if(other.gameObject == currentPerson) //Wenn die IntPers schon als current gespeichert ist
            {
                currentPerson = null; //Wird das current auf null zurückgesetzt
            }
        }
    }
}
