using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public abstract class DatingMaster : MonoBehaviour
{
    public GameObject unmatch;
    public GameObject dateOption;
    public GameObject chatLaterInWeek;

    public abstract void SetAllInactive();

    public void Unmatch()
    {
        SetAllInactive();
        unmatch.SetActive(true);
        Invoke("Room", 3f);
    }


    public void Date()
    {
        SetAllInactive();
        dateOption.SetActive(true);
        Invoke("Room", 3f);
    }

    public void ChatLater()
    {
        chatLaterInWeek.SetActive(true);
        Debug.Log("Invoke room");
        Invoke("Room", 3f);
    }

    public virtual void Room()
    {

        SceneManager.LoadScene("Room");
    }
}
