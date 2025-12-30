using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using YG;

public class ShipSelecter : MonoBehaviour
{
    public GameObject[] characters;
    public int index;

    [SerializeField] private Button FirtShowButton;

    //private int CellIndex;
    public bool trueBoard;
    public int lives;

    //[SerializeField] private GameObject no;
    //[SerializeField] private GameObject yes;
    [SerializeField] private GameObject block;
    [SerializeField] private GameObject block2;
    [SerializeField] private GameObject block3;
    [SerializeField] private GameObject block4;
    [SerializeField] private GameObject block5;
    [SerializeField] private GameObject block6;
    [SerializeField] private GameObject block7;
    [SerializeField] private GameObject block8;
    [SerializeField] private GameObject block9;
    [SerializeField] private GameObject block10;
    [SerializeField] private GameObject cell;
    [SerializeField] private GameObject cell2;
    [SerializeField] private GameObject cell3;
    [SerializeField] private GameObject cell4;
    [SerializeField] private GameObject cell5;
    [SerializeField] private GameObject cell6;
    [SerializeField] private GameObject cell7;
    [SerializeField] private GameObject cell8;
    [SerializeField] private GameObject cell9;
    [SerializeField] private GameObject cell10;

    //[SerializeField] private GameObject firstGameBonusButton;

    [SerializeField] private TextMeshProUGUI RecordScorText;
    [SerializeField] private TextMeshProUGUI DiamondText;
    //[SerializeField] private Text HeartText;
    public float hiscore;
    private int diamond;
    //private int heart;
    public bool _isBoard_1;
    public bool _isBoard_2;
    public bool _isBoard_3;
    public bool _isBoard_4;
    public bool _isBoard_5;
    public bool _isBoard_6;
    public bool _isBoard_7;
    public bool _isBoard_8;
    public bool _isBoard_9;
    public bool _isBoard_10;

    public bool firstGame;

    [SerializeField] private GameObject notCredits;

    private void OnEnable()
    {
        YandexGame.RewardVideoEvent += Rewarded;
    }

    private void OnDisable()
    {
        YandexGame.RewardVideoEvent -= Rewarded;
    }

    void Start()
    {

        FirtShowButton.onClick.AddListener(delegate { TryRewardShow(1); });
        index = PlayerPrefs.GetInt("CharacterSelected");
        
        //CellIndex = 11;
        characters = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            characters[i] = transform.GetChild(i).gameObject;

        }
        foreach (GameObject go in characters)
        {
            go.SetActive(false);
        }
        if (characters[index])
        {
            characters[index].SetActive(true);
        }

        hiscore = PlayerPrefs.GetInt("hiscore");
        RecordScorText.text = hiscore.ToString();
    }


    void Update()
    {
        //firstGame = PlayerPrefs.GetInt("firstGame") == 1 ? true : false;
        /*if (!firstGame)
        {
            firstGameBonusButton.SetActive(true);
        }
        else
        {
            firstGameBonusButton.SetActive(false);
        }*/
        int index1 = PlayerPrefs.GetInt("CharacterSelected");
        diamond = PlayerPrefs.GetInt("diamond");
        //heart = PlayerPrefs.GetInt("heart");
        //HeartText.text = heart.ToString();
        DiamondText.text = diamond.ToString();
        //yes.SetActive(false);
        //no.SetActive(false);
        _isBoard_1 = PlayerPrefs.GetInt("isBoard1") == 1 ? true : false;
        _isBoard_2 = PlayerPrefs.GetInt("isBoard2") == 1 ? true : false;
        _isBoard_3 = PlayerPrefs.GetInt("isBoard3") == 1 ? true : false;
        _isBoard_4 = PlayerPrefs.GetInt("isBoard4") == 1 ? true : false;
        _isBoard_5 = PlayerPrefs.GetInt("isBoard5") == 1 ? true : false;
        _isBoard_6 = PlayerPrefs.GetInt("isBoard6") == 1 ? true : false;
        _isBoard_7 = PlayerPrefs.GetInt("isBoard7") == 1 ? true : false;
        _isBoard_8 = PlayerPrefs.GetInt("isBoard8") == 1 ? true : false;
        _isBoard_9 = PlayerPrefs.GetInt("isBoard9") == 1 ? true : false;
        _isBoard_10 = PlayerPrefs.GetInt("isBoard10") == 1 ? true : false;
        if (index == 1 && _isBoard_1)
        {
            block.SetActive(false);
            cell.SetActive(false);
        }
        if (index == 2 && _isBoard_2)
        {
            block2.SetActive(false);
            cell2.SetActive(false);
        }
        if (index == 3 && _isBoard_3)
        {
            block3.SetActive(false);
            cell3.SetActive(false);
        }
        if (index == 4 && _isBoard_4)
        {
            block4.SetActive(false);
            cell4.SetActive(false);
        }
        if (index == 5 && _isBoard_5)
        {
            block5.SetActive(false);
            cell5.SetActive(false);
        }
        if (index == 6 && _isBoard_6)
        {
            block6.SetActive(false);
            cell6.SetActive(false);
        }
        if (index == 7 && _isBoard_7)
        {
            block7.SetActive(false);
            cell7.SetActive(false);
        }
        if (index == 8 && _isBoard_8)
        {
            block8.SetActive(false);
            cell8.SetActive(false);
        }
        if (index == 9 && _isBoard_9)
        {
            block9.SetActive(false);
            cell9.SetActive(false);
        }
        if (index == 10 && _isBoard_10)
        {
            block10.SetActive(false);
            cell10.SetActive(false);
        }



    }

    public void SelectLeft()
    {
        int index1 = PlayerPrefs.GetInt("CharacterSelected");
        characters[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = characters.Length - 1;
        }
        if (index == 0)
        {
            cell.SetActive(false);
            cell2.SetActive(false);
            cell3.SetActive(false);
            cell4.SetActive(false);
            cell5.SetActive(false);
            cell6.SetActive(false);
            cell7.SetActive(false);
            cell8.SetActive(false);
            cell9.SetActive(false);
            cell10.SetActive(false);
            block.SetActive(false);
            block2.SetActive(false);
            block3.SetActive(false);
            block4.SetActive(false);
            block5.SetActive(false);
            block6.SetActive(false);
            block7.SetActive(false);
            block8.SetActive(false);
            block9.SetActive(false);
            block10.SetActive(false);
        }
        characters[index].SetActive(true);
        if (index == 1)
        {
            if (hiscore >= 1000)
            {
                block.SetActive(false);
                if (_isBoard_1)
                {
                    cell.SetActive(false);
                }
                else
                {
                    cell.SetActive(true);
                }
            }
            else
            {
                block.SetActive(true);
                cell.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);

        }
        else
        {
            block.SetActive(false);
            cell.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        if (index == 2)
        {
            if (hiscore >= 1500)
            {
                block2.SetActive(false);
                if (_isBoard_2)
                {
                    cell2.SetActive(false);
                }
                else
                {
                    cell2.SetActive(true);
                }
            }
            else
            {
                block2.SetActive(true);
                cell2.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block2.SetActive(false);
            cell2.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }

        if (index == 3)
        {
            if (hiscore >= 2000)
            {
                block3.SetActive(false);
                if (_isBoard_3)
                {
                    cell3.SetActive(false);
                }
                else
                {
                    cell3.SetActive(true);
                }
            }
            else
            {
                block3.SetActive(true);
                cell3.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block3.SetActive(false);
            cell3.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }

        if (index == 4)
        {
            if (hiscore >= 3000)
            {
                block4.SetActive(false);
                if (_isBoard_4)
                {
                    cell4.SetActive(false);
                }
                else
                {
                    cell4.SetActive(true);
                }
            }
            else
            {
                block4.SetActive(true);
                cell4.SetActive(true);
            }

        }
        else
        {
            block4.SetActive(false);
            cell4.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }
        if (index == 5)
        {
            if (hiscore >= 4000)
            {
                block5.SetActive(false);
                if (_isBoard_5)
                {
                    cell5.SetActive(false);
                }
                else
                {
                    cell5.SetActive(true);
                }
            }
            else
            {
                block5.SetActive(true);
                cell5.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block5.SetActive(false);
            cell5.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }
        if (index == 6)
        {
            if (hiscore >= 5000)
            {
                block6.SetActive(false);
                if (_isBoard_6)
                {
                    cell6.SetActive(false);
                }
                else
                {
                    cell6.SetActive(true);
                }
            }
            else
            {
                block6.SetActive(true);
                cell6.SetActive(true);
            }
            block6.SetActive(false);
            cell6.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block6.SetActive(false);
            cell6.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        if (index == 7)
        {
            if (hiscore >= 6000)
            {
                block7.SetActive(false);
                if (_isBoard_7)
                {
                    cell7.SetActive(false);
                }
                else
                {
                    cell7.SetActive(true);
                }
            }
            else
            {
                block7.SetActive(true);
                cell7.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block7.SetActive(false);
            cell7.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }
        if (index == 8)
        {
            if (hiscore >= 7000)
            {
                block8.SetActive(false);
                if (_isBoard_8)
                {
                    cell8.SetActive(false);
                }
                else
                {
                    cell8.SetActive(true);
                }
            }
            else
            {
                block8.SetActive(true);
                cell8.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block8.SetActive(false);
            cell8.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }
        if (index == 9)
        {
            if (hiscore >= 8000)
            {
                block9.SetActive(false);
                if (_isBoard_9)
                {
                    cell9.SetActive(false);
                }
                else
                {
                    cell9.SetActive(true);
                }
            }
            else
            {
                block9.SetActive(true);
                cell9.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block9.SetActive(false);
            cell9.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }
        if (index == 10)
        {
            if (hiscore >= 9000)
            {
                block10.SetActive(false);
                if (_isBoard_10)
                {
                    cell10.SetActive(false);
                }
                else
                {
                    cell10.SetActive(true);
                }
            }
            else
            {
                block10.SetActive(true);
                cell10.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block10.SetActive(false);
            cell10.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }



    }

    public void SelectRight()
    {

        int index2 = PlayerPrefs.GetInt("CharacterSelected");
        characters[index].SetActive(false);
        index++;
        if (index == characters.Length)
        {
            index = 0;
        }
        characters[index].SetActive(true);
        if (index == 0)
        {
            cell.SetActive(false);
            cell2.SetActive(false);
            cell3.SetActive(false);
            cell4.SetActive(false);
            cell5.SetActive(false);
            cell6.SetActive(false);
            cell7.SetActive(false);
            cell8.SetActive(false);
            cell9.SetActive(false);
            cell10.SetActive(false);
            block.SetActive(false);
            block2.SetActive(false);
            block3.SetActive(false);
            block4.SetActive(false);
            block5.SetActive(false);
            block6.SetActive(false);
            block7.SetActive(false);
            block8.SetActive(false);
            block9.SetActive(false);
            block10.SetActive(false);
        }

        if (index == 1)
        {
            if (hiscore >= 1000)
            {
                block.SetActive(false);
                if (_isBoard_1)
                {
                    cell.SetActive(false);
                }
                else
                {
                    cell.SetActive(true);
                }
            }
            else
            {
                block.SetActive(true);
                cell.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block.SetActive(false);
            cell.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }
        if (index == 2)
        {
            if (hiscore >= 1500)
            {
                block2.SetActive(false);
                if (_isBoard_2)
                {
                    cell2.SetActive(false);
                }
                else
                {
                    cell2.SetActive(true);
                }
            }
            else
            {
                block2.SetActive(true);
                cell2.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block2.SetActive(false);
            cell2.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }

        if (index == 3)
        {
            if (hiscore >= 2000)
            {
                block3.SetActive(false);
                if (_isBoard_3)
                {
                    cell3.SetActive(false);
                }
                else
                {
                    cell3.SetActive(true);
                }
            }
            else
            {
                block3.SetActive(true);
                cell3.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block3.SetActive(false);
            cell3.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }

        if (index == 4)
        {
            if (hiscore >= 3000)
            {
                block4.SetActive(false);
                if (_isBoard_4)
                {
                    cell4.SetActive(false);
                }
                else
                {
                    cell4.SetActive(true);
                }
            }
            else
            {
                block4.SetActive(true);
                cell4.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block4.SetActive(false);
            cell4.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }

        if (index == 5)
        {
            if (hiscore >= 4000)
            {
                block5.SetActive(false);
                if (_isBoard_5)
                {
                    cell5.SetActive(false);
                }
                else
                {
                    cell5.SetActive(true);
                }
            }
            else
            {
                block5.SetActive(true);
                cell5.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block5.SetActive(false);
            cell5.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }
        if (index == 6)
        {
            if (hiscore >= 5000)
            {
                block6.SetActive(false);
                if (_isBoard_6)
                {
                    cell6.SetActive(false);
                }
                else
                {
                    cell6.SetActive(true);
                }
            }
            else
            {
                block6.SetActive(true);
                cell6.SetActive(true);
            }

        }
        else
        {
            block6.SetActive(false);
            cell6.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }
        if (index == 7)
        {
            if (hiscore >= 6000)
            {
                block7.SetActive(false);
                if (_isBoard_7)
                {
                    cell7.SetActive(false);
                }
                else
                {
                    cell7.SetActive(true);
                }
            }
            else
            {
                block7.SetActive(true);
                cell7.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block7.SetActive(false);
            cell7.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }
        if (index == 8)
        {
            if (hiscore >= 7000)
            {
                block8.SetActive(false);
                if (_isBoard_8)
                {
                    cell8.SetActive(false);
                }
                else
                {
                    cell8.SetActive(true);
                }
            }
            else
            {
                block8.SetActive(true);
                cell8.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block8.SetActive(false);
            cell8.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }
        if (index == 9)
        {
            if (hiscore >= 8000)
            {
                block9.SetActive(false);
                if (_isBoard_9)
                {
                    cell9.SetActive(false);
                }
                else
                {
                    cell9.SetActive(true);
                }
            }
            else
            {
                block9.SetActive(true);
                cell9.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block9.SetActive(false);
            cell9.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }
        if (index == 10)
        {
            if (hiscore >= 9000)
            {
                block10.SetActive(false);
                if (_isBoard_10)
                {
                    cell10.SetActive(false);
                }
                else
                {
                    cell10.SetActive(true);
                }
            }
            else
            {
                block10.SetActive(true);
                cell10.SetActive(true);
            }
            //yes.SetActive(true);
            //no.SetActive(false);
        }
        else
        {
            block10.SetActive(false);
            cell10.SetActive(false);
            //yes.SetActive(true);
            //no.SetActive(false);

        }


    }

    public void StartScene()
    {
        if (index == 1 && _isBoard_1)
        {

            PlayerPrefs.SetInt("CharacterSelected", index);
            lives = PlayerPrefs.GetInt("lives");
            lives = 3;
            PlayerPrefs.SetInt("lives", lives);
        }


        if (index == 2 && _isBoard_2)
        {

            PlayerPrefs.SetInt("CharacterSelected", index);
            lives = PlayerPrefs.GetInt("lives");
            lives = 3;
            PlayerPrefs.SetInt("lives", lives);
        }

        if (index == 3 && _isBoard_3)
        {

            PlayerPrefs.SetInt("CharacterSelected", index);
            lives = PlayerPrefs.GetInt("lives");
            lives = 3;
            PlayerPrefs.SetInt("lives", lives);
        }

        if (index == 4 && _isBoard_4)
        {

            PlayerPrefs.SetInt("CharacterSelected", index);
            lives = PlayerPrefs.GetInt("lives");
            lives = 4;
            PlayerPrefs.SetInt("lives", lives);
        }

        if (index == 5 && _isBoard_5)
        {

            PlayerPrefs.SetInt("CharacterSelected", index);
            lives = PlayerPrefs.GetInt("lives");
            lives = 4;
            PlayerPrefs.SetInt("lives", lives);
        }

        if (index == 6 && _isBoard_6)
        {

            PlayerPrefs.SetInt("CharacterSelected", index);
            lives = PlayerPrefs.GetInt("lives");
            lives = 5;
            PlayerPrefs.SetInt("lives", lives);
        }

        if (index == 7 && _isBoard_7)
        {

            PlayerPrefs.SetInt("CharacterSelected", index);
            lives = PlayerPrefs.GetInt("lives");
            lives = 4;
            PlayerPrefs.SetInt("lives", lives);
        }

        if (index == 8 && _isBoard_8)
        {

            PlayerPrefs.SetInt("CharacterSelected", index);
            lives = PlayerPrefs.GetInt("lives");
            lives = 5;
            PlayerPrefs.SetInt("lives", lives);
        }

        if (index == 9 && _isBoard_9)
        {

            PlayerPrefs.SetInt("CharacterSelected", index);
            lives = PlayerPrefs.GetInt("lives");
            lives = 5;
            PlayerPrefs.SetInt("lives", lives);
        }

        if (index == 10 && _isBoard_10)
        {

            PlayerPrefs.SetInt("CharacterSelected", index);
            lives = PlayerPrefs.GetInt("lives");
            lives = 5;
            PlayerPrefs.SetInt("lives", lives);
        }
        if (index == 0)
        {
            index = 0;
            PlayerPrefs.SetInt("CharacterSelected", index);
            lives = PlayerPrefs.GetInt("lives");
            lives = 3;
            PlayerPrefs.SetInt("lives", lives);
        }


    }

    public void BuyBoard1()
    {
        diamond = PlayerPrefs.GetInt("diamond");
        if (diamond >= 200)
        {
            diamond = PlayerPrefs.GetInt("diamond");
            diamond -= 200;
            PlayerPrefs.SetInt("diamond", diamond);

            _isBoard_1 = true;
            PlayerPrefs.SetInt("isBoard1", _isBoard_1 ? 1 : 0);
        }
        else
        {
            notCredits.SetActive(true);
            StartCoroutine(NotCredits());
        }
    }

    public void BuyBoard2()
    {
        diamond = PlayerPrefs.GetInt("diamond");
        if (diamond >= 500)
        {
            diamond = PlayerPrefs.GetInt("diamond");
            diamond -= 500;
            PlayerPrefs.SetInt("diamond", diamond);

            _isBoard_2 = true;
            PlayerPrefs.SetInt("isBoard2", _isBoard_2 ? 1 : 0);
        }
        else
        {
            notCredits.SetActive(true);
            StartCoroutine(NotCredits());
        }
    }

    public void BuyBoard3()
    {
        diamond = PlayerPrefs.GetInt("diamond");
        if (diamond >= 1000)
        {
            diamond = PlayerPrefs.GetInt("diamond");
            diamond -= 1500;
            PlayerPrefs.SetInt("diamond", diamond);


            _isBoard_3 = true;
            PlayerPrefs.SetInt("isBoard3", _isBoard_3 ? 1 : 0);


        }
        else
        {
            notCredits.SetActive(true);
            StartCoroutine(NotCredits());
        }
    }

    public void BuyBoard4()
    {
        diamond = PlayerPrefs.GetInt("diamond");
        if (diamond >= 1500)
        {
            diamond = PlayerPrefs.GetInt("diamond");
            diamond -= 1500;
            PlayerPrefs.SetInt("diamond", diamond);

            _isBoard_4 = true;
            PlayerPrefs.SetInt("isBoard4", _isBoard_4 ? 1 : 0);
        }
        else
        {
            notCredits.SetActive(true);
            StartCoroutine(NotCredits());
        }
    }

    public void BuyBoard5()
    {
        diamond = PlayerPrefs.GetInt("diamond");
        if (diamond >= 2000)
        {
            diamond = PlayerPrefs.GetInt("diamond");
            diamond -= 2000;
            PlayerPrefs.SetInt("diamond", diamond);

            _isBoard_5 = true;
            PlayerPrefs.SetInt("isBoard5", _isBoard_5 ? 1 : 0);
        }
        else
        {
            notCredits.SetActive(true);
            StartCoroutine(NotCredits());
        }
    }

    public void BuyBoard6()
    {
        diamond = PlayerPrefs.GetInt("diamond");
        if (diamond >= 3000)
        {
            diamond = PlayerPrefs.GetInt("diamond");
            diamond -= 3000;
            PlayerPrefs.SetInt("diamond", diamond);

            _isBoard_6 = true;
            PlayerPrefs.SetInt("isBoard6", _isBoard_6 ? 1 : 0);
        }
        else
        {
            notCredits.SetActive(true);
            StartCoroutine(NotCredits());
        }
    }

    public void BuyBoard7()
    {
        diamond = PlayerPrefs.GetInt("diamond");
        if (diamond >= 3000)
        {
            diamond = PlayerPrefs.GetInt("diamond");
            diamond -= 3000;
            PlayerPrefs.SetInt("diamond", diamond);

            _isBoard_7 = true;
            PlayerPrefs.SetInt("isBoard7", _isBoard_7 ? 1 : 0);
        }
        else
        {
            notCredits.SetActive(true);
            StartCoroutine(NotCredits());
        }
    }

    public void BuyBoard8()
    {
        diamond = PlayerPrefs.GetInt("diamond");
        if (diamond >= 4000)
        {
            diamond = PlayerPrefs.GetInt("diamond");
            diamond -= 4000;
            PlayerPrefs.SetInt("diamond", diamond);

            _isBoard_8 = true;
            PlayerPrefs.SetInt("isBoard8", _isBoard_8 ? 1 : 0);
        }
        else
        {
            notCredits.SetActive(true);
            StartCoroutine(NotCredits());
        }
    }

    public void BuyBoard9()
    {
        diamond = PlayerPrefs.GetInt("diamond");
        if (diamond >= 4000)
        {
            diamond = PlayerPrefs.GetInt("diamond");
            diamond -= 4000;
            PlayerPrefs.SetInt("diamond", diamond);

            _isBoard_9 = true;
            PlayerPrefs.SetInt("isBoard9", _isBoard_9 ? 1 : 0);
        }
        else
        {
            notCredits.SetActive(true);
            StartCoroutine(NotCredits());
        }
    }

    public void BuyBoard10()
    {
        diamond = PlayerPrefs.GetInt("diamond");
        if (diamond >= 5000)
        {
            diamond = PlayerPrefs.GetInt("diamond");
            diamond -= 5000;
            PlayerPrefs.SetInt("diamond", diamond);

            _isBoard_10 = true;
            PlayerPrefs.SetInt("isBoard10", _isBoard_10 ? 1 : 0);
        }
        else
        {
            notCredits.SetActive(true);
            StartCoroutine(NotCredits());
        }
    }

    void Rewarded(int id)
    {
        if (id == 1)
        {

            diamond = PlayerPrefs.GetInt("diamond");
            diamond += 100;
            PlayerPrefs.SetInt("diamond", diamond);

        }
    }

    void TryRewardShow(int id)
    {
        YandexGame.RewVideoShow(id);

    }

    public void BonusBuy()
    {
        diamond = PlayerPrefs.GetInt("diamond");
        if (diamond >= 300)
        {
            diamond = PlayerPrefs.GetInt("diamond");
            diamond -= 300;
            PlayerPrefs.SetInt("diamond", diamond);
            //heart = PlayerPrefs.GetInt("heart");
            //heart += 3;
            //PlayerPrefs.SetInt("heart", heart);

        }
    }

    public void BonusStart()
    {

        diamond = PlayerPrefs.GetInt("diamond");
        diamond += 400;
        PlayerPrefs.SetInt("diamond", diamond);
        //heart = PlayerPrefs.GetInt("heart");
        //heart += 3;
        //PlayerPrefs.SetInt("heart", heart);
        firstGame = true;
        PlayerPrefs.SetInt("firstGame", firstGame ? 1 : 0);
    }

    private IEnumerator NotCredits()
    {
        yield return new WaitForSeconds(3);
        notCredits.SetActive(false);
    }
}
