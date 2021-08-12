using IWshRuntimeLibrary;

namespace ShortcutCreator
{
	public class SHCreator
	{
		/// <summary>
		/// Creates a new <see cref="Shortcut"/> on the desktop.
		/// </summary>
		/// <param name="FileName">The name of the shortcut file itself.</param>
		/// <param name="TargetPath">The file path to the file to open.</param>
		/// <param name="WorkingDirectory">The directory containing the file to open.</param>
		/// <param name="FileArguments">The command-line arguments to pass whilst opening the file.</param>
		internal SHCreator(string FileName, string TargetPath, string WorkingDirectory, string FileArguments)
		{
			object shDesktop = "Desktop";
			WshShell shell = new WshShell();
			string path = shell.SpecialFolders.Item(ref shDesktop).ToString() + "\\" + FileName;
			IWshShortcut shortcut = shell.CreateShortcut(path);
			shortcut.Arguments = FileArguments;
			shortcut.TargetPath = TargetPath;
			shortcut.WorkingDirectory = WorkingDirectory;
			shortcut.Save();
		}

		/// <summary>
		/// Creates a new <see cref="Shortcut"/> on the desktop.
		/// </summary>
		/// <param name="FileName">The name of the shortcut file itself.</param>
		/// <param name="TargetPath">The file path to the file to open.</param>
		/// <param name="WorkingDirectory">The directory containing the file to open.</param>
		/// <param name="CLArgs">The command-line arguments to pass whilst opening the file.</param>
		public static void Create(string FileName, string TargetPath, string WorkingDirectory, string CLArgs)
		{
			new SHCreator(FileName, TargetPath, WorkingDirectory, CLArgs);
		}
	}
}
