using System;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Reward : MonoBehaviour
{
    public float msToWait = 5000.0f;
    public Text Timer;
    private Button RewardButton;
    private ulong lastOpen;
    public int coins;
    //86400000

    void Start()
    {
        RewardButton = GetComponent<Button>();
        lastOpen = ulong.Parse(PlayerPrefs.GetString("lastOpen"));
        Timer = GetComponentInChildren<Text>();

        if (!isReady())
        {
            RewardButton.interactable = false;
        }
        //coins = PlayerPrefs.GetInt("coins");
    }

    void Update()
    {
        if (!RewardButton.IsInteractable())
        {
            if (isReady())
            {
                RewardButton.interactable = true;
                Timer.text = " ";
                return;
            }
            ulong diff = ((ulong)DateTime.Now.Ticks - lastOpen);
            ulong m = diff / TimeSpan.TicksPerMillisecond;
            float seconleft = (float)(msToWait - m) / 1000.0f;

            string t = "";

            t += ((int)seconleft / 3600).ToString() + "÷ ";
            seconleft -= ((int)seconleft / 3600) * 3600;
            t += ((int)seconleft / 60).ToString("00") + "ì ";
            t += ((int)seconleft % 60).ToString("00") + "c ";

            Timer.text = t;
        }
    }

    public void ClicReward()
    {
        lastOpen = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("lastOpen", lastOpen.ToString());
        RewardButton.interactable = false;
        coins = PlayerPrefs.GetInt("coins");
        coins += 30;
        PlayerPrefs.SetInt("coins", coins);
        //reward
    }

    private bool isReady()
    {
        ulong diff = ((ulong)DateTime.Now.Ticks - lastOpen);
        ulong m = diff / TimeSpan.TicksPerMillisecond;
        float seconleft = (float)(msToWait - m) / 1000.0f;

        if (seconleft < 0)
        {
            Timer.text = " ";
            return true;
        }
        return false;
    }
}
