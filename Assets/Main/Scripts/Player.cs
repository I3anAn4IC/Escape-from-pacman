using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float dirX, dirY;
    public float speed;
    public Joystick joystick;
    private Rigidbody2D rb;
	public Animator animator;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = joystick.Horizontal * speed;
        dirY = joystick.Vertical * speed;

		Vector3 movement = new Vector3(dirX, dirY, 0.0f);


        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
        
    }
}
