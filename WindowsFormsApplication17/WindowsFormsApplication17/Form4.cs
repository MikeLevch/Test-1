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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
           
            InitializeComponent();
			
          
        }
        public string strTB;
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            strTB = this.maskedTextBox1.Text;

           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Form1 main = this.Owner as Form1;
            

           
               this.maskedTextBox1.Text = dt.tostring(); ;
          
            
               
       
           

        }
    }
}
