using System;
using Game;
using GnomoriaModSdk;

namespace GnomoriaLauncher.Internal
{
	sealed class GnomoriaEvents : IGnomoriaEvents
	{
		private readonly GnomanEmpire _game = GnomanEmpire.Instance;
		private readonly UpdatableDrawableComponent _sniffer = new UpdatableDrawableComponent();

		#region IGnomoriaEvents

		public event Action Initialization
		{
			add { _sniffer.Initialization += value; }
			remove { _sniffer.Initialization -= value; }
		}

		public event GameEventHandler UpdateCalled
		{
			add { _sniffer.UpdateCalled += value; }
			remove { _sniffer.UpdateCalled -= value; }
		}

		public event GameEventHandler DrawCalled
		{
			add { _sniffer.DrawCalled += value; }
			remove { _sniffer.DrawCalled -= value; }
		}

		#endregion

		public void Run()
		{
			// TODO: subscribe to other events
			_game.Components.Add(_sniffer);
			_game.Run();
		}
	}
}
