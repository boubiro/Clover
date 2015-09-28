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
            this.tabMainForm = new MetroFramework.Controls.MetroTabControl();
            this.lnkCopyright = new MetroFramework.Controls.MetroLink();
            this.tbGeneral = new MetroFramework.Controls.MetroTabPage();
            this.tbAbout = new MetroFramework.Controls.MetroTabPage();
            this.lblSearch = new MetroFramework.Controls.MetroLabel();
            this.txtMovieName = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.tabMainForm.SuspendLayout();
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
            // tabMainForm
            // 
            this.tabMainForm.Controls.Add(this.tbGeneral);
            this.tabMainForm.Controls.Add(this.tbAbout);
            this.tabMainForm.Location = new System.Drawing.Point(23, 278);
            this.tabMainForm.Name = "tabMainForm";
            this.tabMainForm.SelectedIndex = 0;
            this.tabMainForm.Size = new System.Drawing.Size(261, 114);
            this.tabMainForm.TabIndex = 1;
            this.tabMainForm.UseSelectable = true;
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
            this.tbGeneral.Controls.Add(this.btnSearch);
            this.tbGeneral.Controls.Add(this.txtMovieName);
            this.tbGeneral.Controls.Add(this.lblSearch);
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
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 11);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 19);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // txtMovieName
            // 
            // 
            // 
            // 
            this.txtMovieName.CustomButton.Image = null;
            this.txtMovieName.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtMovieName.CustomButton.Name = "";
            this.txtMovieName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMovieName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMovieName.CustomButton.TabIndex = 1;
            this.txtMovieName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMovieName.CustomButton.UseSelectable = true;
            this.txtMovieName.CustomButton.Visible = false;
            this.txtMovieName.Lines = new string[0];
            this.txtMovieName.Location = new System.Drawing.Point(57, 10);
            this.txtMovieName.MaxLength = 32767;
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.PasswordChar = '\0';
            this.txtMovieName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMovieName.SelectedText = "";
            this.txtMovieName.SelectionLength = 0;
            this.txtMovieName.SelectionStart = 0;
            this.txtMovieName.Size = new System.Drawing.Size(193, 23);
            this.txtMovieName.TabIndex = 3;
            this.txtMovieName.UseSelectable = true;
            this.txtMovieName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMovieName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(166, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 433);
            this.Controls.Add(this.lnkCopyright);
            this.Controls.Add(this.tabMainForm);
            this.Controls.Add(this.pcLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "Clover";
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.tabMainForm.ResumeLayout(false);
            this.tbGeneral.ResumeLayout(false);
            this.tbGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcLogo;
        private MetroFramework.Controls.MetroTabControl tabMainForm;
        private MetroFramework.Controls.MetroTabPage tbGeneral;
        private MetroFramework.Controls.MetroLink lnkCopyright;
        private MetroFramework.Controls.MetroTabPage tbAbout;
        private MetroFramework.Controls.MetroTextBox txtMovieName;
        private MetroFramework.Controls.MetroLabel lblSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
    }
}

