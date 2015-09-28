namespace Clover
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.lnkCopyright = new MetroFramework.Controls.MetroLink();
            this.tbGeneral = new MetroFramework.Controls.MetroTabPage();
            this.tbAbout = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.tbGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcLogo
            // 
            this.pcLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcLogo.Image")));
            this.pcLogo.Location = new System.Drawing.Point(50, 67);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(204, 193);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLogo.TabIndex = 0;
            this.pcLogo.TabStop = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tbGeneral);
            this.metroTabControl1.Controls.Add(this.tbAbout);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 278);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(261, 114);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // lnkCopyright
            // 
            this.lnkCopyright.Location = new System.Drawing.Point(113, 398);
            this.lnkCopyright.Name = "lnkCopyright";
            this.lnkCopyright.Size = new System.Drawing.Size(171, 23);
            this.lnkCopyright.TabIndex = 2;
            this.lnkCopyright.Text = "Copyright © 2015, Scarecrow";
            this.lnkCopyright.UseSelectable = true;
            // 
            // tbGeneral
            // 
            this.tbGeneral.Controls.Add(this.metroButton1);
            this.tbGeneral.Controls.Add(this.metroTextBox1);
            this.tbGeneral.Controls.Add(this.metroLabel1);
            this.tbGeneral.HorizontalScrollbarBarColor = true;
            this.tbGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tbGeneral.HorizontalScrollbarSize = 10;
            this.tbGeneral.Location = new System.Drawing.Point(4, 38);
            this.tbGeneral.Name = "tbGeneral";
            this.tbGeneral.Size = new System.Drawing.Size(253, 72);
            this.tbGeneral.TabIndex = 0;
            this.tbGeneral.Text = "General";
            this.tbGeneral.VerticalScrollbarBarColor = true;
            this.tbGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tbGeneral.VerticalScrollbarSize = 10;
            // 
            // tbAbout
            // 
            this.tbAbout.HorizontalScrollbarBarColor = true;
            this.tbAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.tbAbout.HorizontalScrollbarSize = 10;
            this.tbAbout.Location = new System.Drawing.Point(4, 38);
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.Size = new System.Drawing.Size(253, 72);
            this.tbAbout.TabIndex = 1;
            this.tbAbout.Text = "About";
            this.tbAbout.VerticalScrollbarBarColor = true;
            this.tbAbout.VerticalScrollbarHighlightOnWheel = false;
            this.tbAbout.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Search";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(57, 10);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(193, 23);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(166, 39);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(84, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Search";
            this.metroButton1.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 433);
            this.Controls.Add(this.lnkCopyright);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.pcLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "Clover";
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.tbGeneral.ResumeLayout(false);
            this.tbGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcLogo;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tbGeneral;
        private MetroFramework.Controls.MetroLink lnkCopyright;
        private MetroFramework.Controls.MetroTabPage tbAbout;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

