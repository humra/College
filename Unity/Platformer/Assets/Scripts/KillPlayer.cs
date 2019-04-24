using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    public LevelManager levelManager;
    public ScoreManager scoreManager;

	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
        scoreManager = FindObjectOfType<ScoreManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Player"))
        {
            scoreManager.removeLife(1);

            if(scoreManager.getLives() == 0)
            {
                levelManager.gameOver();
            }
            else
            {
                levelManager.RespawnPlayer();

            }
        }
    }
}
