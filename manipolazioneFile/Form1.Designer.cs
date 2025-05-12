namespace manipolazioneFile
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
            btCheck = new Button();
            btCrea = new Button();
            btCopia = new Button();
            btDelete = new Button();
            btLeggi = new Button();
            btReadAllLines = new Button();
            btStreamReader = new Button();
            textBox1 = new TextBox();
            txRighe = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btCheck
            // 
            btCheck.Location = new Point(48, 67);
            btCheck.Name = "btCheck";
            btCheck.Size = new Size(190, 53);
            btCheck.TabIndex = 0;
            btCheck.Text = "controlla esistenza";
            btCheck.UseVisualStyleBackColor = true;
            btCheck.Click += btCheck_Click;
            // 
            // btCrea
            // 
            btCrea.Location = new Point(48, 126);
            btCrea.Name = "btCrea";
            btCrea.Size = new Size(190, 53);
            btCrea.TabIndex = 1;
            btCrea.Text = "crea file";
            btCrea.UseVisualStyleBackColor = true;
            btCrea.Click += btCrea_Click;
            // 
            // btCopia
            // 
            btCopia.Location = new Point(48, 185);
            btCopia.Name = "btCopia";
            btCopia.Size = new Size(190, 53);
            btCopia.TabIndex = 2;
            btCopia.Text = "copia file";
            btCopia.UseVisualStyleBackColor = true;
            btCopia.Click += btCopia_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(48, 244);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(190, 53);
            btDelete.TabIndex = 3;
            btDelete.Text = "cancella file";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btLeggi
            // 
            btLeggi.Location = new Point(394, 67);
            btLeggi.Name = "btLeggi";
            btLeggi.Size = new Size(350, 53);
            btLeggi.TabIndex = 4;
            btLeggi.Text = "leggi file con ReadAllText";
            btLeggi.UseVisualStyleBackColor = true;
            btLeggi.Click += btLeggi_Click;
            // 
            // btReadAllLines
            // 
            btReadAllLines.Location = new Point(394, 126);
            btReadAllLines.Name = "btReadAllLines";
            btReadAllLines.Size = new Size(350, 53);
            btReadAllLines.TabIndex = 5;
            btReadAllLines.Text = "leggi file con ReadAllLines";
            btReadAllLines.UseVisualStyleBackColor = true;
            btReadAllLines.Click += btReadAllLines_Click;
            // 
            // btStreamReader
            // 
            btStreamReader.Location = new Point(394, 185);
            btStreamReader.Name = "btStreamReader";
            btStreamReader.Size = new Size(350, 53);
            btStreamReader.TabIndex = 6;
            btStreamReader.Text = "leggi file con StreamReader ";
            btStreamReader.UseVisualStyleBackColor = true;
            btStreamReader.Click += btStreamReader_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(394, 293);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(346, 145);
            textBox1.TabIndex = 7;
            // 
            // txRighe
            // 
            txRighe.Location = new Point(547, 245);
            txRighe.Name = "txRighe";
            txRighe.Size = new Size(193, 31);
            txRighe.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(396, 246);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 9;
            label1.Text = "righe da leggere:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txRighe);
            Controls.Add(textBox1);
            Controls.Add(btStreamReader);
            Controls.Add(btReadAllLines);
            Controls.Add(btLeggi);
            Controls.Add(btDelete);
            Controls.Add(btCopia);
            Controls.Add(btCrea);
            Controls.Add(btCheck);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCheck;
        private Button btCrea;
        private Button btCopia;
        private Button btDelete;
        private Button btLeggi;
        private Button btReadAllLines;
        private Button btStreamReader;
        private TextBox textBox1;
        private TextBox txRighe;
        private Label label1;
    }
}
