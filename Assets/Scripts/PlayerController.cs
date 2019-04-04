using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(GravityBody))]
public class PlayerController : MonoBehaviour{

    // public vars
    public float speed = 6;
    public float  rotationSpeed;
    public GameObject lookAt;


    private Transform originalPos;

    // System vars
    Vector3 moveAmount;
    Vector3 smoothMoveVelocity;
    Rigidbody rb;
    private float inputX;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        originalPos = transform;
    }

    void Update()
    {


        // Calculate movement:
        inputX = SimpleInput.GetAxis("Horizontal");
        
        float inputY = 1;

        Vector3 moveDir = new Vector3(inputX, 0, inputY).normalized;
        Vector3 targetMoveAmount = moveDir * speed;
        moveAmount =  Vector3.SmoothDamp(moveAmount, targetMoveAmount, ref smoothMoveVelocity, .15f);

        //Rotation
       // transform.LookAt(lookAt.transform);
      
    }

  
    void FixedUpdate()
    {
        // Apply movement to rigidbody
        Vector3 localMove = transform.TransformDirection(moveAmount) * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + localMove);


        //Apply rotation
        Vector3 yRotation = Vector3.up * inputX * rotationSpeed * Time.fixedDeltaTime;
        Quaternion deltaRotation = Quaternion.Euler(yRotation);
        Quaternion targetRotation = rb.rotation * deltaRotation;
        rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, 50f * Time.deltaTime));
    }

    public void restartPosition() {

        transform.position = originalPos.position;
        transform.rotation = originalPos.rotation;

    }
}
