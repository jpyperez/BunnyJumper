using UnityEngine;
using System.Collections;

public class ChooseLevel : MonoBehaviour {

    public GameObject GONormal, GOHard, GOExpert, GONotHard, GONotExpert, GOTextLocked;
    private float elapsedTime;
    private bool flgClicked;

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetFloat("RecordNormal") >= 50)
        {
            GONotHard.SetActive(false);
            GOHard.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("RecordHard") >= 50)
        {
            GONotExpert.SetActive(false);
            GOExpert.SetActive(true);
        }
	}

    void Update()
    {
        if (flgClicked)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= 3)
            {
                GOTextLocked.SetActive(false);
                elapsedTime = 0;
                flgClicked = false;
            }
        }
    }

    // Buttons
    public void OnNormal()
    {
        StartOptions.SetNormal();
        Application.LoadLevel("rm_game");
    }

    public void OnHard() 
    {
        StartOptions.SetHard();
        Application.LoadLevel("rm_game");
    }

    public void OnExpert()
    {
        StartOptions.SetExpert();
        Application.LoadLevel("rm_game");
    }

    public void OnLockedLevel()
    {
        flgClicked = true;
        //Debug.Log("time " + elapsedTime);
        if(flgClicked)
            GOTextLocked.SetActive(true);

    }

}
