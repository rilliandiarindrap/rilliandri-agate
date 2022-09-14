using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void OpenAuthor()
    {
        Debug.Log("Created by Yandi");
    }
    public void Credit()
    {
        SceneManager.LoadScene("CreditS");
    }


}
