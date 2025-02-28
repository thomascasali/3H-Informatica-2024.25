namespace esercizio_verifica_recupero_28._02._2025
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
            label1 = new Label();
            txDimensione = new TextBox();
            btIstanzia = new Button();
            btRiempi = new Button();
            label2 = new Label();
            lbDisplay = new Label();
            btMax = new Button();
            lbMax = new Label();
            lbMedia = new Label();
            btMedia = new Button();
            btInverti = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 19);
            label1.Name = "label1";
            label1.Size = new Size(283, 25);
            label1.TabIndex = 0;
            label1.Text = "Inserisci la dimensione del vettore:";
            // 
            // txDimensione
            // 
            txDimensione.Location = new Point(346, 14);
            txDimensione.Name = "txDimensione";
            txDimensione.Size = new Size(53, 31);
            txDimensione.TabIndex = 1;
            // 
            // btIstanzia
            // 
            btIstanzia.Location = new Point(407, 13);
            btIstanzia.Name = "btIstanzia";
            btIstanzia.Size = new Size(160, 34);
            btIstanzia.TabIndex = 2;
            btIstanzia.Text = "Istanzia vettore";
            btIstanzia.UseVisualStyleBackColor = true;
            btIstanzia.Click += btIstanzia_Click;
            // 
            // btRiempi
            // 
            btRiempi.Location = new Point(59, 112);
            btRiempi.Name = "btRiempi";
            btRiempi.Size = new Size(147, 34);
            btRiempi.TabIndex = 3;
            btRiempi.Text = "Riempi vettore";
            btRiempi.UseVisualStyleBackColor = true;
            btRiempi.Click += btRiempi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 346);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 4;
            label2.Text = "Vettore:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbDisplay
            // 
            lbDisplay.BackColor = Color.FromArgb(192, 255, 255);
            lbDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDisplay.ForeColor = Color.Blue;
            lbDisplay.Location = new Point(59, 383);
            lbDisplay.Name = "lbDisplay";
            lbDisplay.Size = new Size(666, 38);
            lbDisplay.TabIndex = 5;
            lbDisplay.Text = "label3";
            // 
            // btMax
            // 
            btMax.Location = new Point(56, 174);
            btMax.Name = "btMax";
            btMax.Size = new Size(150, 34);
            btMax.TabIndex = 6;
            btMax.Text = "Cerca massimo";
            btMax.UseVisualStyleBackColor = true;
            btMax.Click += btMax_Click;
            // 
            // lbMax
            // 
            lbMax.BackColor = Color.FromArgb(192, 255, 255);
            lbMax.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMax.ForeColor = Color.Blue;
            lbMax.Location = new Point(229, 173);
            lbMax.Name = "lbMax";
            lbMax.Size = new Size(100, 34);
            lbMax.TabIndex = 7;
            // 
            // lbMedia
            // 
            lbMedia.BackColor = Color.FromArgb(192, 255, 255);
            lbMedia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMedia.ForeColor = Color.Blue;
            lbMedia.Location = new Point(230, 236);
            lbMedia.Name = "lbMedia";
            lbMedia.Size = new Size(100, 34);
            lbMedia.TabIndex = 9;
            // 
            // btMedia
            // 
            btMedia.Location = new Point(57, 237);
            btMedia.Name = "btMedia";
            btMedia.Size = new Size(150, 34);
            btMedia.TabIndex = 8;
            btMedia.Text = "Calcola media";
            btMedia.UseVisualStyleBackColor = true;
            btMedia.Click += btMedia_Click;
            // 
            // btInverti
            // 
            btInverti.Location = new Point(60, 295);
            btInverti.Name = "btInverti";
            btInverti.Size = new Size(147, 34);
            btInverti.TabIndex = 10;
            btInverti.Text = "Inverti vettore";
            btInverti.UseVisualStyleBackColor = true;
            btInverti.Click += btInverti_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btInverti);
            Controls.Add(lbMedia);
            Controls.Add(btMedia);
            Controls.Add(lbMax);
            Controls.Add(btMax);
            Controls.Add(lbDisplay);
            Controls.Add(label2);
            Controls.Add(btRiempi);
            Controls.Add(btIstanzia);
            Controls.Add(txDimensione);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txDimensione;
        private Button btIstanzia;
        private Button btRiempi;
        private Label label2;
        private Label lbDisplay;
        private Button btMax;
        private Label lbMax;
        private Label lbMedia;
        private Button btMedia;
        private Button btInverti;
    }
}
