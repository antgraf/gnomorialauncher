using System;
using GnomoriaModSdk;

namespace GnomoriaLauncher.Internal
{
	sealed class ModModule
	{
		public IGnomoriaMod Mod { get; set; }
		public ModInformation Information { get; set; }
		public bool Enabled { get; set; }
		public bool MissedDependecies { get; set; }
		public Exception Exception { get; set; }
	}
}
