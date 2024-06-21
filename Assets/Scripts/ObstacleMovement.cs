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

        // ��ֹ��� Ư�� ��ġ�� �Ѿ�� �ݴ� �������� �̵�
        if (transform.position.z > 10f || transform.position.z < -10f)
        {
            direction = -direction;
        }
    }
}
