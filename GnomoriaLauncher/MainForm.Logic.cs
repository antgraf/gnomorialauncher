using System.Collections.Generic;
using System.Diagnostics;
using GnomoriaLauncher.Internal;

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
			// TODO
		}

		private ModInfoPanel CreateModPanel(ModModule mod)
		{
			return new ModInfoPanel(mod) { Width = pnlMods.ClientSize.Width - pnlMods.Margin.Left - pnlMods.Margin.Right };
		}

		private void DrawPanels()
		{
			pnlMods.Controls.Clear();
			Debug.Assert(_panels != null, "_panels != null");
// ReSharper disable CoVariantArrayConversion
			pnlMods.Controls.AddRange(_panels.ToArray());
// ReSharper restore CoVariantArrayConversion
		}
	}
}
