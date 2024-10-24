using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreTable : MonoBehaviour
{
    public Transform highScoreContainer;
    public Transform highScoreTemplate;

    private void Awake()
        {
        highScoreContainer = transform.Find("HighScoreContainer");
        highScoreTemplate = highScoreContainer.Find("HighScoreTemplate");

        highScoreTemplate.gameObject.SetActive(false);

        float templateHeight = 25f;
        for (int i = 0; i < 10; i++)
            {
            Transform highScoreTransform = Instantiate(highScoreTemplate, highScoreContainer);
            RectTransform highScoreRecttransform = highScoreTransform.GetComponent<RectTransform>();
            highScoreRecttransform.anchoredPosition = new Vector2(0, -templateHeight * i);
            highScoreTransform.gameObject.SetActive(true);

            int pos = i + 1;
            string posString;
            switch (pos)
                {
                default:
                    posString = pos + "TH"; break;

                case 1: posString = "1ST"; break;
                case 2: posString = "2ND"; break;
                case 3: posString = "3RD"; break;
                }

            highScoreTransform.Find("TextPosition").GetComponent<TextMeshProUGUI>().text = posString;

            int score = Random.Range(0, 10000);

            highScoreTransform.Find("TextScore").GetComponent<TextMeshProUGUI>().text = score.ToString();

            string name = "AAA";
            highScoreTransform.Find("TextName").GetComponent<TextMeshProUGUI>().text = name;
            }
        }
    }
