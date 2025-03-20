using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnBackgroundToggle_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
                this.BackColor = SystemColors.Control;
            else
                this.BackColor = Color.Red;
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            lstItems.Items.Add($"Item {lstItems.Items.Count + 1}");
            if (progressBar.Value < 100)
                progressBar.Value += 10;
            else
                progressBar.Value = 0; // Reset progressbar als deze vol is
        }

        private void btnToggleVisibility_Click(object sender, EventArgs e)
        {
            bool isVisible = btnBackgroundToggle.Visible;
            btnBackgroundToggle.Visible = !isVisible;
            btnAddItem.Visible = !isVisible;
            lstItems.Visible = !isVisible;
        }

    }
}
