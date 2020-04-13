using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_Mod_Uninstaller
{
    public partial class Form1 : Form
    {
        Properties.Settings sett = new Properties.Settings();
        string[] files;
        int goodFiles;
        int badFiles;
        bool GTAExe;
        List<string> originalList = new List<string> { "bink2w64.dll", "common.rpf", "d3dcompiler_46.dll", "d3dcsx_46.dll", "GFSDK_ShadowLib.win64.dll", "GFSDK_TXAA.win64.dll", "GFSDK_TXAA_AlphaResolve.win64.dll", "GPUPerfAPIDX11-x64.dll", "GTA5.exe", "GTAVLanguageSelect.exe", "GTAVLauncher.exe", "index.bin", "NvPmApi.Core.win64.dll", "PlayGTAV.exe", "version.txt", "x64a.rpf", "x64b.rpf", "x64c.rpf", "x64d.rpf", "x64e.rpf", "x64f.rpf", "x64g.rpf", "x64h.rpf", "x64i.rpf", "x64j.rpf", "x64k.rpf", "x64l.rpf", "x64m.rpf", "x64n.rpf", "x64o.rpf", "x64p.rpf", "x64q.rpf", "x64r.rpf", "x64s.rpf", "x64t.rpf", "x64u.rpf", "x64v.rpf", "x64w.rpf" };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (sett.gtaPath == "")
            {
                if (MessageBox.Show("Let me know Your GTA V Folder.\nDo You wanna do this now?", "GTA V Folder", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string[] fileTemp = Directory.GetFiles(folderBrowserDialog.SelectedPath);

                        for (int a = 0; a < fileTemp.Length; a++)
                        {
                            string fileName = Path.GetFileName(fileTemp[a]);

                            if (fileName.Contains("GTA5.exe"))
                            {
                                Console.WriteLine("GTA5.exe Finded!");
                                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"GTAUninstaller\" + "TempFiles");
                                sett.copyToPath = AppDomain.CurrentDomain.BaseDirectory + @"GTAUninstaller\" + "TempFiles";
                                sett.gtaPath = folderBrowserDialog.SelectedPath;
                                sett.Save();
                                settings1.Hide();
                                GTAExe = true;
                                Success();
                                return;
                            }
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                Console.WriteLine(Environment.SpecialFolder.MyDocuments + @"GTAUninstaller\" + "TempFiles");
                LoadListView();
                settings1.Hide();
            }

            if (listview_lv.Controls.Count == 0)
            {
                if (MessageBox.Show("List it's empty!\nAre you sure that you give valid GTA V Folder?\nReset App Data.", "Hmmm...", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    sett.gtaPath = "";
                    Application.Exit();
                }
            }
        }

        public void LoadListView()
        {
            bad_files_checkbox.Items.Clear();
            good_files_checkbox.Items.Clear();
            files = Directory.GetFiles(sett.gtaPath);
            ListItem_custom[] listItems = new ListItem_custom[files.Length];

            goodFiles = 0;
            badFiles = 0;
            for (int i = 0; i < files.Length; i++)
            {
                ListItem_custom li = new ListItem_custom();

                listItems[i] = li = new ListItem_custom();
                listItems[i].Title = Path.GetFileName(files[i]).TrimEnd();
                Console.WriteLine("");
                try
                {
                    if (!originalList.Any(w => Path.GetFileName(files[i]).Contains(w)))
                    {
                        Console.WriteLine("Bad");
                        badFiles = badFiles + 1;
                        listItems[i].wrongFile = true;
                        listItems[i].BackColor = Color.DarkRed;
                        bad_files_checkbox.Items.Add(listItems[i].Title);
                    }
                    else
                    {
                        Console.WriteLine("Good");
                        goodFiles = goodFiles + 1;
                        listItems[i].wrongFile = false;
                        listItems[i].BackColor = Color.Green;
                        good_files_checkbox.Items.Add(listItems[i].Title);
                    }

                    listview_lv.Controls.Add(listItems[i]);
                }
                catch
                {

                }



                Console.WriteLine("Item Lists: " + i);
                Console.WriteLine("Max originalList: " + originalList.Count);
                Console.WriteLine("");
                //Thread.Sleep(100);
            }
            good_txt.Text = "Good Files: " + goodFiles;
            bad_txt.Text = "Bad Files: " + badFiles;
        }

        private void sett_bttn_Click(object sender, EventArgs e)
        {
            //sett.gtaPath = "";
            //sett.Save();
            //Application.Exit();
            settings1.BringToFront();
            settings.Instance.PnlContainerInfo.Controls["gtadir_txt"].Text = sett.gtaPath;
            settings.Instance.PnlContainerInfo.Controls["copyto_txt"].Text = sett.copyToPath;
            settings1.Show();
        }

        private void FocusPage() //On first app run - when we select GTAV dir, GTA Mod Uninstaller lost Focus
        {
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        public void Success() //Public because we want to access this event from Setting's form where we want to "Refresh" files (ex. When we want to set another GTAV dir).
        {
            sett.gtaPath = folderBrowserDialog.SelectedPath;
            LoadListView();
            FocusPage();
            sett.Save();
            good_txt.Text = "Good Files: " + goodFiles;
            bad_txt.Text = "Bad Files: " + badFiles;
        }

        private void delete_bttn_Click(object sender, EventArgs e)
        {
            ListItem_custom[] listItems = new ListItem_custom[files.Length];

            if (bad_files_checkbox.CheckedItems.Count == 0)
            {
                for (int i = 0; i <= listItems.Length - 1; i++)
                {
                    if (listItems[i].wrongFile == true)
                    {
                        Console.WriteLine("LLL");
                        File.Delete(sett.gtaPath + "/" + listItems[i].Title);
                    }
                }
            }
            else
            {
                for (int i = 0; i < bad_files_checkbox.CheckedItems.Count; i++)
                {

                    File.Delete(sett.gtaPath + "/" + bad_files_checkbox.CheckedItems[i]);
                }
            }
            listview_lv.Visible = false;
            LoadListView();
        }

        private void copy_to_another_bttn_Click(object sender, EventArgs e)
        {
            ListItem_custom[] listItems = new ListItem_custom[files.Length];

            if (bad_files_checkbox.CheckedItems.Count == 0)
            {
                for (int i = 0; i <= listItems.Length-1; i++)
                {
                    ListItem_custom li = new ListItem_custom();
                    listItems[i] = li = new ListItem_custom();

                    if (listItems[i].wrongFile == true)
                    {
                        Console.WriteLine(sett.gtaPath + "/" + listItems[i].Title, sett.copyToPath + @"\" + listItems[i].Title);
                        File.Move(sett.gtaPath + "/" + listItems[i].Title, sett.copyToPath + @"\" + listItems[i].Title);
                        if (File.Exists(sett.gtaPath + "/" + listItems[i].Title))
                        {
                            File.Delete(sett.gtaPath + "/" + listItems[i].Title);
                        }
                        LoadListView();
                    }
                }
            }
            else
            {
                for (int i = 0; i < bad_files_checkbox.CheckedItems.Count; i++)
                {
                    File.Move(sett.gtaPath + "/" + bad_files_checkbox.CheckedItems[i], sett.copyToPath + @"\" + bad_files_checkbox.CheckedItems[i]);
                    if (File.Exists(sett.gtaPath + "/" + bad_files_checkbox.CheckedItems[i]))
                    {
                        File.Delete(sett.gtaPath + "/" + bad_files_checkbox.CheckedItems[i]);
                    }
                }
                LoadListView();
            }
        }
        private void copy_to_gta_bttn_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(sett.copyToPath);
            Console.WriteLine(files[0] + " Move To " + sett.gtaPath + @"\" + Path.GetFileName(files[0]));
            for (int i = 0; i < files.Length; i++)
            {

                File.Move(files[i], sett.gtaPath + @"\" + Path.GetFileName(files[i]));
                if (File.Exists(files[i]))
                {
                    File.Delete(files[i]);
                }

                Console.WriteLine(files[i]);

            }
            LoadListView();
        }

        private void bad_files_checkbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            count(bad_files_checkbox.CheckedItems.Count + good_files_checkbox.CheckedItems.Count);
        }
        private void good_files_checkbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            count(bad_files_checkbox.CheckedItems.Count + good_files_checkbox.CheckedItems.Count);
        }

        private void count(int counter)
        {
            if (counter != 0)
            {
                delete_bttn.Text = "Delete (" + counter + ")";
            }
            else
            {
                delete_bttn.Text = "Delete";
            }
        }

        private void slct_all_orig_check_CheckedChanged(object sender, EventArgs e)
        {
            if (slct_all_orig_check.Checked == true)
            {
                for (int i = 0; i < good_files_checkbox.Items.Count; i++)
                {
                    good_files_checkbox.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < good_files_checkbox.Items.Count; i++)
                {
                    good_files_checkbox.SetItemChecked(i, false);
                }
            }
            count(bad_files_checkbox.CheckedItems.Count + good_files_checkbox.CheckedItems.Count);
        }

        private void slct_all_bad_check_CheckedChanged(object sender, EventArgs e)
        {
            if (slct_all_bad_check.Checked == true)
            {
                for (int i = 0; i < bad_files_checkbox.Items.Count; i++)
                {
                    bad_files_checkbox.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < bad_files_checkbox.Items.Count; i++)
                {
                    bad_files_checkbox.SetItemChecked(i, false);
                }
            }
            count(bad_files_checkbox.CheckedItems.Count + good_files_checkbox.CheckedItems.Count);
        }
    }
}
