using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 3f;
    public Vector3 direction = Vector3.forward;

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        // 장애물이 특정 위치를 넘어서면 반대 방향으로 이동
        if (transform.position.z > 10f || transform.position.z < -10f)
        {
            direction = -direction;
        }
    }
}
