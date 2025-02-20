namespace ripasso_17._02._2025
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUno = new Button();
            checkBox1 = new CheckBox();
            lblUno = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            textBox3 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnUno
            // 
            btnUno.Location = new Point(93, 135);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(112, 34);
            btnUno.TabIndex = 0;
            btnUno.Text = "button1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.MouseClick += pippo;
            btnUno.MouseEnter += pluto;
            btnUno.MouseLeave += esco;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(98, 213);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblUno
            // 
            lblUno.AutoSize = true;
            lblUno.Location = new Point(96, 282);
            lblUno.Name = "lblUno";
            lblUno.Size = new Size(59, 25);
            lblUno.TabIndex = 2;
            lblUno.Text = "label1";
            lblUno.Click += pippo;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(441, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(442, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(447, 209);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(449, 267);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(93, 437);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(489, 179);
            listBox1.TabIndex = 7;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 400);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 8;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // button2
            // 
            button2.Location = new Point(261, 400);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 677);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblUno);
            Controls.Add(checkBox1);
            Controls.Add(btnUno);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            DoubleClick += Form1_DoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUno;
        private CheckBox checkBox1;
        private Label lblUno;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private ListBox listBox1;
        private TextBox textBox3;
        private Button button2;
    }
}
