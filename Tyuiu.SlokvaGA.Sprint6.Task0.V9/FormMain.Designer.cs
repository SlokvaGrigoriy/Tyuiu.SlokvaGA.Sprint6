
using Tyuiu.SlokvaGA.Sprint6.Task0.V9.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task0.V9
{
    partial class FormMain : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pictureBoxFormula_SGA = new PictureBox();
            groupBoxCondition_SGA = new GroupBox();
            labelCondition_SGA = new Label();
            button_SGA = new Button();
            textBoxVariable_SGA = new TextBox();
            groupBoxInput_SGA = new GroupBox();
            labelVariable_SGA = new Label();
            groupBoxOutput_SGA = new GroupBox();
            textBoxResult_SGA = new TextBox();
            labelResult_SGA = new Label();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SGA).BeginInit();
            groupBoxCondition_SGA.SuspendLayout();
            groupBoxInput_SGA.SuspendLayout();
            groupBoxOutput_SGA.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxFormula_SGA
            // 
            pictureBoxFormula_SGA.Image = (Image)resources.GetObject("pictureBoxFormula_SGA.Image");
            pictureBoxFormula_SGA.Location = new Point(611, 22);
            pictureBoxFormula_SGA.Name = "pictureBoxFormula_SGA";
            pictureBoxFormula_SGA.Size = new Size(106, 61);
            pictureBoxFormula_SGA.TabIndex = 0;
            pictureBoxFormula_SGA.TabStop = false;
            pictureBoxFormula_SGA.UseWaitCursor = true;
            // 
            // groupBoxCondition_SGA
            // 
            groupBoxCondition_SGA.Controls.Add(labelCondition_SGA);
            groupBoxCondition_SGA.Controls.Add(pictureBoxFormula_SGA);
            groupBoxCondition_SGA.Location = new Point(12, 25);
            groupBoxCondition_SGA.Name = "groupBoxCondition_SGA";
            groupBoxCondition_SGA.Size = new Size(776, 244);
            groupBoxCondition_SGA.TabIndex = 1;
            groupBoxCondition_SGA.TabStop = false;
            groupBoxCondition_SGA.Text = "Условие";
            groupBoxCondition_SGA.UseWaitCursor = true;
            groupBoxCondition_SGA.Enter += groupBox1_Enter;
            // 
            // labelCondition_SGA
            // 
            labelCondition_SGA.AutoSize = true;
            labelCondition_SGA.Font = new Font("Segoe UI", 9F);
            labelCondition_SGA.Location = new Point(22, 31);
            labelCondition_SGA.Name = "labelCondition_SGA";
            labelCondition_SGA.Size = new Size(458, 30);
            labelCondition_SGA.TabIndex = 3;
            labelCondition_SGA.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. \r\nОкруглить до трёх знаков после запятой.";
            labelCondition_SGA.UseWaitCursor = true;
            // 
            // button_SGA
            // 
            button_SGA.Location = new Point(667, 393);
            button_SGA.Name = "button_SGA";
            button_SGA.Size = new Size(106, 32);
            button_SGA.TabIndex = 0;
            button_SGA.Text = "Выполнить";
            button_SGA.UseVisualStyleBackColor = true;
            button_SGA.Click += button_SGA_Click;
            // 
            // textBoxVariable_SGA
            // 
            textBoxVariable_SGA.Location = new Point(32, 62);
            textBoxVariable_SGA.Name = "textBoxVariable_SGA";
            textBoxVariable_SGA.ReadOnly = true;
            textBoxVariable_SGA.Size = new Size(89, 23);
            textBoxVariable_SGA.TabIndex = 2;
            textBoxVariable_SGA.Text = "3";
            textBoxVariable_SGA.TextChanged += textBoxVariable_SGA_TextChanged;
            // 
            // groupBoxInput_SGA
            // 
            groupBoxInput_SGA.Controls.Add(labelVariable_SGA);
            groupBoxInput_SGA.Controls.Add(textBoxVariable_SGA);
            groupBoxInput_SGA.Location = new Point(12, 291);
            groupBoxInput_SGA.Name = "groupBoxInput_SGA";
            groupBoxInput_SGA.Size = new Size(583, 134);
            groupBoxInput_SGA.TabIndex = 3;
            groupBoxInput_SGA.TabStop = false;
            groupBoxInput_SGA.Text = "Ввод данных";
            groupBoxInput_SGA.Enter += groupBoxInput_SGA_Enter;
            // 
            // labelVariable_SGA
            // 
            labelVariable_SGA.AutoSize = true;
            labelVariable_SGA.Location = new Point(32, 44);
            labelVariable_SGA.Name = "labelVariable_SGA";
            labelVariable_SGA.Size = new Size(89, 15);
            labelVariable_SGA.TabIndex = 4;
            labelVariable_SGA.Text = "Переменная X:";
            // 
            // groupBoxOutput_SGA
            // 
            groupBoxOutput_SGA.Controls.Add(textBoxResult_SGA);
            groupBoxOutput_SGA.Controls.Add(labelResult_SGA);
            groupBoxOutput_SGA.Location = new Point(601, 291);
            groupBoxOutput_SGA.Name = "groupBoxOutput_SGA";
            groupBoxOutput_SGA.Size = new Size(187, 96);
            groupBoxOutput_SGA.TabIndex = 4;
            groupBoxOutput_SGA.TabStop = false;
            groupBoxOutput_SGA.Text = "Вывод данных";
            groupBoxOutput_SGA.Enter += groupBoxOutput_SGA_Enter;
            // 
            // textBoxResult_SGA
            // 
            textBoxResult_SGA.Location = new Point(22, 51);
            textBoxResult_SGA.Name = "textBoxResult_SGA";
            textBoxResult_SGA.ReadOnly = true;
            textBoxResult_SGA.Size = new Size(150, 23);
            textBoxResult_SGA.TabIndex = 5;
            textBoxResult_SGA.TextChanged += textBoxVariable_SGA_TextChanged;
            // 
            // labelResult_SGA
            // 
            labelResult_SGA.AutoSize = true;
            labelResult_SGA.Location = new Point(22, 33);
            labelResult_SGA.Name = "labelResult_SGA";
            labelResult_SGA.Size = new Size(63, 15);
            labelResult_SGA.TabIndex = 5;
            labelResult_SGA.Text = "Результат:";
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(601, 393);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(60, 40);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxOutput_SGA);
            Controls.Add(groupBoxInput_SGA);
            Controls.Add(button_SGA);
            Controls.Add(groupBoxCondition_SGA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 9 | Слоква Г. А. ";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SGA).EndInit();
            groupBoxCondition_SGA.ResumeLayout(false);
            groupBoxCondition_SGA.PerformLayout();
            groupBoxInput_SGA.ResumeLayout(false);
            groupBoxInput_SGA.PerformLayout();
            groupBoxOutput_SGA.ResumeLayout(false);
            groupBoxOutput_SGA.PerformLayout();
            ResumeLayout(false);
        }

        private void textBoxVariable_SGA_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBoxOutput_SGA_Enter(object sender, EventArgs e)
        {
        }

        private void groupBoxInput_SGA_Enter(object sender, EventArgs e)
        {
        }

        private void button_SGA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                double result = ds.Calculate(Convert.ToInt32(textBoxVariable_SGA.Text));
                textBoxResult_SGA.Text = Math.Round(result, 3).ToString("F3");
            }
            catch
            {
                MessageBox.Show("Ошибка при вычислении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        #endregion

        private PictureBox pictureBoxFormula_SGA;
        private GroupBox groupBoxCondition_SGA;
        private Button button_SGA;
        private TextBox textBoxVariable_SGA;
        private Label labelCondition_SGA;
        private GroupBox groupBoxInput_SGA;
        private Label labelVariable_SGA;
        private GroupBox groupBoxOutput_SGA;
        private TextBox textBoxResult_SGA;
        private Label labelResult_SGA;
        private Button buttonHelp;
    }
}
