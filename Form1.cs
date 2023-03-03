namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataCreation(10);
        }

        private void DataCreation(int n)
        {
            //Definicion de computadoras
            List<Computadora> computadoras = new List<Computadora>();

            //Creación de los alumnos en tracking
            for (int i = 1; i <= n; i++)
            {
                computadoras.Add(
                    new Computadora(
                        "Asus TUF " + i,
                        2017 + i,
                        "LPT2023A" + i,
                        "512 GB",
                        "Intel Core i" + i * 3
                    ));
            }

            dataGridView1.DataSource = computadoras;
        }
    }
}