using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BTC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Scenechange", 1f);
    }

    [System.Obsolete]
    public void Scenechange()
    {
        SceneManager.UnloadScene(1);
    }
}
