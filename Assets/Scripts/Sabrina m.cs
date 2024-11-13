using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Speed;
    public float JumpForce;

    private float _horizontal;
    private Rigidbody2D _Rigidbody2D;
    private bool _Grounded;

    void Start()
    {
        _Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");

        Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);


        if (Physics2D.Raycast(transform.position, Vector2.down, 0.1f))
        {
            _Grounded = true;
        }
    }


}