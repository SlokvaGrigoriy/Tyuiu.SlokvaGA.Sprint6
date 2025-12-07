using Tyuiu.SlokvaGA.Sprint6.Task4.V18.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task4.V18
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            textBoxResult_SGA = new TextBox();
            groupBoxCondition_SGA = new GroupBox();
            labelCondition_SGA = new Label();
            groupBoxInput_SGA = new GroupBox();
            labelStart_SGA = new Label();
            labelStop_SGA = new Label();
            textBoxStart_SGA = new TextBox();
            textBoxStop_SGA = new TextBox();
            labelOutput_SGA = new Label();
            chartFunc_SGA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone_SGA = new Button();
            buttonSave_SGA = new Button();
            buttonHelp_SGA = new Button();
            groupBoxCondition_SGA.SuspendLayout();
            groupBoxInput_SGA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc_SGA).BeginInit();
            SuspendLayout();
            // 
            // textBoxResult_SGA
            // 
            textBoxResult_SGA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxResult_SGA.Location = new Point(5, 104);
            textBoxResult_SGA.Multiline = true;
            textBoxResult_SGA.Name = "textBoxResult_SGA";
            textBoxResult_SGA.ReadOnly = true;
            textBoxResult_SGA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SGA.Size = new Size(204, 346);
            textBoxResult_SGA.TabIndex = 0;
            textBoxResult_SGA.TextChanged += textBoxResult_SGA_TextChanged;
            // 
            // groupBoxCondition_SGA
            // 
            groupBoxCondition_SGA.Controls.Add(labelCondition_SGA);
            groupBoxCondition_SGA.Location = new Point(12, 0);
            groupBoxCondition_SGA.Name = "groupBoxCondition_SGA";
            groupBoxCondition_SGA.Size = new Size(325, 84);
            groupBoxCondition_SGA.TabIndex = 1;
            groupBoxCondition_SGA.TabStop = false;
            groupBoxCondition_SGA.Text = "Условие";
            // 
            // labelCondition_SGA
            // 
            labelCondition_SGA.AutoSize = true;
            labelCondition_SGA.Location = new Point(6, 19);
            labelCondition_SGA.Name = "labelCondition_SGA";
            labelCondition_SGA.Size = new Size(291, 30);
            labelCondition_SGA.TabIndex = 2;
            labelCondition_SGA.Text = "Протабулировать функцию f(x) на диапазоне [-5;5].\nОкруглить до двух знаков после запятой. ";
            labelCondition_SGA.Click += labelCondition_SGA_Click;
            // 
            // groupBoxInput_SGA
            // 
            groupBoxInput_SGA.Controls.Add(labelStart_SGA);
            groupBoxInput_SGA.Controls.Add(labelStop_SGA);
            groupBoxInput_SGA.Controls.Add(textBoxStart_SGA);
            groupBoxInput_SGA.Controls.Add(textBoxStop_SGA);
            groupBoxInput_SGA.Location = new Point(343, 0);
            groupBoxInput_SGA.Name = "groupBoxInput_SGA";
            groupBoxInput_SGA.Size = new Size(289, 84);
            groupBoxInput_SGA.TabIndex = 0;
            groupBoxInput_SGA.TabStop = false;
            groupBoxInput_SGA.Text = "Ввод данных";
            // 
            // labelStart_SGA
            // 
            labelStart_SGA.AutoSize = true;
            labelStart_SGA.Location = new Point(38, 28);
            labelStart_SGA.Name = "labelStart_SGA";
            labelStart_SGA.Size = new Size(72, 15);
            labelStart_SGA.TabIndex = 7;
            labelStart_SGA.Text = "Старт шага:";
            // 
            // labelStop_SGA
            // 
            labelStop_SGA.AutoSize = true;
            labelStop_SGA.Location = new Point(173, 28);
            labelStop_SGA.Name = "labelStop_SGA";
            labelStop_SGA.Size = new Size(75, 15);
            labelStop_SGA.TabIndex = 8;
            labelStop_SGA.Text = "Конец шага:";
            // 
            // textBoxStart_SGA
            // 
            textBoxStart_SGA.Location = new Point(25, 46);
            textBoxStart_SGA.Name = "textBoxStart_SGA";
            textBoxStart_SGA.Size = new Size(100, 23);
            textBoxStart_SGA.TabIndex = 2;
            // 
            // textBoxStop_SGA
            // 
            textBoxStop_SGA.Location = new Point(161, 46);
            textBoxStop_SGA.Name = "textBoxStop_SGA";
            textBoxStop_SGA.Size = new Size(100, 23);
            textBoxStop_SGA.TabIndex = 3;
            // 
            // labelOutput_SGA
            // 
            labelOutput_SGA.AutoSize = true;
            labelOutput_SGA.Location = new Point(18, 86);
            labelOutput_SGA.Name = "labelOutput_SGA";
            labelOutput_SGA.Size = new Size(86, 15);
            labelOutput_SGA.TabIndex = 2;
            labelOutput_SGA.Text = "Вывод данных";
            // 
            // chartFunc_SGA
            // 
            chartFunc_SGA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartFunc_SGA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunc_SGA.Legends.Add(legend1);
            chartFunc_SGA.Location = new Point(215, 86);
            chartFunc_SGA.Name = "chartFunc_SGA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunc_SGA.Series.Add(series1);
            chartFunc_SGA.Size = new Size(709, 364);
            chartFunc_SGA.TabIndex = 3;
            chartFunc_SGA.Text = "chart1";
            title1.Name = "Titlefx";
            title1.Text = "График функции f(x)";
            chartFunc_SGA.Titles.Add(title1);
            // 
            // buttonDone_SGA
            // 
            buttonDone_SGA.BackColor = Color.Green;
            buttonDone_SGA.Cursor = Cursors.Hand;
            buttonDone_SGA.Location = new Point(638, 12);
            buttonDone_SGA.Name = "buttonDone_SGA";
            buttonDone_SGA.Size = new Size(97, 68);
            buttonDone_SGA.TabIndex = 4;
            buttonDone_SGA.Text = "Выполнить";
            buttonDone_SGA.UseVisualStyleBackColor = false;
            buttonDone_SGA.Click += buttonDone_SGA_Click;
            // 
            // buttonSave_SGA
            // 
            buttonSave_SGA.BackColor = Color.RoyalBlue;
            buttonSave_SGA.Cursor = Cursors.Hand;
            buttonSave_SGA.Location = new Point(741, 12);
            buttonSave_SGA.Name = "buttonSave_SGA";
            buttonSave_SGA.Size = new Size(89, 68);
            buttonSave_SGA.TabIndex = 5;
            buttonSave_SGA.Text = "Сохранить";
            buttonSave_SGA.UseVisualStyleBackColor = false;
            buttonSave_SGA.Click += buttonSave_SGA_Click;
            // 
            // buttonHelp_SGA
            // 
            buttonHelp_SGA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SGA.BackColor = Color.CornflowerBlue;
            buttonHelp_SGA.Cursor = Cursors.Hand;
            buttonHelp_SGA.Location = new Point(836, 12);
            buttonHelp_SGA.Name = "buttonHelp_SGA";
            buttonHelp_SGA.Size = new Size(75, 68);
            buttonHelp_SGA.TabIndex = 6;
            buttonHelp_SGA.Text = "Справка";
            buttonHelp_SGA.UseVisualStyleBackColor = false;
            buttonHelp_SGA.Click += buttonHelp_SGA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 450);
            Controls.Add(buttonHelp_SGA);
            Controls.Add(buttonSave_SGA);
            Controls.Add(buttonDone_SGA);
            Controls.Add(chartFunc_SGA);
            Controls.Add(labelOutput_SGA);
            Controls.Add(groupBoxInput_SGA);
            Controls.Add(groupBoxCondition_SGA);
            Controls.Add(textBoxResult_SGA);
            MinimumSize = new Size(939, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 18 | Слоква Г. А.";
            groupBoxCondition_SGA.ResumeLayout(false);
            groupBoxCondition_SGA.PerformLayout();
            groupBoxInput_SGA.ResumeLayout(false);
            groupBoxInput_SGA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc_SGA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult_SGA;
        private GroupBox groupBoxCondition_SGA;
        private Label labelCondition_SGA;
        private GroupBox groupBoxInput_SGA;
        private TextBox textBoxStart_SGA;
        private TextBox textBoxStop_SGA;
        private Label labelOutput_SGA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_SGA;
        private Label labelStart_SGA;
        private Label labelStop_SGA;
        private Button buttonDone_SGA;
        private Button buttonSave_SGA;
        private Button buttonHelp_SGA;
    }
}
