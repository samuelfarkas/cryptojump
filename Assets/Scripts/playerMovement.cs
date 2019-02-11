using UnityEngine;

public class playerMovement : MonoBehaviour {

    public CharacterController controller;

    public float gravity = 14f;
    private float verticalVelocity;

    public float walkSpeed = 10f;
    public float runSpeed = 25f;
    private float speed;
    public float jumpForce = 10f;

	
	void Update () {

        //poloha vpravo / lavo - beh / chodza
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = runSpeed;
        }
        else
        {
            speed = walkSpeed;
        }

        float hAxis = Input.GetAxis("Horizontal") * speed;


        //Gravitacia a jump system
        if (controller.isGrounded)
        {
            verticalVelocity = 0;
            
            if(Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                verticalVelocity = jumpForce;
            }

        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }


        //samotny pohyb postavy
        Vector3 moveVector = new Vector3(hAxis, verticalVelocity, 0);
        controller.Move(moveVector * Time.deltaTime);



	}
}
