using System;
using System.Collections.Generic;
using System.Drawing;

namespace GnomoriaModSdk
{
	public class ModInformation
	{
		public string CodeName { get; set; }
		public Version Version { get; set; }
		public string Description { get; set; }
		public Guid Id { get; set; }
		public Bitmap Icon { get; set; }
		public IEnumerable<Guid> Dependencies { get; set; }
		public Type SettingsType { get; set; }
		public Type[] AdditionalSettingsTypes { get; set; }
	}
}
