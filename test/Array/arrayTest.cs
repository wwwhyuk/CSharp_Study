namespace CSharpStudy.Array
{
    class Array
    {
        string[] s1 = new string[10];
        string[] s2 = { "hello", "this", "is", "me" };
        string[,] s3 = { {"김과장", "개발부서"},
            {"이과장", "마케팅부서"}, {"박부장","총괄"},
            {"심대표", "대표"} };
        int[] i1 = { 1, 2, 3 };

        public void Method1()
        {
            int sum = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine(s1[i]);
            }
            for (int i = 0; i < s2.Length; i++)
            {
                Console.WriteLine(s2[i]);
            }

            foreach (var row in s2)
            {
                Console.WriteLine(row);
            }

            for (int i = 0; i < s3.GetLength(0); i++)
            {
                for (int j = 0; j < s3.GetLength(1); j++)
                {
                    Console.WriteLine(s3[i, j]);
                }
            }

            foreach (var row in s3)
            {
                Console.WriteLine(row);
            }

            for (int i = 0; i < i1.Length; i++)
            {
                sum += i1[i];
            }
            Console.WriteLine(sum);
        }
    }
}
