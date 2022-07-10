using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 5f;
    public Animator anim;

    

    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);
    }

    void Start()
    {
        //Get the animator, which you attach to the GameObject you are intending to animate.
        anim = gameObject.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        transform.Translate(moveSpeed * Time.fixedDeltaTime * movement);
    }
}
