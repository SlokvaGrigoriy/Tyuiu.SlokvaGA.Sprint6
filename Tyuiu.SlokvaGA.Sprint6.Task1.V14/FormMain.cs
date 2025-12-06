using Tyuiu.SlokvaGA.Sprint6.Task1.V14.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task1.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

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
            MessageBox.Show("Таск 1 выполнил студент группы ИСПб-25-1 Слоква Григорий Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        DataService ds = new DataService();

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SGA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_SGA.Text);

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);
                int len = valueArray.Length;

                textBoxResult_SGA.Text = "";
                textBoxResult_SGA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_SGA.AppendText("|    x     |   f(x)   |" + Environment.NewLine);
                textBoxResult_SGA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    int currentX = startStep + i;
                    string strline = String.Format("|{0,5:d}     |  {1,6:f2}  | ", currentX, valueArray[i]);
                    textBoxResult_SGA.AppendText(strline + Environment.NewLine);
                }
                textBoxResult_SGA.AppendText("+----------+----------+");
            }
            catch
            {
                MessageBox.Show("Введите корректные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxResult_SGA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}