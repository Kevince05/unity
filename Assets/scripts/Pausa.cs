using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Pausa : MonoBehaviour
{
    [HideInInspector] public static bool pausedGame = false;
    [SerializeField] public GameObject MenuPausaUI;
    [SerializeField] public Button restart;
    [SerializeField] public Button quit;
    
    void Start(){
        MenuPausaUI.SetActive(false);
        restart.onClick.AddListener(Restart);
        quit.onClick.AddListener(Quit);
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            if(pausedGame)
            {
                MenuPausaUI.SetActive(false);
                Time.timeScale = 1f;
                pausedGame = false;
            }
            else{
                MenuPausaUI.SetActive(true);
                Time.timeScale = 0f;
                pausedGame = true;
            }
        }
    }
    void Restart()
    {
        SceneManager.LoadScene("game");
        pausedGame = false;
        Time.timeScale = 1f;

    }
    void Quit()
    {
       Application.Quit();
    }
}
