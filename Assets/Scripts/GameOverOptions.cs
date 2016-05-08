using UnityEngine;
using System.Collections;

public class GameOverOptions : MonoBehaviour {

    // Variables
    public UnityEngine.UI.Text score,
        record;

	// Use this for initialization
	void Start () {

        if (StartOptions.difficulty == "normal")
        {
            score.text = PlayerPrefs.GetFloat("ScoreNormal").ToString();
            record.text = PlayerPrefs.GetFloat("RecordNormal").ToString();
        }
        else if (StartOptions.difficulty == "hard")
        {
            score.text = PlayerPrefs.GetFloat("ScoreHard").ToString();
            record.text = PlayerPrefs.GetFloat("RecordHard").ToString();
        }
        else if (StartOptions.difficulty == "expert")
        {
            score.text = PlayerPrefs.GetFloat("ScoreExpert").ToString();
            record.text = PlayerPrefs.GetFloat("RecordExpert").ToString();
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Restart()
    {
        Application.LoadLevel("rm_game");
    }

    public void Menu()
    {
        Application.LoadLevel("rm_start");
    }
}
