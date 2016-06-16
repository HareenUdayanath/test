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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            col.Add("test");
            textBox1.AutoCompleteCustomSource = col;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.dateTimePicker1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            while (textBox1.AutoCompleteCustomSource.Count > 1)
            {
                textBox1.AutoCompleteCustomSource.RemoveAt(textBox1.AutoCompleteCustomSource.Count - 1);
            }
            textBox1.AutoCompleteCustomSource.AddRange(new string[] {"ABC", "BCD", "CDE" });
            textBox1.AutoCompleteCustomSource.RemoveAt(0);
        }
    }
}
