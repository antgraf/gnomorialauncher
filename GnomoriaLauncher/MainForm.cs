using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GnomoriaLauncher.Internal;

namespace GnomoriaLauncher
{
	internal partial class MainForm : Form
	{
		private GnomoriaController _controller;

		public MainForm(GnomoriaController controller)
		{
			_controller = controller;
			InitializeComponent();
		}
	}
}
