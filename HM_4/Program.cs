using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_Int num = new Class_Int(1);
            Class_String str = new Class_String("2");
            Console.WriteLine("Class_Int id is " + num.Id_.ToString()+"\nClass_String id is "+str.Id_);
            Console.ReadLine();
        }
    }
}
