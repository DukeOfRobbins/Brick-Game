using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEditor;
using System;

public class MenuUIHandler : MonoBehaviour
    {

    public TextMeshProUGUI playerName;
    public TMP_InputField playerNameText;

    public GameObject noNameMessage;

    public void StartGame()
        {
        if (playerNameText.text  == "")
            {
            noNameMessage.SetActive(true);
            }
        else
            SceneManager.LoadScene(1);
            PersistenceScript.instance.LoadHighScore();
            PersistenceScript.instance.currentScore = 0;
            PersistenceScript.instance.currentPlayerName = playerName.text;
        }

    public void QuitGame()
        {
        PersistenceScript.instance.SaveHighScore();

            #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
            #else
                                Application.Quit(); // original code to quit Unity player
            #endif
        }

    public void ReturnToMenu()
        {
        SceneManager.LoadScene(0);
        PersistenceScript.instance.currentPlayerName = null;
        playerName = null;
        PersistenceScript.instance.currentScore = 0;
        }

    public void CheckHighScores()
        {
        SceneManager.LoadScene(2);
        }
    }
