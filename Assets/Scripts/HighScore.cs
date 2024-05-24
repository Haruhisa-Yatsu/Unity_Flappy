using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public TMP_Text _highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        int score = PlayerPrefs.GetInt("score");
        string difficulty = PlayerPrefs.GetString("difficulty");


        string highScore = PlayerPrefs.GetString("highScore");
        //Debug.Log(highScore);
        string[] highScoreArr = highScore.Split(' ');
        int nowHighScore = 0;
        int index = -1;
        switch (difficulty)
        {
            case "easy":
                nowHighScore = int.Parse(highScoreArr[0]);
                index = 0;
                break;
            case "normal":
                nowHighScore = int.Parse(highScoreArr[1]);
                index = 1;
                break;
            case "hard":
                nowHighScore = int.Parse(highScoreArr[2]);
                index = 2;
                break;
            case "challenge":
                nowHighScore = int.Parse(highScoreArr[3]);
                index = 3;
                break;
        }
        if (nowHighScore < score)
        {
            highScoreArr[index] = score.ToString();
        }
        string newHighScore = "";
        string newHighScoreDb = "";
        string[] strings = { "E", "N", "H", "C" };
        for (int i = 0; i < 4; i++)
        {
            newHighScore += strings[i] + " : " + highScoreArr[i] + "\n";
            newHighScoreDb += highScoreArr[i] + " ";
        }
        _highScoreText.text = newHighScore;
        PlayerPrefs.SetString("highScore", newHighScoreDb);
    }

    // Update is called once per frame
    void Update()
    {
    }
}