using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// NEW USING STATEMENT
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
     private static int currentScore1;
    private static int currentScore2;
    private static int currentScore3;
    private static int currentScore;

    System.DateTime start;
    System.DateTime end;
  //  private Text timeLeft;

    public  Text scoreText;
    //  private Text SummaryText;

    private static  String timerDisplay;
    private static String SummaryDisplay ;
    private static String scoreDisplay;

    // Use this for initialization
    void Start () {

        start = System.DateTime.Now;
        end = System.DateTime.Now.AddSeconds(30);

        // Update UI once
        UpdateText();
	}

    // Update is called once per frame
    void Update()
    {
            var calctimeLeft = end - DateTime.Now;
            timerDisplay = string.Format("Time Left: {0} ", calctimeLeft.Seconds);

            if (calctimeLeft.Seconds <= 0)
            {
                PlsLoadScene();
            }
        UpdateText();
    }

    public void UpdateScore(int objType , int valueToAdd)
    {
        switch(objType)
        {
            case 1: currentScore1++; break;
            case 2: currentScore2++; break;
            case 3: currentScore3++; break;
            default: currentScore += valueToAdd; break;
        }

        UpdateText();
    }

    void UpdateText()
    {
        if (SceneManager.GetActiveScene().name != "Assign5_Scene2")
        {
            SummaryDisplay = string.Format(
                        "Summary \n Bowling Ball: {0}\n Ball: {1}\n Coin: {2}",
                            currentScore1, currentScore2, currentScore3);

            scoreDisplay = string.Format("Score: {0} {1} {2}", currentScore1, currentScore2, currentScore3);
            scoreText.text = scoreDisplay + "\n" + timerDisplay;
        }
        else
        {
             scoreText.text = SummaryDisplay;
        }
    }

    private void PlsLoadScene()
    {
        if (SceneManager.GetActiveScene().name == "Assign5_Scene2")
        {
            scoreText.text = SummaryDisplay;
        }
        else
        {
           SceneManager.LoadScene("Assign5_Scene2", UnityEngine.SceneManagement.LoadSceneMode.Single);
        }
    }

}
