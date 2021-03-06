﻿using UnityEngine;
using System.Collections;

public class Ninja : MonoBehaviour
{
    Animator anim;
    public GameObject Shuriken;

	void Start()
	{
        Physics2D.IgnoreLayerCollision(10, 10); // disable shuriken's collision
        anim = GetComponent<Animator>();
	}
	
	void Update()
	{
        if (Input.GetMouseButtonDown(1)) // when you right clicked
        {
            Invoke("Attack", 0.1f); // create shuriken after 0.1 second
            anim.SetTrigger("attack"); // attack animation
        }

        if (rigidbody2D.velocity.magnitude <= 0f) // ninja landed on roof
        {
            if (Input.GetMouseButtonDown(0)) // when you left click
            {
                rigidbody2D.AddForce(Vector2.up * 300f);
            }
            anim.SetTrigger("run");
        }
    }

    void Attack()
    {
        Instantiate(Shuriken, transform.position + Vector3.up * 0.2f, Quaternion.identity); // create shuriken
    }
}
