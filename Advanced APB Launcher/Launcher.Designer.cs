﻿namespace Advanced_APB_Launcher
{
	// Token: 0x0200000A RID: 10
	public partial class Launcher : System.Windows.Forms.Form
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00003F84 File Offset: 0x00002184
		[System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003FD4 File Offset: 0x000021D4
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Advanced_APB_Launcher.Launcher));
			this.StartBtn = new System.Windows.Forms.Button();
			this.SettingsBtn = new System.Windows.Forms.Button();
			this.UpdateBtn = new System.Windows.Forms.Button();
			this.NoMovies = new System.Windows.Forms.CheckBox();
			this.LanguageSelector = new System.Windows.Forms.ComboBox();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.ExitBtn = new System.Windows.Forms.Button();
			this.PingTimer = new System.Windows.Forms.Timer(this.components);
			this.Version = new System.Windows.Forms.Label();
			this.DownloadLink = new System.Windows.Forms.LinkLabel();
			this.UpdateLink = new System.Windows.Forms.LinkLabel();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.ServerLabel = new System.Windows.Forms.Label();
			this.LoginLabel = new System.Windows.Forms.Label();
			this.PatriotLabel = new System.Windows.Forms.Label();
			this.ObeyaLabel = new System.Windows.Forms.Label();
			this.ColbyLabel = new System.Windows.Forms.Label();
			this.JokerLabel = new System.Windows.Forms.Label();
			this.HanLabel = new System.Windows.Forms.Label();
			this.StatusLabel = new System.Windows.Forms.Label();
			this.LoginStatusLabel = new System.Windows.Forms.Label();
			this.PatriotStatusLabel = new System.Windows.Forms.Label();
			this.ObeyaStatusLabel = new System.Windows.Forms.Label();
			this.ColbyStatusLabel = new System.Windows.Forms.Label();
			this.JokerStatusLabel = new System.Windows.Forms.Label();
			this.HanStatusLabel = new System.Windows.Forms.Label();
			base.SuspendLayout();
			this.StartBtn.BackColor = System.Drawing.Color.Black;
			this.StartBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(105, 103, 106);
			this.StartBtn.FlatAppearance.BorderSize = 3;
			this.StartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(156, 109, 79);
			this.StartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(51, 51, 51);
			this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StartBtn.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.StartBtn.ForeColor = System.Drawing.Color.White;
			System.Windows.Forms.Control startBtn = this.StartBtn;
			System.Drawing.Point location = new System.Drawing.Point(360, 155);
			startBtn.Location = location;
			this.StartBtn.Name = "StartBtn";
			System.Windows.Forms.Control startBtn2 = this.StartBtn;
			System.Drawing.Size size = new System.Drawing.Size(167, 50);
			startBtn2.Size = size;
			this.StartBtn.TabIndex = 1;
			this.StartBtn.Text = "Start APB";
			this.StartBtn.UseVisualStyleBackColor = false;
			this.SettingsBtn.BackColor = System.Drawing.Color.Black;
			this.SettingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(105, 103, 106);
			this.SettingsBtn.FlatAppearance.BorderSize = 3;
			this.SettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(156, 109, 79);
			this.SettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(51, 51, 51);
			this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SettingsBtn.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.SettingsBtn.ForeColor = System.Drawing.Color.White;
			System.Windows.Forms.Control settingsBtn = this.SettingsBtn;
			location = new System.Drawing.Point(187, 155);
			settingsBtn.Location = location;
			this.SettingsBtn.Name = "SettingsBtn";
			System.Windows.Forms.Control settingsBtn2 = this.SettingsBtn;
			size = new System.Drawing.Size(167, 50);
			settingsBtn2.Size = size;
			this.SettingsBtn.TabIndex = 2;
			this.SettingsBtn.Text = "Settings";
			this.SettingsBtn.UseVisualStyleBackColor = false;
			this.UpdateBtn.BackColor = System.Drawing.Color.Black;
			this.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(105, 103, 106);
			this.UpdateBtn.FlatAppearance.BorderSize = 3;
			this.UpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(156, 109, 79);
			this.UpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(51, 51, 51);
			this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UpdateBtn.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.UpdateBtn.ForeColor = System.Drawing.Color.White;
			System.Windows.Forms.Control updateBtn = this.UpdateBtn;
			location = new System.Drawing.Point(15, 155);
			updateBtn.Location = location;
			this.UpdateBtn.Name = "UpdateBtn";
			System.Windows.Forms.Control updateBtn2 = this.UpdateBtn;
			size = new System.Drawing.Size(167, 50);
			updateBtn2.Size = size;
			this.UpdateBtn.TabIndex = 3;
			this.UpdateBtn.Text = "Update APB";
			this.UpdateBtn.UseVisualStyleBackColor = false;
			this.NoMovies.AutoSize = true;
			this.NoMovies.BackColor = System.Drawing.Color.Black;
			this.NoMovies.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.NoMovies.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(105, 103, 106);
			this.NoMovies.FlatAppearance.BorderSize = 3;
			this.NoMovies.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.NoMovies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(153, 110, 91);
			this.NoMovies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(51, 51, 51);
			this.NoMovies.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Control noMovies = this.NoMovies;
			location = new System.Drawing.Point(374, 126);
			noMovies.Location = location;
			this.NoMovies.Name = "NoMovies";
			System.Windows.Forms.Control noMovies2 = this.NoMovies;
			size = new System.Drawing.Size(153, 23);
			noMovies2.Size = size;
			this.NoMovies.TabIndex = 4;
			this.NoMovies.Text = "No In Game Movies";
			this.ToolTip1.SetToolTip(this.NoMovies, "Disables In Game Movies");
			this.NoMovies.UseVisualStyleBackColor = false;
			this.LanguageSelector.BackColor = System.Drawing.Color.Black;
			this.LanguageSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LanguageSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LanguageSelector.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.LanguageSelector.ForeColor = System.Drawing.Color.White;
			this.LanguageSelector.FormattingEnabled = true;
			this.LanguageSelector.Items.AddRange(new object[]
			{
				"English",
				"Français",
				"Deutsch",
				"Italiano",
				"Español"
			});
			System.Windows.Forms.Control languageSelector = this.LanguageSelector;
			location = new System.Drawing.Point(187, 126);
			languageSelector.Location = location;
			this.LanguageSelector.Name = "LanguageSelector";
			System.Windows.Forms.Control languageSelector2 = this.LanguageSelector;
			size = new System.Drawing.Size(167, 23);
			languageSelector2.Size = size;
			this.LanguageSelector.TabIndex = 5;
			this.ToolTip1.SetToolTip(this.LanguageSelector, "Changes In Game Language");
			this.ExitBtn.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(105, 103, 106);
			this.ExitBtn.FlatAppearance.BorderSize = 3;
			this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(156, 109, 79);
			this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(51, 51, 51);
			this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.ExitBtn.ForeColor = System.Drawing.Color.White;
			System.Windows.Forms.Control exitBtn = this.ExitBtn;
			location = new System.Drawing.Point(509, 0);
			exitBtn.Location = location;
			this.ExitBtn.Name = "ExitBtn";
			System.Windows.Forms.Control exitBtn2 = this.ExitBtn;
			size = new System.Drawing.Size(30, 30);
			exitBtn2.Size = size;
			this.ExitBtn.TabIndex = 7;
			this.ExitBtn.Text = "X";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.PingTimer.Enabled = true;
			this.PingTimer.Interval = 5000;
			this.Version.BackColor = System.Drawing.Color.Black;
			this.Version.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Version.Font = new System.Drawing.Font("Times New Roman", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.Version.ForeColor = System.Drawing.Color.Lime;
			System.Windows.Forms.Control version = this.Version;
			location = new System.Drawing.Point(150, 27);
			version.Location = location;
			this.Version.Name = "Version";
			System.Windows.Forms.Control version2 = this.Version;
			size = new System.Drawing.Size(239, 15);
			version2.Size = size;
			this.Version.TabIndex = 9;
			this.Version.Text = "Version: ";
			this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.DownloadLink.AutoSize = true;
			this.DownloadLink.LinkColor = System.Drawing.Color.Red;
			System.Windows.Forms.Control downloadLink = this.DownloadLink;
			location = new System.Drawing.Point(4, 10);
			downloadLink.Location = location;
			this.DownloadLink.Name = "DownloadLink";
			System.Windows.Forms.Control downloadLink2 = this.DownloadLink;
			size = new System.Drawing.Size(80, 13);
			downloadLink2.Size = size;
			this.DownloadLink.TabIndex = 10;
			this.DownloadLink.TabStop = true;
			this.DownloadLink.Text = "Click to Update";
			this.DownloadLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.DownloadLink.Visible = false;
			this.UpdateLink.ActiveLinkColor = System.Drawing.Color.Blue;
			this.UpdateLink.AutoSize = true;
			this.UpdateLink.ForeColor = System.Drawing.Color.White;
			this.UpdateLink.LinkColor = System.Drawing.Color.Lime;
			System.Windows.Forms.Control updateLink = this.UpdateLink;
			location = new System.Drawing.Point(4, 10);
			updateLink.Location = location;
			this.UpdateLink.Name = "UpdateLink";
			System.Windows.Forms.Control updateLink2 = this.UpdateLink;
			size = new System.Drawing.Size(142, 13);
			updateLink2.Size = size;
			this.UpdateLink.TabIndex = 11;
			this.UpdateLink.TabStop = true;
			this.UpdateLink.Text = "Check For Launcher Update";
			this.UpdateLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(254, 156, 22);
			System.Windows.Forms.Control titleLabel = this.TitleLabel;
			location = new System.Drawing.Point(150, 3);
			titleLabel.Location = location;
			this.TitleLabel.Name = "TitleLabel";
			System.Windows.Forms.Control titleLabel2 = this.TitleLabel;
			size = new System.Drawing.Size(239, 24);
			titleLabel2.Size = size;
			this.TitleLabel.TabIndex = 13;
			this.TitleLabel.Text = "Advanced APB Launcher 2.0";
			this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Button1.BackColor = System.Drawing.Color.FromArgb(139, 143, 144);
			this.Button1.Enabled = false;
			this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(91, 95, 96);
			this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = System.Drawing.Color.White;
			System.Windows.Forms.Control button = this.Button1;
			location = new System.Drawing.Point(17, 64);
			button.Location = location;
			this.Button1.Name = "Button1";
			System.Windows.Forms.Control button2 = this.Button1;
			size = new System.Drawing.Size(505, 29);
			button2.Size = size;
			this.Button1.TabIndex = 14;
			this.Button1.Text = "APB:DB Server Status";
			this.Button1.UseVisualStyleBackColor = false;
			this.ServerLabel.Font = new System.Drawing.Font("Times New Roman", 20.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.ServerLabel.ForeColor = System.Drawing.Color.FromArgb(254, 156, 22);
			System.Windows.Forms.Control serverLabel = this.ServerLabel;
			location = new System.Drawing.Point(13, 96);
			serverLabel.Location = location;
			this.ServerLabel.Name = "ServerLabel";
			System.Windows.Forms.Control serverLabel2 = this.ServerLabel;
			size = new System.Drawing.Size(94, 31);
			serverLabel2.Size = size;
			this.ServerLabel.TabIndex = 15;
			this.ServerLabel.Text = "Server";
			this.LoginLabel.Font = new System.Drawing.Font("Times New Roman", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Control loginLabel = this.LoginLabel;
			location = new System.Drawing.Point(13, 127);
			loginLabel.Location = location;
			this.LoginLabel.Name = "LoginLabel";
			System.Windows.Forms.Control loginLabel2 = this.LoginLabel;
			size = new System.Drawing.Size(94, 24);
			loginLabel2.Size = size;
			this.LoginLabel.TabIndex = 16;
			this.LoginLabel.Text = "Login";
			this.PatriotLabel.Font = new System.Drawing.Font("Times New Roman", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Control patriotLabel = this.PatriotLabel;
			location = new System.Drawing.Point(13, 151);
			patriotLabel.Location = location;
			this.PatriotLabel.Name = "PatriotLabel";
			System.Windows.Forms.Control patriotLabel2 = this.PatriotLabel;
			size = new System.Drawing.Size(94, 24);
			patriotLabel2.Size = size;
			this.PatriotLabel.TabIndex = 17;
			this.PatriotLabel.Text = "Patriot";
			this.ObeyaLabel.Font = new System.Drawing.Font("Times New Roman", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Control obeyaLabel = this.ObeyaLabel;
			location = new System.Drawing.Point(13, 175);
			obeyaLabel.Location = location;
			this.ObeyaLabel.Name = "ObeyaLabel";
			System.Windows.Forms.Control obeyaLabel2 = this.ObeyaLabel;
			size = new System.Drawing.Size(94, 24);
			obeyaLabel2.Size = size;
			this.ObeyaLabel.TabIndex = 18;
			this.ObeyaLabel.Text = "Obeya";
			this.ColbyLabel.Font = new System.Drawing.Font("Times New Roman", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Control colbyLabel = this.ColbyLabel;
			location = new System.Drawing.Point(13, 199);
			colbyLabel.Location = location;
			this.ColbyLabel.Name = "ColbyLabel";
			System.Windows.Forms.Control colbyLabel2 = this.ColbyLabel;
			size = new System.Drawing.Size(94, 24);
			colbyLabel2.Size = size;
			this.ColbyLabel.TabIndex = 19;
			this.ColbyLabel.Text = "Colby";
			this.JokerLabel.Font = new System.Drawing.Font("Times New Roman", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Control jokerLabel = this.JokerLabel;
			location = new System.Drawing.Point(13, 223);
			jokerLabel.Location = location;
			this.JokerLabel.Name = "JokerLabel";
			System.Windows.Forms.Control jokerLabel2 = this.JokerLabel;
			size = new System.Drawing.Size(94, 24);
			jokerLabel2.Size = size;
			this.JokerLabel.TabIndex = 20;
			this.JokerLabel.Text = "Joker";
			this.HanLabel.Font = new System.Drawing.Font("Times New Roman", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Control hanLabel = this.HanLabel;
			location = new System.Drawing.Point(13, 247);
			hanLabel.Location = location;
			this.HanLabel.Name = "HanLabel";
			System.Windows.Forms.Control hanLabel2 = this.HanLabel;
			size = new System.Drawing.Size(94, 24);
			hanLabel2.Size = size;
			this.HanLabel.TabIndex = 21;
			this.HanLabel.Text = "Han";
			this.StatusLabel.Font = new System.Drawing.Font("Times New Roman", 20.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(254, 156, 22);
			System.Windows.Forms.Control statusLabel = this.StatusLabel;
			location = new System.Drawing.Point(426, 96);
			statusLabel.Location = location;
			this.StatusLabel.Name = "StatusLabel";
			System.Windows.Forms.Control statusLabel2 = this.StatusLabel;
			size = new System.Drawing.Size(94, 31);
			statusLabel2.Size = size;
			this.StatusLabel.TabIndex = 22;
			this.StatusLabel.Text = "Status";
			this.LoginStatusLabel.Font = new System.Drawing.Font("Times New Roman", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Control loginStatusLabel = this.LoginStatusLabel;
			location = new System.Drawing.Point(426, 127);
			loginStatusLabel.Location = location;
			this.LoginStatusLabel.Name = "LoginStatusLabel";
			System.Windows.Forms.Control loginStatusLabel2 = this.LoginStatusLabel;
			size = new System.Drawing.Size(94, 24);
			loginStatusLabel2.Size = size;
			this.LoginStatusLabel.TabIndex = 23;
			this.LoginStatusLabel.Text = "Checking";
			this.PatriotStatusLabel.Font = new System.Drawing.Font("Times New Roman", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Control patriotStatusLabel = this.PatriotStatusLabel;
			location = new System.Drawing.Point(426, 151);
			patriotStatusLabel.Location = location;
			this.PatriotStatusLabel.Name = "PatriotStatusLabel";
			System.Windows.Forms.Control patriotStatusLabel2 = this.PatriotStatusLabel;
			size = new System.Drawing.Size(94, 24);
			patriotStatusLabel2.Size = size;
			this.PatriotStatusLabel.TabIndex = 24;
			this.PatriotStatusLabel.Text = "Checking";
			this.ObeyaStatusLabel.Font = new System.Drawing.Font("Times New Roman", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Control obeyaStatusLabel = this.ObeyaStatusLabel;
			location = new System.Drawing.Point(426, 175);
			obeyaStatusLabel.Location = location;
			this.ObeyaStatusLabel.Name = "ObeyaStatusLabel";
			System.Windows.Forms.Control obeyaStatusLabel2 = this.ObeyaStatusLabel;
			size = new System.Drawing.Size(94, 24);
			obeyaStatusLabel2.Size = size;
			this.ObeyaStatusLabel.TabIndex = 25;
			this.ObeyaStatusLabel.Text = "Checking";
			this.ColbyStatusLabel.Font = new System.Drawing.Font("Times New Roman", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Control colbyStatusLabel = this.ColbyStatusLabel;
			location = new System.Drawing.Point(426, 199);
			colbyStatusLabel.Location = location;
			this.ColbyStatusLabel.Name = "ColbyStatusLabel";
			System.Windows.Forms.Control colbyStatusLabel2 = this.ColbyStatusLabel;
			size = new System.Drawing.Size(94, 24);
			colbyStatusLabel2.Size = size;
			this.ColbyStatusLabel.TabIndex = 26;
			this.ColbyStatusLabel.Text = "Checking";
			this.JokerStatusLabel.Font = new System.Drawing.Font("Times New Roman", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Control jokerStatusLabel = this.JokerStatusLabel;
			location = new System.Drawing.Point(426, 223);
			jokerStatusLabel.Location = location;
			this.JokerStatusLabel.Name = "JokerStatusLabel";
			System.Windows.Forms.Control jokerStatusLabel2 = this.JokerStatusLabel;
			size = new System.Drawing.Size(94, 24);
			jokerStatusLabel2.Size = size;
			this.JokerStatusLabel.TabIndex = 27;
			this.JokerStatusLabel.Text = "Checking";
			this.HanStatusLabel.Font = new System.Drawing.Font("Times New Roman", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			System.Windows.Forms.Control hanStatusLabel = this.HanStatusLabel;
			location = new System.Drawing.Point(426, 247);
			hanStatusLabel.Location = location;
			this.HanStatusLabel.Name = "HanStatusLabel";
			System.Windows.Forms.Control hanStatusLabel2 = this.HanStatusLabel;
			size = new System.Drawing.Size(94, 24);
			hanStatusLabel2.Size = size;
			this.HanStatusLabel.TabIndex = 28;
			this.HanStatusLabel.Text = "Checking";
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleDimensions = autoScaleDimensions;
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			size = new System.Drawing.Size(539, 217);
			base.ClientSize = size;
			base.Controls.Add(this.HanStatusLabel);
			base.Controls.Add(this.JokerStatusLabel);
			base.Controls.Add(this.ColbyStatusLabel);
			base.Controls.Add(this.ObeyaStatusLabel);
			base.Controls.Add(this.PatriotStatusLabel);
			base.Controls.Add(this.LoginStatusLabel);
			base.Controls.Add(this.StatusLabel);
			base.Controls.Add(this.HanLabel);
			base.Controls.Add(this.JokerLabel);
			base.Controls.Add(this.ColbyLabel);
			base.Controls.Add(this.ObeyaLabel);
			base.Controls.Add(this.PatriotLabel);
			base.Controls.Add(this.LoginLabel);
			base.Controls.Add(this.ServerLabel);
			base.Controls.Add(this.TitleLabel);
			base.Controls.Add(this.DownloadLink);
			base.Controls.Add(this.UpdateLink);
			base.Controls.Add(this.Version);
			base.Controls.Add(this.ExitBtn);
			base.Controls.Add(this.LanguageSelector);
			base.Controls.Add(this.NoMovies);
			base.Controls.Add(this.UpdateBtn);
			base.Controls.Add(this.SettingsBtn);
			base.Controls.Add(this.StartBtn);
			base.Controls.Add(this.Button1);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.ForeColor = System.Drawing.Color.White;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Launcher";
			base.Opacity = 0.95;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Advanced APB Launcher 2.0";
			this.HanStatusLabel.Visible = false;
			this.JokerStatusLabel.Visible = false;
			this.ColbyStatusLabel.Visible = false;
			this.ObeyaStatusLabel.Visible = false;
			this.PatriotStatusLabel.Visible = false;
			this.LoginStatusLabel.Visible = false;
			this.StatusLabel.Visible = false;
			this.HanLabel.Visible = false;
			this.JokerLabel.Visible = false;
			this.ColbyLabel.Visible = false;
			this.ObeyaLabel.Visible = false;
			this.PatriotLabel.Visible = false;
			this.LoginLabel.Visible = false;
			this.ServerLabel.Visible = false;
			this.Button1.Visible = false;
			this.UpdateLink.Visible = false;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000F RID: 15
		private System.ComponentModel.IContainer components;
	}
}