using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VolumeController : MonoBehaviour {

    // variables
    public static float volSound, volFX;
    public Slider SSound, SFX;


	// Use this for initialization
	void Start () {
        volFX = PlayerPrefs.GetFloat("VolumeFX");
        volSound = PlayerPrefs.GetFloat("VolumeSound");
        SSound.value = volSound;
        SFX.value = volFX;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SoundController()
    {
        volSound = SSound.value;
        PlayerPrefs.SetFloat("VolumeSound", volSound);
    }

    public void FXController()
    {   
        volFX = SFX.value;
        PlayerPrefs.SetFloat("VolumeFX", volFX);
    }

}
