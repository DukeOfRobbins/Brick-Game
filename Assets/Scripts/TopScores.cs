using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TopScores : MonoBehaviour
{
    public TextMeshProUGUI playerName;
    public TextMeshProUGUI playerScore;

    private void Start()
        {
        playerName.text = PersistenceScript.instance.HighScoreName;
        playerScore.text = PersistenceScript.instance.HighScore.ToString();
        }
    }
