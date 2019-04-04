using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerRotator : MonoBehaviour
{

    private float rotation;
    public float rotationSpeed;

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Rotation
        rotation = Input.GetAxisRaw("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {

        transform.RotateAroundLocal(Vector3.up, rotation * rotationSpeed * Time.deltaTime);
        //Vector3 yRotation = Vector3.up * rotation * rotationSpeed * Time.fixedDeltaTime;
        //  Quaternion deltaRotation = Quaternion.Euler(yRotation);
        //  Quaternion targetRotation = rb.rotation * deltaRotation;
        //rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, 50f * Time.deltaTime));
        //transform.Rotate(0f, rotation * rotationSpeed * Time.fixedDeltaTime, 0f, Space.Self);

    }
}

