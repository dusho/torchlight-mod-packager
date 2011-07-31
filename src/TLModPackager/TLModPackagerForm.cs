using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using System.Diagnostics;

namespace TLModPackager
{
    /// <summary>
    /// TODO: Pass readme.txt separately into package, not as part of mod ??
    /// TODO: Check for existing readme.txt and grab information from it into controls (textboxes, ...)
    /// </summary>
    public partial class TLModPackagerForm : Form
    {
        public bool ErrorOccured;
        public string ErrorDescription;

        public bool ArchiveNameChangeFlag { get; set; }

        public string ModFolderName { get; set; }
        public string ModFolderPath { get; set; }
        public List<string> ModFiles { get; set; }
        public List<string> SelectedModFiles { get; set; }
        public string ModAuthor { get; set; }
        public string ModsPath { get; set; }

        List<string> IgnoreFilesWithExtensions { get; set; }
        List<string> IgnoreFiles { get; set; }

        Color OriginalBackColor;

        const string READ_ME = "readme.txt";

        public TLModPackagerForm()
        {
            InitializeComponent();

            this.Text = string.Format("{0} {1} ({2})", AsmInfo.Title, AsmInfo.Version, AsmInfo.CompanyName);
            
            ModFiles = new List<string>();
            SelectedModFiles = new List<string>();

            IgnoreFilesWithExtensions = new List<string>();
            IgnoreFilesWithExtensions.Add(".adm");
            IgnoreFilesWithExtensions.Add(".cmp");
            
            IgnoreFiles = new List<string>();
            IgnoreFiles.Add("mod.dat");
            IgnoreFiles.Add("mods.dat");
            IgnoreFiles.Add("readme.txt");

            OriginalBackColor = buttonModFolder.BackColor;

            panelManager.SelectedIndex = 0;
            buttonSelectMod.Enabled = false;

            comboBoxICategory.Items.Clear();
            comboBoxICategory.Items.Add("Class");
            comboBoxICategory.Items.Add("Conversion");
            comboBoxICategory.Items.Add("GUI");
            comboBoxICategory.Items.Add("Gameplay");
            comboBoxICategory.Items.Add("Items");
            comboBoxICategory.Items.Add("Maps");
            comboBoxICategory.Items.Add("Mod Pack");
            comboBoxICategory.Items.Add("Monsters");
            comboBoxICategory.Items.Add("NPCs");
            comboBoxICategory.Items.Add("Pets");
            comboBoxICategory.Items.Add("Resource");
            comboBoxICategory.Items.Add("Skills&Spells");
            comboBoxICategory.Items.Add("Skins");
            comboBoxICategory.Items.Add("Music&Sounds");
            comboBoxICategory.Items.Add("Tool");
            comboBoxICategory.Items.Add("Translations");
            comboBoxICategory.SelectedIndex = 0;

            comboBoxLicensing.Items.Clear();
            comboBoxLicensing.Items.Add("I don't care");
            comboBoxLicensing.Items.Add("Modify and credit");
            comboBoxLicensing.Items.Add("Modify, credit and let me know");
            comboBoxLicensing.Items.Add("Ask for permission");
            comboBoxLicensing.Items.Add("GNU General Public License");
            comboBoxLicensing.Items.Add("GNU Lesser General Public License");
            comboBoxLicensing.Items.Add("Other (fill in below)");
            comboBoxLicensing.SelectedIndex = 0;

            buttonDetectMods.BackColor = Color.LightPink;

            textBoxIInstallCompatibility.Text = @"Extract Contents of Archive to '%appdata%\runic games\torchlight\mods'";

            textBoxArchDestination.Text = Directory.GetCurrentDirectory();

            comboBoxIDetails.Visible = false;
            progressBarArchive.Visible = false;

            ArchiveNameChangeFlag = true;

            UpdateInfo();
        }

        private void buttonModFolder_Click(object sender, EventArgs e)
        {
            panelManager.SelectedIndex = 0;
            buttonSelectMod.Enabled = false;
            
            UpdateInfo();
            progressBarArchive.Visible = false;

            if (string.IsNullOrEmpty(textBoxModsPath.Text))
                buttonDetectMods.BackColor = Color.LightPink;
        }

        private void buttonFileSelect_Click(object sender, EventArgs e)
        {
            panelManager.SelectedIndex = 1;

            UpdateInfo();
            progressBarArchive.Visible = false;
            if (treeViewModFiles.Nodes.Count == 0)
            {
                buttonViewModFiles.BackColor = Color.LightPink;
            }
        }

        private void buttonModInfo_Click(object sender, EventArgs e)
        {
            panelManager.SelectedIndex = 2;

            textBoxIModName.Text = ModFolderName;
            UpdateInfo();
            progressBarArchive.Visible = false;

            if (string.IsNullOrEmpty(textBoxIAuthor.Text))
                textBoxIAuthor.BackColor = Color.LightPink;
        }

        private void buttonModDescription_Click(object sender, EventArgs e)
        {
            panelManager.SelectedIndex = 4;

            UpdateInfo();
            progressBarArchive.Visible = false;
        }

        private void buttonPackaging_Click(object sender, EventArgs e)
        {
            panelManager.SelectedIndex = 3;

            if (ArchiveNameChangeFlag)
            {
                textBoxArchiveName.Text = GetDefaultArchiveName();
                ArchiveNameChangeFlag = false;
            }
            UpdateInfo();

            if (SelectedModFiles.Count > 0)
                buttonCreateArchive.Enabled = true;
            else
                buttonCreateArchive.Enabled = false;
        }

        string GetDefaultArchiveName()
        {
            string cat = comboBoxICategory.Text;
            if(!string.IsNullOrEmpty(comboBoxIDetails.Text))
            {
                cat = comboBoxIDetails.Text;
            }
            string name = string.Format("[{0}]{1}_v{2}(by {3}).zip",
                cat, textBoxIModName.Text, textBoxIVersion.Text, textBoxIAuthor.Text );

            labelPackageName.Text = name;

            return name;
        }

        string GetSafeFilename(string theStr)
        {
            string safeName = theStr;

            foreach (var cc in Path.GetInvalidFileNameChars())
            {
                safeName = safeName.Replace(cc, new char());
            }
            return safeName;
        }

        private void buttonDetectMods_Click(object sender, EventArgs e)
        {
            buttonDetectMods.BackColor = OriginalBackColor;
            string modsPath = TryToFindModsFolder();
            if (string.IsNullOrEmpty(modsPath))
            {
                textBoxModsPath.BackColor = Color.LightPink;                
            }
            else
            {
                textBoxModsPath.BackColor = Color.LightGreen;                
                ModsPath = modsPath;
                PopulateModFoldersView(ModsPath);
            }

            textBoxModsPath.Text = ModsPath;
        }

        void UpdateInfo()
        {
            ModAuthor = textBoxIAuthor.Text;
            string author = string.IsNullOrEmpty(ModAuthor) ? string.Empty :  "by " + ModAuthor;
            string numFiles = SelectedModFiles.Count == 0 ? string.Empty : string.Format("({0} files)", SelectedModFiles.Count);
            string info = string.Format("{0} {1} {2}", ModFolderName, numFiles, author);
            labelModFolderName.Text = info;

            // coloring
            buttonModFolder.BackColor = OriginalBackColor;
            buttonFileSelect.BackColor = OriginalBackColor;
            buttonModInfo.BackColor = OriginalBackColor;
            buttonPackaging.BackColor = OriginalBackColor;
            buttonModDescription.BackColor = OriginalBackColor;
            switch (panelManager.SelectedIndex)
            {
                case 0:
                    buttonModFolder.BackColor = Color.LightSteelBlue;
                    break;
                case 1:
                    buttonFileSelect.BackColor = Color.LightSteelBlue;
                    break;
                case 2:
                    buttonModInfo.BackColor = Color.LightSteelBlue;
                    break;
                case 3:
                    buttonPackaging.BackColor = Color.LightSteelBlue;
                    break;
                case 4:
                    buttonModDescription.BackColor = Color.LightSteelBlue;
                    break;
            }
        }

        void PopulateModFoldersView(string theModsPath)
        {
            string[] modFolders = Directory.GetDirectories(theModsPath);
            listViewModFolders.Items.Clear();
            foreach (var fld in modFolders)
            {
                listViewModFolders.Items.Add(Path.GetFileName(fld));
            }
        }         

        /// <summary>
        /// Just try to find torchlight mods folder
        /// </summary>
        /// <returns>TL mods folder or some default one</returns>
        string TryToFindModsFolder()
        {
            string modFolder = string.Empty;

            string tlfd = FindFolder(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "torchlight");
            string mdfd = FindFolder(tlfd, "mods");

            if (!string.IsNullOrEmpty(mdfd))
            {
                modFolder = mdfd + Path.DirectorySeparatorChar;
            }

            return modFolder;
        }

        public static string FindFolder(string theStartingDir, string theSeachName)
        {
            string result = string.Empty;
            Stack<string> stack = new Stack<string>();
            stack.Push(theStartingDir);

            while (stack.Count > 0)
            {
                string dir = stack.Pop();

                try
                {
                    if (string.Compare(Path.GetFileName(dir), theSeachName, true) == 0)
                        return dir;
                    foreach (string dn in Directory.GetDirectories(dir))
                    {
                        stack.Push(dn);
                    }
                }
                catch
                {
                    // Could not open the directory
                }
            }
            return result;
        }

        private void listViewModFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewModFolders.SelectedItems.Count > 0)
            {
                buttonSelectMod.Enabled = true;
                if (string.IsNullOrEmpty(ModFolderName))
                {
                    buttonSelectMod.BackColor = Color.LightPink;
                }
            }
        }

        private void buttonSelectMod_Click(object sender, EventArgs e)
        {
            if (listViewModFolders.SelectedItems.Count > 0)
            {
                buttonSelectMod.BackColor = OriginalBackColor;
                string oldFolderName = ModFolderName;
                ModFolderName = listViewModFolders.SelectedItems[0].Text;
                ModFolderPath = Path.Combine(ModsPath, ModFolderName);
                if (string.Compare(oldFolderName, ModFolderName) != 0)
                {
                    ModFiles.Clear();    
                    SelectedModFiles.Clear();
                    treeViewModFiles.Nodes.Clear();
                }
                               
                UpdateInfo();
            }
        }

        private void buttonViewModFiles_Click(object sender, EventArgs e)
        {
            buttonViewModFiles.BackColor = OriginalBackColor;

            GatherAllModFiles(ModFolderPath);

            treeViewModFiles.Nodes.Clear();
            foreach (var fl in ModFiles)
            {
                string modFile = fl.Replace(ModsPath, string.Empty);
                TreeNode treeNode = new TreeNode(modFile);                
                treeViewModFiles.Nodes.Add(treeNode);
            }
        }

        /// <summary>
        /// Gets all mods files ONLY if it wasn't done already
        /// </summary>
        /// <param name="theModsFolder">mods folder path</param>
        void GatherAllModFiles(string theModsFolder)
        {
            //SetProgress("Searching for mod files", 0f);
            // don't search if there are files already
            if (ModFiles.Count != 0) return;

            GatherFiles(theModsFolder, ModFiles);

            // now get rid of files with extension to be ignored (compiled files)
            foreach (var ignoreExt in IgnoreFilesWithExtensions)
            {
                for (int i = ModFiles.Count - 1; i >= 0; i--)
                {
                    if (string.Compare(Path.GetExtension(ModFiles[i]), ignoreExt, true) == 0)
                    {
                        ModFiles.RemoveAt(i);
                    }
                }
            }
            // get rid of some files (mod.dat,..)
            foreach (var ignoreFile in IgnoreFiles)
            {
                for (int i = ModFiles.Count - 1; i >= 0; i--)
                {
                    if (string.Compare(Path.GetFileName(ModFiles[i]), ignoreFile, true) == 0)
                    {
                        ModFiles.RemoveAt(i);
                    }
                }
            }
            //SetProgress("Searching for mod files", 100f);
        }

        /// <summary>
        /// Search directory for all files recursively
        /// </summary>
        /// <param name="theDir">directory to be scanned</param>
        /// <param name="theFiles">container for files</param>
        void GatherFiles(string theDir, List<string> theFiles)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(theDir))
                {
                    foreach (string f in Directory.GetFiles(d, "*.*"))
                    {
                        theFiles.Add(f);
                    }
                    GatherFiles(d, theFiles);
                }
            }
            catch (System.Exception excpt)
            {
                ErrorOccured = true;
                ErrorDescription = excpt.Message;
            }
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode it in treeViewModFiles.Nodes)
            {
                it.Checked = true;
            }
            UpdateInfo();
        }

        private void buttonSelectNone_Click(object sender, EventArgs e)
        {
            foreach (TreeNode it in treeViewModFiles.Nodes)
            {
                it.Checked = false;
            }
            UpdateInfo();
        }

        private void treeViewModFiles_AfterCheck(object sender, TreeViewEventArgs e)
        {
            SelectedModFiles.Clear();

            foreach (TreeNode it in treeViewModFiles.Nodes)
            {
                if (it.Checked)
                {
                    SelectedModFiles.Add(it.Text);
                }
            }
            UpdateInfo();
        }

        private void comboBoxICategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxICategory.SelectedItem.Equals("Items"))
            {
                comboBoxIDetails.Visible = true;
                comboBoxIDetails.Items.Clear();
                comboBoxIDetails.Items.Add("Gems");
                comboBoxIDetails.Items.Add("Potions");
                comboBoxIDetails.Items.Add("Weapons");
                comboBoxIDetails.Items.Add("Armor");

                comboBoxIDetails.SelectedIndex = 0;
            }
            else
            {
                comboBoxIDetails.Visible = false;
                comboBoxIDetails.Text = string.Empty;
            }

            ArchiveNameChangeFlag = true;
        }

        string CreateReadMeFile(string thePath)
        {            
            string path = Path.Combine(thePath, READ_ME);
            using (TextWriter writer = File.CreateText(path)) // Use File.CreateText result
            {
                writer.WriteLine(textBoxArchiveName.Text);
                writer.WriteLine();
                writer.WriteLine("Mod Name: {0}", textBoxIModName.Text);
                writer.WriteLine("Version: {0}", textBoxIVersion.Text);
                writer.WriteLine("Mod Author: {0} \t Email: {1} \t Web site: {2}",
                    textBoxIAuthor.Text, textBoxIEmail.Text, textBoxIWebSite.Text);
                
                writer.WriteLine("Release date: {0}", dateTimePickerIRelease.Value.ToShortDateString());
                if (!string.IsNullOrEmpty(comboBoxIDetails.Text))
                {
                    writer.WriteLine("Category: {0}/{1}", comboBoxICategory.Text, comboBoxIDetails.Text);
                }
                else
                {
                    writer.WriteLine("Category: {0}", comboBoxICategory.Text);
                }
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine("===========");
                writer.WriteLine("Description");
                writer.WriteLine("===========");
                writer.WriteLine(textBoxIDescription.Text);

                if (!string.IsNullOrEmpty(textBoxIDetails.Text))
                {
                    writer.WriteLine();
                    writer.WriteLine("===========");
                    writer.WriteLine("Details");
                    writer.WriteLine("===========");
                    writer.WriteLine(textBoxIDetails.Text);
                }

                if (!string.IsNullOrEmpty(textBoxILocation.Text))
                {
                    writer.WriteLine();
                    writer.WriteLine("===========");
                    writer.WriteLine("Location");
                    writer.WriteLine("===========");
                    writer.WriteLine(textBoxILocation.Text);
                }

                writer.WriteLine();
                writer.WriteLine("===========");
                writer.WriteLine("Instalation");
                writer.WriteLine("===========");
                writer.WriteLine(textBoxIInstallCompatibility.Text);

                writer.WriteLine();
                writer.WriteLine("===========");
                writer.WriteLine("Licensing");
                writer.WriteLine("===========");
                writer.WriteLine(comboBoxLicensing.Text);
                writer.WriteLine(textBoxILicensing.Text);
            }

            return path;
        }

        private void textBoxArchiveName_TextChanged(object sender, EventArgs e)
        {
            labelPackageName.Text = textBoxArchiveName.Text;
        }

        private void buttonCreateArchive_Click(object sender, EventArgs e)
        {
            progressBarArchive.Visible = true;
            buttonCreateArchive.Enabled = false;
            textBoxArchDestination.Enabled = false;
            textBoxArchiveName.Enabled = false;

            string readme = CreateReadMeFile(Path.Combine(ModsPath, ModFolderName));
            AddReadMeToBeArchived();

            CreateArchive();

            buttonCreateArchive.Enabled = true;
            textBoxArchDestination.Enabled = true;
            textBoxArchiveName.Enabled = true;

            if (checkBoxOpenReadMe.Checked)
            {
                Process notePad = new Process();

                notePad.StartInfo.FileName = "notepad.exe";
                notePad.StartInfo.Arguments = readme;

                notePad.Start();
            }
        }

        void AddReadMeToBeArchived()
        {
            for (int i = SelectedModFiles.Count - 1; i >= 0; i--)
            {
                if (Path.GetFileName(SelectedModFiles[i]).Equals(READ_ME))
                {
                    SelectedModFiles.RemoveAt(i);
                    break;
                }
            }

            SelectedModFiles.Add(Path.Combine(ModFolderName, READ_ME));
        }

        void CreateArchive()
        {
            string desiredArchName = textBoxArchiveName.Text;
            string dest = textBoxArchDestination.Text;

            string archivePath = Path.Combine(dest, desiredArchName);

            try
            {
                // Depending on the directory this could be very large and would require more attention
                // in a commercial package.
                var filenames = SelectedModFiles;
                progressBarArchive.Maximum = filenames.Count;
                progressBarArchive.Step = 1;

                // 'using' statements guarantee the stream is closed properly which is a big source
                // of problems otherwise.  Its exception safe as well which is great.
                using (ZipOutputStream s = new ZipOutputStream(File.Create(archivePath)))
                {

                    s.SetLevel(9); // 0 - store only to 9 - means best compression

                    byte[] buffer = new byte[4096];

                    foreach (string file in filenames)
                    {
                        string filePath = Path.Combine(ModsPath, file);
                        // Using GetFileName makes the result compatible with XP
                        // as the resulting path is not absolute.                        
                        //ZipEntry entry = new ZipEntry(Path.GetFileName(filePath));   
                        ZipEntry entry = new ZipEntry(file);     

                        // Setup the entry data as required.

                        // Crc and size are handled by the library for seakable streams
                        // so no need to do them here.

                        // Could also use the last write time or similar for the file.
                        entry.DateTime = DateTime.Now;
                        s.PutNextEntry(entry);

                        using (FileStream fs = File.OpenRead(filePath))
                        {

                            // Using a fixed size buffer here makes no noticeable difference for output
                            // but keeps a lid on memory usage.
                            int sourceBytes;
                            do
                            {
                                sourceBytes = fs.Read(buffer, 0, buffer.Length);
                                s.Write(buffer, 0, sourceBytes);
                            } while (sourceBytes > 0);
                        }

                        progressBarArchive.Increment(1);
                    }

                    // Finish/Close arent needed strictly as the using statement does this automatically

                    // Finish is important to ensure trailing information for a Zip file is appended.  Without this
                    // the created file would be invalid.
                    s.Finish();

                    // Close is important to wrap things up and unlock the file.
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Exception during processing {0}", ex));
                //Console.WriteLine("Exception during processing {0}", ex);

                // No need to rethrow the exception as for our purposes its handled.
            }

        }

        private void textBoxIModName_TextChanged(object sender, EventArgs e)
        {
            ModFolderName = textBoxIModName.Text;
            ArchiveNameChangeFlag = true;
        }

        private void textBoxIVersion_TextChanged(object sender, EventArgs e)
        {
            ArchiveNameChangeFlag = true;
        }

        private void textBoxIAuthor_TextChanged(object sender, EventArgs e)
        {
            ArchiveNameChangeFlag = true;
            if (string.IsNullOrEmpty(textBoxIAuthor.Text))
                textBoxIAuthor.BackColor = Color.LightPink;
            else
                textBoxIAuthor.BackColor = OriginalBackColor;
        }

        private void comboBoxIDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArchiveNameChangeFlag = true;
        }

        private void buttonArchivePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            // Set the help text description for the FolderBrowserDialog.
            folderBrowserDialog1.Description =
                "Select the directory where to save the archive.";
            
            folderBrowserDialog1.ShowNewFolderButton = true;

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxArchDestination.Text = folderBrowserDialog1.SelectedPath;                
            }
        }

    }
}
