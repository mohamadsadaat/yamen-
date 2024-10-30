using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yamen_barbour
{
    class bs
    {
        public int ite(int[] array,int search )
        {
            int left = 0;
            int right = array.Length - 1;
            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == search)
                {
                    return mid;
                }
                else if (array[mid] > search)
                {
                    left = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
        public int rec(int[] array, int search, int left, int right)
        {
            if(left > right)
            {
                return -1;
            }
            int mid = left + (right - left) / 2;
            if (array[mid] == search)
            {
                return mid;
            }
            else if (array[mid] > search)
            {
                return rec(array, search, left, mid - 1);
            }
            else
            {
                return rec(array, search, mid + 1, right);

            }
            return -1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bs b = new bs();
            int[] arr = { 1, 2, 3, 6, 8, 9, 15, 19, 29, 49 };
            Console.WriteLine("enter number ");
            int search =int.Parse(Console.ReadLine());
            
                int i = b.ite(arr, search);
                int r = b.rec(arr, search, 0, arr.Length - 1);
                if(i != -1)
                {
                    Console.WriteLine("the search in iterativ is" + search + "in index" + i);
                }
                else
                {
                    Console.WriteLine("the search in iterativ is" + search + "unavalible");
                }
                if (r != -1)
                {
                    Console.WriteLine("the search in iterativ is" + search + "in index" + r);
                }
                else
                {
                    Console.WriteLine("the search in iterativ is" + search + "unavalible");
                }
           
        }
    }
}
