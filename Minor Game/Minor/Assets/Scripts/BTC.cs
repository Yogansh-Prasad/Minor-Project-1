using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BTC : MonoBehaviour
{

    
    public GameObject Kedron;
    public GameObject Celestial;
    

    public void Start()
    {
        
        Spawn();
    }


    public void Spawn()
    {
        
        if (Scenechanger.cardspawner == 3) 
        {
            Kedron.SetActive(true);
            Invoke(nameof(BackToMain), 5f);
           
        }

        if (Scenechanger.cardspawner == 1)
        {
            Celestial.SetActive(true);
            Invoke(nameof(BackToMain), 5f);

        }

    }

    [System.Obsolete]
    public void BackToMain()
    {
        SceneManager.UnloadScene(1);
        Scenechanger.canvas.SetActive(true);
    }
}
