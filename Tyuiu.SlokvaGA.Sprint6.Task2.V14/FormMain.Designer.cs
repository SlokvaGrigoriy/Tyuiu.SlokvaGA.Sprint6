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
            groupBoxCondition_SGA = new GroupBox();
            labelCondition_SGA = new Label();
            groupBoxInput_SGA = new GroupBox();
            textBoxStart_SGA = new TextBox();
            textBoxStop_SGA = new TextBox();
            labelStart_SGA = new Label();
            labelStop_SGA = new Label();
            groupBoxOutput_SGA = new GroupBox();
            label4 = new Label();
            buttonInfo_SGA = new Button();
            buttonDone_SGA = new Button();
            labelFunc_SGA = new Label();
            pictureBoxFormula_SGA = new PictureBox();
            groupBoxCondition_SGA.SuspendLayout();
            groupBoxInput_SGA.SuspendLayout();
            groupBoxOutput_SGA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SGA).BeginInit();
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
            groupBoxOutput_SGA.Controls.Add(label4);
            groupBoxOutput_SGA.Location = new Point(539, 12);
            groupBoxOutput_SGA.Name = "groupBoxOutput_SGA";
            groupBoxOutput_SGA.Size = new Size(455, 426);
            groupBoxOutput_SGA.TabIndex = 0;
            groupBoxOutput_SGA.TabStop = false;
            groupBoxOutput_SGA.Text = "Вывод данных";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // buttonInfo_SGA
            // 
            buttonInfo_SGA.BackColor = Color.DodgerBlue;
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
            buttonDone_SGA.BackColor = Color.DarkGreen;
            buttonDone_SGA.Location = new Point(377, 347);
            buttonDone_SGA.Name = "buttonDone_SGA";
            buttonDone_SGA.Size = new Size(156, 91);
            buttonDone_SGA.TabIndex = 3;
            buttonDone_SGA.Text = "Выполнить";
            buttonDone_SGA.UseVisualStyleBackColor = false;
            buttonDone_SGA.Click += buttonDone_SGA_Click;
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
            pictureBoxFormula_SGA.Location = new Point(159, 141);
            pictureBoxFormula_SGA.Name = "pictureBoxFormula_SGA";
            pictureBoxFormula_SGA.Size = new Size(100, 50);
            pictureBoxFormula_SGA.TabIndex = 5;
            pictureBoxFormula_SGA.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 447);
            Controls.Add(buttonDone_SGA);
            Controls.Add(buttonInfo_SGA);
            Controls.Add(groupBoxOutput_SGA);
            Controls.Add(groupBoxInput_SGA);
            Controls.Add(groupBoxCondition_SGA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 14 | Слоква Г. А.";
            groupBoxCondition_SGA.ResumeLayout(false);
            groupBoxCondition_SGA.PerformLayout();
            groupBoxInput_SGA.ResumeLayout(false);
            groupBoxInput_SGA.PerformLayout();
            groupBoxOutput_SGA.ResumeLayout(false);
            groupBoxOutput_SGA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SGA).EndInit();
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
        private Label label4;
        private TextBox textBoxStart_SGA;
        private TextBox textBoxStop_SGA;
        private Label labelFunc_SGA;
        private PictureBox pictureBoxFormula_SGA;
    }
}
