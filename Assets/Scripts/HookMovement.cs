using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookMovement : MonoBehaviour
{
public Transform groundCheck;
    public float sinkspeed;
public LayerMask groundLayer;
public float jumpForce;
public float speed;
private Rigidbody2D rb;
private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Hook";
        
        rb =  this.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0f, sinkspeed));
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //bool grounded = Physics2D.OverlapCircle(groundCheck.position, .2f, groundLayer) != null;


        Vector2 movementVector = new Vector2();
        
        movementVector.x = Input.GetAxis ("Horizontal") * speed;

        //if(Input.GetButtonDown("Jump") && grounded)
        //{
        //    movementVector.y = jumpForce;
        //}

       

        //tell animator about relevant information
        //animator.SetFloat("speed", Mathf.Abs(rb.velocity.x));

        rb.AddForce(movementVector);
    }
}
