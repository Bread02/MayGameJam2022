using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndyThreeManager : DatingMaster
{

    public GameObject idLoveToJoinYou;
    public GameObject idNeedToPrep;
    public GameObject thanksIReallyAppreciate;
    public GameObject yeahSure;
    public GameObject firstMessage;

    public void Start()
    {
        SetAllInactive();
        firstMessage.SetActive(true);
    }

    public override void SetAllInactive()
    {
        idLoveToJoinYou.SetActive(false);
        idNeedToPrep.SetActive(false);
        thanksIReallyAppreciate.SetActive(false);
        yeahSure.SetActive(false);
        firstMessage.SetActive(false);
    }

    public void HeyPizza()
    {
        SetAllInactive();
        idLoveToJoinYou.SetActive(true);
    }

    public void howCome()
    {
        SetAllInactive();
        idNeedToPrep.SetActive(true);

    }

    public void IHopeYourShow()
    {
        SetAllInactive();
        thanksIReallyAppreciate.SetActive(true);
    }

    public void AreYouSureEatingDisorder()
    {
        SetAllInactive();
        Unmatch();

    }

    public void ImSureYoullDoWell()
    {
        SetAllInactive();
        ChatLater();
    }

    public void MaybeWeCouldGo()
    {
        SetAllInactive();
        yeahSure.SetActive(true);
        Invoke("Date", 2f);
    }
}
