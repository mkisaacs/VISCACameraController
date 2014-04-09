using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CameraController
{
    public partial class SetLabel : Form
    {
        public SetLabel()
        {
            InitializeComponent();
        }
        public SetLabel(string labelText)
        {
            InitializeComponent();
            this.ux_txtLabel.Text = labelText;
        }

        public string Label
        {
            get
            {
                return ux_txtLabel.Text;
            }
            set
            {
                ux_txtLabel.Text = value;
            }
        }

        private void ux_btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
