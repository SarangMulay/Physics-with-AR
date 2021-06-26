using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roling : MonoBehaviour {

 
     Rigidbody rb;

     bool moveLeft;
     bool moveRight;
     bool moveForward;
     bool moveBackward;
     float horizontalMove;
     float verticalMove;
     public float speed = 300;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    // LEFT BUTTON
     public void PointerDownLeft()
     {
       moveLeft = true;
     }
     public void PointerupLeft()
     {
       moveLeft = false;
     }
    // RIGHT BUTTON
     public void PointerDownRight()
     {
       moveRight = true;
     }
     public void PointerupRight()
     {
       moveRight = false;
     }

     // FORWARD BUTTON
      public void PointerDownForward()
     {
       moveForward = true;
     }
     public void PointerupForward()
     {
       moveForward = false;
     }
    // BACKWARD BUTTON
     public void PointerDownBackward()
     {
       moveBackward = true;
     }
     public void PointerupBackward()
     {
       moveBackward = false;
     }
     private void Update()
     {
         Movement();
     }
void Movement()
{
    if(moveLeft)
    {
        horizontalMove = -speed;
    }
    else if (moveRight)
    {
        horizontalMove = speed;
    }
    else
    {
        horizontalMove = 0;
    }
    if(moveForward)
    {
        verticalMove = speed;
    }
    else if (moveBackward)
    {
        verticalMove = -speed;
    }
    else 
    {
        verticalMove = 0;
    }
}
private void FixedUpdate()
{
    rb.velocity = new Vector3(horizontalMove * Time.deltaTime, rb.velocity.y, verticalMove * Time.deltaTime);
}
}
   
