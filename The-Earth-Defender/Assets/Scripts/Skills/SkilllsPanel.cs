using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkilllsPanel : MonoBehaviour
{

    public int record;
    public int credit;
    public int iron;
    public int levelSputnik;

    public int countSputnik;
    public int liveSputnik;
    public int speedShootSputnik;
    public int volumAttackSputnik;
    public int speedStartSputnik;

    public GameObject maxLevelcountSputnik;
    public GameObject maxLevelliveSputnik;
    public GameObject maxLevelspeedShootSputnik;
    public GameObject maxLevelvolumeAttackSputnik;
    public GameObject maxLevelspeedStartSputnik;

    public GameObject leader1;
    public GameObject leader2;
    public GameObject leader3;
    public GameObject leader4;
    public GameObject leader5;

    [SerializeField] private TextMeshProUGUI LevelSputnikText;


    void Start()
    {
        
    }

    
    void Update()
    {
        levelSputnik = PlayerPrefs.GetInt("levelSputnik");
        LevelSputnikText.text = levelSputnik.ToString();
        record = PlayerPrefs.GetInt("hiscore");
        countSputnik = PlayerPrefs.GetInt("countSputnik");
        liveSputnik = PlayerPrefs.GetInt("liveSputnik");
        speedShootSputnik = PlayerPrefs.GetInt("speedShootSputnik");
        volumAttackSputnik = PlayerPrefs.GetInt("volumAttackSputnik");
        speedStartSputnik = PlayerPrefs.GetInt("speedStartSputnik");
        //leaderDeactivate
        if(record >= 100)
        {
            leader1.SetActive(false);
        }
        if (record >= 300)
        {
            leader2.SetActive(false);
        }
        if (record >= 1100)
        {
            leader3.SetActive(false);
        }
        if (record >= 1400)
        {
            leader4.SetActive(false);
        }
        if (record >= 1750)
        {
            leader5.SetActive(false);
        }

        // plusDeactivate
        if (countSputnik >= 10)
        {
            maxLevelcountSputnik.SetActive(false);
        }
        if (liveSputnik >= 10)
        {
            maxLevelliveSputnik.SetActive(false);
        }
        if (speedShootSputnik >= 10)
        {
            maxLevelspeedShootSputnik.SetActive(false);
        }
        if (volumAttackSputnik >= 10)
        {
            maxLevelvolumeAttackSputnik.SetActive(false);
        }
        if (speedStartSputnik >= 10)
        {
            maxLevelspeedStartSputnik.SetActive(false);
        }
    }


    public void BuyCountSputnic()
    {
        countSputnik = PlayerPrefs.GetInt("countSputnik");
        iron = PlayerPrefs.GetInt("iron");
        credit = PlayerPrefs.GetInt("diamond");
        if(countSputnik <= 9)
        {
            if (credit >= 300 && iron >= 200)
            {
                iron -= 200;
                PlayerPrefs.SetInt("iron", iron);
                credit -= 300;
                PlayerPrefs.SetInt("credit", credit);
                countSputnik += 1;
                PlayerPrefs.SetInt("countSputnik", countSputnik);
                levelSputnik = PlayerPrefs.GetInt("levelSputnik");
                levelSputnik += 1;
                PlayerPrefs.SetInt("levelSputnik", levelSputnik);
            }
        }
        
    }

    public void BuyLiveSputnik()
    {
        liveSputnik = PlayerPrefs.GetInt("liveSputnik");
        iron = PlayerPrefs.GetInt("iron");
        credit = PlayerPrefs.GetInt("diamond");
        if (liveSputnik <= 9)
        {
            if (credit >= 300 && iron >= 200)
            {
                iron -= 200;
                PlayerPrefs.SetInt("iron", iron);
                credit -= 300;
                PlayerPrefs.SetInt("credit", credit);
                countSputnik += 1;
                PlayerPrefs.SetInt("liveSputnik", liveSputnik);
                levelSputnik = PlayerPrefs.GetInt("levelSputnik");
                levelSputnik += 1;
                PlayerPrefs.SetInt("levelSputnik", levelSputnik);
            }
        }

    }

    public void BuySpeedShootSputnik()
    {
        speedShootSputnik = PlayerPrefs.GetInt("speedShootSputnik");
        iron = PlayerPrefs.GetInt("iron");
        credit = PlayerPrefs.GetInt("diamond");
        if (speedShootSputnik <= 9)
        {
            if (credit >= 300 && iron >= 200)
            {
                iron -= 200;
                PlayerPrefs.SetInt("iron", iron);
                credit -= 300;
                PlayerPrefs.SetInt("credit", credit);
                speedShootSputnik += 1;
                PlayerPrefs.SetInt("speedShootSputnik", speedShootSputnik);
                levelSputnik = PlayerPrefs.GetInt("levelSputnik");
                levelSputnik += 1;
                PlayerPrefs.SetInt("levelSputnik", levelSputnik);
            }
        }

    }

    public void BuyVolumAttackSputnik()
    {
        volumAttackSputnik = PlayerPrefs.GetInt("volumAttackSputnik");
        iron = PlayerPrefs.GetInt("iron");
        credit = PlayerPrefs.GetInt("diamond");
        if (volumAttackSputnik <= 9)
        {
            if (credit >= 300 && iron >= 200)
            {
                iron -= 200;
                PlayerPrefs.SetInt("iron", iron);
                credit -= 300;
                PlayerPrefs.SetInt("credit", credit);
                volumAttackSputnik += 1;
                PlayerPrefs.SetInt("volumAttackSputnik", volumAttackSputnik);
                levelSputnik = PlayerPrefs.GetInt("levelSputnik");
                levelSputnik += 1;
                PlayerPrefs.SetInt("levelSputnik", levelSputnik);
            }
        }

    }

    public void BuySpeedStartSputnik()
    {
        speedStartSputnik = PlayerPrefs.GetInt("speedStartSputnik");
        iron = PlayerPrefs.GetInt("iron");
        credit = PlayerPrefs.GetInt("diamond");
        if (speedStartSputnik <= 9)
        {
            if (credit >= 300 && iron >= 200)
            {
                iron -= 200;
                PlayerPrefs.SetInt("iron", iron);
                credit -= 300;
                PlayerPrefs.SetInt("credit", credit);
                speedStartSputnik += 1;
                PlayerPrefs.SetInt("speedStartSputnik", speedStartSputnik);
                levelSputnik = PlayerPrefs.GetInt("levelSputnik");
                levelSputnik += 1;
                PlayerPrefs.SetInt("levelSputnik", levelSputnik);
            }
        }

    }


}
