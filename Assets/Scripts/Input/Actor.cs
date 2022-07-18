using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private float dashCooldown = 20;
    [SerializeField] protected float dashSpeed = 15f;
    [SerializeField] protected int dashDuration = 35;

    protected float dashDelay = 0;
    protected float dashActive = 0;
    protected bool dashing = false;
    protected Vector2 dashDirection;

    protected Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    protected void Move(Vector2 vector)
    {
        rigidbody.velocity = vector * speed; 
    }

    protected void Fire()
    {

    }

    protected void Dash(Vector2 direction)
    {
        if (dashDelay > 0) return;
        dashing = true;

        dashDirection = direction;

        rigidbody.velocity = new Vector2(direction.x, direction.y);
        rigidbody.AddForce(direction * dashSpeed, ForceMode2D.Force);
        dashDelay = dashCooldown;
    }

    protected void StopDash()
    {
        dashDirection = Vector2.zero;
        dashing = false;
    }
}
