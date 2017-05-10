using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TaxCalculation
{
    public partial class Form1 : Form
    {        
        List<Panel> panelList = new List<Panel>();
        List<TextBox> tbList = new List<TextBox>();       
        Form2 PersonalInfo = new Form2();

        //The field to keep the output file
        private string outputFile = null;

        // The method for preparing a file for output
        private void fileMethod(string fileString)
        {
            string template = File.ReadAllText(@"blank.xml");
            template = template.Replace("{{position2}}", Form2.tb4F2.Text);
            template = template.Replace("{{surname2}}", Form2.tb2F2.Text);
            template = template.Replace("{{initials}}", Form2.tb5F2.Text);
            template = template.Replace("{{position1}}", Form2.tb3F2.Text);
            template = template.Replace("{{surname1}}", Form2.tb1F2.Text);
            template = template.Replace("{{sum}}", fileString);
            outputFile = template;            
        }

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
            StreamWriter oStream = new StreamWriter(@"PersonalInfo.txt");
            for (int i = 0; i < tbList.Count; i++)
            {
                oStream.WriteLine(tbList[i].Text);
            }
            oStream.Close();
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
            tbList.Add(Form2.tb1F2);
            tbList.Add(Form2.tb2F2);
            tbList.Add(Form2.tb3F2);
            tbList.Add(Form2.tb4F2);
            tbList.Add(Form2.tb5F2);

            if (File.Exists(@"BaseValue.txt") == true)
            {
                StreamReader iStream = new StreamReader(@"BaseValue.txt");
                string buffer = iStream.ReadToEnd();
                textBox5.Text = buffer;
                textBox6.Text = buffer;
                iStream.Close();
            }
            if (File.Exists(@"PersonalInfo.txt") == true)
            {
                StreamReader iStream = new StreamReader(@"PersonalInfo.txt");
                string textLine;
                int index = 0;
                do
                {
                    textLine = iStream.ReadLine();
                    tbList[index].Text = textLine;
                    ++index;
                    textLine = "";
                } while (iStream.Peek() != -1);
                iStream.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = TaxArithmetic.Tax1Count(textBox1.Text);
            fileMethod(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = TaxArithmetic.Tax2Count(textBox5.Text, textBox4.Text);
            fileMethod(textBox3.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox7.Text = TaxArithmetic.Tax3Count(textBox6.Text, textBox8.Text);
            fileMethod(textBox7.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            PersonalInfo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {    
            File.WriteAllText(@"statement.doc", outputFile);            
        }
    }
}