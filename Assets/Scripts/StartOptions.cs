using UnityEngine;
using System.Collections;

public class StartOptions : MonoBehaviour {

    // Variables
    public static string difficulty;
    public static string language = "portuguese";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("rm_game");
        }
	}

    public static void SetNormal()
    {
        difficulty = "normal";
    }

    public static void SetHard()
    {
        difficulty = "hard";
    }

    public static void SetExpert()
    {
        difficulty = "expert";
    }
}
