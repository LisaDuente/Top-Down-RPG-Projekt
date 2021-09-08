using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public bool isSceneChanger; //if the current Object can change the current scene to another scene
    public bool inventory; //if true this object can be stored in inventory
    public bool changeable; //if true, object can be changed through items in inventory
    public bool searchingFor; //if true, object is in need of an other object
    public bool dialogue;   //if the object triggers a dialogue
    public string itemNeeded;   //Item that is needed for interaction
    public Animator anim;   //provides a link to the Animator
    
    public void DoInteraction()
    {
        //picked up and put in inventory
        gameObject.SetActive(false); //lässt den sprite vom Bildschirm verschwinden, Objekt bleibt aber weiter vorhanden
    }

    public void changeAnimation()
    {
        anim.SetBool("notSearching", true);
        dialogue = false;
    }
}
