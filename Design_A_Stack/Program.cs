using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Design_A_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            int mini = 0;
            int max = 5;

            for (int i = mini; i <= max; i++)
            {
                stack.Push(i);
            }

            // if we clear the List from here we will have an exception error 
            //when we try to pop an empty List

            for(int i = mini; i <= max; i++)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.ReadLine();
        }
    }
}
