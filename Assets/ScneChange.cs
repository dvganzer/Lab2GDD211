using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScneChange : MonoBehaviour
{
    public InputField playerInput;
    public string playerName;

    public void SetName()
    {
        playerName = playerInput.text;
        Debug.Log("name of player's car " + playerName);

    }

    public void StartGame()
    {

        PlayerPrefs.SetString("ThisPlayer", playerName);
        SceneManager.LoadScene("Car Choice");
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Screen 1");
    }
}

