namespace introduzione_alle_matrici_24._02._2025
{
    public partial class Form1 : Form
    {
        int[,] matrice = new int[5, 5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            for (int i =0; i<5;i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrice[i, j] = rnd.Next(100);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value= matrice[i, j];
                }
            }
        }
    }
}
