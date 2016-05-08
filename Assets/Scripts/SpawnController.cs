using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {

    // Variables
    public GameObject prefabObstacle;       // spawn object - obstacle
    
    public float currentTime;               // time to next spawn
    private float yBottom;

    // levels
    
    private float minRandom, maxRandom;
    private float distance;
    private float rateSpawn;                 // spawn interval


	// Use this for initialization
	void Start () {
        currentTime = 0;
        if (StartOptions.difficulty == "normal")
        {
            distance = 34f;
            minRandom = -25.25f;
            maxRandom = -7f;
            rateSpawn = 5f;
        }
        else if (StartOptions.difficulty == "hard")
        {
            distance = 32f;
            minRandom = -25.25f;
            maxRandom = -7f;
            rateSpawn = 4f;
        }
        else if (StartOptions.difficulty == "expert")
        {
            distance = 30f;
            minRandom = -25.25f;
            maxRandom = -7f;
            rateSpawn = 4f;
        }
	}
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        yBottom = Random.Range(minRandom, maxRandom);

        if (currentTime >= rateSpawn)
        {           
            currentTime = 0;
            GameObject tempPrefabTop = Instantiate(prefabObstacle) as GameObject;
            GameObject tempPrefabBot = Instantiate(prefabObstacle) as GameObject;
            tempPrefabTop.transform.position = new Vector3(transform.position.x, yBottom + distance, tempPrefabTop.transform.position.z);
            tempPrefabTop.transform.Rotate(new Vector3(0, 0, 180));
            tempPrefabBot.transform.position = new Vector3(transform.position.x, yBottom, tempPrefabTop.transform.position.z);
        }

	}
}
