namespace manipolazioneFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\casal\OneDrive\Desktop\test.txt"))
            {
                MessageBox.Show("Il file esiste.");
            }
            else
            {
                MessageBox.Show("Il file non esiste.");
            }
        }

        private void btCrea_Click(object sender, EventArgs e)
        {
            File.Create(@"C:\Users\casal\OneDrive\Desktop\nuovofile.txt");
        }

        private void btCopia_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\casal\OneDrive\Desktop\testCOPIA.txt"))
            {
                MessageBox.Show("Il file esiste già.");
                return;
            }
            else
            {
                File.Copy(@"C:\Users\casal\OneDrive\Desktop\test.txt", @"C:\Users\casal\OneDrive\Desktop\testCOPIA.txt");

            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\casal\OneDrive\Desktop\testCOPIA.txt");
        }

        private void btLeggi_Click(object sender, EventArgs e)
        {
            string contenuto = File.ReadAllText(@"C:\Users\casal\OneDrive\Desktop\test.txt");
            MessageBox.Show(contenuto);
        }

        private void btReadAllLines_Click(object sender, EventArgs e)
        {
            string[] righe = File.ReadAllLines(@"C:\Users\casal\OneDrive\Desktop\test.txt");
            MessageBox.Show(righe[2]);
        }

        private void btStreamReader_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\casal\OneDrive\Desktop\test.txt"))
            {
                string riga;
                int righe_da_leggere = int.Parse(txRighe.Text); // Numero di righe da leggere
                int contatore = 0; // Contatore per le righe lette
                textBox1.Clear(); // Pulisce il TextBox prima di scrivere
                while ((riga = reader.ReadLine()) != null)
                {
                    if (righe_da_leggere == contatore)
                    {
                        break; // Esci dal ciclo se hai letto il numero di righe desiderato
                    }
                    textBox1.AppendText(riga + Environment.NewLine);
                    contatore++;

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
