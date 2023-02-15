using Interface;
using interface_practice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    public class MyArray : IOutput, IMath, ISort, ICalc, IOutput2, ICalc2
    {
       private int[] arr; 
        private int size;
        public int Size
        {
            get { return size; }
            set
            {
                try
                {
                    if (size < 0) throw new ArgumentException();
                    size = value;
                    arr = new int[size];

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Environment.Exit(1);
                }
            }
        }

        public MyArray()
        {
            size = 1;
            arr = new int[1];
        }
        public MyArray(int size)
        {
            this.size = size;
            arr = new int[size];
        }

        public int this[int i]
        {
            get 
            {
                return arr[i];
            }
            set
            {
                try
                {
                    if(i>size) throw new ArgumentException();
                    arr[i] = value;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Environment.Exit(1);
                }
            }
        }
        public void Show()
        {
            foreach(var i in arr){
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Show();
            Console.WriteLine("{0}\n",info);
        }

        public int Max()
        {
            int max = arr[0];     
            for(int i=0; i < arr.Length; i++)
            {
                if(arr[i] > max) max = arr[i];
            }
            return max;
        }

        public int Min()
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }

        public float Avg()
        {
            float sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                sum+= arr[i];
            }
            return sum/arr.Length;
        }

        public bool Search(int ValueToSearch)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == ValueToSearch) return true;
            }
            return false;
        }

        public void SortAsc()
        {
            if (size <= 1) return;
            int index = 0;
            while (index < arr.Length)
            {
                if (index == 0)
                    index++;
                if (arr[index] <= arr[index - 1])
                    index++;
                else
                {
                    (arr[index], arr[index - 1]) = (arr[index-1], arr[index]);
                    index--;
                }
            }
        }

        public void SortDesc()
        {
            if (size <= 1) return;
            int index = 0;
            while (index < arr.Length)
            {
                if (index == 0)
                    index++;
                if (arr[index] >= arr[index - 1])
                    index++;
                else
                {
                    (arr[index], arr[index - 1]) = (arr[index - 1], arr[index]);
                    index--;
                }
            }
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc == true)
            {
                SortAsc();
            }
            else SortDesc();
        }

        public int Less(int valueToCompare)
        {
            int counter = 0;
            foreach(var i in arr)
            {
                if(i < valueToCompare) counter++;
            }
            return counter;
        }

        public int Greater(int valueToCompare)
        {
            int counter = 0;
            foreach (var i in arr)
            {
                if (i > valueToCompare) counter++;
            }
            return counter;
        }

        public void ShowEven()
        {
            foreach(var i in arr)
            {
                if (i % 2 == 0) Console.WriteLine("{0} ", i);
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            foreach (var i in arr)
            {
                if (i % 2 == 0) Console.WriteLine("{0} ", i);
            }
            Console.WriteLine();
        }

        public int CountDistinct()
        {
           int count = arr.Length;
            foreach(var i in arr)
            {
                foreach(int j in arr)
                {
                    if (i == j)
                    {
                        count--;
                        break;
                    }
                }
            }
            return count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int counter = 0;
            foreach(var i in arr)
            {
                if (i == valueToCompare) counter++;
            }
            return counter;
        }
    }
}
