using CSharpStudy.Enum;

namespace CSharpStudy
{
    class mainTest
    {
        public static void Main(string[] args)
        {
            Var.Var var = new Var.Var();
            Array.Array array = new Array.Array();
            String.stringTest string1 = new String.stringTest();

            //var.Method1();

            //array.Method1();

            //string1.Method1();


            LocalNum myNum;

            // enum 타입에 값을 대입하는 방법
            myNum = LocalNum.Busan;

            // enum을 int로 변환(Casting)하는 방법. 
            // (int)를 앞에 지정.
            int cityValue = (int)myNum;

            if (myNum == LocalNum.Busan) // enum 값을 비교하는 방법
            {
                Console.WriteLine("Welcome to Busan, "+cityValue);
            }


            Border border = Border.Top | Border.Bottom | Border.Left;

            if((border&Border.Top) != 0)
            {
                Console.WriteLine("correct : border = Border.Top");

                if((border.HasFlag(Border.Bottom))) {
                    Console.WriteLine("correct : border.HasFlag = Border.Bottom");
                    Console.WriteLine(border.ToString());
                    Console.WriteLine(border);
                    //열거형 타입 데이터를
                    // , 기호를 기점으로 append 되어 있다.
                }
            }
        }
    }
}
