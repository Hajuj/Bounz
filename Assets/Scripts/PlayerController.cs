using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private LayerMask platformsLayerMask;
    private Rigidbody2D rb;
    private CircleCollider2D cc;
    [SerializeField] private float jumpVelocity;
    private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        jumpVelocity = 11f;
        moveSpeed = 5f;
        rb = GetComponent<Rigidbody2D>();
        cc = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(cc.bounds.center, cc.bounds.size, 0f, Vector2.down, .1f, platformsLayerMask);
        return (raycastHit2D.collider != null);
        
    }

    private void HandleMovement()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * jumpVelocity;
        }

        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //Debug.Log("Registered Right Arrow");
            rb.velocity = new Vector2(+moveSpeed, rb.velocity.y);
        }
        else
        {

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                //Debug.Log("Registered Left Arrow");
                rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(0, rb.velocity.y);
            }
        }
    }
}
