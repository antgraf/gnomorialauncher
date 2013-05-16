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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModInfoPanel));
			this.picIcon = new System.Windows.Forms.PictureBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblFileName = new System.Windows.Forms.Label();
			this.btnSettings = new System.Windows.Forms.Button();
			this.lblDependecies = new System.Windows.Forms.LinkLabel();
			this.chkEnabled = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// picIcon
			// 
			this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
			this.picIcon.Location = new System.Drawing.Point(24, 3);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new System.Drawing.Size(64, 64);
			this.picIcon.TabIndex = 0;
			this.picIcon.TabStop = false;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(95, 4);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(107, 13);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "CodeName + Version";
			// 
			// lblDescription
			// 
			this.lblDescription.Location = new System.Drawing.Point(95, 21);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(288, 33);
			this.lblDescription.TabIndex = 2;
			this.lblDescription.Text = "Description\r\nMultiline";
			// 
			// lblFileName
			// 
			this.lblFileName.AutoSize = true;
			this.lblFileName.Enabled = false;
			this.lblFileName.Location = new System.Drawing.Point(95, 54);
			this.lblFileName.Name = "lblFileName";
			this.lblFileName.Size = new System.Drawing.Size(80, 13);
			this.lblFileName.TabIndex = 3;
			this.lblFileName.Text = "FileName.gmod";
			// 
			// btnSettings
			// 
			this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSettings.Image = global::GnomoriaLauncher.Properties.Resources.Gear;
			this.btnSettings.Location = new System.Drawing.Point(393, 3);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(42, 42);
			this.btnSettings.TabIndex = 4;
			this.btnSettings.UseVisualStyleBackColor = true;
			this.btnSettings.Click += new System.EventHandler(this.BtnSettingsClick);
			// 
			// lblDependecies
			// 
			this.lblDependecies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDependecies.Location = new System.Drawing.Point(264, 54);
			this.lblDependecies.Name = "lblDependecies";
			this.lblDependecies.Size = new System.Drawing.Size(171, 13);
			this.lblDependecies.TabIndex = 5;
			this.lblDependecies.TabStop = true;
			this.lblDependecies.Text = "XX Dependencies (missed)";
			this.lblDependecies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblDependecies.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblDependeciesLinkClicked);
			// 
			// chkEnabled
			// 
			this.chkEnabled.AutoSize = true;
			this.chkEnabled.Checked = true;
			this.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkEnabled.Location = new System.Drawing.Point(3, 28);
			this.chkEnabled.Name = "chkEnabled";
			this.chkEnabled.Size = new System.Drawing.Size(15, 14);
			this.chkEnabled.TabIndex = 6;
			this.chkEnabled.UseVisualStyleBackColor = true;
			// 
			// ModInfoPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.chkEnabled);
			this.Controls.Add(this.lblDependecies);
			this.Controls.Add(this.btnSettings);
			this.Controls.Add(this.lblFileName);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.picIcon);
			this.Name = "ModInfoPanel";
			this.Size = new System.Drawing.Size(438, 70);
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picIcon;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblFileName;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.LinkLabel lblDependecies;
		private System.Windows.Forms.CheckBox chkEnabled;
	}
}
