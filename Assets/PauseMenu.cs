using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    //To active PauseMenu
    public void Pause(bool pause)
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Reset()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
