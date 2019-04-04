using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody))]
public class GravityBody : MonoBehaviour {

    GravityAtractor planet;

	// Use this for initialization
	void Start () {

        planet = GameObject.Find("Planet").GetComponent<GravityAtractor>();
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;


    }
	
	// Update is called once per frame
	void FixedUpdate () {

        planet.Atracct(transform);
		
	}
}
