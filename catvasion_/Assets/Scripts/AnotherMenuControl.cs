using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnotherMenuControl : MonoBehaviour
{
    public void Restart(int scene_number)
    {
        SceneManager.LoadScene(scene_number);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
