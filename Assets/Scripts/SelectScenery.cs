using UnityEngine;
using System.Collections;

public class SelectScenery : MonoBehaviour {

    // Textures (bg)
    public Material matBGNormal, matBGHard, matBGExpert;
    public Material matFloorNormal, matFloorHard, matFloorExpert;
    public MeshRenderer MRBG, MRFloor, MRCeiling;
    public Sprite sprObsNormal, sprObsHard, sprObsExpert;
    public SpriteRenderer SRObstacle;
    public GameObject GOFloor, GOCeiling;

	// Use this for initialization
	void Start () 
    {
        if (StartOptions.difficulty == "normal")
        {
            MRBG.material = matBGNormal;
            MRCeiling.material = MRFloor.material = matFloorNormal;
            SRObstacle.sprite = sprObsNormal;
        }
        else if (StartOptions.difficulty == "hard")
        {
            MRBG.material = matBGHard;
            MRCeiling.material = MRFloor.material = matFloorHard;
            SRObstacle.sprite = sprObsHard;
        }
        else if (StartOptions.difficulty == "expert")
        {
            MRBG.material = matBGExpert;
            MRCeiling.material = MRFloor.material = matFloorExpert;
            SRObstacle.sprite = sprObsExpert;
            GOFloor.GetComponent<MoveScenario>().speed = +1.0f;
            GOCeiling.GetComponent<MoveScenario>().speed = -1.0f;
        }
	}
	
	// Update is called once per frame
	void Update () 
    {

	}
}
