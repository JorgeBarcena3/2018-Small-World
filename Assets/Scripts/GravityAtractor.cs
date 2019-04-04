using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAtractor : MonoBehaviour {

    public float gravity = -10f;

    public void Atracct(Transform body) {

        Vector3 targetDire = (body.position - transform.position).normalized;
        Vector3 bodyUp = body.up;

        body.rotation = Quaternion.FromToRotation(body.up, targetDire) * body.rotation;
        body.GetComponent<Rigidbody>().AddForce(targetDire * gravity);


    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
