using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    private string[] inventory = new string[10]; //Hier werden die Items gespeichert, man kann 10 Items halten

    public void AddItem(GameObject item)
    {
        bool itemAdded = false;
        Debug.Log(inventory[1]);

        //Finde den ersten freien Platz
        for (int i = 0; i < inventory.Length; i++) //für jede stelle in inventory solange i kleiner ist als die länge des inventory, gehe einen schritt weiter
        {
            if (inventory[i] == null) //wenn der i-te platz im inventory nichts beinhaltet
            {
                inventory[i] = item.name;
                Debug.Log(item.name + " was added");
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

    public bool FindItem(string itemName)
    {
        for(int i = 0; i< inventory.Length; i++)
        {
            if(inventory[i] == itemName)
            {
                return true; //we found the item
            }
        }
        //item not found
        return false;
    }

    public void SaveInventory()
    {
        SaveSystem.Instance.inventorySaveSystem = inventory;
    }

    void Start()
    {
        SaveInventory();
    }
        
    
}
