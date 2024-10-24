using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerScores : IComparable<PlayerScores>
{
    public string playerName;
    public int playerScore;

    public PlayerScores(string name, int score)
        {
        name = playerName;
        score = playerScore;
        }

    public int CompareTo(PlayerScores other)
        {
        if (other == null)
            {
            return 1;
            }

        //Return the difference in score.
        return playerScore - other.playerScore;
        }
    }