using Scanner_Tool_Installer.Properties;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Environment;

namespace Scanner_Tool_Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            InstallButton.Enabled = false;
            ShortcutCheckBox.Enabled = false;
            ManualCheckBox.Enabled = false;
            var ShortcutPath = Path.Combine(GetFolderPath(SpecialFolder.Desktop), "Scanner Tool.lnk");
            var ManualPath = Path.Combine(GetFolderPath(SpecialFolder.Desktop), "Scanner Tool.pdf");
            var ProgramDataPath = Path.Combine(GetFolderPath(SpecialFolder.CommonApplicationData), "Scanner Tool");
            try
            {
                if (Directory.Exists(ProgramDataPath))
                {
                    Directory.Delete(ProgramDataPath, true);
                }
                Directory.CreateDirectory(ProgramDataPath);
                File.WriteAllBytes(Path.Combine(ProgramDataPath, "Scanner Tool.exe"), Resources._Scanner_Tool_exe);//Hier müssen Sie aus dem anderen Projekt die EXE Datei als Resource hinzufügen
                File.WriteAllBytes(Path.Combine(ProgramDataPath, "Scanner Tool.pdb"), Resources._Scanner_Tool_pdb);//Hier müssen Sie aus dem anderen Projekt die PDB Datei als Resource hinzufügen, damit in der Fehlermeldung die Codezeile angegeben wird
                File.WriteAllBytes(Path.Combine(ProgramDataPath, "ImageProcessor.dll"), Resources._ImageProcessor_dll);
                File.WriteAllBytes(Path.Combine(ProgramDataPath, "itextsharp.dll"), Resources._itextsharp_dll);
                File.WriteAllBytes(Path.Combine(ProgramDataPath, "log4net.dll"), Resources._log4net_dll);
                File.WriteAllBytes(Path.Combine(ProgramDataPath, "MaterialSkin.dll"), Resources._MaterialSkin_dll);
                File.WriteAllBytes(Path.Combine(ProgramDataPath, "TwainDotNet.dll"), Resources._TwainDotNet_dll);
                File.WriteAllBytes(Path.Combine(ProgramDataPath, "TwainDotNet.WinFroms.dll"), Resources._TwainDotNet_WinFroms_dll);
                if (ShortcutCheckBox.Checked)
                {
                    if (File.Exists(ShortcutPath))
                    {
                        File.Delete(ShortcutPath);
                    }
                    var shortcut = (IWshRuntimeLibrary.IWshShortcut)(new IWshRuntimeLibrary.WshShell()).CreateShortcut(ShortcutPath);
                    shortcut.TargetPath = Path.Combine(ProgramDataPath, "Scanner Tool.exe");
                    shortcut.WorkingDirectory = ProgramDataPath;
                    shortcut.Save();
                }
                if (ManualCheckBox.Checked)
                {
                    if (File.Exists(ManualPath))
                    {
                        File.Delete(ManualPath);
                    }
                    File.WriteAllBytes(ManualPath, Resources._Scanner_Tool_pdf);//Hier Ihre PDF als Tutorial für den Mitarbeiter
                }
                foreach (var MenuPath in new SpecialFolder[2] { SpecialFolder.CommonStartMenu, SpecialFolder.StartMenu})
                {
                    string StartMenuPath = Path.Combine(GetFolderPath(MenuPath), "Programs", "Scanner Tool");
                    if (Directory.Exists(StartMenuPath))
                    {
                        Directory.Delete(StartMenuPath, true);
                    }
                    Directory.CreateDirectory(StartMenuPath);
                    var MenuShortcut = (IWshRuntimeLibrary.IWshShortcut)(new IWshRuntimeLibrary.WshShell()).CreateShortcut(Path.Combine(StartMenuPath, "Scanner Tool.lnk"));
                    MenuShortcut.TargetPath = Path.Combine(ProgramDataPath, "Scanner Tool.exe");
                    MenuShortcut.WorkingDirectory = ProgramDataPath;
                    MenuShortcut.Save();
                }
                MessageBox.Show("Scanner Tool wurde erfolgreich installiert");
            }
            catch
            {
                MessageBox.Show("Sie müssen zuerst die Anwendung beenden, bevor Sie es installieren können.");
            }
        }
    }
}
