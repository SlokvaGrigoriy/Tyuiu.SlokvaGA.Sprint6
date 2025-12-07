namespace Tyuiu.SlokvaGA.Sprint6.Task7.V11
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox1 = new PictureBox();
            labelAbout_SGA = new Label();
            buttonDone_SGA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ButtonDone_SGA_Click;
            // 
            // labelAbout_SGA
            // 
            labelAbout_SGA.AutoSize = true;
            labelAbout_SGA.Location = new Point(282, 22);
            labelAbout_SGA.Name = "labelAbout_SGA";
            labelAbout_SGA.Size = new Size(303, 135);
            labelAbout_SGA.TabIndex = 1;
            labelAbout_SGA.Text = resources.GetString("labelAbout_SGA.Text");
            // 
            // buttonDone_SGA
            // 
            buttonDone_SGA.Location = new Point(535, 178);
            buttonDone_SGA.Name = "buttonDone_SGA";
            buttonDone_SGA.Size = new Size(101, 29);
            buttonDone_SGA.TabIndex = 2;
            buttonDone_SGA.Text = "OK";
            buttonDone_SGA.UseVisualStyleBackColor = true;
            buttonDone_SGA.Click += ButtonDone_SGA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 219);
            Controls.Add(buttonDone_SGA);
            Controls.Add(labelAbout_SGA);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(664, 258);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelAbout_SGA;
        private Button buttonDone_SGA;
    }
}