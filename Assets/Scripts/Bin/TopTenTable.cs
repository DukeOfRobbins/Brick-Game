using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TopTenTable : MonoBehaviour
{
    public Transform container;
    public Transform topTenHeadings;

    private List<TopTenEntry> topTenEntryList;
    public List<Transform> topTenEntryTransformEntryList;

    //public object PlayerPrefsX { get; private set; }

    private void Awake()
        {

        container = transform.Find("TopTenContainer");
        topTenHeadings = container.Find("TopTenHeadings");

        topTenHeadings.gameObject.SetActive(false);

        topTenEntryList = new List<TopTenEntry>()
            {

            new TopTenEntry {tScore = 25,  tName = "Marky"},
            new TopTenEntry {tScore = 132, tName = "MarkyBabes"},
            new TopTenEntry {tScore = 102, tName = "Bib"},
            new TopTenEntry {tScore = 203, tName = "Marabes"},
            new TopTenEntry {tScore = 2245, tName = "Mar"},
            new TopTenEntry {tScore = 34, tName = "Babes"},
            new TopTenEntry {tScore = 120, tName = "Mabes"},
            new TopTenEntry {tScore = 76, tName = "MarkyBabes"},
            new TopTenEntry {tScore = 60, tName = "dhdh"},
            new TopTenEntry {tScore = 245, tName = "lgkgj"},
            };

        topTenEntryTransformEntryList = new List<Transform>();

        foreach (TopTenEntry topTenEntry in topTenEntryList)
            {
            CreateTopTenEntryTransform(topTenEntry, container, topTenEntryTransformEntryList);
            }
        }

    private void CreateTopTenEntryTransform(TopTenEntry topTenEntry, Transform container, List<Transform> transformList)
        {
        float listingHeight = 25f;

        Transform topTenTransform = Instantiate(topTenHeadings, container);
        RectTransform topTenRectTransform = topTenTransform.GetComponent<RectTransform>();
        topTenRectTransform.anchoredPosition = new Vector2(0, listingHeight * transformList.Count);
        topTenTransform.gameObject.SetActive(true);

        int score = topTenEntry.tScore;
        string name = topTenEntry.tName;

        transformList.Add(topTenTransform);

        //topTenTransform.Find("NameText").GetComponent<TextMeshProUGUI>().text = PersistenceScript.instance.currentPlayerName;
        //topTenTransform.Find("ScoreText").GetComponent<TextMeshProUGUI>().text = PersistenceScript.instance.currentHighScore.ToString();
        }

    private class TopTenEntry
        {
        public int tScore;
        public string tName;
        }

//void DisplayPlayerResult()
//        {
//        //topTenTransform.Find("NameText").GetComponent<TextMeshProUGUI>().text = PersistenceScript.instance.currentPlayerName;
//        //topTenTransform.Find("ScoreText").GetComponent<TextMeshProUGUI>().text = PersistenceScript.instance.m_Points.ToString();
//        }
}
