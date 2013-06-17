using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using GnomoriaLauncher.Internal;

namespace GnomoriaLauncher
{
	partial class MainForm
	{
		private const string ModdedLauncherFilename = "GnomoriaLauncherFaarksMods.exe";

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
			string self = Application.ExecutablePath;
			string selfModded = Path.Combine(Application.StartupPath, ModdedLauncherFilename);
			Process.Start(_faarksMods ? selfModded : self, "-execute");
			Application.Exit();
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
