using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int score;
    public static int gems;
    public static int life;
    public static int maxLives = 3;
    public LevelManager levelManager;

    public Text scoreText;
    public Text gemAmountText;
    public Text lifeCounterText;

    void Start()
    {
        score = PlayerStatsScript.score;
        gems = PlayerStatsScript.gems;
        life = PlayerStatsScript.life;
        levelManager = FindObjectOfType<LevelManager>();
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        gemAmountText = GameObject.Find("FuelGemCounterText").GetComponent<Text>();
        lifeCounterText = GameObject.Find("LifeCounterText").GetComponent<Text>();
    }

    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        gemAmountText.text = "x " + gems.ToString();
        lifeCounterText.text = "x " + life.ToString();
    }

    internal void removeLife(int amount)
    {
        life -= amount;
    }

    internal int getLives()
    {
        return life;
    }

    internal static void addLife(int amount)
    {
         if(life == maxLives)
        {
            addPoints(50);
            addGem(3);
        }
         else
        {
            life += amount;
        }
    }

    public static void addPoints(int points)
    {
        score += points;
    }

    public static void addGem(int amount)
    {
        gems += amount;
    }

    public static void reset()
    {
        score = 0;
    }

    internal static int getGems()
    {
        return gems;
    }
}
