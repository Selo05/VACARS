using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace VACARS
{
    public partial class VACARS_Register : Form
    {
        public VACARS_Register()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ea = Convert.ToString(textBox1);
            TextBox textBox5 = this.textBox5;
            textBox5.Text = "Code saved > userdata.txt";

            string path = @"C:\Users\sengu\source\repos\VACARS\VACARS\userdata.txt"; 
            
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine($"Email:{ea}");
                sw.WriteLine($"Username:{textBox2}");
                sw.WriteLine($"First:{textBox3}");
                sw.WriteLine($"Sur:{textBox4}");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
