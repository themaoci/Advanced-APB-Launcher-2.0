using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Advanced_APB_Launcher.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Advanced_APB_Launcher
{
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	public partial class Launcher : Form
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00003DF0 File Offset: 0x00001FF0
		public Launcher()
		{
			base.Load += this.Launcher_Load;
			base.MouseDown += this.Launcher_MouseDown;
			base.MouseUp += this.Launcher_MouseUp;
			base.MouseMove += this.Launcher_MouseMove;
			Launcher.__ENCAddToList(this);
			this.IsDraggingForm = false;
			this.MousePos = new Point(0, 0);
			this.elapsedTime = 59;
			this.InitializeComponent();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003E80 File Offset: 0x00002080
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Launcher.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Launcher.__ENCList.Count == Launcher.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int num2 = 0;
						int num3 = Launcher.__ENCList.Count - 1;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							WeakReference weakReference = Launcher.__ENCList[num4];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num4 != num;
								if (flag2)
								{
									Launcher.__ENCList[num] = Launcher.__ENCList[num4];
								}
								num++;
							}
							num4++;
						}
						Launcher.__ENCList.RemoveRange(num, Launcher.__ENCList.Count - num);
						Launcher.__ENCList.Capacity = Launcher.__ENCList.Count;
					}
					Launcher.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000055D4 File Offset: 0x000037D4
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000055EC File Offset: 0x000037EC
		internal virtual Button StartBtn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StartBtn;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.StartBtn_Click);
				bool flag = this._StartBtn != null;
				if (flag)
				{
					this._StartBtn.Click -= value2;
				}
				this._StartBtn = value;
				flag = (this._StartBtn != null);
				if (flag)
				{
					this._StartBtn.Click += value2;
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000564C File Offset: 0x0000384C
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00005664 File Offset: 0x00003864
		internal virtual Button SettingsBtn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SettingsBtn;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SettingsBtn_Click);
				bool flag = this._SettingsBtn != null;
				if (flag)
				{
					this._SettingsBtn.Click -= value2;
				}
				this._SettingsBtn = value;
				flag = (this._SettingsBtn != null);
				if (flag)
				{
					this._SettingsBtn.Click += value2;
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000056C4 File Offset: 0x000038C4
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000056DC File Offset: 0x000038DC
		internal virtual Button UpdateBtn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UpdateBtn;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UpdateBtn_Click);
				bool flag = this._UpdateBtn != null;
				if (flag)
				{
					this._UpdateBtn.Click -= value2;
				}
				this._UpdateBtn = value;
				flag = (this._UpdateBtn != null);
				if (flag)
				{
					this._UpdateBtn.Click += value2;
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000573C File Offset: 0x0000393C
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000212A File Offset: 0x0000032A
		internal virtual CheckBox NoMovies
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NoMovies;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NoMovies = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00005754 File Offset: 0x00003954
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002134 File Offset: 0x00000334
		internal virtual ComboBox LanguageSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LanguageSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LanguageSelector = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0000576C File Offset: 0x0000396C
		// (set) Token: 0x06000040 RID: 64 RVA: 0x0000213E File Offset: 0x0000033E
		internal virtual ToolTip ToolTip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolTip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTip1 = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00005784 File Offset: 0x00003984
		// (set) Token: 0x06000042 RID: 66 RVA: 0x0000579C File Offset: 0x0000399C
		internal virtual Button ExitBtn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ExitBtn;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ExitBtn_Click);
				bool flag = this._ExitBtn != null;
				if (flag)
				{
					this._ExitBtn.Click -= value2;
				}
				this._ExitBtn = value;
				flag = (this._ExitBtn != null);
				if (flag)
				{
					this._ExitBtn.Click += value2;
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000057FC File Offset: 0x000039FC
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00005814 File Offset: 0x00003A14
		internal virtual Timer PingTimer
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PingTimer;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PingTimer_Tick);
				bool flag = this._PingTimer != null;
				if (flag)
				{
					this._PingTimer.Tick -= value2;
				}
				this._PingTimer = value;
				flag = (this._PingTimer != null);
				if (flag)
				{
					this._PingTimer.Tick += value2;
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00005874 File Offset: 0x00003A74
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002148 File Offset: 0x00000348
		internal virtual Label Version
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Version;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000588C File Offset: 0x00003A8C
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000058A4 File Offset: 0x00003AA4
		internal virtual LinkLabel DownloadLink
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DownloadLink;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.DownloadLink_LinkClicked);
				bool flag = this._DownloadLink != null;
				if (flag)
				{
					this._DownloadLink.LinkClicked -= value2;
				}
				this._DownloadLink = value;
				flag = (this._DownloadLink != null);
				if (flag)
				{
					this._DownloadLink.LinkClicked += value2;
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00005904 File Offset: 0x00003B04
		// (set) Token: 0x0600004A RID: 74 RVA: 0x0000591C File Offset: 0x00003B1C
		internal virtual LinkLabel UpdateLink
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UpdateLink;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.UpdateLink_LinkClicked);
				bool flag = this._UpdateLink != null;
				if (flag)
				{
					this._UpdateLink.LinkClicked -= value2;
				}
				this._UpdateLink = value;
				flag = (this._UpdateLink != null);
				if (flag)
				{
					this._UpdateLink.LinkClicked += value2;
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000597C File Offset: 0x00003B7C
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002152 File Offset: 0x00000352
		internal virtual Label TitleLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TitleLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TitleLabel = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00005994 File Offset: 0x00003B94
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000215C File Offset: 0x0000035C
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button1 = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000059AC File Offset: 0x00003BAC
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002166 File Offset: 0x00000366
		internal virtual Label ServerLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ServerLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ServerLabel = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000059C4 File Offset: 0x00003BC4
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002170 File Offset: 0x00000370
		internal virtual Label LoginLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LoginLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LoginLabel = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000059DC File Offset: 0x00003BDC
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000217A File Offset: 0x0000037A
		internal virtual Label PatriotLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PatriotLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PatriotLabel = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000059F4 File Offset: 0x00003BF4
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002184 File Offset: 0x00000384
		internal virtual Label ObeyaLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ObeyaLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ObeyaLabel = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00005A0C File Offset: 0x00003C0C
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000218E File Offset: 0x0000038E
		internal virtual Label ColbyLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColbyLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColbyLabel = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00005A24 File Offset: 0x00003C24
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002198 File Offset: 0x00000398
		internal virtual Label JokerLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._JokerLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._JokerLabel = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00005A3C File Offset: 0x00003C3C
		// (set) Token: 0x0600005C RID: 92 RVA: 0x000021A2 File Offset: 0x000003A2
		internal virtual Label HanLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HanLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HanLabel = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00005A54 File Offset: 0x00003C54
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000021AC File Offset: 0x000003AC
		internal virtual Label StatusLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StatusLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._StatusLabel = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00005A6C File Offset: 0x00003C6C
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000021B6 File Offset: 0x000003B6
		internal virtual Label LoginStatusLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LoginStatusLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LoginStatusLabel = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00005A84 File Offset: 0x00003C84
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000021C0 File Offset: 0x000003C0
		internal virtual Label PatriotStatusLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PatriotStatusLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PatriotStatusLabel = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00005A9C File Offset: 0x00003C9C
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000021CA File Offset: 0x000003CA
		internal virtual Label ObeyaStatusLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ObeyaStatusLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ObeyaStatusLabel = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00005AB4 File Offset: 0x00003CB4
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000021D4 File Offset: 0x000003D4
		internal virtual Label ColbyStatusLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColbyStatusLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColbyStatusLabel = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00005ACC File Offset: 0x00003CCC
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000021DE File Offset: 0x000003DE
		internal virtual Label JokerStatusLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._JokerStatusLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._JokerStatusLabel = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00005AE4 File Offset: 0x00003CE4
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000021E8 File Offset: 0x000003E8
		internal virtual Label HanStatusLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HanStatusLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HanStatusLabel = value;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00005AFC File Offset: 0x00003CFC
		private void Launcher_Load(object sender, EventArgs e)
		{
			this.NoMovies.Checked = MySettingsProperty.Settings.NoMoviesSetting;
			this.LanguageSelector.Text = MySettingsProperty.Settings.LanguageSelectorSetting;
			this.Version.Text = "Version: " + Application.ProductVersion;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00005B54 File Offset: 0x00003D54
		private void Launcher_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				this.IsDraggingForm = true;
				this.MousePos = e.Location;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005B88 File Offset: 0x00003D88
		private void Launcher_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				this.IsDraggingForm = false;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005BB0 File Offset: 0x00003DB0
		private void Launcher_MouseMove(object sender, MouseEventArgs e)
		{
			bool isDraggingForm = this.IsDraggingForm;
			if (isDraggingForm)
			{
				Point location = new Point((Size)(this.Location + (Size)(e.Location - (Size)this.MousePos)));
				this.Location = location;
				location = default(Point);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00005C10 File Offset: 0x00003E10
		private void UpdateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.dropbox.com/s/dx8ardxhgpqgcsv/Version.txt?dl=1");
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			string text = streamReader.ReadToEnd();
			bool flag = text.Contains(Application.ProductVersion.ToString());
			if (flag)
			{
				this.UpdateLink.LinkColor = Color.Lime;
				this.UpdateLink.Text = "No Update Needed!";
			}
			else
			{
				this.UpdateLink.Visible = false;
				this.DownloadLink.Visible = true;
			}
			streamReader.Close();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00005CAC File Offset: 0x00003EAC
		private void DownloadLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start("https://www.dropbox.com/s/oaufd85zfvnlmi5/Advanced%20APB%20Launcher.zip?dl=1");
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Notify USPStyle something went wrong", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000021F2 File Offset: 0x000003F2
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void PingTimer_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00005CF4 File Offset: 0x00003EF4
		private void UpdateBtn_Click(object sender, EventArgs e)
		{
			try
			{
				Interaction.Shell(Application.StartupPath + "\\Launcher\\APBLauncher.exe", AppWinStyle.MinimizedFocus, false, -1);
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, null);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000021F4 File Offset: 0x000003F4
		private void SettingsBtn_Click(object sender, EventArgs e)
		{
			MyProject.Forms.SettingsForm.Show();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00005D50 File Offset: 0x00003F50
		private void StartBtn_Click(object sender, EventArgs e)
		{
			if (this.LanguageSelector.SelectedIndex == 0)
			{
				if (this.NoMovies.Checked)
				{
					try
					{
						Interaction.Shell(Application.StartupPath + "\\Binaries\\APB.exe -nomoviestartup -lbl -pktlag=0 -noamdtsc -language=1031", AppWinStyle.MinimizedFocus, false, -1);
						goto IL_295;
					}
					catch (Exception ex)
					{
						Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, null);
						goto IL_295;
					}
				}
				try
				{
					Interaction.Shell(Application.StartupPath + "\\Binaries\\APB.exe -language=1031", AppWinStyle.MinimizedFocus, false, -1);
					goto IL_295;
				}
				catch (Exception ex2)
				{
					Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, null);
					goto IL_295;
				}
			}
			if (this.LanguageSelector.SelectedIndex == 1)
			{
				if (this.NoMovies.Checked)
				{
					try
					{
						Interaction.Shell(Application.StartupPath + "\\Binaries\\APB.exe -language=1036 -nomoviestartup", AppWinStyle.MinimizedFocus, false, -1);
						goto IL_295;
					}
					catch (Exception ex3)
					{
						Interaction.MsgBox(ex3.Message, MsgBoxStyle.Critical, null);
						goto IL_295;
					}
				}
				try
				{
					Interaction.Shell(Application.StartupPath + "\\Binaries\\APB.exe -language=1036", AppWinStyle.MinimizedFocus, false, -1);
					goto IL_295;
				}
				catch (Exception ex4)
				{
					Interaction.MsgBox(ex4.Message, MsgBoxStyle.Critical, null);
					goto IL_295;
				}
			}
			if (this.LanguageSelector.SelectedIndex == 2)
			{
				if (this.NoMovies.Checked)
				{
					try
					{
						Interaction.Shell(Application.StartupPath + "\\Binaries\\APB.exe -language=1031 -nomoviestartup", AppWinStyle.MinimizedFocus, false, -1);
						goto IL_295;
					}
					catch (Exception ex5)
					{
						Interaction.MsgBox(ex5.Message, MsgBoxStyle.Critical, null);
						goto IL_295;
					}
				}
				try
				{
					Interaction.Shell(Application.StartupPath + "\\Binaries\\APB.exe -language=1031", AppWinStyle.MinimizedFocus, false, -1);
					goto IL_295;
				}
				catch (Exception ex6)
				{
					Interaction.MsgBox(ex6.Message, MsgBoxStyle.Critical, null);
					goto IL_295;
				}
			}
			if (this.LanguageSelector.SelectedIndex == 3)
			{
				if (this.NoMovies.Checked)
				{
					try
					{
						Interaction.Shell(Application.StartupPath + "\\Binaries\\APB.exe -language=1040 -nomoviestartup", AppWinStyle.MinimizedFocus, false, -1);
						goto IL_295;
					}
					catch (Exception ex7)
					{
						Interaction.MsgBox(ex7.Message, MsgBoxStyle.Critical, null);
						goto IL_295;
					}
				}
				try
				{
					Interaction.Shell(Application.StartupPath + "\\Binaries\\APB.exe -language=1040", AppWinStyle.MinimizedFocus, false, -1);
					goto IL_295;
				}
				catch (Exception ex8)
				{
					Interaction.MsgBox(ex8.Message, MsgBoxStyle.Critical, null);
					goto IL_295;
				}
			}
			if (this.LanguageSelector.SelectedIndex == 4)
			{
				if (this.NoMovies.Checked)
				{
					try
					{
						Interaction.Shell(Application.StartupPath + "\\Binaries\\APB.exe -language=1034 -nomoviestartup", AppWinStyle.MinimizedFocus, false, -1);
						goto IL_295;
					}
					catch (Exception ex9)
					{
						Interaction.MsgBox(ex9.Message, MsgBoxStyle.Critical, null);
						goto IL_295;
					}
				}
				try
				{
					Interaction.Shell(Application.StartupPath + "\\Binaries\\APB.exe -language=1034", AppWinStyle.MinimizedFocus, false, -1);
					goto IL_295;
				}
				catch (Exception ex10)
				{
					Interaction.MsgBox(ex10.Message, MsgBoxStyle.Critical, null);
					goto IL_295;
				}
			}
			try
			{
				Interaction.Shell(Application.StartupPath + "\\Binaries\\APB.exe", AppWinStyle.MinimizedFocus, false, -1);
			}
			catch (Exception ex11)
			{
				Interaction.MsgBox(ex11.Message, MsgBoxStyle.Critical, null);
			}
			IL_295:
			MySettingsProperty.Settings.NoMoviesSetting = this.NoMovies.Checked;
			MySettingsProperty.Settings.LanguageSelectorSetting = this.LanguageSelector.Text;
			MySettingsProperty.Settings.Save();
			base.Close();
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002208 File Offset: 0x00000408
		private void ExitBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x0400000E RID: 14
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000010 RID: 16
		[AccessedThroughProperty("StartBtn")]
		private Button _StartBtn;

		// Token: 0x04000011 RID: 17
		[AccessedThroughProperty("SettingsBtn")]
		private Button _SettingsBtn;

		// Token: 0x04000012 RID: 18
		[AccessedThroughProperty("UpdateBtn")]
		private Button _UpdateBtn;

		// Token: 0x04000013 RID: 19
		[AccessedThroughProperty("NoMovies")]
		private CheckBox _NoMovies;

		// Token: 0x04000014 RID: 20
		[AccessedThroughProperty("LanguageSelector")]
		private ComboBox _LanguageSelector;

		// Token: 0x04000015 RID: 21
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		// Token: 0x04000016 RID: 22
		[AccessedThroughProperty("ExitBtn")]
		private Button _ExitBtn;

		// Token: 0x04000017 RID: 23
		[AccessedThroughProperty("PingTimer")]
		private Timer _PingTimer;

		// Token: 0x04000018 RID: 24
		[AccessedThroughProperty("Version")]
		private Label _Version;

		// Token: 0x04000019 RID: 25
		[AccessedThroughProperty("DownloadLink")]
		private LinkLabel _DownloadLink;

		// Token: 0x0400001A RID: 26
		[AccessedThroughProperty("UpdateLink")]
		private LinkLabel _UpdateLink;

		// Token: 0x0400001B RID: 27
		[AccessedThroughProperty("TitleLabel")]
		private Label _TitleLabel;

		// Token: 0x0400001C RID: 28
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400001D RID: 29
		[AccessedThroughProperty("ServerLabel")]
		private Label _ServerLabel;

		// Token: 0x0400001E RID: 30
		[AccessedThroughProperty("LoginLabel")]
		private Label _LoginLabel;

		// Token: 0x0400001F RID: 31
		[AccessedThroughProperty("PatriotLabel")]
		private Label _PatriotLabel;

		// Token: 0x04000020 RID: 32
		[AccessedThroughProperty("ObeyaLabel")]
		private Label _ObeyaLabel;

		// Token: 0x04000021 RID: 33
		[AccessedThroughProperty("ColbyLabel")]
		private Label _ColbyLabel;

		// Token: 0x04000022 RID: 34
		[AccessedThroughProperty("JokerLabel")]
		private Label _JokerLabel;

		// Token: 0x04000023 RID: 35
		[AccessedThroughProperty("HanLabel")]
		private Label _HanLabel;

		// Token: 0x04000024 RID: 36
		[AccessedThroughProperty("StatusLabel")]
		private Label _StatusLabel;

		// Token: 0x04000025 RID: 37
		[AccessedThroughProperty("LoginStatusLabel")]
		private Label _LoginStatusLabel;

		// Token: 0x04000026 RID: 38
		[AccessedThroughProperty("PatriotStatusLabel")]
		private Label _PatriotStatusLabel;

		// Token: 0x04000027 RID: 39
		[AccessedThroughProperty("ObeyaStatusLabel")]
		private Label _ObeyaStatusLabel;

		// Token: 0x04000028 RID: 40
		[AccessedThroughProperty("ColbyStatusLabel")]
		private Label _ColbyStatusLabel;

		// Token: 0x04000029 RID: 41
		[AccessedThroughProperty("JokerStatusLabel")]
		private Label _JokerStatusLabel;

		// Token: 0x0400002A RID: 42
		[AccessedThroughProperty("HanStatusLabel")]
		private Label _HanStatusLabel;

		// Token: 0x0400002B RID: 43
		private bool IsDraggingForm;

		// Token: 0x0400002C RID: 44
		private Point MousePos;

		// Token: 0x0400002D RID: 45
		private int elapsedTime;
	}
}
