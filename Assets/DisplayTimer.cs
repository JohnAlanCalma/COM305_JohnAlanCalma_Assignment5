using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DisplayTimer : MonoBehaviour {

    // private String timeLeft = "30";

    System.DateTime start ;
    DateTime end ;
    private Text timeLeft;

    // Use this for initialization
    void Start () {
     //   DontDestroyOnLoad(this.gameObject);

        timeLeft = GetComponent<Text>();
        start = DateTime.Now;
        end = DateTime.Now.AddSeconds(30);
    }

    // Update is called once per frame
    void Update () {
        var calctimeLeft = end - DateTime.Now;
        timeLeft.text = string.Format("Time Left: {0} ", calctimeLeft.Seconds);
        if (calctimeLeft.Seconds <= 0)
        {
            LoadScene();
        }
    }
    void UpdateText()
    {
     //   var calctimeLeft = end - DateTime.Now;
     //   timeLeft.text = string.Format("Time Left: {0} ", calctimeLeft);
    }

    private void LoadScene()
    {
        SceneManager.LoadScene("Assign5_Scene2", UnityEngine.SceneManagement.LoadSceneMode.Single);
    }
}
