using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
   public static bool pausedGame = false;
   public GameObject MenuPausaUI;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            if(pausedGame)
            {
                Continua();
            }
        }
        else
        {
            Paused();
        }
    }
    void Continua()
    {
        MenuPausaUI.SetActive(false);
        Time.timeScale = 1f;
        pausedGame= false;
    }
    void Paused()
    {
        MenuPausaUI.SetActive(true);
        Time.timeScale = 0f;
        pausedGame = true;
    }
    public void OnApplicationQuit()
    {
       Application.Quit();
    }
}
