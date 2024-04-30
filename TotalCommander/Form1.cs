using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalCommander
{
    public partial class Form1 : Form
    {
        private DriveInfo[] drives;
        private bool Hidden = true;
        private DirectoryInfo currentLeft;
        private DirectoryInfo currentRight;
        private ListViewItem[] copyItems = new ListViewItem[20];

        public Form1()
        {
            InitializeComponent();
            DirectoryInfo temp = new DirectoryInfo(Properties.Settings.Default.DefaultDir);
            currentLeft = temp;
            currentRight = temp;
            toolStripTextBox1.Text = Properties.Settings.Default.DefaultDir;
            BackColor = Properties.Settings.Default.DefaultColor;
            toolStrip1.BackColor = Properties.Settings.Default.DefaultColor;
            listViewLeft.Font = Properties.Settings.Default.DefaultFont;
            listViewRight.Font = Properties.Settings.Default.DefaultFont;
            RefreshDir();
        }

        void CopyDir(string FromDir, string ToDir)
        {
            DirectoryInfo fromdir = new DirectoryInfo(FromDir);
            DirectoryInfo todir = new DirectoryInfo(ToDir);
            while (true)
            {
                if (!todir.Exists)
                {
                    todir.Create();
                }
                FileInfo[] fls = fromdir.GetFiles();
                if (fls.Length > 0)
                    foreach (FileInfo fi in fls)
                        fi.CopyTo(todir.FullName.ToString() + "\\" + fi.Name.ToString(), true);
                DirectoryInfo[] dirs = fromdir.GetDirectories();
                if (dirs.Length > 0)
                {
                    foreach (DirectoryInfo di in dirs)
                    {
                        DirectoryInfo dir = new DirectoryInfo(todir.FullName.ToString() + "\\" + di.Name.ToString());
                        CopyDir(di.FullName, dir.FullName);
                    }
                    break;
                }
                else break;
            }
        }

        private void RefreshDir()
        {
            if (currentLeft != null)
                Load_Directory((DirectoryInfo)currentLeft, listViewLeft, tbleft, Hidden);

            if (currentRight != null)
                Load_Directory((DirectoryInfo)currentRight, listViewRight, tbright, Hidden);
        }

        private void Load_Directory(DirectoryInfo dirs, ListView listView, TextBox tb, bool Hidden)   //LOAD THE DIRECTORY INTO LISTVIEW
        {
            try
            {
                listView.Items.Clear();
                var dirList = dirs.GetDirectories();
                var fileList = dirs.GetFiles();
                ListViewItem list1 = new ListViewItem();
                list1.Text = "...";
                list1.Tag = true;
                listView.Items.Add(list1);

                foreach (var dir in dirList)
                {
                    if (Hidden == true)
                    {
                        if (dir.Attributes.ToString().Contains("Hidden"))
                            continue;
                    }

                    ListViewItem list = new ListViewItem();
                    list.Text = dir.Name;
                    list.SubItems.Add("Folder");
                    list.SubItems.Add(dir.CreationTime.ToString());
                    list.SubItems.Add("");
                    list.Tag = dir;
                    listView.Items.Add(list);
                }

                foreach (var file in fileList)
                {
                    if (Hidden == true)
                    {
                        if (file.Attributes.ToString().Contains("Hidden"))
                            continue;
                    }

                    ListViewItem list = new ListViewItem();
                    list.Text = file.Name;
                    list.SubItems.Add("File");
                    list.SubItems.Add(file.CreationTime.ToString());
                    list.SubItems.Add($"{(float)(file.Length / 1024)} KB");
                    list.Tag = file;
                    listView.Items.Add(list);
                }
                tb.Text = dirs.FullName;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private void Delete_files(DirectoryInfo dirs, ListViewItem listtemp, TextBox tb)
        {
            if (listtemp.Tag is true)
                MessageBox.Show("Directory not exist !!", "ERRORS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (listtemp.Tag is DirectoryInfo)
                {
                    DirectoryInfo temp = (DirectoryInfo)listtemp.Tag;
                    if (temp.Exists)
                    {
                        temp.Delete(true);
                    }
                }
                else
                {
                    FileInfo temp = (FileInfo)listtemp.Tag;
                    if (temp.Exists)
                        temp.Delete();
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------

        private void cbleft_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbleft.SelectedIndex >= 0)
            {
                Load_Directory((DirectoryInfo)drives[cbleft.SelectedIndex].RootDirectory, listViewLeft, tbleft, Hidden);
                currentLeft = (DirectoryInfo)drives[cbleft.SelectedIndex].RootDirectory;
            }
        }  //CHANGE DRIVE LEFT WINDOW

        private void cbright_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbright.SelectedIndex >= 0)
            {
                Load_Directory((DirectoryInfo)drives[cbright.SelectedIndex].RootDirectory, listViewRight, tbright, Hidden);
                currentRight = (DirectoryInfo)drives[cbright.SelectedIndex].RootDirectory;
            }
        } //CHANGE DRIVE RIGHT WINDOW

        private void Form1_Load(object sender, EventArgs e)
        {

            drives = DriveInfo.GetDrives();
            if (copyItems == null)
            {
            }
            foreach (var drive in drives)
            {
                cbleft.Items.Add(drive);
                cbright.Items.Add(drive);
            }
        }

        private void listViewLeft_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem list in listViewLeft.SelectedItems)
            {
                if (list.Tag is FileInfo)
                {
                    FileInfo temp = (FileInfo)list.Tag;
                    if (temp.Exists)
                    {
                        Process.Start(temp.FullName);
                    }
                    else MessageBox.Show("File don't exist !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (list.Tag is true)
                {
                    if (currentLeft != null && currentLeft.Parent != null)
                    {
                        Load_Directory((DirectoryInfo)currentLeft.Parent, listViewLeft, tbleft, Hidden);
                        currentLeft = (DirectoryInfo)currentLeft.Parent;
                    }
                }
                if (list.Tag is DirectoryInfo)
                {
                    Load_Directory((DirectoryInfo)list.Tag, listViewLeft, tbleft, Hidden);
                    currentLeft = (DirectoryInfo)list.Tag;
                }
            }
        } //DOUBLE CLICK ON ITEM OF WINDOW LEFT

        private void listViewRight_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem list in listViewRight.SelectedItems)
            {
                if (list.Tag is FileInfo)
                {
                    FileInfo temp = (FileInfo)list.Tag;
                    if (temp.Exists)
                    {
                        Process.Start(temp.FullName);
                    }
                    else MessageBox.Show("File don't exist !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (list.Tag is true)
                {
                    if (currentRight != null && currentRight.Parent != null)
                    {
                        Load_Directory((DirectoryInfo)currentRight.Parent, listViewRight, tbright, Hidden);
                        currentRight = (DirectoryInfo)currentRight.Parent;
                    }
                }
                if (list.Tag is DirectoryInfo)
                {
                    Load_Directory((DirectoryInfo)list.Tag, listViewRight, tbright, Hidden);
                    currentRight = (DirectoryInfo)list.Tag;
                }
            }
        } //DOUBLE CLICK ON ITEM OF WINDOW RIGHT

        private void DeleteToolStrip_Click(object sender, EventArgs e)
        {
            if (listViewLeft.SelectedItems.Count != 0)
            {
                DialogResult answer = MessageBox.Show("Do you want to delete !!!", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    foreach (ListViewItem listtemp in listViewLeft.SelectedItems)
                    {
                        new Thread(() => Delete_files(currentLeft, listtemp, tbleft)).Start();
                    }
                }
            }
            if (listViewRight.SelectedItems.Count != 0)
            {
                DialogResult answer = MessageBox.Show("Do you want to delete !!!", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    foreach (ListViewItem listtemp in listViewRight.SelectedItems)
                    {
                        new Thread(() => Delete_files(currentRight, listtemp, tbright)).Start();
                    }
                }
            }
            RefreshDir();

        }

        private void CreateFile(object sender, EventArgs e)
        {
            if (listViewLeft.Focused)
            {
                string path = tbleft.Text;
                if (tbleft.Text.Length > 3)
                {
                    path += "\\NewFile.txt";
                }
                if (tbleft.Text.Length == 3)
                {
                    path += "NewFile.txt";
                }
                try
                {
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes("");
                        fs.Write(info, 0, info.Length);
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            if (listViewRight.Focused)
            {
                string path = tbright.Text;
                if (tbright.Text.Length > 3)
                {
                    path += "\\NewFile.txt";
                }
                if (tbright.Text.Length == 3)
                {
                    path += "NewFile.txt";
                }
                try
                {
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes("");
                        fs.Write(info, 0, info.Length);
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            RefreshDir();
        }

        private void CreateDir(object sender, EventArgs e)
        {
            if (listViewLeft.Focused)
            {
                string path = tbleft.Text;
                if (tbleft.Text.Length > 3)
                {
                    path += "\\NewFolder";
                }
                if (tbleft.Text.Length == 3)
                {
                    path += "NewFolder";
                }
                Directory.CreateDirectory(path);
            }
            if (listViewRight.Focused)
            {
                string path = tbright.Text;
                if (tbright.Text.Length > 3)
                {
                    path += "\\NewFolder";
                }
                if (tbright.Text.Length == 3)
                {
                    path += "NewFolder";
                }
                Directory.CreateDirectory(path);
            }
            RefreshDir();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshDir();
        }

        private void Copy(object sender, EventArgs e)
        {
            if (listViewLeft.Focused)
            {
                foreach (ListViewItem listtemp in listViewLeft.SelectedItems)
                {
                    if (listtemp.Tag is true)
                        MessageBox.Show("Directory not exist !!", "ERRORS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (listtemp.Tag is DirectoryInfo)
                        {
                            DirectoryInfo temp = (DirectoryInfo)listtemp.Tag;
                            new Thread(() => CopyDir(temp.FullName, tbright.Text + "\\" + temp.Name)).Start();
                        }
                        else
                        {
                            FileInfo temp1 = (FileInfo)listtemp.Tag;
                            if (temp1.Exists)
                                new Thread(() => temp1.CopyTo(tbright.Text + "\\" + temp1.Name.ToString(), true)).Start();
                        }
                    }
                }
            }
            if (listViewRight.Focused)
            {
                foreach (ListViewItem listtemp in listViewRight.SelectedItems)
                {
                    if (listtemp.Tag is true)
                        MessageBox.Show("Directory not exist !!", "ERRORS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (listtemp.Tag is DirectoryInfo)
                        {
                            DirectoryInfo temp = (DirectoryInfo)listtemp.Tag;
                            new Thread(() => CopyDir(temp.FullName, tbleft.Text + "\\" + temp.Name)).Start();
                        }
                        else
                        {
                            FileInfo temp1 = (FileInfo)listtemp.Tag;
                            if (temp1.Exists)
                                new Thread(() => temp1.CopyTo(tbleft.Text + "\\" + temp1.Name.ToString(), true)).Start();
                        }
                    }
                }
            }
            RefreshDir();
        }

        private void Rename(object sender, EventArgs e)
        {
            if (listViewLeft.Focused)
            {
                if (listViewLeft.SelectedItems.Count == 1 && listViewLeft.SelectedItems[0].Text != "...")
                {
                    listViewLeft.SelectedItems[0].BeginEdit();
                }
            }
            if (listViewRight.Focused)
            {
                if (listViewRight.SelectedItems.Count == 1 && listViewRight.SelectedItems[0].Text != "...")
                {
                    listViewRight.SelectedItems[0].BeginEdit();
                }
            }
        }

        private void AfterRenameLeft(object sender, LabelEditEventArgs e)
        {
            try
            {
                ListViewItem temp = listViewLeft.SelectedItems[0];
                if (temp.Tag is DirectoryInfo)
                {
                    DirectoryInfo dir = (DirectoryInfo)temp.Tag;
                    if (e.Label != null)
                    {
                        Directory.Move(dir.FullName, dir.FullName.Replace(dir.Name, e.Label));
                    }
                }
                if (temp.Tag is FileInfo)
                {
                    FileInfo file = (FileInfo)temp.Tag;
                    if (e.Label != null)
                    {
                        File.Move(file.FullName, file.FullName.Replace(file.Name, e.Label));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл с таким именем уже существует!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            RefreshDir();
        }

        private void AfterRenameRight(object sender, LabelEditEventArgs e)
        {
            try
            {
                ListViewItem temp = listViewRight.SelectedItems[0];
            if (temp.Tag is DirectoryInfo)
            {
                DirectoryInfo dir = (DirectoryInfo)temp.Tag;
                if (e.Label != null)
                {
                    Directory.Move(dir.FullName, dir.FullName.Replace(dir.Name, e.Label));
                }
            }
            if (temp.Tag is FileInfo)
            {
                FileInfo file = (FileInfo)temp.Tag;
                if (e.Label != null)
                {
                    File.Move(file.FullName, file.FullName.Replace(file.Name, e.Label));
                }
            }
            }
            catch
            {
                MessageBox.Show("Файл с таким именем уже существует!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            RefreshDir();
        }

        private void prop(object sender, EventArgs e)
        {
            if (listViewLeft.SelectedItems.Count == 1 && listViewLeft.SelectedItems[0].Text != "...")
            {
                FileInfo temp = (FileInfo)listViewLeft.SelectedItems[0].Tag;
                var path = temp.FullName;
                var dir = Path.GetDirectoryName(path);
                var file = Path.GetFileName(path);

                var shell = new Shell32.Shell();
                var folder = shell.NameSpace(dir);
                var folderItem = folder.ParseName(file);

                var names =
                    (from idx in Enumerable.Range(0, short.MaxValue)
                     let key = folder.GetDetailsOf(null, idx)
                     where !string.IsNullOrEmpty(key)
                     select (idx, key)).ToDictionary(p => p.idx, p => p.key);

                var properties =
                    (from idx in names.Keys
                     orderby idx
                     let value = folder.GetDetailsOf(folderItem, idx)
                     where !string.IsNullOrEmpty(value)
                     select (name: names[idx], value)).ToList();
                Form2 form2 = new Form2();
                foreach (var kvp in properties)
                    Data.text += kvp.name + " : " + kvp.value + "\n";
                form2.ShowDialog();
            }
            if (listViewRight.SelectedItems.Count == 1 && listViewRight.SelectedItems[0].Text != "...")
            {
                FileInfo temp = (FileInfo)listViewRight.SelectedItems[0].Tag;
                var path = temp.FullName;
                var dir = Path.GetDirectoryName(path);
                var file = Path.GetFileName(path);

                var shell = new Shell32.Shell();
                var folder = shell.NameSpace(dir);
                var folderItem = folder.ParseName(file);

                var names =
                    (from idx in Enumerable.Range(0, short.MaxValue)
                     let key = folder.GetDetailsOf(null, idx)
                     where !string.IsNullOrEmpty(key)
                     select (idx, key)).ToDictionary(p => p.idx, p => p.key);

                var properties =
                    (from idx in names.Keys
                     orderby idx
                     let value = folder.GetDetailsOf(folderItem, idx)
                     where !string.IsNullOrEmpty(value)
                     select (name: names[idx], value)).ToList();
                Form2 form2 = new Form2();
                foreach (var kvp in properties)
                    Data.text += kvp.name + " : " + kvp.value + "\n";
                form2.ShowDialog();
            }
        }

        private void FontChange(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DefaultFont = fontDialog1.Font;
                listViewLeft.Font = fontDialog1.Font;
                listViewRight.Font = fontDialog1.Font;
            }
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DefaultColor = colorDialog1.Color;
                BackColor = colorDialog1.Color;
                toolStrip1.BackColor = colorDialog1.Color;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultDir = toolStripTextBox1.Text;
        }
    }
}
