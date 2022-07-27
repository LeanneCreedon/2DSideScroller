﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCredits : MonoBehaviour
{
    public void LoadMenu ()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
