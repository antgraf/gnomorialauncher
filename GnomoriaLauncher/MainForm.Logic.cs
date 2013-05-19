using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using GnomoriaLauncher.Internal;
using GnomoriaLauncher.Properties;

namespace GnomoriaLauncher
{
	partial class MainForm
	{
		private const string GnomoriaFilename = "Gnomoria.exe";
		private const string GnomoriaModdedFilename = "GnomoriaModded.exe";

		private readonly List<ModInfoPanel> _panels = new List<ModInfoPanel>();

		private void LoadMods()
		{
			_controller.ReadMods();
			ModModule[] mods = _controller.GetActiveMods();
			_panels.Clear();
			foreach(ModModule mod in mods)
			{
				_panels.Add(CreateModPanel(mod));
			}
			DrawPanels();
		}

		private void Run()
		{
			string exe = _faarksMods ? GnomoriaModdedFilename : GnomoriaFilename;
			ModModule[] mods = _controller.GetActiveMods();
			foreach(ModModule mod in mods)
			{
				if(mod.Enabled && mod.Exception == null && mod.MissedDependecies == 0)
				{
					try
					{
						mod.Mod.Open(_controller.Game, new SettingsManager(mod.Information));
					}
					catch(Exception e)
					{
						lblStatus.Text = string.Format(Resources.MainForm_Run_Mod_load_failed, mod.Information.CodeName, e);
					}
				}
			}

			// TODO: Support Faarks mods
			new Thread(() => _controller.Run()).Start();
		}

		private ModInfoPanel CreateModPanel(ModModule mod)
		{
			ModInfoPanel panel = new ModInfoPanel(mod) { Width = pnlMods.ClientSize.Width - pnlMods.Margin.Left - pnlMods.Margin.Right };
			panel.CheckedChanged += PanelCheckedChanged;
			return panel;
		}

		private void DrawPanels()
		{
			pnlMods.Controls.Clear();
			Debug.Assert(_panels != null, "_panels != null");
// ReSharper disable CoVariantArrayConversion
			pnlMods.Controls.AddRange(_panels.ToArray());
// ReSharper restore CoVariantArrayConversion
		}

		void PanelCheckedChanged(object sender, EventArgs e)
		{
			_controller.Validate();
			// TODO
		}
	}
}
