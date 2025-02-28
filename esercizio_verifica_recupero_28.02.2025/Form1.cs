namespace esercizio_verifica_recupero_28._02._2025
{
    public partial class Form1 : Form
    {
        //dichiarazione vettore
        int[] vettore;
        int dim;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btIstanzia_Click(object sender, EventArgs e)
        {
            dim = Convert.ToInt16(txDimensione.Text);
            if (dim >= 10 && dim <= 20)
            {
                //se la dimensione inserita è compresa tra 10 e 20
                //allora istanzio il vettore
                vettore = new int[dim];
            }
        }

        private void btRiempi_Click(object sender, EventArgs e)
        {
            RiempiVettore();
            StampaVettore();
        }

        private void btMax_Click(object sender, EventArgs e)
        {
            lbMax.Text = MaxVettore().ToString();
        }

        private void btMedia_Click(object sender, EventArgs e)
        {
            lbMedia.Text = MediaVettore().ToString();
        }

        private void btInverti_Click(object sender, EventArgs e)
        {
            InvertiVettore();
            StampaVettore();
        }

        #region metodi personalizzati
        void RiempiVettore()
        {
            Random rnd = new Random();
            for (int i = 0; i < dim; i++)
            {
                vettore[i] = rnd.Next(1, 100);
            }
        }

        void StampaVettore()
        {
            string txt = "";
            for (int i = 0; i < dim; i++)
            {
                txt = txt + vettore[i] + " - ";
            }
            lbDisplay.Text = txt;
        }

        int MaxVettore()
        {
            int max = vettore[0];
            for (int i = 1; i < dim; i++) //parto da 1 perché 0 l'ho messo come max iniziale
            {
                if (vettore[i] > max) max = vettore[i];
            }
            return max;
        }
        double MediaVettore()
        {
            int somma = 0;
            for (int i = 0; i < dim; i++)
            {
                somma += vettore[i];
            }
            return (double)somma / (double)dim;
        }

        void InvertiVettore()
        {
            int tmp;
            for (int i = 0; i < dim / 2; i++)
            {
                tmp = vettore[i];
                vettore[i] = vettore[dim - 1 - i];
                vettore[dim - 1 - i] = tmp;
            }
        }
        #endregion

    }
}
