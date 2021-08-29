using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public void DoInteraction()
    {
        //picked up and put in inventory
        gameObject.SetActive(false); //lässt den sprite vom Vildschirm verschwinden, Objekt bleibt aber weiter vorhanden
    }
}
