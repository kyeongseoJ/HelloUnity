using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // ������ �ڽ� ���� ������Ʈ���� Ʈ������
    public Transform childTransform;

    void Start()
    {
        // �ڽ��� ���� ��ġ (0, -1, 0)���� ����
        transform.position = new Vector3(0, -1, 0);

        // �ڽ��� ���� ��ġ�� (0, 2, 0)���� ����
        childTransform.localPosition = new Vector3(0, 2, 0);

        // �ڽ��� ���� ȸ���� (0, 0, 30)���� ����
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
        // �ڽ��� ���� ȸ���� (0, 60, 0)���� ����
        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // ���� ����Ű�� ������ �ʴ� (0, 1, 0) �� �ӵ��� �����̵�
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime); // �������� ����
            // transform.position += new Vector3(0, 1, 0) * Time.deltaTime; // �������� ���� 
            // transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime, Space.World); // �������� ����
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // �Ʒ��� ����Ű�� ������ �ʴ� (0, -1, 0) �� �ӵ��� �����̵�
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // ���� ����Ű�� ������
            // �ڽ��� �ʴ� (0, 0, 180) ȸ�� 
            transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);
            // �ڽ��� �ʴ� (0, 180, 0) ȸ��
            transform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // ������ ����Ű�� ������
            // �ڽ��� �ʴ� (0, 0, -180) ȸ�� 
            transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime);
            // �ڽ��� �ʴ� (0, -180, 0) ȸ��
            transform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime);
        }

    }
}
