using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIElement : MonoBehaviour
{
    public GameObject imageOnButton;
    public bool isActive = true;

    public void ActivateImage()
    {
        if(isActive)
        {
            imageOnButton.SetActive(false);
            isActive = false;
        }
        else
        {
            imageOnButton.SetActive(true);
            isActive = true;
        }
        
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
