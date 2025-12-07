namespace Tyuiu.SlokvaGA.Sprint6.Task7.V11
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
            labelOutput_SGA = new Label();
            dataGridViewOutMatrix_SGA = new DataGridView();
            dataGridViewInMatrix_SGA = new DataGridView();
            openFileDialogTask_SGA = new OpenFileDialog();
            toolTip_SGA = new ToolTip(components);
            saveFileDialogMatrix_SGA = new SaveFileDialog();
            labelInput_SGA = new Label();
            buttonHelp_SGA = new Button();
            buttonSaveFile_SGA = new Button();
            buttonOpenFile_SGA = new Button();
            buttonDone_SGA = new Button();
            groupBoxCondition_SGA = new GroupBox();
            labelCondition_SGA = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_SGA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_SGA).BeginInit();
            groupBoxCondition_SGA.SuspendLayout();
            SuspendLayout();
            // 
            // labelOutput_SGA
            // 
            labelOutput_SGA.AutoSize = true;
            labelOutput_SGA.Location = new Point(12, 138);
            labelOutput_SGA.Name = "labelOutput_SGA";
            labelOutput_SGA.Size = new Size(45, 15);
            labelOutput_SGA.TabIndex = 8;
            labelOutput_SGA.Text = "Вывод:";
            // 
            // dataGridViewOutMatrix_SGA
            // 
            dataGridViewOutMatrix_SGA.AllowUserToAddRows = false;
            dataGridViewOutMatrix_SGA.AllowUserToDeleteRows = false;
            dataGridViewOutMatrix_SGA.AllowUserToResizeColumns = false;
            dataGridViewOutMatrix_SGA.AllowUserToResizeRows = false;
            dataGridViewOutMatrix_SGA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOutMatrix_SGA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_SGA.ColumnHeadersVisible = false;
            dataGridViewOutMatrix_SGA.Location = new Point(416, 156);
            dataGridViewOutMatrix_SGA.Name = "dataGridViewOutMatrix_SGA";
            dataGridViewOutMatrix_SGA.ReadOnly = true;
            dataGridViewOutMatrix_SGA.RowHeadersVisible = false;
            dataGridViewOutMatrix_SGA.ScrollBars = ScrollBars.Vertical;
            dataGridViewOutMatrix_SGA.Size = new Size(386, 364);
            dataGridViewOutMatrix_SGA.TabIndex = 9;
            dataGridViewOutMatrix_SGA.CellContentClick += dataGridViewOutMatrix_SGA_CellContentClick;
            // 
            // dataGridViewInMatrix_SGA
            // 
            dataGridViewInMatrix_SGA.AllowUserToAddRows = false;
            dataGridViewInMatrix_SGA.AllowUserToDeleteRows = false;
            dataGridViewInMatrix_SGA.AllowUserToResizeColumns = false;
            dataGridViewInMatrix_SGA.AllowUserToResizeRows = false;
            dataGridViewInMatrix_SGA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewInMatrix_SGA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_SGA.ColumnHeadersVisible = false;
            dataGridViewInMatrix_SGA.Location = new Point(12, 156);
            dataGridViewInMatrix_SGA.Name = "dataGridViewInMatrix_SGA";
            dataGridViewInMatrix_SGA.ReadOnly = true;
            dataGridViewInMatrix_SGA.RowHeadersVisible = false;
            dataGridViewInMatrix_SGA.ScrollBars = ScrollBars.Vertical;
            dataGridViewInMatrix_SGA.Size = new Size(401, 364);
            dataGridViewInMatrix_SGA.TabIndex = 10;
            dataGridViewInMatrix_SGA.CellContentClick += dataGridViewInMatrix_SGA_CellContentClick;
            // 
            // labelInput_SGA
            // 
            labelInput_SGA.AutoSize = true;
            labelInput_SGA.Location = new Point(416, 138);
            labelInput_SGA.Name = "labelInput_SGA";
            labelInput_SGA.Size = new Size(36, 15);
            labelInput_SGA.TabIndex = 7;
            labelInput_SGA.Text = "Ввод:";
            // 
            // buttonHelp_SGA
            // 
            buttonHelp_SGA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SGA.Cursor = Cursors.Hand;
            buttonHelp_SGA.Image = (Image)resources.GetObject("buttonHelp_SGA.Image");
            buttonHelp_SGA.Location = new Point(701, 12);
            buttonHelp_SGA.Name = "buttonHelp_SGA";
            buttonHelp_SGA.Size = new Size(101, 45);
            buttonHelp_SGA.TabIndex = 5;
            buttonHelp_SGA.UseVisualStyleBackColor = true;
            buttonHelp_SGA.Click += buttonHelp_SGA_Click;
            // 
            // buttonSaveFile_SGA
            // 
            buttonSaveFile_SGA.Cursor = Cursors.Hand;
            buttonSaveFile_SGA.Image = (Image)resources.GetObject("buttonSaveFile_SGA.Image");
            buttonSaveFile_SGA.Location = new Point(226, 12);
            buttonSaveFile_SGA.Name = "buttonSaveFile_SGA";
            buttonSaveFile_SGA.Size = new Size(101, 45);
            buttonSaveFile_SGA.TabIndex = 4;
            buttonSaveFile_SGA.UseVisualStyleBackColor = true;
            buttonSaveFile_SGA.Click += button3_Click;
            // 
            // buttonOpenFile_SGA
            // 
            buttonOpenFile_SGA.Cursor = Cursors.Hand;
            buttonOpenFile_SGA.Image = (Image)resources.GetObject("buttonOpenFile_SGA.Image");
            buttonOpenFile_SGA.Location = new Point(12, 12);
            buttonOpenFile_SGA.Name = "buttonOpenFile_SGA";
            buttonOpenFile_SGA.Size = new Size(101, 45);
            buttonOpenFile_SGA.TabIndex = 2;
            buttonOpenFile_SGA.UseVisualStyleBackColor = true;
            buttonOpenFile_SGA.Click += buttonOpenFile_SGA_Click;
            // 
            // buttonDone_SGA
            // 
            buttonDone_SGA.Cursor = Cursors.Hand;
            buttonDone_SGA.Image = (Image)resources.GetObject("buttonDone_SGA.Image");
            buttonDone_SGA.Location = new Point(119, 12);
            buttonDone_SGA.Name = "buttonDone_SGA";
            buttonDone_SGA.Size = new Size(101, 45);
            buttonDone_SGA.TabIndex = 3;
            buttonDone_SGA.UseVisualStyleBackColor = true;
            buttonDone_SGA.Click += buttonDone_SGA_Click;
            // 
            // groupBoxCondition_SGA
            // 
            groupBoxCondition_SGA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCondition_SGA.Controls.Add(labelCondition_SGA);
            groupBoxCondition_SGA.Location = new Point(12, 63);
            groupBoxCondition_SGA.Name = "groupBoxCondition_SGA";
            groupBoxCondition_SGA.Size = new Size(790, 72);
            groupBoxCondition_SGA.TabIndex = 6;
            groupBoxCondition_SGA.TabStop = false;
            groupBoxCondition_SGA.Text = "Условие";
            // 
            // labelCondition_SGA
            // 
            labelCondition_SGA.AutoSize = true;
            labelCondition_SGA.Location = new Point(3, 19);
            labelCondition_SGA.Name = "labelCondition_SGA";
            labelCondition_SGA.Size = new Size(782, 30);
            labelCondition_SGA.TabIndex = 0;
            labelCondition_SGA.Text = "Дан файл InPutFileTask7V11.csv в котором хранится матрица целочисленных значений. Изменить в пятой строке отрицательные числа на 9.\r\n\r\n";
            labelCondition_SGA.Click += label1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 480);
            Controls.Add(buttonDone_SGA);
            Controls.Add(buttonOpenFile_SGA);
            Controls.Add(buttonHelp_SGA);
            Controls.Add(buttonSaveFile_SGA);
            Controls.Add(groupBoxCondition_SGA);
            Controls.Add(labelInput_SGA);
            Controls.Add(dataGridViewInMatrix_SGA);
            Controls.Add(labelOutput_SGA);
            Controls.Add(dataGridViewOutMatrix_SGA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 11 | Слоква Г. А.";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_SGA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_SGA).EndInit();
            groupBoxCondition_SGA.ResumeLayout(false);
            groupBoxCondition_SGA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelOutput_SGA;
        private DataGridView dataGridViewOutMatrix_SGA;
        private DataGridView dataGridViewInMatrix_SGA;
        private OpenFileDialog openFileDialogTask_SGA;
        private ToolTip toolTip_SGA;
        private SaveFileDialog saveFileDialogMatrix_SGA;
        private Label labelInput_SGA;
        private Button buttonHelp_SGA;
        private Button buttonSaveFile_SGA;
        private Button buttonOpenFile_SGA;
        private Button buttonDone_SGA;
        private GroupBox groupBoxCondition_SGA;
        private Label labelCondition_SGA;
    }
}
