using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameScript : MonoBehaviour {

    public GameObject endLevelParticle;
    public GameObject nextLevelButton;
    public GameObject levelCode;
    public ScoreManager scoreManager;

    private PlayerController player;

    private Text timer;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        nextLevelButton = GameObject.Find("NextLevel");
        levelCode = GameObject.Find("LevelCodeText");

        nextLevelButton.gameObject.SetActive(false);
        levelCode.gameObject.SetActive(false);
        timer = GameObject.Find("Timer").GetComponent<Text>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            player.gameObject.SetActive(false);

            Instantiate(endLevelParticle, this.transform.position, this.transform.rotation);
            Destroy(gameObject);
            ScoreManager.addPoints(500);

            nextLevelButton.gameObject.SetActive(true);
            levelCode.gameObject.SetActive(true);

            addTimeBonus();
            addLifeBonus();
            addGemBonus();
        }
    }

    private void addGemBonus()
    {
        ScoreManager.addPoints(FuelGemPickup.pointsWorth * ScoreManager.gems);
    }

    private void addLifeBonus()
    {
        ScoreManager.addPoints(LifePickup.pointsWorth * ScoreManager.life);
    }

    private void addTimeBonus()
    {
        float time = float.Parse(timer.text);

        if (time < 30.0f)
        {
            ScoreManager.addPoints(100);
        }
        else if (time < 60.0f)
        {
            ScoreManager.addPoints(50);
        }
    }
}
