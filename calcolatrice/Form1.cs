namespace calcolatrice
{
    public partial class Form1 : Form
    {
        int numero;
        char operazione;

        public Form1()
        {
            InitializeComponent();
        }

        private void txNumeri_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (char.IsNumber(e.KeyChar))
            //MessageBox.Show("è stato premuto un numero");
            if (char.IsLetter(e.KeyChar)) e.Handled = true;

        }

        private void btPiu_Click(object sender, EventArgs e)
        {
            numero = Convert.ToInt32(txNumeri.Text);
            txNumeri.Text = "";
            operazione = '+';
        }

        {

        }

        private void btUguale_Click(object sender, EventArgs e)
        {
            int totale = 0;
            int num2 = Convert.ToInt32(txNumeri.Text);
            if (operazione == '+') totale = numero + num2;
            if (operazione == '-') totale = numero - num2;
            lbRisultato.Text = totale.ToString();
        }

        private void btMeno_Click(object sender, EventArgs e)
        {
            numero = Convert.ToInt32(txNumeri.Text);
            txNumeri.Text = "";
            operazione = '-';
        }
    }
}
