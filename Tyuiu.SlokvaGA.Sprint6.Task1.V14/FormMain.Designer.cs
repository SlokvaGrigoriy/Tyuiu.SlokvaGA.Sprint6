namespace Tyuiu.SlokvaGA.Sprint6.Task1.V14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_SGA = new GroupBox();
            pictureBoxFormula_SGA = new PictureBox();
            labelFunc_SGA = new Label();
            labelCondition_SGA = new Label();
            groupBoxInput_SGA = new GroupBox();
            textBoxStart_SGA = new TextBox();
            textBoxStop_SGA = new TextBox();
            labelStart_SGA = new Label();
            labelEnd_SGA = new Label();
            labelResult_SGA = new Label();
            groupBoxOutput_SGA = new GroupBox();
            textBoxResult_SGA = new TextBox();
            buttonInfo_SGA = new Button();
            buttonDone_SGA = new Button();
            groupBoxCondition_SGA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SGA).BeginInit();
            groupBoxInput_SGA.SuspendLayout();
            groupBoxOutput_SGA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_SGA
            // 
            groupBoxCondition_SGA.Controls.Add(pictureBoxFormula_SGA);
            groupBoxCondition_SGA.Controls.Add(labelFunc_SGA);
            groupBoxCondition_SGA.Controls.Add(labelCondition_SGA);
            groupBoxCondition_SGA.Location = new Point(12, 12);
            groupBoxCondition_SGA.Name = "groupBoxCondition_SGA";
            groupBoxCondition_SGA.Size = new Size(522, 324);
            groupBoxCondition_SGA.TabIndex = 0;
            groupBoxCondition_SGA.TabStop = false;
            groupBoxCondition_SGA.Text = "Условие";
            // 
            // pictureBoxFormula_SGA
            // 
            pictureBoxFormula_SGA.Image = (Image)resources.GetObject("pictureBoxFormula_SGA.Image");
            pictureBoxFormula_SGA.Location = new Point(128, 141);
            pictureBoxFormula_SGA.Name = "pictureBoxFormula_SGA";
            pictureBoxFormula_SGA.Size = new Size(196, 40);
            pictureBoxFormula_SGA.TabIndex = 7;
            pictureBoxFormula_SGA.TabStop = false;
            pictureBoxFormula_SGA.Click += pictureBox1_Click;
            // 
            // labelFunc_SGA
            // 
            labelFunc_SGA.AutoSize = true;
            labelFunc_SGA.Location = new Point(17, 65);
            labelFunc_SGA.Name = "labelFunc_SGA";
            labelFunc_SGA.Size = new Size(58, 15);
            labelFunc_SGA.TabIndex = 6;
            labelFunc_SGA.Text = "Функция:";
            // 
            // labelCondition_SGA
            // 
            labelCondition_SGA.AutoSize = true;
            labelCondition_SGA.Location = new Point(17, 19);
            labelCondition_SGA.Name = "labelCondition_SGA";
            labelCondition_SGA.Size = new Size(436, 30);
            labelCondition_SGA.TabIndex = 4;
            labelCondition_SGA.Text = "Протабулировать функцию F(x) на диапазоне [-5;5]. \nРезультат вывести в виде таблицы и округлить до двух знаков после запятой. ";
            labelCondition_SGA.Click += labelCondition_SGA_Click;
            // 
            // groupBoxInput_SGA
            // 
            groupBoxInput_SGA.Controls.Add(textBoxStart_SGA);
            groupBoxInput_SGA.Controls.Add(textBoxStop_SGA);
            groupBoxInput_SGA.Controls.Add(labelStart_SGA);
            groupBoxInput_SGA.Controls.Add(labelEnd_SGA);
            groupBoxInput_SGA.Location = new Point(12, 352);
            groupBoxInput_SGA.Name = "groupBoxInput_SGA";
            groupBoxInput_SGA.Size = new Size(253, 83);
            groupBoxInput_SGA.TabIndex = 1;
            groupBoxInput_SGA.TabStop = false;
            groupBoxInput_SGA.Text = "Ввод данных";
            // 
            // textBoxStart_SGA
            // 
            textBoxStart_SGA.Location = new Point(17, 37);
            textBoxStart_SGA.Name = "textBoxStart_SGA";
            textBoxStart_SGA.Size = new Size(100, 23);
            textBoxStart_SGA.TabIndex = 6;
            // 
            // textBoxStop_SGA
            // 
            textBoxStop_SGA.Location = new Point(138, 37);
            textBoxStop_SGA.Name = "textBoxStop_SGA";
            textBoxStop_SGA.Size = new Size(100, 23);
            textBoxStop_SGA.TabIndex = 7;
            // 
            // labelStart_SGA
            // 
            labelStart_SGA.AutoSize = true;
            labelStart_SGA.Location = new Point(28, 19);
            labelStart_SGA.Name = "labelStart_SGA";
            labelStart_SGA.Size = new Size(72, 15);
            labelStart_SGA.TabIndex = 2;
            labelStart_SGA.Text = "Старт шага:";
            labelStart_SGA.Click += label1_Click;
            // 
            // labelEnd_SGA
            // 
            labelEnd_SGA.AutoSize = true;
            labelEnd_SGA.Location = new Point(153, 19);
            labelEnd_SGA.Name = "labelEnd_SGA";
            labelEnd_SGA.Size = new Size(75, 15);
            labelEnd_SGA.TabIndex = 3;
            labelEnd_SGA.Text = "Конец шага:";
            // 
            // labelResult_SGA
            // 
            labelResult_SGA.AutoSize = true;
            labelResult_SGA.Location = new Point(6, 19);
            labelResult_SGA.Name = "labelResult_SGA";
            labelResult_SGA.Size = new Size(63, 15);
            labelResult_SGA.TabIndex = 5;
            labelResult_SGA.Text = "Результат:";
            // 
            // groupBoxOutput_SGA
            // 
            groupBoxOutput_SGA.Controls.Add(textBoxResult_SGA);
            groupBoxOutput_SGA.Controls.Add(labelResult_SGA);
            groupBoxOutput_SGA.Location = new Point(540, 21);
            groupBoxOutput_SGA.Name = "groupBoxOutput_SGA";
            groupBoxOutput_SGA.Size = new Size(248, 414);
            groupBoxOutput_SGA.TabIndex = 8;
            groupBoxOutput_SGA.TabStop = false;
            groupBoxOutput_SGA.Text = "Вывод данных";
            groupBoxOutput_SGA.Enter += groupBox1_Enter;
            // 
            // textBoxResult_SGA
            // 
            textBoxResult_SGA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_SGA.Location = new Point(6, 43);
            textBoxResult_SGA.Multiline = true;
            textBoxResult_SGA.Name = "textBoxResult_SGA";
            textBoxResult_SGA.ReadOnly = true;
            textBoxResult_SGA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SGA.Size = new Size(236, 365);
            textBoxResult_SGA.TabIndex = 11;
            textBoxResult_SGA.TextChanged += textBoxResult_SGA_TextChanged;
            // 
            // buttonInfo_SGA
            // 
            buttonInfo_SGA.BackColor = Color.DodgerBlue;
            buttonInfo_SGA.Cursor = Cursors.Hand;
            buttonInfo_SGA.Location = new Point(271, 361);
            buttonInfo_SGA.Name = "buttonInfo_SGA";
            buttonInfo_SGA.Size = new Size(97, 74);
            buttonInfo_SGA.TabIndex = 9;
            buttonInfo_SGA.Text = "Справка";
            buttonInfo_SGA.UseVisualStyleBackColor = false;
            buttonInfo_SGA.Click += button1_Click;
            // 
            // buttonDone_SGA
            // 
            buttonDone_SGA.BackColor = Color.DarkGreen;
            buttonDone_SGA.Cursor = Cursors.Hand;
            buttonDone_SGA.Location = new Point(383, 361);
            buttonDone_SGA.Name = "buttonDone_SGA";
            buttonDone_SGA.Size = new Size(151, 74);
            buttonDone_SGA.TabIndex = 10;
            buttonDone_SGA.Text = "Выполнить";
            buttonDone_SGA.UseVisualStyleBackColor = false;
            buttonDone_SGA.Click += button2_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_SGA);
            Controls.Add(buttonInfo_SGA);
            Controls.Add(groupBoxOutput_SGA);
            Controls.Add(groupBoxInput_SGA);
            Controls.Add(groupBoxCondition_SGA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 14 | Слоква Г. А.";
            groupBoxCondition_SGA.ResumeLayout(false);
            groupBoxCondition_SGA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SGA).EndInit();
            groupBoxInput_SGA.ResumeLayout(false);
            groupBoxInput_SGA.PerformLayout();
            groupBoxOutput_SGA.ResumeLayout(false);
            groupBoxOutput_SGA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_SGA;
        private Label labelCondition_SGA;
        private GroupBox groupBoxInput_SGA;
        private Label labelStart_SGA;
        private Label labelEnd_SGA;
        private Label labelResult_SGA;
        private PictureBox pictureBoxFormula_SGA;
        private Label labelFunc_SGA;
        private TextBox textBoxStart_SGA;
        private TextBox textBoxStop_SGA;
        private GroupBox groupBoxOutput_SGA;
        private Button buttonInfo_SGA;
        private Button buttonDone_SGA;
        private TextBox textBoxResult_SGA;
    }
}
