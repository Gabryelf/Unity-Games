using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    [SerializeField] public TextMeshProUGUI TextScore;
    [SerializeField] AudioSource audio4;

    void Start()
    {
        Time.timeScale = 1;
        score = PlayerPrefs.GetInt("score");
        score = 0;
        PlayerPrefs.SetInt("score", score);
        TextScore.text = score.ToString();
        audio4.Play();
    }

    void FixedUpdate()
    {
        score = PlayerPrefs.GetInt("score");
        TextScore.text = score.ToString();
    }
}
