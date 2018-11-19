using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    public GameObject bird;
    public GameObject rocher;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // bird à toucherpour bonus de 3 buts 
        bird.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);

        // j'arrive pas le faire tourner sur lui meme :( fe projet planete...
        rocher.transform.RotateAround(transform.position, transform.up, Time.deltaTime * 50f);

    }
}
