using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

    public AudioClip ACSound;
    public AudioSource ASSound;

	// Use this for initialization
	void Start () {
        ASSound.clip = ACSound;
        ASSound.Play();
	}

    void Update()
    {
        ASSound.volume = VolumeController.volSound;
    }
	
}
