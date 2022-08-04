using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuToCafe : MonoBehaviour
{
    public void PlayCutScene()
    {
        SceneManager.LoadScene("CutScene1");
    }
    public void goControls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void goMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
