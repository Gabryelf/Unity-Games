using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecordText : MonoBehaviour
{
    public int record;
    [SerializeField] public TextMeshProUGUI TextRecordScore;

    void Start()
    {
        record = PlayerPrefs.GetInt("record");
        TextRecordScore.text = record.ToString();
    }

}
