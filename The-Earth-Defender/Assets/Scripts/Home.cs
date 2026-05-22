using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Home : MonoBehaviour
{
    public int iron;
    public int hiscore;
    [SerializeField] private TextMeshProUGUI IronText;
    [SerializeField] private TextMeshProUGUI RecordText;

    void Start()
    {
        
    }

    
    void Update()
    {
        iron = PlayerPrefs.GetInt("iron");
        IronText.text = iron.ToString();
        hiscore = PlayerPrefs.GetInt("hiscore");
        RecordText.text = hiscore.ToString();
    }
}
