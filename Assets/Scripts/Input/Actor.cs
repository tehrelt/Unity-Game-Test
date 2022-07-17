using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    [SerializeField] private float speed;
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
}
