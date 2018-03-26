using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collided : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("collided");
    }


    // Update is called once per frame
    void Update () {
		
        
    }
}
