using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class MainMenu : MonoBehaviour
{
    public Button button;

    private void Start()
    {
        button.onClick.AddListener(LoadScene);
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
