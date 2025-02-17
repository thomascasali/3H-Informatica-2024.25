namespace ripasso_17._02._2025
{
    public partial class Form1 : Form
    {
        int conta = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ho cliccato sulla label il contatote è " + conta);
            conta++;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("ho fatto doppio click sulla form e il contatote è diventato " + conta);
            conta++;
        }

        private void pluto(object sender, EventArgs e)
        {
        }

        private void esco(object sender, EventArgs e)
        {
            MessageBox.Show("SEI USCITO");

        }

        private void pippo(object sender, EventArgs e)
        {
            MessageBox.Show("ho richiamato il motodo pippo e adesso conta vale " + conta);
            conta++;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
        }
    }
}
