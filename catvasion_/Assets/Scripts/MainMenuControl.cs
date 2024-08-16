using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    [SerializeField] GameObject gameobject;
    [SerializeField] GameObject gameobject1;

    public void QuitButton()
    {
        Application.Quit();
    }

    public void ChooseDifficulty()
    {
        gameobject.SetActive(true);
        gameobject1.SetActive(false);
    }

    public void BackButton()
    {
        gameobject.SetActive(false);
        gameobject1.SetActive(true);
    }

    public void EasyGame()
    {
        SceneManager.LoadScene(1);
    }

    public void HarderGame()
    {
        SceneManager.LoadScene(2);
    }

    public void SuperHardGame()
    {
        SceneManager.LoadScene(3);
    }
}
