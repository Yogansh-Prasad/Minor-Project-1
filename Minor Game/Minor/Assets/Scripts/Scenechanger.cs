using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Scenechanger : MonoBehaviour
{

    
    private void OnMouseDown()
    {
        if (gameObject.tag == "Hammerhead") 
        {
            Invoke("Scenechange", 4f);
            
        }
    }

    public void Scenechange() 
    {
        SceneManager.LoadScene(1,LoadSceneMode.Additive);
    }

    
}
