using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour{

    public CharacterController controller;
    public Transform GroundCheck;
    public float speed = 6;
    public float turnSmoothTime = 0f;
    public float Gravity = -9f;
    public float groundDistance = 0.4f;
    public float JumpHeight =3f;
    public float turnSmoothVelocity;
    public float rot=0f;
    public LayerMask ground;
    Vector3 velocity;
    bool isGrounded;
    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update(){
        isGrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, ground);
        if(isGrounded && velocity.y < 0){
            velocity.y = 0f;
        }
        float rot = Camera.main.transform.localEulerAngles.y;
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f){

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = rot;
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, angle, 0f) * Vector3.forward;
            
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
        if(Input.GetButtonDown("Jump") && isGrounded){
            velocity.y = Mathf.Sqrt(JumpHeight * -2 * Gravity);
        }
        velocity.y += Gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        
    }
}
