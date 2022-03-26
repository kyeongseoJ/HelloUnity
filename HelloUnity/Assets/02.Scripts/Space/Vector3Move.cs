using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Move : MonoBehaviour
{
    void Update()
    {
        // (x 좌우 y 위아래 z 앞뒤)
        // Vector3.forward = new Vector3(0, 0, 1);
        //    Vector3.back = new Vector3(0, 0, -1);
        //    Vector3.up = new Vector3(0, 1, 0);
        //    Vector3.down = new Vector3(0, -1, 0);
        //    Vector3.left = new Vector3(-1, 0, 0);
        //    Vector3.right = new Vector3(1, 0, 0);

        // 자신의 앞으로 평행이동 = 지역공간 이동
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        transform.position = transform.position + transform.up * 1 * Time.deltaTime;
        transform.position += transform.up * Time.deltaTime;

        // 전역공간 이동
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime, UnityEngine.Space.World);
        transform.position = transform.position + Vector3.up *1 * Time.deltaTime;
    }
}
