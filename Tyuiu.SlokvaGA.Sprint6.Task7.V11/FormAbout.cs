using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SlokvaGA.Sprint6.Task7.V11
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }
        private void ButtonDone_SGA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
