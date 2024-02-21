using CSharpStudy.Var;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class mainTest
    {
        public static void Main(string[] args)
        {
            Var.Var var = new Var.Var();
            Array.Array array = new Array.Array();
            
            var.Method1();

            array.Method1();
        }
    }
}
