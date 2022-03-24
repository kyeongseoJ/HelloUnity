using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 currentPos = transform.position; // 내 자신의 현재 위치
        Vector3 desPos = new Vector3(5, 3, 5); // 목적지 

        // currentPos 에서 desPos 로 향하는 벡터
        Vector3 delta = desPos - currentPos;
        // 방향벡터 정규화 delta.normalized;

        // currentPos에서 desPos 크기 = 실제 크기를 구하기
        // 두가지 방법으로 구할 수 있다.
        float distance = delta.magnitude;
        float distance2 = Vector3.Distance(currentPos, desPos);

        transform.position = new Vector3(0, 0, 10);
        transform.localScale = new Vector3(1, 1, 1);

        // 에러 발생 , 회전은 쿼터니언 타입이라 벡터3로 다루지 않는다. => 짐벌락 현상 때문
        //        transform.rotation = new Vector3(30, 60, 90);
        //Quaternion rotation =  Quaternion.Euler(new Vector3(0, 60, 0));

        Quaternion a = Quaternion.Euler(30, 0, 0);
        Quaternion b = Quaternion.Euler(0, 60, 0);

        //a만큼 회전한 상태에서 b만큼 더 회전한 회전값을 표현
        Quaternion rotation = a * b;

        //        Quaternion -> Euler(Vector3)
        //        Euler(Vector3) -> Quaternion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
