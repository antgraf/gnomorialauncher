using System;

namespace GnomoriaModSdk
{
	public interface IGnomoriaEvents
	{
		event Action Initialization;
		event GameEventHandler UpdateCalled;
		event GameEventHandler DrawCalled;
	}
}
