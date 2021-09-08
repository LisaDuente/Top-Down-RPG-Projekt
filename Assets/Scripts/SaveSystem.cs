using System.Collections.Generic;
using UnityEngine;

//needs to be attached to a SaveSystemObject, that needs to be in every scene
public class SaveSystem : MonoBehaviour
{
   public static SaveSystem Instance;

   public string[] inventorySaveSystem;
   public bool isSearchingFor;
   

   void Awake()
   {
       //if there is another instance, destroy it and make it THIS instance
       if (Instance == null)
       {
           //keeps the gameObject this script is attached to alive
           DontDestroyOnLoad(gameObject);
           Instance = this;
       }
       else if ( Instance != this)
        {
            Destroy(gameObject);
        }       
    }
}
