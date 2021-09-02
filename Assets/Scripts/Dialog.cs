using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** will host all information about a dialogue
*/
[System.Serializable]           //shows in the inspector, so we can add it
public class Dialog 
{
    public string name;         //name of the npc we are talking to

    [TextArea(3, 10)]           //min and max of lines for text 
    public string[] sentences; //The scentences that we will load in the queue

   
}
