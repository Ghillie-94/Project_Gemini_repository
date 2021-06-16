using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDoor : MonoBehaviour
{
    public string sceneToLoad;

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Finish")) //changed from player
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
