using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Advanced_APB_Launcher.My;
using Launcher;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Advanced_APB_Launcher
{
	// Token: 0x0200000E RID: 14
	[DesignerGenerated]
	public partial class SettingsForm : Form
	{
		// Token: 0x06000185 RID: 389 RVA: 0x00007488 File Offset: 0x00005688
		public SettingsForm()
		{
			base.MouseDown += this.SetingsForm_MouseDown;
			base.MouseUp += this.SetingsForm_MouseUp;
			base.MouseMove += this.SetingsForm_MouseMove;
			base.Load += this.SettingsForm_Load;
			SettingsForm.__ENCAddToList(this);
			this.IsDraggingForm = false;
			this.MousePos = new Point(0, 0);
			this.InitializeComponent();
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00007510 File Offset: 0x00005710
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = SettingsForm.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = SettingsForm.__ENCList.Count == SettingsForm.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int num2 = 0;
						int num3 = SettingsForm.__ENCList.Count - 1;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							WeakReference weakReference = SettingsForm.__ENCList[num4];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num4 != num;
								if (flag2)
								{
									SettingsForm.__ENCList[num] = SettingsForm.__ENCList[num4];
								}
								num++;
							}
							num4++;
						}
						SettingsForm.__ENCList.RemoveRange(num, SettingsForm.__ENCList.Count - num);
						SettingsForm.__ENCList.Capacity = SettingsForm.__ENCList.Count;
					}
					SettingsForm.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00014AD4 File Offset: 0x00012CD4
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00014AEC File Offset: 0x00012CEC
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00014B4C File Offset: 0x00012D4C
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00014B64 File Offset: 0x00012D64
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
				EventHandler value2 = new EventHandler(this.Button1_Click);
				bool flag = this._Button1 != null;
				if (flag)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				flag = (this._Button1 != null);
				if (flag)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00014BC4 File Offset: 0x00012DC4
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00014BDC File Offset: 0x00012DDC
		internal virtual GroupBox InGameBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._InGameBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.InGameBox_Enter);
				EventHandler value3 = new EventHandler(this.InGameBox_Enter);
				bool flag = this._InGameBox != null;
				if (flag)
				{
					this._InGameBox.Enter -= value2;
					this._InGameBox.Enter -= value3;
				}
				this._InGameBox = value;
				flag = (this._InGameBox != null);
				if (flag)
				{
					this._InGameBox.Enter += value2;
					this._InGameBox.Enter += value3;
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00014C64 File Offset: 0x00012E64
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00014C7C File Offset: 0x00012E7C
		internal virtual GroupBox GroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GroupBox2_Enter);
				bool flag = this._GroupBox2 != null;
				if (flag)
				{
					this._GroupBox2.Enter -= value2;
				}
				this._GroupBox2 = value;
				flag = (this._GroupBox2 != null);
				if (flag)
				{
					this._GroupBox2.Enter += value2;
				}
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00014CDC File Offset: 0x00012EDC
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00014CF4 File Offset: 0x00012EF4
		internal virtual Button Button2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				bool flag = this._Button2 != null;
				if (flag)
				{
					this._Button2.Click -= value2;
				}
				this._Button2 = value;
				flag = (this._Button2 != null);
				if (flag)
				{
					this._Button2.Click += value2;
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00014D54 File Offset: 0x00012F54
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00014D6C File Offset: 0x00012F6C
		internal virtual Button CancelBtn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CancelBtn;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CancelBtn_Click);
				bool flag = this._CancelBtn != null;
				if (flag)
				{
					this._CancelBtn.Click -= value2;
				}
				this._CancelBtn = value;
				flag = (this._CancelBtn != null);
				if (flag)
				{
					this._CancelBtn.Click += value2;
				}
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00014DCC File Offset: 0x00012FCC
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00014DE4 File Offset: 0x00012FE4
		internal virtual Button SaveBtn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SaveBtn;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SaveBtn_Click);
				bool flag = this._SaveBtn != null;
				if (flag)
				{
					this._SaveBtn.Click -= value2;
				}
				this._SaveBtn = value;
				flag = (this._SaveBtn != null);
				if (flag)
				{
					this._SaveBtn.Click += value2;
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00014E44 File Offset: 0x00013044
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002C78 File Offset: 0x00000E78
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00014E5C File Offset: 0x0001305C
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00014E74 File Offset: 0x00013074
		internal virtual ComboBox ResolutionSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ResolutionSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ResolutionSelector_SelectedIndexChanged);
				bool flag = this._ResolutionSelector != null;
				if (flag)
				{
					this._ResolutionSelector.SelectedIndexChanged -= value2;
				}
				this._ResolutionSelector = value;
				flag = (this._ResolutionSelector != null);
				if (flag)
				{
					this._ResolutionSelector.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00014ED4 File Offset: 0x000130D4
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002C82 File Offset: 0x00000E82
		internal virtual CheckBox EnableVsync
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableVsync;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableVsync = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00014EEC File Offset: 0x000130EC
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002C8C File Offset: 0x00000E8C
		internal virtual ToolTip SettingToolTip
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SettingToolTip;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SettingToolTip = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00014F04 File Offset: 0x00013104
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002C96 File Offset: 0x00000E96
		internal virtual CheckBox EnableSmoothFrameRate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableSmoothFrameRate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableSmoothFrameRate = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00014F1C File Offset: 0x0001311C
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002CA0 File Offset: 0x00000EA0
		internal virtual CheckBox EnableDynamicShadows
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableDynamicShadows;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableDynamicShadows = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00014F34 File Offset: 0x00013134
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00002CAA File Offset: 0x00000EAA
		internal virtual CheckBox EnableStaticDecals
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableStaticDecals;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableStaticDecals = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00014F4C File Offset: 0x0001314C
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00002CB4 File Offset: 0x00000EB4
		internal virtual CheckBox EnableTrilinear
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableTrilinear;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableTrilinear = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00014F64 File Offset: 0x00013164
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002CBE File Offset: 0x00000EBE
		internal virtual CheckBox EnableDistortion
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableDistortion;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableDistortion = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00014F7C File Offset: 0x0001317C
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002CC8 File Offset: 0x00000EC8
		internal virtual CheckBox EnableBloom
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableBloom;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableBloom = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00014F94 File Offset: 0x00013194
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002CD2 File Offset: 0x00000ED2
		internal virtual CheckBox EnableAmbientOcclusion
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableAmbientOcclusion;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableAmbientOcclusion = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00014FAC File Offset: 0x000131AC
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002CDC File Offset: 0x00000EDC
		internal virtual CheckBox EnableBlobShadows
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableBlobShadows;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableBlobShadows = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00014FC4 File Offset: 0x000131C4
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002CE6 File Offset: 0x00000EE6
		internal virtual CheckBox EnableLEShadows
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableLEShadows;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableLEShadows = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00014FDC File Offset: 0x000131DC
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002CF0 File Offset: 0x00000EF0
		internal virtual CheckBox EnableLQHealthHUD
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableLQHealthHUD;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableLQHealthHUD = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00014FF4 File Offset: 0x000131F4
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002CFA File Offset: 0x00000EFA
		internal virtual CheckBox EnableEyelashes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableEyelashes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableEyelashes = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0001500C File Offset: 0x0001320C
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002D04 File Offset: 0x00000F04
		internal virtual ComboBox AnisoSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AnisoSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._AnisoSelector = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00015024 File Offset: 0x00013224
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002D0E File Offset: 0x00000F0E
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0001503C File Offset: 0x0001323C
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002D18 File Offset: 0x00000F18
		internal virtual CheckBox EnableDynamicDecals
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableDynamicDecals;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableDynamicDecals = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00015054 File Offset: 0x00013254
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002D22 File Offset: 0x00000F22
		internal virtual CheckBox EnableLevelParticles
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableLevelParticles;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableLevelParticles = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0001506C File Offset: 0x0001326C
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002D2C File Offset: 0x00000F2C
		internal virtual CheckBox EnableCDLights
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableCDLights;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableCDLights = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00015084 File Offset: 0x00013284
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002D36 File Offset: 0x00000F36
		internal virtual CheckBox EnableDynamicLights
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableDynamicLights;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableDynamicLights = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0001509C File Offset: 0x0001329C
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002D40 File Offset: 0x00000F40
		internal virtual CheckBox EnableDirectionalLightmaps
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableDirectionalLightmaps;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableDirectionalLightmaps = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x000150B4 File Offset: 0x000132B4
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002D4A File Offset: 0x00000F4A
		internal virtual CheckBox EnableFogVolumes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableFogVolumes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableFogVolumes = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x000150CC File Offset: 0x000132CC
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002D54 File Offset: 0x00000F54
		internal virtual CheckBox EnableLensFlares
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableLensFlares;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableLensFlares = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000150E4 File Offset: 0x000132E4
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002D5E File Offset: 0x00000F5E
		internal virtual CheckBox EnableStreamTextures
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableStreamTextures;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableStreamTextures = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x000150FC File Offset: 0x000132FC
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00002D68 File Offset: 0x00000F68
		internal virtual CheckBox EnableSTFronds
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableSTFronds;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableSTFronds = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00015114 File Offset: 0x00013314
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00002D72 File Offset: 0x00000F72
		internal virtual CheckBox EnableSTLeaves
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableSTLeaves;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableSTLeaves = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0001512C File Offset: 0x0001332C
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002D7C File Offset: 0x00000F7C
		internal virtual CheckBox EnableDPDistortion
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableDPDistortion;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableDPDistortion = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00015144 File Offset: 0x00013344
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002D86 File Offset: 0x00000F86
		internal virtual CheckBox EnableQualityBloom
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableQualityBloom;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableQualityBloom = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0001515C File Offset: 0x0001335C
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002D90 File Offset: 0x00000F90
		internal virtual CheckBox EnableDepthOfField
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableDepthOfField;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableDepthOfField = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00015174 File Offset: 0x00013374
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002D9A File Offset: 0x00000F9A
		internal virtual CheckBox EnableMotionBlur
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableMotionBlur;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableMotionBlur = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0001518C File Offset: 0x0001338C
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002DA4 File Offset: 0x00000FA4
		internal virtual CheckBox EnableDXTNormal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableDXTNormal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableDXTNormal = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x000151A4 File Offset: 0x000133A4
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002DAE File Offset: 0x00000FAE
		internal virtual CheckBox EnableDXTOtherVehicle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableDXTOtherVehicle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableDXTOtherVehicle = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x000151BC File Offset: 0x000133BC
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00002DB8 File Offset: 0x00000FB8
		internal virtual CheckBox EnableDXTOtherCharacter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableDXTOtherCharacter;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableDXTOtherCharacter = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000151D4 File Offset: 0x000133D4
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00002DC2 File Offset: 0x00000FC2
		internal virtual CheckBox EnableDXTLocalVehicle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableDXTLocalVehicle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableDXTLocalVehicle = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001DD RID: 477 RVA: 0x000151EC File Offset: 0x000133EC
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00002DCC File Offset: 0x00000FCC
		internal virtual CheckBox EnableDXTLocalCharacter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableDXTLocalCharacter;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableDXTLocalCharacter = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00015204 File Offset: 0x00013404
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002DD6 File Offset: 0x00000FD6
		internal virtual CheckBox EnableSimpleVehicleMaterials
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableSimpleVehicleMaterials;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableSimpleVehicleMaterials = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0001521C File Offset: 0x0001341C
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002DE0 File Offset: 0x00000FE0
		internal virtual CheckBox EnableForegroundShadows
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableForegroundShadows;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableForegroundShadows = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00015234 File Offset: 0x00013434
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00002DEA File Offset: 0x00000FEA
		internal virtual CheckBox EnableBetterShadows
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableBetterShadows;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableBetterShadows = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0001524C File Offset: 0x0001344C
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002DF4 File Offset: 0x00000FF4
		internal virtual CheckBox EnablePCFShadows
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnablePCFShadows;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnablePCFShadows = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00015264 File Offset: 0x00013464
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002DFE File Offset: 0x00000FFE
		internal virtual CheckBox EnableVSMShadows
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableVSMShadows;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableVSMShadows = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0001527C File Offset: 0x0001347C
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00002E08 File Offset: 0x00001008
		internal virtual CheckBox EnableHighPolyChars
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableHighPolyChars;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableHighPolyChars = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00015294 File Offset: 0x00013494
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00002E12 File Offset: 0x00001012
		internal virtual CheckBox EnableUpscaleSP
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableUpscaleSP;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableUpscaleSP = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060001ED RID: 493 RVA: 0x000152AC File Offset: 0x000134AC
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00002E1C File Offset: 0x0000101C
		internal virtual CheckBox EnableThreadLag
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableThreadLag;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableThreadLag = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000152C4 File Offset: 0x000134C4
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002E26 File Offset: 0x00001026
		internal virtual CheckBox EnableFPRTargets
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableFPRTargets;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableFPRTargets = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x000152DC File Offset: 0x000134DC
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x000152F4 File Offset: 0x000134F4
		internal virtual Button Button3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click);
				bool flag = this._Button3 != null;
				if (flag)
				{
					this._Button3.Click -= value2;
				}
				this._Button3 = value;
				flag = (this._Button3 != null);
				if (flag)
				{
					this._Button3.Click += value2;
				}
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00015354 File Offset: 0x00013554
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x0001536C File Offset: 0x0001356C
		internal virtual GroupBox GroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GroupBox3_Enter);
				bool flag = this._GroupBox3 != null;
				if (flag)
				{
					this._GroupBox3.Enter -= value2;
				}
				this._GroupBox3 = value;
				flag = (this._GroupBox3 != null);
				if (flag)
				{
					this._GroupBox3.Enter += value2;
				}
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000153CC File Offset: 0x000135CC
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002E30 File Offset: 0x00001030
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000153E4 File Offset: 0x000135E4
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002E3A File Offset: 0x0000103A
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000153FC File Offset: 0x000135FC
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00002E44 File Offset: 0x00001044
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00015414 File Offset: 0x00013614
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00002E4E File Offset: 0x0000104E
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0001542C File Offset: 0x0001362C
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00002E58 File Offset: 0x00001058
		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00015444 File Offset: 0x00013644
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00002E62 File Offset: 0x00001062
		internal virtual Label Label13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label13 = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0001545C File Offset: 0x0001365C
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00002E6C File Offset: 0x0000106C
		internal virtual Label Label12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label12 = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00015474 File Offset: 0x00013674
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00002E76 File Offset: 0x00001076
		internal virtual Label Label11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0001548C File Offset: 0x0001368C
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00002E80 File Offset: 0x00001080
		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000207 RID: 519 RVA: 0x000154A4 File Offset: 0x000136A4
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00002E8A File Offset: 0x0000108A
		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000209 RID: 521 RVA: 0x000154BC File Offset: 0x000136BC
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00002E94 File Offset: 0x00001094
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600020B RID: 523 RVA: 0x000154D4 File Offset: 0x000136D4
		// (set) Token: 0x0600020C RID: 524 RVA: 0x000154EC File Offset: 0x000136EC
		internal virtual Panel Panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Panel1_Click);
				bool flag = this._Panel1 != null;
				if (flag)
				{
					this._Panel1.Click -= value2;
				}
				this._Panel1 = value;
				flag = (this._Panel1 != null);
				if (flag)
				{
					this._Panel1.Click += value2;
				}
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0001554C File Offset: 0x0001374C
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00015564 File Offset: 0x00013764
		internal virtual TrackBar UnknownSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UnknownSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UnknownSelector_Scroll);
				bool flag = this._UnknownSelector != null;
				if (flag)
				{
					this._UnknownSelector.Scroll -= value2;
				}
				this._UnknownSelector = value;
				flag = (this._UnknownSelector != null);
				if (flag)
				{
					this._UnknownSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600020F RID: 527 RVA: 0x000155C4 File Offset: 0x000137C4
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00002E9E File Offset: 0x0000109E
		internal virtual Label UnknownLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UnknownLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UnknownLabel = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000211 RID: 529 RVA: 0x000155DC File Offset: 0x000137DC
		// (set) Token: 0x06000212 RID: 530 RVA: 0x000155F4 File Offset: 0x000137F4
		internal virtual TrackBar EnvironmentSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnvironmentSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EnvironmentSelector_Scroll);
				EventHandler value3 = new EventHandler(this.EnvironmentSelector_Scroll);
				bool flag = this._EnvironmentSelector != null;
				if (flag)
				{
					this._EnvironmentSelector.Scroll -= value2;
					this._EnvironmentSelector.Scroll -= value3;
				}
				this._EnvironmentSelector = value;
				flag = (this._EnvironmentSelector != null);
				if (flag)
				{
					this._EnvironmentSelector.Scroll += value2;
					this._EnvironmentSelector.Scroll += value3;
				}
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0001567C File Offset: 0x0001387C
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00002EA8 File Offset: 0x000010A8
		internal virtual Label EnvironmentLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnvironmentLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnvironmentLabel = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00015694 File Offset: 0x00013894
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00002EB2 File Offset: 0x000010B2
		internal virtual Label PropLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PropLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PropLabel = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000217 RID: 535 RVA: 0x000156AC File Offset: 0x000138AC
		// (set) Token: 0x06000218 RID: 536 RVA: 0x000156C4 File Offset: 0x000138C4
		internal virtual TrackBar PropSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PropSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PropSelector_Scroll);
				bool flag = this._PropSelector != null;
				if (flag)
				{
					this._PropSelector.Scroll -= value2;
				}
				this._PropSelector = value;
				flag = (this._PropSelector != null);
				if (flag)
				{
					this._PropSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00015724 File Offset: 0x00013924
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00002EBC File Offset: 0x000010BC
		internal virtual Label CharacterLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CharacterLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CharacterLabel = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0001573C File Offset: 0x0001393C
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00015754 File Offset: 0x00013954
		internal virtual TrackBar CharacterSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CharacterSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CharacterSelector_Scroll);
				bool flag = this._CharacterSelector != null;
				if (flag)
				{
					this._CharacterSelector.Scroll -= value2;
				}
				this._CharacterSelector = value;
				flag = (this._CharacterSelector != null);
				if (flag)
				{
					this._CharacterSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600021D RID: 541 RVA: 0x000157B4 File Offset: 0x000139B4
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002EC6 File Offset: 0x000010C6
		internal virtual Label VehicleLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VehicleLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._VehicleLabel = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000157CC File Offset: 0x000139CC
		// (set) Token: 0x06000220 RID: 544 RVA: 0x000157E4 File Offset: 0x000139E4
		internal virtual TrackBar VehicleSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VehicleSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.VehicleSelector_Scroll);
				bool flag = this._VehicleSelector != null;
				if (flag)
				{
					this._VehicleSelector.Scroll -= value2;
				}
				this._VehicleSelector = value;
				flag = (this._VehicleSelector != null);
				if (flag)
				{
					this._VehicleSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00015844 File Offset: 0x00013A44
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002ED0 File Offset: 0x000010D0
		internal virtual Label PedestrianLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PedestrianLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PedestrianLabel = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0001585C File Offset: 0x00013A5C
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00015874 File Offset: 0x00013A74
		internal virtual TrackBar PedestrianSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PedestrianSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PedestrianSelector_Scroll);
				bool flag = this._PedestrianSelector != null;
				if (flag)
				{
					this._PedestrianSelector.Scroll -= value2;
				}
				this._PedestrianSelector = value;
				flag = (this._PedestrianSelector != null);
				if (flag)
				{
					this._PedestrianSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000158D4 File Offset: 0x00013AD4
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00002EDA File Offset: 0x000010DA
		internal virtual Label CityVehicleLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CityVehicleLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CityVehicleLabel = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000227 RID: 551 RVA: 0x000158EC File Offset: 0x00013AEC
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00015904 File Offset: 0x00013B04
		internal virtual TrackBar CityVehicleSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CityVehicleSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CityVehicleSelector_Scroll);
				bool flag = this._CityVehicleSelector != null;
				if (flag)
				{
					this._CityVehicleSelector.Scroll -= value2;
				}
				this._CityVehicleSelector = value;
				flag = (this._CityVehicleSelector != null);
				if (flag)
				{
					this._CityVehicleSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00015964 File Offset: 0x00013B64
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00002EE4 File Offset: 0x000010E4
		internal virtual Label PickupLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PickupLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PickupLabel = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0001597C File Offset: 0x00013B7C
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00015994 File Offset: 0x00013B94
		internal virtual TrackBar PickupSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PickupSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PickupSelector_Scroll);
				bool flag = this._PickupSelector != null;
				if (flag)
				{
					this._PickupSelector.Scroll -= value2;
				}
				this._PickupSelector = value;
				flag = (this._PickupSelector != null);
				if (flag)
				{
					this._PickupSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600022D RID: 557 RVA: 0x000159F4 File Offset: 0x00013BF4
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00002EEE File Offset: 0x000010EE
		internal virtual Label PrimitiveLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PrimitiveLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PrimitiveLabel = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00015A0C File Offset: 0x00013C0C
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00015A24 File Offset: 0x00013C24
		internal virtual TrackBar PrimitiveSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PrimitiveSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PrimitiveSelector_Scroll);
				bool flag = this._PrimitiveSelector != null;
				if (flag)
				{
					this._PrimitiveSelector.Scroll -= value2;
				}
				this._PrimitiveSelector = value;
				flag = (this._PrimitiveSelector != null);
				if (flag)
				{
					this._PrimitiveSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00015A84 File Offset: 0x00013C84
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00002EF8 File Offset: 0x000010F8
		internal virtual Label UILabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UILabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UILabel = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00015A9C File Offset: 0x00013C9C
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00015AB4 File Offset: 0x00013CB4
		internal virtual TrackBar UISelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UISelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UISelector_Scroll);
				bool flag = this._UISelector != null;
				if (flag)
				{
					this._UISelector.Scroll -= value2;
				}
				this._UISelector = value;
				flag = (this._UISelector != null);
				if (flag)
				{
					this._UISelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00015B14 File Offset: 0x00013D14
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00002F02 File Offset: 0x00001102
		internal virtual Label ShadowResolutionLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShadowResolutionLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ShadowResolutionLabel = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00015B2C File Offset: 0x00013D2C
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00015B44 File Offset: 0x00013D44
		internal virtual TrackBar ShadowResolutionSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShadowResolutionSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ShadowResolutionSelector_Scroll);
				bool flag = this._ShadowResolutionSelector != null;
				if (flag)
				{
					this._ShadowResolutionSelector.Scroll -= value2;
				}
				this._ShadowResolutionSelector = value;
				flag = (this._ShadowResolutionSelector != null);
				if (flag)
				{
					this._ShadowResolutionSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00015BA4 File Offset: 0x00013DA4
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00002F0C File Offset: 0x0000110C
		internal virtual Label Label15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label15 = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00015BBC File Offset: 0x00013DBC
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00002F16 File Offset: 0x00001116
		internal virtual Label VFXLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VFXLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._VFXLabel = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00015BD4 File Offset: 0x00013DD4
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00015BEC File Offset: 0x00013DEC
		internal virtual TrackBar VFXSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VFXSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.VFXSelector_Scroll);
				bool flag = this._VFXSelector != null;
				if (flag)
				{
					this._VFXSelector.Scroll -= value2;
				}
				this._VFXSelector = value;
				flag = (this._VFXSelector != null);
				if (flag)
				{
					this._VFXSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00015C4C File Offset: 0x00013E4C
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00002F20 File Offset: 0x00001120
		internal virtual Label Label14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label14 = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00015C64 File Offset: 0x00013E64
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002F2A File Offset: 0x0000112A
		internal virtual Label LSMLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LSMLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LSMLabel = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00015C7C File Offset: 0x00013E7C
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00015C94 File Offset: 0x00013E94
		internal virtual TrackBar LSMSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LSMSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.LSMSelector_Scroll);
				bool flag = this._LSMSelector != null;
				if (flag)
				{
					this._LSMSelector.Scroll -= value2;
				}
				this._LSMSelector = value;
				flag = (this._LSMSelector != null);
				if (flag)
				{
					this._LSMSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00015CF4 File Offset: 0x00013EF4
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00002F34 File Offset: 0x00001134
		internal virtual Label Label17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label17 = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00015D0C File Offset: 0x00013F0C
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00002F3E File Offset: 0x0000113E
		internal virtual Label RenderTargetLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RenderTargetLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RenderTargetLabel = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00015D24 File Offset: 0x00013F24
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00015D3C File Offset: 0x00013F3C
		internal virtual TrackBar RenderTargetSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RenderTargetSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RenderTargetSelector_Scroll);
				bool flag = this._RenderTargetSelector != null;
				if (flag)
				{
					this._RenderTargetSelector.Scroll -= value2;
				}
				this._RenderTargetSelector = value;
				flag = (this._RenderTargetSelector != null);
				if (flag)
				{
					this._RenderTargetSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00015D9C File Offset: 0x00013F9C
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00002F48 File Offset: 0x00001148
		internal virtual Label SignageLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SignageLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SignageLabel = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00015DB4 File Offset: 0x00013FB4
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00015DCC File Offset: 0x00013FCC
		internal virtual TrackBar SignageSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SignageSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SignageSelector_Scroll);
				bool flag = this._SignageSelector != null;
				if (flag)
				{
					this._SignageSelector.Scroll -= value2;
				}
				this._SignageSelector = value;
				flag = (this._SignageSelector != null);
				if (flag)
				{
					this._SignageSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00015E2C File Offset: 0x0001402C
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00002F52 File Offset: 0x00001152
		internal virtual Label Label16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label16 = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00015E44 File Offset: 0x00014044
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00002F5C File Offset: 0x0000115C
		internal virtual Label Label18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label18 = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00015E5C File Offset: 0x0001405C
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00002F66 File Offset: 0x00001166
		internal virtual Label PlayerGraffitiLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PlayerGraffitiLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PlayerGraffitiLabel = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00015E74 File Offset: 0x00014074
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00015E8C File Offset: 0x0001408C
		internal virtual TrackBar PlayerGraffitiSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PlayerGraffitiSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PlayerGraffitiSelector_Scroll);
				bool flag = this._PlayerGraffitiSelector != null;
				if (flag)
				{
					this._PlayerGraffitiSelector.Scroll -= value2;
				}
				this._PlayerGraffitiSelector = value;
				flag = (this._PlayerGraffitiSelector != null);
				if (flag)
				{
					this._PlayerGraffitiSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00015EEC File Offset: 0x000140EC
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00002F70 File Offset: 0x00001170
		internal virtual Label Label19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label19 = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00015F04 File Offset: 0x00014104
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00002F7A File Offset: 0x0000117A
		internal virtual Label PlayerStatueLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PlayerStatueLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PlayerStatueLabel = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00015F1C File Offset: 0x0001411C
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00015F34 File Offset: 0x00014134
		internal virtual TrackBar PlayerStatueSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PlayerStatueSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PlayerStatueSelector_Scroll);
				bool flag = this._PlayerStatueSelector != null;
				if (flag)
				{
					this._PlayerStatueSelector.Scroll -= value2;
				}
				this._PlayerStatueSelector = value;
				flag = (this._PlayerStatueSelector != null);
				if (flag)
				{
					this._PlayerStatueSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00015F94 File Offset: 0x00014194
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00002F84 File Offset: 0x00001184
		internal virtual Label Label21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label21 = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00015FAC File Offset: 0x000141AC
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00002F8E File Offset: 0x0000118E
		internal virtual Label CharacterSharedLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CharacterSharedLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CharacterSharedLabel = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00015FC4 File Offset: 0x000141C4
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00015FDC File Offset: 0x000141DC
		internal virtual TrackBar CharacterSharedSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CharacterSharedSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CharacterSharedSelector_Scroll);
				bool flag = this._CharacterSharedSelector != null;
				if (flag)
				{
					this._CharacterSharedSelector.Scroll -= value2;
				}
				this._CharacterSharedSelector = value;
				flag = (this._CharacterSharedSelector != null);
				if (flag)
				{
					this._CharacterSharedSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0001603C File Offset: 0x0001423C
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00002F98 File Offset: 0x00001198
		internal virtual Label Label22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label22 = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00016054 File Offset: 0x00014254
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00002FA2 File Offset: 0x000011A2
		internal virtual Label VehicleSharedLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VehicleSharedLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._VehicleSharedLabel = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0001606C File Offset: 0x0001426C
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00016084 File Offset: 0x00014284
		internal virtual TrackBar VehicleSharedSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VehicleSharedSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.VehicleSharedSelector_Scroll);
				bool flag = this._VehicleSharedSelector != null;
				if (flag)
				{
					this._VehicleSharedSelector.Scroll -= value2;
				}
				this._VehicleSharedSelector = value;
				flag = (this._VehicleSharedSelector != null);
				if (flag)
				{
					this._VehicleSharedSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000160E4 File Offset: 0x000142E4
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00002FAC File Offset: 0x000011AC
		internal virtual Label Label20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label20 = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600026B RID: 619 RVA: 0x000160FC File Offset: 0x000142FC
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00002FB6 File Offset: 0x000011B6
		internal virtual Label ContactLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContactLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContactLabel = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00016114 File Offset: 0x00014314
		// (set) Token: 0x0600026E RID: 622 RVA: 0x0001612C File Offset: 0x0001432C
		internal virtual TrackBar ContactSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContactSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ContactSelector_Scroll);
				bool flag = this._ContactSelector != null;
				if (flag)
				{
					this._ContactSelector.Scroll -= value2;
				}
				this._ContactSelector = value;
				flag = (this._ContactSelector != null);
				if (flag)
				{
					this._ContactSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0001618C File Offset: 0x0001438C
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00002FC0 File Offset: 0x000011C0
		internal virtual Label Label23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label23 = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000271 RID: 625 RVA: 0x000161A4 File Offset: 0x000143A4
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00002FCA File Offset: 0x000011CA
		internal virtual Label CharacterDNMLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CharacterDNMLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CharacterDNMLabel = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000273 RID: 627 RVA: 0x000161BC File Offset: 0x000143BC
		// (set) Token: 0x06000274 RID: 628 RVA: 0x000161D4 File Offset: 0x000143D4
		internal virtual TrackBar CharacterDNMSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CharacterDNMSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CharacterDNMSelector_Scroll);
				bool flag = this._CharacterDNMSelector != null;
				if (flag)
				{
					this._CharacterDNMSelector.Scroll -= value2;
				}
				this._CharacterDNMSelector = value;
				flag = (this._CharacterDNMSelector != null);
				if (flag)
				{
					this._CharacterDNMSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00016234 File Offset: 0x00014434
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00002FD4 File Offset: 0x000011D4
		internal virtual Label Label24
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label24;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label24 = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0001624C File Offset: 0x0001444C
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00002FDE File Offset: 0x000011DE
		internal virtual Label PlayerVehicleLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PlayerVehicleLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PlayerVehicleLabel = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00016264 File Offset: 0x00014464
		// (set) Token: 0x0600027A RID: 634 RVA: 0x0001627C File Offset: 0x0001447C
		internal virtual TrackBar PlayerVehicleSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PlayerVehicleSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PlayerVehicleSelector_Scroll);
				bool flag = this._PlayerVehicleSelector != null;
				if (flag)
				{
					this._PlayerVehicleSelector.Scroll -= value2;
				}
				this._PlayerVehicleSelector = value;
				flag = (this._PlayerVehicleSelector != null);
				if (flag)
				{
					this._PlayerVehicleSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600027B RID: 635 RVA: 0x000162DC File Offset: 0x000144DC
		// (set) Token: 0x0600027C RID: 636 RVA: 0x000162F4 File Offset: 0x000144F4
		internal virtual Button Button4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button4_Click);
				bool flag = this._Button4 != null;
				if (flag)
				{
					this._Button4.Click -= value2;
				}
				this._Button4 = value;
				flag = (this._Button4 != null);
				if (flag)
				{
					this._Button4.Click += value2;
				}
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00016354 File Offset: 0x00014554
		// (set) Token: 0x0600027E RID: 638 RVA: 0x0001636C File Offset: 0x0001456C
		internal virtual GroupBox GroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GroupBox4_Enter);
				bool flag = this._GroupBox4 != null;
				if (flag)
				{
					this._GroupBox4.Enter -= value2;
				}
				this._GroupBox4 = value;
				flag = (this._GroupBox4 != null);
				if (flag)
				{
					this._GroupBox4.Enter += value2;
				}
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600027F RID: 639 RVA: 0x000163CC File Offset: 0x000145CC
		// (set) Token: 0x06000280 RID: 640 RVA: 0x000163E4 File Offset: 0x000145E4
		internal virtual Panel Panel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Panel2_Click);
				bool flag = this._Panel2 != null;
				if (flag)
				{
					this._Panel2.Click -= value2;
				}
				this._Panel2 = value;
				flag = (this._Panel2 != null);
				if (flag)
				{
					this._Panel2.Click += value2;
				}
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00016444 File Offset: 0x00014644
		// (set) Token: 0x06000282 RID: 642 RVA: 0x00002FE8 File Offset: 0x000011E8
		internal virtual Label ParticleLODBiasLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ParticleLODBiasLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ParticleLODBiasLabel = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0001645C File Offset: 0x0001465C
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00016474 File Offset: 0x00014674
		internal virtual TrackBar ParticleLODBiasSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ParticleLODBiasSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ParticleLODBiasSelector_Scroll);
				bool flag = this._ParticleLODBiasSelector != null;
				if (flag)
				{
					this._ParticleLODBiasSelector.Scroll -= value2;
				}
				this._ParticleLODBiasSelector = value;
				flag = (this._ParticleLODBiasSelector != null);
				if (flag)
				{
					this._ParticleLODBiasSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000285 RID: 645 RVA: 0x000164D4 File Offset: 0x000146D4
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00002FF2 File Offset: 0x000011F2
		internal virtual Label Label65
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label65;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label65 = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000287 RID: 647 RVA: 0x000164EC File Offset: 0x000146EC
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00002FFC File Offset: 0x000011FC
		internal virtual Label Label26
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label26;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label26 = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00016504 File Offset: 0x00014704
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00003006 File Offset: 0x00001206
		internal virtual Label ShadowQualityBiasLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShadowQualityBiasLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ShadowQualityBiasLabel = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0001651C File Offset: 0x0001471C
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00016534 File Offset: 0x00014734
		internal virtual TrackBar ShadowQualityBiasSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShadowQualityBiasSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ShadowQualityBiasSelector_Scroll);
				bool flag = this._ShadowQualityBiasSelector != null;
				if (flag)
				{
					this._ShadowQualityBiasSelector.Scroll -= value2;
				}
				this._ShadowQualityBiasSelector = value;
				flag = (this._ShadowQualityBiasSelector != null);
				if (flag)
				{
					this._ShadowQualityBiasSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00016594 File Offset: 0x00014794
		// (set) Token: 0x0600028E RID: 654 RVA: 0x00003010 File Offset: 0x00001210
		internal virtual Label Label25
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label25;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label25 = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600028F RID: 655 RVA: 0x000165AC File Offset: 0x000147AC
		// (set) Token: 0x06000290 RID: 656 RVA: 0x0000301A File Offset: 0x0000121A
		internal virtual Label SunRenderQualityLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SunRenderQualityLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SunRenderQualityLabel = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000291 RID: 657 RVA: 0x000165C4 File Offset: 0x000147C4
		// (set) Token: 0x06000292 RID: 658 RVA: 0x000165DC File Offset: 0x000147DC
		internal virtual TrackBar SunRenderQualitySelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SunRenderQualitySelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SunRenderQualitySelector_Scroll);
				bool flag = this._SunRenderQualitySelector != null;
				if (flag)
				{
					this._SunRenderQualitySelector.Scroll -= value2;
				}
				this._SunRenderQualitySelector = value;
				flag = (this._SunRenderQualitySelector != null);
				if (flag)
				{
					this._SunRenderQualitySelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0001663C File Offset: 0x0001483C
		// (set) Token: 0x06000294 RID: 660 RVA: 0x00003024 File Offset: 0x00001224
		internal virtual Label Label27
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label27;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label27 = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00016654 File Offset: 0x00014854
		// (set) Token: 0x06000296 RID: 662 RVA: 0x0000302E File Offset: 0x0000122E
		internal virtual Label ParticleSpaceAreaLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ParticleSpaceAreaLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ParticleSpaceAreaLabel = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0001666C File Offset: 0x0001486C
		// (set) Token: 0x06000298 RID: 664 RVA: 0x00016684 File Offset: 0x00014884
		internal virtual TrackBar ParticleSpaceAreaSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ParticleSpaceAreaSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ParticleSpaceAreaSelector_Scroll);
				bool flag = this._ParticleSpaceAreaSelector != null;
				if (flag)
				{
					this._ParticleSpaceAreaSelector.Scroll -= value2;
				}
				this._ParticleSpaceAreaSelector = value;
				flag = (this._ParticleSpaceAreaSelector != null);
				if (flag)
				{
					this._ParticleSpaceAreaSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000299 RID: 665 RVA: 0x000166E4 File Offset: 0x000148E4
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00003038 File Offset: 0x00001238
		internal virtual Label Label28
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label28;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label28 = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600029B RID: 667 RVA: 0x000166FC File Offset: 0x000148FC
		// (set) Token: 0x0600029C RID: 668 RVA: 0x00003042 File Offset: 0x00001242
		internal virtual Label FoliageDrawRadiusLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FoliageDrawRadiusLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FoliageDrawRadiusLabel = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00016714 File Offset: 0x00014914
		// (set) Token: 0x0600029E RID: 670 RVA: 0x0001672C File Offset: 0x0001492C
		internal virtual TrackBar FoliageDrawRadiusSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FoliageDrawRadiusSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FoliageDrawRadiusSelector_Scroll);
				bool flag = this._FoliageDrawRadiusSelector != null;
				if (flag)
				{
					this._FoliageDrawRadiusSelector.Scroll -= value2;
				}
				this._FoliageDrawRadiusSelector = value;
				flag = (this._FoliageDrawRadiusSelector != null);
				if (flag)
				{
					this._FoliageDrawRadiusSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0001678C File Offset: 0x0001498C
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x0000304C File Offset: 0x0000124C
		internal virtual Label Label29
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label29;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label29 = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x000167A4 File Offset: 0x000149A4
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x00003056 File Offset: 0x00001256
		internal virtual Label ShadowFilterRadiusLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShadowFilterRadiusLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ShadowFilterRadiusLabel = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x000167BC File Offset: 0x000149BC
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x000167D4 File Offset: 0x000149D4
		internal virtual TrackBar ShadowFilterRadiusSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShadowFilterRadiusSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ShadowFilterRadiusSelector_Scroll);
				bool flag = this._ShadowFilterRadiusSelector != null;
				if (flag)
				{
					this._ShadowFilterRadiusSelector.Scroll -= value2;
				}
				this._ShadowFilterRadiusSelector = value;
				flag = (this._ShadowFilterRadiusSelector != null);
				if (flag)
				{
					this._ShadowFilterRadiusSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00016834 File Offset: 0x00014A34
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00003060 File Offset: 0x00001260
		internal virtual Label Label30
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label30;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label30 = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0001684C File Offset: 0x00014A4C
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000306A File Offset: 0x0000126A
		internal virtual Label ShadowDepthBiasLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShadowDepthBiasLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ShadowDepthBiasLabel = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00016864 File Offset: 0x00014A64
		// (set) Token: 0x060002AA RID: 682 RVA: 0x0001687C File Offset: 0x00014A7C
		internal virtual TrackBar ShadowDepthBiasSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShadowDepthBiasSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ShadowDepthBiasSelector_Scroll);
				bool flag = this._ShadowDepthBiasSelector != null;
				if (flag)
				{
					this._ShadowDepthBiasSelector.Scroll -= value2;
				}
				this._ShadowDepthBiasSelector = value;
				flag = (this._ShadowDepthBiasSelector != null);
				if (flag)
				{
					this._ShadowDepthBiasSelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060002AB RID: 683 RVA: 0x000168DC File Offset: 0x00014ADC
		// (set) Token: 0x060002AC RID: 684 RVA: 0x00003074 File Offset: 0x00001274
		internal virtual Label Label31
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label31;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label31 = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060002AD RID: 685 RVA: 0x000168F4 File Offset: 0x00014AF4
		// (set) Token: 0x060002AE RID: 686 RVA: 0x0000307E File Offset: 0x0000127E
		internal virtual Label MaxMemoryCacheEntryLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MaxMemoryCacheEntryLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MaxMemoryCacheEntryLabel = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0001690C File Offset: 0x00014B0C
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x00016924 File Offset: 0x00014B24
		internal virtual TrackBar MaxMemoryCacheEntrySelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MaxMemoryCacheEntrySelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.MaxMemoryCacheEntrySelector_Scroll);
				bool flag = this._MaxMemoryCacheEntrySelector != null;
				if (flag)
				{
					this._MaxMemoryCacheEntrySelector.Scroll -= value2;
				}
				this._MaxMemoryCacheEntrySelector = value;
				flag = (this._MaxMemoryCacheEntrySelector != null);
				if (flag)
				{
					this._MaxMemoryCacheEntrySelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00016984 File Offset: 0x00014B84
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x00003088 File Offset: 0x00001288
		internal virtual Label Label32
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label32;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label32 = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0001699C File Offset: 0x00014B9C
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00003092 File Offset: 0x00001292
		internal virtual Label TextureStreamingMemoryLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextureStreamingMemoryLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextureStreamingMemoryLabel = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x000169B4 File Offset: 0x00014BB4
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x000169CC File Offset: 0x00014BCC
		internal virtual TrackBar TextureStreamingMemorySelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextureStreamingMemorySelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextureStreamingMemorySelector_Scroll);
				bool flag = this._TextureStreamingMemorySelector != null;
				if (flag)
				{
					this._TextureStreamingMemorySelector.Scroll -= value2;
				}
				this._TextureStreamingMemorySelector = value;
				flag = (this._TextureStreamingMemorySelector != null);
				if (flag)
				{
					this._TextureStreamingMemorySelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00016A2C File Offset: 0x00014C2C
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x0000309C File Offset: 0x0000129C
		internal virtual Label Label33
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label33;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label33 = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00016A44 File Offset: 0x00014C44
		// (set) Token: 0x060002BA RID: 698 RVA: 0x000030A6 File Offset: 0x000012A6
		internal virtual Label TexturePoolMemoryLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TexturePoolMemoryLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TexturePoolMemoryLabel = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00016A5C File Offset: 0x00014C5C
		// (set) Token: 0x060002BC RID: 700 RVA: 0x00016A74 File Offset: 0x00014C74
		internal virtual TrackBar TexturePoolMemorySelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TexturePoolMemorySelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TexturePoolMemorySelector_Scroll);
				bool flag = this._TexturePoolMemorySelector != null;
				if (flag)
				{
					this._TexturePoolMemorySelector.Scroll -= value2;
				}
				this._TexturePoolMemorySelector = value;
				flag = (this._TexturePoolMemorySelector != null);
				if (flag)
				{
					this._TexturePoolMemorySelector.Scroll += value2;
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00016AD4 File Offset: 0x00014CD4
		// (set) Token: 0x060002BE RID: 702 RVA: 0x000030B0 File Offset: 0x000012B0
		internal virtual Label Label38
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label38;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label38 = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00016AEC File Offset: 0x00014CEC
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x000030BA File Offset: 0x000012BA
		internal virtual Label MeshStreamingMemoryLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MeshStreamingMemoryLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MeshStreamingMemoryLabel = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00016B04 File Offset: 0x00014D04
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x00016B1C File Offset: 0x00014D1C
		internal virtual TrackBar MeshStreamingMemorySelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MeshStreamingMemorySelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.MeshStreamingMemorySelector_Scroll);
				bool flag = this._MeshStreamingMemorySelector != null;
				if (flag)
				{
					this._MeshStreamingMemorySelector.Scroll -= value2;
				}
				this._MeshStreamingMemorySelector = value;
				flag = (this._MeshStreamingMemorySelector != null);
				if (flag)
				{
					this._MeshStreamingMemorySelector.Scroll += value2;
				}
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00016B7C File Offset: 0x00014D7C
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x000030C4 File Offset: 0x000012C4
		internal virtual Label Label39
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label39;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label39 = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00016B94 File Offset: 0x00014D94
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x000030CE File Offset: 0x000012CE
		internal virtual Label Label37
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label37;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label37 = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00016BAC File Offset: 0x00014DAC
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x000030D8 File Offset: 0x000012D8
		internal virtual Label Label35
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label35;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label35 = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00016BC4 File Offset: 0x00014DC4
		// (set) Token: 0x060002CA RID: 714 RVA: 0x000030E2 File Offset: 0x000012E2
		internal virtual TextBox TextureCreationPerFrameBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextureCreationPerFrameBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextureCreationPerFrameBox = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00016BDC File Offset: 0x00014DDC
		// (set) Token: 0x060002CC RID: 716 RVA: 0x000030EC File Offset: 0x000012EC
		internal virtual Label Label44
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label44;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label44 = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00016BF4 File Offset: 0x00014DF4
		// (set) Token: 0x060002CE RID: 718 RVA: 0x000030F6 File Offset: 0x000012F6
		internal virtual Label Label40
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label40;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label40 = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00016C0C File Offset: 0x00014E0C
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x00003100 File Offset: 0x00001300
		internal virtual Label Label41
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label41;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label41 = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00016C24 File Offset: 0x00014E24
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x0000310A File Offset: 0x0000130A
		internal virtual Label Label42
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label42;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label42 = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00016C3C File Offset: 0x00014E3C
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00003114 File Offset: 0x00001314
		internal virtual TextBox DynamicShadowsBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DynamicShadowsBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DynamicShadowsBox = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00016C54 File Offset: 0x00014E54
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x0000311E File Offset: 0x0000131E
		internal virtual Label Label45
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label45;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label45 = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00016C6C File Offset: 0x00014E6C
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x00003128 File Offset: 0x00001328
		internal virtual Label Label46
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label46;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label46 = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00016C84 File Offset: 0x00014E84
		// (set) Token: 0x060002DA RID: 730 RVA: 0x00003132 File Offset: 0x00001332
		internal virtual Label Label47
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label47;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label47 = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00016C9C File Offset: 0x00014E9C
		// (set) Token: 0x060002DC RID: 732 RVA: 0x0000313C File Offset: 0x0000133C
		internal virtual Label Label48
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label48;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label48 = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00016CB4 File Offset: 0x00014EB4
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00003146 File Offset: 0x00001346
		internal virtual TextBox ShadowFadeDistanceBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShadowFadeDistanceBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ShadowFadeDistanceBox = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00016CCC File Offset: 0x00014ECC
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x00003150 File Offset: 0x00001350
		internal virtual Label Label43
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label43;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label43 = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00016CE4 File Offset: 0x00014EE4
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x0000315A File Offset: 0x0000135A
		internal virtual Label Label49
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label49;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label49 = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00016CFC File Offset: 0x00014EFC
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00003164 File Offset: 0x00001364
		internal virtual Label Label50
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label50;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label50 = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00016D14 File Offset: 0x00014F14
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0000316E File Offset: 0x0000136E
		internal virtual Label Label51
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label51;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label51 = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00016D2C File Offset: 0x00014F2C
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00003178 File Offset: 0x00001378
		internal virtual Label Label52
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label52;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label52 = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00016D44 File Offset: 0x00014F44
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00003182 File Offset: 0x00001382
		internal virtual TextBox CharacterLODDistance1Box
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CharacterLODDistance1Box;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CharacterLODDistance1Box = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00016D5C File Offset: 0x00014F5C
		// (set) Token: 0x060002EC RID: 748 RVA: 0x0000318C File Offset: 0x0000138C
		internal virtual Label Label53
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label53;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label53 = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00016D74 File Offset: 0x00014F74
		// (set) Token: 0x060002EE RID: 750 RVA: 0x00003196 File Offset: 0x00001396
		internal virtual Label Label54
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label54;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label54 = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00016D8C File Offset: 0x00014F8C
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x000031A0 File Offset: 0x000013A0
		internal virtual Label Label55
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label55;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label55 = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00016DA4 File Offset: 0x00014FA4
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x000031AA File Offset: 0x000013AA
		internal virtual Label Label56
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label56;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label56 = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00016DBC File Offset: 0x00014FBC
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x000031B4 File Offset: 0x000013B4
		internal virtual TextBox CharacterLODDistance2Box
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CharacterLODDistance2Box;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CharacterLODDistance2Box = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00016DD4 File Offset: 0x00014FD4
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x000031BE File Offset: 0x000013BE
		internal virtual Label Label57
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label57;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label57 = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00016DEC File Offset: 0x00014FEC
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x000031C8 File Offset: 0x000013C8
		internal virtual Label Label58
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label58;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label58 = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00016E04 File Offset: 0x00015004
		// (set) Token: 0x060002FA RID: 762 RVA: 0x000031D2 File Offset: 0x000013D2
		internal virtual Label Label59
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label59;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label59 = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00016E1C File Offset: 0x0001501C
		// (set) Token: 0x060002FC RID: 764 RVA: 0x000031DC File Offset: 0x000013DC
		internal virtual Label Label60
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label60;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label60 = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00016E34 File Offset: 0x00015034
		// (set) Token: 0x060002FE RID: 766 RVA: 0x000031E6 File Offset: 0x000013E6
		internal virtual TextBox VehicleLODDistanceBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VehicleLODDistanceBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._VehicleLODDistanceBox = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060002FF RID: 767 RVA: 0x00016E4C File Offset: 0x0001504C
		// (set) Token: 0x06000300 RID: 768 RVA: 0x000031F0 File Offset: 0x000013F0
		internal virtual Label Label61
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label61;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label61 = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00016E64 File Offset: 0x00015064
		// (set) Token: 0x06000302 RID: 770 RVA: 0x000031FA File Offset: 0x000013FA
		internal virtual Label Label62
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label62;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label62 = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00016E7C File Offset: 0x0001507C
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00003204 File Offset: 0x00001404
		internal virtual Label Label63
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label63;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label63 = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00016E94 File Offset: 0x00015094
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0000320E File Offset: 0x0000140E
		internal virtual Label Label64
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label64;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label64 = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00016EAC File Offset: 0x000150AC
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00003218 File Offset: 0x00001418
		internal virtual TextBox VehicleCullDistanceBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VehicleCullDistanceBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._VehicleCullDistanceBox = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00016EC4 File Offset: 0x000150C4
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00003222 File Offset: 0x00001422
		internal virtual Label Label70
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label70;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label70 = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00016EDC File Offset: 0x000150DC
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0000322C File Offset: 0x0000142C
		internal virtual Label Label71
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label71;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label71 = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00016EF4 File Offset: 0x000150F4
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00003236 File Offset: 0x00001436
		internal virtual Label Label72
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label72;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label72 = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00016F0C File Offset: 0x0001510C
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00003240 File Offset: 0x00001440
		internal virtual Label Label73
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label73;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label73 = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00016F24 File Offset: 0x00015124
		// (set) Token: 0x06000312 RID: 786 RVA: 0x0000324A File Offset: 0x0000144A
		internal virtual TextBox PedestrianCullDistanceBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PedestrianCullDistanceBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PedestrianCullDistanceBox = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00016F3C File Offset: 0x0001513C
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00003254 File Offset: 0x00001454
		internal virtual Label Label66
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label66;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label66 = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00016F54 File Offset: 0x00015154
		// (set) Token: 0x06000316 RID: 790 RVA: 0x0000325E File Offset: 0x0000145E
		internal virtual Label Label67
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label67;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label67 = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00016F6C File Offset: 0x0001516C
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00003268 File Offset: 0x00001468
		internal virtual Label Label68
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label68;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label68 = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00016F84 File Offset: 0x00015184
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00003272 File Offset: 0x00001472
		internal virtual Label Label69
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label69;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label69 = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00016F9C File Offset: 0x0001519C
		// (set) Token: 0x0600031C RID: 796 RVA: 0x0000327C File Offset: 0x0000147C
		internal virtual TextBox PedestrianLODDistanceBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PedestrianLODDistanceBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PedestrianLODDistanceBox = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00016FB4 File Offset: 0x000151B4
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00003286 File Offset: 0x00001486
		internal virtual Label Label74
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label74;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label74 = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00016FCC File Offset: 0x000151CC
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00003290 File Offset: 0x00001490
		internal virtual Label Label75
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label75;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label75 = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00016FE4 File Offset: 0x000151E4
		// (set) Token: 0x06000322 RID: 802 RVA: 0x0000329A File Offset: 0x0000149A
		internal virtual Label Label76
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label76;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label76 = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00016FFC File Offset: 0x000151FC
		// (set) Token: 0x06000324 RID: 804 RVA: 0x000032A4 File Offset: 0x000014A4
		internal virtual Label Label77
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label77;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label77 = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00017014 File Offset: 0x00015214
		// (set) Token: 0x06000326 RID: 806 RVA: 0x000032AE File Offset: 0x000014AE
		internal virtual TextBox DriverCullDistanceBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DriverCullDistanceBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DriverCullDistanceBox = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0001702C File Offset: 0x0001522C
		// (set) Token: 0x06000328 RID: 808 RVA: 0x000032B8 File Offset: 0x000014B8
		internal virtual Label Label78
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label78;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label78 = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00017044 File Offset: 0x00015244
		// (set) Token: 0x0600032A RID: 810 RVA: 0x000032C2 File Offset: 0x000014C2
		internal virtual Label Label79
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label79;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label79 = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0001705C File Offset: 0x0001525C
		// (set) Token: 0x0600032C RID: 812 RVA: 0x000032CC File Offset: 0x000014CC
		internal virtual Label Label80
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label80;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label80 = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00017074 File Offset: 0x00015274
		// (set) Token: 0x0600032E RID: 814 RVA: 0x000032D6 File Offset: 0x000014D6
		internal virtual Label Label81
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label81;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label81 = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0001708C File Offset: 0x0001528C
		// (set) Token: 0x06000330 RID: 816 RVA: 0x000032E0 File Offset: 0x000014E0
		internal virtual TextBox DriverLODDistanceBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DriverLODDistanceBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DriverLODDistanceBox = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000331 RID: 817 RVA: 0x000170A4 File Offset: 0x000152A4
		// (set) Token: 0x06000332 RID: 818 RVA: 0x000032EA File Offset: 0x000014EA
		internal virtual Label Label82
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label82;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label82 = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000333 RID: 819 RVA: 0x000170BC File Offset: 0x000152BC
		// (set) Token: 0x06000334 RID: 820 RVA: 0x000032F4 File Offset: 0x000014F4
		internal virtual Label Label83
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label83;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label83 = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000335 RID: 821 RVA: 0x000170D4 File Offset: 0x000152D4
		// (set) Token: 0x06000336 RID: 822 RVA: 0x000032FE File Offset: 0x000014FE
		internal virtual Label Label84
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label84;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label84 = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000337 RID: 823 RVA: 0x000170EC File Offset: 0x000152EC
		// (set) Token: 0x06000338 RID: 824 RVA: 0x00003308 File Offset: 0x00001508
		internal virtual Label Label85
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label85;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label85 = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000339 RID: 825 RVA: 0x00017104 File Offset: 0x00015304
		// (set) Token: 0x0600033A RID: 826 RVA: 0x00003312 File Offset: 0x00001512
		internal virtual TextBox LCVehicleCullDistanceBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LCVehicleCullDistanceBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LCVehicleCullDistanceBox = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0001711C File Offset: 0x0001531C
		// (set) Token: 0x0600033C RID: 828 RVA: 0x0000331C File Offset: 0x0000151C
		internal virtual Label Label86
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label86;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label86 = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00017134 File Offset: 0x00015334
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00003326 File Offset: 0x00001526
		internal virtual Label Label87
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label87;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label87 = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0001714C File Offset: 0x0001534C
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00003330 File Offset: 0x00001530
		internal virtual Label Label88
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label88;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label88 = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00017164 File Offset: 0x00015364
		// (set) Token: 0x06000342 RID: 834 RVA: 0x0000333A File Offset: 0x0000153A
		internal virtual Label Label89
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label89;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label89 = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0001717C File Offset: 0x0001537C
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00003344 File Offset: 0x00001544
		internal virtual TextBox LCVehicleLODDistanceBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LCVehicleLODDistanceBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LCVehicleLODDistanceBox = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00017194 File Offset: 0x00015394
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000171AC File Offset: 0x000153AC
		internal virtual TrackBar QualityBar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QualityBar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.QualityBar_Scroll);
				bool flag = this._QualityBar != null;
				if (flag)
				{
					this._QualityBar.Scroll -= value2;
				}
				this._QualityBar = value;
				flag = (this._QualityBar != null);
				if (flag)
				{
					this._QualityBar.Scroll += value2;
				}
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0001720C File Offset: 0x0001540C
		// (set) Token: 0x06000348 RID: 840 RVA: 0x0000334E File Offset: 0x0000154E
		internal virtual Label QualityLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QualityLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._QualityLabel = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00017224 File Offset: 0x00015424
		// (set) Token: 0x0600034A RID: 842 RVA: 0x00003358 File Offset: 0x00001558
		internal virtual TextBox ResX
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ResX;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ResX = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0001723C File Offset: 0x0001543C
		// (set) Token: 0x0600034C RID: 844 RVA: 0x00003362 File Offset: 0x00001562
		internal virtual TextBox ResY
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ResY;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ResY = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00017254 File Offset: 0x00015454
		// (set) Token: 0x0600034E RID: 846 RVA: 0x0000336C File Offset: 0x0000156C
		internal virtual Label ResYLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ResYLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ResYLabel = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600034F RID: 847 RVA: 0x0001726C File Offset: 0x0001546C
		// (set) Token: 0x06000350 RID: 848 RVA: 0x00003376 File Offset: 0x00001576
		internal virtual Label ResXLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ResXLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ResXLabel = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00017284 File Offset: 0x00015484
		// (set) Token: 0x06000352 RID: 850 RVA: 0x0001729C File Offset: 0x0001549C
		internal virtual Button Button5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button5_Click);
				bool flag = this._Button5 != null;
				if (flag)
				{
					this._Button5.Click -= value2;
				}
				this._Button5 = value;
				flag = (this._Button5 != null);
				if (flag)
				{
					this._Button5.Click += value2;
				}
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000353 RID: 851 RVA: 0x000172FC File Offset: 0x000154FC
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00003380 File Offset: 0x00001580
		internal virtual GroupBox OtherBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OtherBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OtherBox = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00017314 File Offset: 0x00015514
		// (set) Token: 0x06000356 RID: 854 RVA: 0x0000338A File Offset: 0x0000158A
		internal virtual CheckBox MouseAccelSelector
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MouseAccelSelector;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MouseAccelSelector = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000357 RID: 855 RVA: 0x0001732C File Offset: 0x0001552C
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00003394 File Offset: 0x00001594
		internal virtual Label Label34
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label34;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label34 = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00017344 File Offset: 0x00015544
		// (set) Token: 0x0600035A RID: 858 RVA: 0x0000339E File Offset: 0x0000159E
		internal virtual Label Label36
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label36;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label36 = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0001735C File Offset: 0x0001555C
		// (set) Token: 0x0600035C RID: 860 RVA: 0x000033A8 File Offset: 0x000015A8
		internal virtual ComboBox EnableFullScreen
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnableFullScreen;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EnableFullScreen = value;
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00017374 File Offset: 0x00015574
		private void SetingsForm_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				this.IsDraggingForm = true;
				this.MousePos = e.Location;
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000173A8 File Offset: 0x000155A8
		private void SetingsForm_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				this.IsDraggingForm = false;
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000173D0 File Offset: 0x000155D0
		private void SetingsForm_MouseMove(object sender, MouseEventArgs e)
		{
			bool isDraggingForm = this.IsDraggingForm;
			if (isDraggingForm)
			{
				Point location = new Point((Size)(this.Location + (Size)(e.Location - (Size)this.MousePos)));
				this.Location = location;
				location = default(Point);
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00017430 File Offset: 0x00015630
		private void SettingsForm_Load(object sender, EventArgs e)
		{
			this.ResolutionSelector.Text = MySettingsProperty.Settings.ResolutionSetting;
			this.ResX.Text = MySettingsProperty.Settings.ResXSetting;
			this.ResY.Text = MySettingsProperty.Settings.ResYSetting;
			this.AnisoSelector.Text = MySettingsProperty.Settings.AnisotropySetting;
			this.EnableFullScreen.Text = MySettingsProperty.Settings.FullscreenSetting;
			this.EnableVsync.Checked = MySettingsProperty.Settings.VsyncSetting;
			this.EnableSmoothFrameRate.Checked = MySettingsProperty.Settings.SmoothFrameRateSetting;
			this.EnableStaticDecals.Checked = MySettingsProperty.Settings.StaticDecalsSetting;
			this.EnableDynamicShadows.Checked = MySettingsProperty.Settings.DynamicShadowsSetting;
			this.EnableLEShadows.Checked = MySettingsProperty.Settings.LEShadowsSetting;
			this.EnableBlobShadows.Checked = MySettingsProperty.Settings.BlobShadowsSetting;
			this.EnableAmbientOcclusion.Checked = MySettingsProperty.Settings.AOSetting;
			this.EnableBloom.Checked = MySettingsProperty.Settings.BloomSetting;
			this.EnableDistortion.Checked = MySettingsProperty.Settings.DistortionSetting;
			this.EnableTrilinear.Checked = MySettingsProperty.Settings.TrilinearSetting;
			this.EnableLQHealthHUD.Checked = MySettingsProperty.Settings.LQHealthHUDSetting;
			this.EnableEyelashes.Checked = MySettingsProperty.Settings.RenderEyelashesSetting;
			this.EnableDynamicDecals.Checked = MySettingsProperty.Settings.DynamicDecalsSetting;
			this.EnableLevelParticles.Checked = MySettingsProperty.Settings.LevelParticleSettings;
			this.EnableDynamicLights.Checked = MySettingsProperty.Settings.DynamicLightsSetting;
			this.EnableCDLights.Checked = MySettingsProperty.Settings.CDLightsSetting;
			this.EnableDirectionalLightmaps.Checked = MySettingsProperty.Settings.DirectionalLightmapsSetting;
			this.EnableMotionBlur.Checked = MySettingsProperty.Settings.MotionBlurSetting;
			this.EnableDepthOfField.Checked = MySettingsProperty.Settings.DepthOfFieldSetting;
			this.EnableQualityBloom.Checked = MySettingsProperty.Settings.QualityBloomSetting;
			this.EnableDPDistortion.Checked = MySettingsProperty.Settings.DPDistortionSetting;
			this.EnableSTLeaves.Checked = MySettingsProperty.Settings.STLeavesSetting;
			this.EnableSTFronds.Checked = MySettingsProperty.Settings.STFrondsSetting;
			this.EnableStreamTextures.Checked = MySettingsProperty.Settings.StreamTexturesSetting;
			this.EnableLensFlares.Checked = MySettingsProperty.Settings.LensFlaresSetting;
			this.EnableFogVolumes.Checked = MySettingsProperty.Settings.FogVolumesSetting;
			this.EnableFPRTargets.Checked = MySettingsProperty.Settings.FPRTargetsSetting;
			this.EnableThreadLag.Checked = MySettingsProperty.Settings.ThreadLagSetting;
			this.EnableUpscaleSP.Checked = MySettingsProperty.Settings.UpscaleSPSetting;
			this.EnableHighPolyChars.Checked = MySettingsProperty.Settings.HighPolyCharsSetting;
			this.EnableVSMShadows.Checked = MySettingsProperty.Settings.VSMShadowsSetting;
			this.EnablePCFShadows.Checked = MySettingsProperty.Settings.PCFShadowsSetting;
			this.EnableBetterShadows.Checked = MySettingsProperty.Settings.BetterShadowsSetting;
			this.EnableForegroundShadows.Checked = MySettingsProperty.Settings.ForegroundShadowsSetting;
			this.EnableSimpleVehicleMaterials.Checked = MySettingsProperty.Settings.SimpleVehicleMaterialsSetting;
			this.EnableDXTLocalCharacter.Checked = MySettingsProperty.Settings.DXTLocalCharacterSetting;
			this.EnableDXTLocalVehicle.Checked = MySettingsProperty.Settings.DXTLocalVehicleSetting;
			this.EnableDXTOtherCharacter.Checked = MySettingsProperty.Settings.DXTOtherCharacterSetting;
			this.EnableDXTOtherVehicle.Checked = MySettingsProperty.Settings.DXTOtherVehicleSetting;
			this.EnableDXTNormal.Checked = MySettingsProperty.Settings.DXTNormalSetting;
			this.UnknownSelector.Value = MySettingsProperty.Settings.UnknownSetting;
			this.UnknownLabel.Text = MySettingsProperty.Settings.UnknownLabelSetting;
			this.EnvironmentSelector.Value = MySettingsProperty.Settings.EnvironmentSetting;
			this.EnvironmentLabel.Text = MySettingsProperty.Settings.EnvironmentLabelSetting;
			this.PropSelector.Value = MySettingsProperty.Settings.PropSetting;
			this.PropLabel.Text = MySettingsProperty.Settings.PropLabelSetting;
			this.CharacterSelector.Value = MySettingsProperty.Settings.CharacterSetting;
			this.CharacterLabel.Text = MySettingsProperty.Settings.CharacterLabelSetting;
			this.VehicleSelector.Value = MySettingsProperty.Settings.VehicleSetting;
			this.VehicleLabel.Text = MySettingsProperty.Settings.VehicleLabelSetting;
			this.PedestrianSelector.Value = MySettingsProperty.Settings.PedestrianSetting;
			this.PedestrianLabel.Text = MySettingsProperty.Settings.PedestrianLabelSetting;
			this.CityVehicleSelector.Value = MySettingsProperty.Settings.CityVehicleSetting;
			this.CityVehicleLabel.Text = MySettingsProperty.Settings.CityVehicleLabelSetting;
			this.PickupSelector.Value = MySettingsProperty.Settings.PickupSetting;
			this.PickupLabel.Text = MySettingsProperty.Settings.PickupLabelSetting;
			this.PrimitiveSelector.Value = MySettingsProperty.Settings.PrimitiveSetting;
			this.PrimitiveLabel.Text = MySettingsProperty.Settings.PrimitiveLabelSetting;
			this.UISelector.Value = MySettingsProperty.Settings.UISetting;
			this.UILabel.Text = MySettingsProperty.Settings.UILabelSetting;
			this.VFXSelector.Value = MySettingsProperty.Settings.VFXSetting;
			this.VFXLabel.Text = MySettingsProperty.Settings.VFXLabelSetting;
			this.LSMSelector.Value = MySettingsProperty.Settings.LSMSetting;
			this.LSMLabel.Text = MySettingsProperty.Settings.LSMLabelSetting;
			this.RenderTargetSelector.Value = MySettingsProperty.Settings.RenderTargetSetting;
			this.RenderTargetLabel.Text = MySettingsProperty.Settings.RenderTargetLabelSetting;
			this.SignageSelector.Value = MySettingsProperty.Settings.SignageSetting;
			this.SignageLabel.Text = MySettingsProperty.Settings.SignageLabelSetting;
			this.PlayerGraffitiSelector.Value = MySettingsProperty.Settings.PlayerGraffitiSetting;
			this.PlayerGraffitiLabel.Text = MySettingsProperty.Settings.PlayerGraffitiLabelSetting;
			this.PlayerStatueSelector.Value = MySettingsProperty.Settings.PlayerStatueSetting;
			this.PlayerStatueLabel.Text = MySettingsProperty.Settings.PlayerStatueLabelSetting;
			this.CharacterSharedSelector.Value = MySettingsProperty.Settings.CharacterSharedSetting;
			this.CharacterSharedLabel.Text = MySettingsProperty.Settings.CharacterSharedLabelSetting;
			this.VehicleSharedSelector.Value = MySettingsProperty.Settings.VehicleSharedSetting;
			this.VehicleSharedLabel.Text = MySettingsProperty.Settings.VehicleSharedLabelSetting;
			this.ContactSelector.Value = MySettingsProperty.Settings.ContactSetting;
			this.ContactLabel.Text = MySettingsProperty.Settings.ContactLabelSetting;
			this.ShadowResolutionSelector.Value = MySettingsProperty.Settings.ShadowResolutionSetting;
			this.ShadowResolutionLabel.Text = MySettingsProperty.Settings.ShadowResolutionLabelSetting;
			this.CharacterDNMSelector.Value = MySettingsProperty.Settings.CharacterDNMSetting;
			this.CharacterDNMLabel.Text = MySettingsProperty.Settings.CharacterDNMLabelSetting;
			this.PlayerVehicleSelector.Value = MySettingsProperty.Settings.PlayerVehicleSetting;
			this.PlayerVehicleLabel.Text = MySettingsProperty.Settings.PlayerVehicleLabelSetting;
			this.ParticleLODBiasSelector.Value = MySettingsProperty.Settings.ParticleLODBiasSetting;
			this.ParticleLODBiasLabel.Text = MySettingsProperty.Settings.ParticleLODBiasLabelSetting;
			this.ShadowQualityBiasSelector.Value = MySettingsProperty.Settings.ShadowQualityBiasSetting;
			this.ShadowQualityBiasLabel.Text = MySettingsProperty.Settings.ShadowQualityBiasLabelSetting;
			this.SunRenderQualitySelector.Value = MySettingsProperty.Settings.SunRenderQualitySetting;
			this.SunRenderQualityLabel.Text = MySettingsProperty.Settings.SunRenderQualityLabelSetting;
			this.ParticleSpaceAreaSelector.Value = MySettingsProperty.Settings.ParticleSpaceAreaSeting;
			this.ParticleSpaceAreaLabel.Text = MySettingsProperty.Settings.ParticleSpaceAreaLabelSeting;
			this.FoliageDrawRadiusSelector.Value = MySettingsProperty.Settings.FoliageDrawRadiusSetting;
			this.FoliageDrawRadiusLabel.Text = MySettingsProperty.Settings.FoliageDrawRadiusLabelSetting;
			this.ShadowFilterRadiusSelector.Value = MySettingsProperty.Settings.ShadowFilterRadiusSetting;
			this.ShadowFilterRadiusLabel.Text = MySettingsProperty.Settings.ShadowFilterRadiusSettingLabelSetting;
			this.ShadowDepthBiasSelector.Value = MySettingsProperty.Settings.ShadowDepthBiasSetting;
			this.ShadowDepthBiasLabel.Text = MySettingsProperty.Settings.ShadowDepthBiasLabelSetting;
			this.MaxMemoryCacheEntrySelector.Value = MySettingsProperty.Settings.MaxMemoryCacheEntrySetting;
			this.MaxMemoryCacheEntryLabel.Text = MySettingsProperty.Settings.MaxMemoryCacheEntryLabelSetting;
			this.TextureStreamingMemorySelector.Value = MySettingsProperty.Settings.TextureStreamingMemorySetting;
			this.TextureStreamingMemoryLabel.Text = MySettingsProperty.Settings.TextureStreamingMemoryLabelSetting;
			this.TexturePoolMemorySelector.Value = MySettingsProperty.Settings.TexturePoolMemorySetting;
			this.TexturePoolMemoryLabel.Text = MySettingsProperty.Settings.TexturePoolMemoryLabelSetting;
			this.MeshStreamingMemorySelector.Value = MySettingsProperty.Settings.MeshStreamingMemorySetting;
			this.MeshStreamingMemoryLabel.Text = MySettingsProperty.Settings.MeshStreamingMemoryLabelSetting;
			this.TextureCreationPerFrameBox.Text = MySettingsProperty.Settings.TextureCreationPerFrameSetting;
			this.DynamicShadowsBox.Text = MySettingsProperty.Settings.MaxDynamicShadowsSetting;
			this.ShadowFadeDistanceBox.Text = MySettingsProperty.Settings.ShadowFadeDistanceSetting;
			this.CharacterLODDistance1Box.Text = MySettingsProperty.Settings.CharacterLODDistance1Setting;
			this.CharacterLODDistance2Box.Text = MySettingsProperty.Settings.CharacterLODDistance2Setting;
			this.VehicleLODDistanceBox.Text = MySettingsProperty.Settings.VehicleLODDistanceSetting;
			this.VehicleCullDistanceBox.Text = MySettingsProperty.Settings.VehicleCullDistanceSetting;
			this.PedestrianLODDistanceBox.Text = MySettingsProperty.Settings.PedestrianLODDistanceSetting;
			this.PedestrianCullDistanceBox.Text = MySettingsProperty.Settings.PedestrianCullDistanceSetting;
			this.DriverLODDistanceBox.Text = MySettingsProperty.Settings.DriverLODDistanceSetting;
			this.DriverCullDistanceBox.Text = MySettingsProperty.Settings.DriverCullDistanceSetting;
			this.LCVehicleLODDistanceBox.Text = MySettingsProperty.Settings.LCVehicleLODDistanceSetting;
			this.LCVehicleCullDistanceBox.Text = MySettingsProperty.Settings.LCVehicleCullDistanceSetting;
			this.QualityBar.Value = MySettingsProperty.Settings.QualityBarSetting;
			this.QualityLabel.Text = MySettingsProperty.Settings.QualityLabelSetting;
			this.MouseAccelSelector.Checked = MySettingsProperty.Settings.MouseAccelSetting;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002208 File Offset: 0x00000408
		private void ExitBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000033B2 File Offset: 0x000015B2
		private void Panel1_Click(object sender, EventArgs e)
		{
			this.Panel1.Focus();
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000033C2 File Offset: 0x000015C2
		private void Panel2_Click(object sender, EventArgs e)
		{
			this.Panel2.Focus();
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00017F2C File Offset: 0x0001612C
		private void Button1_Click(object sender, EventArgs e)
		{
			this.InGameBox.Visible = true;
			this.GroupBox2.Visible = false;
			this.GroupBox3.Visible = false;
			this.GroupBox4.Visible = false;
			this.OtherBox.Visible = false;
			this.Button1.FlatAppearance.BorderColor = Color.FromArgb(132, 90, 65);
			this.Button2.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button3.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button4.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button5.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button1.ForeColor = Color.FromArgb(132, 90, 65);
			this.Button2.ForeColor = Color.White;
			this.Button3.ForeColor = Color.White;
			this.Button4.ForeColor = Color.White;
			this.Button5.ForeColor = Color.White;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0001806C File Offset: 0x0001626C
		private void Button2_Click(object sender, EventArgs e)
		{
			this.InGameBox.Visible = false;
			this.GroupBox2.Visible = true;
			this.GroupBox3.Visible = false;
			this.GroupBox4.Visible = false;
			this.OtherBox.Visible = false;
			this.Button1.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button2.FlatAppearance.BorderColor = Color.FromArgb(132, 90, 65);
			this.Button3.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button4.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button5.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button1.ForeColor = Color.White;
			this.Button2.ForeColor = Color.FromArgb(132, 90, 65);
			this.Button3.ForeColor = Color.White;
			this.Button4.ForeColor = Color.White;
			this.Button5.ForeColor = Color.White;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000181AC File Offset: 0x000163AC
		private void Button3_Click(object sender, EventArgs e)
		{
			this.InGameBox.Visible = false;
			this.GroupBox2.Visible = false;
			this.GroupBox3.Visible = true;
			this.GroupBox4.Visible = false;
			this.OtherBox.Visible = false;
			this.Button1.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button2.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button3.FlatAppearance.BorderColor = Color.FromArgb(132, 90, 65);
			this.Button4.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button5.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button1.ForeColor = Color.White;
			this.Button2.ForeColor = Color.White;
			this.Button3.ForeColor = Color.FromArgb(132, 90, 65);
			this.Button4.ForeColor = Color.White;
			this.Button5.ForeColor = Color.White;
			this.Panel1.Focus();
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000182F8 File Offset: 0x000164F8
		private void Button4_Click(object sender, EventArgs e)
		{
			this.InGameBox.Visible = false;
			this.GroupBox2.Visible = false;
			this.GroupBox3.Visible = false;
			this.GroupBox4.Visible = true;
			this.OtherBox.Visible = false;
			this.Button1.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button2.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button3.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button4.FlatAppearance.BorderColor = Color.FromArgb(132, 90, 65);
			this.Button5.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button1.ForeColor = Color.White;
			this.Button2.ForeColor = Color.White;
			this.Button3.ForeColor = Color.White;
			this.Button4.ForeColor = Color.FromArgb(132, 90, 65);
			this.Button5.ForeColor = Color.White;
			this.Panel2.Focus();
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00018444 File Offset: 0x00016644
		private void Button5_Click(object sender, EventArgs e)
		{
			this.InGameBox.Visible = false;
			this.GroupBox2.Visible = false;
			this.GroupBox3.Visible = false;
			this.GroupBox4.Visible = false;
			this.OtherBox.Visible = true;
			this.Button1.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button2.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button3.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button4.FlatAppearance.BorderColor = Color.FromArgb(105, 103, 106);
			this.Button5.FlatAppearance.BorderColor = Color.FromArgb(132, 90, 65);
			this.Button1.ForeColor = Color.White;
			this.Button2.ForeColor = Color.White;
			this.Button3.ForeColor = Color.White;
			this.Button4.ForeColor = Color.White;
			this.Button5.ForeColor = Color.FromArgb(132, 90, 65);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00018584 File Offset: 0x00016784
		private void SaveBtn_Click(object sender, EventArgs e)
		{
			GameLauncher.GetINI(Application.StartupPath + "\\APBGame\\Config\\APBMachineOptions.ini");
			GameLauncher.SaveToINI("SystemSettings", "VideoQuality", "1");
			bool flag = this.ResolutionSelector.SelectedIndex == 1;
			bool flag2;
			if (flag)
			{
				GameLauncher.SaveToINI("SystemSettings", "Resx", "1024");
				GameLauncher.SaveToINI("SystemSettings", "Resy", "768");
			}
			else
			{
				flag = (this.ResolutionSelector.SelectedIndex == 2);
				if (flag)
				{
					GameLauncher.SaveToINI("SystemSettings", "Resx", "1280");
					GameLauncher.SaveToINI("SystemSettings", "Resy", "720");
				}
				else
				{
					flag = (this.ResolutionSelector.SelectedIndex == 3);
					if (flag)
					{
						GameLauncher.SaveToINI("SystemSettings", "Resx", "1280");
						GameLauncher.SaveToINI("SystemSettings", "Resy", "768");
					}
					else
					{
						flag = (this.ResolutionSelector.SelectedIndex == 4);
						if (flag)
						{
							GameLauncher.SaveToINI("SystemSettings", "Resx", "1280");
							GameLauncher.SaveToINI("SystemSettings", "Resy", "800");
						}
						else
						{
							flag = (this.ResolutionSelector.SelectedIndex == 5);
							if (flag)
							{
								GameLauncher.SaveToINI("SystemSettings", "Resx", "1280");
								GameLauncher.SaveToINI("SystemSettings", "Resy", "960");
							}
							else
							{
								flag = (this.ResolutionSelector.SelectedIndex == 6);
								if (flag)
								{
									GameLauncher.SaveToINI("SystemSettings", "Resx", "1280");
									GameLauncher.SaveToINI("SystemSettings", "Resy", "1024");
								}
								else
								{
									flag = (this.ResolutionSelector.SelectedIndex == 7);
									if (flag)
									{
										GameLauncher.SaveToINI("SystemSettings", "Resx", "1360");
										GameLauncher.SaveToINI("SystemSettings", "Resy", "768");
									}
									else
									{
										flag = (this.ResolutionSelector.SelectedIndex == 8);
										if (flag)
										{
											GameLauncher.SaveToINI("SystemSettings", "Resx", "1360");
											GameLauncher.SaveToINI("SystemSettings", "Resy", "1024");
										}
										else
										{
											flag = (this.ResolutionSelector.SelectedIndex == 9);
											if (flag)
											{
												GameLauncher.SaveToINI("SystemSettings", "Resx", "1366");
												GameLauncher.SaveToINI("SystemSettings", "Resy", "768");
											}
											else
											{
												flag = (this.ResolutionSelector.SelectedIndex == 10);
												if (flag)
												{
													GameLauncher.SaveToINI("SystemSettings", "Resx", "1400");
													GameLauncher.SaveToINI("SystemSettings", "Resy", "1050");
												}
												else
												{
													flag = (this.ResolutionSelector.SelectedIndex == 11);
													if (flag)
													{
														GameLauncher.SaveToINI("SystemSettings", "Resx", "1440");
														GameLauncher.SaveToINI("SystemSettings", "Resy", "900");
													}
													else
													{
														flag = (this.ResolutionSelector.SelectedIndex == 12);
														if (flag)
														{
															GameLauncher.SaveToINI("SystemSettings", "Resx", "1600");
															GameLauncher.SaveToINI("SystemSettings", "Resy", "900");
														}
														else
														{
															flag = (this.ResolutionSelector.SelectedIndex == 13);
															if (flag)
															{
																GameLauncher.SaveToINI("SystemSettings", "Resx", "1600");
																GameLauncher.SaveToINI("SystemSettings", "Resy", "1200");
															}
															else
															{
																flag = (this.ResolutionSelector.SelectedIndex == 14);
																if (flag)
																{
																	GameLauncher.SaveToINI("SystemSettings", "Resx", "1680");
																	GameLauncher.SaveToINI("SystemSettings", "Resy", "1050");
																}
																else
																{
																	flag = (this.ResolutionSelector.SelectedIndex == 15);
																	if (flag)
																	{
																		GameLauncher.SaveToINI("SystemSettings", "Resx", "1776");
																		GameLauncher.SaveToINI("SystemSettings", "Resy", "1000");
																	}
																	else
																	{
																		flag = (this.ResolutionSelector.SelectedIndex == 16);
																		if (flag)
																		{
																			GameLauncher.SaveToINI("SystemSettings", "Resx", "1920");
																			GameLauncher.SaveToINI("SystemSettings", "Resy", "1080");
																		}
																		else
																		{
																			flag = (this.ResolutionSelector.SelectedIndex == 17);
																			if (flag)
																			{
																				GameLauncher.SaveToINI("SystemSettings", "Resx", "1920");
																				GameLauncher.SaveToINI("SystemSettings", "Resy", "1200");
																			}
																			else
																			{
																				flag = (this.ResolutionSelector.SelectedIndex == 18);
																				if (flag)
																				{
																					GameLauncher.SaveToINI("SystemSettings", "Resx", "1920");
																					GameLauncher.SaveToINI("SystemSettings", "Resy", "1280");
																				}
																				else
																				{
																					flag = (this.ResolutionSelector.SelectedIndex == 19);
																					if (flag)
																					{
																						GameLauncher.SaveToINI("SystemSettings", "Resx", "2560");
																						GameLauncher.SaveToINI("SystemSettings", "Resy", "1440");
																					}
																					else
																					{
																						flag = (this.ResolutionSelector.SelectedIndex == 20);
																						if (flag)
																						{
																							GameLauncher.SaveToINI("SystemSettings", "Resx", "2560");
																							GameLauncher.SaveToINI("SystemSettings", "Resy", "1600");
																						}
																						else
																						{
																							flag = (this.ResolutionSelector.SelectedIndex == 21);
																							if (flag)
																							{
																								GameLauncher.SaveToINI("SystemSettings", "Resx", "5760");
																								GameLauncher.SaveToINI("SystemSettings", "Resy", "1080");
																							}
																							else
																							{
																								flag = (this.ResolutionSelector.SelectedIndex == 22);
																								if (flag)
																								{
																									GameLauncher.SaveToINI("SystemSettings", "Resx", "5884");
																									GameLauncher.SaveToINI("SystemSettings", "Resy", "1080");
																								}
																								else
																								{
																									flag = (this.ResolutionSelector.SelectedIndex == 23);
																									if (flag)
																									{
																										flag2 = !Versioned.IsNumeric(this.ResX.Text);
																										if (flag2)
																										{
																											this.ResolutionSelector.SelectedIndex = 0;
																										}
																										else
																										{
																											flag2 = !Versioned.IsNumeric(this.ResY.Text);
																											if (flag2)
																											{
																												this.ResolutionSelector.SelectedIndex = 0;
																											}
																											else
																											{
																												GameLauncher.SaveToINI("SystemSettings", "Resx", this.ResX.Text);
																												GameLauncher.SaveToINI("SystemSettings", "Resy", this.ResY.Text);
																											}
																										}
																									}
																									else
																									{
																										this.ResolutionSelector.SelectedIndex = 0;
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.AnisoSelector.SelectedIndex == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("SystemSettings", "AnisotropyAmount", "1");
			}
			else
			{
				flag2 = (this.AnisoSelector.SelectedIndex == 1);
				if (flag2)
				{
					GameLauncher.SaveToINI("SystemSettings", "AnisotropyAmount", "2");
				}
				else
				{
					flag2 = (this.AnisoSelector.SelectedIndex == 2);
					if (flag2)
					{
						GameLauncher.SaveToINI("SystemSettings", "AnisotropyAmount", "4");
					}
					else
					{
						flag2 = (this.AnisoSelector.SelectedIndex == 3);
						if (flag2)
						{
							GameLauncher.SaveToINI("SystemSettings", "AnisotropyAmount", "8");
						}
						else
						{
							GameLauncher.SaveToINI("SystemSettings", "AnisotropyAmount", "16");
						}
					}
				}
			}
			flag2 = (this.EnableFullScreen.SelectedIndex == 1);
			if (flag2)
			{
				GameLauncher.SaveToINI("SystemSettings", "Fullscreen", "0");
			}
			else
			{
				flag2 = (this.EnableFullScreen.SelectedIndex == 2);
				if (flag2)
				{
					GameLauncher.SaveToINI("SystemSettings", "Fullscreen", "1");
				}
				else
				{
					flag2 = (this.EnableFullScreen.SelectedIndex == 3);
					if (flag2)
					{
						GameLauncher.SaveToINI("SystemSettings", "Fullscreen", "2");
					}
					else
					{
						this.EnableFullScreen.SelectedIndex = 0;
					}
				}
			}
			GameLauncher.SaveToINI("SystemSettings", "UseVsync", Conversions.ToString(this.EnableVsync.Checked));
			GameLauncher.SaveToINI("SystemSettings", "SmoothFrameRate", Conversions.ToString(this.EnableSmoothFrameRate.Checked));
			GameLauncher.SaveToINI("SystemSettings", "bAllowStaticDecals", Conversions.ToString(this.EnableStaticDecals.Checked));
			GameLauncher.SaveToINI("SystemSettings", "DynamicShadows", Conversions.ToString(this.EnableDynamicShadows.Checked));
			GameLauncher.SaveToINI("SystemSettings", "LightEnvironmentShadows", Conversions.ToString(this.EnableLEShadows.Checked));
			GameLauncher.SaveToINI("SystemSettings", "EnvironmentShadows", Conversions.ToString(this.EnableLEShadows.Checked));
			GameLauncher.SaveToINI("SystemSettings", "bAllowBlobShadows", Conversions.ToString(this.EnableBlobShadows.Checked));
			GameLauncher.SaveToINI("SystemSettings", "AmbientOcclusion", Conversions.ToString(this.EnableAmbientOcclusion.Checked));
			GameLauncher.SaveToINI("SystemSettings", "Bloom", Conversions.ToString(this.EnableBloom.Checked));
			GameLauncher.SaveToINI("SystemSettings", "Distortion", Conversions.ToString(this.EnableDistortion.Checked));
			GameLauncher.SaveToINI("SystemSettings", "bTrilinearFiltering", Conversions.ToString(this.EnableTrilinear.Checked));
			GameLauncher.SaveToINI("SystemSettings", "bLowQualityHealthHUD", Conversions.ToString(this.EnableLQHealthHUD.Checked));
			GameLauncher.SaveToINI("SystemSettings", "m_bGameRenderEyelashes", Conversions.ToString(this.EnableEyelashes.Checked));
			GameLauncher.GetINI(Application.StartupPath + "\\APBGame\\Config\\APBCompat.ini");
			flag2 = (this.AnisoSelector.SelectedIndex == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("AppCompatBucket1", "MaxAnisotropy", "1");
				GameLauncher.SaveToINI("AppCompatBucket1", "AnisotropyAmount", "1");
			}
			else
			{
				flag2 = (this.AnisoSelector.SelectedIndex == 1);
				if (flag2)
				{
					GameLauncher.SaveToINI("AppCompatBucket1", "MaxAnisotropy", "2");
					GameLauncher.SaveToINI("AppCompatBucket1", "AnisotropyAmount", "2");
				}
				else
				{
					flag2 = (this.AnisoSelector.SelectedIndex == 2);
					if (flag2)
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "MaxAnisotropy", "4");
						GameLauncher.SaveToINI("AppCompatBucket1", "AnisotropyAmount", "4");
					}
					else
					{
						flag2 = (this.AnisoSelector.SelectedIndex == 3);
						if (flag2)
						{
							GameLauncher.SaveToINI("AppCompatBucket1", "MaxAnisotropy", "8");
							GameLauncher.SaveToINI("AppCompatBucket1", "AnisotropyAmount", "8");
						}
						else
						{
							GameLauncher.SaveToINI("AppCompatBucket1", "MaxAnisotropy", "16");
							GameLauncher.SaveToINI("AppCompatBucket1", "AnisotropyAmount", "16");
						}
					}
				}
			}
			GameLauncher.SaveToINI("AppCompatBucket1", "UseVsync", Conversions.ToString(this.EnableVsync.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "SmoothFrameRate", Conversions.ToString(this.EnableSmoothFrameRate.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "StaticDecals", Conversions.ToString(this.EnableStaticDecals.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "DynamicShadows", Conversions.ToString(this.EnableDynamicShadows.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "LightEnvironmentShadows", Conversions.ToString(this.EnableLEShadows.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "EnvironmentShadows", Conversions.ToString(this.EnableLEShadows.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "BlobShadows", Conversions.ToString(this.EnableBlobShadows.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "AmbientOcclusion", Conversions.ToString(this.EnableAmbientOcclusion.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "Bloom", Conversions.ToString(this.EnableBloom.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "Distortion", Conversions.ToString(this.EnableDistortion.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "Trilinear", Conversions.ToString(this.EnableTrilinear.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "LowQualityHealthHUD", Conversions.ToString(this.EnableLQHealthHUD.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "m_bGameRenderEyelashes", Conversions.ToString(this.EnableEyelashes.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "DynamicDecals", Conversions.ToString(this.EnableDynamicDecals.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "LevelParticles", Conversions.ToString(this.EnableLevelParticles.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "DynamicLights", Conversions.ToString(this.EnableDynamicLights.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "CompositeDynamicLights", Conversions.ToString(this.EnableCDLights.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "DirectionalLightmaps", Conversions.ToString(this.EnableDirectionalLightmaps.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "MotionBlur", Conversions.ToString(this.EnableMotionBlur.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "DepthOfField", Conversions.ToString(this.EnableDepthOfField.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "QualityBloom", Conversions.ToString(this.EnableQualityBloom.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "DropParticleDistortion", Conversions.ToString(this.EnableDPDistortion.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "SpeedTreeLeaves", Conversions.ToString(this.EnableSTLeaves.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "SpeedTreeFronds", Conversions.ToString(this.EnableSTFronds.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "OnlyStreamInTextures", Conversions.ToString(this.EnableStreamTextures.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "LensFlares", Conversions.ToString(this.EnableLensFlares.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "FogVolumes", Conversions.ToString(this.EnableFogVolumes.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "FloatingPointRenderTargets", Conversions.ToString(this.EnableFPRTargets.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "OneFrameThreadLag", Conversions.ToString(this.EnableThreadLag.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "UpscaleScreenPercentage", Conversions.ToString(this.EnableUpscaleSP.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "EnableHighPolyChars", Conversions.ToString(this.EnableHighPolyChars.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "bEnableVSMShadows", Conversions.ToString(this.EnableVSMShadows.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "bEnableBranchingPCFShadows", Conversions.ToString(this.EnablePCFShadows.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "bAllowBetterModulatedShadows", Conversions.ToString(this.EnableBetterShadows.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "bEnableForegroundShadowsOnWorld", Conversions.ToString(this.EnableForegroundShadows.Checked));
			GameLauncher.SaveToINI("AppCompatBucket1", "bUseSimplifiedVehicleMaterials", Conversions.ToString(this.EnableSimpleVehicleMaterials.Checked));
			flag2 = (this.ShadowResolutionSelector.Value == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("AppCompatBucket1", "MaxShadowResolution", "128");
			}
			else
			{
				flag2 = (this.ShadowResolutionSelector.Value == 1);
				if (flag2)
				{
					GameLauncher.SaveToINI("AppCompatBucket1", "MaxShadowResolution", "256");
				}
				else
				{
					flag2 = (this.ShadowResolutionSelector.Value == 2);
					if (flag2)
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "MaxShadowResolution", "512");
					}
					else
					{
						flag2 = (this.ShadowResolutionSelector.Value == 3);
						if (flag2)
						{
							GameLauncher.SaveToINI("AppCompatBucket1", "MaxShadowResolution", "1024");
						}
						else
						{
							GameLauncher.SaveToINI("AppCompatBucket1", "MaxShadowResolution", "2048");
						}
					}
				}
			}
			flag2 = (this.CharacterDNMSelector.Value == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseWidth", "1");
				GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseHeight", "1");
				GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapWidth", "1");
				GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapHeight", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseWidth", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseHeight", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapWidth", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapHeight", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseWidth", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseHeight", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapWidth", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapHeight", "1");
			}
			else
			{
				flag2 = (this.CharacterDNMSelector.Value == 1);
				if (flag2)
				{
					GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseWidth", "4");
					GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseHeight", "4");
					GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapWidth", "4");
					GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapHeight", "4");
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseWidth", "4");
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseHeight", "4");
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapWidth", "4");
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapHeight", "4");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseWidth", "4");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseHeight", "4");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapWidth", "4");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapHeight", "4");
				}
				else
				{
					flag2 = (this.CharacterDNMSelector.Value == 2);
					if (flag2)
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseWidth", "8");
						GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseHeight", "8");
						GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapWidth", "8");
						GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapHeight", "8");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseWidth", "8");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseHeight", "8");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapWidth", "8");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapHeight", "8");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseWidth", "8");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseHeight", "8");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapWidth", "8");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapHeight", "8");
					}
					else
					{
						flag2 = (this.CharacterDNMSelector.Value == 3);
						if (flag2)
						{
							GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseWidth", "16");
							GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseHeight", "16");
							GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapWidth", "16");
							GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapHeight", "16");
							GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseWidth", "16");
							GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseHeight", "16");
							GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapWidth", "16");
							GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapHeight", "16");
							GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseWidth", "16");
							GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseHeight", "16");
							GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapWidth", "16");
							GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapHeight", "16");
						}
						else
						{
							flag2 = (this.CharacterDNMSelector.Value == 4);
							if (flag2)
							{
								GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseWidth", "32");
								GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseHeight", "32");
								GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapWidth", "32");
								GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapHeight", "32");
								GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseWidth", "32");
								GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseHeight", "32");
								GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapWidth", "32");
								GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapHeight", "32");
								GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseWidth", "32");
								GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseHeight", "32");
								GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapWidth", "32");
								GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapHeight", "32");
							}
							else
							{
								flag2 = (this.CharacterDNMSelector.Value == 5);
								if (flag2)
								{
									GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseWidth", "64");
									GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseHeight", "64");
									GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapWidth", "64");
									GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapHeight", "64");
									GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseWidth", "64");
									GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseHeight", "64");
									GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapWidth", "64");
									GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapHeight", "64");
									GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseWidth", "64");
									GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseHeight", "64");
									GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapWidth", "64");
									GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapHeight", "64");
								}
								else
								{
									flag2 = (this.CharacterDNMSelector.Value == 6);
									if (flag2)
									{
										GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseWidth", "128");
										GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseHeight", "128");
										GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapWidth", "128");
										GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapHeight", "128");
										GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseWidth", "128");
										GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseHeight", "128");
										GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapWidth", "128");
										GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapHeight", "128");
										GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseWidth", "128");
										GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseHeight", "128");
										GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapWidth", "128");
										GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapHeight", "128");
									}
									else
									{
										flag2 = (this.CharacterDNMSelector.Value == 7);
										if (flag2)
										{
											GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseWidth", "256");
											GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseHeight", "256");
											GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapWidth", "256");
											GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapHeight", "256");
											GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseWidth", "256");
											GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseHeight", "256");
											GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapWidth", "256");
											GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapHeight", "256");
											GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseWidth", "256");
											GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseHeight", "256");
											GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapWidth", "256");
											GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapHeight", "256");
										}
										else
										{
											flag2 = (this.CharacterDNMSelector.Value == 8);
											if (flag2)
											{
												GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseWidth", "512");
												GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseHeight", "512");
												GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapWidth", "512");
												GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapHeight", "512");
												GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseWidth", "512");
												GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseHeight", "512");
												GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapWidth", "512");
												GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapHeight", "512");
												GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseWidth", "512");
												GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseHeight", "512");
												GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapWidth", "512");
												GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapHeight", "512");
											}
											else
											{
												GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseWidth", "1024");
												GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterDiffuseHeight", "1024");
												GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapWidth", "1024");
												GameLauncher.SaveToINI("AppCompatBucket1", "nCharacterNormalMapHeight", "1024");
												GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseWidth", "1024");
												GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterDiffuseHeight", "1024");
												GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapWidth", "1024");
												GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nCharacterNormalMapHeight", "1024");
												GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseWidth", "1024");
												GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterDiffuseHeight", "1024");
												GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapWidth", "1024");
												GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nCharacterNormalMapHeight", "1024");
											}
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.PlayerVehicleSelector.Value == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleExteriorTextureSize", "1");
				GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleExteriorNormalTextureSize", "1");
				GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleExteriorEmissiveTextureSize", "1");
				GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleInteriorTextureSize", "1");
				GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleInteriorEmissiveTextureSize", "1");
				GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleWheelTextureSize", "1");
				GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleWheelEmissiveTextureSize", "1");
				GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleGlassTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleExteriorTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleExteriorNormalTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleExteriorEmissiveTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleInteriorTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleInteriorEmissiveTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleWheelTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleWheelEmissiveTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleGlassTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleExteriorTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleExteriorNormalTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleExteriorEmissiveTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleInteriorTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleInteriorEmissiveTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleWheelTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleWheelEmissiveTextureSize", "1");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleGlassTextureSize", "1");
			}
			else
			{
				flag2 = (this.PlayerVehicleSelector.Value == 1);
				if (flag2)
				{
					GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleExteriorTextureSize", "512");
					GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleExteriorNormalTextureSize", "256");
					GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleExteriorEmissiveTextureSize", "128");
					GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleInteriorTextureSize", "256");
					GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleInteriorEmissiveTextureSize", "128");
					GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleWheelTextureSize", "128");
					GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleWheelEmissiveTextureSize", "64");
					GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleGlassTextureSize", "128");
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleExteriorTextureSize", "512");
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleExteriorNormalTextureSize", "256");
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleExteriorEmissiveTextureSize", "128");
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleInteriorTextureSize", "256");
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleInteriorEmissiveTextureSize", "128");
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleWheelTextureSize", "128");
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleWheelEmissiveTextureSize", "64");
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleGlassTextureSize", "128");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleExteriorTextureSize", "512");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleExteriorNormalTextureSize", "256");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleExteriorEmissiveTextureSize", "128");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleInteriorTextureSize", "256");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleInteriorEmissiveTextureSize", "128");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleWheelTextureSize", "128");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleWheelEmissiveTextureSize", "64");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleGlassTextureSize", "128");
				}
				else
				{
					flag2 = (this.PlayerVehicleSelector.Value == 2);
					if (flag2)
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleExteriorTextureSize", "1024");
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleExteriorNormalTextureSize", "512");
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleExteriorEmissiveTextureSize", "256");
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleInteriorTextureSize", "512");
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleInteriorEmissiveTextureSize", "256");
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleWheelTextureSize", "256");
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleWheelEmissiveTextureSize", "128");
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleGlassTextureSize", "512");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleExteriorTextureSize", "1024");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleExteriorNormalTextureSize", "512");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleExteriorEmissiveTextureSize", "256");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleInteriorTextureSize", "512");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleInteriorEmissiveTextureSize", "256");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleWheelTextureSize", "256");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleWheelEmissiveTextureSize", "128");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleGlassTextureSize", "512");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleExteriorTextureSize", "1024");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleExteriorNormalTextureSize", "512");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleExteriorEmissiveTextureSize", "256");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleInteriorTextureSize", "512");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleInteriorEmissiveTextureSize", "256");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleWheelTextureSize", "256");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleWheelEmissiveTextureSize", "128");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleGlassTextureSize", "512");
					}
					else
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleExteriorTextureSize", "1024");
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleExteriorNormalTextureSize", "1024");
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleExteriorEmissiveTextureSize", "256");
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleInteriorTextureSize", "512");
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleInteriorEmissiveTextureSize", "256");
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleWheelTextureSize", "256");
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleWheelEmissiveTextureSize", "128");
						GameLauncher.SaveToINI("AppCompatBucket1", "nVehicleGlassTextureSize", "512");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleExteriorTextureSize", "1024");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleExteriorNormalTextureSize", "1024");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleExteriorEmissiveTextureSize", "256");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleInteriorTextureSize", "512");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleInteriorEmissiveTextureSize", "256");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleWheelTextureSize", "256");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleWheelEmissiveTextureSize", "128");
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nVehicleGlassTextureSize", "512");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleExteriorTextureSize", "1024");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleExteriorNormalTextureSize", "1024");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleExteriorEmissiveTextureSize", "256");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleInteriorTextureSize", "512");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleInteriorEmissiveTextureSize", "256");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleWheelTextureSize", "256");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleWheelEmissiveTextureSize", "128");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nVehicleGlassTextureSize", "512");
					}
				}
			}
			flag2 = (this.ParticleLODBiasSelector.Value == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("AppCompatBucket1", "ParticleLODBias", "1");
			}
			else
			{
				GameLauncher.SaveToINI("AppCompatBucket1", "ParticleLODBias", "0");
			}
			flag2 = (this.ShadowQualityBiasSelector.Value == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFilterQualityBias", "0");
			}
			else
			{
				GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFilterQualityBias", "1");
			}
			flag2 = (this.SunRenderQualitySelector.Value == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("AppCompatBucket1", "SunRenderQuality", "0");
			}
			else
			{
				flag2 = (this.SunRenderQualitySelector.Value == 1);
				if (flag2)
				{
					GameLauncher.SaveToINI("AppCompatBucket1", "SunRenderQuality", "1");
				}
				else
				{
					GameLauncher.SaveToINI("AppCompatBucket1", "SunRenderQuality", "2");
				}
			}
			flag2 = (this.ParticleSpaceAreaSelector.Value == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "0.1");
			}
			else
			{
				flag2 = (this.ParticleSpaceAreaSelector.Value == 1);
				if (flag2)
				{
					GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "5.0");
				}
				else
				{
					flag2 = (this.ParticleSpaceAreaSelector.Value == 2);
					if (flag2)
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "50.0");
					}
					else
					{
						flag2 = (this.ParticleSpaceAreaSelector.Value == 3);
						if (flag2)
						{
							GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "500.0");
						}
						else
						{
							flag2 = (this.ParticleSpaceAreaSelector.Value == 4);
							if (flag2)
							{
								GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "1250.0");
							}
							else
							{
								flag2 = (this.ParticleSpaceAreaSelector.Value == 5);
								if (flag2)
								{
									GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "2500.0");
								}
								else
								{
									flag2 = (this.ParticleSpaceAreaSelector.Value == 6);
									if (flag2)
									{
										GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "5000.0");
									}
									else
									{
										flag2 = (this.ParticleSpaceAreaSelector.Value == 7);
										if (flag2)
										{
											GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "7812.5");
										}
										else
										{
											flag2 = (this.ParticleSpaceAreaSelector.Value == 8);
											if (flag2)
											{
												GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "12500.0");
											}
											else
											{
												flag2 = (this.ParticleSpaceAreaSelector.Value == 9);
												if (flag2)
												{
													GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "25000.0");
												}
												else
												{
													flag2 = (this.ParticleSpaceAreaSelector.Value == 10);
													if (flag2)
													{
														GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "50000.0");
													}
													else
													{
														flag2 = (this.ParticleSpaceAreaSelector.Value == 11);
														if (flag2)
														{
															GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "125000.0");
														}
														else
														{
															flag2 = (this.ParticleSpaceAreaSelector.Value == 12);
															if (flag2)
															{
																GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "250000.0");
															}
															else
															{
																flag2 = (this.ParticleSpaceAreaSelector.Value == 13);
																if (flag2)
																{
																	GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "500000.0");
																}
																else
																{
																	GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "0.0");
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.FoliageDrawRadiusSelector.Value == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("AppCompatBucket1", "FoliageDrawRadiusMultiplier", "0.000000");
			}
			else
			{
				GameLauncher.SaveToINI("AppCompatBucket1", "FoliageDrawRadiusMultiplier", "1.000000");
			}
			flag2 = (this.ShadowFilterRadiusSelector.Value == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFilterRadius", "1");
			}
			else
			{
				flag2 = (this.ShadowFilterRadiusSelector.Value == 1);
				if (flag2)
				{
					GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFilterRadius", "2");
				}
				else
				{
					GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFilterRadius", "3");
				}
			}
			flag2 = (this.ShadowDepthBiasSelector.Value == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("AppCompatBucket1", "ShadowDepthBias", ".008");
			}
			else
			{
				flag2 = (this.ShadowDepthBiasSelector.Value == 1);
				if (flag2)
				{
					GameLauncher.SaveToINI("AppCompatBucket1", "ShadowDepthBias", ".01");
				}
				else
				{
					flag2 = (this.ShadowDepthBiasSelector.Value == 2);
					if (flag2)
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "ShadowDepthBias", ".012");
					}
					else
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "ShadowDepthBias", ".015");
					}
				}
			}
			flag2 = !Versioned.IsNumeric(this.DynamicShadowsBox.Text);
			if (flag2)
			{
				this.DynamicShadowsBox.Text = Conversions.ToString(10);
				GameLauncher.SaveToINI("AppCompatBucket1", "MaxDynamicShadows", "10");
			}
			else
			{
				flag2 = (Conversions.ToDouble(this.DynamicShadowsBox.Text) >= 35.0);
				if (flag2)
				{
					this.DynamicShadowsBox.Text = Conversions.ToString(35);
					GameLauncher.SaveToINI("AppCompatBucket1", "MaxDynamicShadows", "35");
				}
				else
				{
					GameLauncher.SaveToINI("AppCompatBucket1", "MaxDynamicShadows", this.DynamicShadowsBox.Text);
				}
			}
			flag2 = !Versioned.IsNumeric(this.ShadowFadeDistanceBox.Text);
			if (flag2)
			{
				this.ShadowFadeDistanceBox.Text = Conversions.ToString(65);
				GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFadeEndDistance", "6500");
			}
			else
			{
				flag2 = (Conversions.ToDouble(this.ShadowFadeDistanceBox.Text) <= 24.0);
				if (flag2)
				{
					this.ShadowFadeDistanceBox.Text = Conversions.ToString(25);
					GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFadeEndDistance", "2500");
				}
				else
				{
					flag2 = (Conversions.ToDouble(this.ShadowFadeDistanceBox.Text) >= 101.0);
					if (flag2)
					{
						this.ShadowFadeDistanceBox.Text = Conversions.ToString(100);
						GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFadeEndDistance", "10000");
					}
					else
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFadeEndDistance", Conversions.ToString(Conversion.Val(this.ShadowFadeDistanceBox.Text) * Conversion.Val(100)));
					}
				}
			}
			flag2 = !Versioned.IsNumeric(this.CharacterLODDistance1Box.Text);
			if (flag2)
			{
				this.CharacterLODDistance1Box.Text = Conversions.ToString(5);
				GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance1", "500");
			}
			else
			{
				flag2 = (Conversions.ToDouble(this.CharacterLODDistance1Box.Text) <= 0.0);
				if (flag2)
				{
					this.CharacterLODDistance1Box.Text = Conversions.ToString(1);
					GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance1", "100");
				}
				else
				{
					flag2 = (Conversions.ToDouble(this.CharacterLODDistance1Box.Text) >= 100.0);
					if (flag2)
					{
						this.CharacterLODDistance1Box.Text = Conversions.ToString(99);
						GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance1", "9900");
					}
					else
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance1", Conversions.ToString(Conversion.Val(this.CharacterLODDistance1Box.Text) * Conversion.Val(100)));
					}
				}
			}
			flag2 = !Versioned.IsNumeric(this.CharacterLODDistance2Box.Text);
			if (flag2)
			{
				this.CharacterLODDistance2Box.Text = Conversions.ToString(15);
				GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance2", "1500");
			}
			else
			{
				flag2 = (Conversions.ToDouble(this.CharacterLODDistance2Box.Text) <= 1.0);
				if (flag2)
				{
					this.CharacterLODDistance2Box.Text = Conversions.ToString(2);
					GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance2", "200");
				}
				else
				{
					flag2 = (Conversions.ToDouble(this.CharacterLODDistance2Box.Text) >= 101.0);
					if (flag2)
					{
						this.CharacterLODDistance2Box.Text = Conversions.ToString(100);
						GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance2", "10000");
					}
					else
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance2", Conversions.ToString(Conversion.Val(this.CharacterLODDistance2Box.Text) * Conversion.Val(100)));
					}
				}
			}
			flag2 = !Versioned.IsNumeric(this.VehicleLODDistanceBox.Text);
			if (flag2)
			{
				this.VehicleLODDistanceBox.Text = Conversions.ToString(25);
				GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleLODDistance", "2500");
			}
			else
			{
				flag2 = (Conversions.ToDouble(this.VehicleLODDistanceBox.Text) <= 0.0);
				if (flag2)
				{
					this.VehicleLODDistanceBox.Text = Conversions.ToString(1);
					GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleLODDistance", "100");
				}
				else
				{
					flag2 = (Conversions.ToDouble(this.VehicleLODDistanceBox.Text) >= 100.0);
					if (flag2)
					{
						this.VehicleLODDistanceBox.Text = Conversions.ToString(99);
						GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleLODDistance", "9900");
					}
					else
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleLODDistance", Conversions.ToString(Conversion.Val(this.VehicleLODDistanceBox.Text) * Conversion.Val(100)));
					}
				}
			}
			flag2 = !Versioned.IsNumeric(this.VehicleCullDistanceBox.Text);
			if (flag2)
			{
				this.VehicleCullDistanceBox.Text = Conversions.ToString(100);
				GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleCullDistance", "10000");
			}
			else
			{
				flag2 = (Conversions.ToDouble(this.VehicleCullDistanceBox.Text) <= 1.0);
				if (flag2)
				{
					this.VehicleCullDistanceBox.Text = Conversions.ToString(2);
					GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleCullDistance", "200");
				}
				else
				{
					flag2 = (Conversions.ToDouble(this.VehicleCullDistanceBox.Text) >= 101.0);
					if (flag2)
					{
						this.VehicleCullDistanceBox.Text = Conversions.ToString(100);
						GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleCullDistance", "10000");
					}
					else
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleCullDistance", Conversions.ToString(Conversion.Val(this.VehicleCullDistanceBox.Text) * Conversion.Val(100)));
					}
				}
			}
			flag2 = !Versioned.IsNumeric(this.PedestrianLODDistanceBox.Text);
			if (flag2)
			{
				this.PedestrianLODDistanceBox.Text = Conversions.ToString(3);
				GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianLODDistance", "300");
			}
			else
			{
				flag2 = (Conversions.ToDouble(this.PedestrianLODDistanceBox.Text) <= 0.0);
				if (flag2)
				{
					this.PedestrianLODDistanceBox.Text = Conversions.ToString(1);
					GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianLODDistance", "100");
				}
				else
				{
					flag2 = (Conversions.ToDouble(this.PedestrianLODDistanceBox.Text) >= 100.0);
					if (flag2)
					{
						this.PedestrianLODDistanceBox.Text = Conversions.ToString(99);
						GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianLODDistance", "9900");
					}
					else
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianLODDistance", Conversions.ToString(Conversion.Val(this.PedestrianLODDistanceBox.Text) * Conversion.Val(100)));
					}
				}
			}
			flag2 = !Versioned.IsNumeric(this.PedestrianCullDistanceBox.Text);
			if (flag2)
			{
				this.PedestrianCullDistanceBox.Text = Conversions.ToString(50);
				GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianCullDistance", "5000");
			}
			else
			{
				flag2 = (Conversions.ToDouble(this.PedestrianCullDistanceBox.Text) <= 1.0);
				if (flag2)
				{
					this.PedestrianCullDistanceBox.Text = Conversions.ToString(2);
					GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianCullDistance", "200");
				}
				else
				{
					flag2 = (Conversions.ToDouble(this.PedestrianCullDistanceBox.Text) >= 101.0);
					if (flag2)
					{
						this.PedestrianCullDistanceBox.Text = Conversions.ToString(100);
						GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianCullDistance", "10000");
					}
					else
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianCullDistance", Conversions.ToString(Conversion.Val(this.PedestrianCullDistanceBox.Text) * Conversion.Val(100)));
					}
				}
			}
			flag2 = !Versioned.IsNumeric(this.DriverLODDistanceBox.Text);
			if (flag2)
			{
				this.DriverLODDistanceBox.Text = Conversions.ToString(3);
				GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverLODDistance", "300");
			}
			else
			{
				flag2 = (Conversions.ToDouble(this.DriverLODDistanceBox.Text) <= 0.0);
				if (flag2)
				{
					this.DriverLODDistanceBox.Text = Conversions.ToString(1);
					GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverLODDistance", "100");
				}
				else
				{
					flag2 = (Conversions.ToDouble(this.DriverLODDistanceBox.Text) >= 100.0);
					if (flag2)
					{
						this.DriverLODDistanceBox.Text = Conversions.ToString(99);
						GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverLODDistance", "9900");
					}
					else
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverLODDistance", Conversions.ToString(Conversion.Val(this.DriverLODDistanceBox.Text) * Conversion.Val(100)));
					}
				}
			}
			flag2 = !Versioned.IsNumeric(this.DriverCullDistanceBox.Text);
			if (flag2)
			{
				this.DriverCullDistanceBox.Text = Conversions.ToString(70);
				GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverCullDistance", "7000");
			}
			else
			{
				flag2 = (Conversions.ToDouble(this.DriverCullDistanceBox.Text) <= 1.0);
				if (flag2)
				{
					this.DriverCullDistanceBox.Text = Conversions.ToString(2);
					GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverCullDistance", "200");
				}
				else
				{
					flag2 = (Conversions.ToDouble(this.DriverCullDistanceBox.Text) >= 101.0);
					if (flag2)
					{
						this.DriverCullDistanceBox.Text = Conversions.ToString(100);
						GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverCullDistance", "10000");
					}
					else
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverCullDistance", Conversions.ToString(Conversion.Val(this.DriverCullDistanceBox.Text) * Conversion.Val(100)));
					}
				}
			}
			flag2 = !Versioned.IsNumeric(this.LCVehicleLODDistanceBox.Text);
			if (flag2)
			{
				this.LCVehicleLODDistanceBox.Text = Conversions.ToString(10);
				GameLauncher.SaveToINI("AppCompatBucket1", "fLCVehicleLODDistance", "1000");
			}
			else
			{
				flag2 = (Conversions.ToDouble(this.LCVehicleLODDistanceBox.Text) <= 0.0);
				if (flag2)
				{
					this.LCVehicleLODDistanceBox.Text = Conversions.ToString(1);
					GameLauncher.SaveToINI("AppCompatBucket1", "fLCVehicleLODDistance", "100");
				}
				else
				{
					flag2 = (Conversions.ToDouble(this.LCVehicleLODDistanceBox.Text) >= 100.0);
					if (flag2)
					{
						this.LCVehicleLODDistanceBox.Text = Conversions.ToString(99);
						GameLauncher.SaveToINI("AppCompatBucket1", "fLCVehicleLODDistance", "9900");
					}
					else
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "fLCVehicleLODDistance", Conversions.ToString(Conversion.Val(this.LCVehicleLODDistanceBox.Text) * Conversion.Val(100)));
					}
				}
			}
			flag2 = !Versioned.IsNumeric(this.LCVehicleCullDistanceBox.Text);
			if (flag2)
			{
				this.LCVehicleCullDistanceBox.Text = Conversions.ToString(70);
				GameLauncher.SaveToINI("AppCompatBucket1", "fLCVehicleCullDistance", "7000");
			}
			else
			{
				flag2 = (Conversions.ToDouble(this.LCVehicleCullDistanceBox.Text) <= 1.0);
				if (flag2)
				{
					this.LCVehicleCullDistanceBox.Text = Conversions.ToString(2);
					GameLauncher.SaveToINI("AppCompatBucket1", "fLCVehicleCullDistance", "200");
				}
				else
				{
					flag2 = (Conversions.ToDouble(this.LCVehicleCullDistanceBox.Text) >= 101.0);
					if (flag2)
					{
						this.LCVehicleCullDistanceBox.Text = Conversions.ToString(100);
						GameLauncher.SaveToINI("AppCompatBucket1", "fLCVehicleCullDistance", "10000");
					}
					else
					{
						GameLauncher.SaveToINI("AppCompatBucket1", "fLCVehicleCullDistance", Conversions.ToString(Conversion.Val(this.LCVehicleCullDistanceBox.Text) * Conversion.Val(100)));
					}
				}
			}
			flag2 = (this.MaxMemoryCacheEntrySelector.Value == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("AppCompatBucket1", "nMaxMemoryCacheEntryCount", "100");
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nMaxMemoryCacheEntryCount", "100");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nMaxMemoryCacheEntryCount", "100");
				GameLauncher.SaveToINI("AppHWConstraintsBucket3", "nMaxMemoryCacheEntryCount", "100");
			}
			else
			{
				flag2 = (this.MaxMemoryCacheEntrySelector.Value == 1);
				if (flag2)
				{
					GameLauncher.SaveToINI("AppCompatBucket1", "nMaxMemoryCacheEntryCount", "120");
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nMaxMemoryCacheEntryCount", "120");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nMaxMemoryCacheEntryCount", "120");
					GameLauncher.SaveToINI("AppHWConstraintsBucket3", "nMaxMemoryCacheEntryCount", "120");
				}
				else
				{
					GameLauncher.SaveToINI("AppCompatBucket1", "nMaxMemoryCacheEntryCount", "250");
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nMaxMemoryCacheEntryCount", "250");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nMaxMemoryCacheEntryCount", "250");
					GameLauncher.SaveToINI("AppHWConstraintsBucket3", "nMaxMemoryCacheEntryCount", "250");
				}
			}
			GameLauncher.SaveToINI("AppHWConstraintsBucket1", "bCompressDiffuseLocalPlayerCharacterTextures", Conversions.ToString(this.EnableDXTLocalCharacter.Checked));
			GameLauncher.SaveToINI("AppHWConstraintsBucket1", "bCompressDiffuseLocalPlayerVehicleTextures", Conversions.ToString(this.EnableDXTLocalVehicle.Checked));
			GameLauncher.SaveToINI("AppHWConstraintsBucket1", "bCompressDiffuseOtherPlayerCharacterTextures", Conversions.ToString(this.EnableDXTOtherCharacter.Checked));
			GameLauncher.SaveToINI("AppHWConstraintsBucket1", "bCompressDiffuseOtherPlayerVehicleTextures", Conversions.ToString(this.EnableDXTOtherVehicle.Checked));
			GameLauncher.SaveToINI("AppHWConstraintsBucket1", "bCompressNormalTextures", Conversions.ToString(this.EnableDXTNormal.Checked));
			GameLauncher.SaveToINI("AppHWConstraintsBucket2", "bCompressDiffuseLocalPlayerCharacterTextures", Conversions.ToString(this.EnableDXTLocalCharacter.Checked));
			GameLauncher.SaveToINI("AppHWConstraintsBucket2", "bCompressDiffuseLocalPlayerVehicleTextures", Conversions.ToString(this.EnableDXTLocalVehicle.Checked));
			GameLauncher.SaveToINI("AppHWConstraintsBucket2", "bCompressDiffuseOtherPlayerCharacterTextures", Conversions.ToString(this.EnableDXTOtherCharacter.Checked));
			GameLauncher.SaveToINI("AppHWConstraintsBucket2", "bCompressDiffuseOtherPlayerVehicleTextures", Conversions.ToString(this.EnableDXTOtherVehicle.Checked));
			GameLauncher.SaveToINI("AppHWConstraintsBucket2", "bCompressNormalTextures", Conversions.ToString(this.EnableDXTNormal.Checked));
			GameLauncher.SaveToINI("AppHWConstraintsBucket3", "bCompressDiffuseLocalPlayerCharacterTextures", Conversions.ToString(this.EnableDXTLocalCharacter.Checked));
			GameLauncher.SaveToINI("AppHWConstraintsBucket3", "bCompressDiffuseLocalPlayerVehicleTextures", Conversions.ToString(this.EnableDXTLocalVehicle.Checked));
			GameLauncher.SaveToINI("AppHWConstraintsBucket3", "bCompressDiffuseOtherPlayerCharacterTextures", Conversions.ToString(this.EnableDXTOtherCharacter.Checked));
			GameLauncher.SaveToINI("AppHWConstraintsBucket3", "bCompressDiffuseOtherPlayerVehicleTextures", Conversions.ToString(this.EnableDXTOtherVehicle.Checked));
			GameLauncher.SaveToINI("AppHWConstraintsBucket3", "bCompressNormalTextures", Conversions.ToString(this.EnableDXTNormal.Checked));
			flag2 = (this.TextureStreamingMemorySelector.Value == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTextureStreaming", "52428800");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTextureStreaming", "52428800");
				GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTextureStreaming", "52428800");
			}
			else
			{
				flag2 = (this.TextureStreamingMemorySelector.Value == 1);
				if (flag2)
				{
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTextureStreaming", "104857600");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTextureStreaming", "104857600");
					GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTextureStreaming", "104857600");
				}
				else
				{
					flag2 = (this.TextureStreamingMemorySelector.Value == 2);
					if (flag2)
					{
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTextureStreaming", "125829120");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTextureStreaming", "125829120");
						GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTextureStreaming", "125829120");
					}
					else
					{
						flag2 = (this.TextureStreamingMemorySelector.Value == 3);
						if (flag2)
						{
							GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTextureStreaming", "157286400");
							GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTextureStreaming", "157286400");
							GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTextureStreaming", "157286400");
						}
						else
						{
							flag2 = (this.TextureStreamingMemorySelector.Value == 4);
							if (flag2)
							{
								GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTextureStreaming", "314572800");
								GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTextureStreaming", "314572800");
								GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTextureStreaming", "314572800");
							}
							else
							{
								GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTextureStreaming", "524288000");
								GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTextureStreaming", "524288000");
								GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTextureStreaming", "524288000");
							}
						}
					}
				}
			}
			flag2 = (this.TexturePoolMemorySelector.Value == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTexturePool", "100000000");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTexturePool", "100000000");
				GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTexturePool", "100000000");
			}
			else
			{
				flag2 = (this.TexturePoolMemorySelector.Value == 1);
				if (flag2)
				{
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTexturePool", "150000000");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTexturePool", "150000000");
					GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTexturePool", "150000000");
				}
				else
				{
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTexturePool", "200000000");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTexturePool", "200000000");
					GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTexturePool", "200000000");
				}
			}
			flag2 = (this.MeshStreamingMemorySelector.Value == 0);
			if (flag2)
			{
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByMeshStreaming", "26214400");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByMeshStreaming", "26214400");
				GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByMeshStreaming", "26214400");
			}
			else
			{
				flag2 = (this.MeshStreamingMemorySelector.Value == 1);
				if (flag2)
				{
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByMeshStreaming", "31457280");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByMeshStreaming", "31457280");
					GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByMeshStreaming", "31457280");
				}
				else
				{
					flag2 = (this.MeshStreamingMemorySelector.Value == 2);
					if (flag2)
					{
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByMeshStreaming", "57671680");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByMeshStreaming", "57671680");
						GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByMeshStreaming", "57671680");
					}
					else
					{
						flag2 = (this.MeshStreamingMemorySelector.Value == 3);
						if (flag2)
						{
							GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByMeshStreaming", "89128960");
							GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByMeshStreaming", "89128960");
							GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByMeshStreaming", "89128960");
						}
						else
						{
							flag2 = (this.MeshStreamingMemorySelector.Value == 4);
							if (flag2)
							{
								GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByMeshStreaming", "104857600");
								GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByMeshStreaming", "104857600");
								GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByMeshStreaming", "104857600");
							}
							else
							{
								GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByMeshStreaming", "157286400");
								GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByMeshStreaming", "157286400");
								GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByMeshStreaming", "157286400");
							}
						}
					}
				}
			}
			flag2 = !Versioned.IsNumeric(this.TextureCreationPerFrameBox.Text);
			if (flag2)
			{
				this.TextureCreationPerFrameBox.Text = Conversions.ToString(10);
				GameLauncher.SaveToINI("AppHWConstraintsBucket1", "NumberOfTextureCreationPerFrame", "10");
				GameLauncher.SaveToINI("AppHWConstraintsBucket2", "NumberOfTextureCreationPerFrame", "10");
				GameLauncher.SaveToINI("AppHWConstraintsBucket3", "NumberOfTextureCreationPerFrame", "10");
			}
			else
			{
				flag2 = (Conversions.ToDouble(this.TextureCreationPerFrameBox.Text) <= 1.0);
				if (flag2)
				{
					this.TextureCreationPerFrameBox.Text = Conversions.ToString(2);
					GameLauncher.SaveToINI("AppHWConstraintsBucket1", "NumberOfTextureCreationPerFrame", "2");
					GameLauncher.SaveToINI("AppHWConstraintsBucket2", "NumberOfTextureCreationPerFrame", "2");
					GameLauncher.SaveToINI("AppHWConstraintsBucket3", "NumberOfTextureCreationPerFrame", "2");
				}
				else
				{
					flag2 = (Conversions.ToDouble(this.TextureCreationPerFrameBox.Text) >= 11.0);
					if (flag2)
					{
						this.TextureCreationPerFrameBox.Text = Conversions.ToString(10);
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "NumberOfTextureCreationPerFrame", "10");
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "NumberOfTextureCreationPerFrame", "10");
						GameLauncher.SaveToINI("AppHWConstraintsBucket3", "NumberOfTextureCreationPerFrame", "10");
					}
					else
					{
						GameLauncher.SaveToINI("AppHWConstraintsBucket1", "NumberOfTextureCreationPerFrame", this.TextureCreationPerFrameBox.Text);
						GameLauncher.SaveToINI("AppHWConstraintsBucket2", "NumberOfTextureCreationPerFrame", this.TextureCreationPerFrameBox.Text);
						GameLauncher.SaveToINI("AppHWConstraintsBucket3", "NumberOfTextureCreationPerFrame", this.TextureCreationPerFrameBox.Text);
					}
				}
			}
			string[] array = File.ReadAllLines(Application.StartupPath + "\\APBGame\\Config\\APBCompat.ini");
			flag2 = (this.UnknownSelector.Value == 0);
			if (flag2)
			{
				array[621] = "TEXCAT_Unknown=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
				array[622] = "TEXCAT_Unknown=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
			}
			else
			{
				array[621] = "TEXCAT_Unknown=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
				array[622] = "TEXCAT_Unknown=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
			}
			flag2 = (this.EnvironmentSelector.Value == 0);
			if (flag2)
			{
				array[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
				array[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
				array[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
				array[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
				array[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
				array[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
			}
			else
			{
				flag2 = (this.EnvironmentSelector.Value == 1);
				if (flag2)
				{
					array[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
					array[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
					array[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
					array[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
					array[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
					array[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
				}
				else
				{
					flag2 = (this.EnvironmentSelector.Value == 2);
					if (flag2)
					{
						array[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
						array[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
						array[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
						array[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
						array[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
						array[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
					}
					else
					{
						flag2 = (this.EnvironmentSelector.Value == 3);
						if (flag2)
						{
							array[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
							array[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
							array[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
							array[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
							array[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
							array[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
						}
						else
						{
							flag2 = (this.EnvironmentSelector.Value == 4);
							if (flag2)
							{
								array[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
								array[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
								array[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
								array[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
								array[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
								array[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
							}
							else
							{
								flag2 = (this.EnvironmentSelector.Value == 5);
								if (flag2)
								{
									array[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
									array[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
									array[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
									array[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
									array[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
									array[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
								}
								else
								{
									flag2 = (this.EnvironmentSelector.Value == 6);
									if (flag2)
									{
										array[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
										array[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
										array[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
										array[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
										array[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
										array[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
									}
									else
									{
										flag2 = (this.EnvironmentSelector.Value == 7);
										if (flag2)
										{
											array[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
											array[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
											array[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
											array[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
											array[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
											array[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
										}
										else
										{
											array[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
											array[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
											array[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
											array[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
											array[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
											array[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.PropSelector.Value == 0);
			if (flag2)
			{
				array[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
			}
			else
			{
				flag2 = (this.PropSelector.Value == 1);
				if (flag2)
				{
					array[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
				}
				else
				{
					flag2 = (this.PropSelector.Value == 2);
					if (flag2)
					{
						array[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
					}
					else
					{
						flag2 = (this.PropSelector.Value == 3);
						if (flag2)
						{
							array[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
						}
						else
						{
							flag2 = (this.PropSelector.Value == 4);
							if (flag2)
							{
								array[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
							}
							else
							{
								flag2 = (this.PropSelector.Value == 5);
								if (flag2)
								{
									array[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								}
								else
								{
									flag2 = (this.PropSelector.Value == 6);
									if (flag2)
									{
										array[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									}
									else
									{
										flag2 = (this.PropSelector.Value == 7);
										if (flag2)
										{
											array[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										}
										else
										{
											array[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.CharacterSelector.Value == 0);
			if (flag2)
			{
				array[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=40)";
				array[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=40)";
				array[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=100)";
				array[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=100)";
			}
			else
			{
				flag2 = (this.CharacterSelector.Value == 1);
				if (flag2)
				{
					array[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=40)";
					array[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=40)";
					array[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=100)";
					array[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=100)";
				}
				else
				{
					flag2 = (this.CharacterSelector.Value == 2);
					if (flag2)
					{
						array[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=40)";
						array[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=40)";
						array[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=100)";
						array[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=100)";
					}
					else
					{
						flag2 = (this.CharacterSelector.Value == 3);
						if (flag2)
						{
							array[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=40)";
							array[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=40)";
							array[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=100)";
							array[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=100)";
						}
						else
						{
							flag2 = (this.CharacterSelector.Value == 4);
							if (flag2)
							{
								array[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
								array[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
								array[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
								array[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
							}
							else
							{
								flag2 = (this.CharacterSelector.Value == 5);
								if (flag2)
								{
									array[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
									array[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
									array[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
									array[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
								}
								else
								{
									flag2 = (this.CharacterSelector.Value == 6);
									if (flag2)
									{
										array[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
										array[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
										array[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
										array[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
									}
									else
									{
										flag2 = (this.CharacterSelector.Value == 7);
										if (flag2)
										{
											array[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
											array[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
											array[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
											array[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
										}
										else
										{
											array[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
											array[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
											array[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
											array[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.VehicleSelector.Value == 0);
			if (flag2)
			{
				array[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=35)";
				array[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=35)";
				array[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=100)";
				array[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=100)";
			}
			else
			{
				flag2 = (this.VehicleSelector.Value == 1);
				if (flag2)
				{
					array[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=35)";
					array[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=35)";
					array[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=100)";
					array[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=100)";
				}
				else
				{
					flag2 = (this.VehicleSelector.Value == 2);
					if (flag2)
					{
						array[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=35)";
						array[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=35)";
						array[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=100)";
						array[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=100)";
					}
					else
					{
						flag2 = (this.VehicleSelector.Value == 3);
						if (flag2)
						{
							array[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=35)";
							array[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=35)";
							array[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=100)";
							array[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=100)";
						}
						else
						{
							flag2 = (this.VehicleSelector.Value == 4);
							if (flag2)
							{
								array[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
								array[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
								array[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
								array[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
							}
							else
							{
								flag2 = (this.VehicleSelector.Value == 5);
								if (flag2)
								{
									array[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
									array[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
									array[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
									array[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
								}
								else
								{
									flag2 = (this.VehicleSelector.Value == 6);
									if (flag2)
									{
										array[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
										array[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
										array[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
										array[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
									}
									else
									{
										flag2 = (this.VehicleSelector.Value == 7);
										if (flag2)
										{
											array[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
											array[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
											array[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
											array[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
										}
										else
										{
											array[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
											array[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
											array[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
											array[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.PedestrianSelector.Value == 0);
			if (flag2)
			{
				array[631] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
				array[632] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
				array[1302] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
				array[1303] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
				array[1345] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
				array[1346] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
			}
			else
			{
				flag2 = (this.PedestrianSelector.Value == 1);
				if (flag2)
				{
					array[631] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
					array[632] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
					array[1302] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
					array[1303] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
					array[1345] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
					array[1346] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
				}
				else
				{
					flag2 = (this.PedestrianSelector.Value == 2);
					if (flag2)
					{
						array[631] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
						array[632] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
						array[1302] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
						array[1303] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
						array[1345] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
						array[1346] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
					}
					else
					{
						flag2 = (this.PedestrianSelector.Value == 3);
						if (flag2)
						{
							array[631] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
							array[632] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
							array[1302] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
							array[1303] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
							array[1345] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
							array[1346] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
						}
						else
						{
							flag2 = (this.PedestrianSelector.Value == 4);
							if (flag2)
							{
								array[631] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								array[632] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								array[1302] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								array[1303] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								array[1345] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								array[1346] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
							}
							else
							{
								flag2 = (this.PedestrianSelector.Value == 5);
								if (flag2)
								{
									array[631] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[632] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1302] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1303] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1345] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1346] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								}
								else
								{
									array[631] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[632] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1302] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1303] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1345] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1346] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								}
							}
						}
					}
				}
			}
			flag2 = (this.CityVehicleSelector.Value == 0);
			if (flag2)
			{
				array[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
				array[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
				array[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
				array[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
				array[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
				array[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
			}
			else
			{
				flag2 = (this.CityVehicleSelector.Value == 1);
				if (flag2)
				{
					array[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
					array[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
					array[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
					array[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
					array[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
					array[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
				}
				else
				{
					flag2 = (this.CityVehicleSelector.Value == 2);
					if (flag2)
					{
						array[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
						array[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
						array[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
						array[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
						array[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
						array[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
					}
					else
					{
						flag2 = (this.CityVehicleSelector.Value == 3);
						if (flag2)
						{
							array[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
							array[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
							array[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
							array[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
							array[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
							array[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
						}
						else
						{
							flag2 = (this.CityVehicleSelector.Value == 4);
							if (flag2)
							{
								array[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								array[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								array[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								array[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								array[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								array[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
							}
							else
							{
								flag2 = (this.CityVehicleSelector.Value == 5);
								if (flag2)
								{
									array[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								}
								else
								{
									flag2 = (this.CityVehicleSelector.Value == 6);
									if (flag2)
									{
										array[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
										array[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
										array[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
										array[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
										array[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
										array[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									}
									else
									{
										flag2 = (this.CityVehicleSelector.Value == 7);
										if (flag2)
										{
											array[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
										}
										else
										{
											array[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.PickupSelector.Value == 0);
			if (flag2)
			{
				array[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
			}
			else
			{
				flag2 = (this.PickupSelector.Value == 1);
				if (flag2)
				{
					array[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
				}
				else
				{
					flag2 = (this.PickupSelector.Value == 2);
					if (flag2)
					{
						array[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
					}
					else
					{
						flag2 = (this.PickupSelector.Value == 3);
						if (flag2)
						{
							array[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
						}
						else
						{
							flag2 = (this.PickupSelector.Value == 4);
							if (flag2)
							{
								array[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
							}
							else
							{
								flag2 = (this.PickupSelector.Value == 5);
								if (flag2)
								{
									array[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								}
								else
								{
									flag2 = (this.PickupSelector.Value == 6);
									if (flag2)
									{
										array[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									}
									else
									{
										flag2 = (this.PickupSelector.Value == 7);
										if (flag2)
										{
											array[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										}
										else
										{
											array[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.PrimitiveSelector.Value == 0);
			if (flag2)
			{
				array[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=100)";
				array[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=100)";
			}
			else
			{
				flag2 = (this.PrimitiveSelector.Value == 1);
				if (flag2)
				{
					array[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=100)";
					array[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=100)";
				}
				else
				{
					flag2 = (this.PrimitiveSelector.Value == 2);
					if (flag2)
					{
						array[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=100)";
						array[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=100)";
					}
					else
					{
						flag2 = (this.PrimitiveSelector.Value == 3);
						if (flag2)
						{
							array[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=100)";
							array[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=100)";
						}
						else
						{
							flag2 = (this.PrimitiveSelector.Value == 4);
							if (flag2)
							{
								array[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
								array[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
							}
							else
							{
								flag2 = (this.PrimitiveSelector.Value == 5);
								if (flag2)
								{
									array[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
									array[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
								}
								else
								{
									flag2 = (this.PrimitiveSelector.Value == 6);
									if (flag2)
									{
										array[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
										array[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
									}
									else
									{
										flag2 = (this.PrimitiveSelector.Value == 7);
										if (flag2)
										{
											array[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
											array[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
										}
										else
										{
											array[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
											array[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.UISelector.Value == 0);
			if (flag2)
			{
				array[643] = "TEXCAT_UI=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
				array[644] = "TEXCAT_UI=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
			}
			else
			{
				flag2 = (this.UISelector.Value == 1);
				if (flag2)
				{
					array[643] = "TEXCAT_UI=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
					array[644] = "TEXCAT_UI=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
				}
				else
				{
					array[643] = "TEXCAT_UI=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
					array[644] = "TEXCAT_UI=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
				}
			}
			flag2 = (this.VFXSelector.Value == 0);
			if (flag2)
			{
				array[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
				array[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
			}
			else
			{
				flag2 = (this.VFXSelector.Value == 1);
				if (flag2)
				{
					array[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
					array[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
				}
				else
				{
					flag2 = (this.VFXSelector.Value == 2);
					if (flag2)
					{
						array[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
						array[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
					}
					else
					{
						flag2 = (this.VFXSelector.Value == 3);
						if (flag2)
						{
							array[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
							array[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
						}
						else
						{
							flag2 = (this.VFXSelector.Value == 4);
							if (flag2)
							{
								array[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
								array[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
							}
							else
							{
								flag2 = (this.VFXSelector.Value == 5);
								if (flag2)
								{
									array[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
									array[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
								}
								else
								{
									flag2 = (this.VFXSelector.Value == 6);
									if (flag2)
									{
										array[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
										array[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
									}
									else
									{
										flag2 = (this.VFXSelector.Value == 7);
										if (flag2)
										{
											array[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
											array[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
										}
										else
										{
											array[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
											array[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.LSMSelector.Value == 0);
			if (flag2)
			{
				array[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
			}
			else
			{
				flag2 = (this.LSMSelector.Value == 1);
				if (flag2)
				{
					array[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
				}
				else
				{
					flag2 = (this.LSMSelector.Value == 2);
					if (flag2)
					{
						array[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
					}
					else
					{
						flag2 = (this.LSMSelector.Value == 3);
						if (flag2)
						{
							array[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
						}
						else
						{
							flag2 = (this.LSMSelector.Value == 4);
							if (flag2)
							{
								array[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
							}
							else
							{
								flag2 = (this.LSMSelector.Value == 5);
								if (flag2)
								{
									array[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								}
								else
								{
									flag2 = (this.LSMSelector.Value == 6);
									if (flag2)
									{
										array[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									}
									else
									{
										flag2 = (this.LSMSelector.Value == 7);
										if (flag2)
										{
											array[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										}
										else
										{
											array[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.RenderTargetSelector.Value == 0);
			if (flag2)
			{
				array[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=0)";
				array[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=0)";
			}
			else
			{
				flag2 = (this.RenderTargetSelector.Value == 1);
				if (flag2)
				{
					array[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=0)";
					array[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=0)";
				}
				else
				{
					flag2 = (this.RenderTargetSelector.Value == 2);
					if (flag2)
					{
						array[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=0)";
						array[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=0)";
					}
					else
					{
						flag2 = (this.RenderTargetSelector.Value == 3);
						if (flag2)
						{
							array[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=0)";
							array[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=0)";
						}
						else
						{
							flag2 = (this.RenderTargetSelector.Value == 4);
							if (flag2)
							{
								array[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
								array[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
							}
							else
							{
								flag2 = (this.RenderTargetSelector.Value == 5);
								if (flag2)
								{
									array[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
									array[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
								}
								else
								{
									flag2 = (this.RenderTargetSelector.Value == 6);
									if (flag2)
									{
										array[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
										array[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
									}
									else
									{
										flag2 = (this.RenderTargetSelector.Value == 7);
										if (flag2)
										{
											array[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
											array[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
										}
										else
										{
											array[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
											array[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.SignageSelector.Value == 0);
			if (flag2)
			{
				array[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=50)";
				array[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=50)";
			}
			else
			{
				flag2 = (this.SignageSelector.Value == 1);
				if (flag2)
				{
					array[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=50)";
					array[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=50)";
				}
				else
				{
					flag2 = (this.SignageSelector.Value == 2);
					if (flag2)
					{
						array[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=50)";
						array[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=50)";
					}
					else
					{
						flag2 = (this.SignageSelector.Value == 3);
						if (flag2)
						{
							array[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=50)";
							array[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=50)";
						}
						else
						{
							flag2 = (this.SignageSelector.Value == 4);
							if (flag2)
							{
								array[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
								array[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
							}
							else
							{
								flag2 = (this.SignageSelector.Value == 5);
								if (flag2)
								{
									array[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
									array[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
								}
								else
								{
									flag2 = (this.SignageSelector.Value == 6);
									if (flag2)
									{
										array[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
										array[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
									}
									else
									{
										flag2 = (this.SignageSelector.Value == 7);
										if (flag2)
										{
											array[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
											array[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
										}
										else
										{
											array[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
											array[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.PlayerGraffitiSelector.Value == 0);
			if (flag2)
			{
				array[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=50)";
				array[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=50)";
			}
			else
			{
				flag2 = (this.PlayerGraffitiSelector.Value == 1);
				if (flag2)
				{
					array[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=50)";
					array[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=50)";
				}
				else
				{
					flag2 = (this.PlayerGraffitiSelector.Value == 2);
					if (flag2)
					{
						array[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=50)";
						array[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=50)";
					}
					else
					{
						flag2 = (this.PlayerGraffitiSelector.Value == 3);
						if (flag2)
						{
							array[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=50)";
							array[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=50)";
						}
						else
						{
							flag2 = (this.PlayerGraffitiSelector.Value == 4);
							if (flag2)
							{
								array[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
								array[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
							}
							else
							{
								flag2 = (this.PlayerGraffitiSelector.Value == 5);
								if (flag2)
								{
									array[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
									array[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
								}
								else
								{
									flag2 = (this.PlayerGraffitiSelector.Value == 6);
									if (flag2)
									{
										array[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
										array[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
									}
									else
									{
										flag2 = (this.PlayerGraffitiSelector.Value == 7);
										if (flag2)
										{
											array[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
											array[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
										}
										else
										{
											array[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
											array[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.PlayerStatueSelector.Value == 0);
			if (flag2)
			{
				array[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
			}
			else
			{
				flag2 = (this.PlayerStatueSelector.Value == 1);
				if (flag2)
				{
					array[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
				}
				else
				{
					flag2 = (this.PlayerStatueSelector.Value == 2);
					if (flag2)
					{
						array[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
					}
					else
					{
						flag2 = (this.PlayerStatueSelector.Value == 3);
						if (flag2)
						{
							array[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
						}
						else
						{
							flag2 = (this.PlayerStatueSelector.Value == 4);
							if (flag2)
							{
								array[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
							}
							else
							{
								flag2 = (this.PlayerStatueSelector.Value == 5);
								if (flag2)
								{
									array[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								}
								else
								{
									flag2 = (this.PlayerStatueSelector.Value == 6);
									if (flag2)
									{
										array[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									}
									else
									{
										flag2 = (this.PlayerStatueSelector.Value == 7);
										if (flag2)
										{
											array[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										}
										else
										{
											array[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.CharacterSharedSelector.Value == 0);
			if (flag2)
			{
				array[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
			}
			else
			{
				flag2 = (this.CharacterSharedSelector.Value == 1);
				if (flag2)
				{
					array[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
				}
				else
				{
					flag2 = (this.CharacterSharedSelector.Value == 2);
					if (flag2)
					{
						array[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
					}
					else
					{
						flag2 = (this.CharacterSharedSelector.Value == 3);
						if (flag2)
						{
							array[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
						}
						else
						{
							flag2 = (this.CharacterSharedSelector.Value == 4);
							if (flag2)
							{
								array[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
							}
							else
							{
								flag2 = (this.CharacterSharedSelector.Value == 5);
								if (flag2)
								{
									array[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								}
								else
								{
									flag2 = (this.CharacterSharedSelector.Value == 6);
									if (flag2)
									{
										array[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									}
									else
									{
										flag2 = (this.CharacterSharedSelector.Value == 7);
										if (flag2)
										{
											array[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										}
										else
										{
											array[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.VehicleSharedSelector.Value == 0);
			if (flag2)
			{
				array[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
				array[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
			}
			else
			{
				flag2 = (this.VehicleSharedSelector.Value == 1);
				if (flag2)
				{
					array[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
					array[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
				}
				else
				{
					flag2 = (this.VehicleSharedSelector.Value == 2);
					if (flag2)
					{
						array[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
						array[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
					}
					else
					{
						flag2 = (this.VehicleSharedSelector.Value == 3);
						if (flag2)
						{
							array[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
							array[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
						}
						else
						{
							flag2 = (this.VehicleSharedSelector.Value == 4);
							if (flag2)
							{
								array[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								array[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
							}
							else
							{
								flag2 = (this.VehicleSharedSelector.Value == 5);
								if (flag2)
								{
									array[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									array[1355] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
								}
								else
								{
									flag2 = (this.VehicleSharedSelector.Value == 6);
									if (flag2)
									{
										array[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										array[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
									}
									else
									{
										flag2 = (this.VehicleSharedSelector.Value == 7);
										if (flag2)
										{
											array[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										}
										else
										{
											array[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
											array[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
										}
									}
								}
							}
						}
					}
				}
			}
			flag2 = (this.ContactSelector.Value == 0);
			if (flag2)
			{
				array[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
				array[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
				array[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
				array[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
				array[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
				array[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
			}
			else
			{
				flag2 = (this.ContactSelector.Value == 1);
				if (flag2)
				{
					array[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
					array[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
					array[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
					array[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
					array[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
					array[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
				}
				else
				{
					flag2 = (this.ContactSelector.Value == 2);
					if (flag2)
					{
						array[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
						array[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
						array[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
						array[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
						array[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
						array[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
					}
					else
					{
						flag2 = (this.ContactSelector.Value == 3);
						if (flag2)
						{
							array[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
							array[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
							array[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
							array[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
							array[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
							array[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
						}
						else
						{
							flag2 = (this.ContactSelector.Value == 4);
							if (flag2)
							{
								array[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								array[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								array[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								array[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								array[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								array[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
							}
							else
							{
								flag2 = (this.ContactSelector.Value == 5);
								if (flag2)
								{
									array[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									array[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
								}
								else
								{
									flag2 = (this.ContactSelector.Value == 6);
									if (flag2)
									{
										array[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
										array[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
										array[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
										array[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
										array[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
										array[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
									}
									else
									{
										flag2 = (this.ContactSelector.Value == 7);
										if (flag2)
										{
											array[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
										}
										else
										{
											array[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
											array[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
										}
									}
								}
							}
						}
					}
				}
			}
			File.WriteAllLines(Application.StartupPath + "\\APBGame\\Config\\APBCompat.ini", array);
			MySettingsProperty.Settings.ResolutionSetting = this.ResolutionSelector.Text;
			MySettingsProperty.Settings.ResXSetting = this.ResX.Text;
			MySettingsProperty.Settings.ResYSetting = this.ResY.Text;
			MySettingsProperty.Settings.AnisotropySetting = this.AnisoSelector.Text;
			MySettingsProperty.Settings.FullscreenSetting = this.EnableFullScreen.Text;
			MySettingsProperty.Settings.VsyncSetting = this.EnableVsync.Checked;
			MySettingsProperty.Settings.SmoothFrameRateSetting = this.EnableSmoothFrameRate.Checked;
			MySettingsProperty.Settings.StaticDecalsSetting = this.EnableStaticDecals.Checked;
			MySettingsProperty.Settings.DynamicShadowsSetting = this.EnableDynamicShadows.Checked;
			MySettingsProperty.Settings.LEShadowsSetting = this.EnableLEShadows.Checked;
			MySettingsProperty.Settings.BlobShadowsSetting = this.EnableBlobShadows.Checked;
			MySettingsProperty.Settings.AOSetting = this.EnableAmbientOcclusion.Checked;
			MySettingsProperty.Settings.BloomSetting = this.EnableBloom.Checked;
			MySettingsProperty.Settings.DistortionSetting = this.EnableDistortion.Checked;
			MySettingsProperty.Settings.TrilinearSetting = this.EnableTrilinear.Checked;
			MySettingsProperty.Settings.LQHealthHUDSetting = this.EnableLQHealthHUD.Checked;
			MySettingsProperty.Settings.RenderEyelashesSetting = this.EnableEyelashes.Checked;
			MySettingsProperty.Settings.DynamicDecalsSetting = this.EnableDynamicDecals.Checked;
			MySettingsProperty.Settings.LevelParticleSettings = this.EnableLevelParticles.Checked;
			MySettingsProperty.Settings.DynamicLightsSetting = this.EnableDynamicLights.Checked;
			MySettingsProperty.Settings.CDLightsSetting = this.EnableCDLights.Checked;
			MySettingsProperty.Settings.DirectionalLightmapsSetting = this.EnableDirectionalLightmaps.Checked;
			MySettingsProperty.Settings.MotionBlurSetting = this.EnableMotionBlur.Checked;
			MySettingsProperty.Settings.DepthOfFieldSetting = this.EnableDepthOfField.Checked;
			MySettingsProperty.Settings.QualityBloomSetting = this.EnableQualityBloom.Checked;
			MySettingsProperty.Settings.DPDistortionSetting = this.EnableDPDistortion.Checked;
			MySettingsProperty.Settings.STLeavesSetting = this.EnableSTLeaves.Checked;
			MySettingsProperty.Settings.STFrondsSetting = this.EnableSTFronds.Checked;
			MySettingsProperty.Settings.StreamTexturesSetting = this.EnableStreamTextures.Checked;
			MySettingsProperty.Settings.LensFlaresSetting = this.EnableLensFlares.Checked;
			MySettingsProperty.Settings.FogVolumesSetting = this.EnableFogVolumes.Checked;
			MySettingsProperty.Settings.FPRTargetsSetting = this.EnableFPRTargets.Checked;
			MySettingsProperty.Settings.ThreadLagSetting = this.EnableThreadLag.Checked;
			MySettingsProperty.Settings.UpscaleSPSetting = this.EnableUpscaleSP.Checked;
			MySettingsProperty.Settings.HighPolyCharsSetting = this.EnableHighPolyChars.Checked;
			MySettingsProperty.Settings.VSMShadowsSetting = this.EnableVSMShadows.Checked;
			MySettingsProperty.Settings.PCFShadowsSetting = this.EnablePCFShadows.Checked;
			MySettingsProperty.Settings.BetterShadowsSetting = this.EnableBetterShadows.Checked;
			MySettingsProperty.Settings.ForegroundShadowsSetting = this.EnableForegroundShadows.Checked;
			MySettingsProperty.Settings.SimpleVehicleMaterialsSetting = this.EnableSimpleVehicleMaterials.Checked;
			MySettingsProperty.Settings.DXTLocalCharacterSetting = this.EnableDXTLocalCharacter.Checked;
			MySettingsProperty.Settings.DXTLocalVehicleSetting = this.EnableDXTLocalVehicle.Checked;
			MySettingsProperty.Settings.DXTOtherCharacterSetting = this.EnableDXTOtherCharacter.Checked;
			MySettingsProperty.Settings.DXTOtherVehicleSetting = this.EnableDXTOtherVehicle.Checked;
			MySettingsProperty.Settings.DXTNormalSetting = this.EnableDXTNormal.Checked;
			MySettingsProperty.Settings.UnknownSetting = this.UnknownSelector.Value;
			MySettingsProperty.Settings.UnknownLabelSetting = this.UnknownLabel.Text;
			MySettingsProperty.Settings.EnvironmentSetting = this.EnvironmentSelector.Value;
			MySettingsProperty.Settings.EnvironmentLabelSetting = this.EnvironmentLabel.Text;
			MySettingsProperty.Settings.PropSetting = this.PropSelector.Value;
			MySettingsProperty.Settings.PropLabelSetting = this.PropLabel.Text;
			MySettingsProperty.Settings.CharacterSetting = this.CharacterSelector.Value;
			MySettingsProperty.Settings.CharacterLabelSetting = this.CharacterLabel.Text;
			MySettingsProperty.Settings.VehicleSetting = this.VehicleSelector.Value;
			MySettingsProperty.Settings.VehicleLabelSetting = this.VehicleLabel.Text;
			MySettingsProperty.Settings.PedestrianSetting = this.PedestrianSelector.Value;
			MySettingsProperty.Settings.PedestrianLabelSetting = this.PedestrianLabel.Text;
			MySettingsProperty.Settings.CityVehicleSetting = this.CityVehicleSelector.Value;
			MySettingsProperty.Settings.CityVehicleLabelSetting = this.CityVehicleLabel.Text;
			MySettingsProperty.Settings.PickupSetting = this.PickupSelector.Value;
			MySettingsProperty.Settings.PickupLabelSetting = this.PickupLabel.Text;
			MySettingsProperty.Settings.PrimitiveSetting = this.PrimitiveSelector.Value;
			MySettingsProperty.Settings.PrimitiveLabelSetting = this.PrimitiveLabel.Text;
			MySettingsProperty.Settings.UISetting = this.UISelector.Value;
			MySettingsProperty.Settings.UILabelSetting = this.UILabel.Text;
			MySettingsProperty.Settings.VFXSetting = this.VFXSelector.Value;
			MySettingsProperty.Settings.VFXLabelSetting = this.VFXLabel.Text;
			MySettingsProperty.Settings.LSMSetting = this.LSMSelector.Value;
			MySettingsProperty.Settings.LSMLabelSetting = this.LSMLabel.Text;
			MySettingsProperty.Settings.RenderTargetSetting = this.RenderTargetSelector.Value;
			MySettingsProperty.Settings.RenderTargetLabelSetting = this.RenderTargetLabel.Text;
			MySettingsProperty.Settings.SignageSetting = this.SignageSelector.Value;
			MySettingsProperty.Settings.SignageLabelSetting = this.SignageLabel.Text;
			MySettingsProperty.Settings.PlayerGraffitiSetting = this.PlayerGraffitiSelector.Value;
			MySettingsProperty.Settings.PlayerGraffitiLabelSetting = this.PlayerGraffitiLabel.Text;
			MySettingsProperty.Settings.PlayerStatueSetting = this.PlayerStatueSelector.Value;
			MySettingsProperty.Settings.PlayerStatueLabelSetting = this.PlayerStatueLabel.Text;
			MySettingsProperty.Settings.CharacterSharedSetting = this.CharacterSharedSelector.Value;
			MySettingsProperty.Settings.CharacterSharedLabelSetting = this.CharacterSharedLabel.Text;
			MySettingsProperty.Settings.VehicleSharedSetting = this.VehicleSharedSelector.Value;
			MySettingsProperty.Settings.VehicleSharedLabelSetting = this.VehicleSharedLabel.Text;
			MySettingsProperty.Settings.ContactSetting = this.ContactSelector.Value;
			MySettingsProperty.Settings.ContactLabelSetting = this.ContactLabel.Text;
			MySettingsProperty.Settings.ShadowResolutionSetting = this.ShadowResolutionSelector.Value;
			MySettingsProperty.Settings.ShadowResolutionLabelSetting = this.ShadowResolutionLabel.Text;
			MySettingsProperty.Settings.CharacterDNMSetting = this.CharacterDNMSelector.Value;
			MySettingsProperty.Settings.CharacterDNMLabelSetting = this.CharacterDNMLabel.Text;
			MySettingsProperty.Settings.PlayerVehicleSetting = this.PlayerVehicleSelector.Value;
			MySettingsProperty.Settings.PlayerVehicleLabelSetting = this.PlayerVehicleLabel.Text;
			MySettingsProperty.Settings.ParticleLODBiasSetting = this.ParticleLODBiasSelector.Value;
			MySettingsProperty.Settings.ParticleLODBiasLabelSetting = this.ParticleLODBiasLabel.Text;
			MySettingsProperty.Settings.ShadowQualityBiasSetting = this.ShadowQualityBiasSelector.Value;
			MySettingsProperty.Settings.ShadowQualityBiasLabelSetting = this.ShadowQualityBiasLabel.Text;
			MySettingsProperty.Settings.SunRenderQualitySetting = this.SunRenderQualitySelector.Value;
			MySettingsProperty.Settings.SunRenderQualityLabelSetting = this.SunRenderQualityLabel.Text;
			MySettingsProperty.Settings.ParticleSpaceAreaSeting = this.ParticleSpaceAreaSelector.Value;
			MySettingsProperty.Settings.ParticleSpaceAreaLabelSeting = this.ParticleSpaceAreaLabel.Text;
			MySettingsProperty.Settings.FoliageDrawRadiusSetting = this.FoliageDrawRadiusSelector.Value;
			MySettingsProperty.Settings.FoliageDrawRadiusLabelSetting = this.FoliageDrawRadiusLabel.Text;
			MySettingsProperty.Settings.ShadowFilterRadiusSetting = this.ShadowFilterRadiusSelector.Value;
			MySettingsProperty.Settings.ShadowFilterRadiusSettingLabelSetting = this.ShadowFilterRadiusLabel.Text;
			MySettingsProperty.Settings.ShadowDepthBiasSetting = this.ShadowDepthBiasSelector.Value;
			MySettingsProperty.Settings.ShadowDepthBiasLabelSetting = this.ShadowDepthBiasLabel.Text;
			MySettingsProperty.Settings.MaxMemoryCacheEntrySetting = this.MaxMemoryCacheEntrySelector.Value;
			MySettingsProperty.Settings.MaxMemoryCacheEntryLabelSetting = this.MaxMemoryCacheEntryLabel.Text;
			MySettingsProperty.Settings.TextureStreamingMemorySetting = this.TextureStreamingMemorySelector.Value;
			MySettingsProperty.Settings.TextureStreamingMemoryLabelSetting = this.TextureStreamingMemoryLabel.Text;
			MySettingsProperty.Settings.TexturePoolMemorySetting = this.TexturePoolMemorySelector.Value;
			MySettingsProperty.Settings.TexturePoolMemoryLabelSetting = this.TexturePoolMemoryLabel.Text;
			MySettingsProperty.Settings.MeshStreamingMemorySetting = this.MeshStreamingMemorySelector.Value;
			MySettingsProperty.Settings.MeshStreamingMemoryLabelSetting = this.MeshStreamingMemoryLabel.Text;
			MySettingsProperty.Settings.TextureCreationPerFrameSetting = this.TextureCreationPerFrameBox.Text;
			MySettingsProperty.Settings.MaxDynamicShadowsSetting = this.DynamicShadowsBox.Text;
			MySettingsProperty.Settings.ShadowFadeDistanceSetting = this.ShadowFadeDistanceBox.Text;
			MySettingsProperty.Settings.CharacterLODDistance1Setting = this.CharacterLODDistance1Box.Text;
			MySettingsProperty.Settings.CharacterLODDistance2Setting = this.CharacterLODDistance2Box.Text;
			MySettingsProperty.Settings.VehicleLODDistanceSetting = this.VehicleLODDistanceBox.Text;
			MySettingsProperty.Settings.VehicleCullDistanceSetting = this.VehicleCullDistanceBox.Text;
			MySettingsProperty.Settings.PedestrianLODDistanceSetting = this.PedestrianLODDistanceBox.Text;
			MySettingsProperty.Settings.PedestrianCullDistanceSetting = this.PedestrianCullDistanceBox.Text;
			MySettingsProperty.Settings.DriverLODDistanceSetting = this.DriverLODDistanceBox.Text;
			MySettingsProperty.Settings.DriverCullDistanceSetting = this.DriverCullDistanceBox.Text;
			MySettingsProperty.Settings.LCVehicleLODDistanceSetting = this.LCVehicleLODDistanceBox.Text;
			MySettingsProperty.Settings.LCVehicleCullDistanceSetting = this.LCVehicleCullDistanceBox.Text;
			MySettingsProperty.Settings.QualityBarSetting = this.QualityBar.Value;
			MySettingsProperty.Settings.QualityLabelSetting = this.QualityLabel.Text;
			MySettingsProperty.Settings.MouseAccelSetting = this.MouseAccelSelector.Checked;
			MySettingsProperty.Settings.Save();
			this.Close();
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00002208 File Offset: 0x00000408
		private void CancelBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0001F808 File Offset: 0x0001DA08
		private void UnknownSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.UnknownSelector.Value == 0;
			if (flag)
			{
				this.UnknownLabel.Text = "16 (Default)";
			}
			else
			{
				this.UnknownLabel.Text = "32";
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0001F850 File Offset: 0x0001DA50
		private void EnvironmentSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.EnvironmentSelector.Value == 0;
			if (flag)
			{
				this.EnvironmentLabel.Text = "16";
			}
			else
			{
				flag = (this.EnvironmentSelector.Value == 1);
				if (flag)
				{
					this.EnvironmentLabel.Text = "32";
				}
				else
				{
					flag = (this.EnvironmentSelector.Value == 2);
					if (flag)
					{
						this.EnvironmentLabel.Text = "64 (Default)";
					}
					else
					{
						flag = (this.EnvironmentSelector.Value == 3);
						if (flag)
						{
							this.EnvironmentLabel.Text = "128";
						}
						else
						{
							flag = (this.EnvironmentSelector.Value == 4);
							if (flag)
							{
								this.EnvironmentLabel.Text = "256";
							}
							else
							{
								flag = (this.EnvironmentSelector.Value == 5);
								if (flag)
								{
									this.EnvironmentLabel.Text = "512";
								}
								else
								{
									flag = (this.EnvironmentSelector.Value == 6);
									if (flag)
									{
										this.EnvironmentLabel.Text = "1024";
									}
									else
									{
										flag = (this.EnvironmentSelector.Value == 7);
										if (flag)
										{
											this.EnvironmentLabel.Text = "2048";
										}
										else
										{
											this.EnvironmentLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0001F9AC File Offset: 0x0001DBAC
		private void PropSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.PropSelector.Value == 0;
			if (flag)
			{
				this.PropLabel.Text = "16";
			}
			else
			{
				flag = (this.PropSelector.Value == 1);
				if (flag)
				{
					this.PropLabel.Text = "32";
				}
				else
				{
					flag = (this.PropSelector.Value == 2);
					if (flag)
					{
						this.PropLabel.Text = "64 (Default)";
					}
					else
					{
						flag = (this.PropSelector.Value == 3);
						if (flag)
						{
							this.PropLabel.Text = "128";
						}
						else
						{
							flag = (this.PropSelector.Value == 4);
							if (flag)
							{
								this.PropLabel.Text = "256";
							}
							else
							{
								flag = (this.PropSelector.Value == 5);
								if (flag)
								{
									this.PropLabel.Text = "512";
								}
								else
								{
									flag = (this.PropSelector.Value == 6);
									if (flag)
									{
										this.PropLabel.Text = "1024";
									}
									else
									{
										flag = (this.PropSelector.Value == 7);
										if (flag)
										{
											this.PropLabel.Text = "2048";
										}
										else
										{
											this.PropLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0001FB08 File Offset: 0x0001DD08
		private void CharacterSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.CharacterSelector.Value == 0;
			if (flag)
			{
				this.CharacterLabel.Text = "16";
			}
			else
			{
				flag = (this.CharacterSelector.Value == 1);
				if (flag)
				{
					this.CharacterLabel.Text = "32";
				}
				else
				{
					flag = (this.CharacterSelector.Value == 2);
					if (flag)
					{
						this.CharacterLabel.Text = "64";
					}
					else
					{
						flag = (this.CharacterSelector.Value == 3);
						if (flag)
						{
							this.CharacterLabel.Text = "128";
						}
						else
						{
							flag = (this.CharacterSelector.Value == 4);
							if (flag)
							{
								this.CharacterLabel.Text = "256 (Default)";
							}
							else
							{
								flag = (this.CharacterSelector.Value == 5);
								if (flag)
								{
									this.CharacterLabel.Text = "512";
								}
								else
								{
									flag = (this.CharacterSelector.Value == 6);
									if (flag)
									{
										this.CharacterLabel.Text = "1024";
									}
									else
									{
										flag = (this.CharacterSelector.Value == 7);
										if (flag)
										{
											this.CharacterLabel.Text = "2048";
										}
										else
										{
											this.CharacterLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0001FC64 File Offset: 0x0001DE64
		private void VehicleSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.VehicleSelector.Value == 0;
			if (flag)
			{
				this.VehicleLabel.Text = "16";
			}
			else
			{
				flag = (this.VehicleSelector.Value == 1);
				if (flag)
				{
					this.VehicleLabel.Text = "32";
				}
				else
				{
					flag = (this.VehicleSelector.Value == 2);
					if (flag)
					{
						this.VehicleLabel.Text = "64";
					}
					else
					{
						flag = (this.VehicleSelector.Value == 3);
						if (flag)
						{
							this.VehicleLabel.Text = "128 (Default)";
						}
						else
						{
							flag = (this.VehicleSelector.Value == 4);
							if (flag)
							{
								this.VehicleLabel.Text = "256";
							}
							else
							{
								flag = (this.VehicleSelector.Value == 5);
								if (flag)
								{
									this.VehicleLabel.Text = "512";
								}
								else
								{
									flag = (this.VehicleSelector.Value == 6);
									if (flag)
									{
										this.VehicleLabel.Text = "1024";
									}
									else
									{
										flag = (this.VehicleSelector.Value == 7);
										if (flag)
										{
											this.VehicleLabel.Text = "2048";
										}
										else
										{
											this.VehicleLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0001FDC0 File Offset: 0x0001DFC0
		private void PedestrianSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.PedestrianSelector.Value == 0;
			if (flag)
			{
				this.PedestrianLabel.Text = "16";
			}
			else
			{
				flag = (this.PedestrianSelector.Value == 1);
				if (flag)
				{
					this.PedestrianLabel.Text = "32";
				}
				else
				{
					flag = (this.PedestrianSelector.Value == 2);
					if (flag)
					{
						this.PedestrianLabel.Text = "64";
					}
					else
					{
						flag = (this.PedestrianSelector.Value == 3);
						if (flag)
						{
							this.PedestrianLabel.Text = "128 (Default)";
						}
						else
						{
							flag = (this.PedestrianSelector.Value == 4);
							if (flag)
							{
								this.PedestrianLabel.Text = "256";
							}
							else
							{
								flag = (this.PedestrianSelector.Value == 5);
								if (flag)
								{
									this.PedestrianLabel.Text = "512";
								}
								else
								{
									this.PedestrianLabel.Text = "1024";
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0001FECC File Offset: 0x0001E0CC
		private void CityVehicleSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.CityVehicleSelector.Value == 0;
			if (flag)
			{
				this.CityVehicleLabel.Text = "16";
			}
			else
			{
				flag = (this.CityVehicleSelector.Value == 1);
				if (flag)
				{
					this.CityVehicleLabel.Text = "32";
				}
				else
				{
					flag = (this.CityVehicleSelector.Value == 2);
					if (flag)
					{
						this.CityVehicleLabel.Text = "64";
					}
					else
					{
						flag = (this.CityVehicleSelector.Value == 3);
						if (flag)
						{
							this.CityVehicleLabel.Text = "128 (Default)";
						}
						else
						{
							flag = (this.CityVehicleSelector.Value == 4);
							if (flag)
							{
								this.CityVehicleLabel.Text = "256";
							}
							else
							{
								flag = (this.CityVehicleSelector.Value == 5);
								if (flag)
								{
									this.CityVehicleLabel.Text = "512";
								}
								else
								{
									flag = (this.CityVehicleSelector.Value == 6);
									if (flag)
									{
										this.CityVehicleLabel.Text = "1024";
									}
									else
									{
										flag = (this.CityVehicleSelector.Value == 7);
										if (flag)
										{
											this.CityVehicleLabel.Text = "2048";
										}
										else
										{
											this.CityVehicleLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00020028 File Offset: 0x0001E228
		private void PickupSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.PickupSelector.Value == 0;
			if (flag)
			{
				this.PickupLabel.Text = "16";
			}
			else
			{
				flag = (this.PickupSelector.Value == 1);
				if (flag)
				{
					this.PickupLabel.Text = "32";
				}
				else
				{
					flag = (this.PickupSelector.Value == 2);
					if (flag)
					{
						this.PickupLabel.Text = "64 (Default)";
					}
					else
					{
						flag = (this.PickupSelector.Value == 3);
						if (flag)
						{
							this.PickupLabel.Text = "128";
						}
						else
						{
							flag = (this.PickupSelector.Value == 4);
							if (flag)
							{
								this.PickupLabel.Text = "256";
							}
							else
							{
								flag = (this.PickupSelector.Value == 5);
								if (flag)
								{
									this.PickupLabel.Text = "512";
								}
								else
								{
									flag = (this.PickupSelector.Value == 6);
									if (flag)
									{
										this.PickupLabel.Text = "1024";
									}
									else
									{
										flag = (this.PickupSelector.Value == 7);
										if (flag)
										{
											this.PickupLabel.Text = "2048";
										}
										else
										{
											this.PickupLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00020184 File Offset: 0x0001E384
		private void PrimitiveSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.PrimitiveSelector.Value == 0;
			if (flag)
			{
				this.PrimitiveLabel.Text = "16";
			}
			else
			{
				flag = (this.PrimitiveSelector.Value == 1);
				if (flag)
				{
					this.PrimitiveLabel.Text = "32";
				}
				else
				{
					flag = (this.PrimitiveSelector.Value == 2);
					if (flag)
					{
						this.PrimitiveLabel.Text = "64 (Default)";
					}
					else
					{
						flag = (this.PrimitiveSelector.Value == 3);
						if (flag)
						{
							this.PrimitiveLabel.Text = "128";
						}
						else
						{
							flag = (this.PrimitiveSelector.Value == 4);
							if (flag)
							{
								this.PrimitiveLabel.Text = "256";
							}
							else
							{
								flag = (this.PrimitiveSelector.Value == 5);
								if (flag)
								{
									this.PrimitiveLabel.Text = "512";
								}
								else
								{
									flag = (this.PrimitiveSelector.Value == 6);
									if (flag)
									{
										this.PrimitiveLabel.Text = "1024";
									}
									else
									{
										flag = (this.PrimitiveSelector.Value == 7);
										if (flag)
										{
											this.PrimitiveLabel.Text = "2048";
										}
										else
										{
											this.PrimitiveLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000202E0 File Offset: 0x0001E4E0
		private void UISelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.UISelector.Value == 0;
			if (flag)
			{
				this.UILabel.Text = "1024 (Default)";
			}
			else
			{
				flag = (this.UISelector.Value == 1);
				if (flag)
				{
					this.UILabel.Text = "2048";
				}
				else
				{
					this.UILabel.Text = "4096";
				}
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0002034C File Offset: 0x0001E54C
		private void ShadowResolutionSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.ShadowResolutionSelector.Value == 0;
			if (flag)
			{
				this.ShadowResolutionLabel.Text = "128 (Default)";
			}
			else
			{
				flag = (this.ShadowResolutionSelector.Value == 1);
				if (flag)
				{
					this.ShadowResolutionLabel.Text = "256";
				}
				else
				{
					flag = (this.ShadowResolutionSelector.Value == 2);
					if (flag)
					{
						this.ShadowResolutionLabel.Text = "512";
					}
					else
					{
						flag = (this.ShadowResolutionSelector.Value == 3);
						if (flag)
						{
							this.ShadowResolutionLabel.Text = "1024";
						}
						else
						{
							this.ShadowResolutionLabel.Text = "2048";
						}
					}
				}
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00020408 File Offset: 0x0001E608
		private void VFXSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.VFXSelector.Value == 0;
			if (flag)
			{
				this.VFXLabel.Text = "16";
			}
			else
			{
				flag = (this.VFXSelector.Value == 1);
				if (flag)
				{
					this.VFXLabel.Text = "32 (Default)";
				}
				else
				{
					flag = (this.VFXSelector.Value == 2);
					if (flag)
					{
						this.VFXLabel.Text = "64";
					}
					else
					{
						flag = (this.VFXSelector.Value == 3);
						if (flag)
						{
							this.VFXLabel.Text = "128";
						}
						else
						{
							flag = (this.VFXSelector.Value == 4);
							if (flag)
							{
								this.VFXLabel.Text = "256";
							}
							else
							{
								flag = (this.VFXSelector.Value == 5);
								if (flag)
								{
									this.VFXLabel.Text = "512";
								}
								else
								{
									flag = (this.VFXSelector.Value == 6);
									if (flag)
									{
										this.VFXLabel.Text = "1024";
									}
									else
									{
										flag = (this.VFXSelector.Value == 7);
										if (flag)
										{
											this.VFXLabel.Text = "2048";
										}
										else
										{
											this.VFXLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00020564 File Offset: 0x0001E764
		private void LSMSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.LSMSelector.Value == 0;
			if (flag)
			{
				this.LSMLabel.Text = "16 (Default)";
			}
			else
			{
				flag = (this.LSMSelector.Value == 1);
				if (flag)
				{
					this.LSMLabel.Text = "32";
				}
				else
				{
					flag = (this.LSMSelector.Value == 2);
					if (flag)
					{
						this.LSMLabel.Text = "64";
					}
					else
					{
						flag = (this.LSMSelector.Value == 3);
						if (flag)
						{
							this.LSMLabel.Text = "128";
						}
						else
						{
							flag = (this.LSMSelector.Value == 4);
							if (flag)
							{
								this.LSMLabel.Text = "256";
							}
							else
							{
								flag = (this.LSMSelector.Value == 5);
								if (flag)
								{
									this.LSMLabel.Text = "512";
								}
								else
								{
									flag = (this.LSMSelector.Value == 6);
									if (flag)
									{
										this.LSMLabel.Text = "1024";
									}
									else
									{
										flag = (this.LSMSelector.Value == 7);
										if (flag)
										{
											this.LSMLabel.Text = "2048";
										}
										else
										{
											this.LSMLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000206C0 File Offset: 0x0001E8C0
		private void RenderTargetSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.RenderTargetSelector.Value == 0;
			if (flag)
			{
				this.RenderTargetLabel.Text = "16";
			}
			else
			{
				flag = (this.RenderTargetSelector.Value == 1);
				if (flag)
				{
					this.RenderTargetLabel.Text = "32 (Default)";
				}
				else
				{
					flag = (this.RenderTargetSelector.Value == 2);
					if (flag)
					{
						this.RenderTargetLabel.Text = "64";
					}
					else
					{
						flag = (this.RenderTargetSelector.Value == 3);
						if (flag)
						{
							this.RenderTargetLabel.Text = "128";
						}
						else
						{
							flag = (this.RenderTargetSelector.Value == 4);
							if (flag)
							{
								this.RenderTargetLabel.Text = "256";
							}
							else
							{
								flag = (this.RenderTargetSelector.Value == 5);
								if (flag)
								{
									this.RenderTargetLabel.Text = "512";
								}
								else
								{
									flag = (this.RenderTargetSelector.Value == 6);
									if (flag)
									{
										this.RenderTargetLabel.Text = "1024";
									}
									else
									{
										flag = (this.RenderTargetSelector.Value == 7);
										if (flag)
										{
											this.RenderTargetLabel.Text = "2048";
										}
										else
										{
											this.RenderTargetLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0002081C File Offset: 0x0001EA1C
		private void SignageSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.SignageSelector.Value == 0;
			if (flag)
			{
				this.SignageLabel.Text = "16";
			}
			else
			{
				flag = (this.SignageSelector.Value == 1);
				if (flag)
				{
					this.SignageLabel.Text = "32";
				}
				else
				{
					flag = (this.SignageSelector.Value == 2);
					if (flag)
					{
						this.SignageLabel.Text = "64 (Default)";
					}
					else
					{
						flag = (this.SignageSelector.Value == 3);
						if (flag)
						{
							this.SignageLabel.Text = "128";
						}
						else
						{
							flag = (this.SignageSelector.Value == 4);
							if (flag)
							{
								this.SignageLabel.Text = "256";
							}
							else
							{
								flag = (this.SignageSelector.Value == 5);
								if (flag)
								{
									this.SignageLabel.Text = "512";
								}
								else
								{
									flag = (this.SignageSelector.Value == 6);
									if (flag)
									{
										this.SignageLabel.Text = "1024";
									}
									else
									{
										flag = (this.SignageSelector.Value == 7);
										if (flag)
										{
											this.SignageLabel.Text = "2048";
										}
										else
										{
											this.SignageLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00020978 File Offset: 0x0001EB78
		private void PlayerGraffitiSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.PlayerGraffitiSelector.Value == 0;
			if (flag)
			{
				this.PlayerGraffitiLabel.Text = "16";
			}
			else
			{
				flag = (this.PlayerGraffitiSelector.Value == 1);
				if (flag)
				{
					this.PlayerGraffitiLabel.Text = "32";
				}
				else
				{
					flag = (this.PlayerGraffitiSelector.Value == 2);
					if (flag)
					{
						this.PlayerGraffitiLabel.Text = "64 (Default)";
					}
					else
					{
						flag = (this.PlayerGraffitiSelector.Value == 3);
						if (flag)
						{
							this.PlayerGraffitiLabel.Text = "128";
						}
						else
						{
							flag = (this.PlayerGraffitiSelector.Value == 4);
							if (flag)
							{
								this.PlayerGraffitiLabel.Text = "256";
							}
							else
							{
								flag = (this.PlayerGraffitiSelector.Value == 5);
								if (flag)
								{
									this.PlayerGraffitiLabel.Text = "512";
								}
								else
								{
									flag = (this.PlayerGraffitiSelector.Value == 6);
									if (flag)
									{
										this.PlayerGraffitiLabel.Text = "1024";
									}
									else
									{
										flag = (this.PlayerGraffitiSelector.Value == 7);
										if (flag)
										{
											this.PlayerGraffitiLabel.Text = "2048";
										}
										else
										{
											this.PlayerGraffitiLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00020AD4 File Offset: 0x0001ECD4
		private void PlayerStatueSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.PlayerStatueSelector.Value == 0;
			if (flag)
			{
				this.PlayerStatueLabel.Text = "16 (Default)";
			}
			else
			{
				flag = (this.PlayerStatueSelector.Value == 1);
				if (flag)
				{
					this.PlayerStatueLabel.Text = "32";
				}
				else
				{
					flag = (this.PlayerStatueSelector.Value == 2);
					if (flag)
					{
						this.PlayerStatueLabel.Text = "64";
					}
					else
					{
						flag = (this.PlayerStatueSelector.Value == 3);
						if (flag)
						{
							this.PlayerStatueLabel.Text = "128";
						}
						else
						{
							flag = (this.PlayerStatueSelector.Value == 4);
							if (flag)
							{
								this.PlayerStatueLabel.Text = "256";
							}
							else
							{
								flag = (this.PlayerStatueSelector.Value == 5);
								if (flag)
								{
									this.PlayerStatueLabel.Text = "512";
								}
								else
								{
									flag = (this.PlayerStatueSelector.Value == 6);
									if (flag)
									{
										this.PlayerStatueLabel.Text = "1024";
									}
									else
									{
										flag = (this.PlayerStatueSelector.Value == 7);
										if (flag)
										{
											this.PlayerStatueLabel.Text = "2048";
										}
										else
										{
											this.PlayerStatueLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00020C30 File Offset: 0x0001EE30
		private void CharacterSharedSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.CharacterSharedSelector.Value == 0;
			if (flag)
			{
				this.CharacterSharedLabel.Text = "16";
			}
			else
			{
				flag = (this.CharacterSharedSelector.Value == 1);
				if (flag)
				{
					this.CharacterSharedLabel.Text = "32";
				}
				else
				{
					flag = (this.CharacterSharedSelector.Value == 2);
					if (flag)
					{
						this.CharacterSharedLabel.Text = "64 (Default)";
					}
					else
					{
						flag = (this.CharacterSharedSelector.Value == 3);
						if (flag)
						{
							this.CharacterSharedLabel.Text = "128";
						}
						else
						{
							flag = (this.CharacterSharedSelector.Value == 4);
							if (flag)
							{
								this.CharacterSharedLabel.Text = "256";
							}
							else
							{
								flag = (this.CharacterSharedSelector.Value == 5);
								if (flag)
								{
									this.CharacterSharedLabel.Text = "512";
								}
								else
								{
									flag = (this.CharacterSharedSelector.Value == 6);
									if (flag)
									{
										this.CharacterSharedLabel.Text = "1024";
									}
									else
									{
										flag = (this.CharacterSharedSelector.Value == 7);
										if (flag)
										{
											this.CharacterSharedLabel.Text = "2048";
										}
										else
										{
											this.CharacterSharedLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00020D8C File Offset: 0x0001EF8C
		private void VehicleSharedSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.VehicleSharedSelector.Value == 0;
			if (flag)
			{
				this.VehicleSharedLabel.Text = "16";
			}
			else
			{
				flag = (this.VehicleSharedSelector.Value == 1);
				if (flag)
				{
					this.VehicleSharedLabel.Text = "32";
				}
				else
				{
					flag = (this.VehicleSharedSelector.Value == 2);
					if (flag)
					{
						this.VehicleSharedLabel.Text = "64 (Default)";
					}
					else
					{
						flag = (this.VehicleSharedSelector.Value == 3);
						if (flag)
						{
							this.VehicleSharedLabel.Text = "128";
						}
						else
						{
							flag = (this.VehicleSharedSelector.Value == 4);
							if (flag)
							{
								this.VehicleSharedLabel.Text = "256";
							}
							else
							{
								flag = (this.VehicleSharedSelector.Value == 5);
								if (flag)
								{
									this.VehicleSharedLabel.Text = "512";
								}
								else
								{
									flag = (this.VehicleSharedSelector.Value == 6);
									if (flag)
									{
										this.VehicleSharedLabel.Text = "1024";
									}
									else
									{
										flag = (this.VehicleSharedSelector.Value == 7);
										if (flag)
										{
											this.VehicleSharedLabel.Text = "2048";
										}
										else
										{
											this.VehicleSharedLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00020EE8 File Offset: 0x0001F0E8
		private void ContactSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.ContactSelector.Value == 0;
			if (flag)
			{
				this.ContactLabel.Text = "16";
			}
			else
			{
				flag = (this.ContactSelector.Value == 1);
				if (flag)
				{
					this.ContactLabel.Text = "32";
				}
				else
				{
					flag = (this.ContactSelector.Value == 2);
					if (flag)
					{
						this.ContactLabel.Text = "64";
					}
					else
					{
						flag = (this.ContactSelector.Value == 3);
						if (flag)
						{
							this.ContactLabel.Text = "128";
						}
						else
						{
							flag = (this.ContactSelector.Value == 4);
							if (flag)
							{
								this.ContactLabel.Text = "256 (Default)";
							}
							else
							{
								flag = (this.ContactSelector.Value == 5);
								if (flag)
								{
									this.ContactLabel.Text = "512";
								}
								else
								{
									flag = (this.ContactSelector.Value == 6);
									if (flag)
									{
										this.ContactLabel.Text = "1024";
									}
									else
									{
										flag = (this.ContactSelector.Value == 7);
										if (flag)
										{
											this.ContactLabel.Text = "2048";
										}
										else
										{
											this.ContactLabel.Text = "4096";
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00021044 File Offset: 0x0001F244
		private void CharacterDNMSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.CharacterDNMSelector.Value == 0;
			if (flag)
			{
				this.CharacterDNMLabel.Text = "1";
			}
			else
			{
				flag = (this.CharacterDNMSelector.Value == 1);
				if (flag)
				{
					this.CharacterDNMLabel.Text = "4";
				}
				else
				{
					flag = (this.CharacterDNMSelector.Value == 2);
					if (flag)
					{
						this.CharacterDNMLabel.Text = "8";
					}
					else
					{
						flag = (this.CharacterDNMSelector.Value == 3);
						if (flag)
						{
							this.CharacterDNMLabel.Text = "16";
						}
						else
						{
							flag = (this.CharacterDNMSelector.Value == 4);
							if (flag)
							{
								this.CharacterDNMLabel.Text = "32";
							}
							else
							{
								flag = (this.CharacterDNMSelector.Value == 5);
								if (flag)
								{
									this.CharacterDNMLabel.Text = "64";
								}
								else
								{
									flag = (this.CharacterDNMSelector.Value == 6);
									if (flag)
									{
										this.CharacterDNMLabel.Text = "128";
									}
									else
									{
										flag = (this.CharacterDNMSelector.Value == 7);
										if (flag)
										{
											this.CharacterDNMLabel.Text = "256";
										}
										else
										{
											flag = (this.CharacterDNMSelector.Value == 8);
											if (flag)
											{
												this.CharacterDNMLabel.Text = "512 (Default)";
											}
											else
											{
												this.CharacterDNMLabel.Text = "1024";
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000211C8 File Offset: 0x0001F3C8
		private void PlayerVehicleSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.PlayerVehicleSelector.Value == 0;
			if (flag)
			{
				this.PlayerVehicleLabel.Text = "None";
			}
			else
			{
				flag = (this.PlayerVehicleSelector.Value == 1);
				if (flag)
				{
					this.PlayerVehicleLabel.Text = "Low Quality (Default)";
				}
				else
				{
					flag = (this.PlayerVehicleSelector.Value == 2);
					if (flag)
					{
						this.PlayerVehicleLabel.Text = "High Quality";
					}
					else
					{
						this.PlayerVehicleLabel.Text = "Ultra Quality";
					}
				}
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0002125C File Offset: 0x0001F45C
		private void ParticleLODBiasSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.ParticleLODBiasSelector.Value == 0;
			if (flag)
			{
				this.ParticleLODBiasLabel.Text = "Low Quality (Default)";
			}
			else
			{
				this.ParticleLODBiasLabel.Text = "High Quality";
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x000212A4 File Offset: 0x0001F4A4
		private void ShadowQualityBiasSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.ShadowQualityBiasSelector.Value == 0;
			if (flag)
			{
				this.ShadowQualityBiasLabel.Text = "Low Quality (Default)";
			}
			else
			{
				this.ShadowQualityBiasLabel.Text = "High Quality";
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000212EC File Offset: 0x0001F4EC
		private void SunRenderQualitySelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.SunRenderQualitySelector.Value == 0;
			if (flag)
			{
				this.SunRenderQualityLabel.Text = "Low Quality (Default)";
			}
			else
			{
				flag = (this.SunRenderQualitySelector.Value == 1);
				if (flag)
				{
					this.SunRenderQualityLabel.Text = "Medium Quality";
				}
				else
				{
					this.SunRenderQualityLabel.Text = "High Quality";
				}
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00021358 File Offset: 0x0001F558
		private void ParticleSpaceAreaSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.ParticleSpaceAreaSelector.Value == 0;
			if (flag)
			{
				this.ParticleSpaceAreaLabel.Text = "None";
			}
			else
			{
				flag = (this.ParticleSpaceAreaSelector.Value == 1);
				if (flag)
				{
					this.ParticleSpaceAreaLabel.Text = "5";
				}
				else
				{
					flag = (this.ParticleSpaceAreaSelector.Value == 2);
					if (flag)
					{
						this.ParticleSpaceAreaLabel.Text = "50";
					}
					else
					{
						flag = (this.ParticleSpaceAreaSelector.Value == 3);
						if (flag)
						{
							this.ParticleSpaceAreaLabel.Text = "500";
						}
						else
						{
							flag = (this.ParticleSpaceAreaSelector.Value == 4);
							if (flag)
							{
								this.ParticleSpaceAreaLabel.Text = "1250";
							}
							else
							{
								flag = (this.ParticleSpaceAreaSelector.Value == 5);
								if (flag)
								{
									this.ParticleSpaceAreaLabel.Text = "2500";
								}
								else
								{
									flag = (this.ParticleSpaceAreaSelector.Value == 6);
									if (flag)
									{
										this.ParticleSpaceAreaLabel.Text = "5000";
									}
									else
									{
										flag = (this.ParticleSpaceAreaSelector.Value == 7);
										if (flag)
										{
											this.ParticleSpaceAreaLabel.Text = "7812.5";
										}
										else
										{
											flag = (this.ParticleSpaceAreaSelector.Value == 8);
											if (flag)
											{
												this.ParticleSpaceAreaLabel.Text = "12500";
											}
											else
											{
												flag = (this.ParticleSpaceAreaSelector.Value == 9);
												if (flag)
												{
													this.ParticleSpaceAreaLabel.Text = "25000 (Default)";
												}
												else
												{
													flag = (this.ParticleSpaceAreaSelector.Value == 10);
													if (flag)
													{
														this.ParticleSpaceAreaLabel.Text = "50000";
													}
													else
													{
														flag = (this.ParticleSpaceAreaSelector.Value == 11);
														if (flag)
														{
															this.ParticleSpaceAreaLabel.Text = "125000";
														}
														else
														{
															flag = (this.ParticleSpaceAreaSelector.Value == 12);
															if (flag)
															{
																this.ParticleSpaceAreaLabel.Text = "250000";
															}
															else
															{
																flag = (this.ParticleSpaceAreaSelector.Value == 13);
																if (flag)
																{
																	this.ParticleSpaceAreaLabel.Text = "500000";
																}
																else
																{
																	this.ParticleSpaceAreaLabel.Text = "Infinite";
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x000215A8 File Offset: 0x0001F7A8
		private void FoliageDrawRadiusSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.FoliageDrawRadiusSelector.Value == 0;
			if (flag)
			{
				this.FoliageDrawRadiusLabel.Text = "Low Quality (Default)";
			}
			else
			{
				this.FoliageDrawRadiusLabel.Text = "High Quality";
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000215F0 File Offset: 0x0001F7F0
		private void ShadowFilterRadiusSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.ShadowFilterRadiusSelector.Value == 0;
			if (flag)
			{
				this.ShadowFilterRadiusLabel.Text = "Low Quality (Default)";
			}
			else
			{
				flag = (this.ShadowFilterRadiusSelector.Value == 1);
				if (flag)
				{
					this.ShadowFilterRadiusLabel.Text = "High Quality";
				}
				else
				{
					this.ShadowFilterRadiusLabel.Text = "Ultra Quality";
				}
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0002165C File Offset: 0x0001F85C
		private void ShadowDepthBiasSelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.ShadowDepthBiasSelector.Value == 0;
			if (flag)
			{
				this.ShadowDepthBiasLabel.Text = "Low Quality (Default)";
			}
			else
			{
				flag = (this.ShadowDepthBiasSelector.Value == 1);
				if (flag)
				{
					this.ShadowDepthBiasLabel.Text = "Medium Quality";
				}
				else
				{
					flag = (this.ShadowDepthBiasSelector.Value == 2);
					if (flag)
					{
						this.ShadowDepthBiasLabel.Text = "High Quality";
					}
					else
					{
						this.ShadowDepthBiasLabel.Text = "Ultra Quality";
					}
				}
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x000216F0 File Offset: 0x0001F8F0
		private void MaxMemoryCacheEntrySelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.MaxMemoryCacheEntrySelector.Value == 0;
			if (flag)
			{
				this.MaxMemoryCacheEntryLabel.Text = "Low Quality";
			}
			else
			{
				flag = (this.MaxMemoryCacheEntrySelector.Value == 1);
				if (flag)
				{
					this.MaxMemoryCacheEntryLabel.Text = "Medium Quality (Default)";
				}
				else
				{
					this.MaxMemoryCacheEntryLabel.Text = "High Quality";
				}
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0002175C File Offset: 0x0001F95C
		private void TextureStreamingMemorySelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.TextureStreamingMemorySelector.Value == 0;
			if (flag)
			{
				this.TextureStreamingMemoryLabel.Text = "Minimal Quality";
			}
			else
			{
				flag = (this.TextureStreamingMemorySelector.Value == 1);
				if (flag)
				{
					this.TextureStreamingMemoryLabel.Text = "Low Quality";
				}
				else
				{
					flag = (this.TextureStreamingMemorySelector.Value == 2);
					if (flag)
					{
						this.TextureStreamingMemoryLabel.Text = "Medium Quality";
					}
					else
					{
						flag = (this.TextureStreamingMemorySelector.Value == 3);
						if (flag)
						{
							this.TextureStreamingMemoryLabel.Text = "High Quality";
						}
						else
						{
							flag = (this.TextureStreamingMemorySelector.Value == 4);
							if (flag)
							{
								this.TextureStreamingMemoryLabel.Text = "Maximum Quality (Default)";
							}
							else
							{
								this.TextureStreamingMemoryLabel.Text = "Ultra Quality";
							}
						}
					}
				}
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00021840 File Offset: 0x0001FA40
		private void TexturePoolMemorySelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.TexturePoolMemorySelector.Value == 0;
			if (flag)
			{
				this.TexturePoolMemoryLabel.Text = "Low Quality";
			}
			else
			{
				flag = (this.TexturePoolMemorySelector.Value == 1);
				if (flag)
				{
					this.TexturePoolMemoryLabel.Text = "High Quality (Default)";
				}
				else
				{
					this.TexturePoolMemoryLabel.Text = "Ultra Quality";
				}
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000218AC File Offset: 0x0001FAAC
		private void MeshStreamingMemorySelector_Scroll(object sender, EventArgs e)
		{
			bool flag = this.MeshStreamingMemorySelector.Value == 0;
			if (flag)
			{
				this.MeshStreamingMemoryLabel.Text = "Minimal Quality";
			}
			else
			{
				flag = (this.MeshStreamingMemorySelector.Value == 1);
				if (flag)
				{
					this.MeshStreamingMemoryLabel.Text = "Low Quality";
				}
				else
				{
					flag = (this.MeshStreamingMemorySelector.Value == 2);
					if (flag)
					{
						this.MeshStreamingMemoryLabel.Text = "Medium Quality";
					}
					else
					{
						flag = (this.MeshStreamingMemorySelector.Value == 3);
						if (flag)
						{
							this.MeshStreamingMemoryLabel.Text = "High Quality";
						}
						else
						{
							flag = (this.MeshStreamingMemorySelector.Value == 4);
							if (flag)
							{
								this.MeshStreamingMemoryLabel.Text = "Maximum Quality (Default)";
							}
							else
							{
								this.MeshStreamingMemoryLabel.Text = "Ultra Quality";
							}
						}
					}
				}
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00021990 File Offset: 0x0001FB90
		private void QualityBar_Scroll(object sender, EventArgs e)
		{
			bool flag = this.QualityBar.Value == 0;
			if (flag)
			{
				this.QualityLabel.Text = "Minimal";
				this.AnisoSelector.SelectedIndex = 0;
				this.EnableStaticDecals.Checked = false;
				this.EnableDynamicDecals.Checked = false;
				this.EnableLevelParticles.Checked = false;
				this.EnableDynamicLights.Checked = true;
				this.EnableDynamicShadows.Checked = false;
				this.EnableBlobShadows.Checked = false;
				this.EnableLEShadows.Checked = false;
				this.EnableCDLights.Checked = true;
				this.EnableDirectionalLightmaps.Checked = true;
				this.EnableMotionBlur.Checked = false;
				this.EnableDepthOfField.Checked = false;
				this.EnableAmbientOcclusion.Checked = false;
				this.EnableBloom.Checked = false;
				this.EnableQualityBloom.Checked = false;
				this.EnableDistortion.Checked = false;
				this.EnableDPDistortion.Checked = true;
				this.EnableSTLeaves.Checked = false;
				this.EnableSTFronds.Checked = false;
				this.EnableStreamTextures.Checked = false;
				this.EnableLensFlares.Checked = false;
				this.EnableFogVolumes.Checked = false;
				this.EnableFPRTargets.Checked = true;
				this.EnableTrilinear.Checked = false;
				this.EnableThreadLag.Checked = true;
				this.EnableVsync.Checked = false;
				this.EnableUpscaleSP.Checked = true;
				this.EnableEyelashes.Checked = false;
				this.EnableHighPolyChars.Checked = false;
				this.EnableSmoothFrameRate.Checked = false;
				this.UnknownSelector.Value = 0;
				this.UnknownLabel.Text = "16 (Default)";
				this.EnvironmentSelector.Value = 0;
				this.EnvironmentLabel.Text = "16";
				this.PropSelector.Value = 0;
				this.PropLabel.Text = "16";
				this.CharacterSelector.Value = 0;
				this.CharacterLabel.Text = "16";
				this.VehicleSelector.Value = 0;
				this.VehicleLabel.Text = "16";
				this.PedestrianSelector.Value = 0;
				this.PedestrianLabel.Text = "16";
				this.CityVehicleSelector.Value = 0;
				this.CityVehicleLabel.Text = "16";
				this.PickupSelector.Value = 0;
				this.PickupLabel.Text = "16";
				this.PrimitiveSelector.Value = 0;
				this.PrimitiveLabel.Text = "16";
				this.UISelector.Value = 0;
				this.UILabel.Text = "1024 (Default)";
				this.VFXSelector.Value = 0;
				this.VFXLabel.Text = "16";
				this.LSMSelector.Value = 0;
				this.LSMLabel.Text = "16 (Default)";
				this.RenderTargetSelector.Value = 0;
				this.RenderTargetLabel.Text = "16";
				this.SignageSelector.Value = 0;
				this.SignageLabel.Text = "16";
				this.PlayerGraffitiSelector.Value = 0;
				this.PlayerGraffitiLabel.Text = "16";
				this.PlayerStatueSelector.Value = 0;
				this.PlayerStatueLabel.Text = "16 (Default)";
				this.CharacterSharedSelector.Value = 0;
				this.CharacterSharedLabel.Text = "16";
				this.VehicleSharedSelector.Value = 0;
				this.VehicleSharedLabel.Text = "16";
				this.ContactSelector.Value = 0;
				this.ContactLabel.Text = "16";
				this.EnableVSMShadows.Checked = false;
				this.EnablePCFShadows.Checked = false;
				this.EnableBetterShadows.Checked = false;
				this.EnableForegroundShadows.Checked = false;
				this.EnableLQHealthHUD.Checked = true;
				this.EnableSimpleVehicleMaterials.Checked = true;
				this.CharacterDNMSelector.Value = 0;
				this.CharacterDNMLabel.Text = "1";
				this.PlayerVehicleSelector.Value = 0;
				this.PlayerVehicleLabel.Text = "None";
				this.ShadowResolutionSelector.Value = 0;
				this.ShadowResolutionLabel.Text = "128 (Default)";
				this.ParticleLODBiasSelector.Value = 0;
				this.ParticleLODBiasLabel.Text = "Low Quality (Default)";
				this.ShadowQualityBiasSelector.Value = 0;
				this.ShadowQualityBiasLabel.Text = "Low Quality (Default)";
				this.ShadowFadeDistanceBox.Text = "25";
				this.DynamicShadowsBox.Text = "0";
				this.SunRenderQualitySelector.Value = 0;
				this.SunRenderQualityLabel.Text = "Low Quality (Default)";
				this.ParticleSpaceAreaSelector.Value = 0;
				this.ParticleSpaceAreaLabel.Text = "None";
				this.FoliageDrawRadiusSelector.Value = 0;
				this.FoliageDrawRadiusLabel.Text = "Low Quality (Default)";
				this.ShadowFilterRadiusSelector.Value = 0;
				this.ShadowFilterRadiusLabel.Text = "Low Quality (Default)";
				this.ShadowDepthBiasSelector.Value = 0;
				this.ShadowDepthBiasLabel.Text = "Low Quality (Default)";
				this.CharacterLODDistance1Box.Text = "1";
				this.CharacterLODDistance2Box.Text = "2";
				this.VehicleLODDistanceBox.Text = "1";
				this.VehicleCullDistanceBox.Text = "2";
				this.PedestrianLODDistanceBox.Text = "1";
				this.PedestrianCullDistanceBox.Text = "2";
				this.DriverLODDistanceBox.Text = "1";
				this.DriverCullDistanceBox.Text = "2";
				this.LCVehicleLODDistanceBox.Text = "1";
				this.LCVehicleCullDistanceBox.Text = "2";
				this.MaxMemoryCacheEntrySelector.Value = 0;
				this.MaxMemoryCacheEntryLabel.Text = "Low Quality";
				this.EnableDXTLocalCharacter.Checked = false;
				this.EnableDXTLocalVehicle.Checked = false;
				this.EnableDXTOtherCharacter.Checked = false;
				this.EnableDXTOtherVehicle.Checked = false;
				this.EnableDXTNormal.Checked = false;
				this.TextureStreamingMemorySelector.Value = 0;
				this.TextureStreamingMemoryLabel.Text = "Minimal Quality";
				this.TexturePoolMemorySelector.Value = 0;
				this.TexturePoolMemoryLabel.Text = "Low Quality";
				this.MeshStreamingMemorySelector.Value = 0;
				this.MeshStreamingMemoryLabel.Text = "Minimal Quality";
				this.TextureCreationPerFrameBox.Text = "2";
			}
			else
			{
				flag = (this.QualityBar.Value == 1);
				if (flag)
				{
					this.QualityLabel.Text = "Default";
					this.AnisoSelector.SelectedIndex = 0;
					this.EnableStaticDecals.Checked = true;
					this.EnableDynamicDecals.Checked = false;
					this.EnableLevelParticles.Checked = false;
					this.EnableDynamicLights.Checked = true;
					this.EnableDynamicShadows.Checked = false;
					this.EnableBlobShadows.Checked = false;
					this.EnableLEShadows.Checked = false;
					this.EnableCDLights.Checked = false;
					this.EnableDirectionalLightmaps.Checked = true;
					this.EnableMotionBlur.Checked = false;
					this.EnableDepthOfField.Checked = false;
					this.EnableAmbientOcclusion.Checked = false;
					this.EnableBloom.Checked = false;
					this.EnableQualityBloom.Checked = false;
					this.EnableDistortion.Checked = false;
					this.EnableDPDistortion.Checked = false;
					this.EnableSTLeaves.Checked = false;
					this.EnableSTFronds.Checked = false;
					this.EnableStreamTextures.Checked = false;
					this.EnableLensFlares.Checked = false;
					this.EnableFogVolumes.Checked = false;
					this.EnableFPRTargets.Checked = true;
					this.EnableTrilinear.Checked = false;
					this.EnableThreadLag.Checked = true;
					this.EnableVsync.Checked = false;
					this.EnableUpscaleSP.Checked = true;
					this.EnableEyelashes.Checked = false;
					this.EnableHighPolyChars.Checked = false;
					this.EnableSmoothFrameRate.Checked = true;
					this.UnknownSelector.Value = 0;
					this.UnknownLabel.Text = "16 (Default)";
					this.EnvironmentSelector.Value = 2;
					this.EnvironmentLabel.Text = "64 (Default)";
					this.PropSelector.Value = 2;
					this.PropLabel.Text = "64 (Default)";
					this.CharacterSelector.Value = 4;
					this.CharacterLabel.Text = "256 (Default)";
					this.VehicleSelector.Value = 3;
					this.VehicleLabel.Text = "128 (Default)";
					this.PedestrianSelector.Value = 3;
					this.PedestrianLabel.Text = "128 (Default)";
					this.CityVehicleSelector.Value = 3;
					this.CityVehicleLabel.Text = "128 (Default)";
					this.PickupSelector.Value = 2;
					this.PickupLabel.Text = "64 (Default)";
					this.PrimitiveSelector.Value = 2;
					this.PrimitiveLabel.Text = "64 (Default)";
					this.UISelector.Value = 0;
					this.UILabel.Text = "1024 (Default)";
					this.VFXSelector.Value = 1;
					this.VFXLabel.Text = "32 (Default)";
					this.LSMSelector.Value = 0;
					this.LSMLabel.Text = "16 (Default)";
					this.RenderTargetSelector.Value = 1;
					this.RenderTargetLabel.Text = "32 (Default)";
					this.SignageSelector.Value = 2;
					this.SignageLabel.Text = "64 (Default)";
					this.PlayerGraffitiSelector.Value = 2;
					this.PlayerGraffitiLabel.Text = "64 (Default)";
					this.PlayerStatueSelector.Value = 0;
					this.PlayerStatueLabel.Text = "16 (Default)";
					this.CharacterSharedSelector.Value = 2;
					this.CharacterSharedLabel.Text = "64 (Default)";
					this.VehicleSharedSelector.Value = 2;
					this.VehicleSharedLabel.Text = "64 (Default)";
					this.ContactSelector.Value = 4;
					this.ContactLabel.Text = "256 (Default)";
					this.EnableVSMShadows.Checked = false;
					this.EnablePCFShadows.Checked = false;
					this.EnableBetterShadows.Checked = false;
					this.EnableForegroundShadows.Checked = false;
					this.EnableLQHealthHUD.Checked = true;
					this.EnableSimpleVehicleMaterials.Checked = true;
					this.CharacterDNMSelector.Value = 8;
					this.CharacterDNMLabel.Text = "512 (Default)";
					this.PlayerVehicleSelector.Value = 1;
					this.PlayerVehicleLabel.Text = "Low Quality (Default)";
					this.ShadowResolutionSelector.Value = 0;
					this.ShadowResolutionLabel.Text = "128 (Default)";
					this.ParticleLODBiasSelector.Value = 0;
					this.ParticleLODBiasLabel.Text = "Low Quality (Default)";
					this.ShadowQualityBiasSelector.Value = 0;
					this.ShadowQualityBiasLabel.Text = "Low Quality (Default)";
					this.ShadowFadeDistanceBox.Text = "65";
					this.DynamicShadowsBox.Text = "10";
					this.SunRenderQualitySelector.Value = 0;
					this.SunRenderQualityLabel.Text = "Low Quality (Default)";
					this.ParticleSpaceAreaSelector.Value = 9;
					this.ParticleSpaceAreaLabel.Text = "25000";
					this.FoliageDrawRadiusSelector.Value = 0;
					this.FoliageDrawRadiusLabel.Text = "Low Quality (Default)";
					this.ShadowFilterRadiusSelector.Value = 0;
					this.ShadowFilterRadiusLabel.Text = "Low Quality (Default)";
					this.ShadowDepthBiasSelector.Value = 0;
					this.ShadowDepthBiasLabel.Text = "Low Quality (Default)";
					this.CharacterLODDistance1Box.Text = "5";
					this.CharacterLODDistance2Box.Text = "15";
					this.VehicleLODDistanceBox.Text = "25";
					this.VehicleCullDistanceBox.Text = "100";
					this.PedestrianLODDistanceBox.Text = "3";
					this.PedestrianCullDistanceBox.Text = "50";
					this.DriverLODDistanceBox.Text = "3";
					this.DriverCullDistanceBox.Text = "70";
					this.LCVehicleLODDistanceBox.Text = "10";
					this.LCVehicleCullDistanceBox.Text = "70";
					this.MaxMemoryCacheEntrySelector.Value = 1;
					this.MaxMemoryCacheEntryLabel.Text = "Medium Quality (Default)";
					this.EnableDXTLocalCharacter.Checked = false;
					this.EnableDXTLocalVehicle.Checked = false;
					this.EnableDXTOtherCharacter.Checked = false;
					this.EnableDXTOtherVehicle.Checked = false;
					this.EnableDXTNormal.Checked = true;
					this.TextureStreamingMemorySelector.Value = 4;
					this.TextureStreamingMemoryLabel.Text = "Maximum Quality (Default)";
					this.TexturePoolMemorySelector.Value = 1;
					this.TexturePoolMemoryLabel.Text = "High Quality (Default)";
					this.MeshStreamingMemorySelector.Value = 4;
					this.MeshStreamingMemoryLabel.Text = "Maximum Quality (Default)";
					this.TextureCreationPerFrameBox.Text = "10";
				}
				else
				{
					flag = (this.QualityBar.Value == 2);
					if (flag)
					{
						this.QualityLabel.Text = "Low Quality No Shadows";
						this.AnisoSelector.SelectedIndex = 0;
						this.EnableStaticDecals.Checked = false;
						this.EnableDynamicDecals.Checked = false;
						this.EnableLevelParticles.Checked = false;
						this.EnableDynamicLights.Checked = true;
						this.EnableDynamicShadows.Checked = false;
						this.EnableBlobShadows.Checked = false;
						this.EnableLEShadows.Checked = false;
						this.EnableCDLights.Checked = true;
						this.EnableDirectionalLightmaps.Checked = true;
						this.EnableMotionBlur.Checked = false;
						this.EnableDepthOfField.Checked = false;
						this.EnableAmbientOcclusion.Checked = false;
						this.EnableBloom.Checked = true;
						this.EnableQualityBloom.Checked = false;
						this.EnableDistortion.Checked = false;
						this.EnableDPDistortion.Checked = true;
						this.EnableSTLeaves.Checked = false;
						this.EnableSTFronds.Checked = false;
						this.EnableStreamTextures.Checked = false;
						this.EnableLensFlares.Checked = false;
						this.EnableFogVolumes.Checked = false;
						this.EnableFPRTargets.Checked = true;
						this.EnableTrilinear.Checked = false;
						this.EnableThreadLag.Checked = true;
						this.EnableVsync.Checked = false;
						this.EnableUpscaleSP.Checked = true;
						this.EnableEyelashes.Checked = false;
						this.EnableHighPolyChars.Checked = false;
						this.EnableSmoothFrameRate.Checked = false;
						this.UnknownSelector.Value = 0;
						this.UnknownLabel.Text = "16 (Default)";
						this.EnvironmentSelector.Value = 0;
						this.EnvironmentLabel.Text = "16";
						this.PropSelector.Value = 3;
						this.PropLabel.Text = "128";
						this.CharacterSelector.Value = 3;
						this.CharacterLabel.Text = "128";
						this.VehicleSelector.Value = 5;
						this.VehicleLabel.Text = "512";
						this.PedestrianSelector.Value = 3;
						this.PedestrianLabel.Text = "128 (Default)";
						this.CityVehicleSelector.Value = 4;
						this.CityVehicleLabel.Text = "256";
						this.PickupSelector.Value = 1;
						this.PickupLabel.Text = "32";
						this.PrimitiveSelector.Value = 0;
						this.PrimitiveLabel.Text = "16";
						this.UISelector.Value = 0;
						this.UILabel.Text = "1024 (Default)";
						this.VFXSelector.Value = 2;
						this.VFXLabel.Text = "64";
						this.LSMSelector.Value = 3;
						this.LSMLabel.Text = "128";
						this.RenderTargetSelector.Value = 0;
						this.RenderTargetLabel.Text = "16";
						this.SignageSelector.Value = 2;
						this.SignageLabel.Text = "64 (Default)";
						this.PlayerGraffitiSelector.Value = 3;
						this.PlayerGraffitiLabel.Text = "128";
						this.PlayerStatueSelector.Value = 0;
						this.PlayerStatueLabel.Text = "16 (Default)";
						this.CharacterSharedSelector.Value = 0;
						this.CharacterSharedLabel.Text = "16";
						this.VehicleSharedSelector.Value = 0;
						this.VehicleSharedLabel.Text = "16";
						this.ContactSelector.Value = 3;
						this.ContactLabel.Text = "128";
						this.EnableVSMShadows.Checked = false;
						this.EnablePCFShadows.Checked = false;
						this.EnableBetterShadows.Checked = false;
						this.EnableForegroundShadows.Checked = false;
						this.EnableLQHealthHUD.Checked = true;
						this.EnableSimpleVehicleMaterials.Checked = true;
						this.CharacterDNMSelector.Value = 7;
						this.CharacterDNMLabel.Text = "256";
						this.PlayerVehicleSelector.Value = 1;
						this.PlayerVehicleLabel.Text = "Low Quality (Default)";
						this.ShadowResolutionSelector.Value = 0;
						this.ShadowResolutionLabel.Text = "128 (Default)";
						this.ParticleLODBiasSelector.Value = 0;
						this.ParticleLODBiasLabel.Text = "Low Quality (Default)";
						this.ShadowQualityBiasSelector.Value = 0;
						this.ShadowQualityBiasLabel.Text = "Low Quality (Default)";
						this.ShadowFadeDistanceBox.Text = "25";
						this.DynamicShadowsBox.Text = "0";
						this.SunRenderQualitySelector.Value = 0;
						this.SunRenderQualityLabel.Text = "Low Quality (Default)";
						this.ParticleSpaceAreaSelector.Value = 6;
						this.ParticleSpaceAreaLabel.Text = "5000";
						this.FoliageDrawRadiusSelector.Value = 0;
						this.FoliageDrawRadiusLabel.Text = "Low Quality (Default)";
						this.ShadowFilterRadiusSelector.Value = 0;
						this.ShadowFilterRadiusLabel.Text = "Low Quality (Default)";
						this.ShadowDepthBiasSelector.Value = 0;
						this.ShadowDepthBiasLabel.Text = "Low Quality (Default)";
						this.CharacterLODDistance1Box.Text = "5";
						this.CharacterLODDistance2Box.Text = "7";
						this.VehicleLODDistanceBox.Text = "10";
						this.VehicleCullDistanceBox.Text = "20";
						this.PedestrianLODDistanceBox.Text = "5";
						this.PedestrianCullDistanceBox.Text = "10";
						this.DriverLODDistanceBox.Text = "5";
						this.DriverCullDistanceBox.Text = "10";
						this.LCVehicleLODDistanceBox.Text = "10";
						this.LCVehicleCullDistanceBox.Text = "20";
						this.MaxMemoryCacheEntrySelector.Value = 0;
						this.MaxMemoryCacheEntryLabel.Text = "Low Quality";
						this.EnableDXTLocalCharacter.Checked = false;
						this.EnableDXTLocalVehicle.Checked = false;
						this.EnableDXTOtherCharacter.Checked = false;
						this.EnableDXTOtherVehicle.Checked = false;
						this.EnableDXTNormal.Checked = false;
						this.TextureStreamingMemorySelector.Value = 0;
						this.TextureStreamingMemoryLabel.Text = "Minimal Quality";
						this.TexturePoolMemorySelector.Value = 0;
						this.TexturePoolMemoryLabel.Text = "Low Quality";
						this.MeshStreamingMemorySelector.Value = 0;
						this.MeshStreamingMemoryLabel.Text = "Minimal Quality";
						this.TextureCreationPerFrameBox.Text = "2";
					}
					else
					{
						flag = (this.QualityBar.Value == 3);
						if (flag)
						{
							this.QualityLabel.Text = "Low Quality With Shadows";
							this.AnisoSelector.SelectedIndex = 0;
							this.EnableStaticDecals.Checked = false;
							this.EnableDynamicDecals.Checked = false;
							this.EnableLevelParticles.Checked = false;
							this.EnableDynamicLights.Checked = true;
							this.EnableDynamicShadows.Checked = true;
							this.EnableBlobShadows.Checked = false;
							this.EnableLEShadows.Checked = true;
							this.EnableCDLights.Checked = true;
							this.EnableDirectionalLightmaps.Checked = true;
							this.EnableMotionBlur.Checked = false;
							this.EnableDepthOfField.Checked = false;
							this.EnableAmbientOcclusion.Checked = false;
							this.EnableBloom.Checked = true;
							this.EnableQualityBloom.Checked = false;
							this.EnableDistortion.Checked = false;
							this.EnableDPDistortion.Checked = true;
							this.EnableSTLeaves.Checked = false;
							this.EnableSTFronds.Checked = false;
							this.EnableStreamTextures.Checked = false;
							this.EnableLensFlares.Checked = false;
							this.EnableFogVolumes.Checked = false;
							this.EnableFPRTargets.Checked = true;
							this.EnableTrilinear.Checked = false;
							this.EnableThreadLag.Checked = true;
							this.EnableVsync.Checked = false;
							this.EnableUpscaleSP.Checked = true;
							this.EnableEyelashes.Checked = false;
							this.EnableHighPolyChars.Checked = false;
							this.EnableSmoothFrameRate.Checked = false;
							this.UnknownSelector.Value = 0;
							this.UnknownLabel.Text = "16 (Default)";
							this.EnvironmentSelector.Value = 0;
							this.EnvironmentLabel.Text = "16";
							this.PropSelector.Value = 3;
							this.PropLabel.Text = "128";
							this.CharacterSelector.Value = 3;
							this.CharacterLabel.Text = "128";
							this.VehicleSelector.Value = 5;
							this.VehicleLabel.Text = "512";
							this.PedestrianSelector.Value = 3;
							this.PedestrianLabel.Text = "128 (Default)";
							this.CityVehicleSelector.Value = 4;
							this.CityVehicleLabel.Text = "256";
							this.PickupSelector.Value = 1;
							this.PickupLabel.Text = "32";
							this.PrimitiveSelector.Value = 0;
							this.PrimitiveLabel.Text = "16";
							this.UISelector.Value = 0;
							this.UILabel.Text = "1024 (Default)";
							this.VFXSelector.Value = 2;
							this.VFXLabel.Text = "64";
							this.LSMSelector.Value = 3;
							this.LSMLabel.Text = "128";
							this.RenderTargetSelector.Value = 0;
							this.RenderTargetLabel.Text = "16";
							this.SignageSelector.Value = 2;
							this.SignageLabel.Text = "64 (Default)";
							this.PlayerGraffitiSelector.Value = 3;
							this.PlayerGraffitiLabel.Text = "128";
							this.PlayerStatueSelector.Value = 0;
							this.PlayerStatueLabel.Text = "16 (Default)";
							this.CharacterSharedSelector.Value = 0;
							this.CharacterSharedLabel.Text = "16";
							this.VehicleSharedSelector.Value = 0;
							this.VehicleSharedLabel.Text = "16";
							this.ContactSelector.Value = 3;
							this.ContactLabel.Text = "128";
							this.EnableVSMShadows.Checked = false;
							this.EnablePCFShadows.Checked = false;
							this.EnableBetterShadows.Checked = false;
							this.EnableForegroundShadows.Checked = false;
							this.EnableLQHealthHUD.Checked = true;
							this.EnableSimpleVehicleMaterials.Checked = true;
							this.CharacterDNMSelector.Value = 7;
							this.CharacterDNMLabel.Text = "256";
							this.PlayerVehicleSelector.Value = 1;
							this.PlayerVehicleLabel.Text = "Low Quality (Default)";
							this.ShadowResolutionSelector.Value = 0;
							this.ShadowResolutionLabel.Text = "128 (Default)";
							this.ParticleLODBiasSelector.Value = 0;
							this.ParticleLODBiasLabel.Text = "Low Quality (Default)";
							this.ShadowQualityBiasSelector.Value = 1;
							this.ShadowQualityBiasLabel.Text = "High Quality";
							this.ShadowFadeDistanceBox.Text = "50";
							this.DynamicShadowsBox.Text = "20";
							this.SunRenderQualitySelector.Value = 2;
							this.SunRenderQualityLabel.Text = "High Quality";
							this.ParticleSpaceAreaSelector.Value = 6;
							this.ParticleSpaceAreaLabel.Text = "5000";
							this.FoliageDrawRadiusSelector.Value = 0;
							this.FoliageDrawRadiusLabel.Text = "Low Quality (Default)";
							this.ShadowFilterRadiusSelector.Value = 1;
							this.ShadowFilterRadiusLabel.Text = "High Quality";
							this.ShadowDepthBiasSelector.Value = 0;
							this.ShadowDepthBiasLabel.Text = "Low Quality (Default)";
							this.CharacterLODDistance1Box.Text = "5";
							this.CharacterLODDistance2Box.Text = "7";
							this.VehicleLODDistanceBox.Text = "10";
							this.VehicleCullDistanceBox.Text = "20";
							this.PedestrianLODDistanceBox.Text = "5";
							this.PedestrianCullDistanceBox.Text = "10";
							this.DriverLODDistanceBox.Text = "5";
							this.DriverCullDistanceBox.Text = "10";
							this.LCVehicleLODDistanceBox.Text = "10";
							this.LCVehicleCullDistanceBox.Text = "20";
							this.MaxMemoryCacheEntrySelector.Value = 0;
							this.MaxMemoryCacheEntryLabel.Text = "Low Quality";
							this.EnableDXTLocalCharacter.Checked = false;
							this.EnableDXTLocalVehicle.Checked = false;
							this.EnableDXTOtherCharacter.Checked = false;
							this.EnableDXTOtherVehicle.Checked = false;
							this.EnableDXTNormal.Checked = false;
							this.TextureStreamingMemorySelector.Value = 0;
							this.TextureStreamingMemoryLabel.Text = "Minimal Quality";
							this.TexturePoolMemorySelector.Value = 0;
							this.TexturePoolMemoryLabel.Text = "Low Quality";
							this.MeshStreamingMemorySelector.Value = 0;
							this.MeshStreamingMemoryLabel.Text = "Minimal Quality";
							this.TextureCreationPerFrameBox.Text = "2";
						}
						else
						{
							flag = (this.QualityBar.Value == 4);
							if (flag)
							{
								this.QualityLabel.Text = "Cars and Characters";
								this.AnisoSelector.SelectedIndex = 0;
								this.EnableStaticDecals.Checked = false;
								this.EnableDynamicDecals.Checked = false;
								this.EnableLevelParticles.Checked = false;
								this.EnableDynamicLights.Checked = true;
								this.EnableDynamicShadows.Checked = false;
								this.EnableBlobShadows.Checked = false;
								this.EnableLEShadows.Checked = false;
								this.EnableCDLights.Checked = true;
								this.EnableDirectionalLightmaps.Checked = true;
								this.EnableMotionBlur.Checked = false;
								this.EnableDepthOfField.Checked = false;
								this.EnableAmbientOcclusion.Checked = false;
								this.EnableBloom.Checked = true;
								this.EnableQualityBloom.Checked = false;
								this.EnableDistortion.Checked = false;
								this.EnableDPDistortion.Checked = true;
								this.EnableSTLeaves.Checked = false;
								this.EnableSTFronds.Checked = false;
								this.EnableStreamTextures.Checked = false;
								this.EnableLensFlares.Checked = false;
								this.EnableFogVolumes.Checked = false;
								this.EnableFPRTargets.Checked = true;
								this.EnableTrilinear.Checked = false;
								this.EnableThreadLag.Checked = true;
								this.EnableVsync.Checked = false;
								this.EnableUpscaleSP.Checked = true;
								this.EnableEyelashes.Checked = false;
								this.EnableHighPolyChars.Checked = false;
								this.EnableSmoothFrameRate.Checked = false;
								this.UnknownSelector.Value = 0;
								this.UnknownLabel.Text = "16 (Default)";
								this.EnvironmentSelector.Value = 0;
								this.EnvironmentLabel.Text = "16";
								this.PropSelector.Value = 0;
								this.PropLabel.Text = "16";
								this.CharacterSelector.Value = 6;
								this.CharacterLabel.Text = "1024";
								this.VehicleSelector.Value = 6;
								this.VehicleLabel.Text = "1024";
								this.PedestrianSelector.Value = 5;
								this.PedestrianLabel.Text = "512";
								this.CityVehicleSelector.Value = 6;
								this.CityVehicleLabel.Text = "1024";
								this.PickupSelector.Value = 0;
								this.PickupLabel.Text = "16";
								this.PrimitiveSelector.Value = 0;
								this.PrimitiveLabel.Text = "16";
								this.UISelector.Value = 0;
								this.UILabel.Text = "1024 (Default)";
								this.VFXSelector.Value = 2;
								this.VFXLabel.Text = "64";
								this.LSMSelector.Value = 4;
								this.LSMLabel.Text = "256";
								this.RenderTargetSelector.Value = 0;
								this.RenderTargetLabel.Text = "16";
								this.SignageSelector.Value = 0;
								this.SignageLabel.Text = "16";
								this.PlayerGraffitiSelector.Value = 0;
								this.PlayerGraffitiLabel.Text = "16";
								this.PlayerStatueSelector.Value = 0;
								this.PlayerStatueLabel.Text = "16 (Default)";
								this.CharacterSharedSelector.Value = 4;
								this.CharacterSharedLabel.Text = "256";
								this.VehicleSharedSelector.Value = 4;
								this.VehicleSharedLabel.Text = "256";
								this.ContactSelector.Value = 5;
								this.ContactLabel.Text = "512";
								this.EnableVSMShadows.Checked = false;
								this.EnablePCFShadows.Checked = false;
								this.EnableBetterShadows.Checked = false;
								this.EnableForegroundShadows.Checked = false;
								this.EnableLQHealthHUD.Checked = true;
								this.EnableSimpleVehicleMaterials.Checked = true;
								this.CharacterDNMSelector.Value = 9;
								this.CharacterDNMLabel.Text = "1024";
								this.PlayerVehicleSelector.Value = 2;
								this.PlayerVehicleLabel.Text = "High Quality";
								this.ShadowResolutionSelector.Value = 0;
								this.ShadowResolutionLabel.Text = "128 (Default)";
								this.ParticleLODBiasSelector.Value = 0;
								this.ParticleLODBiasLabel.Text = "Low Quality (Default)";
								this.ShadowQualityBiasSelector.Value = 0;
								this.ShadowQualityBiasLabel.Text = "Low Quality (Default)";
								this.ShadowFadeDistanceBox.Text = "25";
								this.DynamicShadowsBox.Text = "0";
								this.SunRenderQualitySelector.Value = 0;
								this.SunRenderQualityLabel.Text = "Low Quality (Default)";
								this.ParticleSpaceAreaSelector.Value = 6;
								this.ParticleSpaceAreaLabel.Text = "5000";
								this.FoliageDrawRadiusSelector.Value = 0;
								this.FoliageDrawRadiusLabel.Text = "Low Quality (Default)";
								this.ShadowFilterRadiusSelector.Value = 0;
								this.ShadowFilterRadiusLabel.Text = "Low Quality (Default)";
								this.ShadowDepthBiasSelector.Value = 0;
								this.ShadowDepthBiasLabel.Text = "Low Quality (Default)";
								this.CharacterLODDistance1Box.Text = "5";
								this.CharacterLODDistance2Box.Text = "15";
								this.VehicleLODDistanceBox.Text = "25";
								this.VehicleCullDistanceBox.Text = "100";
								this.PedestrianLODDistanceBox.Text = "5";
								this.PedestrianCullDistanceBox.Text = "70";
								this.DriverLODDistanceBox.Text = "5";
								this.DriverCullDistanceBox.Text = "100";
								this.LCVehicleLODDistanceBox.Text = "15";
								this.LCVehicleCullDistanceBox.Text = "100";
								this.MaxMemoryCacheEntrySelector.Value = 0;
								this.MaxMemoryCacheEntryLabel.Text = "Low Quality";
								this.EnableDXTLocalCharacter.Checked = false;
								this.EnableDXTLocalVehicle.Checked = false;
								this.EnableDXTOtherCharacter.Checked = false;
								this.EnableDXTOtherVehicle.Checked = false;
								this.EnableDXTNormal.Checked = false;
								this.TextureStreamingMemorySelector.Value = 4;
								this.TextureStreamingMemoryLabel.Text = "Maximum Quality (Default)";
								this.TexturePoolMemorySelector.Value = 1;
								this.TexturePoolMemoryLabel.Text = "High Quality (Default)";
								this.MeshStreamingMemorySelector.Value = 4;
								this.MeshStreamingMemoryLabel.Text = "Maximum Quality (Default)";
								this.TextureCreationPerFrameBox.Text = "4";
							}
							else
							{
								flag = (this.QualityBar.Value == 5);
								if (flag)
								{
									this.QualityLabel.Text = "USPStyle Quality";
									this.AnisoSelector.SelectedIndex = 1;
									this.EnableStaticDecals.Checked = true;
									this.EnableDynamicDecals.Checked = false;
									this.EnableLevelParticles.Checked = true;
									this.EnableDynamicLights.Checked = true;
									this.EnableDynamicShadows.Checked = true;
									this.EnableBlobShadows.Checked = true;
									this.EnableLEShadows.Checked = true;
									this.EnableCDLights.Checked = false;
									this.EnableDirectionalLightmaps.Checked = true;
									this.EnableMotionBlur.Checked = false;
									this.EnableDepthOfField.Checked = false;
									this.EnableAmbientOcclusion.Checked = false;
									this.EnableBloom.Checked = true;
									this.EnableQualityBloom.Checked = false;
									this.EnableDistortion.Checked = false;
									this.EnableDPDistortion.Checked = true;
									this.EnableSTLeaves.Checked = false;
									this.EnableSTFronds.Checked = false;
									this.EnableStreamTextures.Checked = false;
									this.EnableLensFlares.Checked = false;
									this.EnableFogVolumes.Checked = false;
									this.EnableFPRTargets.Checked = true;
									this.EnableTrilinear.Checked = true;
									this.EnableThreadLag.Checked = true;
									this.EnableVsync.Checked = false;
									this.EnableUpscaleSP.Checked = true;
									this.EnableEyelashes.Checked = true;
									this.EnableHighPolyChars.Checked = false;
									this.EnableSmoothFrameRate.Checked = false;
									this.UnknownSelector.Value = 0;
									this.UnknownLabel.Text = "16 (Default)";
									this.EnvironmentSelector.Value = 4;
									this.EnvironmentLabel.Text = "256";
									this.PropSelector.Value = 4;
									this.PropLabel.Text = "256";
									this.CharacterSelector.Value = 6;
									this.CharacterLabel.Text = "1024";
									this.VehicleSelector.Value = 6;
									this.VehicleLabel.Text = "1024";
									this.PedestrianSelector.Value = 5;
									this.PedestrianLabel.Text = "512";
									this.CityVehicleSelector.Value = 6;
									this.CityVehicleLabel.Text = "1024";
									this.PickupSelector.Value = 3;
									this.PickupLabel.Text = "128";
									this.PrimitiveSelector.Value = 3;
									this.PrimitiveLabel.Text = "128";
									this.UISelector.Value = 0;
									this.UILabel.Text = "1024 (Default)";
									this.VFXSelector.Value = 2;
									this.VFXLabel.Text = "64";
									this.LSMSelector.Value = 3;
									this.LSMLabel.Text = "128";
									this.RenderTargetSelector.Value = 0;
									this.RenderTargetLabel.Text = "16";
									this.SignageSelector.Value = 4;
									this.SignageLabel.Text = "256";
									this.PlayerGraffitiSelector.Value = 4;
									this.PlayerGraffitiLabel.Text = "256";
									this.PlayerStatueSelector.Value = 0;
									this.PlayerStatueLabel.Text = "16 (Default)";
									this.CharacterSharedSelector.Value = 3;
									this.CharacterSharedLabel.Text = "128";
									this.VehicleSharedSelector.Value = 3;
									this.VehicleSharedLabel.Text = "128";
									this.ContactSelector.Value = 5;
									this.ContactLabel.Text = "512";
									this.EnableVSMShadows.Checked = false;
									this.EnablePCFShadows.Checked = false;
									this.EnableBetterShadows.Checked = false;
									this.EnableForegroundShadows.Checked = false;
									this.EnableLQHealthHUD.Checked = true;
									this.EnableSimpleVehicleMaterials.Checked = false;
									this.CharacterDNMSelector.Value = 9;
									this.CharacterDNMLabel.Text = "1024";
									this.PlayerVehicleSelector.Value = 3;
									this.PlayerVehicleLabel.Text = "Ultra Quality";
									this.ShadowResolutionSelector.Value = 3;
									this.ShadowResolutionLabel.Text = "1024";
									this.ParticleLODBiasSelector.Value = 0;
									this.ParticleLODBiasLabel.Text = "Low Quality (Default)";
									this.ShadowQualityBiasSelector.Value = 1;
									this.ShadowQualityBiasLabel.Text = "High Quality";
									this.ShadowFadeDistanceBox.Text = "50";
									this.DynamicShadowsBox.Text = "25";
									this.SunRenderQualitySelector.Value = 1;
									this.SunRenderQualityLabel.Text = "Medium Quality";
									this.ParticleSpaceAreaSelector.Value = 7;
									this.ParticleSpaceAreaLabel.Text = "7812.5";
									this.FoliageDrawRadiusSelector.Value = 0;
									this.FoliageDrawRadiusLabel.Text = "Low Quality (Default)";
									this.ShadowFilterRadiusSelector.Value = 0;
									this.ShadowFilterRadiusLabel.Text = "Low Quality (Default)";
									this.ShadowDepthBiasSelector.Value = 3;
									this.ShadowDepthBiasLabel.Text = "Ultra Quality";
									this.CharacterLODDistance1Box.Text = "7";
									this.CharacterLODDistance2Box.Text = "18";
									this.VehicleLODDistanceBox.Text = "30";
									this.VehicleCullDistanceBox.Text = "100";
									this.PedestrianLODDistanceBox.Text = "5";
									this.PedestrianCullDistanceBox.Text = "50";
									this.DriverLODDistanceBox.Text = "5";
									this.DriverCullDistanceBox.Text = "50";
									this.LCVehicleLODDistanceBox.Text = "30";
									this.LCVehicleCullDistanceBox.Text = "100";
									this.MaxMemoryCacheEntrySelector.Value = 1;
									this.MaxMemoryCacheEntryLabel.Text = "Medium Quality (Default)";
									this.EnableDXTLocalCharacter.Checked = false;
									this.EnableDXTLocalVehicle.Checked = false;
									this.EnableDXTOtherCharacter.Checked = false;
									this.EnableDXTOtherVehicle.Checked = false;
									this.EnableDXTNormal.Checked = false;
									this.TextureStreamingMemorySelector.Value = 4;
									this.TextureStreamingMemoryLabel.Text = "Maximum Quality (Default)";
									this.TexturePoolMemorySelector.Value = 1;
									this.TexturePoolMemoryLabel.Text = "High Quality (Default)";
									this.MeshStreamingMemorySelector.Value = 4;
									this.MeshStreamingMemoryLabel.Text = "Maximum Quality (Default)";
									this.TextureCreationPerFrameBox.Text = "4";
								}
								else
								{
									flag = (this.QualityBar.Value == 6);
									if (flag)
									{
										this.QualityLabel.Text = "Low Quality Environment";
										this.AnisoSelector.SelectedIndex = 0;
										this.EnableStaticDecals.Checked = false;
										this.EnableDynamicDecals.Checked = false;
										this.EnableLevelParticles.Checked = false;
										this.EnableDynamicLights.Checked = true;
										this.EnableDynamicShadows.Checked = true;
										this.EnableBlobShadows.Checked = true;
										this.EnableLEShadows.Checked = true;
										this.EnableCDLights.Checked = false;
										this.EnableDirectionalLightmaps.Checked = true;
										this.EnableMotionBlur.Checked = false;
										this.EnableDepthOfField.Checked = false;
										this.EnableAmbientOcclusion.Checked = false;
										this.EnableBloom.Checked = true;
										this.EnableQualityBloom.Checked = false;
										this.EnableDistortion.Checked = false;
										this.EnableDPDistortion.Checked = true;
										this.EnableSTLeaves.Checked = false;
										this.EnableSTFronds.Checked = false;
										this.EnableStreamTextures.Checked = false;
										this.EnableLensFlares.Checked = false;
										this.EnableFogVolumes.Checked = false;
										this.EnableFPRTargets.Checked = true;
										this.EnableTrilinear.Checked = true;
										this.EnableThreadLag.Checked = true;
										this.EnableVsync.Checked = false;
										this.EnableUpscaleSP.Checked = true;
										this.EnableEyelashes.Checked = false;
										this.EnableHighPolyChars.Checked = false;
										this.EnableSmoothFrameRate.Checked = false;
										this.UnknownSelector.Value = 0;
										this.UnknownLabel.Text = "16 (Default)";
										this.EnvironmentSelector.Value = 0;
										this.EnvironmentLabel.Text = "16";
										this.PropSelector.Value = 5;
										this.PropLabel.Text = "512";
										this.CharacterSelector.Value = 6;
										this.CharacterLabel.Text = "1024";
										this.VehicleSelector.Value = 6;
										this.VehicleLabel.Text = "1024";
										this.PedestrianSelector.Value = 5;
										this.PedestrianLabel.Text = "512";
										this.CityVehicleSelector.Value = 6;
										this.CityVehicleLabel.Text = "1024";
										this.PickupSelector.Value = 5;
										this.PickupLabel.Text = "512";
										this.PrimitiveSelector.Value = 5;
										this.PrimitiveLabel.Text = "512";
										this.UISelector.Value = 0;
										this.UILabel.Text = "1024 (Default)";
										this.VFXSelector.Value = 3;
										this.VFXLabel.Text = "128";
										this.LSMSelector.Value = 5;
										this.LSMLabel.Text = "512";
										this.RenderTargetSelector.Value = 5;
										this.RenderTargetLabel.Text = "512";
										this.SignageSelector.Value = 5;
										this.SignageLabel.Text = "512";
										this.PlayerGraffitiSelector.Value = 5;
										this.PlayerGraffitiLabel.Text = "512";
										this.PlayerStatueSelector.Value = 0;
										this.PlayerStatueLabel.Text = "16 (Default)";
										this.CharacterSharedSelector.Value = 6;
										this.CharacterSharedLabel.Text = "1024";
										this.VehicleSharedSelector.Value = 6;
										this.VehicleSharedLabel.Text = "1024";
										this.ContactSelector.Value = 6;
										this.ContactLabel.Text = "1024";
										this.EnableVSMShadows.Checked = false;
										this.EnablePCFShadows.Checked = false;
										this.EnableBetterShadows.Checked = false;
										this.EnableForegroundShadows.Checked = false;
										this.EnableLQHealthHUD.Checked = true;
										this.EnableSimpleVehicleMaterials.Checked = true;
										this.CharacterDNMSelector.Value = 9;
										this.CharacterDNMLabel.Text = "1024";
										this.PlayerVehicleSelector.Value = 2;
										this.PlayerVehicleLabel.Text = "High Quality";
										this.ShadowResolutionSelector.Value = 1;
										this.ShadowResolutionLabel.Text = "256";
										this.ParticleLODBiasSelector.Value = 0;
										this.ParticleLODBiasLabel.Text = "Low Quality (Default)";
										this.ShadowQualityBiasSelector.Value = 1;
										this.ShadowQualityBiasLabel.Text = "High Quality";
										this.ShadowFadeDistanceBox.Text = "50";
										this.DynamicShadowsBox.Text = "20";
										this.SunRenderQualitySelector.Value = 2;
										this.SunRenderQualityLabel.Text = "High Quality";
										this.ParticleSpaceAreaSelector.Value = 6;
										this.ParticleSpaceAreaLabel.Text = "5000";
										this.FoliageDrawRadiusSelector.Value = 0;
										this.FoliageDrawRadiusLabel.Text = "Low Quality (Default)";
										this.ShadowFilterRadiusSelector.Value = 0;
										this.ShadowFilterRadiusLabel.Text = "Low Quality (Default)";
										this.ShadowDepthBiasSelector.Value = 0;
										this.ShadowDepthBiasLabel.Text = "Low Quality (Default)";
										this.CharacterLODDistance1Box.Text = "5";
										this.CharacterLODDistance2Box.Text = "15";
										this.VehicleLODDistanceBox.Text = "25";
										this.VehicleCullDistanceBox.Text = "100";
										this.PedestrianLODDistanceBox.Text = "5";
										this.PedestrianCullDistanceBox.Text = "70";
										this.DriverLODDistanceBox.Text = "5";
										this.DriverCullDistanceBox.Text = "100";
										this.LCVehicleLODDistanceBox.Text = "15";
										this.LCVehicleCullDistanceBox.Text = "100";
										this.MaxMemoryCacheEntrySelector.Value = 0;
										this.MaxMemoryCacheEntryLabel.Text = "Low Quality";
										this.EnableDXTLocalCharacter.Checked = false;
										this.EnableDXTLocalVehicle.Checked = false;
										this.EnableDXTOtherCharacter.Checked = false;
										this.EnableDXTOtherVehicle.Checked = false;
										this.EnableDXTNormal.Checked = false;
										this.TextureStreamingMemorySelector.Value = 4;
										this.TextureStreamingMemoryLabel.Text = "Maximum Quality (Default)";
										this.TexturePoolMemorySelector.Value = 1;
										this.TexturePoolMemoryLabel.Text = "High Quality (Default)";
										this.MeshStreamingMemorySelector.Value = 4;
										this.MeshStreamingMemoryLabel.Text = "Maximum Quality (Default)";
										this.TextureCreationPerFrameBox.Text = "2";
									}
									else
									{
										flag = (this.QualityBar.Value == 7);
										if (flag)
										{
											this.QualityLabel.Text = "High Quality";
											this.AnisoSelector.SelectedIndex = 3;
											this.EnableStaticDecals.Checked = true;
											this.EnableDynamicDecals.Checked = true;
											this.EnableLevelParticles.Checked = true;
											this.EnableDynamicLights.Checked = true;
											this.EnableDynamicShadows.Checked = true;
											this.EnableBlobShadows.Checked = true;
											this.EnableLEShadows.Checked = true;
											this.EnableCDLights.Checked = false;
											this.EnableDirectionalLightmaps.Checked = true;
											this.EnableMotionBlur.Checked = true;
											this.EnableDepthOfField.Checked = true;
											this.EnableAmbientOcclusion.Checked = false;
											this.EnableBloom.Checked = true;
											this.EnableQualityBloom.Checked = true;
											this.EnableDistortion.Checked = true;
											this.EnableDPDistortion.Checked = false;
											this.EnableSTLeaves.Checked = true;
											this.EnableSTFronds.Checked = true;
											this.EnableStreamTextures.Checked = false;
											this.EnableLensFlares.Checked = true;
											this.EnableFogVolumes.Checked = true;
											this.EnableFPRTargets.Checked = true;
											this.EnableTrilinear.Checked = true;
											this.EnableThreadLag.Checked = true;
											this.EnableVsync.Checked = false;
											this.EnableUpscaleSP.Checked = true;
											this.EnableEyelashes.Checked = true;
											this.EnableHighPolyChars.Checked = true;
											this.EnableSmoothFrameRate.Checked = false;
											this.UnknownSelector.Value = 0;
											this.UnknownLabel.Text = "16 (Default)";
											this.EnvironmentSelector.Value = 6;
											this.EnvironmentLabel.Text = "1024";
											this.PropSelector.Value = 6;
											this.PropLabel.Text = "1024";
											this.CharacterSelector.Value = 6;
											this.CharacterLabel.Text = "1024";
											this.VehicleSelector.Value = 6;
											this.VehicleLabel.Text = "1024";
											this.PedestrianSelector.Value = 6;
											this.PedestrianLabel.Text = "1024";
											this.CityVehicleSelector.Value = 6;
											this.CityVehicleLabel.Text = "1024";
											this.PickupSelector.Value = 6;
											this.PickupLabel.Text = "1024";
											this.PrimitiveSelector.Value = 6;
											this.PrimitiveLabel.Text = "1024";
											this.UISelector.Value = 0;
											this.UILabel.Text = "1024 (Default)";
											this.VFXSelector.Value = 6;
											this.VFXLabel.Text = "1024";
											this.LSMSelector.Value = 6;
											this.LSMLabel.Text = "1024";
											this.RenderTargetSelector.Value = 6;
											this.RenderTargetLabel.Text = "1024";
											this.SignageSelector.Value = 6;
											this.SignageLabel.Text = "1024";
											this.PlayerGraffitiSelector.Value = 6;
											this.PlayerGraffitiLabel.Text = "1024";
											this.PlayerStatueSelector.Value = 6;
											this.PlayerStatueLabel.Text = "1024";
											this.CharacterSharedSelector.Value = 6;
											this.CharacterSharedLabel.Text = "1024";
											this.VehicleSharedSelector.Value = 6;
											this.VehicleSharedLabel.Text = "1024";
											this.ContactSelector.Value = 6;
											this.ContactLabel.Text = "1024";
											this.EnableVSMShadows.Checked = false;
											this.EnablePCFShadows.Checked = false;
											this.EnableBetterShadows.Checked = true;
											this.EnableForegroundShadows.Checked = true;
											this.EnableLQHealthHUD.Checked = false;
											this.EnableSimpleVehicleMaterials.Checked = false;
											this.CharacterDNMSelector.Value = 9;
											this.CharacterDNMLabel.Text = "1024";
											this.PlayerVehicleSelector.Value = 2;
											this.PlayerVehicleLabel.Text = "High Quality";
											this.ShadowResolutionSelector.Value = 3;
											this.ShadowResolutionLabel.Text = "1024";
											this.ParticleLODBiasSelector.Value = 1;
											this.ParticleLODBiasLabel.Text = "High Quality";
											this.ShadowQualityBiasSelector.Value = 1;
											this.ShadowQualityBiasLabel.Text = "High Quality";
											this.ShadowFadeDistanceBox.Text = "75";
											this.DynamicShadowsBox.Text = "30";
											this.SunRenderQualitySelector.Value = 2;
											this.SunRenderQualityLabel.Text = "High Quality";
											this.ParticleSpaceAreaSelector.Value = 10;
											this.ParticleSpaceAreaLabel.Text = "50000";
											this.FoliageDrawRadiusSelector.Value = 1;
											this.FoliageDrawRadiusLabel.Text = "High Quality";
											this.ShadowFilterRadiusSelector.Value = 1;
											this.ShadowFilterRadiusLabel.Text = "High Quality";
											this.ShadowDepthBiasSelector.Value = 2;
											this.ShadowDepthBiasLabel.Text = "High Quality";
											this.CharacterLODDistance1Box.Text = "7";
											this.CharacterLODDistance2Box.Text = "18";
											this.VehicleLODDistanceBox.Text = "30";
											this.VehicleCullDistanceBox.Text = "100";
											this.PedestrianLODDistanceBox.Text = "5";
											this.PedestrianCullDistanceBox.Text = "50";
											this.DriverLODDistanceBox.Text = "5";
											this.DriverCullDistanceBox.Text = "50";
											this.LCVehicleLODDistanceBox.Text = "30";
											this.LCVehicleCullDistanceBox.Text = "100";
											this.MaxMemoryCacheEntrySelector.Value = 1;
											this.MaxMemoryCacheEntryLabel.Text = "Medium Quality (Default)";
											this.EnableDXTLocalCharacter.Checked = false;
											this.EnableDXTLocalVehicle.Checked = false;
											this.EnableDXTOtherCharacter.Checked = false;
											this.EnableDXTOtherVehicle.Checked = false;
											this.EnableDXTNormal.Checked = false;
											this.TextureStreamingMemorySelector.Value = 4;
											this.TextureStreamingMemoryLabel.Text = "Maximum Quality (Default)";
											this.TexturePoolMemorySelector.Value = 1;
											this.TexturePoolMemoryLabel.Text = "High Quality (Default)";
											this.MeshStreamingMemorySelector.Value = 4;
											this.MeshStreamingMemoryLabel.Text = "Maximum Quality (Default)";
											this.TextureCreationPerFrameBox.Text = "6";
										}
										else
										{
											flag = (this.QualityBar.Value == 8);
											if (flag)
											{
												this.QualityLabel.Text = "Ultra Quality";
												this.AnisoSelector.SelectedIndex = 4;
												this.EnableStaticDecals.Checked = true;
												this.EnableDynamicDecals.Checked = true;
												this.EnableLevelParticles.Checked = true;
												this.EnableDynamicLights.Checked = true;
												this.EnableDynamicShadows.Checked = true;
												this.EnableBlobShadows.Checked = true;
												this.EnableLEShadows.Checked = true;
												this.EnableCDLights.Checked = false;
												this.EnableDirectionalLightmaps.Checked = true;
												this.EnableMotionBlur.Checked = true;
												this.EnableDepthOfField.Checked = true;
												this.EnableAmbientOcclusion.Checked = false;
												this.EnableBloom.Checked = true;
												this.EnableQualityBloom.Checked = true;
												this.EnableDistortion.Checked = true;
												this.EnableDPDistortion.Checked = false;
												this.EnableSTLeaves.Checked = true;
												this.EnableSTFronds.Checked = true;
												this.EnableStreamTextures.Checked = false;
												this.EnableLensFlares.Checked = true;
												this.EnableFogVolumes.Checked = true;
												this.EnableFPRTargets.Checked = true;
												this.EnableTrilinear.Checked = true;
												this.EnableThreadLag.Checked = true;
												this.EnableVsync.Checked = false;
												this.EnableUpscaleSP.Checked = true;
												this.EnableEyelashes.Checked = true;
												this.EnableHighPolyChars.Checked = true;
												this.EnableSmoothFrameRate.Checked = false;
												this.UnknownSelector.Value = 1;
												this.UnknownLabel.Text = "32";
												this.EnvironmentSelector.Value = 8;
												this.EnvironmentLabel.Text = "4096";
												this.PropSelector.Value = 8;
												this.PropLabel.Text = "4096";
												this.CharacterSelector.Value = 8;
												this.CharacterLabel.Text = "4096";
												this.VehicleSelector.Value = 8;
												this.VehicleLabel.Text = "4096";
												this.PedestrianSelector.Value = 6;
												this.PedestrianLabel.Text = "1024";
												this.CityVehicleSelector.Value = 8;
												this.CityVehicleLabel.Text = "4096";
												this.PickupSelector.Value = 8;
												this.PickupLabel.Text = "4096";
												this.PrimitiveSelector.Value = 8;
												this.PrimitiveLabel.Text = "4096";
												this.UISelector.Value = 0;
												this.UILabel.Text = "1024 (Default)";
												this.VFXSelector.Value = 8;
												this.VFXLabel.Text = "4096";
												this.LSMSelector.Value = 8;
												this.LSMLabel.Text = "4096";
												this.RenderTargetSelector.Value = 8;
												this.RenderTargetLabel.Text = "4096";
												this.SignageSelector.Value = 8;
												this.SignageLabel.Text = "4096";
												this.PlayerGraffitiSelector.Value = 8;
												this.PlayerGraffitiLabel.Text = "4096";
												this.PlayerStatueSelector.Value = 8;
												this.PlayerStatueLabel.Text = "4096";
												this.CharacterSharedSelector.Value = 8;
												this.CharacterSharedLabel.Text = "4096";
												this.VehicleSharedSelector.Value = 8;
												this.VehicleSharedLabel.Text = "4096";
												this.ContactSelector.Value = 8;
												this.ContactLabel.Text = "4096";
												this.EnableVSMShadows.Checked = false;
												this.EnablePCFShadows.Checked = false;
												this.EnableBetterShadows.Checked = true;
												this.EnableForegroundShadows.Checked = true;
												this.EnableLQHealthHUD.Checked = false;
												this.EnableSimpleVehicleMaterials.Checked = false;
												this.CharacterDNMSelector.Value = 9;
												this.CharacterDNMLabel.Text = "1024";
												this.PlayerVehicleSelector.Value = 3;
												this.PlayerVehicleLabel.Text = "Ultra Quality";
												this.ShadowResolutionSelector.Value = 4;
												this.ShadowResolutionLabel.Text = "2048";
												this.ParticleLODBiasSelector.Value = 1;
												this.ParticleLODBiasLabel.Text = "High Quality";
												this.ShadowQualityBiasSelector.Value = 1;
												this.ShadowQualityBiasLabel.Text = "High Quality";
												this.ShadowFadeDistanceBox.Text = "75";
												this.DynamicShadowsBox.Text = "35";
												this.SunRenderQualitySelector.Value = 2;
												this.SunRenderQualityLabel.Text = "High Quality";
												this.ParticleSpaceAreaSelector.Value = 13;
												this.ParticleSpaceAreaLabel.Text = "500000";
												this.FoliageDrawRadiusSelector.Value = 1;
												this.FoliageDrawRadiusLabel.Text = "High Quality";
												this.ShadowFilterRadiusSelector.Value = 2;
												this.ShadowFilterRadiusLabel.Text = "Ultra Quality";
												this.ShadowDepthBiasSelector.Value = 3;
												this.ShadowDepthBiasLabel.Text = "Ultra Quality";
												this.CharacterLODDistance1Box.Text = "10";
												this.CharacterLODDistance2Box.Text = "20";
												this.VehicleLODDistanceBox.Text = "30";
												this.VehicleCullDistanceBox.Text = "100";
												this.PedestrianLODDistanceBox.Text = "5";
												this.PedestrianCullDistanceBox.Text = "50";
												this.DriverLODDistanceBox.Text = "5";
												this.DriverCullDistanceBox.Text = "50";
												this.LCVehicleLODDistanceBox.Text = "30";
												this.LCVehicleCullDistanceBox.Text = "100";
												this.MaxMemoryCacheEntrySelector.Value = 2;
												this.MaxMemoryCacheEntryLabel.Text = "High Quality";
												this.EnableDXTLocalCharacter.Checked = false;
												this.EnableDXTLocalVehicle.Checked = false;
												this.EnableDXTOtherCharacter.Checked = false;
												this.EnableDXTOtherVehicle.Checked = false;
												this.EnableDXTNormal.Checked = false;
												this.TextureStreamingMemorySelector.Value = 5;
												this.TextureStreamingMemoryLabel.Text = "Ultra Quality";
												this.TexturePoolMemorySelector.Value = 2;
												this.TexturePoolMemoryLabel.Text = "Ultra Quality";
												this.MeshStreamingMemorySelector.Value = 5;
												this.MeshStreamingMemoryLabel.Text = "Ultra Quality";
												this.TextureCreationPerFrameBox.Text = "10";
											}
											else
											{
												flag = (this.QualityBar.Value == 9);
												if (flag)
												{
													this.QualityLabel.Text = "Custom";
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000033D2 File Offset: 0x000015D2
		private void InGameBox_Enter(object sender, EventArgs e)
		{
			this.QualityBar.Value = 9;
			this.QualityLabel.Text = "Custom";
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000033D2 File Offset: 0x000015D2
		private void GroupBox2_Enter(object sender, EventArgs e)
		{
			this.QualityBar.Value = 9;
			this.QualityLabel.Text = "Custom";
		}

		// Token: 0x0600038F RID: 911 RVA: 0x000033D2 File Offset: 0x000015D2
		private void GroupBox3_Enter(object sender, EventArgs e)
		{
			this.QualityBar.Value = 9;
			this.QualityLabel.Text = "Custom";
		}

		// Token: 0x06000390 RID: 912 RVA: 0x000033D2 File Offset: 0x000015D2
		private void GroupBox4_Enter(object sender, EventArgs e)
		{
			this.QualityBar.Value = 9;
			this.QualityLabel.Text = "Custom";
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0002589C File Offset: 0x00023A9C
		private void ResolutionSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.ResolutionSelector.SelectedIndex == 23;
			if (flag)
			{
				this.ResX.Visible = true;
				this.ResXLabel.Visible = true;
				this.ResY.Visible = true;
				this.ResYLabel.Visible = true;
			}
			else
			{
				this.ResX.Visible = false;
				this.ResXLabel.Visible = false;
				this.ResY.Visible = false;
				this.ResYLabel.Visible = false;
			}
		}

		// Token: 0x04000033 RID: 51
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000035 RID: 53
		[AccessedThroughProperty("ExitBtn")]
		private Button _ExitBtn;

		// Token: 0x04000036 RID: 54
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000037 RID: 55
		[AccessedThroughProperty("InGameBox")]
		private GroupBox _InGameBox;

		// Token: 0x04000038 RID: 56
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000039 RID: 57
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x0400003A RID: 58
		[AccessedThroughProperty("CancelBtn")]
		private Button _CancelBtn;

		// Token: 0x0400003B RID: 59
		[AccessedThroughProperty("SaveBtn")]
		private Button _SaveBtn;

		// Token: 0x0400003C RID: 60
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400003D RID: 61
		[AccessedThroughProperty("ResolutionSelector")]
		private ComboBox _ResolutionSelector;

		// Token: 0x0400003E RID: 62
		[AccessedThroughProperty("EnableVsync")]
		private CheckBox _EnableVsync;

		// Token: 0x0400003F RID: 63
		[AccessedThroughProperty("SettingToolTip")]
		private ToolTip _SettingToolTip;

		// Token: 0x04000040 RID: 64
		[AccessedThroughProperty("EnableSmoothFrameRate")]
		private CheckBox _EnableSmoothFrameRate;

		// Token: 0x04000041 RID: 65
		[AccessedThroughProperty("EnableDynamicShadows")]
		private CheckBox _EnableDynamicShadows;

		// Token: 0x04000042 RID: 66
		[AccessedThroughProperty("EnableStaticDecals")]
		private CheckBox _EnableStaticDecals;

		// Token: 0x04000043 RID: 67
		[AccessedThroughProperty("EnableTrilinear")]
		private CheckBox _EnableTrilinear;

		// Token: 0x04000044 RID: 68
		[AccessedThroughProperty("EnableDistortion")]
		private CheckBox _EnableDistortion;

		// Token: 0x04000045 RID: 69
		[AccessedThroughProperty("EnableBloom")]
		private CheckBox _EnableBloom;

		// Token: 0x04000046 RID: 70
		[AccessedThroughProperty("EnableAmbientOcclusion")]
		private CheckBox _EnableAmbientOcclusion;

		// Token: 0x04000047 RID: 71
		[AccessedThroughProperty("EnableBlobShadows")]
		private CheckBox _EnableBlobShadows;

		// Token: 0x04000048 RID: 72
		[AccessedThroughProperty("EnableLEShadows")]
		private CheckBox _EnableLEShadows;

		// Token: 0x04000049 RID: 73
		[AccessedThroughProperty("EnableLQHealthHUD")]
		private CheckBox _EnableLQHealthHUD;

		// Token: 0x0400004A RID: 74
		[AccessedThroughProperty("EnableEyelashes")]
		private CheckBox _EnableEyelashes;

		// Token: 0x0400004B RID: 75
		[AccessedThroughProperty("AnisoSelector")]
		private ComboBox _AnisoSelector;

		// Token: 0x0400004C RID: 76
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400004D RID: 77
		[AccessedThroughProperty("EnableDynamicDecals")]
		private CheckBox _EnableDynamicDecals;

		// Token: 0x0400004E RID: 78
		[AccessedThroughProperty("EnableLevelParticles")]
		private CheckBox _EnableLevelParticles;

		// Token: 0x0400004F RID: 79
		[AccessedThroughProperty("EnableCDLights")]
		private CheckBox _EnableCDLights;

		// Token: 0x04000050 RID: 80
		[AccessedThroughProperty("EnableDynamicLights")]
		private CheckBox _EnableDynamicLights;

		// Token: 0x04000051 RID: 81
		[AccessedThroughProperty("EnableDirectionalLightmaps")]
		private CheckBox _EnableDirectionalLightmaps;

		// Token: 0x04000052 RID: 82
		[AccessedThroughProperty("EnableFogVolumes")]
		private CheckBox _EnableFogVolumes;

		// Token: 0x04000053 RID: 83
		[AccessedThroughProperty("EnableLensFlares")]
		private CheckBox _EnableLensFlares;

		// Token: 0x04000054 RID: 84
		[AccessedThroughProperty("EnableStreamTextures")]
		private CheckBox _EnableStreamTextures;

		// Token: 0x04000055 RID: 85
		[AccessedThroughProperty("EnableSTFronds")]
		private CheckBox _EnableSTFronds;

		// Token: 0x04000056 RID: 86
		[AccessedThroughProperty("EnableSTLeaves")]
		private CheckBox _EnableSTLeaves;

		// Token: 0x04000057 RID: 87
		[AccessedThroughProperty("EnableDPDistortion")]
		private CheckBox _EnableDPDistortion;

		// Token: 0x04000058 RID: 88
		[AccessedThroughProperty("EnableQualityBloom")]
		private CheckBox _EnableQualityBloom;

		// Token: 0x04000059 RID: 89
		[AccessedThroughProperty("EnableDepthOfField")]
		private CheckBox _EnableDepthOfField;

		// Token: 0x0400005A RID: 90
		[AccessedThroughProperty("EnableMotionBlur")]
		private CheckBox _EnableMotionBlur;

		// Token: 0x0400005B RID: 91
		[AccessedThroughProperty("EnableDXTNormal")]
		private CheckBox _EnableDXTNormal;

		// Token: 0x0400005C RID: 92
		[AccessedThroughProperty("EnableDXTOtherVehicle")]
		private CheckBox _EnableDXTOtherVehicle;

		// Token: 0x0400005D RID: 93
		[AccessedThroughProperty("EnableDXTOtherCharacter")]
		private CheckBox _EnableDXTOtherCharacter;

		// Token: 0x0400005E RID: 94
		[AccessedThroughProperty("EnableDXTLocalVehicle")]
		private CheckBox _EnableDXTLocalVehicle;

		// Token: 0x0400005F RID: 95
		[AccessedThroughProperty("EnableDXTLocalCharacter")]
		private CheckBox _EnableDXTLocalCharacter;

		// Token: 0x04000060 RID: 96
		[AccessedThroughProperty("EnableSimpleVehicleMaterials")]
		private CheckBox _EnableSimpleVehicleMaterials;

		// Token: 0x04000061 RID: 97
		[AccessedThroughProperty("EnableForegroundShadows")]
		private CheckBox _EnableForegroundShadows;

		// Token: 0x04000062 RID: 98
		[AccessedThroughProperty("EnableBetterShadows")]
		private CheckBox _EnableBetterShadows;

		// Token: 0x04000063 RID: 99
		[AccessedThroughProperty("EnablePCFShadows")]
		private CheckBox _EnablePCFShadows;

		// Token: 0x04000064 RID: 100
		[AccessedThroughProperty("EnableVSMShadows")]
		private CheckBox _EnableVSMShadows;

		// Token: 0x04000065 RID: 101
		[AccessedThroughProperty("EnableHighPolyChars")]
		private CheckBox _EnableHighPolyChars;

		// Token: 0x04000066 RID: 102
		[AccessedThroughProperty("EnableUpscaleSP")]
		private CheckBox _EnableUpscaleSP;

		// Token: 0x04000067 RID: 103
		[AccessedThroughProperty("EnableThreadLag")]
		private CheckBox _EnableThreadLag;

		// Token: 0x04000068 RID: 104
		[AccessedThroughProperty("EnableFPRTargets")]
		private CheckBox _EnableFPRTargets;

		// Token: 0x04000069 RID: 105
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x0400006A RID: 106
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x0400006B RID: 107
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400006C RID: 108
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x0400006D RID: 109
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400006E RID: 110
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400006F RID: 111
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000070 RID: 112
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000071 RID: 113
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000072 RID: 114
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000073 RID: 115
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000074 RID: 116
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000075 RID: 117
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000076 RID: 118
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000077 RID: 119
		[AccessedThroughProperty("UnknownSelector")]
		private TrackBar _UnknownSelector;

		// Token: 0x04000078 RID: 120
		[AccessedThroughProperty("UnknownLabel")]
		private Label _UnknownLabel;

		// Token: 0x04000079 RID: 121
		[AccessedThroughProperty("EnvironmentSelector")]
		private TrackBar _EnvironmentSelector;

		// Token: 0x0400007A RID: 122
		[AccessedThroughProperty("EnvironmentLabel")]
		private Label _EnvironmentLabel;

		// Token: 0x0400007B RID: 123
		[AccessedThroughProperty("PropLabel")]
		private Label _PropLabel;

		// Token: 0x0400007C RID: 124
		[AccessedThroughProperty("PropSelector")]
		private TrackBar _PropSelector;

		// Token: 0x0400007D RID: 125
		[AccessedThroughProperty("CharacterLabel")]
		private Label _CharacterLabel;

		// Token: 0x0400007E RID: 126
		[AccessedThroughProperty("CharacterSelector")]
		private TrackBar _CharacterSelector;

		// Token: 0x0400007F RID: 127
		[AccessedThroughProperty("VehicleLabel")]
		private Label _VehicleLabel;

		// Token: 0x04000080 RID: 128
		[AccessedThroughProperty("VehicleSelector")]
		private TrackBar _VehicleSelector;

		// Token: 0x04000081 RID: 129
		[AccessedThroughProperty("PedestrianLabel")]
		private Label _PedestrianLabel;

		// Token: 0x04000082 RID: 130
		[AccessedThroughProperty("PedestrianSelector")]
		private TrackBar _PedestrianSelector;

		// Token: 0x04000083 RID: 131
		[AccessedThroughProperty("CityVehicleLabel")]
		private Label _CityVehicleLabel;

		// Token: 0x04000084 RID: 132
		[AccessedThroughProperty("CityVehicleSelector")]
		private TrackBar _CityVehicleSelector;

		// Token: 0x04000085 RID: 133
		[AccessedThroughProperty("PickupLabel")]
		private Label _PickupLabel;

		// Token: 0x04000086 RID: 134
		[AccessedThroughProperty("PickupSelector")]
		private TrackBar _PickupSelector;

		// Token: 0x04000087 RID: 135
		[AccessedThroughProperty("PrimitiveLabel")]
		private Label _PrimitiveLabel;

		// Token: 0x04000088 RID: 136
		[AccessedThroughProperty("PrimitiveSelector")]
		private TrackBar _PrimitiveSelector;

		// Token: 0x04000089 RID: 137
		[AccessedThroughProperty("UILabel")]
		private Label _UILabel;

		// Token: 0x0400008A RID: 138
		[AccessedThroughProperty("UISelector")]
		private TrackBar _UISelector;

		// Token: 0x0400008B RID: 139
		[AccessedThroughProperty("ShadowResolutionLabel")]
		private Label _ShadowResolutionLabel;

		// Token: 0x0400008C RID: 140
		[AccessedThroughProperty("ShadowResolutionSelector")]
		private TrackBar _ShadowResolutionSelector;

		// Token: 0x0400008D RID: 141
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x0400008E RID: 142
		[AccessedThroughProperty("VFXLabel")]
		private Label _VFXLabel;

		// Token: 0x0400008F RID: 143
		[AccessedThroughProperty("VFXSelector")]
		private TrackBar _VFXSelector;

		// Token: 0x04000090 RID: 144
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000091 RID: 145
		[AccessedThroughProperty("LSMLabel")]
		private Label _LSMLabel;

		// Token: 0x04000092 RID: 146
		[AccessedThroughProperty("LSMSelector")]
		private TrackBar _LSMSelector;

		// Token: 0x04000093 RID: 147
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x04000094 RID: 148
		[AccessedThroughProperty("RenderTargetLabel")]
		private Label _RenderTargetLabel;

		// Token: 0x04000095 RID: 149
		[AccessedThroughProperty("RenderTargetSelector")]
		private TrackBar _RenderTargetSelector;

		// Token: 0x04000096 RID: 150
		[AccessedThroughProperty("SignageLabel")]
		private Label _SignageLabel;

		// Token: 0x04000097 RID: 151
		[AccessedThroughProperty("SignageSelector")]
		private TrackBar _SignageSelector;

		// Token: 0x04000098 RID: 152
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x04000099 RID: 153
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x0400009A RID: 154
		[AccessedThroughProperty("PlayerGraffitiLabel")]
		private Label _PlayerGraffitiLabel;

		// Token: 0x0400009B RID: 155
		[AccessedThroughProperty("PlayerGraffitiSelector")]
		private TrackBar _PlayerGraffitiSelector;

		// Token: 0x0400009C RID: 156
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x0400009D RID: 157
		[AccessedThroughProperty("PlayerStatueLabel")]
		private Label _PlayerStatueLabel;

		// Token: 0x0400009E RID: 158
		[AccessedThroughProperty("PlayerStatueSelector")]
		private TrackBar _PlayerStatueSelector;

		// Token: 0x0400009F RID: 159
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x040000A0 RID: 160
		[AccessedThroughProperty("CharacterSharedLabel")]
		private Label _CharacterSharedLabel;

		// Token: 0x040000A1 RID: 161
		[AccessedThroughProperty("CharacterSharedSelector")]
		private TrackBar _CharacterSharedSelector;

		// Token: 0x040000A2 RID: 162
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		// Token: 0x040000A3 RID: 163
		[AccessedThroughProperty("VehicleSharedLabel")]
		private Label _VehicleSharedLabel;

		// Token: 0x040000A4 RID: 164
		[AccessedThroughProperty("VehicleSharedSelector")]
		private TrackBar _VehicleSharedSelector;

		// Token: 0x040000A5 RID: 165
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x040000A6 RID: 166
		[AccessedThroughProperty("ContactLabel")]
		private Label _ContactLabel;

		// Token: 0x040000A7 RID: 167
		[AccessedThroughProperty("ContactSelector")]
		private TrackBar _ContactSelector;

		// Token: 0x040000A8 RID: 168
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		// Token: 0x040000A9 RID: 169
		[AccessedThroughProperty("CharacterDNMLabel")]
		private Label _CharacterDNMLabel;

		// Token: 0x040000AA RID: 170
		[AccessedThroughProperty("CharacterDNMSelector")]
		private TrackBar _CharacterDNMSelector;

		// Token: 0x040000AB RID: 171
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		// Token: 0x040000AC RID: 172
		[AccessedThroughProperty("PlayerVehicleLabel")]
		private Label _PlayerVehicleLabel;

		// Token: 0x040000AD RID: 173
		[AccessedThroughProperty("PlayerVehicleSelector")]
		private TrackBar _PlayerVehicleSelector;

		// Token: 0x040000AE RID: 174
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		// Token: 0x040000AF RID: 175
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x040000B0 RID: 176
		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		// Token: 0x040000B1 RID: 177
		[AccessedThroughProperty("ParticleLODBiasLabel")]
		private Label _ParticleLODBiasLabel;

		// Token: 0x040000B2 RID: 178
		[AccessedThroughProperty("ParticleLODBiasSelector")]
		private TrackBar _ParticleLODBiasSelector;

		// Token: 0x040000B3 RID: 179
		[AccessedThroughProperty("Label65")]
		private Label _Label65;

		// Token: 0x040000B4 RID: 180
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		// Token: 0x040000B5 RID: 181
		[AccessedThroughProperty("ShadowQualityBiasLabel")]
		private Label _ShadowQualityBiasLabel;

		// Token: 0x040000B6 RID: 182
		[AccessedThroughProperty("ShadowQualityBiasSelector")]
		private TrackBar _ShadowQualityBiasSelector;

		// Token: 0x040000B7 RID: 183
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		// Token: 0x040000B8 RID: 184
		[AccessedThroughProperty("SunRenderQualityLabel")]
		private Label _SunRenderQualityLabel;

		// Token: 0x040000B9 RID: 185
		[AccessedThroughProperty("SunRenderQualitySelector")]
		private TrackBar _SunRenderQualitySelector;

		// Token: 0x040000BA RID: 186
		[AccessedThroughProperty("Label27")]
		private Label _Label27;

		// Token: 0x040000BB RID: 187
		[AccessedThroughProperty("ParticleSpaceAreaLabel")]
		private Label _ParticleSpaceAreaLabel;

		// Token: 0x040000BC RID: 188
		[AccessedThroughProperty("ParticleSpaceAreaSelector")]
		private TrackBar _ParticleSpaceAreaSelector;

		// Token: 0x040000BD RID: 189
		[AccessedThroughProperty("Label28")]
		private Label _Label28;

		// Token: 0x040000BE RID: 190
		[AccessedThroughProperty("FoliageDrawRadiusLabel")]
		private Label _FoliageDrawRadiusLabel;

		// Token: 0x040000BF RID: 191
		[AccessedThroughProperty("FoliageDrawRadiusSelector")]
		private TrackBar _FoliageDrawRadiusSelector;

		// Token: 0x040000C0 RID: 192
		[AccessedThroughProperty("Label29")]
		private Label _Label29;

		// Token: 0x040000C1 RID: 193
		[AccessedThroughProperty("ShadowFilterRadiusLabel")]
		private Label _ShadowFilterRadiusLabel;

		// Token: 0x040000C2 RID: 194
		[AccessedThroughProperty("ShadowFilterRadiusSelector")]
		private TrackBar _ShadowFilterRadiusSelector;

		// Token: 0x040000C3 RID: 195
		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		// Token: 0x040000C4 RID: 196
		[AccessedThroughProperty("ShadowDepthBiasLabel")]
		private Label _ShadowDepthBiasLabel;

		// Token: 0x040000C5 RID: 197
		[AccessedThroughProperty("ShadowDepthBiasSelector")]
		private TrackBar _ShadowDepthBiasSelector;

		// Token: 0x040000C6 RID: 198
		[AccessedThroughProperty("Label31")]
		private Label _Label31;

		// Token: 0x040000C7 RID: 199
		[AccessedThroughProperty("MaxMemoryCacheEntryLabel")]
		private Label _MaxMemoryCacheEntryLabel;

		// Token: 0x040000C8 RID: 200
		[AccessedThroughProperty("MaxMemoryCacheEntrySelector")]
		private TrackBar _MaxMemoryCacheEntrySelector;

		// Token: 0x040000C9 RID: 201
		[AccessedThroughProperty("Label32")]
		private Label _Label32;

		// Token: 0x040000CA RID: 202
		[AccessedThroughProperty("TextureStreamingMemoryLabel")]
		private Label _TextureStreamingMemoryLabel;

		// Token: 0x040000CB RID: 203
		[AccessedThroughProperty("TextureStreamingMemorySelector")]
		private TrackBar _TextureStreamingMemorySelector;

		// Token: 0x040000CC RID: 204
		[AccessedThroughProperty("Label33")]
		private Label _Label33;

		// Token: 0x040000CD RID: 205
		[AccessedThroughProperty("TexturePoolMemoryLabel")]
		private Label _TexturePoolMemoryLabel;

		// Token: 0x040000CE RID: 206
		[AccessedThroughProperty("TexturePoolMemorySelector")]
		private TrackBar _TexturePoolMemorySelector;

		// Token: 0x040000CF RID: 207
		[AccessedThroughProperty("Label38")]
		private Label _Label38;

		// Token: 0x040000D0 RID: 208
		[AccessedThroughProperty("MeshStreamingMemoryLabel")]
		private Label _MeshStreamingMemoryLabel;

		// Token: 0x040000D1 RID: 209
		[AccessedThroughProperty("MeshStreamingMemorySelector")]
		private TrackBar _MeshStreamingMemorySelector;

		// Token: 0x040000D2 RID: 210
		[AccessedThroughProperty("Label39")]
		private Label _Label39;

		// Token: 0x040000D3 RID: 211
		[AccessedThroughProperty("Label37")]
		private Label _Label37;

		// Token: 0x040000D4 RID: 212
		[AccessedThroughProperty("Label35")]
		private Label _Label35;

		// Token: 0x040000D5 RID: 213
		[AccessedThroughProperty("TextureCreationPerFrameBox")]
		private TextBox _TextureCreationPerFrameBox;

		// Token: 0x040000D6 RID: 214
		[AccessedThroughProperty("Label44")]
		private Label _Label44;

		// Token: 0x040000D7 RID: 215
		[AccessedThroughProperty("Label40")]
		private Label _Label40;

		// Token: 0x040000D8 RID: 216
		[AccessedThroughProperty("Label41")]
		private Label _Label41;

		// Token: 0x040000D9 RID: 217
		[AccessedThroughProperty("Label42")]
		private Label _Label42;

		// Token: 0x040000DA RID: 218
		[AccessedThroughProperty("DynamicShadowsBox")]
		private TextBox _DynamicShadowsBox;

		// Token: 0x040000DB RID: 219
		[AccessedThroughProperty("Label45")]
		private Label _Label45;

		// Token: 0x040000DC RID: 220
		[AccessedThroughProperty("Label46")]
		private Label _Label46;

		// Token: 0x040000DD RID: 221
		[AccessedThroughProperty("Label47")]
		private Label _Label47;

		// Token: 0x040000DE RID: 222
		[AccessedThroughProperty("Label48")]
		private Label _Label48;

		// Token: 0x040000DF RID: 223
		[AccessedThroughProperty("ShadowFadeDistanceBox")]
		private TextBox _ShadowFadeDistanceBox;

		// Token: 0x040000E0 RID: 224
		[AccessedThroughProperty("Label43")]
		private Label _Label43;

		// Token: 0x040000E1 RID: 225
		[AccessedThroughProperty("Label49")]
		private Label _Label49;

		// Token: 0x040000E2 RID: 226
		[AccessedThroughProperty("Label50")]
		private Label _Label50;

		// Token: 0x040000E3 RID: 227
		[AccessedThroughProperty("Label51")]
		private Label _Label51;

		// Token: 0x040000E4 RID: 228
		[AccessedThroughProperty("Label52")]
		private Label _Label52;

		// Token: 0x040000E5 RID: 229
		[AccessedThroughProperty("CharacterLODDistance1Box")]
		private TextBox _CharacterLODDistance1Box;

		// Token: 0x040000E6 RID: 230
		[AccessedThroughProperty("Label53")]
		private Label _Label53;

		// Token: 0x040000E7 RID: 231
		[AccessedThroughProperty("Label54")]
		private Label _Label54;

		// Token: 0x040000E8 RID: 232
		[AccessedThroughProperty("Label55")]
		private Label _Label55;

		// Token: 0x040000E9 RID: 233
		[AccessedThroughProperty("Label56")]
		private Label _Label56;

		// Token: 0x040000EA RID: 234
		[AccessedThroughProperty("CharacterLODDistance2Box")]
		private TextBox _CharacterLODDistance2Box;

		// Token: 0x040000EB RID: 235
		[AccessedThroughProperty("Label57")]
		private Label _Label57;

		// Token: 0x040000EC RID: 236
		[AccessedThroughProperty("Label58")]
		private Label _Label58;

		// Token: 0x040000ED RID: 237
		[AccessedThroughProperty("Label59")]
		private Label _Label59;

		// Token: 0x040000EE RID: 238
		[AccessedThroughProperty("Label60")]
		private Label _Label60;

		// Token: 0x040000EF RID: 239
		[AccessedThroughProperty("VehicleLODDistanceBox")]
		private TextBox _VehicleLODDistanceBox;

		// Token: 0x040000F0 RID: 240
		[AccessedThroughProperty("Label61")]
		private Label _Label61;

		// Token: 0x040000F1 RID: 241
		[AccessedThroughProperty("Label62")]
		private Label _Label62;

		// Token: 0x040000F2 RID: 242
		[AccessedThroughProperty("Label63")]
		private Label _Label63;

		// Token: 0x040000F3 RID: 243
		[AccessedThroughProperty("Label64")]
		private Label _Label64;

		// Token: 0x040000F4 RID: 244
		[AccessedThroughProperty("VehicleCullDistanceBox")]
		private TextBox _VehicleCullDistanceBox;

		// Token: 0x040000F5 RID: 245
		[AccessedThroughProperty("Label70")]
		private Label _Label70;

		// Token: 0x040000F6 RID: 246
		[AccessedThroughProperty("Label71")]
		private Label _Label71;

		// Token: 0x040000F7 RID: 247
		[AccessedThroughProperty("Label72")]
		private Label _Label72;

		// Token: 0x040000F8 RID: 248
		[AccessedThroughProperty("Label73")]
		private Label _Label73;

		// Token: 0x040000F9 RID: 249
		[AccessedThroughProperty("PedestrianCullDistanceBox")]
		private TextBox _PedestrianCullDistanceBox;

		// Token: 0x040000FA RID: 250
		[AccessedThroughProperty("Label66")]
		private Label _Label66;

		// Token: 0x040000FB RID: 251
		[AccessedThroughProperty("Label67")]
		private Label _Label67;

		// Token: 0x040000FC RID: 252
		[AccessedThroughProperty("Label68")]
		private Label _Label68;

		// Token: 0x040000FD RID: 253
		[AccessedThroughProperty("Label69")]
		private Label _Label69;

		// Token: 0x040000FE RID: 254
		[AccessedThroughProperty("PedestrianLODDistanceBox")]
		private TextBox _PedestrianLODDistanceBox;

		// Token: 0x040000FF RID: 255
		[AccessedThroughProperty("Label74")]
		private Label _Label74;

		// Token: 0x04000100 RID: 256
		[AccessedThroughProperty("Label75")]
		private Label _Label75;

		// Token: 0x04000101 RID: 257
		[AccessedThroughProperty("Label76")]
		private Label _Label76;

		// Token: 0x04000102 RID: 258
		[AccessedThroughProperty("Label77")]
		private Label _Label77;

		// Token: 0x04000103 RID: 259
		[AccessedThroughProperty("DriverCullDistanceBox")]
		private TextBox _DriverCullDistanceBox;

		// Token: 0x04000104 RID: 260
		[AccessedThroughProperty("Label78")]
		private Label _Label78;

		// Token: 0x04000105 RID: 261
		[AccessedThroughProperty("Label79")]
		private Label _Label79;

		// Token: 0x04000106 RID: 262
		[AccessedThroughProperty("Label80")]
		private Label _Label80;

		// Token: 0x04000107 RID: 263
		[AccessedThroughProperty("Label81")]
		private Label _Label81;

		// Token: 0x04000108 RID: 264
		[AccessedThroughProperty("DriverLODDistanceBox")]
		private TextBox _DriverLODDistanceBox;

		// Token: 0x04000109 RID: 265
		[AccessedThroughProperty("Label82")]
		private Label _Label82;

		// Token: 0x0400010A RID: 266
		[AccessedThroughProperty("Label83")]
		private Label _Label83;

		// Token: 0x0400010B RID: 267
		[AccessedThroughProperty("Label84")]
		private Label _Label84;

		// Token: 0x0400010C RID: 268
		[AccessedThroughProperty("Label85")]
		private Label _Label85;

		// Token: 0x0400010D RID: 269
		[AccessedThroughProperty("LCVehicleCullDistanceBox")]
		private TextBox _LCVehicleCullDistanceBox;

		// Token: 0x0400010E RID: 270
		[AccessedThroughProperty("Label86")]
		private Label _Label86;

		// Token: 0x0400010F RID: 271
		[AccessedThroughProperty("Label87")]
		private Label _Label87;

		// Token: 0x04000110 RID: 272
		[AccessedThroughProperty("Label88")]
		private Label _Label88;

		// Token: 0x04000111 RID: 273
		[AccessedThroughProperty("Label89")]
		private Label _Label89;

		// Token: 0x04000112 RID: 274
		[AccessedThroughProperty("LCVehicleLODDistanceBox")]
		private TextBox _LCVehicleLODDistanceBox;

		// Token: 0x04000113 RID: 275
		[AccessedThroughProperty("QualityBar")]
		private TrackBar _QualityBar;

		// Token: 0x04000114 RID: 276
		[AccessedThroughProperty("QualityLabel")]
		private Label _QualityLabel;

		// Token: 0x04000115 RID: 277
		[AccessedThroughProperty("ResX")]
		private TextBox _ResX;

		// Token: 0x04000116 RID: 278
		[AccessedThroughProperty("ResY")]
		private TextBox _ResY;

		// Token: 0x04000117 RID: 279
		[AccessedThroughProperty("ResYLabel")]
		private Label _ResYLabel;

		// Token: 0x04000118 RID: 280
		[AccessedThroughProperty("ResXLabel")]
		private Label _ResXLabel;

		// Token: 0x04000119 RID: 281
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		// Token: 0x0400011A RID: 282
		[AccessedThroughProperty("OtherBox")]
		private GroupBox _OtherBox;

		// Token: 0x0400011B RID: 283
		[AccessedThroughProperty("MouseAccelSelector")]
		private CheckBox _MouseAccelSelector;

		// Token: 0x0400011C RID: 284
		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		// Token: 0x0400011D RID: 285
		[AccessedThroughProperty("Label36")]
		private Label _Label36;

		// Token: 0x0400011E RID: 286
		[AccessedThroughProperty("EnableFullScreen")]
		private ComboBox _EnableFullScreen;

		// Token: 0x0400011F RID: 287
		private bool IsDraggingForm;

		// Token: 0x04000120 RID: 288
		private Point MousePos;
	}
}
