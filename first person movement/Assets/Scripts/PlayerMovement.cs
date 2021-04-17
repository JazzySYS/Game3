using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public CharacterController cont;

	public float speed = 12f;
	public float gravity = 9.81f;

	public float jumpCount;
	public float jumpHeight = 5f;

	public Transform jumpCheck;
	public float jumpDist = 2f;
	public LayerMask jumpMask;

	public Transform groundCheck;
	public float groundDistance = 0.4f;
	public LayerMask groundMask;

	bool isJump;

	bool isGrounded;

	Vector3 velocity;

    void FixedUpdate()
    {
    	isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

    	if(isGrounded && velocity.y < 0){
    		velocity.y = -0.25f;
    	}

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        cont.Move(move * speed * Time.deltaTime);

        velocity.y -= gravity * Time.deltaTime;

        cont.Move(velocity * Time.deltaTime);

        isJump = Physics.CheckSphere(jumpCheck.position, jumpDist, jumpMask);

        if (isJump && jumpCount < 1){
        	jumpCount = jumpCount + 1;
        }
    }

    void Update(){
    	if(isGrounded == true){
    		jumpCount = 1f;
    	}

    	if(jumpCount >= 1 && Input.GetKeyDown("space")){
    		velocity.y = jumpHeight;
    		jumpCount = jumpCount - 1f;
    	}
    }

    void OnCollisionEnter(Collision CollisionInfo){
    	if(CollisionInfo.collider.tag == "ExtraJump"){
    		jumpCount = jumpCount + 1f;
    	}
    }
}
