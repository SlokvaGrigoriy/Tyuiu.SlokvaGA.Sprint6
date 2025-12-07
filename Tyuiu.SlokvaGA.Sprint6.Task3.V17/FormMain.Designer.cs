using Tyuiu.SlokvaGA.Sprint6.Task3.V17.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task3.V17
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
            groupBoxCondition_SGA = new GroupBox();
            textBoxCondition_SGA = new TextBox();
            dataGridViewMas_SGA = new DataGridView();
            groupBoxOutput_SGA = new GroupBox();
            labelResult_SGA = new Label();
            buttonDone_SGA = new Button();
            buttonHelp_SGA = new Button();
            groupBoxCondition_SGA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMas_SGA).BeginInit();
            groupBoxOutput_SGA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_SGA
            // 
            groupBoxCondition_SGA.Controls.Add(textBoxCondition_SGA);
            groupBoxCondition_SGA.Location = new Point(12, 12);
            groupBoxCondition_SGA.Name = "groupBoxCondition_SGA";
            groupBoxCondition_SGA.Size = new Size(480, 426);
            groupBoxCondition_SGA.TabIndex = 0;
            groupBoxCondition_SGA.TabStop = false;
            groupBoxCondition_SGA.Text = "Условие";
            groupBoxCondition_SGA.Enter += groupBoxCondition_SGA_Enter;
            // 
            // textBoxCondition_SGA
            // 
            textBoxCondition_SGA.Location = new Point(20, 28);
            textBoxCondition_SGA.Multiline = true;
            textBoxCondition_SGA.Name = "textBoxCondition_SGA";
            textBoxCondition_SGA.ReadOnly = true;
            textBoxCondition_SGA.Size = new Size(440, 380);
            textBoxCondition_SGA.TabIndex = 2;
            textBoxCondition_SGA.Text = "Дан массив 5 на 5 элементов.\r\n22  32 -16  24  27\r\n 3  -20  24 -20  25\r\n21  17  -8 -19  17\r\n 8   22  28  27  19\r\n11  20  12  27  29\r\nВыполнить сортировку по возрастанию в четвертом столбце.";
            // 
            // dataGridViewMas_SGA
            // 
            dataGridViewMas_SGA.AllowUserToResizeColumns = false;
            dataGridViewMas_SGA.AllowUserToResizeRows = false;
            dataGridViewMas_SGA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMas_SGA.ColumnHeadersVisible = false;
            dataGridViewMas_SGA.Location = new Point(19, 46);
            dataGridViewMas_SGA.Name = "dataGridViewMas_SGA";
            dataGridViewMas_SGA.ReadOnly = true;
            dataGridViewMas_SGA.RowHeadersVisible = false;
            dataGridViewMas_SGA.Size = new Size(253, 128);
            dataGridViewMas_SGA.TabIndex = 1;
            dataGridViewMas_SGA.CellContentClick += dataGridViewMas_SGA_CellContentClick;
            // 
            // groupBoxOutput_SGA
            // 
            groupBoxOutput_SGA.Controls.Add(labelResult_SGA);
            groupBoxOutput_SGA.Controls.Add(dataGridViewMas_SGA);
            groupBoxOutput_SGA.Location = new Point(498, 12);
            groupBoxOutput_SGA.Name = "groupBoxOutput_SGA";
            groupBoxOutput_SGA.Size = new Size(290, 199);
            groupBoxOutput_SGA.TabIndex = 1;
            groupBoxOutput_SGA.TabStop = false;
            groupBoxOutput_SGA.Text = "Вывод данных";
            // 
            // labelResult_SGA
            // 
            labelResult_SGA.AutoSize = true;
            labelResult_SGA.Location = new Point(6, 19);
            labelResult_SGA.Name = "labelResult_SGA";
            labelResult_SGA.Size = new Size(63, 15);
            labelResult_SGA.TabIndex = 0;
            labelResult_SGA.Text = "Результат:";
            labelResult_SGA.Click += label1_Click;
            // 
            // buttonDone_SGA
            // 
            buttonDone_SGA.Cursor = Cursors.Hand;
            buttonDone_SGA.Location = new Point(579, 381);
            buttonDone_SGA.Name = "buttonDone_SGA";
            buttonDone_SGA.Size = new Size(209, 57);
            buttonDone_SGA.TabIndex = 2;
            buttonDone_SGA.Text = "Выполнить";
            buttonDone_SGA.UseVisualStyleBackColor = true;
            buttonDone_SGA.Click += buttonDone_SGA_Click;
            // 
            // buttonHelp_SGA
            // 
            buttonHelp_SGA.Cursor = Cursors.Hand;
            buttonHelp_SGA.Location = new Point(498, 381);
            buttonHelp_SGA.Name = "buttonHelp_SGA";
            buttonHelp_SGA.Size = new Size(75, 57);
            buttonHelp_SGA.TabIndex = 3;
            buttonHelp_SGA.Text = "?";
            buttonHelp_SGA.UseVisualStyleBackColor = true;
            buttonHelp_SGA.Click += button2_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_SGA);
            Controls.Add(buttonDone_SGA);
            Controls.Add(groupBoxOutput_SGA);
            Controls.Add(groupBoxCondition_SGA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 17 | Слоква Г. А.";
            Load += FormMain_Load;
            groupBoxCondition_SGA.ResumeLayout(false);
            groupBoxCondition_SGA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMas_SGA).EndInit();
            groupBoxOutput_SGA.ResumeLayout(false);
            groupBoxOutput_SGA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_SGA;
        private DataGridView dataGridViewMas_SGA;
        private GroupBox groupBoxOutput_SGA;
        private Label labelResult_SGA;
        private Button buttonDone_SGA;
        private Button buttonHelp_SGA;
        private TextBox textBoxCondition_SGA;
    }
}
