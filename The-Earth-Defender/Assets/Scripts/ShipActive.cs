using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipActive : MonoBehaviour
{
    public int activeIndex;

    [SerializeField] private GameObject Board;
    [SerializeField] private GameObject Board1;
    [SerializeField] private GameObject Board2;
    [SerializeField] private GameObject Board3;
    [SerializeField] private GameObject Board4;
    [SerializeField] private GameObject Board5;
    [SerializeField] private GameObject Board6;
    [SerializeField] private GameObject Board7;
    [SerializeField] private GameObject Board8;
    [SerializeField] private GameObject Board9;
    [SerializeField] private GameObject Board10;



    void Start()
    {
        activeIndex = PlayerPrefs.GetInt("CharacterSelected");


        if (activeIndex == 0)
        {
            Board.SetActive(true);
        }
        else
        {
            Board.SetActive(false);
        }
        if (activeIndex == 1)
        {
            Board1.SetActive(true);
        }
        else
        {
            Board1.SetActive(false);
        }
        if (activeIndex == 2)
        {
            Board2.SetActive(true);
        }
        else
        {
            Board2.SetActive(false);
        }
        if (activeIndex == 3)
        {
            Board3.SetActive(true);
        }
        else
        {
            Board3.SetActive(false);
        }
        if (activeIndex == 4)
        {
            Board4.SetActive(true);
        }
        else
        {
            Board4.SetActive(false);
        }
        if (activeIndex == 5)
        {
            Board5.SetActive(true);
        }
        else
        {
            Board5.SetActive(false);
        }
        if (activeIndex == 6)
        {
            Board6.SetActive(true);
        }
        else
        {
            Board6.SetActive(false);
        }
        if (activeIndex == 7)
        {
            Board7.SetActive(true);
        }
        else
        {
            Board7.SetActive(false);
        }
        if (activeIndex == 8)
        {
            Board8.SetActive(true);
        }
        else
        {
            Board8.SetActive(false);
        }
        if (activeIndex == 9)
        {
            Board9.SetActive(true);
        }
        else
        {
            Board9.SetActive(false);
        }
        if (activeIndex == 10)
        {
            Board10.SetActive(true);
        }
        else
        {
            Board10.SetActive(false);
        }
    }

    private void Update()
    {
        activeIndex = PlayerPrefs.GetInt("CharacterSelected");


        if (activeIndex == 0)
        {
            Board.SetActive(true);
        }
        else
        {
            Board.SetActive(false);
        }
        if (activeIndex == 1)
        {
            Board1.SetActive(true);
        }
        else
        {
            Board1.SetActive(false);
        }
        if (activeIndex == 2)
        {
            Board2.SetActive(true);
        }
        else
        {
            Board2.SetActive(false);
        }
        if (activeIndex == 3)
        {
            Board3.SetActive(true);
        }
        else
        {
            Board3.SetActive(false);
        }
        if (activeIndex == 4)
        {
            Board4.SetActive(true);
        }
        else
        {
            Board4.SetActive(false);
        }
        if (activeIndex == 5)
        {
            Board5.SetActive(true);
        }
        else
        {
            Board5.SetActive(false);
        }
        if (activeIndex == 6)
        {
            Board6.SetActive(true);
        }
        else
        {
            Board6.SetActive(false);
        }
        if (activeIndex == 7)
        {
            Board7.SetActive(true);
        }
        else
        {
            Board7.SetActive(false);
        }
        if (activeIndex == 8)
        {
            Board8.SetActive(true);
        }
        else
        {
            Board8.SetActive(false);
        }
        if (activeIndex == 9)
        {
            Board9.SetActive(true);
        }
        else
        {
            Board9.SetActive(false);
        }
        if (activeIndex == 10)
        {
            Board10.SetActive(true);
        }
        else
        {
            Board10.SetActive(false);
        }
    }
}
