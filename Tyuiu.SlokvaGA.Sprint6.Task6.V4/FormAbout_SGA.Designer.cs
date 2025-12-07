namespace Tyuiu.SlokvaGA.Sprint6.Task6.V4
{
    partial class FormAbout_SGA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_SGA));
            pictureBoxAvatar_SGA = new PictureBox();
            labelAbout_SGA = new Label();
            buttonDone_SGA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SGA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_SGA
            // 
            pictureBoxAvatar_SGA.Image = (Image)resources.GetObject("pictureBoxAvatar_SGA.Image");
            pictureBoxAvatar_SGA.Location = new Point(12, 12);
            pictureBoxAvatar_SGA.Name = "pictureBoxAvatar_SGA";
            pictureBoxAvatar_SGA.Size = new Size(255, 192);
            pictureBoxAvatar_SGA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar_SGA.TabIndex = 0;
            pictureBoxAvatar_SGA.TabStop = false;
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
            buttonDone_SGA.Click += buttonDone_SGA_Click;
            // 
            // FormAbout_SGA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 219);
            Controls.Add(buttonDone_SGA);
            Controls.Add(labelAbout_SGA);
            Controls.Add(pictureBoxAvatar_SGA);
            Name = "FormAbout_SGA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SGA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_SGA;
        private Label labelAbout_SGA;
        private Button buttonDone_SGA;
    }
}