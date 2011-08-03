namespace TLModPackager
{
    partial class TLModPackagerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TLModPackagerForm));
            this.buttonModFolder = new System.Windows.Forms.Button();
            this.panelDecor1 = new System.Windows.Forms.Panel();
            this.buttonFileSelect = new System.Windows.Forms.Button();
            this.buttonModInfo = new System.Windows.Forms.Button();
            this.buttonPackaging = new System.Windows.Forms.Button();
            this.buttonModDescription = new System.Windows.Forms.Button();
            this.labelModFolderName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.panelManager = new Controls.PanelManager();
            this.panelModFolder = new Controls.ManagedPanel();
            this.buttonResetControlTexts = new System.Windows.Forms.Button();
            this.buttonReadMePrefill = new System.Windows.Forms.Button();
            this.buttonSelectMod = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDetectMods = new System.Windows.Forms.Button();
            this.textBoxModsPath = new System.Windows.Forms.TextBox();
            this.listViewModFolders = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.panelFilesSelection = new Controls.ManagedPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonViewModFiles = new System.Windows.Forms.Button();
            this.buttonToggleView = new System.Windows.Forms.Button();
            this.buttonSelectNone = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.treeViewModFiles = new System.Windows.Forms.TreeView();
            this.panelModInfo = new Controls.ManagedPanel();
            this.textBoxIDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxIDetails = new System.Windows.Forms.ComboBox();
            this.dateTimePickerIRelease = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxICategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxIWebSite = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIAuthor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIVersion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIModName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPackaging = new Controls.ManagedPanel();
            this.checkBoxOpenReadMe = new System.Windows.Forms.CheckBox();
            this.buttonArchivePath = new System.Windows.Forms.Button();
            this.buttonCreateArchive = new System.Windows.Forms.Button();
            this.labelPackageName = new System.Windows.Forms.Label();
            this.progressBarArchive = new System.Windows.Forms.ProgressBar();
            this.textBoxArchDestination = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxArchiveName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panelModDescription = new Controls.ManagedPanel();
            this.comboBoxLicensing = new System.Windows.Forms.ComboBox();
            this.textBoxIInstallCompatibility = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxILicensing = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxIDetails = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxILocation = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelManager.SuspendLayout();
            this.panelModFolder.SuspendLayout();
            this.panelFilesSelection.SuspendLayout();
            this.panelModInfo.SuspendLayout();
            this.panelPackaging.SuspendLayout();
            this.panelModDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonModFolder
            // 
            this.buttonModFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModFolder.Location = new System.Drawing.Point(12, 12);
            this.buttonModFolder.Name = "buttonModFolder";
            this.buttonModFolder.Size = new System.Drawing.Size(131, 60);
            this.buttonModFolder.TabIndex = 1;
            this.buttonModFolder.Text = "Mod Folder";
            this.buttonModFolder.UseVisualStyleBackColor = true;
            this.buttonModFolder.Click += new System.EventHandler(this.buttonModFolder_Click);
            // 
            // panelDecor1
            // 
            this.panelDecor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDecor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDecor1.Location = new System.Drawing.Point(155, 12);
            this.panelDecor1.Name = "panelDecor1";
            this.panelDecor1.Size = new System.Drawing.Size(3, 389);
            this.panelDecor1.TabIndex = 2;
            // 
            // buttonFileSelect
            // 
            this.buttonFileSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileSelect.Location = new System.Drawing.Point(12, 79);
            this.buttonFileSelect.Name = "buttonFileSelect";
            this.buttonFileSelect.Size = new System.Drawing.Size(131, 60);
            this.buttonFileSelect.TabIndex = 3;
            this.buttonFileSelect.Text = "Files Selection";
            this.buttonFileSelect.UseVisualStyleBackColor = true;
            this.buttonFileSelect.Click += new System.EventHandler(this.buttonFileSelect_Click);
            // 
            // buttonModInfo
            // 
            this.buttonModInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModInfo.Location = new System.Drawing.Point(12, 145);
            this.buttonModInfo.Name = "buttonModInfo";
            this.buttonModInfo.Size = new System.Drawing.Size(131, 60);
            this.buttonModInfo.TabIndex = 4;
            this.buttonModInfo.Text = "Mod Info";
            this.buttonModInfo.UseVisualStyleBackColor = true;
            this.buttonModInfo.Click += new System.EventHandler(this.buttonModInfo_Click);
            // 
            // buttonPackaging
            // 
            this.buttonPackaging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPackaging.Location = new System.Drawing.Point(12, 277);
            this.buttonPackaging.Name = "buttonPackaging";
            this.buttonPackaging.Size = new System.Drawing.Size(131, 124);
            this.buttonPackaging.TabIndex = 5;
            this.buttonPackaging.Text = "Packaging";
            this.buttonPackaging.UseVisualStyleBackColor = true;
            this.buttonPackaging.Click += new System.EventHandler(this.buttonPackaging_Click);
            // 
            // buttonModDescription
            // 
            this.buttonModDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModDescription.Location = new System.Drawing.Point(12, 211);
            this.buttonModDescription.Name = "buttonModDescription";
            this.buttonModDescription.Size = new System.Drawing.Size(131, 60);
            this.buttonModDescription.TabIndex = 6;
            this.buttonModDescription.Text = "Mod Details";
            this.buttonModDescription.UseVisualStyleBackColor = true;
            this.buttonModDescription.Click += new System.EventHandler(this.buttonModDescription_Click);
            // 
            // labelModFolderName
            // 
            this.labelModFolderName.AutoSize = true;
            this.labelModFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModFolderName.Location = new System.Drawing.Point(195, 25);
            this.labelModFolderName.Name = "labelModFolderName";
            this.labelModFolderName.Size = new System.Drawing.Size(64, 22);
            this.labelModFolderName.TabIndex = 7;
            this.labelModFolderName.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mod folder to be packaged:";
            // 
            // panelManager
            // 
            this.panelManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManager.Controls.Add(this.panelModFolder);
            this.panelManager.Controls.Add(this.panelFilesSelection);
            this.panelManager.Controls.Add(this.panelModInfo);
            this.panelManager.Controls.Add(this.panelPackaging);
            this.panelManager.Controls.Add(this.panelModDescription);
            this.panelManager.Location = new System.Drawing.Point(173, 50);
            this.panelManager.Name = "panelManager";
            this.panelManager.SelectedIndex = 2;
            this.panelManager.SelectedPanel = this.panelModInfo;
            this.panelManager.Size = new System.Drawing.Size(585, 355);
            this.panelManager.TabIndex = 0;
            // 
            // panelModFolder
            // 
            this.panelModFolder.Controls.Add(this.buttonResetControlTexts);
            this.panelModFolder.Controls.Add(this.buttonReadMePrefill);
            this.panelModFolder.Controls.Add(this.buttonSelectMod);
            this.panelModFolder.Controls.Add(this.label3);
            this.panelModFolder.Controls.Add(this.label2);
            this.panelModFolder.Controls.Add(this.buttonDetectMods);
            this.panelModFolder.Controls.Add(this.textBoxModsPath);
            this.panelModFolder.Controls.Add(this.listViewModFolders);
            this.panelModFolder.Location = new System.Drawing.Point(0, 0);
            this.panelModFolder.Name = "panelModFolder";
            this.panelModFolder.Size = new System.Drawing.Size(0, 0);
            this.panelModFolder.Text = "managedPanel1";
            // 
            // buttonResetControlTexts
            // 
            this.buttonResetControlTexts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetControlTexts.Location = new System.Drawing.Point(350, 255);
            this.buttonResetControlTexts.Name = "buttonResetControlTexts";
            this.buttonResetControlTexts.Size = new System.Drawing.Size(232, 46);
            this.buttonResetControlTexts.TabIndex = 8;
            this.buttonResetControlTexts.Text = "Clear mod info and mod details";
            this.buttonResetControlTexts.UseVisualStyleBackColor = true;
            this.buttonResetControlTexts.Visible = false;
            this.buttonResetControlTexts.Click += new System.EventHandler(this.buttonResetControlTexts_Click);
            // 
            // buttonReadMePrefill
            // 
            this.buttonReadMePrefill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadMePrefill.Location = new System.Drawing.Point(350, 307);
            this.buttonReadMePrefill.Name = "buttonReadMePrefill";
            this.buttonReadMePrefill.Size = new System.Drawing.Size(232, 48);
            this.buttonReadMePrefill.TabIndex = 7;
            this.buttonReadMePrefill.Text = "Use existing readme.txt to overwrite mod description fields";
            this.toolTips.SetToolTip(this.buttonReadMePrefill, "This is will try to prefill mod info and details from readme.txt. Use with cautio" +
                    "n if you already wrote some descriptions.");
            this.buttonReadMePrefill.UseVisualStyleBackColor = true;
            this.buttonReadMePrefill.Visible = false;
            this.buttonReadMePrefill.Click += new System.EventHandler(this.buttonReadMePrefill_Click);
            // 
            // buttonSelectMod
            // 
            this.buttonSelectMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectMod.Location = new System.Drawing.Point(17, 307);
            this.buttonSelectMod.Name = "buttonSelectMod";
            this.buttonSelectMod.Size = new System.Drawing.Size(327, 46);
            this.buttonSelectMod.TabIndex = 6;
            this.buttonSelectMod.Text = "Select Mod Folder";
            this.buttonSelectMod.UseVisualStyleBackColor = true;
            this.buttonSelectMod.Click += new System.EventHandler(this.buttonSelectMod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select mod folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Torchlight mod folder path:";
            // 
            // buttonDetectMods
            // 
            this.buttonDetectMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetectMods.Location = new System.Drawing.Point(469, 27);
            this.buttonDetectMods.Name = "buttonDetectMods";
            this.buttonDetectMods.Size = new System.Drawing.Size(75, 23);
            this.buttonDetectMods.TabIndex = 2;
            this.buttonDetectMods.Text = "Autodetect";
            this.buttonDetectMods.UseVisualStyleBackColor = true;
            this.buttonDetectMods.Click += new System.EventHandler(this.buttonDetectMods_Click);
            // 
            // textBoxModsPath
            // 
            this.textBoxModsPath.Location = new System.Drawing.Point(17, 29);
            this.textBoxModsPath.Name = "textBoxModsPath";
            this.textBoxModsPath.Size = new System.Drawing.Size(446, 20);
            this.textBoxModsPath.TabIndex = 1;
            // 
            // listViewModFolders
            // 
            this.listViewModFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewModFolders.FullRowSelect = true;
            this.listViewModFolders.HideSelection = false;
            this.listViewModFolders.Location = new System.Drawing.Point(17, 73);
            this.listViewModFolders.MultiSelect = false;
            this.listViewModFolders.Name = "listViewModFolders";
            this.listViewModFolders.Size = new System.Drawing.Size(327, 228);
            this.listViewModFolders.TabIndex = 0;
            this.listViewModFolders.UseCompatibleStateImageBehavior = false;
            this.listViewModFolders.View = System.Windows.Forms.View.Details;
            this.listViewModFolders.SelectedIndexChanged += new System.EventHandler(this.listViewModFolders_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mod folders";
            this.columnHeader1.Width = 297;
            // 
            // panelFilesSelection
            // 
            this.panelFilesSelection.Controls.Add(this.label18);
            this.panelFilesSelection.Controls.Add(this.buttonViewModFiles);
            this.panelFilesSelection.Controls.Add(this.buttonToggleView);
            this.panelFilesSelection.Controls.Add(this.buttonSelectNone);
            this.panelFilesSelection.Controls.Add(this.buttonSelectAll);
            this.panelFilesSelection.Controls.Add(this.treeViewModFiles);
            this.panelFilesSelection.Location = new System.Drawing.Point(0, 0);
            this.panelFilesSelection.Name = "panelFilesSelection";
            this.panelFilesSelection.Size = new System.Drawing.Size(0, 0);
            this.panelFilesSelection.Text = "managedPanel2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(-3, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(164, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Select files you want to package:";
            // 
            // buttonViewModFiles
            // 
            this.buttonViewModFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewModFiles.Location = new System.Drawing.Point(3, 3);
            this.buttonViewModFiles.Name = "buttonViewModFiles";
            this.buttonViewModFiles.Size = new System.Drawing.Size(578, 30);
            this.buttonViewModFiles.TabIndex = 5;
            this.buttonViewModFiles.Text = "List All Mod Files";
            this.buttonViewModFiles.UseVisualStyleBackColor = true;
            this.buttonViewModFiles.Click += new System.EventHandler(this.buttonViewModFiles_Click);
            // 
            // buttonToggleView
            // 
            this.buttonToggleView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToggleView.Location = new System.Drawing.Point(439, 323);
            this.buttonToggleView.Name = "buttonToggleView";
            this.buttonToggleView.Size = new System.Drawing.Size(143, 29);
            this.buttonToggleView.TabIndex = 4;
            this.buttonToggleView.Text = "Toggle File/Tree view";
            this.buttonToggleView.UseVisualStyleBackColor = true;
            this.buttonToggleView.Visible = false;
            // 
            // buttonSelectNone
            // 
            this.buttonSelectNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectNone.Location = new System.Drawing.Point(114, 323);
            this.buttonSelectNone.Name = "buttonSelectNone";
            this.buttonSelectNone.Size = new System.Drawing.Size(107, 29);
            this.buttonSelectNone.TabIndex = 3;
            this.buttonSelectNone.Text = "Select None";
            this.buttonSelectNone.UseVisualStyleBackColor = true;
            this.buttonSelectNone.Click += new System.EventHandler(this.buttonSelectNone_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectAll.Location = new System.Drawing.Point(4, 323);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(104, 29);
            this.buttonSelectAll.TabIndex = 2;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // treeViewModFiles
            // 
            this.treeViewModFiles.CheckBoxes = true;
            this.treeViewModFiles.Location = new System.Drawing.Point(3, 56);
            this.treeViewModFiles.Name = "treeViewModFiles";
            this.treeViewModFiles.Size = new System.Drawing.Size(578, 261);
            this.treeViewModFiles.TabIndex = 0;
            this.treeViewModFiles.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewModFiles_AfterCheck);
            // 
            // panelModInfo
            // 
            this.panelModInfo.Controls.Add(this.textBoxIDescription);
            this.panelModInfo.Controls.Add(this.label11);
            this.panelModInfo.Controls.Add(this.comboBoxIDetails);
            this.panelModInfo.Controls.Add(this.dateTimePickerIRelease);
            this.panelModInfo.Controls.Add(this.label10);
            this.panelModInfo.Controls.Add(this.comboBoxICategory);
            this.panelModInfo.Controls.Add(this.label9);
            this.panelModInfo.Controls.Add(this.textBoxIWebSite);
            this.panelModInfo.Controls.Add(this.label8);
            this.panelModInfo.Controls.Add(this.textBoxIEmail);
            this.panelModInfo.Controls.Add(this.label7);
            this.panelModInfo.Controls.Add(this.textBoxIAuthor);
            this.panelModInfo.Controls.Add(this.label6);
            this.panelModInfo.Controls.Add(this.textBoxIVersion);
            this.panelModInfo.Controls.Add(this.label5);
            this.panelModInfo.Controls.Add(this.textBoxIModName);
            this.panelModInfo.Controls.Add(this.label4);
            this.panelModInfo.Location = new System.Drawing.Point(0, 0);
            this.panelModInfo.Name = "panelModInfo";
            this.panelModInfo.Size = new System.Drawing.Size(585, 355);
            this.panelModInfo.Text = "managedPanel3";
            // 
            // textBoxIDescription
            // 
            this.textBoxIDescription.Location = new System.Drawing.Point(18, 213);
            this.textBoxIDescription.Multiline = true;
            this.textBoxIDescription.Name = "textBoxIDescription";
            this.textBoxIDescription.Size = new System.Drawing.Size(554, 110);
            this.textBoxIDescription.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Description:";
            // 
            // comboBoxIDetails
            // 
            this.comboBoxIDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIDetails.FormattingEnabled = true;
            this.comboBoxIDetails.Location = new System.Drawing.Point(361, 143);
            this.comboBoxIDetails.Name = "comboBoxIDetails";
            this.comboBoxIDetails.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIDetails.TabIndex = 24;
            this.comboBoxIDetails.SelectedIndexChanged += new System.EventHandler(this.comboBoxIDetails_SelectedIndexChanged);
            // 
            // dateTimePickerIRelease
            // 
            this.dateTimePickerIRelease.Location = new System.Drawing.Point(234, 170);
            this.dateTimePickerIRelease.Name = "dateTimePickerIRelease";
            this.dateTimePickerIRelease.Size = new System.Drawing.Size(132, 20);
            this.dateTimePickerIRelease.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(153, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Release Date:";
            // 
            // comboBoxICategory
            // 
            this.comboBoxICategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxICategory.FormattingEnabled = true;
            this.comboBoxICategory.Location = new System.Drawing.Point(234, 143);
            this.comboBoxICategory.Name = "comboBoxICategory";
            this.comboBoxICategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxICategory.TabIndex = 11;
            this.comboBoxICategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxICategory_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Category:";
            // 
            // textBoxIWebSite
            // 
            this.textBoxIWebSite.Location = new System.Drawing.Point(234, 117);
            this.textBoxIWebSite.Name = "textBoxIWebSite";
            this.textBoxIWebSite.Size = new System.Drawing.Size(222, 20);
            this.textBoxIWebSite.TabIndex = 9;
            this.toolTips.SetToolTip(this.textBoxIWebSite, "Author\'s web site");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Web Site:";
            // 
            // textBoxIEmail
            // 
            this.textBoxIEmail.Location = new System.Drawing.Point(234, 91);
            this.textBoxIEmail.Name = "textBoxIEmail";
            this.textBoxIEmail.Size = new System.Drawing.Size(177, 20);
            this.textBoxIEmail.TabIndex = 7;
            this.toolTips.SetToolTip(this.textBoxIEmail, "Author\'s email address");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email:";
            // 
            // textBoxIAuthor
            // 
            this.textBoxIAuthor.Location = new System.Drawing.Point(234, 65);
            this.textBoxIAuthor.Name = "textBoxIAuthor";
            this.textBoxIAuthor.Size = new System.Drawing.Size(148, 20);
            this.textBoxIAuthor.TabIndex = 5;
            this.textBoxIAuthor.TextChanged += new System.EventHandler(this.textBoxIAuthor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Author:";
            // 
            // textBoxIVersion
            // 
            this.textBoxIVersion.Location = new System.Drawing.Point(234, 38);
            this.textBoxIVersion.Name = "textBoxIVersion";
            this.textBoxIVersion.Size = new System.Drawing.Size(67, 20);
            this.textBoxIVersion.TabIndex = 3;
            this.textBoxIVersion.Text = "1.0";
            this.toolTips.SetToolTip(this.textBoxIVersion, "Version of mod. Keep it at x.x (e.g. 0.5 or 1.2)");
            this.textBoxIVersion.TextChanged += new System.EventHandler(this.textBoxIVersion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Version:";
            // 
            // textBoxIModName
            // 
            this.textBoxIModName.Location = new System.Drawing.Point(234, 12);
            this.textBoxIModName.Name = "textBoxIModName";
            this.textBoxIModName.Size = new System.Drawing.Size(189, 20);
            this.textBoxIModName.TabIndex = 1;
            this.textBoxIModName.TextChanged += new System.EventHandler(this.textBoxIModName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mod Name:";
            // 
            // panelPackaging
            // 
            this.panelPackaging.Controls.Add(this.checkBoxOpenReadMe);
            this.panelPackaging.Controls.Add(this.buttonArchivePath);
            this.panelPackaging.Controls.Add(this.buttonCreateArchive);
            this.panelPackaging.Controls.Add(this.labelPackageName);
            this.panelPackaging.Controls.Add(this.progressBarArchive);
            this.panelPackaging.Controls.Add(this.textBoxArchDestination);
            this.panelPackaging.Controls.Add(this.label17);
            this.panelPackaging.Controls.Add(this.textBoxArchiveName);
            this.panelPackaging.Controls.Add(this.label16);
            this.panelPackaging.Location = new System.Drawing.Point(0, 0);
            this.panelPackaging.Name = "panelPackaging";
            this.panelPackaging.Size = new System.Drawing.Size(0, 0);
            this.panelPackaging.Text = "managedPanel1";
            // 
            // checkBoxOpenReadMe
            // 
            this.checkBoxOpenReadMe.AutoSize = true;
            this.checkBoxOpenReadMe.Location = new System.Drawing.Point(204, 246);
            this.checkBoxOpenReadMe.Name = "checkBoxOpenReadMe";
            this.checkBoxOpenReadMe.Size = new System.Drawing.Size(172, 17);
            this.checkBoxOpenReadMe.TabIndex = 8;
            this.checkBoxOpenReadMe.Text = "Open readme.txt when finished";
            this.checkBoxOpenReadMe.UseVisualStyleBackColor = true;
            // 
            // buttonArchivePath
            // 
            this.buttonArchivePath.Location = new System.Drawing.Point(531, 108);
            this.buttonArchivePath.Name = "buttonArchivePath";
            this.buttonArchivePath.Size = new System.Drawing.Size(36, 23);
            this.buttonArchivePath.TabIndex = 7;
            this.buttonArchivePath.Text = "...";
            this.buttonArchivePath.UseVisualStyleBackColor = true;
            this.buttonArchivePath.Click += new System.EventHandler(this.buttonArchivePath_Click);
            // 
            // buttonCreateArchive
            // 
            this.buttonCreateArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateArchive.Location = new System.Drawing.Point(150, 191);
            this.buttonCreateArchive.Name = "buttonCreateArchive";
            this.buttonCreateArchive.Size = new System.Drawing.Size(281, 49);
            this.buttonCreateArchive.TabIndex = 6;
            this.buttonCreateArchive.Text = "Create Mod Package";
            this.toolTips.SetToolTip(this.buttonCreateArchive, "Creates package. Is disabled if mod name is missing or no files were selected.");
            this.buttonCreateArchive.UseVisualStyleBackColor = true;
            this.buttonCreateArchive.Click += new System.EventHandler(this.buttonCreateArchive_Click);
            // 
            // labelPackageName
            // 
            this.labelPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPackageName.Location = new System.Drawing.Point(11, 151);
            this.labelPackageName.Name = "labelPackageName";
            this.labelPackageName.Size = new System.Drawing.Size(556, 25);
            this.labelPackageName.TabIndex = 5;
            this.labelPackageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarArchive
            // 
            this.progressBarArchive.Location = new System.Drawing.Point(26, 275);
            this.progressBarArchive.Name = "progressBarArchive";
            this.progressBarArchive.Size = new System.Drawing.Size(525, 23);
            this.progressBarArchive.TabIndex = 4;
            // 
            // textBoxArchDestination
            // 
            this.textBoxArchDestination.Location = new System.Drawing.Point(106, 109);
            this.textBoxArchDestination.Name = "textBoxArchDestination";
            this.textBoxArchDestination.Size = new System.Drawing.Size(419, 20);
            this.textBoxArchDestination.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Destination folder:";
            // 
            // textBoxArchiveName
            // 
            this.textBoxArchiveName.Location = new System.Drawing.Point(184, 83);
            this.textBoxArchiveName.Name = "textBoxArchiveName";
            this.textBoxArchiveName.Size = new System.Drawing.Size(262, 20);
            this.textBoxArchiveName.TabIndex = 1;
            this.textBoxArchiveName.TextChanged += new System.EventHandler(this.textBoxArchiveName_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(103, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Archive name:";
            // 
            // panelModDescription
            // 
            this.panelModDescription.Controls.Add(this.comboBoxLicensing);
            this.panelModDescription.Controls.Add(this.textBoxIInstallCompatibility);
            this.panelModDescription.Controls.Add(this.label15);
            this.panelModDescription.Controls.Add(this.textBoxILicensing);
            this.panelModDescription.Controls.Add(this.label14);
            this.panelModDescription.Controls.Add(this.textBoxIDetails);
            this.panelModDescription.Controls.Add(this.label13);
            this.panelModDescription.Controls.Add(this.textBoxILocation);
            this.panelModDescription.Controls.Add(this.label12);
            this.panelModDescription.Location = new System.Drawing.Point(0, 0);
            this.panelModDescription.Name = "panelModDescription";
            this.panelModDescription.Size = new System.Drawing.Size(0, 0);
            this.panelModDescription.Text = "managedPanel1";
            // 
            // comboBoxLicensing
            // 
            this.comboBoxLicensing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLicensing.FormattingEnabled = true;
            this.comboBoxLicensing.Location = new System.Drawing.Point(67, 274);
            this.comboBoxLicensing.Name = "comboBoxLicensing";
            this.comboBoxLicensing.Size = new System.Drawing.Size(162, 21);
            this.comboBoxLicensing.TabIndex = 28;
            // 
            // textBoxIInstallCompatibility
            // 
            this.textBoxIInstallCompatibility.Location = new System.Drawing.Point(21, 205);
            this.textBoxIInstallCompatibility.Multiline = true;
            this.textBoxIInstallCompatibility.Name = "textBoxIInstallCompatibility";
            this.textBoxIInstallCompatibility.Size = new System.Drawing.Size(554, 65);
            this.textBoxIInstallCompatibility.TabIndex = 27;
            this.toolTips.SetToolTip(this.textBoxIInstallCompatibility, "Default mod instalation? Are there compatibility issues with previous versions or" +
                    " different type of mods?");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Instalation/Compatibility Issues:";
            // 
            // textBoxILicensing
            // 
            this.textBoxILicensing.Location = new System.Drawing.Point(21, 301);
            this.textBoxILicensing.Multiline = true;
            this.textBoxILicensing.Name = "textBoxILicensing";
            this.textBoxILicensing.Size = new System.Drawing.Size(554, 51);
            this.textBoxILicensing.TabIndex = 30;
            this.toolTips.SetToolTip(this.textBoxILicensing, "Any other details about licensing (distribution restrictions) of mod?");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Licensing:";
            // 
            // textBoxIDetails
            // 
            this.textBoxIDetails.Location = new System.Drawing.Point(21, 29);
            this.textBoxIDetails.Multiline = true;
            this.textBoxIDetails.Name = "textBoxIDetails";
            this.textBoxIDetails.Size = new System.Drawing.Size(554, 60);
            this.textBoxIDetails.TabIndex = 23;
            this.toolTips.SetToolTip(this.textBoxIDetails, "Details about the mod. Leave blank if you don\'t have any.");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Details:";
            // 
            // textBoxILocation
            // 
            this.textBoxILocation.Location = new System.Drawing.Point(21, 108);
            this.textBoxILocation.Multiline = true;
            this.textBoxILocation.Name = "textBoxILocation";
            this.textBoxILocation.Size = new System.Drawing.Size(554, 76);
            this.textBoxILocation.TabIndex = 25;
            this.toolTips.SetToolTip(this.textBoxILocation, "Where will we see the mod? In town? in a dungeon? Is it a new dungeon(where can w" +
                    "e access it)? Is it a UI mod(what part?)");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Location:";
            // 
            // TLModPackagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 417);
            this.Controls.Add(this.labelModFolderName);
            this.Controls.Add(this.buttonModDescription);
            this.Controls.Add(this.buttonPackaging);
            this.Controls.Add(this.buttonModInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFileSelect);
            this.Controls.Add(this.panelDecor1);
            this.Controls.Add(this.buttonModFolder);
            this.Controls.Add(this.panelManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TLModPackagerForm";
            this.Text = "TLModPackager";
            this.panelManager.ResumeLayout(false);
            this.panelModFolder.ResumeLayout(false);
            this.panelModFolder.PerformLayout();
            this.panelFilesSelection.ResumeLayout(false);
            this.panelFilesSelection.PerformLayout();
            this.panelModInfo.ResumeLayout(false);
            this.panelModInfo.PerformLayout();
            this.panelPackaging.ResumeLayout(false);
            this.panelPackaging.PerformLayout();
            this.panelModDescription.ResumeLayout(false);
            this.panelModDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PanelManager panelManager;
        private Controls.ManagedPanel panelModFolder;
        private Controls.ManagedPanel panelFilesSelection;
        private System.Windows.Forms.Button buttonModFolder;
        private System.Windows.Forms.Panel panelDecor1;
        private System.Windows.Forms.ListView listViewModFolders;
        private System.Windows.Forms.TreeView treeViewModFiles;
        private System.Windows.Forms.Button buttonFileSelect;
        private System.Windows.Forms.Button buttonModInfo;
        private System.Windows.Forms.Button buttonPackaging;
        private System.Windows.Forms.Button buttonModDescription;
        private Controls.ManagedPanel panelModInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDetectMods;
        private System.Windows.Forms.TextBox textBoxModsPath;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonSelectMod;
        private System.Windows.Forms.Label labelModFolderName;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonSelectNone;
        private System.Windows.Forms.Button buttonToggleView;
        private System.Windows.Forms.Button buttonViewModFiles;
        private System.Windows.Forms.TextBox textBoxIModName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIWebSite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxIAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxICategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerIRelease;
        private Controls.ManagedPanel panelPackaging;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonCreateArchive;
        private System.Windows.Forms.Label labelPackageName;
        private System.Windows.Forms.ProgressBar progressBarArchive;
        private System.Windows.Forms.TextBox textBoxArchDestination;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxArchiveName;
        private System.Windows.Forms.Button buttonArchivePath;
        private Controls.ManagedPanel panelModDescription;
        private System.Windows.Forms.TextBox textBoxIDetails;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxILocation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxIDetails;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkBoxOpenReadMe;
        private System.Windows.Forms.TextBox textBoxIDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxLicensing;
        private System.Windows.Forms.TextBox textBoxIInstallCompatibility;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxILicensing;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Button buttonReadMePrefill;
        private System.Windows.Forms.Button buttonResetControlTexts;
    }
}

