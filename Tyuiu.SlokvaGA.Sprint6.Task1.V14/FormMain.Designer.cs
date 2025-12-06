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
            pictureBox1 = new PictureBox();
            labelFunc_SGA = new Label();
            labelCondition_SGA = new Label();
            groupBoxInput_SGA = new GroupBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelStart_SGA = new Label();
            labelEnd_SGA = new Label();
            labelResult_SGA = new Label();
            groupBoxOutput_SGA = new GroupBox();
            textBoxResult_SGA = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBoxCondition_SGA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxInput_SGA.SuspendLayout();
            groupBoxOutput_SGA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_SGA
            // 
            groupBoxCondition_SGA.Controls.Add(pictureBox1);
            groupBoxCondition_SGA.Controls.Add(labelFunc_SGA);
            groupBoxCondition_SGA.Controls.Add(labelCondition_SGA);
            groupBoxCondition_SGA.Location = new Point(12, 12);
            groupBoxCondition_SGA.Name = "groupBoxCondition_SGA";
            groupBoxCondition_SGA.Size = new Size(522, 324);
            groupBoxCondition_SGA.TabIndex = 0;
            groupBoxCondition_SGA.TabStop = false;
            groupBoxCondition_SGA.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(128, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 40);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            groupBoxInput_SGA.Controls.Add(textBox1);
            groupBoxInput_SGA.Controls.Add(textBox2);
            groupBoxInput_SGA.Controls.Add(labelStart_SGA);
            groupBoxInput_SGA.Controls.Add(labelEnd_SGA);
            groupBoxInput_SGA.Location = new Point(12, 352);
            groupBoxInput_SGA.Name = "groupBoxInput_SGA";
            groupBoxInput_SGA.Size = new Size(253, 83);
            groupBoxInput_SGA.TabIndex = 1;
            groupBoxInput_SGA.TabStop = false;
            groupBoxInput_SGA.Text = "Ввод данных";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 37);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = "-5";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 37);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            textBox2.Text = "5";
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
            textBoxResult_SGA.Location = new Point(6, 43);
            textBoxResult_SGA.Multiline = true;
            textBoxResult_SGA.Name = "textBoxResult_SGA";
            textBoxResult_SGA.ReadOnly = true;
            textBoxResult_SGA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SGA.Size = new Size(236, 365);
            textBoxResult_SGA.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(271, 361);
            button1.Name = "button1";
            button1.Size = new Size(97, 74);
            button1.TabIndex = 9;
            button1.Text = "Справка";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(383, 361);
            button2.Name = "button2";
            button2.Size = new Size(151, 74);
            button2.TabIndex = 10;
            button2.Text = "Выполнить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBoxOutput_SGA);
            Controls.Add(groupBoxInput_SGA);
            Controls.Add(groupBoxCondition_SGA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 0 | Слоква Г. А.";
            groupBoxCondition_SGA.ResumeLayout(false);
            groupBoxCondition_SGA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label labelFunc_SGA;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBoxOutput_SGA;
        private Button button1;
        private Button button2;
        private TextBox textBoxResult_SGA;
    }
}
