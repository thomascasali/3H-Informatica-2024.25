namespace introduzione_windows_form
{
    public partial class Form1 : Form
    {
        int conta = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Form1.ActiveForm.Text = "CIAO";
        }

        private void btnCliccami_Click(object sender, EventArgs e)
        {
            conta++;
            btnCliccami.Text = "Mi hai cliccato " + conta + " volte";
        }

        private void btnCattura_Click(object sender, EventArgs e)
        {
            lblCattura.Text = txtInput.Text;
        }
    }
}
