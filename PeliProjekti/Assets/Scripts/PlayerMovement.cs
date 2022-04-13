using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private bool isOnGround = true;


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (isOnGround == true)
            {
                body.velocity = new Vector2(body.velocity.x, speed);
                isOnGround = false;


            }
        }


        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);



    
    }

            private void OnCollisionEnter2D(Collision2D collision)
    {
        isOnGround = true;
    }
}
