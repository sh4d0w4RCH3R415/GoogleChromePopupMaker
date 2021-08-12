using System.Diagnostics;

namespace ProcessRunner
{
	public static class ProcStarter
	{
		/// <summary>
		/// Runs a new <see cref="Process"/>.
		/// </summary>
		/// <param name="FileName">The program to run.</param>
		/// <param name="CLArgs">The arguments to pass whilst opening the file.</param>
		public static void RunProc(string FileName, string CLArgs)
		{
			ProcessStartInfo startinfo = new ProcessStartInfo();
			startinfo.FileName = FileName;
			startinfo.Arguments = CLArgs;
			Process.Start(startinfo);
		}
	}
}
