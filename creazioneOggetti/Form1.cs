namespace creazioneOggetti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                Label lb = new Label(); //creo la label
                lb.Text = i.ToString(); //imposto il testo da visualizzare
                lb.Name = "lb" + i.ToString(); //assegno un nome
                lb.Top = 100; //definisco la distanza dall'alto della Form
                lb.Left = 40 + i * 100; //imposto la distanza dalla sinistra della Form
                lb.AutoSize = true; //gli dico che si deve autodimensionare
                this.Controls.Add(lb); //aggiungo la Label alla Form
            }
            for (int i = 0; i < 4; i++)
            {
                Button bt = new Button();
                bt.Text = i.ToString(); //imposto il testo da visualizzare
                bt.Name = bt + i.ToString(); //assegno un nome
                bt.Top = 300; //definisco la distanza dall'alto della Form
                bt.Left = 40 + i * 100; //imposto la distanza dalla sinistra della Form
                bt.AutoSize = true; //gli dico che si deve autodimensionare
                this.Controls.Add(bt); //aggiungo la Label alla Form
            }
        }

        private void btPulisci_Click(object sender, EventArgs e)
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i].Name.Contains("lb"))
                {
                    this.Controls.RemoveAt(i);
                }
            }
        }
        
    }
}
