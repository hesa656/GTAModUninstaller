namespace GTA_Mod_Uninstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.listview_lv = new System.Windows.Forms.FlowLayoutPanel();
            this.good_txt = new System.Windows.Forms.Label();
            this.bad_txt = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.good_files_checkbox = new System.Windows.Forms.CheckedListBox();
            this.bad_files_checkbox = new System.Windows.Forms.CheckedListBox();
            this.slct_all_bad_check = new System.Windows.Forms.CheckBox();
            this.slct_all_orig_check = new System.Windows.Forms.CheckBox();
            this.copy_to_another_bttn = new System.Windows.Forms.Button();
            this.copy_to_gta_bttn = new System.Windows.Forms.Button();
            this.delete_bttn = new System.Windows.Forms.Button();
            this.sett_bttn = new System.Windows.Forms.PictureBox();
            this.settings1 = new GTA_Mod_Uninstaller.settings();
            ((System.ComponentModel.ISupportInitialize)(this.sett_bttn)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // listview_lv
            // 
            this.listview_lv.AutoScroll = true;
            this.listview_lv.Location = new System.Drawing.Point(12, 12);
            this.listview_lv.Name = "listview_lv";
            this.listview_lv.Size = new System.Drawing.Size(249, 370);
            this.listview_lv.TabIndex = 0;
            // 
            // good_txt
            // 
            this.good_txt.AutoSize = true;
            this.good_txt.Location = new System.Drawing.Point(317, 12);
            this.good_txt.Name = "good_txt";
            this.good_txt.Size = new System.Drawing.Size(68, 13);
            this.good_txt.TabIndex = 2;
            this.good_txt.Text = "Good Files: ";
            // 
            // bad_txt
            // 
            this.bad_txt.AutoSize = true;
            this.bad_txt.Location = new System.Drawing.Point(503, 12);
            this.bad_txt.Name = "bad_txt";
            this.bad_txt.Size = new System.Drawing.Size(59, 13);
            this.bad_txt.TabIndex = 3;
            this.bad_txt.Text = "Bad Files: ";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(265, 293);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(354, 10);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(435, 12);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(12, 275);
            this.bunifuSeparator2.TabIndex = 8;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // good_files_checkbox
            // 
            this.good_files_checkbox.FormattingEnabled = true;
            this.good_files_checkbox.Location = new System.Drawing.Point(267, 28);
            this.good_files_checkbox.Name = "good_files_checkbox";
            this.good_files_checkbox.Size = new System.Drawing.Size(170, 242);
            this.good_files_checkbox.TabIndex = 9;
            this.good_files_checkbox.SelectedIndexChanged += new System.EventHandler(this.good_files_checkbox_SelectedIndexChanged);
            // 
            // bad_files_checkbox
            // 
            this.bad_files_checkbox.CheckOnClick = true;
            this.bad_files_checkbox.FormattingEnabled = true;
            this.bad_files_checkbox.Location = new System.Drawing.Point(447, 28);
            this.bad_files_checkbox.Name = "bad_files_checkbox";
            this.bad_files_checkbox.Size = new System.Drawing.Size(172, 242);
            this.bad_files_checkbox.TabIndex = 10;
            this.bad_files_checkbox.SelectedIndexChanged += new System.EventHandler(this.bad_files_checkbox_SelectedIndexChanged);
            // 
            // slct_all_bad_check
            // 
            this.slct_all_bad_check.AutoSize = true;
            this.slct_all_bad_check.Location = new System.Drawing.Point(495, 276);
            this.slct_all_bad_check.Name = "slct_all_bad_check";
            this.slct_all_bad_check.Size = new System.Drawing.Size(72, 17);
            this.slct_all_bad_check.TabIndex = 11;
            this.slct_all_bad_check.Text = "Select All";
            this.slct_all_bad_check.UseVisualStyleBackColor = true;
            this.slct_all_bad_check.CheckedChanged += new System.EventHandler(this.slct_all_bad_check_CheckedChanged);
            // 
            // slct_all_orig_check
            // 
            this.slct_all_orig_check.AutoSize = true;
            this.slct_all_orig_check.Location = new System.Drawing.Point(320, 276);
            this.slct_all_orig_check.Name = "slct_all_orig_check";
            this.slct_all_orig_check.Size = new System.Drawing.Size(72, 17);
            this.slct_all_orig_check.TabIndex = 12;
            this.slct_all_orig_check.Text = "Select All";
            this.slct_all_orig_check.UseVisualStyleBackColor = true;
            this.slct_all_orig_check.CheckedChanged += new System.EventHandler(this.slct_all_orig_check_CheckedChanged);
            // 
            // copy_to_another_bttn
            // 
            this.copy_to_another_bttn.Location = new System.Drawing.Point(267, 302);
            this.copy_to_another_bttn.Name = "copy_to_another_bttn";
            this.copy_to_another_bttn.Size = new System.Drawing.Size(170, 44);
            this.copy_to_another_bttn.TabIndex = 13;
            this.copy_to_another_bttn.Text = "Copy to Another Folder";
            this.copy_to_another_bttn.UseVisualStyleBackColor = true;
            this.copy_to_another_bttn.Click += new System.EventHandler(this.copy_to_another_bttn_Click);
            // 
            // copy_to_gta_bttn
            // 
            this.copy_to_gta_bttn.Location = new System.Drawing.Point(447, 302);
            this.copy_to_gta_bttn.Name = "copy_to_gta_bttn";
            this.copy_to_gta_bttn.Size = new System.Drawing.Size(172, 44);
            this.copy_to_gta_bttn.TabIndex = 14;
            this.copy_to_gta_bttn.Text = "Copy to GTA V Folder";
            this.copy_to_gta_bttn.UseVisualStyleBackColor = true;
            this.copy_to_gta_bttn.Click += new System.EventHandler(this.copy_to_gta_bttn_Click);
            // 
            // delete_bttn
            // 
            this.delete_bttn.Location = new System.Drawing.Point(267, 352);
            this.delete_bttn.Name = "delete_bttn";
            this.delete_bttn.Size = new System.Drawing.Size(352, 30);
            this.delete_bttn.TabIndex = 15;
            this.delete_bttn.Text = "Delete";
            this.delete_bttn.UseVisualStyleBackColor = true;
            this.delete_bttn.Click += new System.EventHandler(this.delete_bttn_Click);
            // 
            // sett_bttn
            // 
            this.sett_bttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sett_bttn.Image = global::GTA_Mod_Uninstaller.Properties.Resources.icons8_Settings_32px;
            this.sett_bttn.Location = new System.Drawing.Point(605, 0);
            this.sett_bttn.Name = "sett_bttn";
            this.sett_bttn.Size = new System.Drawing.Size(25, 25);
            this.sett_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sett_bttn.TabIndex = 16;
            this.sett_bttn.TabStop = false;
            this.sett_bttn.Click += new System.EventHandler(this.sett_bttn_Click);
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.White;
            this.settings1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.settings1.Location = new System.Drawing.Point(3, 0);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(631, 394);
            this.settings1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 394);
            this.Controls.Add(this.sett_bttn);
            this.Controls.Add(this.delete_bttn);
            this.Controls.Add(this.copy_to_gta_bttn);
            this.Controls.Add(this.copy_to_another_bttn);
            this.Controls.Add(this.slct_all_orig_check);
            this.Controls.Add(this.slct_all_bad_check);
            this.Controls.Add(this.bad_files_checkbox);
            this.Controls.Add(this.good_files_checkbox);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bad_txt);
            this.Controls.Add(this.good_txt);
            this.Controls.Add(this.listview_lv);
            this.Controls.Add(this.settings1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GTA V Mod Uninstaller 1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sett_bttn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.FlowLayoutPanel listview_lv;
        private System.Windows.Forms.Label good_txt;
        private System.Windows.Forms.Label bad_txt;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.CheckedListBox good_files_checkbox;
        private System.Windows.Forms.CheckedListBox bad_files_checkbox;
        private System.Windows.Forms.CheckBox slct_all_bad_check;
        private System.Windows.Forms.CheckBox slct_all_orig_check;
        private System.Windows.Forms.Button copy_to_another_bttn;
        private System.Windows.Forms.Button copy_to_gta_bttn;
        private System.Windows.Forms.Button delete_bttn;
        private System.Windows.Forms.PictureBox sett_bttn;
        private settings settings1;
    }
}

