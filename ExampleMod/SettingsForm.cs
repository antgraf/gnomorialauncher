using System;
using System.Globalization;
using System.Windows.Forms;

namespace ExampleMod
{
	public partial class SettingsForm : Form
	{
		private string _caption;

		public SettingsForm()
		{
			InitializeComponent();
		}

		public int Speed { get { return trackSpeed.Value; } set { trackSpeed.Value = value; } }

		private void SettingsFormLoad(object sender, EventArgs e)
		{
			UpdateLabel();
		}

		private void TrackSpeedScroll(object sender, EventArgs e)
		{
			UpdateLabel();
		}

		private void UpdateLabel()
		{
			if(_caption == null)
			{
				_caption = lblCaption.Text;
			}
			lblCaption.Text = _caption + trackSpeed.Value.ToString(CultureInfo.InvariantCulture);
		}
	}
}
