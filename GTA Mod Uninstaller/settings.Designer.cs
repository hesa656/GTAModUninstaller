namespace GTA_Mod_Uninstaller
{
    partial class settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.back_bttn = new System.Windows.Forms.PictureBox();
            this.gtadir_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.copyto_txt = new System.Windows.Forms.TextBox();
            this.select_bttn = new System.Windows.Forms.Button();
            this.select2_bttn = new System.Windows.Forms.Button();
            this.reset_app_bttn = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog_temp = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.back_bttn)).BeginInit();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_bttn
            // 
            this.back_bttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_bttn.Image = global::GTA_Mod_Uninstaller.Properties.Resources.icons8_Back_64px;
            this.back_bttn.Location = new System.Drawing.Point(3, 3);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(25, 25);
            this.back_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_bttn.TabIndex = 17;
            this.back_bttn.TabStop = false;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click);
            // 
            // gtadir_txt
            // 
            this.gtadir_txt.Location = new System.Drawing.Point(0, 34);
            this.gtadir_txt.Name = "gtadir_txt";
            this.gtadir_txt.Size = new System.Drawing.Size(438, 22);
            this.gtadir_txt.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "GTA V Directory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Copy MOD files to";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copyto_txt
            // 
            this.copyto_txt.Location = new System.Drawing.Point(0, 121);
            this.copyto_txt.Name = "copyto_txt";
            this.copyto_txt.Size = new System.Drawing.Size(438, 22);
            this.copyto_txt.TabIndex = 20;
            // 
            // select_bttn
            // 
            this.select_bttn.Location = new System.Drawing.Point(0, 62);
            this.select_bttn.Name = "select_bttn";
            this.select_bttn.Size = new System.Drawing.Size(438, 23);
            this.select_bttn.TabIndex = 22;
            this.select_bttn.Text = "SELECT";
            this.select_bttn.UseVisualStyleBackColor = true;
            this.select_bttn.Click += new System.EventHandler(this.select_bttn_Click);
            // 
            // select2_bttn
            // 
            this.select2_bttn.Location = new System.Drawing.Point(0, 149);
            this.select2_bttn.Name = "select2_bttn";
            this.select2_bttn.Size = new System.Drawing.Size(438, 23);
            this.select2_bttn.TabIndex = 23;
            this.select2_bttn.Text = "SELECT";
            this.select2_bttn.UseVisualStyleBackColor = true;
            this.select2_bttn.Click += new System.EventHandler(this.select2_bttn_Click);
            // 
            // reset_app_bttn
            // 
            this.reset_app_bttn.Location = new System.Drawing.Point(553, 368);
            this.reset_app_bttn.Name = "reset_app_bttn";
            this.reset_app_bttn.Size = new System.Drawing.Size(75, 23);
            this.reset_app_bttn.TabIndex = 24;
            this.reset_app_bttn.Text = "Reset App";
            this.reset_app_bttn.UseVisualStyleBackColor = true;
            this.reset_app_bttn.Click += new System.EventHandler(this.reset_app_bttn_Click);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.gtadir_txt);
            this.panel_main.Controls.Add(this.select2_bttn);
            this.panel_main.Controls.Add(this.select_bttn);
            this.panel_main.Controls.Add(this.copyto_txt);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Location = new System.Drawing.Point(93, 102);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(438, 174);
            this.panel_main.TabIndex = 25;
            // 
            // folderBrowserDialog_temp
            // 
            this.folderBrowserDialog_temp.HelpRequest += new System.EventHandler(this.folderBrowserDialog_temp_HelpRequest);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.reset_app_bttn);
            this.Controls.Add(this.back_bttn);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Name = "settings";
            this.Size = new System.Drawing.Size(631, 394);
            this.Load += new System.EventHandler(this.settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back_bttn)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox back_bttn;
        private System.Windows.Forms.TextBox gtadir_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox copyto_txt;
        private System.Windows.Forms.Button select_bttn;
        private System.Windows.Forms.Button select2_bttn;
        private System.Windows.Forms.Button reset_app_bttn;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_temp;
    }
}
