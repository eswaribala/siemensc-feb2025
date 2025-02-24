using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class RefDemo
    {
        public static ref int ProcessData(ref int[] numbers,int element)
        {
            int position= numbers.ToList().FindIndex(x => x == element);
            return ref numbers[position];

        }
    }
}
