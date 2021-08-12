using IWshRuntimeLibrary;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GoogleChromePopupMaker
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void CreateShortcut_MSClick(object sender, EventArgs e)
		{
			object shDesktop = "Desktop";
			WshShell shell = new WshShell();

			string fileName = string.Format("{0}\\{1}.lnk",
				shell.SpecialFolders.Item(ref shDesktop), txtShortcutFileName.Text);
			string targetPath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
			string arguments = string.Format("--app=\"{0}\"", txtShortcutWebsite.Text);
			string workingDir = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
			IWshShortcut shortcut = shell.CreateShortcut(fileName);
			shortcut.Arguments = arguments;
			shortcut.TargetPath = targetPath;
			shortcut.WorkingDirectory = workingDir;
			shortcut.Save();
		}
		private void DisplayPopup_MSClick(object sender, EventArgs e)
		{
			ProcessStartInfo startinfo = new ProcessStartInfo();
			startinfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
			startinfo.Arguments = string.Format("--app=\"{0}\"", txtPopupLink.Text);
			Process.Start(startinfo);
		}
	}
}
