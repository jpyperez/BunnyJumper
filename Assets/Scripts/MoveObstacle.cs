using UnityEngine;
using System.Collections;

public class MoveObstacle : MonoBehaviour {
    
    // Variables
    public float speed;
    private float x;
    private GameObject player;
    private bool flgScored;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
        x = transform.position.x;
        x += speed * Time.deltaTime;

        transform.position = new Vector3(x, transform.position.y, transform.position.z);

        // get out of scene - destroy obstacle
        if (x <= -30)
            Destroy(transform.gameObject);

        // Scoring
        if (x < player.transform.position.x && !flgScored)
        {
            MovePlayer.score += 0.5f;
            flgScored = true;
        }
	}
}
