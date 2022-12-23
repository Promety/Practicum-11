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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        class Array
        {
            public int[] IntArray;
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

            public void SortMass(ref int[] IntArray)//сортировка
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
                    //MessageBox.Show(IntArray[j] + "");
                }
            }

            public void Show(TextBox textBox, int[] IntArray)
            {

                foreach (int item in IntArray)
                    textBox.Text += $"{item} ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z;
            string[] arr = textBox1.Text.Split(' ');
            int[] IntArray = new int[arr.Length]; // объявляем новый массив с количеством элементов = c.
            Array array = new Array(arr.Length);
            for (int i = 0; i < IntArray.Length; i++)
            {
                IntArray[i] = Convert.ToInt32(arr[i]);
            }

            textBox2.Text += ("Отсортированный массив:\n") + Environment.NewLine;
            array.SortMass(ref IntArray);

            array.Show(textBox2, IntArray);
            textBox2.Text += Environment.NewLine + ("\nРазмерность массива:\n") + Environment.NewLine;
            int r = array.Size;
            textBox2.Text += (r) + Environment.NewLine;
            for (int i = 0; i < IntArray.Length; i++)
            {
                array.IntArray[i] = IntArray[i];
            }

            textBox2.Text += ("Умноженный массив:") + Environment.NewLine;
            z = int.Parse(numericUpDown1.Text);

            array.Scalar = z;
            for (int i = 0; i < IntArray.Length; i++)
            {
                IntArray[i] = array.IntArray[i];
            }
            array.Show(textBox2, IntArray);
        }   
    }
}
