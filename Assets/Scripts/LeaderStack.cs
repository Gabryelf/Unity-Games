using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeaderStack : MonoBehaviour
{
    private int record;

    [SerializeField] private TextMeshProUGUI RecordText;

    public GameObject iconLeader1;
    public GameObject iconLeader2;
    public GameObject iconLeader3;
    public GameObject iconLeader4;
    public GameObject iconLeader5;
    public GameObject iconLeader6;
    public GameObject iconLeader7;
    public GameObject iconLeader8;
    public GameObject iconLeader9;
    public GameObject iconLeader10;
    public GameObject iconLeader11;
    public GameObject iconLeader12;
    public GameObject iconLeader13;
    public GameObject iconLeader14;
    public GameObject iconLeader15;
    public GameObject iconLeader16;
    public GameObject iconLeader17;
    public GameObject iconLeader18;
    public GameObject iconLeader19;
    public GameObject iconLeader20;
    public GameObject iconLeader21;
    public GameObject iconLeader22;
    public GameObject iconLeader23;

    void Start()
    {
        record = PlayerPrefs.GetInt("hiscore");
    }

    
    void Update()
    {
        record = PlayerPrefs.GetInt("hiscore");
        if(record >= 0)
        {
            iconLeader1.SetActive(true);
        }
        if (record >= 100)
        {
            iconLeader2.SetActive(true);
        }
        if (record >= 200)
        {
            iconLeader3.SetActive(true);
        }
        if (record >= 300)
        {
            iconLeader4.SetActive(true);
        }
        if (record >= 400)
        {
            iconLeader5.SetActive(true);
        }
        if (record >= 600)
        {
            iconLeader6.SetActive(true);
        }
        if (record >= 800)
        {
            iconLeader7.SetActive(true);
        }
        if (record >= 1000)
        {
            iconLeader8.SetActive(true);
        }
        if (record >= 1100)
        {
            iconLeader9.SetActive(true);
        }
        if (record >= 1250)
        {
            iconLeader10.SetActive(true);
        }
        if (record >= 1400)
        {
            iconLeader11.SetActive(true);
        }
        if (record >= 1500)
        {
            iconLeader12.SetActive(true);
        }
        if (record >= 1750)
        {
            iconLeader13.SetActive(true);
        }
        if (record >= 1900)
        {
            iconLeader14.SetActive(true);
        }
        if (record >= 2000)
        {
            iconLeader15.SetActive(true);
        }
        if (record >= 2200)
        {
            iconLeader16.SetActive(true);
        }
        if (record >= 2400)
        {
            iconLeader17.SetActive(true);
        }
        if (record >= 3000)
        {
            iconLeader18.SetActive(true);
        }
        if (record >= 4000)
        {
            iconLeader19.SetActive(true);
        }
        if (record >= 5000)
        {
            iconLeader20.SetActive(true);
        }
        if (record >= 7000)
        {
            iconLeader21.SetActive(true);
        }
        if (record >= 10000)
        {
            iconLeader22.SetActive(true);
        }
        if (record >= 20000)
        {
            iconLeader23.SetActive(true);
        }
    }
}
