using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Shop : MonoBehaviour
{

    public int credit;


    public bool isShip1;
    public bool isShip2;
    public bool isShip3;



    public GameObject plusBut1;
    public GameObject plusBut2;
    public GameObject plusBut3;
    public GameObject cellIcon;


    public GameObject modActive;
    public GameObject modActive2;
    public GameObject notCredits;

    public GameObject mod1;


    void Start()
    {
        
    }

    
    void Update()
    {
        isShip1 = PlayerPrefs.GetInt("isShip1") == 1 ? true : false;
        isShip2 = PlayerPrefs.GetInt("isShip2") == 1 ? true : false;
        isShip3 = PlayerPrefs.GetInt("isShip3") == 1 ? true : false;


        if (isShip1)
        {
            plusBut1.SetActive(false);
            plusBut2.SetActive(true);
            plusBut3.SetActive(false);
            mod1.SetActive(true);
        }
       

        if (isShip2)
        {
            plusBut1.SetActive(false);
            plusBut2.SetActive(false);
            plusBut3.SetActive(true);


        }

        if (isShip3)
        {
            plusBut1.SetActive(false);
            plusBut3.SetActive(false);
            plusBut2.SetActive(false);
            cellIcon.SetActive(false);
}
    }

    public void BuyShip1()
    {
        credit = PlayerPrefs.GetInt("diamond");
        if(credit >= 200)
        {
            isShip1 = true;
            PlayerPrefs.SetInt("isShip1", isShip1 ? 1 : 0);
            credit -= 200;
            PlayerPrefs.SetInt("diamond", credit);
            StartCoroutine(ModActive());
        }
        else
        {
            notCredits.SetActive(true);
            StartCoroutine(NotCredits());
        }
    }

    public void BuyShip2()
    {
        credit = PlayerPrefs.GetInt("diamond");
        if (credit >= 200)
        {
            isShip2 = true;
            PlayerPrefs.SetInt("isShip2", isShip2 ? 1 : 0);
            credit -= 200;
            PlayerPrefs.SetInt("diamond", credit);
            StartCoroutine(ModActive());
        }
        else
        {
            notCredits.SetActive(true);
            StartCoroutine(NotCredits());
        }
    }

    public void BuyShip3()
    {
        credit = PlayerPrefs.GetInt("diamond");
        if (credit >= 200)
        {
            isShip3 = true;
            PlayerPrefs.SetInt("isShip3", isShip3 ? 1 : 0);
            credit -= 200;
            PlayerPrefs.SetInt("diamond", credit);
            StartCoroutine(ModActive());
        }
        else
        {
            notCredits.SetActive(true);
            StartCoroutine(NotCredits());
        }
    }


    private IEnumerator ModActive()
    {
        modActive.SetActive(true);
        modActive2.SetActive(true);
        yield return new WaitForSeconds(5);
        modActive.SetActive(false);
        modActive2.SetActive(false);
    }

    private IEnumerator NotCredits()
    {
        yield return new WaitForSeconds(3);
        notCredits.SetActive(false);
    }
}
