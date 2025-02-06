using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed, jumpForce;
    private Rigidbody2D rbPlayer;
    private Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rbPlayer.velocity = (transform.right * speed * Input.GetAxis("Horizontal")) +(transform.up * rbPlayer.velocity.y);

        if (rbPlayer.velocity.x > 0.1f)
            GetComponent<SpriteRenderer>().flipX = false;
        else if (rbPlayer.velocity.x < -0.1f)
            GetComponent<SpriteRenderer>().flipX = true;
        if (Input.GetButtonDown("Jump"))
        {
            rbPlayer.AddForce(transform.up * jumpForce);
        }
        playerAnimator.SetFloat("Velocity X", Mathf.Abs(rbPlayer.velocity.x));
        playerAnimator.SetFloat("Velocity Y", rbPlayer.velocity.y);

    }
}
