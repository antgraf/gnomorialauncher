using System;
using System.Windows.Forms;
using GnomoriaLauncher.Internal;
using GnomoriaLauncher.Properties;

namespace GnomoriaLauncher
{
	internal partial class MainForm : Form
	{
		private readonly GnomoriaController _controller;
		private bool _faarksMods = false;

		public MainForm(GnomoriaController controller)
		{
			_controller = controller;
			InitializeComponent();
			UpdateRunButton();
		}

		private void UpdateRunButton()
		{
			btnRun.Text = _faarksMods ? Resources.MainForm_UpdateRunButton_Run_with_Faarks_mods : Resources.MainForm_UpdateRunButton_Run;
		}

		private void Exit()
		{
			Application.Exit();
		}

		private void MainFormLoad(object sender, EventArgs e)
		{
			LoadMods();
		}

		private void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Exit();
		}

		private void RunToolStripMenuItem1Click(object sender, EventArgs e)
		{
			_faarksMods = false;
			UpdateRunButton();
		}

		private void RunWithFaarksModsToolStripMenuItemClick(object sender, EventArgs e)
		{
			_faarksMods = true;
			UpdateRunButton();
		}

		private void ReloadModsToolStripMenuItemClick(object sender, EventArgs e)
		{
			LoadMods();
		}

		private void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			new AboutBox().ShowDialog(this);
		}

		private void BtnRunClick(object sender, EventArgs e)
		{
			Run();
		}

		private void BtnCancelClick(object sender, EventArgs e)
		{
			Exit();
		}
	}
}
