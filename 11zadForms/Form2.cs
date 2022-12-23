using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11zadForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        class Array
        {
            private int[] IntArray;
            private int n;
            public Array(int n)
            {
                IntArray = new int[n];
            }
            
            public int Size
            {
                get { return IntArray.Length; }
            }
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
            public void Enter(TextBox textBox)
            {
                
            }
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
            public void Show(TextBox textBox)
            {
                foreach (int item in IntArray)
                    textBox.Text += $"{item} ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z;
            int k = int.Parse(textBox3.Text);
            // Console.WriteLine("Введите размерность массива:");
           
            //onsole.WriteLine("error");
            Array array = new Array(k);
            
            //Console.WriteLine("Введите элементы массива:");
            // Парсим значение из текстового поля textBox1.
            string[] sNums = textBox1.Text.Split(' '); 
            //if (k > sNums.Length)
            //{ 
            //    MessageBox.Show("Длина массива не соответствует введенному!");
            //    return;
            //}
            int[] IntArray = new int[k]; // объявляем новый массив с количеством элементов = c.
            for (int i = 0; i < IntArray.Length; i++)
                IntArray[k] = Convert.ToInt32(textBox1.Text);

            array.SortMass();
            //Console.WriteLine("Отсортированный массив:");
            array.Show(textBox2);


            int r = array.Size;
            //Console.WriteLine();
            //Console.WriteLine("Размерность массива:");

            Console.WriteLine(r);
            //Console.WriteLine("Введите Скаляр:");
            z = int.Parse(numericUpDown2.Text);
            //Console.WriteLine("Error");
            //Console.WriteLine("Умноженный массив:");

            array.Scalar = z;
            array.Show(textBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // int z = 0;
           // Array array = new Array(z);
           // textBox1.Text += ("\nОтсортированный массив:\n");
           // array.SortMass();
           // array.Show(textBox1);
           
           // int r = array.Size;
           //textBox1.Text ="Размерность массива:";

           // Console.WriteLine(r);
            
           // z = int.Parse(numericUpDown2.Text);
           // array.Scalar = z;
           // array.Show(textBox1);
           // array.Enter(textBox1);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "Введите размерность массива:\n";

        }
    }
}
