using UnityEngine;
using System.Collections;

public class RecordView : MonoBehaviour {

    public UnityEngine.UI.Text recordNormal, recordHard, recordExpert;

	// Use this for initialization
	void Start () {
        recordNormal.text = PlayerPrefs.GetFloat("RecordNormal").ToString();
        recordHard.text = PlayerPrefs.GetFloat("RecordHard").ToString();
        recordExpert.text = PlayerPrefs.GetFloat("RecordExpert").ToString();
	}
	
}
