using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 currentPos = transform.position; // �� �ڽ��� ���� ��ġ
        Vector3 desPos = new Vector3(5, 3, 5); // ������ 

        // currentPos ���� desPos �� ���ϴ� ����
        Vector3 delta = desPos - currentPos;
        // ���⺤�� ����ȭ delta.normalized;

        // currentPos���� desPos ũ�� = ���� ũ�⸦ ���ϱ�
        // �ΰ��� ������� ���� �� �ִ�.
        float distance = delta.magnitude;
        float distance2 = Vector3.Distance(currentPos, desPos);

        transform.position = new Vector3(0, 0, 10);
        transform.localScale = new Vector3(1, 1, 1);

        // ���� �߻� , ȸ���� ���ʹϾ� Ÿ���̶� ����3�� �ٷ��� �ʴ´�. => ������ ���� ����
        //        transform.rotation = new Vector3(30, 60, 90);
        //Quaternion rotation =  Quaternion.Euler(new Vector3(0, 60, 0));

        Quaternion a = Quaternion.Euler(30, 0, 0);
        Quaternion b = Quaternion.Euler(0, 60, 0);

        //a��ŭ ȸ���� ���¿��� b��ŭ �� ȸ���� ȸ������ ǥ��
        Quaternion rotation = a * b;

        //        Quaternion -> Euler(Vector3)
        //        Euler(Vector3) -> Quaternion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
