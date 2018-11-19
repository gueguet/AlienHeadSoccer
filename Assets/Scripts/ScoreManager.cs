using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    private int _score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider col)
    {
        //Debug.Log("ca a marqué");

        _score++;


        Text t = GameObject.Find("Text").GetComponent<Text>();

        t.text = "Score : " + _score;
        
    }
}
