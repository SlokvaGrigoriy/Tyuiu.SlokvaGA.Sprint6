using Tyuiu.SlokvaGA.Sprint6.Task2.V14.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task2.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСПб-25-1 Слоква Григорий Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelCondition_SGA_Click(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        private void buttonDone_SGA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SGA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_SGA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartVisFunc_SGA.Titles.Add("График функции sin(x)");

                this.chartVisFunc_SGA.ChartAreas[0].AxisX.Title = ("Ось X");
                this.chartVisFunc_SGA.ChartAreas[0].AxisY.Title = ("Ось Y");
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewTable_SGA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartVisFunc_SGA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_SGA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SGA.BackColor = Color.Red;
        }

        private void buttonDone_SGA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SGA.BackColor = Color.Green;
        }

        private void buttonDone_SGA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SGA.BackColor = Color.Blue;
        }
    }
}
