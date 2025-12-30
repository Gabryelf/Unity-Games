using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusModifikation : MonoBehaviour
{
    public int ship;


    public bool isShip1;
    public bool isShip2;
    public bool isShip3;
    public GameObject shild2;


    void Start()
    {
        ship = PlayerPrefs.GetInt("CharacterSelected");
        isShip1 = PlayerPrefs.GetInt("isShip1") == 1 ? true : false;
        isShip2 = PlayerPrefs.GetInt("isShip2") == 1 ? true : false;
        isShip3 = PlayerPrefs.GetInt("isShip3") == 1 ? true : false;
        if (isShip1 && !isShip2 && !isShip3 && ship == 0)
        {
            shild2.SetActive(true);
            StartCoroutine(StartShild());
        }
        if (isShip1 && isShip2 && !isShip3 && ship == 0)
        {
            shild2.SetActive(true);
            StartCoroutine(StartShild2());
        }
        if (isShip1 && isShip3 && isShip2 && ship == 0)
        {
            shild2.SetActive(true);
            StartCoroutine(StartShild3());
        }
    }

    void Update()
    {

    }


    private IEnumerator StartShild()
    {
        yield return new WaitForSeconds(30);
        shild2.SetActive(false);
    }
    private IEnumerator StartShild2()
    {
        yield return new WaitForSeconds(45);
        shild2.SetActive(false);
    }
    private IEnumerator StartShild3()
    {
        yield return new WaitForSeconds(60);
        shild2.SetActive(false);
    }
}
