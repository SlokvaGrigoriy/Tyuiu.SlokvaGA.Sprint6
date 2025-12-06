using System.Windows.Forms;
using Tyuiu.SlokvaGA.Sprint6.Task3.V17.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task3.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelCondition_SGA_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxCondition_SGA_Enter(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        int[,] mas = new int[5, 5] { { 22, 32, -16, 24, 27 },
                                          { 3, -20, 24, -20, 25 },
                                          { 21, 17, -8, -19, 17 },
                                          { 8, 22, 28, 27, 19 },
                                          { 11, 20, 12, 27, 29 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            dataGridViewMas_SGA.ColumnCount = columns;
            dataGridViewMas_SGA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMas_SGA.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMas_SGA.Rows[i].Cells[j].Value = Convert.ToString(mas[i, j]);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСПб-25-1 Слоква Григорий Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_SGA_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mas);

            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;

            dataGridViewMas_SGA.RowCount = rows;
            dataGridViewMas_SGA.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMas_SGA.Rows[i].Cells[j].Value = res[i, j];
                }
            }
        }

        private void dataGridViewMas_SGA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
