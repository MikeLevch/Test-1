using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    
    public partial class Form1 : Form
    {
        public string strLB;
        public Form1()
        {
            InitializeComponent();
        }
        Queue<string> qe = new Queue<string>();//Очередь
        Stack<string> stack = new Stack<string>(); //........
        int CelC = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            String stroka; int k = 0;
            if ((maskedTextBox1.Text != "  .  .   ") && (maskedTextBox2.Text != ""))
            {
                stroka = maskedTextBox1.Text + "            " + maskedTextBox2.Text + "°C";
                stack.Push(stroka);
                qe.Enqueue(stroka);
                listBox1.Items.Add(stack.Peek()); //СТЕК ТУТ!
                //Changet by Stasyan. Stek one is useless.
		int stas;
		stas=1;  
                k++;
            }
            else 
            {
                MessageBox.Show("Введите дату и t°C", "Ошибка ввода");
            }

    
                


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox1.Image = imageList1.Images[0];
            
            maskedTextBox2.MaxLength = 2;

            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox2.Mask = "C00";

            

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
           
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            

            maskedTextBox1.Mask = "00/00/0000";
            string datePatt = @"MM/dd/yyyy";
            maskedTextBox1.Text = monthCalendar1.SelectionStart.ToString(datePatt);
            
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
     

             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                stack.Pop(); //И НЕМНОГО ТУТ
                //listBox1.SelectedIndex = 1;
            }
            else
                MessageBox.Show("Выберите элемент", "Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar == '-'))
            {
                e.Handled = true;
                
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            strLB = listBox1.Items[listBox1.SelectedIndex].ToString();
            Form2 f = new Form2();
            f.Owner = this;
            f.ShowDialog();


            listBox1.Items[listBox1.SelectedIndex] = f.strTB;
               // f.maskedTextBox1.Text;
       
            
            
        }
    }
}
