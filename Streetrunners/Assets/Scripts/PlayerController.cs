using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerrb;
    public float jumpTimer;
    
    [SerializeField]
    private float speed;    
    
    [SerializeField]
    public float timedJump;

    [SerializeField]
    float minJump;

    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private GameObject RestartText;

    private bool Death;

    public GameObject charingbar;


    // Start is called before the first frame update
    void Start()
    {
        Death = false;
        RestartText.SetActive(false);
        charingbar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Death)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                    {
                        jumpTimer = Time.fixedTime;
                if (playerrb.velocity.y > -0.1f && playerrb.velocity.y < 0.1f)
                {
                    charingbar.SetActive(true);
                }


                    }
                    else if (Input.GetKeyUp(KeyCode.Space) && playerrb.velocity.y > -0.1f && playerrb.velocity.y < 0.1f)
                    {
                        jumpTimer = Time.fixedTime - jumpTimer;
                        if (jumpTimer > timedJump)
                        {
                            jumpTimer = timedJump;
                        }
                        playerrb.AddForce(Vector2.up * speed * (jumpTimer + minJump), ForceMode2D.Impulse);
                        charingbar.SetActive(false);


            

                    }
                    // Movement
                    transform.position += new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
        }

        if(transform.position.y <= -6)
        {
            Die();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }

    }

    private void Die()
    {
        Death = true;
        
        RestartText.SetActive(true);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
