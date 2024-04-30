namespace TotalCommander
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbleft = new System.Windows.Forms.ComboBox();
            this.listViewLeft = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LeftContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.директориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFolderToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.cbright = new System.Windows.Forms.ComboBox();
            this.listViewRight = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RightContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.директориюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbleft = new System.Windows.Forms.TextBox();
            this.tbright = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.LeftContextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.RightContextMenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbleft
            // 
            this.cbleft.BackColor = System.Drawing.SystemColors.Window;
            this.cbleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbleft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbleft.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbleft.FormattingEnabled = true;
            this.cbleft.Location = new System.Drawing.Point(4, 4);
            this.cbleft.Margin = new System.Windows.Forms.Padding(4);
            this.cbleft.Name = "cbleft";
            this.cbleft.Size = new System.Drawing.Size(69, 24);
            this.cbleft.TabIndex = 0;
            this.cbleft.Text = "Диск";
            this.cbleft.SelectedIndexChanged += new System.EventHandler(this.cbleft_SelectedIndexChanged);
            // 
            // listViewLeft
            // 
            this.listViewLeft.AllowDrop = true;
            this.listViewLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewLeft.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.TypeColumn,
            this.DateColumn,
            this.SizeColumn});
            this.listViewLeft.ContextMenuStrip = this.LeftContextMenuStrip;
            this.listViewLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLeft.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewLeft.FullRowSelect = true;
            this.listViewLeft.HideSelection = false;
            this.listViewLeft.LabelEdit = true;
            this.listViewLeft.Location = new System.Drawing.Point(4, 64);
            this.listViewLeft.Margin = new System.Windows.Forms.Padding(4);
            this.listViewLeft.Name = "listViewLeft";
            this.listViewLeft.Size = new System.Drawing.Size(602, 604);
            this.listViewLeft.TabIndex = 1;
            this.listViewLeft.UseCompatibleStateImageBehavior = false;
            this.listViewLeft.View = System.Windows.Forms.View.Details;
            this.listViewLeft.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.AfterRenameLeft);
            this.listViewLeft.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewLeft_MouseDoubleClick);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 200;
            // 
            // TypeColumn
            // 
            this.TypeColumn.Text = "Type";
            this.TypeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TypeColumn.Width = 80;
            // 
            // DateColumn
            // 
            this.DateColumn.Text = "Date";
            this.DateColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateColumn.Width = 200;
            // 
            // SizeColumn
            // 
            this.SizeColumn.Text = "Size";
            this.SizeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LeftContextMenuStrip
            // 
            this.LeftContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LeftContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.copyToolStripMenuItem1,
            this.renameToolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.propertiesToolStripMenuItem1});
            this.LeftContextMenuStrip.Name = "contextMenuStrip1";
            this.LeftContextMenuStrip.Size = new System.Drawing.Size(191, 124);
            // 
            // New
            // 
            this.New.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.директориюToolStripMenuItem});
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(190, 24);
            this.New.Text = "Создать";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.CreateFile);
            // 
            // директориюToolStripMenuItem
            // 
            this.директориюToolStripMenuItem.Name = "директориюToolStripMenuItem";
            this.директориюToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.директориюToolStripMenuItem.Text = "Директорию";
            this.директориюToolStripMenuItem.Click += new System.EventHandler(this.CreateDir);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(190, 24);
            this.copyToolStripMenuItem1.Text = "Копировать";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.Copy);
            // 
            // renameToolStripMenuItem1
            // 
            this.renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
            this.renameToolStripMenuItem1.Size = new System.Drawing.Size(190, 24);
            this.renameToolStripMenuItem1.Text = "Переименовать";
            this.renameToolStripMenuItem1.Click += new System.EventHandler(this.Rename);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStrip_Click);
            // 
            // propertiesToolStripMenuItem1
            // 
            this.propertiesToolStripMenuItem1.Name = "propertiesToolStripMenuItem1";
            this.propertiesToolStripMenuItem1.Size = new System.Drawing.Size(190, 24);
            this.propertiesToolStripMenuItem1.Text = "Свойства";
            this.propertiesToolStripMenuItem1.Click += new System.EventHandler(this.prop);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1220, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileToolStrip,
            this.NewFolderToolStrip,
            this.CopyToolstrip,
            this.RenameToolStrip,
            this.DeleteToolStrip});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // NewFileToolStrip
            // 
            this.NewFileToolStrip.Name = "NewFileToolStrip";
            this.NewFileToolStrip.Size = new System.Drawing.Size(237, 26);
            this.NewFileToolStrip.Text = "Создать файл";
            this.NewFileToolStrip.Click += new System.EventHandler(this.CreateFile);
            // 
            // NewFolderToolStrip
            // 
            this.NewFolderToolStrip.Name = "NewFolderToolStrip";
            this.NewFolderToolStrip.Size = new System.Drawing.Size(237, 26);
            this.NewFolderToolStrip.Text = "Создать директорию";
            this.NewFolderToolStrip.Click += new System.EventHandler(this.CreateDir);
            // 
            // CopyToolstrip
            // 
            this.CopyToolstrip.Name = "CopyToolstrip";
            this.CopyToolstrip.Size = new System.Drawing.Size(237, 26);
            this.CopyToolstrip.Text = "Копировать";
            this.CopyToolstrip.Click += new System.EventHandler(this.Copy);
            // 
            // RenameToolStrip
            // 
            this.RenameToolStrip.Name = "RenameToolStrip";
            this.RenameToolStrip.Size = new System.Drawing.Size(237, 26);
            this.RenameToolStrip.Text = "Переименовать";
            this.RenameToolStrip.Click += new System.EventHandler(this.Rename);
            // 
            // DeleteToolStrip
            // 
            this.DeleteToolStrip.Name = "DeleteToolStrip";
            this.DeleteToolStrip.Size = new System.Drawing.Size(237, 26);
            this.DeleteToolStrip.Text = "Удалить";
            this.DeleteToolStrip.Click += new System.EventHandler(this.DeleteToolStrip_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorToolStripMenuItem,
            this.fontToolStripMenuItem1,
            this.DirToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.helpToolStripMenuItem.Text = "Вид";
            // 
            // ColorToolStripMenuItem
            // 
            this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            this.ColorToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.ColorToolStripMenuItem.Text = "Цветовая схема";
            this.ColorToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            this.fontToolStripMenuItem1.Size = new System.Drawing.Size(283, 26);
            this.fontToolStripMenuItem1.Text = "Шрифт";
            this.fontToolStripMenuItem1.Click += new System.EventHandler(this.FontChange);
            // 
            // DirToolStripMenuItem
            // 
            this.DirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.DirToolStripMenuItem.Name = "DirToolStripMenuItem";
            this.DirToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.DirToolStripMenuItem.Text = "Директория по умолчанию";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.RefreshButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1220, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.SystemColors.Window;
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(86, 24);
            this.RefreshButton.Text = " Обновить";
            this.RefreshButton.ToolTipText = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // cbright
            // 
            this.cbright.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbright.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbright.FormattingEnabled = true;
            this.cbright.Location = new System.Drawing.Point(614, 4);
            this.cbright.Margin = new System.Windows.Forms.Padding(4);
            this.cbright.Name = "cbright";
            this.cbright.Size = new System.Drawing.Size(83, 24);
            this.cbright.TabIndex = 4;
            this.cbright.Text = "Диск";
            this.cbright.SelectedIndexChanged += new System.EventHandler(this.cbright_SelectedIndexChanged);
            // 
            // listViewRight
            // 
            this.listViewRight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewRight.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewRight.ContextMenuStrip = this.RightContextMenuStrip;
            this.listViewRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRight.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRight.FullRowSelect = true;
            this.listViewRight.HideSelection = false;
            this.listViewRight.LabelEdit = true;
            this.listViewRight.Location = new System.Drawing.Point(614, 64);
            this.listViewRight.Margin = new System.Windows.Forms.Padding(4);
            this.listViewRight.Name = "listViewRight";
            this.listViewRight.Size = new System.Drawing.Size(602, 604);
            this.listViewRight.TabIndex = 5;
            this.listViewRight.UseCompatibleStateImageBehavior = false;
            this.listViewRight.View = System.Windows.Forms.View.Details;
            this.listViewRight.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.AfterRenameRight);
            this.listViewRight.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewRight_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RightContextMenuStrip
            // 
            this.RightContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RightContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.RightContextMenuStrip.Name = "contextMenuStrip1";
            this.RightContextMenuStrip.Size = new System.Drawing.Size(191, 124);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.директориюToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 24);
            this.toolStripMenuItem1.Text = "Создать";
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.файлToolStripMenuItem1.Text = "Файл";
            this.файлToolStripMenuItem1.Click += new System.EventHandler(this.CreateFile);
            // 
            // директориюToolStripMenuItem1
            // 
            this.директориюToolStripMenuItem1.Name = "директориюToolStripMenuItem1";
            this.директориюToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.директориюToolStripMenuItem1.Text = "Директорию";
            this.директориюToolStripMenuItem1.Click += new System.EventHandler(this.CreateDir);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(190, 24);
            this.toolStripMenuItem2.Text = "Копировать";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Copy);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(190, 24);
            this.toolStripMenuItem3.Text = "Переименовать";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.Rename);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(190, 24);
            this.toolStripMenuItem4.Text = "Удалить";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.DeleteToolStrip_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(190, 24);
            this.toolStripMenuItem5.Text = "Свойства";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.prop);
            // 
            // tbleft
            // 
            this.tbleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbleft.Location = new System.Drawing.Point(4, 34);
            this.tbleft.Margin = new System.Windows.Forms.Padding(4);
            this.tbleft.Name = "tbleft";
            this.tbleft.Size = new System.Drawing.Size(602, 22);
            this.tbleft.TabIndex = 6;
            // 
            // tbright
            // 
            this.tbright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbright.Location = new System.Drawing.Point(614, 34);
            this.tbright.Margin = new System.Windows.Forms.Padding(4);
            this.tbright.Name = "tbright";
            this.tbright.Size = new System.Drawing.Size(602, 22);
            this.tbright.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listViewLeft, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listViewRight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbleft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbright, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbright, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbleft, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1220, 672);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Text = "G:\\";
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1220, 727);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TotalCommander";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LeftContextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.RightContextMenuStrip.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbleft;
        private System.Windows.Forms.ListView listViewLeft;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader TypeColumn;
        private System.Windows.Forms.ColumnHeader DateColumn;
        private System.Windows.Forms.ColumnHeader SizeColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem NewFileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem NewFolderToolStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyToolstrip;
        private System.Windows.Forms.ToolStripMenuItem RenameToolStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStrip;
        private System.Windows.Forms.ContextMenuStrip LeftContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cbright;
        private System.Windows.Forms.ListView listViewRight;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.TextBox tbleft;
        private System.Windows.Forms.TextBox tbright;
        private System.Windows.Forms.ContextMenuStrip RightContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem DirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem директориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem директориюToolStripMenuItem1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

