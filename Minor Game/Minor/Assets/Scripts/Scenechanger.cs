using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class Scenechanger : MonoBehaviour
{
    public static  int cardspawner=0;
    public static int moveplayed = 0;
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
        else { cardspawner = 0; }
        
        //Action card logic

        if (gameObject.tag == "Punch")
        {
            moveplayed = 1;

            Invoke("ActionScenechange", 4f);



        }
        else if (gameObject.tag == "Kick")
        {
            moveplayed = 2;
            Invoke("ActionScenechange", 4f);


        }
        else { moveplayed = 0; }



    }
    
    
    
    public void Scenechange()
    {
        canvas = GameObject.FindGameObjectWithTag("EditorOnly");
        canvas.SetActive(false);
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
    }

    public void ActionScenechange()
    {
        canvas = GameObject.FindGameObjectWithTag("EditorOnly");
        canvas.SetActive(false);
        SceneManager.LoadScene(3, LoadSceneMode.Additive);
    }



}
