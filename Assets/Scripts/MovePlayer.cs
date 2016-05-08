using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

    // Variables
    public Animator playerAnm;
    public Rigidbody2D playerRb;
    public GameObject player;
    public float speed;
    private bool flgJump;
    static int timerPressed = 0;

    public Transform groundCheck;
    public bool flgGround;                      // Verify if player is on the ground
    public LayerMask lmGround;                  // this will save the layer ground

    public UnityEngine.UI.Text txtScore;
    public static float score;

    public AudioSource audioSource;
    public AudioClip acJump;
    
    // Use this for inicialization
    void Start()
    {
        playerAnm = gameObject.GetComponent<Animator>();
        score = 0;
        PlayerPrefs.SetFloat("Score", score);
    }

	// Update is called once per frame
	void Update () 
    {
        txtScore.text = score.ToString();

        if (Input.GetMouseButton(0) && flgGround && !PauseOptions.flgPaused)
        {
            timerPressed++;
        }
            
        // jump
        if (Input.GetMouseButtonUp(0) && flgGround && !PauseOptions.flgPaused)
        {
            audioSource.volume = VolumeController.volFX;
            audioSource.PlayOneShot(acJump);
            playerRb.AddForce(new Vector2(0, timerPressed * 23));
            timerPressed = 0;
        }

        if (player.transform.position.y > 11.6)
            OnTriggerEnter2D();


        flgGround = Physics2D.OverlapCircle(groundCheck.position, 0.02f, lmGround);
        playerAnm.SetBool("flgGround", flgGround);
	}

    void OnTriggerEnter2D()
    {
        if (StartOptions.difficulty == "normal")
        {
            PlayerPrefs.SetFloat("ScoreNormal", score);
            if (score > PlayerPrefs.GetFloat("RecordNormal"))
            {
                PlayerPrefs.SetFloat("RecordNormal", score);
            }
        }
        else if (StartOptions.difficulty == "hard")
        {
            PlayerPrefs.SetFloat("ScoreHard", score);
            if (score > PlayerPrefs.GetFloat("RecordHard"))
            {
                PlayerPrefs.SetFloat("RecordHard", score);
            }
        }
        else if (StartOptions.difficulty == "expert")
        {
            PlayerPrefs.SetFloat("ScoreExpert", score);
            if (score > PlayerPrefs.GetFloat("RecordExpert"))
            {
                PlayerPrefs.SetFloat("RecordExpert", score);
            }
        }

        Application.LoadLevel("rm_gameOver");          // choose scene when dies
    }

}
