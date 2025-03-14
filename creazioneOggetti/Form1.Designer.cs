namespace creazioneOggetti
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
            btCrea = new Button();
            btPulisci = new Button();
            SuspendLayout();
            // 
            // btCrea
            // 
            btCrea.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCrea.Location = new Point(40, 21);
            btCrea.Name = "btCrea";
            btCrea.Size = new Size(163, 49);
            btCrea.TabIndex = 0;
            btCrea.Text = "Crea label";
            btCrea.UseVisualStyleBackColor = true;
            btCrea.Click += button1_Click;
            // 
            // btPulisci
            // 
            btPulisci.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPulisci.Location = new Point(589, 21);
            btPulisci.Name = "btPulisci";
            btPulisci.Size = new Size(163, 49);
            btPulisci.TabIndex = 1;
            btPulisci.Text = "Pulisci label";
            btPulisci.UseVisualStyleBackColor = true;
            btPulisci.Click += btPulisci_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btPulisci);
            Controls.Add(btCrea);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btCrea;
        private Button btPulisci;
    }
}
