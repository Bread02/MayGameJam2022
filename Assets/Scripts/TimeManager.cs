using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public StatusManager statusManager;

    public static int day = 0;
    public static int dayTick = 0;

    public GameObject startMatchingScreen;

    public TextMeshProUGUI dayTickText;
    public TextMeshProUGUI dayNumberText;
    public TextMeshProUGUI dayOrNightText;

    public GameObject background1;
    public GameObject background2;
    public GameObject background3;
    public GameObject background4;
    public GameObject background5;

    // Start is called before the first frame update
    void Start()
    {
    //    dayTick = 0;
   //     day = 0;
        dayOrNightText.text = "Daytime";
        startMatchingScreen.SetActive(false);
        dayTick++;
        IfDayTickIsFive();
    }

    public void SetAllBackGroundsInactive()
    {
        background1.SetActive(false);
        background2.SetActive(false);
        background3.SetActive(false);
        background4.SetActive(false);
        background5.SetActive(false);
    }

    public void IncrementDayTick()
    {
        dayTick++;
        statusManager.TickStatusChecks();
        IfDayTickIsFive();
    }

    // Update is called once per frame
    void Update()
    {
        dayTickText.text = "Tick: " + dayTick.ToString();
        dayNumberText.text = "Day: " + day.ToString();
    }

    // trigger evening?
    void IfDayTickIsFive()
    {
        if (dayTick == 1)
        {
            dayOrNightText.text = "Morning";
            SetAllBackGroundsInactive();
            background1.SetActive(true);
        }
        if (dayTick == 2)
        {
            SetAllBackGroundsInactive();
            background2.SetActive(true);
        }

        if (dayTick == 3)
        {
            SetAllBackGroundsInactive();
            background3.SetActive(true);

            dayOrNightText.text = "Afternoon";
        }
        if (dayTick == 4)
        {
            SetAllBackGroundsInactive();
            background4.SetActive(true);

            dayOrNightText.text = "Evening";
        }
        if (dayTick == 5)
        {
            SetAllBackGroundsInactive();
            background5.SetActive(true);

            StartNight();
        }
        if (dayTick == 1 && day == 15)
        {
            Day15();
        }

        if (dayTick == 6 && day != 15)
        {
            StartNewDay();
        }
    }

    void StartNewDay()
    {
        if(day == 10)
        {
            Day15();
        }
        day++;
        dayTick = 1;
        SetAllBackGroundsInactive();
        background1.SetActive(true);

        dayOrNightText.text = "Morning";
    }

    public void StartNight()
    {
        dayOrNightText.text = "Nighttime";
        StartDating();
    }

    public void StartDating()
    {
        startMatchingScreen.SetActive(true);
    }

    public void GoToSleepInsteadOfDating()
    {
        startMatchingScreen.SetActive(false);
        StartNewDay();
    }

    public void Day15()
    {
        SceneManager.LoadScene("HeartBroken");
    }

  
}
