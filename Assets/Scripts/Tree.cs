using UnityEngine;
using System.Collections;

public class Tree : MonoBehaviour
{
    public float Speed = 2.0f;

	void Update ()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);

        if (transform.position.x < -15f)
        {
            transform.position = new Vector3(transform.position.x + 30f, transform.position.y, transform.position.z);
        }
    }
}
