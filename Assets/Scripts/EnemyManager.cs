using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour
{
    public GameObject Enemy;
	
	void Update()
	{
	    if (Random.Range(0, 100) == 0)
        {
            Instantiate(Enemy, transform.position, Quaternion.identity);
        }
	}
}
