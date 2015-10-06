using UnityEngine;
using System.Collections;

public class Ninja : MonoBehaviour
{
    Animator anim;
    public GameObject Shuriken;

	void Start()
	{
        Physics2D.IgnoreLayerCollision(10, 10);
        anim = GetComponent<Animator>();
	}
	
	void Update()
	{
        if (Input.GetMouseButtonDown(1))
        {
            Invoke("Attack", 0.1f);
            anim.SetTrigger("attack");
        }
        if (rigidbody2D.velocity.magnitude > 0f)
        {
            anim.SetTrigger("idle");
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                rigidbody2D.AddForce(Vector2.up * 300f);
            }
            anim.SetTrigger("run");
        }
    }

    void Attack()
    {
        Instantiate(Shuriken, transform.position + Vector3.up * 0.2f, Quaternion.identity);
    }
}
