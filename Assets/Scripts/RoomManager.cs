using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class RoomManager : MonoBehaviour
{
    [Header("Other Scripts")]
    public StatusManager statusManager;
    public TimeManager timeManager;

    [Header("Events Text")]
    public GameObject studyText;
    public GameObject sleptText;
    public GameObject videoGamesText;
    public GameObject surfedTheWebText;
    public GameObject wentForAWalkText;

    [Header("Matching Screens")]
    public GameObject andy;
    public GameObject salvatore;
    public GameObject wojciech;

    // Start is called before the first frame update
    void Start()
    {
        RemoveAllEventsOccuringText();
        andy.SetActive(true);
        salvatore.SetActive(false);
        wojciech.SetActive(false);
    }

    public void RemoveAllEventsOccuringText()
    {
        studyText.SetActive(false);
        sleptText.SetActive(false);
        videoGamesText.SetActive(false);
        surfedTheWebText.SetActive(false);
        wentForAWalkText.SetActive(false);
    }


    public void Study()
    {
        statusManager.Study();
        studyText.SetActive(true);
        timeManager.IncrementDayTick();
        Invoke("RemoveAllEventsOccuringText", 2f);
    }

    public void Sleep()
    {
        statusManager.Sleep();
        sleptText.SetActive(true);
        timeManager.IncrementDayTick();
        andy.SetActive(true);
        wojciech.SetActive(false);
        salvatore.SetActive(false);
        Invoke("RemoveAllEventsOccuringText", 2f);

    }

    public void PlayVideoGames()
    {
        statusManager.PlayVideoGames();
        videoGamesText.SetActive(true);
        timeManager.IncrementDayTick();

        Invoke("RemoveAllEventsOccuringText", 2f);

    }

    public void SurfTheWeb()
    {
        statusManager.SurfTheWeb();
        surfedTheWebText?.SetActive(true);
        timeManager.IncrementDayTick();

        Invoke("RemoveAllEventsOccuringText", 2f);

    }

    public void GoForAWalk()
    {
        statusManager.GoForAWalk();
        wentForAWalkText?.SetActive(true);
        timeManager.IncrementDayTick();

        Invoke("RemoveAllEventsOccuringText", 2f);

    }

    public void Salvatore()
    {
        SceneManager.LoadScene("SalvatoreFirst");
    }

    public void Wojciech()
    {
        SceneManager.LoadScene("WojciechFirst");
    }

    public void Andy()
    {
        if (ConversationTracker.andyOne == true)
        {
            SceneManager.LoadScene("AndyFirst");
        }
        if(ConversationTracker.andyTwo == true)
        {
            SceneManager.LoadScene("AndyTwo");
        }
        if (ConversationTracker.andyThree == true)
        {
            SceneManager.LoadScene("AndyTwo");

        }

    }

    public void AndyNo()
    {
        andy.SetActive(false);
        wojciech.SetActive(true);
    }

    public void WojciechNo()
    {
        wojciech.SetActive(false);
        salvatore.SetActive(true);
    }


}
