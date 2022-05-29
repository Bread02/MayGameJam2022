using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WojciechFirstManager : MonoBehaviour
{
    [Header("SubCanvases")]


    [Header("Woj's text")]
    public GameObject hey;
    public GameObject youLookKindaCute;
    public GameObject sorryIfISayWeirdThings;
    public GameObject uhhhToLazyToType;
    public GameObject iGuess;
    public GameObject iGuess2;
    public GameObject notInLectureMood;
    public GameObject doYouLikeAnime;
    public GameObject grabCoffee;
    public GameObject typingIconForever;
    public GameObject uhhhthanks;
    public GameObject thatmakesmefeelabit;
    public GameObject okcya;
    public GameObject wowreallycantwait;

    public GameObject unmatch;





    public void Start()
    {
        SetAllInactive();
        hey.SetActive(true);
    }

    public void SetAllInactive()
    {
        hey.SetActive(false);
        youLookKindaCute.SetActive(false);
        sorryIfISayWeirdThings.SetActive(false);
        uhhhToLazyToType.SetActive(false);
        iGuess.SetActive(false);
        notInLectureMood.SetActive(false);
        doYouLikeAnime.SetActive(false);
        grabCoffee.SetActive(false);
        typingIconForever.SetActive(false);
        uhhhthanks.SetActive(false);
        thatmakesmefeelabit.SetActive(false);
        unmatch.SetActive(false);
        iGuess2.SetActive(false);

    }

    #region Buttons
    public void helloSmiley()
    {
        SetAllInactive();
        uhhhToLazyToType.SetActive(!false);
    }
    public void wave()
    {
        SetAllInactive();
        uhhhToLazyToType.SetActive(!false);

    }
    public void hi()
    {
        SetAllInactive();
        youLookKindaCute?.SetActive(!false);

    }
    public void Isthatacomplimentcreep()
    {
        SetAllInactive();
        Unmatch();

    }
    public void ThanksIGuess()
    {
        SetAllInactive();
        sorryIfISayWeirdThings.SetActive(!false);
    }
    public void Dontworryaboutit()
    {
        SetAllInactive();
        doYouLikeAnime?.SetActive(!false);

    }
    public void NoWonderLMAO()
    {
        SetAllInactive();
        Unmatch();

    }
    public void WarAndPeace()
    {
        SetAllInactive();
        Unmatch();
    }
    public void Doesntsoundlikeyourinmood()
    {
        SetAllInactive();
        notInLectureMood.SetActive(true);
        Invoke("Unmatch", 3f);
    }

    public void ArentWeAll()
    {
        SetAllInactive();
        iGuess.SetActive(true);
    }

    public void IDontHaveAllDay()
    {
        SetAllInactive();
        Unmatch();

    }

    public void YouDontHaveToDoWhittyLines()
    {
        SetAllInactive();
        uhhhthanks.SetActive(true);
    }

    public void WeWouldntBeHereIfIWasntInterested()
    {
        SetAllInactive();
        thatmakesmefeelabit.SetActive(true);
    }

    public void JesusCanWeJusthave()
    {
        SetAllInactive();
        Unmatch();

    }

    public void wecanchatwhenyoufeelbetter()
    {
        SetAllInactive();
        Invoke("Room", 3f);
    }

    public void feelingdowntoday()
    {
        SetAllInactive();
        iGuess2.SetActive(true);
    }

    public void canchatwhenfeelilngbetter()
    {
        SetAllInactive();
        Invoke("Room", 3f);
    }
    public void GotToGoNow()
    {
        SetAllInactive();
        okcya.SetActive(true);
        Invoke("Room", 3f);

    }

    public void WeCouldChatMoreOverA()
    {
        SetAllInactive();
        wowreallycantwait.SetActive(true);
        Invoke("Room", 3f);
    }

    public void Unmatch()
    {
        SetAllInactive();
        unmatch.SetActive(true);
        Invoke("Room", 3f);
    }

    public void Room()
    {
        SceneManager.LoadScene("Room");
    }
    #endregion

}
