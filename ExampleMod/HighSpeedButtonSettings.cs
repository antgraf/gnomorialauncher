using GnomoriaModSdk;

namespace ExampleMod
{
	public class HighSpeedButtonSettings : ModSettings
	{
		public HighSpeedButtonSettings()
		{
			TimeSpeedFactor = 10;
		}

		public int TimeSpeedFactor { get; set; }
	}
}
