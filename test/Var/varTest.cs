﻿namespace CSharpStudy.Var
{
    class Var
    {

        int globalVar = 1024;

        const int Max = 1024;

        readonly int Min = 1;



        public void Method1()
        {
            int localVar;

            localVar = 100;

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
            Console.WriteLine(Min);
        }
    }
}