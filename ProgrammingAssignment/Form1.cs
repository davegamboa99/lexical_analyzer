using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = textBox1.Text.Length;
            //Console.WriteLine((Convert.ToString(size)));
            int[,] table = new int[17, 10] { {1,1,16,16,16,16,16,16,16,16},
                                        {1,1,3,2,1,16,16,16,16,16},
                                        {4,4,2,16,5,16,16,8,11,16},
                                        {16,16,3,2,16,16,16,16,16,16},
                                        {4,4,14,16,4,16,2,16,16,15},
                                        {16,16,14,16,5,6,2,16,16,15},
                                        {16,16,16,16,7,16,2,16,16,16},
                                        {16,16,14,16,7,16,2,16,16,15},
                                        {9,16,16,16,16,16,16,16,16,16},
                                        {16,16,16,16,16,16,16,10,16,16},
                                        {16,16,14,16,16,16,16,16,16,15},
                                        {12,16,16,16,16,16,16,16,16,16},
                                        {12,16,16,16,16,16,16,16,13,16},
                                        {16,16,14,16,16,16,2,16,16,15},
                                        {16,16,14,16,16,16,2,16,16,15},
                                        {16,16,16,16,16,16,16,16,16,16},
                                        {16,16,16,16,16,16,16,16,16,16}
            };
            int flag = 0;
            int state = 0;
            int input = 0;
            for(int i=0; i<size; i++)
            {
                if (Char.IsLetter(textBox1.Text[i]) is true)
                {
                    input = 0;
                    //Console.WriteLine(textBox1.Text[i]); debugging purposes
                }
                else if (textBox1.Text[i] == '_')
                {
                    input = 1;
                    //Console.WriteLine(textBox1.Text[i]); debugging purposes
                }
                else if (textBox1.Text[i] == ' ')
                {
                    input = 2;
                    //Console.WriteLine(textBox1.Text[i]); debugging purposes
                }
                else if (textBox1.Text[i] == '=')
                {
                    input = 3;
                    //Console.WriteLine(textBox1.Text[i]); debugging purposes
                }
                else if (Char.IsDigit(textBox1.Text[i]) is true)
                {
                    input = 4;
                    //Console.WriteLine(textBox1.Text[i]); debugging purposes
                }
                else if (textBox1.Text[i] == '.')
                {
                    input = 5;
                    //Console.WriteLine(textBox1.Text[i]); debugging purposes
                }
                else if (textBox1.Text[i] == '+' || textBox1.Text[i] == '-' || textBox1.Text[i] == '*' || textBox1.Text[i] == '/')
                {
                    input = 6;
                    //Console.WriteLine(textBox1.Text[i]); debugging purposes
                }
                else if (textBox1.Text[i] == '\'')
                {
                    input = 7;
                    //Console.WriteLine(textBox1.Text[i]); debugging purposes
                }
                else if(textBox1.Text[i] == '\"')
                {
                    input = 8;
                    //Console.WriteLine(textBox1.Text[i]); debugging purposes
                }
                else if(textBox1.Text[i] == ';')
                {
                    flag = 1;
                    input = 9;
                    //Console.WriteLine(textBox1.Text[i]); debugging purposes
                }

                state = table[state, input];

                Console.WriteLine(state);
                 Console.WriteLine("\n");
                if (state == 16)
                {
                    break;
                }
              

            }


            if (state == 16 || flag == 0)
                {
                    MessageBox.Show("Invalid");
                }
            else if (state == 15)
            {
                MessageBox.Show("Valid");
            }

        }
    }
}
