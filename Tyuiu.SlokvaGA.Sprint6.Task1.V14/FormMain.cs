using Tyuiu.SlokvaGA.Sprint6.Task1.V14.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task1.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelCondition_SGA_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСПб-25-1 Слоква Григорий Александрович");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBox1.Text);
                int stopStep = Convert.ToInt32(textBox2.Text);

                string strline;

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];

                textBoxResult_SGA.Text = "";
                textBoxResult_SGA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_SGA.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_SGA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strline = String.Format("|{0,5:d)    |          | {1, 5:f2}   | ", startStep, valueArray[i]);
                    textBoxResult_SGA.AppendText(strline + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_SGA.AppendText("+----------+----------+");
            }
            catch
            {
                MessageBox.Show("Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
