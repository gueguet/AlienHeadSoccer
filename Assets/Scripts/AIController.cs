using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {

    // le but est de temporiser entre plusieurs positions
    private Vector3 firstPosition;
    private Quaternion firstRotation;

    private Vector3 secondPosition;
    private Quaternion secondRotation;

    private Vector3 thirdPosition;
    private Quaternion thirdRotation;


    private void Awake()
    {
        
        firstPosition = new Vector3(-0.00999999f, 1.44f, -20.57f);
        firstRotation = Quaternion.Euler(0f, -89.89001f, 0f);

        secondPosition = new Vector3(1.906f, 2.759f, -20.57f);
        secondRotation = Quaternion.Euler(24.104f, -80.87701f, 0.21f);

        thirdPosition = new Vector3(-2.59f, 2.84f, -18.26f);
        thirdRotation = Quaternion.Euler(-23.032f, -323.25f, 11.667f);

    }


    // Use this for initialization
    void Start () {



        StartCoroutine(moveGoalKepeer());



    }
	
	// Update is called once per frame
	void Update () {
		
        

	}


    IEnumerator moveGoalKepeer()
    {

        Debug.Log("her we are");

        for (int j = 0; j<100; j++)
        {
            gameObject.transform.position = secondPosition;
            gameObject.transform.rotation = secondRotation;

            yield return new WaitForSeconds(2);

            gameObject.transform.position = firstPosition;
            gameObject.transform.rotation = firstRotation;

            yield return new WaitForSeconds(2);

            gameObject.transform.position = thirdPosition;
            gameObject.transform.rotation = thirdRotation;

            yield return new WaitForSeconds(1);


        }

        //gameObject.transform.position = secondPosition;
        //gameObject.transform.rotation = secondRotation;

        //yield return new WaitForSeconds(2);


    }




}
