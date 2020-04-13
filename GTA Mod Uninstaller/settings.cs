using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace GTA_Mod_Uninstaller
{
    public partial class settings : UserControl
    {
        Properties.Settings sett = new Properties.Settings();
        static settings _obj;

        public static settings Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new settings();
                }
                return _obj;
            }
        }

        public Panel PnlContainerInfo
        {
            get { return panel_main; }
            set { panel_main = value; }
        }

        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            _obj = this;
            gtadir_txt.Text = sett.gtaPath;
            copyto_txt.Text = sett.copyToPath;
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Hide();
            Form1 form = new Form1();
            form.LoadListView();
        }

        private void reset_app_bttn_Click(object sender, EventArgs e)
        {
            sett.copyToPath = "";
            sett.gtaPath = "";
            sett.Save();
            Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

        private void select_bttn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = sett.gtaPath;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fileTemp = Directory.GetFiles(folderBrowserDialog.SelectedPath);

                for (int a = 0; a < fileTemp.Length; a++)
                {
                    string fileName = Path.GetFileName(fileTemp[a]);

                    if (fileName.Contains("GTA5.exe"))
                    {
                        Console.WriteLine("GTA5.exe Finded!");
                        sett.gtaPath = folderBrowserDialog.SelectedPath;
                        gtadir_txt.Text = folderBrowserDialog.SelectedPath;
                        sett.Save();
                        Form1 form = new Form1();
                        form.Success();
                        RestartRequired();
                        return;
                    }
                    else if (a == fileTemp.Length - 1)
                    {
                        MessageBox.Show("We don't find GTAV.exe!", "Ups...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void select2_bttn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_temp.ShowDialog() == DialogResult.OK)
            {
                sett.copyToPath = folderBrowserDialog_temp.SelectedPath;
                sett.Save();
                copyto_txt.Text = folderBrowserDialog_temp.SelectedPath;
                RestartRequired();
            }
        }

        private void folderBrowserDialog_temp_HelpRequest(object sender, EventArgs e)
        {

        }

        private void RestartRequired()
        {
            if (MessageBox.Show("We need to restart App!\nApp start automatically after this window close.", "Restart Required!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }
    }
}
