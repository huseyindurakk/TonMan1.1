using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


//Code to assign functions to buttons to change scenes.
public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
   public AudioSource Buttonclicks;

    public void play()
    {
        Buttonclicks.Play ();
        Invoke("play1", 0.2f);
        
    }

    public void goToMenu()
    {   
        Buttonclicks.Play ();
        Invoke("goToMenu1", 0.2f);
    }
    public void goToRestartMenu()
    {   
        Buttonclicks.Play ();
        Invoke("goToRestartMenu1", 0.2f);
    }
    public void quitGame()
    {
        Buttonclicks.Play ();
        Invoke("quitGame1", 0.2f);
    }




    public void play1()
    {
        
        SceneManager.LoadScene("Game");
        
    }

    public void goToMenu1()
    {   
        
        SceneManager.LoadScene("MainMenu");
    }
    public void goToRestartMenu1()
    {   
        
        SceneManager.LoadScene("RestartMenu");
    }

    public void quitGame1()
    {
        Application.Quit();
    }


}
