namespace GnomoriaLauncher
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.runWithFaarksModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.reloadModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlMods = new System.Windows.Forms.FlowLayoutPanel();
			this.btnRun = new wyDay.Controls.SplitButton();
			this.mnuRun = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnCancel = new System.Windows.Forms.Button();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.mnuMain.SuspendLayout();
			this.mnuRun.SuspendLayout();
			this.statusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(473, 24);
			this.mnuMain.TabIndex = 0;
			this.mnuMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// actionToolStripMenuItem
			// 
			this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem1,
            this.runWithFaarksModsToolStripMenuItem,
            this.toolStripSeparator1,
            this.reloadModsToolStripMenuItem});
			this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
			this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.actionToolStripMenuItem.Text = "A&ction";
			// 
			// runToolStripMenuItem1
			// 
			this.runToolStripMenuItem1.Name = "runToolStripMenuItem1";
			this.runToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
			this.runToolStripMenuItem1.Text = "&Run";
			this.runToolStripMenuItem1.Click += new System.EventHandler(this.RunToolStripMenuItem1Click);
			// 
			// runWithFaarksModsToolStripMenuItem
			// 
			this.runWithFaarksModsToolStripMenuItem.Name = "runWithFaarksModsToolStripMenuItem";
			this.runWithFaarksModsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.runWithFaarksModsToolStripMenuItem.Text = "Run with &Faarks mods";
			this.runWithFaarksModsToolStripMenuItem.Click += new System.EventHandler(this.RunWithFaarksModsToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
			// 
			// reloadModsToolStripMenuItem
			// 
			this.reloadModsToolStripMenuItem.Name = "reloadModsToolStripMenuItem";
			this.reloadModsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.reloadModsToolStripMenuItem.Text = "Re&load mods";
			this.reloadModsToolStripMenuItem.Click += new System.EventHandler(this.ReloadModsToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// pnlMods
			// 
			this.pnlMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMods.AutoScroll = true;
			this.pnlMods.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.pnlMods.Location = new System.Drawing.Point(0, 27);
			this.pnlMods.Name = "pnlMods";
			this.pnlMods.Size = new System.Drawing.Size(473, 153);
			this.pnlMods.TabIndex = 1;
			// 
			// btnRun
			// 
			this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRun.AutoSize = true;
			this.btnRun.ContextMenuStrip = this.mnuRun;
			this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnRun.Location = new System.Drawing.Point(150, 186);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(230, 51);
			this.btnRun.SplitMenuStrip = this.mnuRun;
			this.btnRun.TabIndex = 2;
			this.btnRun.Text = "[RUN with Faarks mods]";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.BtnRunClick);
			// 
			// mnuRun
			// 
			this.mnuRun.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.runWithToolStripMenuItem});
			this.mnuRun.Name = "mnuRun";
			this.mnuRun.Size = new System.Drawing.Size(191, 70);
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.runToolStripMenuItem.Text = "&Run";
			this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
			// 
			// runWithToolStripMenuItem
			// 
			this.runWithToolStripMenuItem.Name = "runWithToolStripMenuItem";
			this.runWithToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.runWithToolStripMenuItem.Text = "Run with &Faarks mods";
			this.runWithToolStripMenuItem.Click += new System.EventHandler(this.runWithToolStripMenuItem_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(386, 186);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 51);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Exit";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// statusBar
			// 
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusBar.Location = new System.Drawing.Point(0, 240);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(473, 22);
			this.statusBar.TabIndex = 4;
			this.statusBar.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(39, 17);
			this.lblStatus.Text = "Ready";
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnRun;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(473, 262);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.pnlMods);
			this.Controls.Add(this.mnuMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mnuMain;
			this.Name = "MainForm";
			this.Text = "Gnomoria Mods Launcher";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.mnuRun.ResumeLayout(false);
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.FlowLayoutPanel pnlMods;
		private wyDay.Controls.SplitButton btnRun;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ContextMenuStrip mnuRun;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runWithToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem runWithFaarksModsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem reloadModsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;


	}
}