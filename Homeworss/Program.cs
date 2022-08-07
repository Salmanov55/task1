using System;

namespace Homeworss
{
    internal class Program
    { 
        private static int i;
        private static int sum;
        static void Main(string[] args)
        {
          
            int[] nums = {234, 5678, 56 };
            Console.WriteLine(nums[i]);
        }
        static int NumLength(int num, int temp, int count)
        {
             Console.WriteLine(count);

            if (temp > 9 || temp < -9)
                count= 1;
                temp = num;
            {
                temp = temp / 10;
                count++;
                return count;
            }

           
            
        }
        
         
    }
}
