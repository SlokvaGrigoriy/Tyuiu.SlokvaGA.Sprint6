using Tyuiu.SlokvaGA.Sprint6.Task5.V29.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task5.V29
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataGridViewResult_SGA = new DataGridView();
            groupBoxCondition_SGA = new GroupBox();
            labelCondition_SGA = new Label();
            chartDiag_SGA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone_SGA = new Button();
            buttonOpenFile_SGA = new Button();
            buttonHelp_SGA = new Button();
            labelOutput_SGA = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SGA).BeginInit();
            groupBoxCondition_SGA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_SGA).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResult_SGA
            // 
            dataGridViewResult_SGA.AllowUserToAddRows = false;
            dataGridViewResult_SGA.AllowUserToDeleteRows = false;
            dataGridViewResult_SGA.AllowUserToResizeColumns = false;
            dataGridViewResult_SGA.AllowUserToResizeRows = false;
            dataGridViewResult_SGA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewResult_SGA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_SGA.ColumnHeadersVisible = false;
            dataGridViewResult_SGA.Location = new Point(2, 118);
            dataGridViewResult_SGA.MinimumSize = new Size(164, 327);
            dataGridViewResult_SGA.Name = "dataGridViewResult_SGA";
            dataGridViewResult_SGA.ReadOnly = true;
            dataGridViewResult_SGA.RowHeadersVisible = false;
            dataGridViewResult_SGA.ScrollBars = ScrollBars.Vertical;
            dataGridViewResult_SGA.Size = new Size(164, 327);
            dataGridViewResult_SGA.TabIndex = 0;
            dataGridViewResult_SGA.CellContentClick += dataGridViewResult_SGA_CellContentClick;
            // 
            // groupBoxCondition_SGA
            // 
            groupBoxCondition_SGA.Controls.Add(labelCondition_SGA);
            groupBoxCondition_SGA.Location = new Point(2, 4);
            groupBoxCondition_SGA.Name = "groupBoxCondition_SGA";
            groupBoxCondition_SGA.Size = new Size(451, 96);
            groupBoxCondition_SGA.TabIndex = 1;
            groupBoxCondition_SGA.TabStop = false;
            groupBoxCondition_SGA.Text = "Условие";
            // 
            // labelCondition_SGA
            // 
            labelCondition_SGA.AutoSize = true;
            labelCondition_SGA.Location = new Point(10, 19);
            labelCondition_SGA.Name = "labelCondition_SGA";
            labelCondition_SGA.Size = new Size(380, 60);
            labelCondition_SGA.TabIndex = 2;
            labelCondition_SGA.Text = "Прочитать данные из файла InPutFileTask5V29.txt. \r\nВывести все числа, больше или равные 10. \r\nПостроить диаграмму по этим значениям. \r\nУ вещественных значений округлить до трёх знаков после запятой.";
            labelCondition_SGA.Click += labelCondition_SGA_Click;
            // 
            // chartDiag_SGA
            // 
            chartDiag_SGA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartDiag_SGA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag_SGA.Legends.Add(legend1);
            chartDiag_SGA.Location = new Point(172, 106);
            chartDiag_SGA.Name = "chartDiag_SGA";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_SGA.Series.Add(series1);
            chartDiag_SGA.Size = new Size(627, 339);
            chartDiag_SGA.TabIndex = 2;
            chartDiag_SGA.Text = "chart1";
            // 
            // buttonDone_SGA
            // 
            buttonDone_SGA.BackColor = Color.Green;
            buttonDone_SGA.Cursor = Cursors.Hand;
            buttonDone_SGA.Location = new Point(471, 22);
            buttonDone_SGA.Name = "buttonDone_SGA";
            buttonDone_SGA.Size = new Size(91, 66);
            buttonDone_SGA.TabIndex = 3;
            buttonDone_SGA.Text = "Выполнить";
            buttonDone_SGA.UseVisualStyleBackColor = false;
            buttonDone_SGA.Click += buttonDone_SGA_Click;
            // 
            // buttonOpenFile_SGA
            // 
            buttonOpenFile_SGA.BackColor = SystemColors.HotTrack;
            buttonOpenFile_SGA.Cursor = Cursors.Hand;
            buttonOpenFile_SGA.Location = new Point(580, 22);
            buttonOpenFile_SGA.Name = "buttonOpenFile_SGA";
            buttonOpenFile_SGA.Size = new Size(91, 65);
            buttonOpenFile_SGA.TabIndex = 4;
            buttonOpenFile_SGA.Text = "Открыть файл";
            buttonOpenFile_SGA.UseVisualStyleBackColor = false;
            buttonOpenFile_SGA.Click += buttonOpenFile_SGA_Click;
            // 
            // buttonHelp_SGA
            // 
            buttonHelp_SGA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SGA.BackColor = Color.DodgerBlue;
            buttonHelp_SGA.Cursor = Cursors.Hand;
            buttonHelp_SGA.Location = new Point(687, 22);
            buttonHelp_SGA.Name = "buttonHelp_SGA";
            buttonHelp_SGA.Size = new Size(91, 64);
            buttonHelp_SGA.TabIndex = 5;
            buttonHelp_SGA.Text = "Справка";
            buttonHelp_SGA.UseVisualStyleBackColor = false;
            buttonHelp_SGA.Click += buttonHelp_SGA_Click;
            // 
            // labelOutput_SGA
            // 
            labelOutput_SGA.AutoSize = true;
            labelOutput_SGA.Location = new Point(8, 100);
            labelOutput_SGA.Name = "labelOutput_SGA";
            labelOutput_SGA.Size = new Size(89, 15);
            labelOutput_SGA.TabIndex = 6;
            labelOutput_SGA.Text = "Вывод данных:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 446);
            Controls.Add(labelOutput_SGA);
            Controls.Add(buttonHelp_SGA);
            Controls.Add(buttonOpenFile_SGA);
            Controls.Add(buttonDone_SGA);
            Controls.Add(chartDiag_SGA);
            Controls.Add(groupBoxCondition_SGA);
            Controls.Add(dataGridViewResult_SGA);
            MinimumSize = new Size(816, 485);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 29 | Слоква Г. А.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SGA).EndInit();
            groupBoxCondition_SGA.ResumeLayout(false);
            groupBoxCondition_SGA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_SGA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewResult_SGA;
        private GroupBox groupBoxCondition_SGA;
        private Label labelCondition_SGA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SGA;
        private Button buttonDone_SGA;
        private Button buttonOpenFile_SGA;
        private Button buttonHelp_SGA;
        private Label labelOutput_SGA;
    }
}
