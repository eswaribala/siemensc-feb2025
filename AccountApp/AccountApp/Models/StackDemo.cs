using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Models
{
    internal class StackDemo
    {

        private Stack stack;
        private int quo, rem;

        public StackDemo() { 
          stack = new Stack();
        }

        public void ConvertDecimalToBinary(int number)
        {

            while (number > 0)
            {
                quo = number / 2;
                rem=number%2;
                stack.Push(rem);
                number = quo;

            }
            Console.WriteLine($"Binary Number....");
            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }


        }
    }
}
