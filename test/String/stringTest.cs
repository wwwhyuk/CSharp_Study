using System.Text;

namespace CSharpStudy.String
{
    class stringTest
    {
        char[] c1 = { 'l', 'o', 'a', 'd', 'i', 'n', 'g' };
        char[] c2 = { 't', 'e', 's', 't', 'i', 'n', 'g' };

        string s1 = "C#";
        string s2 = "hi costomer!";

        public void Method1()
        {
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            foreach (var items in c1)
                Console.WriteLine(items); // foreach는 하나씩 출력하기때문에, CW로 인한 줄바꿈이 일어난다.

            foreach (var items in c2)
                Console.WriteLine(items);

            string s3 = s1 + " : " + s2; // 문자열 결합
            Console.WriteLine(s3);
            s3 = s2.Substring(0, 2); // 문자열 추출 
            Console.WriteLine(s3 + "...");
                        
            c1 = s2.ToCharArray(); // 묹자열을 문자배열로 변환

            Console.WriteLine(c1);

            foreach(var items in c1)
                Console.WriteLine(items);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <26; i++)
            {
                sb.Append(i.ToString());
                //sb.Append(System.Environment.NewLine);
            }
            string s = sb.ToString();
            Console.WriteLine(sb); // s를 뽑으나 sb를 뽑으나 같다.
            /*
             StringBuilder의 효율성: StringBuilder는 문자열을 
            효율적으로 처리하기 위한 클래스입니다. 문자열을 조작할
            때마다 새로운 문자열 객체가 생성되는 것이 아니라 내부 버퍼에
            문자열을 추가하고, 이를 효율적으로 관리합니다. 
            따라서 문자열을 조작하는 경우에는 StringBuilder를 
            사용하는 것이 성능상 이점이 있다.
             */
        }
    }
}
