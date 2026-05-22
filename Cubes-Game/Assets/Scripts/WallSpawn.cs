using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WallSpawn : MonoBehaviour
{
    public int countWall;
    public int startCount;
    public int limit;

    public GameObject Wall;

    public GameObject WallPlus;
    public GameObject WallPlusText;

    public TextMeshProUGUI wallText;

    [SerializeField] AudioSource audio3;

    [SerializeField] private Button FirtShowButton;

    private void Start()
    {
       
        startCount = 1;
        countWall = startCount;
        PlayerPrefs.SetInt("wall", countWall);
        wallText.text = countWall.ToString();
        limit = 7;
    }

    private void Update()
    {
        countWall = PlayerPrefs.GetInt("wall");
        wallText.text = countWall.ToString();
        if (countWall > 0)
        {

            FirtShowButton.interactable = false;
            WallPlus.SetActive(false);
            WallPlusText.SetActive(true);
        }
        else
        {
            FirtShowButton.interactable = true;
            WallPlus.SetActive(true);
            WallPlusText.SetActive(false);
        }
    }

    public void AvtiveWall()
    {
        countWall = PlayerPrefs.GetInt("wall");
        if (countWall > 0 && limit > 0 )
        {
            Wall.SetActive(true);
            countWall--;
            limit--;
            PlayerPrefs.SetInt("wall", countWall);
            audio3.Play();

        }

        if (countWall > 0)
        {

            FirtShowButton.interactable = false;
        }
        else
        {
            FirtShowButton.interactable = true;
        }

    }
}
