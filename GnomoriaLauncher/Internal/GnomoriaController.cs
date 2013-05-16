using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using GnomoriaModSdk;

namespace GnomoriaLauncher.Internal
{
	sealed class GnomoriaController
	{
		private const string ModsFolder = "Mods";
		private const string ModsFilter = "*.gmod";

		private readonly GnomoriaEvents _game;

		public Dictionary<Guid, ModModule> Mods { get; private set; }
		public List<string> FailedMods { get; private set; }
		public IGnomoriaEvents Game { get { return _game; } }
		public bool Enabled { get; set; }

		public GnomoriaController()
		{
			Mods = new Dictionary<Guid, ModModule>();
			FailedMods = new List<string>();
			_game = new GnomoriaEvents();
		}

		public void Run()
		{
			_game.Run();
		}

		public void ReadMods()
		{
			Mods.Clear();
			FailedMods.Clear();

			string folder = Path.GetDirectoryName(Application.ExecutablePath);
			Debug.Assert(folder != null, "folder != null");
			string[] modFiles = Directory.GetFiles(Path.Combine(folder, ModsFolder), ModsFilter);
			foreach(string file in modFiles)
			{
				ModModule module = new ModModule();
				try
				{
					Assembly assembly = Assembly.LoadFrom(file);
					IGnomoriaMod mod = CreateGnomoriaMod(assembly);
					if(mod == null)
					{
						throw new EntryPointNotFoundException("Cannot instantiate the base class derived from IGnomoriaMod.");
					}
					ModInformation info = mod.Handshake();
					CheckInformation(info);
					module.Information = info;
					module.Mod = mod;
					ModSettings settings = new SettingsManager(info).Load();
					module.Enabled = settings.Enabled;
				}
				catch(Exception e)
				{
					module.Exception = e;
				}

				if(module.Information != null && module.Information.Id != Guid.Empty && !Mods.ContainsKey(module.Information.Id))
				{
					Mods.Add(module.Information.Id, module);
				}
				else
				{
					FailedMods.Add(file);
				}
			}
			Validate();
		}

		public void Validate()
		{
			CheckDependencies();
		}

		public ModModule[] GetActiveMods()
		{
			Validate();
			return (from mod in Mods.Values where mod.Enabled && !mod.MissedDependecies && mod.Exception == null select mod).ToArray();
		}

		private IGnomoriaMod CreateGnomoriaMod(Assembly assembly)
		{
			return (from t in assembly.GetTypes() where typeof(IGnomoriaMod).IsAssignableFrom(t) select (IGnomoriaMod) assembly.CreateInstance(t.ToString())).FirstOrDefault();
		}

		private void CheckInformation(ModInformation info)
		{
			if(info == null)
			{
				throw new ArgumentNullException("info", "ModInformation nust not be null.");
			}
			if(string.IsNullOrEmpty(info.CodeName))
			{
				throw new ArgumentException("Empty ModInformation.CodeName is not allowed.", "info");
			}
			if(info.Id == Guid.Empty)
			{
				throw new ArgumentException("Empty ModInformation.Id is not allowed.", "info");
			}
			if(info.SettingsType == null)
			{
				throw new ArgumentException("ModInformation.SettingsType must not be null.", "info");
			}
		}

		private void CheckDependencies()
		{
			// TODO: check for level 2+ dependencies
			foreach(ModModule mod in Mods.Values)
			{
				mod.MissedDependecies = false;
				if(mod.Information.Dependencies != null)
				{
					foreach(Guid dependency in mod.Information.Dependencies)
					{
						if(!Mods.ContainsKey(dependency) || !Mods[dependency].Enabled || Mods[dependency].Exception != null)
						{
							mod.MissedDependecies = true;
						}
					}
				}
			}
		}
	}
}
