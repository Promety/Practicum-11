using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad11
{
    class Array
    {
        private int[] IntArray;
        private int n;
        public Array(int n)
        {
            IntArray = new int[n];
        }
       
        //..........................................................................
        public void Show()
        {
            foreach (int item in IntArray)
                Console.Write("{0} ", item);
        }
        //..........................................................................
        public void Enter()
        {
            for (int i = 0; i < IntArray.Length; i++)
            {
                int dop;
                Console.Write("IntArray[{0}] = ", i);
                while (!int.TryParse(Console.ReadLine(), out dop))
                    Console.Write("Ошибка введите заново\nIntArray[{0}] = ", i);
                IntArray[i] = dop;
            }
        }
       
        //..........................................................................
        public void SortMass()//сортировка
        {
            int temp = 0;
            for (int j = 0; j < IntArray.Length - 1; j++)
            {
                for (int i = 0; i < IntArray.Length - 1; i++)
                {
                    if (IntArray[i] > IntArray[i + 1])
                    {
                        temp = IntArray[i + 1];
                        IntArray[i + 1] = IntArray[i];
                        IntArray[i] = temp;
                    }
                }
            }
        }
        //..........................................................................
        private int Size
        {
            get { return IntArray.Length; }
        }
        //..........................................................................
        public int Scalar
        {
            set
            {
                for (int i = 0; i < IntArray.Length; i++)
                {
                    IntArray[i] *= value;
                }
            }
        }
        
        //...............................................................................

        class Program
        {
            static void Main(string[] args)
            {
                int z;
                int k;
                Console.WriteLine("Введите размерность массива:");
                while (!int.TryParse(Console.ReadLine(), out k)|| k<=0)
                Console.WriteLine("error");
                Array array = new Array(k);
                Console.WriteLine("Введите элементы массива:");

                array.Enter();
                array.SortMass();
                Console.WriteLine("Отсортированный массив:");
                array.Show();

              
                int r = array.Size;
                    Console.WriteLine();
                    Console.WriteLine("Размерность массива:");

                    Console.WriteLine(r);
                Console.WriteLine("Введите Скаляр:");
                while (!int.TryParse(Console.ReadLine(), out z))
                    Console.WriteLine("Error");
                Console.WriteLine("Умноженный массив:");

                array.Scalar = z;
                array.Show();

              
            }
        }
    }
}