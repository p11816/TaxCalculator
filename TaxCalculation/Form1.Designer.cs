namespace TaxCalculation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("Исковое заявл. имущ. хар-ра");
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("Общие суды", new System.Windows.Forms.TreeNode[] {
            treeNode146});
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("Исковое заявл. имущ. хар-ра");
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("Заявление приказное");
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("Экономические суды", new System.Windows.Forms.TreeNode[] {
            treeNode148,
            treeNode149});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.treeView1.BackColor = System.Drawing.SystemColors.Info;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.HotTracking = true;
            this.treeView1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new System.Drawing.Point(27, 68);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode146.Name = "Node2";
            treeNode146.Tag = "0";
            treeNode146.Text = "Исковое заявл. имущ. хар-ра";
            treeNode147.Name = "Node0";
            treeNode147.Tag = "-1";
            treeNode147.Text = "Общие суды";
            treeNode148.Name = "Node3";
            treeNode148.Tag = "1";
            treeNode148.Text = "Исковое заявл. имущ. хар-ра";
            treeNode149.Name = "Node5";
            treeNode149.Tag = "2";
            treeNode149.Text = "Заявление приказное";
            treeNode150.Name = "Node1";
            treeNode150.Tag = "-2";
            treeNode150.Text = "Экономические суды";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode147,
            treeNode150});
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(233, 112);
            this.treeView1.TabIndex = 0;
            this.treeView1.TabStop = false;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(290, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 237);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Location = new System.Drawing.Point(290, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 237);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Базовая величина, BYN";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(43, 62);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(145, 23);
            this.textBox5.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "Рассчитать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Государственная пошлина, BYN";
            // 
            // panel3
            // 
            this.panel3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Location = new System.Drawing.Point(291, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 237);
            this.panel3.TabIndex = 7;
            this.panel3.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Базовая величина, BYN";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(43, 62);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(145, 23);
            this.textBox6.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(356, 154);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "Рассчитать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Государственная пошлина, BYN";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(95, 155);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(237, 26);
            this.textBox7.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Сумма взыскания, BYN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(264, 62);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(184, 23);
            this.textBox8.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(95, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 26);
            this.textBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Цена иска, BYN";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(264, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(184, 23);
            this.textBox4.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(356, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 27);
            this.button4.TabIndex = 4;
            this.button4.Text = "Рассчитать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Государственная пошлина, BYN";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(95, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 26);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цена иска, BYN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 23);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ввод данных";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(594, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Импорт в файл";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(716, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(672, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(779, 431);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
    }
}