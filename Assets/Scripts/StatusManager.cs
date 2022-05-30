using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StatusManager : MonoBehaviour
{
    [Header("Status Floats")]
    public static float sanity = 100;
    public static float physicalHealth = 100;

    [Header("Status Bar Images")]
    public Image sanityImage;
    public Image physicalHealthImage;

    // Keeps the status floats linked with the status bar images.
    public void Update()
    {
        sanityImage.fillAmount = sanity / 100;
        physicalHealthImage.fillAmount = physicalHealth / 100;
    }

    public void TickStatusChecks()
    {
        PhysicalHealthIsZero();
        SanityIsZero();
    }

    public void CapStats()
    {
        if(sanity > 100)
        {
            sanity = 100;
        }

        if(physicalHealth > 100)
        {
            physicalHealth = 100;
        }
    }

    public void Study()
    {
        sanity -= 20;
        physicalHealth -= 20;

        CapStats();
    }

    public void Sleep()
    {
        sanity += 20;
        physicalHealth += 20;

        CapStats();
    }

    public void PlayVideoGames()
    {
        CapStats();
    }

    public void SurfTheWeb()
    {
        CapStats();
    }

    public void GoForAWalk()
    {
        CapStats();
    }


    public void SanityIsZero()
    {
        // game over
        if (sanity <= 0)
        {
            SceneManager.LoadScene("SanityGameOver");
            return;
        }
    }

    public void PhysicalHealthIsZero()
    {
        // game over
        if (physicalHealth <= 0)
        {
            SceneManager.LoadScene("PhysicalHealthGameOver");
            return;
        }
    }

}
