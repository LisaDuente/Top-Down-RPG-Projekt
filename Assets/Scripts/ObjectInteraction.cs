using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public bool inventory; //if true this object can be stored in inventory
    public bool changeable; //if true, object can be changed through items in inventory
    public bool searchingFor; //if true, object is in need of an other object
    public GameObject itemNeeded;   //Item that is needed for interaction
    public Animator anim;   //provides a link to the Animator

    public void DoInteraction()
    {
        //picked up and put in inventory
        gameObject.SetActive(false); //lässt den sprite vom Vildschirm verschwinden, Objekt bleibt aber weiter vorhanden
    }

    public void changeAnimation()
    {
        anim.SetBool("notSearching", true);
    }
}
