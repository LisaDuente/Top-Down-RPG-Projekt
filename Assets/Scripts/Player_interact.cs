using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_interact : MonoBehaviour
{
    public GameObject currentIntObject = null; //Das object mit dem wir interagieren wollen
    public ObjectInteraction currentIntObjScript = null; //variable to hold the script of the object
    public Inventory inventory; //Place to hold the link to the inventory script


    void Update()
    {
        if(Input.GetButtonDown("Interact") && currentIntObject) //Wenn wir den Interactbutton e drücken und ein currentIntObj gespeichert haben, dann...
        {
            //Check see if this object is to be stored in inventory
            if(currentIntObjScript.inventory)
            {
                inventory.AddItem(currentIntObject); //rufe die funktion AddItem aus dem Inventory Scrippt auf und adde das currentIntObj
            }

            //Check to see if this object is changeable
            if (currentIntObjScript.changeable)
            {
                //check if object is searchingFor
                if(currentIntObjScript.searchingFor)
                {
                    //check if itemNeeded is in inventory
                    //search inventory for item needed, if found change the object
                    if(inventory.FindItem(currentIntObjScript.itemNeeded))
                    {
                        //found the item needed
                        currentIntObjScript.searchingFor = false;
                        currentIntObjScript.changeAnimation();
                        Debug.Log(currentIntObject.name + "is no longer searching for an item!");
                    }
                    else
                    {
                        Debug.Log(currentIntObject.name + "is searching for an item!");
                    }
                }
                else
                {
                    //object is not searching 
                    Debug.Log(currentIntObject.name + "is not searching for an item");
                }
            }
        }
    }
    
    void OnTriggerEnter2D(Collider2D other) //Wenn ich in die CollideBox vom Interactable Object reinlaufe
    {
        if(other.CompareTag("InteractableObject")) //Wenn das Objekt als InteractableObject getagged ist
        {
            Debug.Log(other.name);
            currentIntObject = other.gameObject;
            currentIntObjScript = currentIntObject.GetComponent<ObjectInteraction>(); //get the script of the interactable Object and store it in the variable

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
