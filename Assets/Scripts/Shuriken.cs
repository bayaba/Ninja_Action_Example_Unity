using UnityEngine;
using System.Collections;

public class Shuriken : MonoBehaviour
{
	void Start()
	{
        LeanTween.scale(gameObject, new Vector3(1f, 1f, 1f), 0.15f);
        LeanTween.rotateAround(gameObject, Vector3.back, 360f, 0.3f).setLoopClamp();
        LeanTween.moveX(gameObject, 2.0f, 1.0f).setEase(LeanTweenType.easeOutExpo);
        Destroy(gameObject, 1.0f);
	}
}
