using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Buttons : MonoBehaviour
{
    [Header("Start")]
    
    [Header("Pause Button")]
    [SerializeField] Image playImage, pauseImage; 
    [SerializeField] GameObject pauseMenu, endOfGameMenu;

    [Header("Music Button")]
    [SerializeField] Image soundOffImage;
    public AudioSource musicOfGame;
    private static bool isMusicOn = true;
    void Start()
    {
        playImage.gameObject.SetActive(true);
        pauseImage.gameObject.SetActive(false);
        
        pauseMenu.SetActive(false);
        musicOfGame.loop = true;
        if (isMusicOn == true)
        {
            musicOfGame.Play();
        }
        
        soundOffImage.gameObject.SetActive(false);
    }

    void Update()
    {
        if (FindObjectOfType<Lifes>().healthForArray < 0)
        {
            endOfGameMenu.SetActive(true);
            Time.timeScale = 0f;
            musicOfGame.Pause();
        }

        if(!isMusicOn)
        {
            musicOfGame.Pause();
            soundOffImage.gameObject.SetActive(true);
        }
    }

    public void ClickPauseButton()
    {
        PauseGame();
    }

    public void ClickSoundButton()
    {
        if (isMusicOn == true)
        {
            musicOfGame.Pause();
            soundOffImage.gameObject.SetActive(true);
            isMusicOn = false;
        }
        else
        {
            musicOfGame.Play();
            soundOffImage.gameObject.SetActive(false);
            isMusicOn = true;
        }
    }

    public void ClickPlayButton()
    {
        ResumeGame();
    }

    public void ClickExitButton()
    {
        ExitGame();
    }

    public void ClickRetryButton()
    {
        SceneManager.LoadScene("Game Scene");
        FindObjectOfType<Lifes>().healthForArray = 2;
        Time.timeScale = 1f; 
    }
    
    private void PauseGame()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        
        playImage.gameObject.SetActive(false);
        pauseImage.gameObject.SetActive(true);
        
        musicOfGame.Pause();
    }

    private void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);

        playImage.gameObject.SetActive(true);
        pauseImage.gameObject.SetActive(false);
        
        musicOfGame.Play();
    }

    private void ExitGame()
    {
        SceneManager.LoadScene("Menu Scene");
    }
}