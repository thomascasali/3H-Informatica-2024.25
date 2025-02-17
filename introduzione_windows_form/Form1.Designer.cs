namespace introduzione_windows_form
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
            txtInput = new TextBox();
            btnCattura = new Button();
            lblCattura = new Label();
            SuspendLayout();
            // 
            // btnCliccami
            // 
            btnCliccami.Location = new Point(468, 188);
            btnCliccami.Name = "btnCliccami";
            btnCliccami.Size = new Size(264, 84);
            btnCliccami.TabIndex = 0;
            btnCliccami.Text = "CLICCAMI";
            btnCliccami.UseVisualStyleBackColor = true;
            btnCliccami.Click += btnCliccami_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(128, 439);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(287, 31);
            txtInput.TabIndex = 1;
            // 
            // btnCattura
            // 
            btnCattura.Location = new Point(437, 439);
            btnCattura.Name = "btnCattura";
            btnCattura.Size = new Size(116, 34);
            btnCattura.TabIndex = 2;
            btnCattura.Text = "CATTURA!";
            btnCattura.UseVisualStyleBackColor = true;
            btnCattura.Click += btnCattura_Click;
            // 
            // lblCattura
            // 
            lblCattura.AutoSize = true;
            lblCattura.Location = new Point(573, 443);
            lblCattura.Name = "lblCattura";
            lblCattura.Size = new Size(256, 25);
            lblCattura.TabIndex = 3;
            lblCattura.Text = "qui comparirà il testo catturato";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1200, 750);
            Controls.Add(lblCattura);
            Controls.Add(btnCattura);
            Controls.Add(txtInput);
            Controls.Add(btnCliccami);
            Name = "Form1";
            Text = "TITOLO DELLA FINESTRA";
            DoubleClick += Form1_DoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCliccami;
        private TextBox txtInput;
        private Button btnCattura;
        private Label lblCattura;
    }
}
