namespace WinFormsApp_test
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
            btnCliccami = new Button();
            lblEtichetta = new Label();
            SuspendLayout();
            // 
            // btnCliccami
            // 
            btnCliccami.Location = new Point(63, 61);
            btnCliccami.Name = "btnCliccami";
            btnCliccami.Size = new Size(112, 34);
            btnCliccami.TabIndex = 0;
            btnCliccami.Text = "CLICCAMI";
            btnCliccami.UseVisualStyleBackColor = true;
            btnCliccami.Click += btnCliccami_Click;
            // 
            // lblEtichetta
            // 
            lblEtichetta.AutoSize = true;
            lblEtichetta.Location = new Point(75, 142);
            lblEtichetta.Name = "lblEtichetta";
            lblEtichetta.Size = new Size(0, 25);
            lblEtichetta.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEtichetta);
            Controls.Add(btnCliccami);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCliccami;
        private Label lblEtichetta;
    }
}
