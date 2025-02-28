namespace matrici
{
    public partial class Form1 : Form
    {
        int[,] matrice = new int[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            for(int i=0; i<3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    matrice[i, j] = rnd.Next(1, 100);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value=matrice[i,j];
                }
            }

        }
    }
}
