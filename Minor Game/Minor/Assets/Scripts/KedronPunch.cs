using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class KedronPunch : MonoBehaviour
{
    public Animator Kanimator;
    public Animator Oanimator;
    public TextMeshProUGUI playerscore; 
    public TextMeshProUGUI enemyscore;
    public void Awake()
    {

        Invoke("KPunchTrue", 1f);
        
    }

    void KPunchFalse() 
    {
        Kanimator.SetBool("Punch", false);     
        Invoke("OPunchTrue", 3f);
        enemyscore.text = "HP : 85";

    }

    void KPunchTrue()
    {
        Kanimator.SetBool("Punch", true);
        Invoke("KPunchFalse", 0.5f);
        
    }

    void OPunchTrue()
    {
        Oanimator.SetBool("Punch", true);
        Invoke("OPunchFalse", 0.5f);
    }

    void OPunchFalse()
    {
        Oanimator.SetBool("Punch", false);
        Invoke("BackToMain",3f);
        playerscore.text = "HP : 92";

    }




    [System.Obsolete]
    public void BackToMain()
    {
        SceneManager.UnloadScene(3);
        Scenechanger.canvas.SetActive(true);
    }

}




