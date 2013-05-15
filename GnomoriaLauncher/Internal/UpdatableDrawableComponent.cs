using System;
using GnomoriaModSdk;
using Microsoft.Xna.Framework;

namespace GnomoriaLauncher.Internal
{
	sealed class UpdatableDrawableComponent : IDisposable, IGameComponent, IUpdateable, IDrawable
	{
		public UpdatableDrawableComponent()
		{
			DrawOrder = 0;
			UpdateOrder = 0;
			Enabled = true;
			Visible = true;
		}

		#region IDisposable

		public void Dispose()
		{
			// TODO
		}

		#endregion

		#region IGameComponent

		public void Initialize()
		{
			Action handler = Initialization;
			if(handler != null)
			{
				handler();
			}
		}

		#endregion

		#region IUpdateable

		public void Update(GameTime gameTime)
		{
			GameEventHandler handler = UpdateCalled;
			if(handler != null)
			{
				handler(gameTime);
			}
		}

		public bool Enabled { get; private set; }
		public int UpdateOrder { get; private set; }
		public event EventHandler<EventArgs> EnabledChanged;
		public event EventHandler<EventArgs> UpdateOrderChanged;

		#endregion

		#region IDrawable

		public void Draw(GameTime gameTime)
		{
			GameEventHandler handler = DrawCalled;
			if(handler != null)
			{
				handler(gameTime);
			}
		}

		public bool Visible { get; private set; }
		public int DrawOrder { get; private set; }
		public event EventHandler<EventArgs> VisibleChanged;
		public event EventHandler<EventArgs> DrawOrderChanged;

		#endregion

		public event Action Initialization;
		public event GameEventHandler UpdateCalled;
		public event GameEventHandler DrawCalled;

// ReSharper disable UnusedMember.Local
		private void MakeCompilerHappy()
// ReSharper restore UnusedMember.Local
		{
			EnabledChanged(this, EventArgs.Empty);
			UpdateOrderChanged(this, EventArgs.Empty);
			VisibleChanged(this, EventArgs.Empty);
			DrawOrderChanged(this, EventArgs.Empty);
		}
	}
}
