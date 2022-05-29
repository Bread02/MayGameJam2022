using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AndyFirstManager : MonoBehaviour
{

    public GameObject hey;
    public GameObject whatYouHaveForLunch;
    public GameObject emojiFire;

    public GameObject niceAnyAlmonds;
    public GameObject coolSoundsTasty;
    public GameObject canGetYouAlmonds;
    public GameObject seeYouNearDescos;

    public GameObject okSadFace;
    public GameObject circleHandEmoji;
    public GameObject winkEmoji;
    public GameObject ironAndCuteness;

    public GameObject obi;
    public GameObject general;
    public GameObject theNewMovieIsComing;

    public GameObject unmatch;


    // Start is called before the first frame update
    void Start()
    {
        SetAllInactive();
        hey.SetActive(true);

    }


    public void SetAllInactive()
    {
        SetAllInactive();

        hey.SetActive(false);
        whatYouHaveForLunch.SetActive(false);
    }

    public void HelloThere()
    {
        SetAllInactive();
        obi.SetActive(true);
    }

    public void Yo()
    {
        SetAllInactive();

        whatYouHaveForLunch.SetActive(true);
    }

    public void Wave()
    {
        SetAllInactive();
        emojiFire.SetActive(true);
    }

    public void HighProteinTrailMix()
    {
        SetAllInactive();
        niceAnyAlmonds.SetActive(true);
    }

    public void BaconPizza()
    {
        SetAllInactive();
        coolSoundsTasty.SetActive(true);
    }

    public void yeah()
    {
        SetAllInactive();
        canGetYouAlmonds.SetActive(true);
    }

    public void imgladyoulikeemojistoo()
    {
        SetAllInactive();
        circleHandEmoji.SetActive(true);
    }

    public void didntthinkyoulikecute()
    {
        SetAllInactive();
        ironAndCuteness.SetActive(true);
    }

    public void thanksbutidliketoknowyoubetter()
    {
        SetAllInactive();

    }

    public void wowthanks()
    {
        SetAllInactive();
    }

    public void yumFace()
    {
        SetAllInactive();
        winkEmoji.SetActive(true);
    }

    public void stopthisemojicringe()
    {
        SetAllInactive();
        okSadFace.SetActive(true);
        Invoke("Unmatch", 3f);
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
}
