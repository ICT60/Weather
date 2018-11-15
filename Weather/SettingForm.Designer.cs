namespace Weather
{
    partial class SettingForm
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
            this.lstCityName = new System.Windows.Forms.ListBox();
            this.cmbCountryName = new System.Windows.Forms.ComboBox();
            this.btnApplySetting = new System.Windows.Forms.Button();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCityName
            // 
            this.lstCityName.FormattingEnabled = true;
            this.lstCityName.Location = new System.Drawing.Point(12, 39);
            this.lstCityName.Name = "lstCityName";
            this.lstCityName.Size = new System.Drawing.Size(392, 173);
            this.lstCityName.TabIndex = 0;
            // 
            // cmbCountryName
            // 
            this.cmbCountryName.FormattingEnabled = true;
            this.cmbCountryName.Location = new System.Drawing.Point(95, 12);
            this.cmbCountryName.Name = "cmbCountryName";
            this.cmbCountryName.Size = new System.Drawing.Size(309, 21);
            this.cmbCountryName.TabIndex = 1;
            this.cmbCountryName.SelectedIndexChanged += new System.EventHandler(this.cmbCountryName_SelectedIndexChanged);
            // 
            // btnApplySetting
            // 
            this.btnApplySetting.Location = new System.Drawing.Point(329, 223);
            this.btnApplySetting.Name = "btnApplySetting";
            this.btnApplySetting.Size = new System.Drawing.Size(75, 23);
            this.btnApplySetting.TabIndex = 2;
            this.btnApplySetting.Text = "Apply";
            this.btnApplySetting.UseVisualStyleBackColor = true;
            this.btnApplySetting.Click += new System.EventHandler(this.btnApplySetting_Click);
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(69, 225);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(254, 20);
            this.txtApiKey.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "API Key :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Country Code :";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 258);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.btnApplySetting);
            this.Controls.Add(this.cmbCountryName);
            this.Controls.Add(this.lstCityName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingForm";
            this.Text = "Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCityName;
        private System.Windows.Forms.ComboBox cmbCountryName;
        private System.Windows.Forms.Button btnApplySetting;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}