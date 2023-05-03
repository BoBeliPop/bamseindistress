using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("stdialog");
    }
    public void quit()
    {
        Application.Quit();
    }
}
