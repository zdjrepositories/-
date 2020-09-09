using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 大学生体质测评系统
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            
            System.Threading.Thread.Sleep(8000);
            Form1_essential_information form1 = new Form1_essential_information();
            this.Close();
            form1.Show();
            
     
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
       
           
            
            
    }

 
}
