namespace GnomoriaModSdk
{
	public interface ISettingsManager
	{
		ModSettings Load();
		void Save(ModSettings settings);
	}
}
