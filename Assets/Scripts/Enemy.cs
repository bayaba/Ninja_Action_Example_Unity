using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    bool isDead = false;
    public GameObject Blood;

    void Start()
    {
        LeanTween.moveY(gameObject, 2.0f, 1.0f).setEase(LeanTweenType.easeOutExpo);
        LeanTween.moveY(gameObject, -2.0f, 1.0f).setEase(LeanTweenType.easeInExpo).setDelay(1.0f);
        LeanTween.moveZ(gameObject, -1.0f, 2.0f);
        LeanTween.moveX(gameObject, transform.position.x + Random.Range(-2f, 2f), 2.0f);
    }

    void Update()
    {
        if (transform.position.y <= -2.0f) Destroy(gameObject);
    }

	void OnTriggerEnter2D(Collider2D col)
	{
	    if (col.gameObject.layer == 10)
        {
            if (!isDead)
            {
                GameObject temp = Instantiate(Blood, transform.position, Quaternion.Euler(0f, 0f, 320f)) as GameObject;
                LeanTween.scale(temp, new Vector3(1.2f, 2.0f, 1.5f), 0.5f);
                Destroy(temp, 0.5f);

                LeanTween.cancel(gameObject, false);
                LeanTween.rotateAround(gameObject, Vector3.back, 360f, 0.5f).setLoopClamp();
                LeanTween.moveY(gameObject, transform.position.y + 1.0f, 0.3f).setEase(LeanTweenType.easeOutExpo);
                LeanTween.moveX(gameObject, 4.7f, 1.5f).setEase(LeanTweenType.easeOutExpo).setDestroyOnComplete(true);
                Destroy(col.gameObject);
                isDead = true;
            }
        }
	}
}
