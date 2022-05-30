using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AndyTwoManager : DatingMaster
{
    public GameObject notreally;
    public GameObject yeahImFollowingThePlan;
    public GameObject sureIReallyNeedToFill;
    public GameObject itsaHugePain;
    public GameObject weCouldTryThatThisWeekend;
    public GameObject firstMessage;

    public void Start()
    {
        SetAllInactive();
        firstMessage.SetActive(true);
    }

    public override void SetAllInactive()
    {
        notreally.SetActive(false);
        yeahImFollowingThePlan.SetActive(false);
        sureIReallyNeedToFill.SetActive(false);
        itsaHugePain.SetActive(false);
        weCouldTryThatThisWeekend.SetActive(false);
        firstMessage.SetActive(false);
    }

    public void AreYouVegetarian()
    {
        SetAllInactive();
        notreally.SetActive(true);
    }

    public void AreYouOnDiet()
    {
        SetAllInactive();

        yeahImFollowingThePlan.SetActive(true);
    }

    public void WeCouldBuySomeFresh()
    {
        SetAllInactive();
        sureIReallyNeedToFill.SetActive(true);
    }

    public void JeeDoYouNeedToTell()
    {
        SetAllInactive();
        Unmatch();
    }

    public void ThatMustTakeALot()
    {
        SetAllInactive();
        itsaHugePain.SetActive(true);
    }

    public void WowThatSucks()
    {
        SetAllInactive();
        chatLaterInWeek.SetActive(true);
    }

    public void HonestlyNotAHugeFan()
    {
        SetAllInactive();
        weCouldTryThatThisWeekend.SetActive(true);
    }

    public void IllSeeYouThere()
    {
        SetAllInactive();
        Date();
    }
}
