using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using GnomoriaModSdk;

namespace GnomoriaLauncher.Internal
{
	sealed class SettingsManager : ISettingsManager
	{
		private const string SettingsPath = @"ModSettings\";
		private const string SettingsExt = ".ModSettings";

		private readonly ModInformation _info;

		public SettingsManager(ModInformation info)
		{
			_info = info;
		}

		#region ISettingsManager

		public ModSettings Load()
		{
			return (ModSettings)typeof(SettingsManager).GetMethod("LoadInternal", BindingFlags.NonPublic | BindingFlags.Static)
			                       .MakeGenericMethod(_info.SettingsType)
			                       .Invoke(null, new object[] { GetSettingsPath(), _info.AdditionalSettingsTypes});
		}

		public void Save(ModSettings settings)
		{
			SaveInternal(settings, GetSettingsPath(), _info.AdditionalSettingsTypes);
		}

		#endregion

		private string GetSettingsPath()
		{
			string fileName = SettingsPath + _info.CodeName + SettingsExt;
			string folder = Path.GetDirectoryName(Application.ExecutablePath);
			Debug.Assert(folder != null, "folder != null");
			return Path.Combine(folder, fileName);
		}

		private static string XmlSerialize(ModSettings settings, Type[] types = null)
		{
			XmlSerializer xmler = types == null ? new XmlSerializer(settings.GetType()) : new XmlSerializer(settings.GetType(), types);
			MemoryStream stream = new MemoryStream();
			xmler.Serialize(stream, settings);
			byte[] buf = stream.ToArray();
			return Encoding.UTF8.GetString(buf);
		}

		private static T XmlDeserialize<T>(string xml, Type[] types = null)
		{
			XmlSerializer xmler = types == null ? new XmlSerializer(typeof(T)) : new XmlSerializer(typeof(T), types);
			byte[] buf = Encoding.UTF8.GetBytes(xml);
			MemoryStream stream = new MemoryStream(buf, false);
			return (T)xmler.Deserialize(stream);
		}

// ReSharper disable UnusedMember.Local
		private static void SaveInternal(ModSettings settings, string path, Type[] types = null)
// ReSharper restore UnusedMember.Local
		{
			using(TextWriter writer = new StreamWriter(path, false, Encoding.UTF8))
			{
				writer.Write(XmlSerialize(settings, types));
			}
		}

// ReSharper disable UnusedMember.Local
		private static T LoadInternal<T>(string path, Type[] types = null)
// ReSharper restore UnusedMember.Local
		{
			try
			{
				string xml;
				using(TextReader reader = new StreamReader(path, Encoding.UTF8))
				{
					xml = reader.ReadToEnd();
				}
				return XmlDeserialize<T>(xml, types);
			}
			catch(Exception)
			{
				return Activator.CreateInstance<T>();
			}
		}
	}
}
