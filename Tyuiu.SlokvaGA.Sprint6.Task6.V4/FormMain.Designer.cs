using Tyuiu.SlokvaGA.Sprint6.Task6.V4.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task6.V4
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
            buttonOpenFile_SGA = new Button();
            button2 = new Button();
            groupBoxCondition_SGA = new GroupBox();
            labelCondition_SGA = new Label();
            openFileDialogTask_SGA = new OpenFileDialog();
            toolTip_SGA = new ToolTip(components);
            buttonHelp_SGA = new Button();
            textBoxInput_SGA = new TextBox();
            textBoxOutput_SGA = new TextBox();
            labelInput_SGA = new Label();
            labelOutput_SGA = new Label();
            groupBoxCondition_SGA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile_SGA
            // 
            buttonOpenFile_SGA.BackColor = Color.Gold;
            buttonOpenFile_SGA.Cursor = Cursors.Hand;
            buttonOpenFile_SGA.Location = new Point(12, 12);
            buttonOpenFile_SGA.Name = "buttonOpenFile_SGA";
            buttonOpenFile_SGA.Size = new Size(90, 59);
            buttonOpenFile_SGA.TabIndex = 0;
            buttonOpenFile_SGA.Text = "Открыть файл";
            toolTip_SGA.SetToolTip(buttonOpenFile_SGA, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_SGA.UseVisualStyleBackColor = false;
            buttonOpenFile_SGA.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(108, 12);
            button2.Name = "button2";
            button2.Size = new Size(90, 59);
            button2.TabIndex = 1;
            button2.Text = "Выполнить";
            toolTip_SGA.SetToolTip(button2, "Производит поиск в файле вхождений символов \"n\"\r\nи конкатенирует строки в которых находятся\r\nэти символы");
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBoxCondition_SGA
            // 
            groupBoxCondition_SGA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCondition_SGA.Controls.Add(labelCondition_SGA);
            groupBoxCondition_SGA.Location = new Point(3, 77);
            groupBoxCondition_SGA.Name = "groupBoxCondition_SGA";
            groupBoxCondition_SGA.Size = new Size(794, 80);
            groupBoxCondition_SGA.TabIndex = 2;
            groupBoxCondition_SGA.TabStop = false;
            groupBoxCondition_SGA.Text = "Условие";
            // 
            // labelCondition_SGA
            // 
            labelCondition_SGA.AutoSize = true;
            labelCondition_SGA.Location = new Point(9, 19);
            labelCondition_SGA.Name = "labelCondition_SGA";
            labelCondition_SGA.Size = new Size(395, 15);
            labelCondition_SGA.TabIndex = 3;
            labelCondition_SGA.Text = "Дан файл InPutFileTask6V4.txt. Вывести слова в которых встречается n.\r\n";
            labelCondition_SGA.Click += labelCondition_SGA_Click;
            // 
            // toolTip_SGA
            // 
            toolTip_SGA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_SGA.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_SGA
            // 
            buttonHelp_SGA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SGA.BackColor = Color.DodgerBlue;
            buttonHelp_SGA.Cursor = Cursors.Hand;
            buttonHelp_SGA.Location = new Point(698, 12);
            buttonHelp_SGA.Name = "buttonHelp_SGA";
            buttonHelp_SGA.Size = new Size(90, 59);
            buttonHelp_SGA.TabIndex = 3;
            buttonHelp_SGA.Text = "Справка";
            toolTip_SGA.SetToolTip(buttonHelp_SGA, "Сведения о программе");
            buttonHelp_SGA.UseVisualStyleBackColor = false;
            buttonHelp_SGA.Click += buttonHelp_SGA_Click;
            // 
            // textBoxInput_SGA
            // 
            textBoxInput_SGA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxInput_SGA.Location = new Point(3, 177);
            textBoxInput_SGA.Multiline = true;
            textBoxInput_SGA.Name = "textBoxInput_SGA";
            textBoxInput_SGA.ReadOnly = true;
            textBoxInput_SGA.ScrollBars = ScrollBars.Vertical;
            textBoxInput_SGA.Size = new Size(404, 271);
            textBoxInput_SGA.TabIndex = 4;
            // 
            // textBoxOutput_SGA
            // 
            textBoxOutput_SGA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOutput_SGA.BorderStyle = BorderStyle.FixedSingle;
            textBoxOutput_SGA.Location = new Point(413, 177);
            textBoxOutput_SGA.Multiline = true;
            textBoxOutput_SGA.Name = "textBoxOutput_SGA";
            textBoxOutput_SGA.ReadOnly = true;
            textBoxOutput_SGA.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_SGA.Size = new Size(384, 271);
            textBoxOutput_SGA.TabIndex = 5;
            // 
            // labelInput_SGA
            // 
            labelInput_SGA.AutoSize = true;
            labelInput_SGA.Location = new Point(3, 159);
            labelInput_SGA.Name = "labelInput_SGA";
            labelInput_SGA.Size = new Size(36, 15);
            labelInput_SGA.TabIndex = 6;
            labelInput_SGA.Text = "Ввод:";
            // 
            // labelOutput_SGA
            // 
            labelOutput_SGA.AutoSize = true;
            labelOutput_SGA.Location = new Point(413, 159);
            labelOutput_SGA.Name = "labelOutput_SGA";
            labelOutput_SGA.Size = new Size(45, 15);
            labelOutput_SGA.TabIndex = 7;
            labelOutput_SGA.Text = "Вывод:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelOutput_SGA);
            Controls.Add(labelInput_SGA);
            Controls.Add(textBoxOutput_SGA);
            Controls.Add(textBoxInput_SGA);
            Controls.Add(buttonHelp_SGA);
            Controls.Add(groupBoxCondition_SGA);
            Controls.Add(button2);
            Controls.Add(buttonOpenFile_SGA);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 4 | Слоква Г. А.";
            groupBoxCondition_SGA.ResumeLayout(false);
            groupBoxCondition_SGA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpenFile_SGA;
        private Button button2;
        private GroupBox groupBoxCondition_SGA;
        private Label labelCondition_SGA;
        private OpenFileDialog openFileDialogTask_SGA;
        private ToolTip toolTip_SGA;
        private Button buttonHelp_SGA;
        private TextBox textBoxInput_SGA;
        private TextBox textBoxOutput_SGA;
        private Label labelInput_SGA;
        private Label labelOutput_SGA;
    }
}
