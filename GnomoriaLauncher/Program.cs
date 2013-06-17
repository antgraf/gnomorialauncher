using System;
using System.Windows.Forms;
using GnomoriaLauncher.Internal;
using GnomoriaModSdk;

namespace GnomoriaLauncher
{
	static class Program
	{
		private static GnomoriaController _controller;

		static void Main(string[] args)
		{
			_controller = new GnomoriaController();
			if(args == null || args.Length != 1)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm(_controller));
			}
			else //if(_controller.Enabled)
			{
				Run();
			}
		}

		static void Run()
		{
			_controller.ReadMods();
			if(_controller.FailedMods.Count > 0)
			{
				MessageBox.Show(string.Format("{0} mods weren't loaded.", _controller.FailedMods.Count));
			}
			ModModule[] mods = _controller.GetActiveMods();
			int disabled = _controller.Mods.Count - mods.Length;
			if(disabled > 0)
			{
				MessageBox.Show(string.Format("{0} mods are disabled or throw an error.", disabled));
			}

			foreach(ModModule mod in mods)
			{
				try
				{
					ISettingsManager settings = new SettingsManager(mod.Information);
					mod.Mod.Open(_controller.Game, settings);
				}
				catch(Exception e)
				{
					MessageBox.Show(e.ToString());
				}
			}

			_controller.Run();
		}
	}
}
