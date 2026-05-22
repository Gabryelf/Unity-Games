using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LosePanel : MonoBehaviour
{
    public int score;
    public int record;
    [SerializeField] public TextMeshProUGUI TextScore;
    [SerializeField] public TextMeshProUGUI TextRecordScore;
    [SerializeField] AudioSource audio5;

    void Start()
    {
        score = PlayerPrefs.GetInt("score");
        TextScore.text = score.ToString();
        record = PlayerPrefs.GetInt("record");
        if (score > record)
        {
            record = score;
            PlayerPrefs.SetInt("record", record);
            TextRecordScore.text = record.ToString();
        }
        else
        {
            TextRecordScore.text = record.ToString();
        }
        Time.timeScale = 0;
        audio5.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
