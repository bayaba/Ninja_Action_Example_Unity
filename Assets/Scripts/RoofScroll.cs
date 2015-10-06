using UnityEngine;
using System.Collections;

public class RoofScroll : MonoBehaviour
{
    float offset = 0f;
    public float Speed = 0f;

	void Update ()
    {
        offset += Time.deltaTime * Speed;
        renderer.material.mainTextureOffset = new Vector3(offset, 0, 0);
	}
}
