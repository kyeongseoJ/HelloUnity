using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // �̵��� ����� Rigidbody ������Ʈ
    public Rigidbody playerRigidbody;
    // �̵��ӷ� �⺻�� 8f�� ����
    public float speed = 8f;
    // �÷��̾� ��Ȱ��ȭ�� ���� ���� ����
    public GameObject myplayer;  
    
    void Start()
    {
        // ���� ������Ʈ�Ĥ��� Rigidbody ������Ʈ�� ã�� playerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        // ������� �������� �Է°��� �����ؼ� ����
        
        // ���� �̵��ӵ��� �Է°��� �̵��ӷ��� ����� ����
        // Vector3 �ӵ��� ����
        // Rigidbody�� �ӵ��� newVelocity �Ҵ�
        
    }
}
