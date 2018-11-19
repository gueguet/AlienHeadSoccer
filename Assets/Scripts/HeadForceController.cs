using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class HeadForceController : MonoBehaviour {

    private VelocityEstimator headVelocity;

    private float headVelocityVectorScalar;
    public float headVelocityRotationScalar;



    public int multiplicaterForce;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //on récupèreune estimation de la vitesse du casque
        headVelocity = gameObject.GetComponent<VelocityEstimator>();
        Vector3 headVelocityVector = headVelocity.GetVelocityEstimate();
        headVelocityVectorScalar = Mathf.Sqrt(Mathf.Pow(headVelocityVector.x, 2) + Mathf.Pow(headVelocityVector.y, 2) + Mathf.Pow(headVelocityVector.z,2));

        


        //Debug.DrawRay(transform.position, transform.forward * 10, Color.red);


		
	}

    // on ne peut pas activer on triger sur le collider --> sinon trvaerse
    // on utilise une méthode qui detecte la collision et non l'entrée dans un collider
    private void OnCollisionEnter(Collision collision)
    {

        string nameBallon = collision.collider.gameObject.name;
        //Debug.Log("collide (name) : " + nameBallon);

        GameObject ballonTouched = GameObject.Find(nameBallon);

        ballonTouched.AddComponent<Rigidbody>();
        multiplicaterForce = 1000;
        ballonTouched.GetComponent<Rigidbody>().AddForce(multiplicaterForce * headVelocityVectorScalar * gameObject.transform.forward);


        AudioSource hitSound = gameObject.GetComponent<AudioSource>();
        hitSound.Play();



    }




}
