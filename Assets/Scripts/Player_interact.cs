using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_interact : MonoBehaviour
{
    public GameObject currentIntObject = null; //Das object mit dem wir interagieren wollen

    void Update()
    {
        if(Input.GetButtonDown("Interact") && currentIntObject) //Wenn wir den Interactbutton e drücken und ein currentIntObj gespeichert haben, dann...
        {
            currentIntObject.SendMessage("DoInteraction"); //refferiert zu funktion "DoInteraction" im Script des InteractableObjects
        }
    }
    
    void OnTriggerEnter2D(Collider2D other) //Wenn ich in die CollideBox vom Interactable Object reinlaufe
    {
        if(other.CompareTag("InteractableObject")) //Wenn das Objekt als InteractableObject getagged ist
        {
            Debug.Log(other.name);
            currentIntObject = other.gameObject;

        }
    }

    void OnTriggerExit2D(Collider2D other) //Wenn man die Colliderzone des InteractableObjects verlässt
    {
        if(other.CompareTag("InteractableObject")) //Wenn das Objekt als InteractableObject getagged ist
        {
            if(other.gameObject == currentIntObject) //Wenn dass IntObj schon als current gespeichert ist
            {
                currentIntObject = null; //Wird das current auf null zurückgesetzt
            }
            

        }
    }
}
