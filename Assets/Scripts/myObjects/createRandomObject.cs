using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createRandomObject : MonoBehaviour {

    public GameObject[] myObjects;

    public int[] counts = new int[3];
	// Use this for initialization
	void Start () { 
        int j = 0;
        for (int i = 0; i < 30; i++)
        {
            j = Random.Range(0, 3);
            var myObj = Instantiate(myObjects[j], new Vector3(   8 + Random.Range(0.1f,1f) * 40, 1 ,0),Quaternion.identity);
         //   (myObj as MonoBehaviour).tag += j.ToString();
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
