using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Move : MonoBehaviour
{
    void Update()
    {
        // (x �¿� y ���Ʒ� z �յ�)
        // Vector3.forward = new Vector3(0, 0, 1);
        //    Vector3.back = new Vector3(0, 0, -1);
        //    Vector3.up = new Vector3(0, 1, 0);
        //    Vector3.down = new Vector3(0, -1, 0);
        //    Vector3.left = new Vector3(-1, 0, 0);
        //    Vector3.right = new Vector3(1, 0, 0);

        // �ڽ��� ������ �����̵� = �������� �̵�
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        transform.position = transform.position + transform.up * 1 * Time.deltaTime;
        transform.position += transform.up * Time.deltaTime;

        // �������� �̵�
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime, UnityEngine.Space.World);
        transform.position = transform.position + Vector3.up *1 * Time.deltaTime;
    }
}
