using System;

namespace WinFormsDemo
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbComponent = new System.Windows.Forms.ComboBox();
            this.Achtergrondkleur = new System.Windows.Forms.Label();
            this.btnBgColor = new System.Windows.Forms.Button();
            this.Voorgrondkleur = new System.Windows.Forms.Label();
            this.btnFgColor = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kies een component om aan te passen:";
            // 
            // cmbComponent
            // 
            this.cmbComponent.FormattingEnabled = true;
            this.cmbComponent.Location = new System.Drawing.Point(68, 91);
            this.cmbComponent.Name = "cmbComponent";
            this.cmbComponent.Size = new System.Drawing.Size(105, 24);
            this.cmbComponent.TabIndex = 1;
            this.cmbComponent.SelectedIndexChanged += new System.EventHandler(this.cmbComponent_SelectedIndexChanged);
            // 
            // Achtergrondkleur
            // 
            this.Achtergrondkleur.AutoSize = true;
            this.Achtergrondkleur.Location = new System.Drawing.Point(65, 146);
            this.Achtergrondkleur.Name = "Achtergrondkleur";
            this.Achtergrondkleur.Size = new System.Drawing.Size(44, 16);
            this.Achtergrondkleur.TabIndex = 2;
            this.Achtergrondkleur.Text = "label2";
            this.Achtergrondkleur.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnBgColor
            // 
            this.btnBgColor.Location = new System.Drawing.Point(68, 192);
            this.btnBgColor.Name = "btnBgColor";
            this.btnBgColor.Size = new System.Drawing.Size(92, 30);
            this.btnBgColor.TabIndex = 3;
            this.btnBgColor.Text = "Color";
            this.btnBgColor.UseVisualStyleBackColor = true;
            // 
            // Voorgrondkleur
            // 
            this.Voorgrondkleur.AutoSize = true;
            this.Voorgrondkleur.Location = new System.Drawing.Point(65, 264);
            this.Voorgrondkleur.Name = "Voorgrondkleur";
            this.Voorgrondkleur.Size = new System.Drawing.Size(44, 16);
            this.Voorgrondkleur.TabIndex = 4;
            this.Voorgrondkleur.Text = "label3";
            // 
            // btnFgColor
            // 
            this.btnFgColor.Location = new System.Drawing.Point(68, 315);
            this.btnFgColor.Name = "btnFgColor";
            this.btnFgColor.Size = new System.Drawing.Size(92, 34);
            this.btnFgColor.TabIndex = 5;
            this.btnFgColor.Text = "button2";
            this.btnFgColor.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(61, 391);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(99, 37);
            this.btnSaveSettings.TabIndex = 6;
            this.btnSaveSettings.Text = "Opslaan";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnFgColor);
            this.Controls.Add(this.Voorgrondkleur);
            this.Controls.Add(this.btnBgColor);
            this.Controls.Add(this.Achtergrondkleur);
            this.Controls.Add(this.cmbComponent);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cmbComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbComponent;
        private System.Windows.Forms.Label Achtergrondkleur;
        private System.Windows.Forms.Button btnBgColor;
        private System.Windows.Forms.Label Voorgrondkleur;
        private System.Windows.Forms.Button btnFgColor;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}