using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    GameObject spawnPoint;

    public void ChangeToScene()
    {
        SceneManager.LoadScene("OutdoorScene");
        //FindObjectOfType<Movement>().SetSpawnPoint(spawnPoint);
    }
}
