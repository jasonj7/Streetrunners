using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isOnGround;
    public Rigidbody2D playerrb;
    private float jumpTimer;
    
    [SerializeField]
    private float speed;    
    
    [SerializeField]
    private float timedJump;

    [SerializeField]
    private float minJump;

    [SerializeField]
    private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        isOnGround = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpTimer = Time.fixedTime;
        }
        else if (Input.GetKeyUp(KeyCode.Space) && isOnGround && playerrb.velocity.y > -0.1f && playerrb.velocity.y < 0.1f)
        {
            jumpTimer = Time.fixedTime - jumpTimer;
            if (jumpTimer > timedJump)
            {
                jumpTimer = timedJump;
            }
            playerrb.AddForce(Vector2.up * speed * (jumpTimer + minJump), ForceMode2D.Impulse);


            

        }
        // Movement
        transform.position += new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
    }
}
