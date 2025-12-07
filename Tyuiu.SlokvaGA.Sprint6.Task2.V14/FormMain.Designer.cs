namespace Tyuiu.SlokvaGA.Sprint6.Task2.V14
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition_SGA = new GroupBox();
            labelFunc_SGA = new Label();
            pictureBoxFormula_SGA = new PictureBox();
            labelCondition_SGA = new Label();
            groupBoxInput_SGA = new GroupBox();
            textBoxStart_SGA = new TextBox();
            textBoxStop_SGA = new TextBox();
            labelStart_SGA = new Label();
            labelStop_SGA = new Label();
            groupBoxOutput_SGA = new GroupBox();
            chartVisFunc_SGA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewTable_SGA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            labelResult_SGA = new Label();
            buttonInfo_SGA = new Button();
            buttonDone_SGA = new Button();
            bindingSource1 = new BindingSource(components);
            groupBoxCondition_SGA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SGA).BeginInit();
            groupBoxInput_SGA.SuspendLayout();
            groupBoxOutput_SGA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVisFunc_SGA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_SGA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_SGA
            // 
            groupBoxCondition_SGA.Controls.Add(labelFunc_SGA);
            groupBoxCondition_SGA.Controls.Add(pictureBoxFormula_SGA);
            groupBoxCondition_SGA.Controls.Add(labelCondition_SGA);
            groupBoxCondition_SGA.Location = new Point(12, 12);
            groupBoxCondition_SGA.Name = "groupBoxCondition_SGA";
            groupBoxCondition_SGA.Size = new Size(521, 329);
            groupBoxCondition_SGA.TabIndex = 0;
            groupBoxCondition_SGA.TabStop = false;
            groupBoxCondition_SGA.Text = "Условие";
            // 
            // labelFunc_SGA
            // 
            labelFunc_SGA.AutoSize = true;
            labelFunc_SGA.Location = new Point(20, 86);
            labelFunc_SGA.Name = "labelFunc_SGA";
            labelFunc_SGA.Size = new Size(58, 15);
            labelFunc_SGA.TabIndex = 4;
            labelFunc_SGA.Text = "Функция:";
            labelFunc_SGA.Click += label1_Click;
            // 
            // pictureBoxFormula_SGA
            // 
            pictureBoxFormula_SGA.Image = (Image)resources.GetObject("pictureBoxFormula_SGA.Image");
            pictureBoxFormula_SGA.Location = new Point(143, 156);
            pictureBoxFormula_SGA.Name = "pictureBoxFormula_SGA";
            pictureBoxFormula_SGA.Size = new Size(239, 43);
            pictureBoxFormula_SGA.TabIndex = 5;
            pictureBoxFormula_SGA.TabStop = false;
            // 
            // labelCondition_SGA
            // 
            labelCondition_SGA.AutoSize = true;
            labelCondition_SGA.Location = new Point(20, 19);
            labelCondition_SGA.Name = "labelCondition_SGA";
            labelCondition_SGA.Size = new Size(362, 30);
            labelCondition_SGA.TabIndex = 4;
            labelCondition_SGA.Text = "Протабулировать функцию F(x) на диапазоне [-5;5]. \nРезультат вывести в DataGridView и построить график функции. ";
            labelCondition_SGA.Click += labelCondition_SGA_Click;
            // 
            // groupBoxInput_SGA
            // 
            groupBoxInput_SGA.Controls.Add(textBoxStart_SGA);
            groupBoxInput_SGA.Controls.Add(textBoxStop_SGA);
            groupBoxInput_SGA.Controls.Add(labelStart_SGA);
            groupBoxInput_SGA.Controls.Add(labelStop_SGA);
            groupBoxInput_SGA.Location = new Point(12, 347);
            groupBoxInput_SGA.Name = "groupBoxInput_SGA";
            groupBoxInput_SGA.Size = new Size(259, 91);
            groupBoxInput_SGA.TabIndex = 1;
            groupBoxInput_SGA.TabStop = false;
            groupBoxInput_SGA.Text = "Ввод данных";
            // 
            // textBoxStart_SGA
            // 
            textBoxStart_SGA.Location = new Point(20, 46);
            textBoxStart_SGA.Name = "textBoxStart_SGA";
            textBoxStart_SGA.Size = new Size(100, 23);
            textBoxStart_SGA.TabIndex = 5;
            // 
            // textBoxStop_SGA
            // 
            textBoxStop_SGA.Location = new Point(131, 46);
            textBoxStop_SGA.Name = "textBoxStop_SGA";
            textBoxStop_SGA.Size = new Size(100, 23);
            textBoxStop_SGA.TabIndex = 6;
            // 
            // labelStart_SGA
            // 
            labelStart_SGA.AutoSize = true;
            labelStart_SGA.Location = new Point(34, 28);
            labelStart_SGA.Name = "labelStart_SGA";
            labelStart_SGA.Size = new Size(72, 15);
            labelStart_SGA.TabIndex = 5;
            labelStart_SGA.Text = "Старт шага:";
            // 
            // labelStop_SGA
            // 
            labelStop_SGA.AutoSize = true;
            labelStop_SGA.Location = new Point(144, 28);
            labelStop_SGA.Name = "labelStop_SGA";
            labelStop_SGA.Size = new Size(75, 15);
            labelStop_SGA.TabIndex = 6;
            labelStop_SGA.Text = "Конец шага:";
            // 
            // groupBoxOutput_SGA
            // 
            groupBoxOutput_SGA.Controls.Add(chartVisFunc_SGA);
            groupBoxOutput_SGA.Controls.Add(dataGridViewTable_SGA);
            groupBoxOutput_SGA.Controls.Add(labelResult_SGA);
            groupBoxOutput_SGA.Location = new Point(539, 12);
            groupBoxOutput_SGA.Name = "groupBoxOutput_SGA";
            groupBoxOutput_SGA.Size = new Size(488, 426);
            groupBoxOutput_SGA.TabIndex = 0;
            groupBoxOutput_SGA.TabStop = false;
            groupBoxOutput_SGA.Text = "Вывод данных";
            // 
            // chartVisFunc_SGA
            // 
            chartArea1.Name = "ChartArea1";
            chartVisFunc_SGA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartVisFunc_SGA.Legends.Add(legend1);
            chartVisFunc_SGA.Location = new Point(131, 37);
            chartVisFunc_SGA.Name = "chartVisFunc_SGA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartVisFunc_SGA.Series.Add(series1);
            chartVisFunc_SGA.Size = new Size(351, 382);
            chartVisFunc_SGA.TabIndex = 4;
            chartVisFunc_SGA.Text = "chart1";
            chartVisFunc_SGA.Click += chart1_Click;
            // 
            // dataGridViewTable_SGA
            // 
            dataGridViewTable_SGA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable_SGA.Columns.AddRange(new DataGridViewColumn[] { X, FX });
            dataGridViewTable_SGA.Location = new Point(22, 37);
            dataGridViewTable_SGA.Name = "dataGridViewTable_SGA";
            dataGridViewTable_SGA.RowHeadersVisible = false;
            dataGridViewTable_SGA.Size = new Size(103, 382);
            dataGridViewTable_SGA.TabIndex = 4;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // FX
            // 
            FX.HeaderText = "FX";
            FX.Name = "FX";
            FX.Width = 50;
            // 
            // labelResult_SGA
            // 
            labelResult_SGA.AutoSize = true;
            labelResult_SGA.Location = new Point(6, 19);
            labelResult_SGA.Name = "labelResult_SGA";
            labelResult_SGA.Size = new Size(63, 15);
            labelResult_SGA.TabIndex = 7;
            labelResult_SGA.Text = "Результат:";
            // 
            // buttonInfo_SGA
            // 
            buttonInfo_SGA.BackColor = Color.DodgerBlue;
            buttonInfo_SGA.Cursor = Cursors.Hand;
            buttonInfo_SGA.Location = new Point(277, 347);
            buttonInfo_SGA.Name = "buttonInfo_SGA";
            buttonInfo_SGA.Size = new Size(94, 91);
            buttonInfo_SGA.TabIndex = 2;
            buttonInfo_SGA.Text = "Справка";
            buttonInfo_SGA.UseVisualStyleBackColor = false;
            buttonInfo_SGA.Click += button1_Click;
            // 
            // buttonDone_SGA
            // 
            buttonDone_SGA.BackColor = Color.Green;
            buttonDone_SGA.Cursor = Cursors.Hand;
            buttonDone_SGA.Location = new Point(377, 347);
            buttonDone_SGA.Name = "buttonDone_SGA";
            buttonDone_SGA.Size = new Size(156, 91);
            buttonDone_SGA.TabIndex = 3;
            buttonDone_SGA.Text = "Выполнить";
            buttonDone_SGA.UseVisualStyleBackColor = false;
            buttonDone_SGA.Click += buttonDone_SGA_Click;
            buttonDone_SGA.MouseDown += buttonDone_SGA_MouseDown;
            buttonDone_SGA.MouseEnter += buttonDone_SGA_MouseEnter;
            buttonDone_SGA.MouseLeave += buttonDone_SGA_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 443);
            Controls.Add(buttonDone_SGA);
            Controls.Add(buttonInfo_SGA);
            Controls.Add(groupBoxOutput_SGA);
            Controls.Add(groupBoxInput_SGA);
            Controls.Add(groupBoxCondition_SGA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 14 | Слоква Г. А.";
            groupBoxCondition_SGA.ResumeLayout(false);
            groupBoxCondition_SGA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SGA).EndInit();
            groupBoxInput_SGA.ResumeLayout(false);
            groupBoxInput_SGA.PerformLayout();
            groupBoxOutput_SGA.ResumeLayout(false);
            groupBoxOutput_SGA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartVisFunc_SGA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_SGA).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_SGA;
        private GroupBox groupBoxInput_SGA;
        private GroupBox groupBoxOutput_SGA;
        private Button buttonInfo_SGA;
        private Button buttonDone_SGA;
        private Label labelCondition_SGA;
        private Label labelStart_SGA;
        private Label labelStop_SGA;
        private Label labelResult_SGA;
        private TextBox textBoxStart_SGA;
        private TextBox textBoxStop_SGA;
        private Label labelFunc_SGA;
        private PictureBox pictureBoxFormula_SGA;
        private DataGridView dataGridViewTable_SGA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
        private BindingSource bindingSource1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVisFunc_SGA;
    }
}
