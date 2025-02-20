namespace calcolatrice
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
            txNumeri = new TextBox();
            btPiu = new Button();
            btMeno = new Button();
            btUguale = new Button();
            lbRisultato = new Label();
            SuspendLayout();
            // 
            // txNumeri
            // 
            txNumeri.BackColor = Color.FromArgb(192, 255, 255);
            txNumeri.BorderStyle = BorderStyle.FixedSingle;
            txNumeri.Font = new Font("Courier New", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txNumeri.ForeColor = Color.FromArgb(0, 0, 192);
            txNumeri.Location = new Point(116, 48);
            txNumeri.Name = "txNumeri";
            txNumeri.Size = new Size(573, 89);
            txNumeri.TabIndex = 0;
            txNumeri.TextAlign = HorizontalAlignment.Right;
            txNumeri.KeyPress += txNumeri_KeyPress;
            // 
            // btPiu
            // 
            btPiu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPiu.Location = new Point(116, 152);
            btPiu.Name = "btPiu";
            btPiu.Size = new Size(63, 65);
            btPiu.TabIndex = 1;
            btPiu.Text = "+";
            btPiu.UseVisualStyleBackColor = true;
            btPiu.Click += btPiu_Click;
            // 
            // btMeno
            // 
            btMeno.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btMeno.Location = new Point(185, 152);
            btMeno.Name = "btMeno";
            btMeno.Size = new Size(63, 65);
            btMeno.TabIndex = 2;
            btMeno.Text = "-";
            btMeno.UseVisualStyleBackColor = true;
            btMeno.Click += btMeno_Click;
            // 
            // btUguale
            // 
            btUguale.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btUguale.Location = new Point(116, 234);
            btUguale.Name = "btUguale";
            btUguale.Size = new Size(63, 65);
            btUguale.TabIndex = 3;
            btUguale.Text = "=";
            btUguale.UseVisualStyleBackColor = true;
            btUguale.Click += btUguale_Click;
            // 
            // lbRisultato
            // 
            lbRisultato.BackColor = Color.FromArgb(192, 255, 192);
            lbRisultato.BorderStyle = BorderStyle.FixedSingle;
            lbRisultato.FlatStyle = FlatStyle.System;
            lbRisultato.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRisultato.ImageAlign = ContentAlignment.MiddleRight;
            lbRisultato.Location = new Point(118, 315);
            lbRisultato.Name = "lbRisultato";
            lbRisultato.Size = new Size(571, 63);
            lbRisultato.TabIndex = 4;
            lbRisultato.Text = "risultato";
            lbRisultato.TextAlign = ContentAlignment.MiddleRight;
            lbRisultato.UseMnemonic = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 450);
            Controls.Add(lbRisultato);
            Controls.Add(btUguale);
            Controls.Add(btMeno);
            Controls.Add(btPiu);
            Controls.Add(txNumeri);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txNumeri;
        private Button btPiu;
        private Button btMeno;
        private Button btUguale;
        private Label lbRisultato;
    }
}
