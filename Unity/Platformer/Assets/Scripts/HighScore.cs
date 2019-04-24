using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class HighScore {

    public static string fileLocation = "highscores.txt";

    class DescComparer<T> : IComparer<T>
    {
        public int Compare(T x, T y)
        {
            return Comparer<T>.Default.Compare(y, x);
        }
    }

    public static SortedList<int, string> getHighscores()
    {
        

        SortedList<int, string> highscores = new SortedList<int, string>(new DescComparer<int>());

        if (!File.Exists(fileLocation))
        {
            File.Create(fileLocation);
        }

        try
        {
            using (StreamReader sr = new StreamReader(fileLocation))
            {
                string line;

                while((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('|');
                    highscores.Add(int.Parse(data[0]), data[1]);
                }
            }
        }
        catch(Exception ex)
        {
            Debug.Log(ex.Message);
        }

        return highscores;
    }

    public static void writeHighScore(int score, string playerName)
    {
        try
        {
            using (StreamWriter sw = File.AppendText(fileLocation))
            {
                string line = score + "|" + playerName;
                sw.WriteLine(line);
            }
        }
        catch(Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }
}