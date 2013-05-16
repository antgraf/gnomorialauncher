namespace GnomoriaLauncher
{
	partial class ModInfoPanel
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.picIcon = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// picIcon
			// 
			this.picIcon.Image = global::GnomoriaLauncher.Properties.Resources.DefaultIcon;
			this.picIcon.Location = new System.Drawing.Point(3, 3);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new System.Drawing.Size(64, 64);
			this.picIcon.TabIndex = 0;
			this.picIcon.TabStop = false;
			// 
			// ModInfoPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.picIcon);
			this.Name = "ModInfoPanel";
			this.Size = new System.Drawing.Size(413, 150);
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picIcon;
	}
}
