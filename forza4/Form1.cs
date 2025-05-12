namespace forza4
{
    public partial class Form1 : Form
    {
        int righe = 7;
        int colonne = 6;
        int[,] forza4 = new int[6, 7];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < colonne - 1; i++)
            {
                for (int j = 0; j < righe - 1; j++)
                {
                    Label lb = new Label(); //creo la label
                    lb.Text = i.ToString() + "," + j.ToString(); //imposto il testo da visualizzare
                    lb.TextAlign = ContentAlignment.MiddleCenter; //imposto l'allineamento del testo
                    lb.Name = "lb" + i.ToString(); //assegno un nome
                    lb.Tag = i + "," + j;
                    lb.Top = 100 + i * 100; //definisco la distanza dall'alto della Form
                    lb.Left = 40 + j * 100; //imposto la distanza dalla sinistra della Form
                    lb.AutoSize = false; //gli dico che si deve autodimensionare
                    lb.Width = 100;
                    lb.Height = 100;
                    lb.BorderStyle = BorderStyle.FixedSingle; //imposto lo stile del bordo
                    lb.Click += lb_Click;
                    this.Controls.Add(lb); //aggiungo la Label alla Form
                }
            }
        }

        private void lb_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((Label)sender).Tag.ToString());
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i].Tag.ToString()== ((Label)sender).Tag.ToString())
                {
                    this.Controls[i].BackColor=Color.Red;
                }
            }
        }
    }
}
