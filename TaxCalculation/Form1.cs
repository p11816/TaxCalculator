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
    public partial class Form1 : Form
    {
        List<Panel> panelList = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView myTree = (TreeView)sender;                             
            int index = Convert.ToInt32(myTree.SelectedNode.Tag);            
            if (index == -1 || index == -2)
            {
                myTree.SelectedNode.Expand();
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {                   
                    panelList[i].SendToBack();
                    panelList[i].Visible = false;
                }
                panelList[index].Visible = true;
                panelList[index].BringToFront();                 
            }            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelList.Add(panel1);
            panelList.Add(panel2);
            panelList.Add(panel3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = TaxArithmetic.Tax1Count(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = TaxArithmetic.Tax2Count(textBox5.Text, textBox4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox7.Text = TaxArithmetic.Tax3Count(textBox6.Text, textBox8.Text);
        }
    }
}