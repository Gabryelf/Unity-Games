using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BombSpawn : MonoBehaviour
{
    public int countBomb;
    public int startCount;
    public int limit;

    public GameObject bombButtonPlus;
    public GameObject bombButtonPlusText;
    public GameObject bomb;
    public GameObject bomb2;
    public GameObject bomb3;
    public GameObject bomb4;
    public GameObject bomb5;
    public GameObject bomb6; 
    public GameObject bomb7;

    public TextMeshProUGUI bombText;

    [SerializeField] AudioSource audio2;

    [SerializeField] private Button FirtShowButton;

  

    private void Start()
    {
      
        startCount = 1;
        countBomb = startCount;
        PlayerPrefs.SetInt("bomb", countBomb);
        bombText.text = countBomb.ToString();
        limit = 7;
    }

    private void Update()
    {
        countBomb = PlayerPrefs.GetInt("bomb");
        bombText.text = countBomb.ToString();
        if (countBomb > 0)
        {

            FirtShowButton.interactable = false;
            bombButtonPlus.SetActive(false);
            bombButtonPlusText.SetActive(true);
           
        }
        else
        {
            FirtShowButton.interactable = true;
            bombButtonPlus.SetActive(true);
            bombButtonPlusText.SetActive(false);
            
        }
    }

    public void AvtiveBomb()
    {
        countBomb = PlayerPrefs.GetInt("bomb");
        if(countBomb > 0 && limit == 7)
        {
            bomb.SetActive(true);
            countBomb--;
            limit--;
            PlayerPrefs.SetInt("bomb", countBomb);
            audio2.Play();
        }
        if (countBomb > 0 && limit == 6)
        {
            bomb2.SetActive(true);
            countBomb--;
            limit--;
            PlayerPrefs.SetInt("bomb", countBomb);
            audio2.Play();
        }
        if (countBomb > 0 && limit == 5)
        {
            bomb3.SetActive(true);
            countBomb--;
            limit--;
            PlayerPrefs.SetInt("bomb", countBomb);
            audio2.Play();
        }
        if (countBomb > 0 && limit == 4)
        {
            bomb4.SetActive(true);
            countBomb--;
            limit--;
            PlayerPrefs.SetInt("bomb", countBomb);
            audio2.Play();
        }
        if (countBomb > 0 && limit == 3)
        {
            bomb5.SetActive(true);
            countBomb--;
            limit--;
            PlayerPrefs.SetInt("bomb", countBomb);
            audio2.Play();
        }
        if (countBomb > 0 && limit == 2)
        {
            bomb6.SetActive(true);
            countBomb--;
            limit--;
            PlayerPrefs.SetInt("bomb", countBomb);
            audio2.Play();
        }
        if (countBomb > 0 && limit == 1)
        {
            bomb7.SetActive(true);
            countBomb--;
            limit--;
            PlayerPrefs.SetInt("bomb", countBomb);
            audio2.Play();

        }
        if (limit <= 0)
        {

            FirtShowButton.interactable = false;
        }
        
        if (countBomb > 0)
        {

            FirtShowButton.interactable = false;
        }
        else
        {
            FirtShowButton.interactable = true;
        }

    }

  
}
