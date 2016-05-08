using UnityEngine;
using System.Collections;

public class MenuOptions : MonoBehaviour {

    // variables
    public GameObject GOMenu, GOPlay, GORecord, GOInstructions, GOSound;
    public AudioSource ASSound, ASFx;

    // Buttons pressed
    public void OnPlay()
    {
        GOMenu.SetActive(false);
        GOPlay.SetActive(true);
        GORecord.SetActive(false);
        GOInstructions.SetActive(false);
        GOSound.SetActive(false);
    }

    public void OnRecord()
    {
        GOMenu.SetActive(false);
        GOPlay.SetActive(false);
        GORecord.SetActive(true);
        GOInstructions.SetActive(false);
        GOSound.SetActive(false);
    }

    public void OnInstructions()
    {
        GOMenu.SetActive(false);
        GOPlay.SetActive(false);
        GORecord.SetActive(false);
        GOInstructions.SetActive(true);
        GOSound.SetActive(false);
    }

    public void OnSound()
    {
        GOMenu.SetActive(false);
        GOPlay.SetActive(false);
        GORecord.SetActive(false);
        GOInstructions.SetActive(false);
        GOSound.SetActive(true);
    }


}
