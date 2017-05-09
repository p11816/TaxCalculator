using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculation
{
    public partial class Form2 : Form
    {
        public static TextBox tb1F2 { get; private set; }
        public static TextBox tb2F2 { get; private set; }
        public static TextBox tb3F2 { get; private set; }
        public static TextBox tb4F2 { get; private set; }
        public static TextBox tb5F2 { get; private set; }

        public Form2()
        {
            InitializeComponent();
            tb1F2 = textBox1;
            tb2F2 = textBox2;
            tb3F2 = textBox3;
            tb4F2 = textBox4;
            tb5F2 = textBox5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();            
        }
    }
}
