using Tyuiu.SlokvaGA.Sprint6.Task6.V4.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task6.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SGA.ShowDialog();
            openFilePath = openFileDialogTask_SGA.FileName;
            string[] lines = File.ReadAllLines(openFilePath);
            textBoxInput_SGA.Text = string.Join(Environment.NewLine, lines);
            labelInput_SGA.Text = labelInput_SGA.Text + " " + openFileDialogTask_SGA.FileName;
            buttonOpenFile_SGA.Enabled = true;
        }

        private void labelCondition_SGA_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxOutput_SGA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_SGA_Click(object sender, EventArgs e)
        {
            FormAbout_SGA formabout = new FormAbout_SGA();
            formabout.ShowDialog();
        }
    }
}
