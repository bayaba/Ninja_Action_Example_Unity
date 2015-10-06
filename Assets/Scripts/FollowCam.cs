using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

	public float followSpeed = 20;

    public Transform TargetPlayer = null;

    public float Ymin, Ymax;

	void Update()
    {
        if (TargetPlayer != null)
        {
            Vector3 start = transform.position;
            Vector3 end = Vector3.MoveTowards(start, TargetPlayer.position, followSpeed * Time.deltaTime);

            end.x = start.x;
            end.z = start.z;

            if (end.y > Ymin) end.y = Ymin;
            if (end.y < Ymax) end.y = Ymax;

            transform.position = end;
        }
    }
}
