using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public StatusManager statusManager;

    public int day;
    public int dayTick;

    public TextMeshProUGUI dayTickText;

    public TextMeshProUGUI dayOrNightText;

    // Start is called before the first frame update
    void Start()
    {
        dayTick = 0;
        dayOrNightText.text = "Daytime";
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
    }

    // trigger evening?
    void IfDayTickIsFive()
    {
        if (dayTick == 5)
        {
            StartEvening();
        }
    }

    public void StartEvening()
    {
        dayOrNightText.text = "Nighttime";
    }

    public void StartNewDay()
    {
        dayTick = 0;
    }
}
