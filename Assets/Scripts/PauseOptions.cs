using UnityEngine;
using System.Collections;

public class PauseOptions : MonoBehaviour 
{
    // variables to GUI
    public GameObject GOPauseUI, GOScore, GOSound;
    public static bool flgPaused = false;

    void Start()
    {
        GOPauseUI.SetActive(false);
    }

    void Update()
    {
       // OnMouseDown();
        if (flgPaused)
        {
            GOPauseUI.SetActive(true);
            GOScore.SetActive(false);
            Time.timeScale = 0;
        }
        if(!flgPaused)
        {
            GOPauseUI.SetActive(false);
            GOScore.SetActive(true);
            Time.timeScale = 1;
        }
    }

    void OnMouseDown()
    {
        flgPaused = true;
    }

    public void Resume()
    {
        flgPaused = !flgPaused;
    }

    public void Restart()
    {
        flgPaused = false;
        Application.LoadLevel(Application.loadedLevel);
    }

    public void MainMenu()
    {
        flgPaused = false;
        Application.LoadLevel("rm_start");
    }

    public void Sound()
    {
        GOSound.SetActive(true);
    }

    public void BackSound()
    {
        GOSound.SetActive(false);
    }

}
