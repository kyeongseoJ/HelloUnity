using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Zoo tom ������Ʈ�� ������Ʈ �Ҵ�
public class Zoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ���ο� Animal ������Ʈ ���� �� ���� tom �� �Ҵ�
        // new = Ŭ�����κ��� �ν��Ͻ� ������ �����
        // Ŭ������� ������ �̸��� ������() 
        Animal tom = new Animal();
        tom.name = "��";
        tom.sound = "�ֿ�!!";


        // �� Ŭ������ ���� ������Ʈ�� ���� �� �ִ�.
        Animal jerry = new Animal();
        jerry.name = "����";
        jerry.sound = "��!";

        // ���� �Ʒ��� ���� ���
        // jerry = tom; => ������ ����Ű�� ����(��ġ)�� ���� ����Ű�� �ǰ� ������ �̾ư� �ȴ� => ���߿� GC�� ���ְ� �� ���̴�.
        // jerry.name = "��Ű";  => �����̸��� ����Ű�� ������ ������ �Űܰ������� ���� �̸��� ��Ű��� �ٲ�� �ȴ�.
                   
        tom.PlaySound();
        jerry.PlaySound();
    }
}
