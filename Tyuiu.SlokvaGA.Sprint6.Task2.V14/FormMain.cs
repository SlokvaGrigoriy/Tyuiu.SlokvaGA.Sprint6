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

                this.chartFunction.Titles.Add("График функции sin(x)");

                this.chartFunction.CharAreas[0].AxisX.Titles.Add("Ось X");
                this.chartFunction.CharAreas[0].AxisY.Titles.Add("Ось Y");
                for (int i = 0; i <= len - 1; i++) ;
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);

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
    }
}
