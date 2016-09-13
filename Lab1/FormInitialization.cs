using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormInitialization : Form
    {
        public string name, function;
        public FormInitialization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                name = textBox1.Text;
                function = textBox2.Text;
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Enter the name and function");
            }
        }

        private void FormInitialization_Load(object sender, EventArgs e)
        {

        }
    }
}
