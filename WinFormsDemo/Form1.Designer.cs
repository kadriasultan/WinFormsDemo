namespace WinFormsDemo
{
    partial class Form1
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
            this.btnBackgroundToggle = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnToggleVisibility = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnOpenSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackgroundToggle
            // 
            this.btnBackgroundToggle.Location = new System.Drawing.Point(12, 130);
            this.btnBackgroundToggle.Name = "btnBackgroundToggle";
            this.btnBackgroundToggle.Size = new System.Drawing.Size(187, 70);
            this.btnBackgroundToggle.TabIndex = 0;
            this.btnBackgroundToggle.Text = "Toggle Kleur";
            this.btnBackgroundToggle.UseVisualStyleBackColor = true;
            this.btnBackgroundToggle.Click += new System.EventHandler(this.btnBackgroundToggle_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(205, 130);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(182, 70);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Voeg Item Toe";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnToggleVisibility
            // 
            this.btnToggleVisibility.Location = new System.Drawing.Point(393, 130);
            this.btnToggleVisibility.Name = "btnToggleVisibility";
            this.btnToggleVisibility.Size = new System.Drawing.Size(186, 70);
            this.btnToggleVisibility.TabIndex = 2;
            this.btnToggleVisibility.Text = "Toggle UI";
            this.btnToggleVisibility.UseVisualStyleBackColor = true;
            this.btnToggleVisibility.Click += new System.EventHandler(this.btnToggleVisibility_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 16;
            this.lstItems.Location = new System.Drawing.Point(18, 236);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(548, 148);
            this.lstItems.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(18, 477);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(548, 110);
            this.progressBar.TabIndex = 4;
            // 
            // btnOpenSettings
            // 
            this.btnOpenSettings.Location = new System.Drawing.Point(413, 0);
            this.btnOpenSettings.Name = "btnOpenSettings";
            this.btnOpenSettings.Size = new System.Drawing.Size(182, 64);
            this.btnOpenSettings.TabIndex = 5;
            this.btnOpenSettings.Text = "Instellingen";
            this.btnOpenSettings.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.btnOpenSettings);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnToggleVisibility);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnBackgroundToggle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackgroundToggle;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnToggleVisibility;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnOpenSettings;
    }
}

