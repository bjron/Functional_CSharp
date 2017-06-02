using System;

namespace Functional_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int> f = (x) => x + 2;
            //int i = f(1);
            //Console.WriteLine(i);
            //f = (x) => 2 * x + 1;
            //i = f(1);
            //Console.WriteLine(i);
            Student st1 = new Student(22, 34);
            Student st2 = new Student(22, 34);

            Console.WriteLine(st1.id > st2.id ? st1.id + " Wins..!" : st2.id + " Wins..!");
            st1.Display();
        }
    }
}