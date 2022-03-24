using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Zoo tom 오브젝트에 컴포넌트 할당
public class Zoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 새로운 Animal 오브젝트 생성 후 변수 tom 에 할당
        // new = 클래스로부터 인스턴스 생성자 예약어
        // 클래스명과 동일한 이름의 생성자() 
        Animal tom = new Animal();
        tom.name = "톰";
        tom.sound = "왜옭!!";


        // 한 클래스로 여러 오브젝트를 만들 수 있다.
        Animal jerry = new Animal();
        jerry.name = "제리";
        jerry.sound = "훗!";

        // 만약 아래와 같은 경우
        // jerry = tom; => 제리를 가르키던 참조(위치)가 톰을 가리키게 되고 제리는 미아가 된다 => 나중에 GC가 없애게 될 것이다.
        // jerry.name = "미키";  => 제리이름을 가르키던 참조는 톰으로 옮겨갔음으로 톰의 이름이 미키라고 바뀌게 된다.
                   
        tom.PlaySound();
        jerry.PlaySound();
    }
}
