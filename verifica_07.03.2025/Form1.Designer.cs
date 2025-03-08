namespace verifica_07._03._2025
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
            txDimensione = new TextBox();
            btIstanzia = new Button();
            label1 = new Label();
            label2 = new Label();
            txMin = new TextBox();
            label3 = new Label();
            txMax = new TextBox();
            btRiempi = new Button();
            lbDisplay = new Label();
            btMinimo = new Button();
            lbMinimo = new Label();
            lbMedia = new Label();
            btSup = new Button();
            lbSuperiori = new Label();
            btCreaMatrice = new Button();
            dtgMatrice = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgMatrice).BeginInit();
            SuspendLayout();
            // 
            // txDimensione
            // 
            txDimensione.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txDimensione.Location = new Point(46, 53);
            txDimensione.Name = "txDimensione";
            txDimensione.Size = new Size(150, 39);
            txDimensione.TabIndex = 0;
            // 
            // btIstanzia
            // 
            btIstanzia.Location = new Point(234, 52);
            btIstanzia.Name = "btIstanzia";
            btIstanzia.Size = new Size(150, 42);
            btIstanzia.TabIndex = 1;
            btIstanzia.Text = "Istanzia";
            btIstanzia.UseVisualStyleBackColor = true;
            btIstanzia.Click += btIstanzia_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 25);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 2;
            label1.Text = "Dimensione vettore";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 117);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 4;
            label2.Text = "Valore minimo";
            // 
            // txMin
            // 
            txMin.Enabled = false;
            txMin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txMin.Location = new Point(46, 145);
            txMin.Name = "txMin";
            txMin.Size = new Size(150, 39);
            txMin.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 117);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 6;
            label3.Text = "Valore massimo";
            // 
            // txMax
            // 
            txMax.Enabled = false;
            txMax.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txMax.Location = new Point(234, 145);
            txMax.Name = "txMax";
            txMax.Size = new Size(150, 39);
            txMax.TabIndex = 5;
            // 
            // btRiempi
            // 
            btRiempi.Enabled = false;
            btRiempi.Location = new Point(421, 145);
            btRiempi.Name = "btRiempi";
            btRiempi.Size = new Size(150, 42);
            btRiempi.TabIndex = 7;
            btRiempi.Text = "Riempi";
            btRiempi.UseVisualStyleBackColor = true;
            btRiempi.Click += btRiempi_Click;
            // 
            // lbDisplay
            // 
            lbDisplay.BackColor = Color.FromArgb(192, 255, 255);
            lbDisplay.BorderStyle = BorderStyle.FixedSingle;
            lbDisplay.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDisplay.Location = new Point(46, 218);
            lbDisplay.Name = "lbDisplay";
            lbDisplay.Size = new Size(878, 55);
            lbDisplay.TabIndex = 8;
            // 
            // btMinimo
            // 
            btMinimo.Enabled = false;
            btMinimo.Location = new Point(46, 307);
            btMinimo.Name = "btMinimo";
            btMinimo.Size = new Size(150, 42);
            btMinimo.TabIndex = 9;
            btMinimo.Text = "Cerca minimo";
            btMinimo.UseVisualStyleBackColor = true;
            btMinimo.Click += btMinimo_Click;
            // 
            // lbMinimo
            // 
            lbMinimo.BackColor = Color.FromArgb(192, 255, 255);
            lbMinimo.BorderStyle = BorderStyle.FixedSingle;
            lbMinimo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMinimo.Location = new Point(216, 307);
            lbMinimo.Name = "lbMinimo";
            lbMinimo.Size = new Size(101, 42);
            lbMinimo.TabIndex = 10;
            // 
            // lbMedia
            // 
            lbMedia.BackColor = Color.FromArgb(192, 255, 255);
            lbMedia.BorderStyle = BorderStyle.FixedSingle;
            lbMedia.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMedia.Location = new Point(216, 385);
            lbMedia.Name = "lbMedia";
            lbMedia.Size = new Size(101, 42);
            lbMedia.TabIndex = 12;
            // 
            // btSup
            // 
            btSup.Enabled = false;
            btSup.Location = new Point(46, 385);
            btSup.Name = "btSup";
            btSup.Size = new Size(150, 68);
            btSup.TabIndex = 11;
            btSup.Text = "Cerca superiori alla media";
            btSup.UseVisualStyleBackColor = true;
            btSup.Click += btSup_Click;
            // 
            // lbSuperiori
            // 
            lbSuperiori.BackColor = Color.FromArgb(192, 255, 255);
            lbSuperiori.BorderStyle = BorderStyle.FixedSingle;
            lbSuperiori.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSuperiori.Location = new Point(347, 385);
            lbSuperiori.Name = "lbSuperiori";
            lbSuperiori.Size = new Size(101, 42);
            lbSuperiori.TabIndex = 13;
            // 
            // btCreaMatrice
            // 
            btCreaMatrice.Enabled = false;
            btCreaMatrice.Location = new Point(46, 480);
            btCreaMatrice.Name = "btCreaMatrice";
            btCreaMatrice.Size = new Size(150, 40);
            btCreaMatrice.TabIndex = 14;
            btCreaMatrice.Text = "Crea matrice";
            btCreaMatrice.UseVisualStyleBackColor = true;
            btCreaMatrice.Click += btCreaMatrice_Click;
            // 
            // dtgMatrice
            // 
            dtgMatrice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMatrice.Location = new Point(50, 539);
            dtgMatrice.Name = "dtgMatrice";
            dtgMatrice.RowHeadersWidth = 62;
            dtgMatrice.Size = new Size(874, 323);
            dtgMatrice.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 885);
            Controls.Add(dtgMatrice);
            Controls.Add(btCreaMatrice);
            Controls.Add(lbSuperiori);
            Controls.Add(lbMedia);
            Controls.Add(btSup);
            Controls.Add(lbMinimo);
            Controls.Add(btMinimo);
            Controls.Add(lbDisplay);
            Controls.Add(btRiempi);
            Controls.Add(label3);
            Controls.Add(txMax);
            Controls.Add(label2);
            Controls.Add(txMin);
            Controls.Add(label1);
            Controls.Add(btIstanzia);
            Controls.Add(txDimensione);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgMatrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txDimensione;
        private Button btIstanzia;
        private Label label1;
        private Label label2;
        private TextBox txMin;
        private Label label3;
        private TextBox txMax;
        private Button btRiempi;
        private Label lbDisplay;
        private Button btMinimo;
        private Label lbMinimo;
        private Label lbMedia;
        private Button btSup;
        private Label lbSuperiori;
        private Button btCreaMatrice;
        private DataGridView dtgMatrice;
    }
}
