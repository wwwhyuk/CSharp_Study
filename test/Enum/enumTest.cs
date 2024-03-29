﻿/*
 C#의 키워드 enum은 열거형 상수(constant)를 표현하기 위한 것으로
이를 이용하면 상수 숫자들을 보다 의미있는 단어들로 표현할 수 있어서 
프로그램을 읽기 쉽게 해준다.

enum의 각 요소는 별도의 지정없이는 첫번째 요소가 0, 두번째 요소가 1, 
세번째 요소가 2 등과 같이 1씩 증가된 값들을 할당받는다. 물론, 개발자가
임의로 의미있는 번호를 지정해 줄 수도 있다. enum문은 클래스 안이나 
네임스페이스 내에서만 선언될 수 있다. 즉, 메서드 안이나 속성 안에서는
선언되지 않는다.
 */
namespace CSharpStudy.Enum
{
    enum LocalNum //열거형은 클래스 단위이기에 메소드를 클래스안에
                  //집어넣지않는이상 만들수없다.
    {
        Seoul = 02,
        Yangsan = 055,
        Busan = 051
    }

    [Flags]
    enum Border
    {
        None = 0,
        Top = 1,
        Right = 2,
        Bottom = 4,
        Left = 8
    }
}
