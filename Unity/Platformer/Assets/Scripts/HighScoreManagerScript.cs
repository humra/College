using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManagerScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
        SortedList<int, string> test = HighScore.getHighscores();

        string tekst = convertToText(test);

        Text placeholder = GameObject.Find("HighScores").GetComponent<Text>();
        placeholder.text = tekst;
	}

    private string convertToText(SortedList<int, string> test)
    {
        IList<int> keys = test.Keys;

        StringBuilder sb = new StringBuilder();

        int counter = 0;

        foreach(int k in keys)
        {
            counter++;

            if(counter > 10)
            {
                break;
            }

            sb.Append(k);
            sb.Append(" - ");
            sb.Append(test[k]);
            sb.Append("\n");
        }

        return sb.ToString(); ;
    }

    // Update is called once per frame
    void Update () {
		
	}
}