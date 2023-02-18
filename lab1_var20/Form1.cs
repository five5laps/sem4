using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_var20
{
    public partial class OOP : Form
    {
        public OOP()
        {
            InitializeComponent();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                //lab1?
                RmbStateLabel.Text = "RMB RELEASED";
                //lab2?
                MessageBox.Show("You released RMB", "Notification");
            }
        }

    }
}
