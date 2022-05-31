using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SalvatoreFirst : DatingMaster
{

    public GameObject heyBabe;
    public GameObject lowEnthusiasm;
    public GameObject heyHeyHey;
    public GameObject maybeIWasTooHarsh;
    public GameObject youSoundFun;
    public GameObject prettyGoodGtg;
    public GameObject nah;

    // Start is called before the first frame update
    void Start()
    {
        SetAllInactive();
        heyBabe.SetActive(!false);
    }

    // Update is called once per frame
    public override void SetAllInactive()
    {
        heyBabe.SetActive(false);
        lowEnthusiasm.SetActive(false);
        maybeIWasTooHarsh.SetActive(false);
        youSoundFun.SetActive(false);
        prettyGoodGtg.SetActive(false);
        heyHeyHey.SetActive(false);
        dateOption.SetActive(false);
        chatLaterInWeek.SetActive(false);
    }

    public void Hello()
    {
        SetAllInactive();
        heyHeyHey.SetActive(true);
    }

    public void eh()
    {
        SetAllInactive();
        lowEnthusiasm.SetActive(true);
    }

    public void CanYouSayAnythingBesidesHey()
    {
        SetAllInactive();
        nah.SetActive(true);
        Invoke("Unmatch", 2f);
    }

    public void HappyFace()
    {
        SetAllInactive();
        youSoundFun.SetActive(!false);
    }

    public void yeeSureThing()
    {
        SetAllInactive();
        Date();
    }

    public void IdLikeToKnowYouFirst()
    {
        SetAllInactive();
        Invoke("ChatToYouAgainLater", 3f);
    }

    public void FuckYou()
    {
        SetAllInactive();
        Unmatch();
    }

    public void SorryThatsJustHowIAm()
    {
        SetAllInactive();
        maybeIWasTooHarsh.SetActive(!false);
    }

    public void PrettyGoodUntilIOpenedDMs()
    {
        SetAllInactive();
        Unmatch();

    }

    public void PrettyGoodWBU()
    {
        SetAllInactive();
        prettyGoodGtg.SetActive(true);
        Invoke("ChatToYouAgainLater", 3f);
    }
}
