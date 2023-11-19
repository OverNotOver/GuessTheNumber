using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        public static int winNumber = RandNumber();
        public Form1()
        {
            InitializeComponent();

        }


        static int RandNumber()
        {
            Random random = new Random();
            int winNumb = random.Next(0, 100);
            return winNumb;

        }


        static async Task<string> StartName(RichTextBox richTextBox, string words)
        {
            string[] arrayWords = words.Split(' ');
            for (int i = 0; i < arrayWords.Length; i++)
            {
                richTextBox.Text += arrayWords[i] + " ";
                await Task.Delay(50);
            }

            return words;

        }


        private async void Check_Click(object sender, EventArgs e)
        {
            string vvod = richTextBox1.Text;
            string numbBig = "Число большое. Давай по меньше............";
            string numbLittle = "Число менькое. Давай по больше...........";

            if (int.TryParse(vvod, out int result))
            {
                if (result > winNumber)
                {
                    richTextBox2.Clear();                  
                    richTextBox2.Text = await StartName(richTextBox2, numbBig);
                }
                else if (result < winNumber)
                {
                    richTextBox2.Clear();
                    richTextBox2.Text = await StartName(richTextBox2, numbLittle);
                }
                else
                {
                    richTextBox2.Clear();
                    richTextBox2.Text = "ПЕРЕМОГА! ВІТАЮ!" + " " + richTextBox1.Text;
                }
            }
            else
            {
                richTextBox1.Text = "Введи числа!!!!";
            }
            await Task.Delay(1000);
            richTextBox1.Clear();


        }
        private async void start_Click(object sender, EventArgs e)
        {
            string words = "Привет, угадай число від 0 до 100! Угадаєш перемагаєш!";
            await StartName(richTextBox2, words);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int newWinNumb = RandNumber();
            winNumber = newWinNumb;
            richTextBox2.Clear();
            start_Click(sender, e);
        }


        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
        }

       
    }
}
