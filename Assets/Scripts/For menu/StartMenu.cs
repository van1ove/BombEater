using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void PlayClick()
    {
        SceneManager.LoadScene("Game Scene");        
    }
    public void ExitClick()
    {
        Application.Quit();
    }
}
