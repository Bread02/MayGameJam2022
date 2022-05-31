using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public abstract class DatingMaster : MonoBehaviour
{
    public GameObject unmatch;
    public GameObject dateOption;
    public GameObject chatLaterInWeek;

    public GameObject music;

    public abstract void SetAllInactive();

    public void Unmatch()
    {
        SetAllInactive();
        unmatch.SetActive(true);
        Invoke("Room", 3f);
        music.SetActive(false);

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
        Invoke("Room", 3f);
    }

    public virtual void Room()
    {

        SceneManager.LoadScene("Room");
    }
}
