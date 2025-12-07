using Tyuiu.SlokvaGA.Sprint6.Task5.V29.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task5.V29
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
        DataService ds = new DataService();
        string path = @"C:\Files\InPutDataFileTask5V29.txt";
        private void buttonDone_SGA_Click(object sender, EventArgs e)
        {
            dataGridViewResult_SGA.ColumnCount = 2;
            dataGridViewResult_SGA.Columns[0].Width = 40;
            dataGridViewResult_SGA.Columns[1].Width = 125;

            this.chartDiag_SGA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_SGA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_SGA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_SGA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_SGA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_SGA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_SGA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСПб-25-1 Слоква Григорий Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewResult_SGA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
