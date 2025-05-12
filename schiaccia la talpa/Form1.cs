namespace schiaccia_la_talpa
{
    public partial class Form1 : Form
    {
        int conta = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            conta++;
            label1.Text = conta.ToString();
            if (conta% 2 == 0)
            {
                pictureBox1.Image = schiaccia_la_talpa.Properties.Resources.talpa;
            }
            else
            {
                pictureBox1.Image = schiaccia_la_talpa.Properties.Resources.talpaschiacciata;
            }
            if (conta == 10)
            {
                timer1.Stop();
                MessageBox.Show("Hai vinto!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
