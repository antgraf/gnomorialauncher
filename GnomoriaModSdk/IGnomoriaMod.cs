using System;
using System.Windows.Forms;
using Microsoft.Xna.Framework;

namespace GnomoriaModSdk
{
	public delegate void GameEventHandler(GameTime gameTime);

	public interface IGnomoriaMod : IDisposable
	{
		ModInformation Handshake();
		bool Configure(IWin32Window parent, ISettingsManager settings);
		void Open(IGnomoriaEvents events, ISettingsManager settings);
	}
}
