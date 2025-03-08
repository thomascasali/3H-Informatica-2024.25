namespace verifica_07._03._2025
{
    public partial class Form1 : Form
    {
        int[] vettore;
        int dimensione;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btIstanzia_Click(object sender, EventArgs e)
        {
            dimensione = Convert.ToInt32(txDimensione.Text);
            if (dimensione < 5 || dimensione > 20)
            {
                txDimensione.Text = "";
                return;
            }
            vettore = new int[dimensione];
            txMin.Enabled = true;
            txMax.Enabled = true;
            btRiempi.Enabled = true;

        }

        private void btRiempi_Click(object sender, EventArgs e)
        {
            int min, max;
            min = Convert.ToInt32(txMin.Text);
            max = Convert.ToInt32(txMax.Text);
            if (min < 1 || min > max)
            {
                txMin.Text = "";
                txMax.Text = "";
            }

            Random rnd = new Random();
            string vetStampa = "";

            for (int i = 0; i < dimensione; i++)
            {
                vettore[i] = rnd.Next(min, max + 1);
                vetStampa += vettore[i] + ", ";
            }
            lbDisplay.Text = vetStampa;

            btMinimo.Enabled = true;
            btSup.Enabled = true;
            btCreaMatrice.Enabled = true;
        }

        private void btMinimo_Click(object sender, EventArgs e)
        {
            int min = vettore[0];
            for (int i = 1; i < vettore.Length; i++)
            {
                if (vettore[i] < min) min = vettore[i];
            }
            lbMinimo.Text = min.ToString();
        }

        private void btSup_Click(object sender, EventArgs e)
        {
            int somma = 0;
            for (int i = 1; i < vettore.Length; i++)
            {
                somma += vettore[i];
            }
            double media = (double)somma / vettore.Length;
            lbMedia.Text = media.ToString();

            int contatore = 0;
            for (int i = 0; i < vettore.Length; i++)
            {
                if (vettore[i] > media) contatore++;
            }
            lbSuperiori.Text = contatore.ToString();
        }

        private void btCreaMatrice_Click(object sender, EventArgs e)
        {
            int[,] matrice = new int[dimensione, dimensione];
            for (int i=0; i<dimensione; i++) 
                for (int j=0; j<dimensione; j++)
                {
                    matrice[i, j] = vettore[j] * (i + 1);
                }
            dtgMatrice.ColumnCount = dimensione;
            dtgMatrice.RowCount = dimensione + 1;
            for (int i = 0; i < dimensione; i++)
                for (int j = 0; j < dimensione; j++)
                {
                    dtgMatrice.Rows[i].Cells[j].Value = matrice[i, j]; 
                }

        }
    }
}
