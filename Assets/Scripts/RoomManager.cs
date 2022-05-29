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

    // Start is called before the first frame update
    void Start()
    {
        RemoveAllEventsOccuringText();
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
        SceneManager.LoadScene("AndyFirst");

    }
}
