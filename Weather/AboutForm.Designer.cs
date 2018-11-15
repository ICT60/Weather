namespace Weather
{
    partial class AboutForm
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
            this.linkToOpenWeatherMap = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkToOpenWeatherMap
            // 
            this.linkToOpenWeatherMap.AutoSize = true;
            this.linkToOpenWeatherMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkToOpenWeatherMap.Location = new System.Drawing.Point(75, 167);
            this.linkToOpenWeatherMap.Name = "linkToOpenWeatherMap";
            this.linkToOpenWeatherMap.Size = new System.Drawing.Size(233, 20);
            this.linkToOpenWeatherMap.TabIndex = 0;
            this.linkToOpenWeatherMap.TabStop = true;
            this.linkToOpenWeatherMap.Text = "https://openweathermap.org/api";
            this.linkToOpenWeatherMap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToOpenWeatherMap_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Author :\r\nChatchai Saratakij (6002526)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weather Data Provide By :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 248);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkToOpenWeatherMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AboutForm";
            this.Text = "About";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkToOpenWeatherMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}