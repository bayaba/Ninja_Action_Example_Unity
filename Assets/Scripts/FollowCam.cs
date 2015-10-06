using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

    // followSpeed는 카메라가 따라가는 속도
	public float followSpeed = 20;

    public Transform TargetPlayer = null;

    public float Ymin, Ymax;

	void Update()
    {
        if (TargetPlayer != null)
        {
            Vector3 start = transform.position;

            // 카메라의 좌표를 서서히 이동하게 해주는 코드
            Vector3 end = Vector3.MoveTowards(start, TargetPlayer.position, followSpeed * Time.deltaTime);

            end.x = start.x;
            end.z = start.z;

            // 카메라가 맵의 크기를 벗어나지 않도록 제한한다.
            if (end.y > Ymin) end.y = Ymin;
            if (end.y < Ymax) end.y = Ymax;

            transform.position = end;
        }
    }
}
