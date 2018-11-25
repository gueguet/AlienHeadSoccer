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

    private Vector3 forthPosition;
    private Quaternion forthRotation;

    private Vector3 fifthPosition;
    private Quaternion fifthRotation;

    public List<Vector3> positionArray = new List<Vector3>();
    public List<Quaternion> rotationArray = new List<Quaternion>();


    private void Awake()
    {

        // data of positions and rotations of the goalkeeper
        firstPosition = new Vector3(-0.00999999f, 1.44f, -20.57f);
        firstRotation = Quaternion.Euler(0f, -89.89001f, 0f);

        secondPosition = new Vector3(1.906f, 2.759f, -20.57f);
        secondRotation = Quaternion.Euler(24.104f, -80.87701f, 0.21f);

        thirdPosition = new Vector3(-2.59f, 2.84f, -18.26f);
        thirdRotation = Quaternion.Euler(-23.032f, -323.25f, 11.667f);

        forthPosition = new Vector3(-2.146f, 4.166f, -10.38f);
        forthRotation = Quaternion.Euler(-39.475f, 28.502f, 9.207f);

        fifthPosition = new Vector3(-0.58f, 3.359f, -16.38f);
        fifthRotation = Quaternion.Euler(-8.257f, 74.93f, 24.946f);

        positionArray.Add(firstPosition);
        positionArray.Add(secondPosition);
        positionArray.Add(thirdPosition);
        positionArray.Add(forthPosition);
        positionArray.Add(fifthPosition);

        rotationArray.Add(firstRotation);
        rotationArray.Add(secondRotation);
        rotationArray.Add(thirdRotation);
        rotationArray.Add(forthRotation);
        rotationArray.Add(fifthRotation);

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

        for (int j = 0; j<100; j++)
        {

            // interval entre 1 et 3 secondes avant de changer le goal de position
            int interval = Random.Range(1, 4);

            // on choisir aléatoireement une position et une rotation dans le tableaux correspondant
            int i_position = Random.Range(0, 5);

            gameObject.transform.position = positionArray[(int)i_position];
            gameObject.transform.rotation = rotationArray[(int)i_position];

            yield return new WaitForSeconds(interval);

        }

    }

}
