using System;
using System.Windows.Forms;
using GnomoriaLauncher.Internal;
using GnomoriaModSdk;

namespace GnomoriaLauncher
{
	static class Program
	{
		static void Main()
		{
			Test();
		}

		static void Test()
		{
			GnomoriaController controller = new GnomoriaController();
			controller.ReadMods();
			if(controller.FailedMods.Count > 0)
			{
				MessageBox.Show(string.Format("{0} mods weren't loaded.", controller.FailedMods.Count));
			}
			ModModule[] mods = controller.GetActiveMods();
			int disabled = controller.Mods.Count - mods.Length;
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
					mod.Mod.Open(controller.Game, settings);
				}
				catch(Exception e)
				{
					MessageBox.Show(e.ToString());
				}
			}

			controller.Run();
		}
	}
}
