using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginScreenLP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have logged in succesfully","Admin Panel");
        }
    }
}
