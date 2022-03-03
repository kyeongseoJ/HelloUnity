using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 이동에 사용할 Rigidbody 컴포넌트
    public Rigidbody playerRigidbody;
    // 이동속력 기본값 8f로 지정
    public float speed = 8f;
    // 플레이어 비활성화를 위한 변수 생성
    public GameObject myplayer;  
    
    void Start()
    {
        // 게임 오브젝트ㅔㅇ서 Rigidbody 컴포넌트를 찾아 playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        // 수평축과 수직축의 입력값을 감지해서 저장
        
        // 실제 이동속도를 입력값과 이동속력을 사용해 결정
        // Vector3 속도를 생성
        // Rigidbody의 속도에 newVelocity 할당
        
    }
}
