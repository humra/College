using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

    public InputField myInput;

    private static Dictionary<string, string> levels = new Dictionary<string, string>
    {
        { "5233", "Level01" },
        { "2410", "Level02" },
        { "4046", "Level03" }
    };

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void newGame(string newGameLevel)
    {
        PlayerStatsScript.setToDefault();
        SceneManager.LoadScene(newGameLevel);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void highscores()
    {
        SceneManager.LoadScene("Highscores");
    }

    public void selectLevel()
    {
        PlayerStatsScript.setToDefault();
        SceneManager.LoadScene("LevelPicker");
    }

    public void returnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void gameEndReturnToMainMenu()
    {

        string playerName = GameObject.Find("PlayerNameText").GetComponent<Text>().text;
        if (playerName != null)
        {
            writeHighScore(playerName);
        }

        SceneManager.LoadScene("MainMenu");
    }

    private void writeHighScore(string playerName)
    {
        HighScore.writeHighScore(ScoreManager.score, playerName);
    }

    public void enterLevelCode()
    {
        string inputCode = myInput.textComponent.text;

        if(levels.ContainsKey(inputCode)) 
        {
            string levelName;
            levels.TryGetValue(inputCode, out levelName);

            SceneManager.LoadScene(levelName);
        }
    }
}
