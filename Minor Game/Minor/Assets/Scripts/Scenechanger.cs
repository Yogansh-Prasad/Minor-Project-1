using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class Scenechanger : MonoBehaviour
{
    public static  int cardspawner=0;
    public static GameObject canvas;
    


    private void OnMouseDown()
    {
        if (gameObject.tag == "Celestial")
        {
            cardspawner = 1;
            
            Invoke("Scenechange", 4f);
            
            

        }
        else if (gameObject.tag == "Demolean") 
        {
            cardspawner = 2;
            Invoke("Scenechange", 4f);
            

        }

        else if (gameObject.tag == "Kedron")
        {
            cardspawner = 3;
            Invoke("Scenechange", 4f);
            
        }
        else if (gameObject.tag == "Mjolnir")
        {
            cardspawner = 4;
            Invoke("Scenechange", 4f);
            
        }
        else if (gameObject.tag == "Punch")
        {
            cardspawner = 5;
            Invoke("Scenechange", 4f);

        }


    }
    
    
    
    public void Scenechange()
    {
        canvas = GameObject.FindGameObjectWithTag("EditorOnly");
        canvas.SetActive(false);
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }



}
