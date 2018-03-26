using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Summary : MonoBehaviour {

    public Text Scene2Summary; 
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);
        Scene2Summary = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Set_Summary(string text)
    {
        this.Scene2Summary.text = text;
    }
}
