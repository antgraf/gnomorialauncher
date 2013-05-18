using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GnomoriaLauncher.Internal;
using GnomoriaModSdk;

namespace GnomoriaLauncher
{
	internal partial class ModInfoPanel : UserControl
	{
		private const string NameFormat = "{0} v{1}.{2}";

		private readonly ModModule _mod;
		private readonly ISettingsManager _settings;
		private readonly Color _linkErrorColor = Color.DarkRed;
		private Color? _linkDefaultColor;

		public event EventHandler CheckedChanged
		{
			add { chkEnabled.CheckedChanged += value; }
			remove { chkEnabled.CheckedChanged -= value; }
		}

		public bool Checked { get { return chkEnabled.Checked; } set { chkEnabled.Checked = value; } }

		public ModInfoPanel(ModModule mod)
		{
			if(mod == null)
			{
				throw new ArgumentNullException("mod");
			}
			_mod = mod;
			_settings = new SettingsManager(_mod.Information);
			InitializeComponent();
			RenderInfo();
		}

		private void RenderInfo()
		{
			if(_mod.Information.Icon != null)
			{
				Bitmap bmp = new Bitmap(picIcon.Image.Width, picIcon.Image.Height);
				using(Graphics gr = Graphics.FromImage(bmp))
				{
					gr.DrawImage(_mod.Information.Icon, 0, 0, bmp.Width, bmp.Height);
				}
				picIcon.Image = bmp;
			}
			lblName.Text = string.Format(NameFormat, _mod.Information.CodeName, _mod.Information.Version.Major, _mod.Information.Version.Minor);
			lblDescription.Text = _mod.Information.Description;
			lblFileName.Text = Path.GetFileName(_mod.FileName);
			UpdateDependencies(_mod.MissedDependecies);
		}

		public void UpdateDependencies(int missedDependecies)
		{
			if(_linkDefaultColor == null)
			{
				_linkDefaultColor = lblDependecies.ActiveLinkColor;
			}

			int dependencies = _mod.Information.Dependencies == null ? 0 : _mod.Information.Dependencies.Count();
			if(missedDependecies == 0)
			{
				lblDependecies.Text = string.Format("{0} dependencies", dependencies);
				lblDependecies.ActiveLinkColor = (Color)_linkDefaultColor;
			}
			else
			{
				lblDependecies.Text = string.Format("{0} out of {1} dependencies missed", missedDependecies, dependencies);
				lblDependecies.ActiveLinkColor = _linkErrorColor;
			}
		}

		private void BtnSettingsClick(object sender, EventArgs e)
		{
			_mod.Mod.Configure(this, _settings);
		}

		private void LblDependeciesLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// TODO
		}
	}
}
