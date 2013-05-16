using System;
using System.Windows.Forms;
using GnomoriaLauncher.Internal;
using GnomoriaModSdk;

namespace GnomoriaLauncher
{
	static class Program
	{
		private static GnomoriaController _controller;

		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			_controller = new GnomoriaController();
			Application.Run(new MainForm(_controller));
			if(_controller.Enabled)
			{
				Test();	// TODO
			}
		}

		static void Test()
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
#pragma warning disable 168
					bool saved = mod.Mod.Configure(null, settings);
#pragma warning restore 168
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
