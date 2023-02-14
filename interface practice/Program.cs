using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayClass;

namespace interface_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray(4);
            Console.WriteLine(arr.Size);
            arr[0] = 6;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr.Show();
            Console.WriteLine("----------------------\n");
            arr.Show("Message");
            Console.WriteLine(arr.Avg());
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Search(2));
            Console.WriteLine(arr.Search(3));
            arr.SortDesc();
            arr.Show();
            arr.SortAsc();
            arr.Show();
            Console.ReadKey();
        }
    }
}
