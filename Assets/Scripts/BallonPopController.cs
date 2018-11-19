using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class BallonPopController : MonoBehaviour {

    public GameObject ballon;
    private int totalBallon = 0;

    // on instancie 3 lanceurs de ballons dans le jeu
    public GameObject lanceur_1;
    public GameObject lanceur_2;
    public GameObject lanceur_3;

    public int launchTimer_1;
    public int launchTimer_2;
    public int launchTimer_3;

    public int launchPower_1;
    public int launchPower_2;
    public int launchPower_3;

    public Vector3 launchVector_1;
    public Vector3 launchVector_2;
    public Vector3 launchVector_3;


    private void Awake()
    {
        launchPower_1 = 28;
        launchVector_1 = new Vector3(0, 15, 40);
        launchTimer_1 = 3;

        launchPower_2 = 38;
        launchVector_2 = new Vector3(-12, 15, 25);
        launchTimer_2 = 5;


        launchPower_3 = 25;
        launchVector_3 = new Vector3(8, 20, 25);
        launchTimer_3 = 4;


    }



    // Use this for initialization
    void Start () {



        // lancer 10 ballons sur le launcher 1
        StartCoroutine(launchBallon(lanceur_1, 100, launchTimer_1, launchPower_1, launchVector_1));
        StartCoroutine(launchBallon(lanceur_2, 100, launchTimer_2, launchPower_2, launchVector_2));
        StartCoroutine(launchBallon(lanceur_3, 100, launchTimer_3, launchPower_3, launchVector_3));


    }



    // Update is called once per frame
    void Update () {

   





    }





    // type d'interface itérateur, une function void aurait causé une erreur
    // lance un nombre de ballons depuis le launcher
    IEnumerator launchBallon(GameObject launcher, int maxBallon, int waitingSeconds, int launchPower, Vector3 launchVector)
    {

        

        for (int i = 0; i < maxBallon; i++)
        {
            

            // intancie la prefab
            GameObject ballonInstance = Instantiate(ballon, launcher.transform.position, Quaternion.identity);

            ballonInstance.GetComponent<Rigidbody>().AddForce(launchPower * launchVector);
            ballonInstance.name = "ballon" + totalBallon;

            totalBallon++;

            // attends 4 secondes entre chaque lancer
            yield return new WaitForSeconds(waitingSeconds);


        }
    }




    //private void OnTriggerEnter(Collider col)
    //{
    //    Debug.Log("collision avec la tete");
    //}










}
