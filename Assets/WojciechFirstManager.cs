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
    public GameObject notInLectureMood;
    public GameObject doYouLikeAnime;
    public GameObject grabCoffee;
    public GameObject typingIconForever;
    public GameObject uhhhthanks;
    public GameObject thatmakesmefeelabit;
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

    }
    public void Dontworryaboutit()
    {
        SetAllInactive();

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

    public void ArentWeAll()
    {
        SetAllInactive();

    }

    public void IDontHaveAllDay()
    {
        SetAllInactive();

    }

    public void YouDontHaveToDoWhittyLines()
    {
        SetAllInactive();

    }

    public void WeWouldntBeHereIfIWasntInterested()
    {
        SetAllInactive();

    }

    public void JesusCanWeJusthave()
    {
        SetAllInactive();
        Unmatch();

    }
    public void GotToGoNow()
    {
        SetAllInactive();

    }

    public void WeCouldChatMoreOverA()
    {
        SetAllInactive();

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
