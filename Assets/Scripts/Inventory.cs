using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject[] inventory = new GameObject[10]; //Hier werden die Items gespeichert, man kann 10 Items halten

    public void AddItem(GameObject item)
    {
        bool itemAdded = false;

        //Finde den ersten freien Platz
        for (int i = 0; i < inventory.Length; i++) //für jede stelle in inventory solange i kleiner ist als die länge des inventory, gehe einen schritt weiter
        {
            if (inventory[i] == null) //wenn der i-te platz im inventory nichts beinhaltet
            {
                inventory[i] = item;
                Debug.Log(item.name + "was added");
                itemAdded = true;
                item.SendMessage("DoInteraction"); //ruft die DOInteraction funktion des items auf
                break;  //stoppt den loop, sodass nur ein Itemslot gefüllt wird
            }
        }

        //Wenn das Inventory full ist
        if(!itemAdded)
        {
            Debug.Log("Inventory is full - Item not added!");
        }
    }

    public bool FindItem(GameObject item)
    {
        for(int i = 0; i< inventory.Length; i++)
        {
            if(inventory[i] == item)
            {
                return true; //we found the item
            }
        }
        //item not found
        return false;
    }
        
    
}
