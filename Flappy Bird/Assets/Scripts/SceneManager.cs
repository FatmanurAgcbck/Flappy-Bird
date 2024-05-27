using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    private bool isPaused = false;
    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);

    }

    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        
    }

    public void MenuGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

    public void TogglePause()
    {
        if (isPaused)
        {
            // Oyunu devam ettir
            Time.timeScale = 1f; // Zaman ölçeğini 1 yaparak oyunu devam ettirir
            isPaused = false;
        }
        else
        {
            //oyunu durdur
            Time.timeScale = 0f; // Zaman ölçeğini 0 yaparak oyunu duraklatır
            isPaused = true;
        }
    }
}
