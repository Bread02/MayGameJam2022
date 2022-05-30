using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public StatusManager statusManager;

    public static int day = 0;
    public static int dayTick = 0;

    public GameObject startMatchingScreen;

    public TextMeshProUGUI dayTickText;
    public TextMeshProUGUI dayNumberText;
    public TextMeshProUGUI dayOrNightText;

    // Start is called before the first frame update
    void Start()
    {
    //    dayTick = 0;
   //     day = 0;
        dayOrNightText.text = "Daytime";
        startMatchingScreen.SetActive(false);
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
        }
        if (dayTick == 3)
        {
            dayOrNightText.text = "Afternoon";
        }
        if (dayTick == 4)
        {
            dayOrNightText.text = "Evening";
        }
        if (dayTick == 5)
        {
            StartNight();
        }
        if (dayTick == 6 && day == 15)
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
        day++;
        dayTick = 0;
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
        
    }

  
}
