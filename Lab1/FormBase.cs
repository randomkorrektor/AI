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

    public partial class FormBase : Form
    {
        
        private List<Student> staff = new List<Student>();

        public FormBase()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = staff[listBox1.SelectedIndex].GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Init = new FormInitialization();
            Init.ShowDialog();
            if (Init.name != null && Init.function != null)
            {
                staff.Add(new Student());
                staff[staff.Count - 1].InitStudent(Init.name, Init.function);
                listBox1.Items.Add(staff[staff.Count - 1].name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var lev = new FormLeveling(staff[listBox1.SelectedIndex]);
                lev.ShowDialog();


                richTextBox1.Text = staff[listBox1.SelectedIndex].GetData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            staff.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Clear();
            for (int i = 0; i < staff.Count; i++)
            {
                listBox1.Items.Add(staff[i].name);
            }
            listBox1.Refresh();
            richTextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
