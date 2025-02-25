using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
   public class InDemo
    {
        public static void ShowData(in int data)
        {
           // data = 67; //compiler error since readonly
            Console.WriteLine(data);
        }
    }
}
