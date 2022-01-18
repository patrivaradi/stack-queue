using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            stack A = new stack();
            A.Push(1);
            A.Push(2);
            A.Push(3);
            A.Push(4);
            A.Push(5);
            A.Pop();
            A.View();
            Console.WriteLine();
            queue B = new queue();
            B.Push(1);
            B.Push(2);
            B.Push(3);
            B.Push(4);
            B.Pop();
            B.View();
            Console.ReadKey();
        }
    }
}
