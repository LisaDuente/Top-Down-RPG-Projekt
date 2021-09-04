using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTrigger : MonoBehaviour
{
    
    public void TriggerSceneChange()
    {
        FindObjectOfType<SceneManagement>().ChangeToScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
