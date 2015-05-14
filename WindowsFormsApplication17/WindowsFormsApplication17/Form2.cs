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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
           
            InitializeComponent();
           
          
        }
        public string strTB;
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            strTB = this.maskedTextBox1.Text;

           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            Form1 main = this.Owner as Form1;
            maskedTextBox1.Mask = "00/00/0000           "+"0000"+"°С";

           
               this.maskedTextBox1.Text = main.strLB; ;
          
            
        }
        
        public string getpassword(string name)
        {
            string pasw = null;

            string connectionString = DB3.Properties.Settings.Default.ClinicConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand myCommand = con.CreateCommand();
            myCommand.CommandText = "SELECT passw FROM autohorize WHERE name LIKE '" + name + "'";
            SqlDataReader dataReader = myCommand.ExecuteReader();
            while (dataReader.Read())
            {
                pasw = dataReader.GetString(0);
            }
            dataReader.Close();
            con.Close();
            return pasw;
        }
    }
}
