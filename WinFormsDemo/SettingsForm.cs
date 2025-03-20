using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsDemo
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            cmbComponent.Items.Add("Button");
            cmbComponent.Items.Add("ListBox");
        }

        private void btnBgColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnBgColor.BackColor = colorDialog.Color;
            }
        }

        private void btnFgColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnFgColor.BackColor = colorDialog.Color;
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SelectedComponent = cmbComponent.SelectedItem.ToString();
            Properties.Settings.Default.BgColor = btnBgColor.BackColor;
            Properties.Settings.Default.FgColor = btnFgColor.BackColor;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
