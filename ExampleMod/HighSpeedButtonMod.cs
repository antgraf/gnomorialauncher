using System;
using System.Windows.Forms;
using ExampleMod.Properties;
using GnomoriaModSdk;
using Game;
using Game.GUI;
using Game.GUI.Controls;
using Microsoft.Xna.Framework;
using XnaButton = Game.GUI.Controls.Button;
using XnaEventArgs = Game.GUI.Controls.EventArgs;

namespace ExampleMod
{
	public class HighSpeedButtonMod : IGnomoriaMod
	{
		private const string CodeName = "HighSpeedButton";
		private const float SpeedButtonLeftFactor = 1002f / 1920f;
		private const float SpeedButtonTopFactor = 42f / 1080f;
		private static readonly Color ActiveButtonColor = new Color(0xbf, 0x77, 0x2f);
		private static readonly Color InactiveButtonColor = Color.White;

		private readonly Guid _guid = new Guid("1CA7C433-6845-4A0B-93BB-7422B2D32A52");

		private IGnomoriaEvents _game;
		private int _speed;
		private XnaButton _btnSpeed;

		#region IGnomoriaMod

		public ModInformation Handshake()
		{
			return new ModInformation
			{
				CodeName = CodeName,
				Description = Resources.HighSpeedButtonMod_Description,
				Id = _guid,
				Icon = Resources.Lightning,
				Dependencies = null,
				SettingsType = typeof(HighSpeedButtonSettings),
				AdditionalSettingsTypes = null
			};
		}

		public bool Configure(IWin32Window parent, ISettingsManager settings)
		{
			HighSpeedButtonSettings data = (HighSpeedButtonSettings)settings.Load();
			SettingsForm form = new SettingsForm {Speed = data.TimeSpeedFactor};
			bool yes = form.ShowDialog(parent) == DialogResult.OK;
			if(yes)
			{
				data.TimeSpeedFactor = form.Speed;
				settings.Save(data);
			}
			return yes;
		}

		public void Open(IGnomoriaEvents events, ISettingsManager settings)
		{
			HighSpeedButtonSettings load = (HighSpeedButtonSettings)settings.Load();
			_speed = load.TimeSpeedFactor;
			_game = events;
			Subscribe();
		}

		#endregion

		#region IDisposable

		public void Dispose()
		{
			Unsubscribe();
		}

		#endregion

		private void Subscribe()
		{
			_game.UpdateCalled += Update;
		}

		private void Unsubscribe()
		{
			_game.UpdateCalled -= Update;
		}

		private void Update(GameTime time)
		{
			GnomanEmpire game = GnomanEmpire.Instance;
			GuiManager manager = game.GuiManager;
			if(manager.HUD != null && manager.HUD.IsHUDActive)
			{
				if(_btnSpeed == null)
				{
					_btnSpeed = new XnaButton(manager.Manager);
					_btnSpeed.Init();
					_btnSpeed.Margins = new Margins(4, 8, 4, 4);
					_btnSpeed.Top = (int)(SpeedButtonTopFactor * manager.Manager.ScreenHeight);
					_btnSpeed.Left = (int)(SpeedButtonLeftFactor * manager.Manager.ScreenWidth);
					_btnSpeed.CanFocus = false;
					_btnSpeed.Glyph = new Glyph(manager.Manager.Skin.Images["Icon.TimeControls"].Resource)
					{
						SourceRect = new Rectangle(16, 0, 16, 16),
						SizeMode = SizeMode.Centered,
						Color = InactiveButtonColor
					};
					_btnSpeed.Width = 18;
					_btnSpeed.Height = 18;
					_btnSpeed.Mode = ButtonMode.Normal;
					_btnSpeed.Click += BtnSpeedClick;
					manager.Add(_btnSpeed);
				}
				UpadteSpeedButton();
			}
		}

		private void BtnSpeedClick(object sender, XnaEventArgs e)
		{
			World world = GnomanEmpire.Instance.World;
			world.Paused.Value = false;
			world.GameSpeed.Value = _speed;
			UpadteSpeedButton();
		}

		private void UpadteSpeedButton()
		{
			_btnSpeed.BringToFront();
			World world = GnomanEmpire.Instance.World;
			if(world.Paused.Value || world.GameSpeed.Value < _speed - 0.01f)
			{
				_btnSpeed.Glyph.Color = InactiveButtonColor;
			}
			else
			{
				_btnSpeed.Glyph.Color = ActiveButtonColor;
			}
		}
	}
}
