using System.Windows.Forms;
using Tyuiu.SlokvaGA.Sprint6.Task7.V11.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task7.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonDone_SGA.Enabled = false;
            buttonSaveFile_SGA.Enabled = false;

            dataGridViewInMatrix_SGA.ColumnCount = 50;
            dataGridViewInMatrix_SGA.Rows.Add(50);
            for (int i = 0; i < 50; i++)
            {
                dataGridViewInMatrix_SGA.Columns[i].Width = 25;
            }

            dataGridViewOutMatrix_SGA.ColumnCount = 50;
            dataGridViewOutMatrix_SGA.Rows.Add(50);
            for (int i = 0; i < 50; i++)
            {
                dataGridViewOutMatrix_SGA.Columns[i].Width = 25;
            }
            openFileDialogTask_SGA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SGA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SGA.FileName = "OutPutFileTask7V11.txt";
            saveFileDialogMatrix_SGA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SGA.ShowDialog();

            string path = saveFileDialogMatrix_SGA.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_SGA.RowCount;
            int columns = dataGridViewOutMatrix_SGA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix_SGA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_SGA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_SGA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_SGA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SGA.ShowDialog();
            openFilePath = openFileDialogTask_SGA.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);

            rows = arrayValues.GetLength(0);
            columns = arrayValues.GetLength(1);

            dataGridViewInMatrix_SGA.ColumnCount = columns;
            dataGridViewInMatrix_SGA.RowCount = rows;
            dataGridViewOutMatrix_SGA.ColumnCount = columns;
            dataGridViewOutMatrix_SGA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_SGA.Columns[i].Width = 25;
                dataGridViewOutMatrix_SGA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix_SGA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonDone_SGA.Enabled = true;
        }

        private void buttonDone_SGA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix_SGA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_SGA.Enabled = true;
        }

        private void dataGridViewInMatrix_SGA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewOutMatrix_SGA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
