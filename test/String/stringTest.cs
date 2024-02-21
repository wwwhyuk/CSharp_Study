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
                        
            c1 = s2.ToCharArray(); // 묹자열을 문자배열로 출력

            Console.WriteLine(c1);

            foreach(var items in c2)
                Console.WriteLine(items);
        }
    }
}
