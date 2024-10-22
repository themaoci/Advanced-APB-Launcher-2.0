using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Advanced_APB_Launcher.My
{
	// Token: 0x0200000C RID: 12
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x0600007D RID: 125 RVA: 0x0000617C File Offset: 0x0000437C
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			bool saveMySettingsOnExit = MyProject.Application.SaveMySettingsOnExit;
			if (saveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000061A8 File Offset: 0x000043A8
		public static MySettings Default
		{
			get
			{
				bool flag = !MySettings.addedHandler;
				if (flag)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						flag = !MySettings.addedHandler;
						if (flag)
						{
							MyProject.Application.Shutdown += MySettings.AutoSaveSettings;
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00006228 File Offset: 0x00004428
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000224D File Offset: 0x0000044D
		[DefaultSettingValue("English")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string LanguageSelectorSetting
		{
			get
			{
				return Conversions.ToString(this["LanguageSelectorSetting"]);
			}
			set
			{
				this["LanguageSelectorSetting"] = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000624C File Offset: 0x0000444C
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000225E File Offset: 0x0000045E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool NoMoviesSetting
		{
			get
			{
				return Conversions.ToBoolean(this["NoMoviesSetting"]);
			}
			set
			{
				this["NoMoviesSetting"] = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00006270 File Offset: 0x00004470
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002274 File Offset: 0x00000474
		[UserScopedSetting]
		[DefaultSettingValue("No Change")]
		[DebuggerNonUserCode]
		public string ResolutionSetting
		{
			get
			{
				return Conversions.ToString(this["ResolutionSetting"]);
			}
			set
			{
				this["ResolutionSetting"] = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00006294 File Offset: 0x00004494
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00002285 File Offset: 0x00000485
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("No Change")]
		public string FullscreenSetting
		{
			get
			{
				return Conversions.ToString(this["FullscreenSetting"]);
			}
			set
			{
				this["FullscreenSetting"] = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000062B8 File Offset: 0x000044B8
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002296 File Offset: 0x00000496
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool VsyncSetting
		{
			get
			{
				return Conversions.ToBoolean(this["VsyncSetting"]);
			}
			set
			{
				this["VsyncSetting"] = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000062DC File Offset: 0x000044DC
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000022AC File Offset: 0x000004AC
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool SmoothFrameRateSetting
		{
			get
			{
				return Conversions.ToBoolean(this["SmoothFrameRateSetting"]);
			}
			set
			{
				this["SmoothFrameRateSetting"] = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00006300 File Offset: 0x00004500
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000022C2 File Offset: 0x000004C2
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool StaticDecalsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["StaticDecalsSetting"]);
			}
			set
			{
				this["StaticDecalsSetting"] = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00006324 File Offset: 0x00004524
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000022D8 File Offset: 0x000004D8
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool DynamicShadowsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["DynamicShadowsSetting"]);
			}
			set
			{
				this["DynamicShadowsSetting"] = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00006348 File Offset: 0x00004548
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000022EE File Offset: 0x000004EE
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool LEShadowsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["LEShadowsSetting"]);
			}
			set
			{
				this["LEShadowsSetting"] = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000636C File Offset: 0x0000456C
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002304 File Offset: 0x00000504
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool BlobShadowsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["BlobShadowsSetting"]);
			}
			set
			{
				this["BlobShadowsSetting"] = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00006390 File Offset: 0x00004590
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000231A File Offset: 0x0000051A
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool AOSetting
		{
			get
			{
				return Conversions.ToBoolean(this["AOSetting"]);
			}
			set
			{
				this["AOSetting"] = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000063B4 File Offset: 0x000045B4
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002330 File Offset: 0x00000530
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool BloomSetting
		{
			get
			{
				return Conversions.ToBoolean(this["BloomSetting"]);
			}
			set
			{
				this["BloomSetting"] = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000063D8 File Offset: 0x000045D8
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002346 File Offset: 0x00000546
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool DistortionSetting
		{
			get
			{
				return Conversions.ToBoolean(this["DistortionSetting"]);
			}
			set
			{
				this["DistortionSetting"] = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000099 RID: 153 RVA: 0x000063FC File Offset: 0x000045FC
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000235C File Offset: 0x0000055C
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool TrilinearSetting
		{
			get
			{
				return Conversions.ToBoolean(this["TrilinearSetting"]);
			}
			set
			{
				this["TrilinearSetting"] = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00006420 File Offset: 0x00004620
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002372 File Offset: 0x00000572
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool LQHealthHUDSetting
		{
			get
			{
				return Conversions.ToBoolean(this["LQHealthHUDSetting"]);
			}
			set
			{
				this["LQHealthHUDSetting"] = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00006444 File Offset: 0x00004644
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002388 File Offset: 0x00000588
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool RenderEyelashesSetting
		{
			get
			{
				return Conversions.ToBoolean(this["RenderEyelashesSetting"]);
			}
			set
			{
				this["RenderEyelashesSetting"] = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00006468 File Offset: 0x00004668
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000239E File Offset: 0x0000059E
		[DebuggerNonUserCode]
		[DefaultSettingValue("Disabled")]
		[UserScopedSetting]
		public string AnisotropySetting
		{
			get
			{
				return Conversions.ToString(this["AnisotropySetting"]);
			}
			set
			{
				this["AnisotropySetting"] = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000648C File Offset: 0x0000468C
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000023AF File Offset: 0x000005AF
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool DynamicDecalsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["DynamicDecalsSetting"]);
			}
			set
			{
				this["DynamicDecalsSetting"] = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000064B0 File Offset: 0x000046B0
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000023C5 File Offset: 0x000005C5
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool LevelParticleSettings
		{
			get
			{
				return Conversions.ToBoolean(this["LevelParticleSettings"]);
			}
			set
			{
				this["LevelParticleSettings"] = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x000064D4 File Offset: 0x000046D4
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000023DB File Offset: 0x000005DB
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool DynamicLightsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["DynamicLightsSetting"]);
			}
			set
			{
				this["DynamicLightsSetting"] = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000064F8 File Offset: 0x000046F8
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x000023F1 File Offset: 0x000005F1
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool CDLightsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["CDLightsSetting"]);
			}
			set
			{
				this["CDLightsSetting"] = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000651C File Offset: 0x0000471C
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00002407 File Offset: 0x00000607
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool DirectionalLightmapsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["DirectionalLightmapsSetting"]);
			}
			set
			{
				this["DirectionalLightmapsSetting"] = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00006540 File Offset: 0x00004740
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000241D File Offset: 0x0000061D
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool MotionBlurSetting
		{
			get
			{
				return Conversions.ToBoolean(this["MotionBlurSetting"]);
			}
			set
			{
				this["MotionBlurSetting"] = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00006564 File Offset: 0x00004764
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002433 File Offset: 0x00000633
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool DepthOfFieldSetting
		{
			get
			{
				return Conversions.ToBoolean(this["DepthOfFieldSetting"]);
			}
			set
			{
				this["DepthOfFieldSetting"] = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00006588 File Offset: 0x00004788
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002449 File Offset: 0x00000649
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool QualityBloomSetting
		{
			get
			{
				return Conversions.ToBoolean(this["QualityBloomSetting"]);
			}
			set
			{
				this["QualityBloomSetting"] = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000065AC File Offset: 0x000047AC
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000245F File Offset: 0x0000065F
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool DPDistortionSetting
		{
			get
			{
				return Conversions.ToBoolean(this["DPDistortionSetting"]);
			}
			set
			{
				this["DPDistortionSetting"] = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x000065D0 File Offset: 0x000047D0
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002475 File Offset: 0x00000675
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool STLeavesSetting
		{
			get
			{
				return Conversions.ToBoolean(this["STLeavesSetting"]);
			}
			set
			{
				this["STLeavesSetting"] = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000065F4 File Offset: 0x000047F4
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000248B File Offset: 0x0000068B
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool STFrondsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["STFrondsSetting"]);
			}
			set
			{
				this["STFrondsSetting"] = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00006618 File Offset: 0x00004818
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000024A1 File Offset: 0x000006A1
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool StreamTexturesSetting
		{
			get
			{
				return Conversions.ToBoolean(this["StreamTexturesSetting"]);
			}
			set
			{
				this["StreamTexturesSetting"] = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000663C File Offset: 0x0000483C
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000024B7 File Offset: 0x000006B7
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool LensFlaresSetting
		{
			get
			{
				return Conversions.ToBoolean(this["LensFlaresSetting"]);
			}
			set
			{
				this["LensFlaresSetting"] = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00006660 File Offset: 0x00004860
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000024CD File Offset: 0x000006CD
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool FogVolumesSetting
		{
			get
			{
				return Conversions.ToBoolean(this["FogVolumesSetting"]);
			}
			set
			{
				this["FogVolumesSetting"] = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00006684 File Offset: 0x00004884
		// (set) Token: 0x060000BE RID: 190 RVA: 0x000024E3 File Offset: 0x000006E3
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool FPRTargetsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["FPRTargetsSetting"]);
			}
			set
			{
				this["FPRTargetsSetting"] = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000BF RID: 191 RVA: 0x000066A8 File Offset: 0x000048A8
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x000024F9 File Offset: 0x000006F9
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool ThreadLagSetting
		{
			get
			{
				return Conversions.ToBoolean(this["ThreadLagSetting"]);
			}
			set
			{
				this["ThreadLagSetting"] = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x000066CC File Offset: 0x000048CC
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x0000250F File Offset: 0x0000070F
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool UpscaleSPSetting
		{
			get
			{
				return Conversions.ToBoolean(this["UpscaleSPSetting"]);
			}
			set
			{
				this["UpscaleSPSetting"] = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000066F0 File Offset: 0x000048F0
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002525 File Offset: 0x00000725
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool HighPolyCharsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["HighPolyCharsSetting"]);
			}
			set
			{
				this["HighPolyCharsSetting"] = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00006714 File Offset: 0x00004914
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000253B File Offset: 0x0000073B
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool VSMShadowsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["VSMShadowsSetting"]);
			}
			set
			{
				this["VSMShadowsSetting"] = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00006738 File Offset: 0x00004938
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00002551 File Offset: 0x00000751
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool PCFShadowsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["PCFShadowsSetting"]);
			}
			set
			{
				this["PCFShadowsSetting"] = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000675C File Offset: 0x0000495C
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002567 File Offset: 0x00000767
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool BetterShadowsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["BetterShadowsSetting"]);
			}
			set
			{
				this["BetterShadowsSetting"] = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00006780 File Offset: 0x00004980
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000257D File Offset: 0x0000077D
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool ForegroundShadowsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["ForegroundShadowsSetting"]);
			}
			set
			{
				this["ForegroundShadowsSetting"] = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000067A4 File Offset: 0x000049A4
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002593 File Offset: 0x00000793
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool SimpleVehicleMaterialsSetting
		{
			get
			{
				return Conversions.ToBoolean(this["SimpleVehicleMaterialsSetting"]);
			}
			set
			{
				this["SimpleVehicleMaterialsSetting"] = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000067C8 File Offset: 0x000049C8
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x000025A9 File Offset: 0x000007A9
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool DXTLocalCharacterSetting
		{
			get
			{
				return Conversions.ToBoolean(this["DXTLocalCharacterSetting"]);
			}
			set
			{
				this["DXTLocalCharacterSetting"] = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000067EC File Offset: 0x000049EC
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000025BF File Offset: 0x000007BF
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool DXTLocalVehicleSetting
		{
			get
			{
				return Conversions.ToBoolean(this["DXTLocalVehicleSetting"]);
			}
			set
			{
				this["DXTLocalVehicleSetting"] = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00006810 File Offset: 0x00004A10
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000025D5 File Offset: 0x000007D5
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool DXTOtherCharacterSetting
		{
			get
			{
				return Conversions.ToBoolean(this["DXTOtherCharacterSetting"]);
			}
			set
			{
				this["DXTOtherCharacterSetting"] = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00006834 File Offset: 0x00004A34
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000025EB File Offset: 0x000007EB
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool DXTOtherVehicleSetting
		{
			get
			{
				return Conversions.ToBoolean(this["DXTOtherVehicleSetting"]);
			}
			set
			{
				this["DXTOtherVehicleSetting"] = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00006858 File Offset: 0x00004A58
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002601 File Offset: 0x00000801
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool DXTNormalSetting
		{
			get
			{
				return Conversions.ToBoolean(this["DXTNormalSetting"]);
			}
			set
			{
				this["DXTNormalSetting"] = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000687C File Offset: 0x00004A7C
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00002617 File Offset: 0x00000817
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		[DebuggerNonUserCode]
		public int UnknownSetting
		{
			get
			{
				return Conversions.ToInteger(this["UnknownSetting"]);
			}
			set
			{
				this["UnknownSetting"] = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000068A0 File Offset: 0x00004AA0
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000262D File Offset: 0x0000082D
		[DebuggerNonUserCode]
		[DefaultSettingValue("16 (Default)")]
		[UserScopedSetting]
		public string UnknownLabelSetting
		{
			get
			{
				return Conversions.ToString(this["UnknownLabelSetting"]);
			}
			set
			{
				this["UnknownLabelSetting"] = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000068C4 File Offset: 0x00004AC4
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000263E File Offset: 0x0000083E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("2")]
		public int EnvironmentSetting
		{
			get
			{
				return Conversions.ToInteger(this["EnvironmentSetting"]);
			}
			set
			{
				this["EnvironmentSetting"] = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000DF RID: 223 RVA: 0x000068E8 File Offset: 0x00004AE8
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002654 File Offset: 0x00000854
		[DefaultSettingValue("2")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public int PropSetting
		{
			get
			{
				return Conversions.ToInteger(this["PropSetting"]);
			}
			set
			{
				this["PropSetting"] = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000690C File Offset: 0x00004B0C
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000266A File Offset: 0x0000086A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("4")]
		public int CharacterSetting
		{
			get
			{
				return Conversions.ToInteger(this["CharacterSetting"]);
			}
			set
			{
				this["CharacterSetting"] = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00006930 File Offset: 0x00004B30
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002680 File Offset: 0x00000880
		[UserScopedSetting]
		[DefaultSettingValue("3")]
		[DebuggerNonUserCode]
		public int VehicleSetting
		{
			get
			{
				return Conversions.ToInteger(this["VehicleSetting"]);
			}
			set
			{
				this["VehicleSetting"] = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00006954 File Offset: 0x00004B54
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002696 File Offset: 0x00000896
		[DefaultSettingValue("3")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int PedestrianSetting
		{
			get
			{
				return Conversions.ToInteger(this["PedestrianSetting"]);
			}
			set
			{
				this["PedestrianSetting"] = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00006978 File Offset: 0x00004B78
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000026AC File Offset: 0x000008AC
		[DefaultSettingValue("3")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int CityVehicleSetting
		{
			get
			{
				return Conversions.ToInteger(this["CityVehicleSetting"]);
			}
			set
			{
				this["CityVehicleSetting"] = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000699C File Offset: 0x00004B9C
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000026C2 File Offset: 0x000008C2
		[DefaultSettingValue("2")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int PickupSetting
		{
			get
			{
				return Conversions.ToInteger(this["PickupSetting"]);
			}
			set
			{
				this["PickupSetting"] = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000069C0 File Offset: 0x00004BC0
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000026D8 File Offset: 0x000008D8
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("2")]
		public int PrimitiveSetting
		{
			get
			{
				return Conversions.ToInteger(this["PrimitiveSetting"]);
			}
			set
			{
				this["PrimitiveSetting"] = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000069E4 File Offset: 0x00004BE4
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000026EE File Offset: 0x000008EE
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		[DebuggerNonUserCode]
		public int UISetting
		{
			get
			{
				return Conversions.ToInteger(this["UISetting"]);
			}
			set
			{
				this["UISetting"] = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00006A08 File Offset: 0x00004C08
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002704 File Offset: 0x00000904
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("1")]
		public int VFXSetting
		{
			get
			{
				return Conversions.ToInteger(this["VFXSetting"]);
			}
			set
			{
				this["VFXSetting"] = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00006A2C File Offset: 0x00004C2C
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000271A File Offset: 0x0000091A
		[DefaultSettingValue("0")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int LSMSetting
		{
			get
			{
				return Conversions.ToInteger(this["LSMSetting"]);
			}
			set
			{
				this["LSMSetting"] = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00006A50 File Offset: 0x00004C50
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002730 File Offset: 0x00000930
		[UserScopedSetting]
		[DefaultSettingValue("1")]
		[DebuggerNonUserCode]
		public int RenderTargetSetting
		{
			get
			{
				return Conversions.ToInteger(this["RenderTargetSetting"]);
			}
			set
			{
				this["RenderTargetSetting"] = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00006A74 File Offset: 0x00004C74
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002746 File Offset: 0x00000946
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("2")]
		public int SignageSetting
		{
			get
			{
				return Conversions.ToInteger(this["SignageSetting"]);
			}
			set
			{
				this["SignageSetting"] = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00006A98 File Offset: 0x00004C98
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000275C File Offset: 0x0000095C
		[DebuggerNonUserCode]
		[DefaultSettingValue("2")]
		[UserScopedSetting]
		public int PlayerGraffitiSetting
		{
			get
			{
				return Conversions.ToInteger(this["PlayerGraffitiSetting"]);
			}
			set
			{
				this["PlayerGraffitiSetting"] = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00006ABC File Offset: 0x00004CBC
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002772 File Offset: 0x00000972
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		[UserScopedSetting]
		public int PlayerStatueSetting
		{
			get
			{
				return Conversions.ToInteger(this["PlayerStatueSetting"]);
			}
			set
			{
				this["PlayerStatueSetting"] = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00006AE0 File Offset: 0x00004CE0
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002788 File Offset: 0x00000988
		[DefaultSettingValue("2")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public int CharacterSharedSetting
		{
			get
			{
				return Conversions.ToInteger(this["CharacterSharedSetting"]);
			}
			set
			{
				this["CharacterSharedSetting"] = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00006B04 File Offset: 0x00004D04
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000279E File Offset: 0x0000099E
		[DebuggerNonUserCode]
		[DefaultSettingValue("2")]
		[UserScopedSetting]
		public int VehicleSharedSetting
		{
			get
			{
				return Conversions.ToInteger(this["VehicleSharedSetting"]);
			}
			set
			{
				this["VehicleSharedSetting"] = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00006B28 File Offset: 0x00004D28
		// (set) Token: 0x06000100 RID: 256 RVA: 0x000027B4 File Offset: 0x000009B4
		[DefaultSettingValue("4")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public int ContactSetting
		{
			get
			{
				return Conversions.ToInteger(this["ContactSetting"]);
			}
			set
			{
				this["ContactSetting"] = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00006B4C File Offset: 0x00004D4C
		// (set) Token: 0x06000102 RID: 258 RVA: 0x000027CA File Offset: 0x000009CA
		[DefaultSettingValue("64 (Default)")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string EnvironmentLabelSetting
		{
			get
			{
				return Conversions.ToString(this["EnvironmentLabelSetting"]);
			}
			set
			{
				this["EnvironmentLabelSetting"] = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00006B70 File Offset: 0x00004D70
		// (set) Token: 0x06000104 RID: 260 RVA: 0x000027DB File Offset: 0x000009DB
		[UserScopedSetting]
		[DefaultSettingValue("64 (Default)")]
		[DebuggerNonUserCode]
		public string PropLabelSetting
		{
			get
			{
				return Conversions.ToString(this["PropLabelSetting"]);
			}
			set
			{
				this["PropLabelSetting"] = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00006B94 File Offset: 0x00004D94
		// (set) Token: 0x06000106 RID: 262 RVA: 0x000027EC File Offset: 0x000009EC
		[UserScopedSetting]
		[DefaultSettingValue("256 (Default)")]
		[DebuggerNonUserCode]
		public string CharacterLabelSetting
		{
			get
			{
				return Conversions.ToString(this["CharacterLabelSetting"]);
			}
			set
			{
				this["CharacterLabelSetting"] = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00006BB8 File Offset: 0x00004DB8
		// (set) Token: 0x06000108 RID: 264 RVA: 0x000027FD File Offset: 0x000009FD
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("128 (Default)")]
		public string VehicleLabelSetting
		{
			get
			{
				return Conversions.ToString(this["VehicleLabelSetting"]);
			}
			set
			{
				this["VehicleLabelSetting"] = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00006BDC File Offset: 0x00004DDC
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000280E File Offset: 0x00000A0E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("128 (Default)")]
		public string PedestrianLabelSetting
		{
			get
			{
				return Conversions.ToString(this["PedestrianLabelSetting"]);
			}
			set
			{
				this["PedestrianLabelSetting"] = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00006C00 File Offset: 0x00004E00
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000281F File Offset: 0x00000A1F
		[DefaultSettingValue("128 (Default)")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string CityVehicleLabelSetting
		{
			get
			{
				return Conversions.ToString(this["CityVehicleLabelSetting"]);
			}
			set
			{
				this["CityVehicleLabelSetting"] = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00006C24 File Offset: 0x00004E24
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002830 File Offset: 0x00000A30
		[DebuggerNonUserCode]
		[DefaultSettingValue("64 (Default)")]
		[UserScopedSetting]
		public string PickupLabelSetting
		{
			get
			{
				return Conversions.ToString(this["PickupLabelSetting"]);
			}
			set
			{
				this["PickupLabelSetting"] = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00006C48 File Offset: 0x00004E48
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002841 File Offset: 0x00000A41
		[UserScopedSetting]
		[DefaultSettingValue("64 (Default)")]
		[DebuggerNonUserCode]
		public string PrimitiveLabelSetting
		{
			get
			{
				return Conversions.ToString(this["PrimitiveLabelSetting"]);
			}
			set
			{
				this["PrimitiveLabelSetting"] = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00006C6C File Offset: 0x00004E6C
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002852 File Offset: 0x00000A52
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("1024 (Default)")]
		public string UILabelSetting
		{
			get
			{
				return Conversions.ToString(this["UILabelSetting"]);
			}
			set
			{
				this["UILabelSetting"] = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00006C90 File Offset: 0x00004E90
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002863 File Offset: 0x00000A63
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		public int ShadowResolutionSetting
		{
			get
			{
				return Conversions.ToInteger(this["ShadowResolutionSetting"]);
			}
			set
			{
				this["ShadowResolutionSetting"] = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00006CB4 File Offset: 0x00004EB4
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00002879 File Offset: 0x00000A79
		[DefaultSettingValue("128 (Default)")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string ShadowResolutionLabelSetting
		{
			get
			{
				return Conversions.ToString(this["ShadowResolutionLabelSetting"]);
			}
			set
			{
				this["ShadowResolutionLabelSetting"] = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00006CD8 File Offset: 0x00004ED8
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000288A File Offset: 0x00000A8A
		[DefaultSettingValue("32 (Default)")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string VFXLabelSetting
		{
			get
			{
				return Conversions.ToString(this["VFXLabelSetting"]);
			}
			set
			{
				this["VFXLabelSetting"] = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00006CFC File Offset: 0x00004EFC
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000289B File Offset: 0x00000A9B
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("16 (Default)")]
		public string LSMLabelSetting
		{
			get
			{
				return Conversions.ToString(this["LSMLabelSetting"]);
			}
			set
			{
				this["LSMLabelSetting"] = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00006D20 File Offset: 0x00004F20
		// (set) Token: 0x0600011C RID: 284 RVA: 0x000028AC File Offset: 0x00000AAC
		[DefaultSettingValue("32 (Default)")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string RenderTargetLabelSetting
		{
			get
			{
				return Conversions.ToString(this["RenderTargetLabelSetting"]);
			}
			set
			{
				this["RenderTargetLabelSetting"] = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00006D44 File Offset: 0x00004F44
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000028BD File Offset: 0x00000ABD
		[UserScopedSetting]
		[DefaultSettingValue("64 (Default)")]
		[DebuggerNonUserCode]
		public string SignageLabelSetting
		{
			get
			{
				return Conversions.ToString(this["SignageLabelSetting"]);
			}
			set
			{
				this["SignageLabelSetting"] = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00006D68 File Offset: 0x00004F68
		// (set) Token: 0x06000120 RID: 288 RVA: 0x000028CE File Offset: 0x00000ACE
		[UserScopedSetting]
		[DefaultSettingValue("64 (Default)")]
		[DebuggerNonUserCode]
		public string PlayerGraffitiLabelSetting
		{
			get
			{
				return Conversions.ToString(this["PlayerGraffitiLabelSetting"]);
			}
			set
			{
				this["PlayerGraffitiLabelSetting"] = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00006D8C File Offset: 0x00004F8C
		// (set) Token: 0x06000122 RID: 290 RVA: 0x000028DF File Offset: 0x00000ADF
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("16 (Default)")]
		public string PlayerStatueLabelSetting
		{
			get
			{
				return Conversions.ToString(this["PlayerStatueLabelSetting"]);
			}
			set
			{
				this["PlayerStatueLabelSetting"] = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00006DB0 File Offset: 0x00004FB0
		// (set) Token: 0x06000124 RID: 292 RVA: 0x000028F0 File Offset: 0x00000AF0
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("64 (Default)")]
		public string CharacterSharedLabelSetting
		{
			get
			{
				return Conversions.ToString(this["CharacterSharedLabelSetting"]);
			}
			set
			{
				this["CharacterSharedLabelSetting"] = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00006DD4 File Offset: 0x00004FD4
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002901 File Offset: 0x00000B01
		[DefaultSettingValue("64 (Default)")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string VehicleSharedLabelSetting
		{
			get
			{
				return Conversions.ToString(this["VehicleSharedLabelSetting"]);
			}
			set
			{
				this["VehicleSharedLabelSetting"] = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00006DF8 File Offset: 0x00004FF8
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00002912 File Offset: 0x00000B12
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("256 (Default)")]
		public string ContactLabelSetting
		{
			get
			{
				return Conversions.ToString(this["ContactLabelSetting"]);
			}
			set
			{
				this["ContactLabelSetting"] = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00006E1C File Offset: 0x0000501C
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002923 File Offset: 0x00000B23
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("8")]
		public int CharacterDNMSetting
		{
			get
			{
				return Conversions.ToInteger(this["CharacterDNMSetting"]);
			}
			set
			{
				this["CharacterDNMSetting"] = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00006E40 File Offset: 0x00005040
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00002939 File Offset: 0x00000B39
		[DefaultSettingValue("512 (Default)")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string CharacterDNMLabelSetting
		{
			get
			{
				return Conversions.ToString(this["CharacterDNMLabelSetting"]);
			}
			set
			{
				this["CharacterDNMLabelSetting"] = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00006E64 File Offset: 0x00005064
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000294A File Offset: 0x00000B4A
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("1")]
		public int PlayerVehicleSetting
		{
			get
			{
				return Conversions.ToInteger(this["PlayerVehicleSetting"]);
			}
			set
			{
				this["PlayerVehicleSetting"] = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00006E88 File Offset: 0x00005088
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00002960 File Offset: 0x00000B60
		[DefaultSettingValue("Low Quality (Default)")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string PlayerVehicleLabelSetting
		{
			get
			{
				return Conversions.ToString(this["PlayerVehicleLabelSetting"]);
			}
			set
			{
				this["PlayerVehicleLabelSetting"] = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00006EAC File Offset: 0x000050AC
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00002971 File Offset: 0x00000B71
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int ParticleLODBiasSetting
		{
			get
			{
				return Conversions.ToInteger(this["ParticleLODBiasSetting"]);
			}
			set
			{
				this["ParticleLODBiasSetting"] = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00006ED0 File Offset: 0x000050D0
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00002987 File Offset: 0x00000B87
		[DebuggerNonUserCode]
		[DefaultSettingValue("Low Quality (Default)")]
		[UserScopedSetting]
		public string ParticleLODBiasLabelSetting
		{
			get
			{
				return Conversions.ToString(this["ParticleLODBiasLabelSetting"]);
			}
			set
			{
				this["ParticleLODBiasLabelSetting"] = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00006EF4 File Offset: 0x000050F4
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00002998 File Offset: 0x00000B98
		[DefaultSettingValue("0")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public int ShadowQualityBiasSetting
		{
			get
			{
				return Conversions.ToInteger(this["ShadowQualityBiasSetting"]);
			}
			set
			{
				this["ShadowQualityBiasSetting"] = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00006F18 File Offset: 0x00005118
		// (set) Token: 0x06000138 RID: 312 RVA: 0x000029AE File Offset: 0x00000BAE
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("Low Quality (Default)")]
		public string ShadowQualityBiasLabelSetting
		{
			get
			{
				return Conversions.ToString(this["ShadowQualityBiasLabelSetting"]);
			}
			set
			{
				this["ShadowQualityBiasLabelSetting"] = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00006F3C File Offset: 0x0000513C
		// (set) Token: 0x0600013A RID: 314 RVA: 0x000029BF File Offset: 0x00000BBF
		[DefaultSettingValue("0")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int SunRenderQualitySetting
		{
			get
			{
				return Conversions.ToInteger(this["SunRenderQualitySetting"]);
			}
			set
			{
				this["SunRenderQualitySetting"] = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00006F60 File Offset: 0x00005160
		// (set) Token: 0x0600013C RID: 316 RVA: 0x000029D5 File Offset: 0x00000BD5
		[DebuggerNonUserCode]
		[DefaultSettingValue("Low Quality (Default)")]
		[UserScopedSetting]
		public string SunRenderQualityLabelSetting
		{
			get
			{
				return Conversions.ToString(this["SunRenderQualityLabelSetting"]);
			}
			set
			{
				this["SunRenderQualityLabelSetting"] = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00006F84 File Offset: 0x00005184
		// (set) Token: 0x0600013E RID: 318 RVA: 0x000029E6 File Offset: 0x00000BE6
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("9")]
		public int ParticleSpaceAreaSeting
		{
			get
			{
				return Conversions.ToInteger(this["ParticleSpaceAreaSeting"]);
			}
			set
			{
				this["ParticleSpaceAreaSeting"] = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00006FA8 File Offset: 0x000051A8
		// (set) Token: 0x06000140 RID: 320 RVA: 0x000029FC File Offset: 0x00000BFC
		[UserScopedSetting]
		[DefaultSettingValue("25000 (Default)")]
		[DebuggerNonUserCode]
		public string ParticleSpaceAreaLabelSeting
		{
			get
			{
				return Conversions.ToString(this["ParticleSpaceAreaLabelSeting"]);
			}
			set
			{
				this["ParticleSpaceAreaLabelSeting"] = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00006FCC File Offset: 0x000051CC
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002A0D File Offset: 0x00000C0D
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		public int FoliageDrawRadiusSetting
		{
			get
			{
				return Conversions.ToInteger(this["FoliageDrawRadiusSetting"]);
			}
			set
			{
				this["FoliageDrawRadiusSetting"] = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00006FF0 File Offset: 0x000051F0
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00002A23 File Offset: 0x00000C23
		[DefaultSettingValue("Low Quality (Default)")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string FoliageDrawRadiusLabelSetting
		{
			get
			{
				return Conversions.ToString(this["FoliageDrawRadiusLabelSetting"]);
			}
			set
			{
				this["FoliageDrawRadiusLabelSetting"] = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00007014 File Offset: 0x00005214
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002A34 File Offset: 0x00000C34
		[DefaultSettingValue("0")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public int ShadowFilterRadiusSetting
		{
			get
			{
				return Conversions.ToInteger(this["ShadowFilterRadiusSetting"]);
			}
			set
			{
				this["ShadowFilterRadiusSetting"] = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00007038 File Offset: 0x00005238
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002A4A File Offset: 0x00000C4A
		[DefaultSettingValue("Low Quality (Default)")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string ShadowFilterRadiusSettingLabelSetting
		{
			get
			{
				return Conversions.ToString(this["ShadowFilterRadiusSettingLabelSetting"]);
			}
			set
			{
				this["ShadowFilterRadiusSettingLabelSetting"] = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000705C File Offset: 0x0000525C
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00002A5B File Offset: 0x00000C5B
		[DefaultSettingValue("0")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int ShadowDepthBiasSetting
		{
			get
			{
				return Conversions.ToInteger(this["ShadowDepthBiasSetting"]);
			}
			set
			{
				this["ShadowDepthBiasSetting"] = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00007080 File Offset: 0x00005280
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002A71 File Offset: 0x00000C71
		[DefaultSettingValue("Low Quality (Default)")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string ShadowDepthBiasLabelSetting
		{
			get
			{
				return Conversions.ToString(this["ShadowDepthBiasLabelSetting"]);
			}
			set
			{
				this["ShadowDepthBiasLabelSetting"] = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000070A4 File Offset: 0x000052A4
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002A82 File Offset: 0x00000C82
		[DefaultSettingValue("1")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int MaxMemoryCacheEntrySetting
		{
			get
			{
				return Conversions.ToInteger(this["MaxMemoryCacheEntrySetting"]);
			}
			set
			{
				this["MaxMemoryCacheEntrySetting"] = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000070C8 File Offset: 0x000052C8
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002A98 File Offset: 0x00000C98
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Medium Quality (Default)")]
		public string MaxMemoryCacheEntryLabelSetting
		{
			get
			{
				return Conversions.ToString(this["MaxMemoryCacheEntryLabelSetting"]);
			}
			set
			{
				this["MaxMemoryCacheEntryLabelSetting"] = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000070EC File Offset: 0x000052EC
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002AA9 File Offset: 0x00000CA9
		[DebuggerNonUserCode]
		[DefaultSettingValue("4")]
		[UserScopedSetting]
		public int TextureStreamingMemorySetting
		{
			get
			{
				return Conversions.ToInteger(this["TextureStreamingMemorySetting"]);
			}
			set
			{
				this["TextureStreamingMemorySetting"] = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00007110 File Offset: 0x00005310
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00002ABF File Offset: 0x00000CBF
		[DefaultSettingValue("Maximum Quality (Default)")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string TextureStreamingMemoryLabelSetting
		{
			get
			{
				return Conversions.ToString(this["TextureStreamingMemoryLabelSetting"]);
			}
			set
			{
				this["TextureStreamingMemoryLabelSetting"] = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00007134 File Offset: 0x00005334
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00002AD0 File Offset: 0x00000CD0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("1")]
		public int TexturePoolMemorySetting
		{
			get
			{
				return Conversions.ToInteger(this["TexturePoolMemorySetting"]);
			}
			set
			{
				this["TexturePoolMemorySetting"] = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00007158 File Offset: 0x00005358
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002AE6 File Offset: 0x00000CE6
		[DefaultSettingValue("High Quality (Default)")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string TexturePoolMemoryLabelSetting
		{
			get
			{
				return Conversions.ToString(this["TexturePoolMemoryLabelSetting"]);
			}
			set
			{
				this["TexturePoolMemoryLabelSetting"] = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0000717C File Offset: 0x0000537C
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00002AF7 File Offset: 0x00000CF7
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("4")]
		public int MeshStreamingMemorySetting
		{
			get
			{
				return Conversions.ToInteger(this["MeshStreamingMemorySetting"]);
			}
			set
			{
				this["MeshStreamingMemorySetting"] = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000071A0 File Offset: 0x000053A0
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002B0D File Offset: 0x00000D0D
		[UserScopedSetting]
		[DefaultSettingValue("Maximum Quality (Default)")]
		[DebuggerNonUserCode]
		public string MeshStreamingMemoryLabelSetting
		{
			get
			{
				return Conversions.ToString(this["MeshStreamingMemoryLabelSetting"]);
			}
			set
			{
				this["MeshStreamingMemoryLabelSetting"] = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000071C4 File Offset: 0x000053C4
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002B1E File Offset: 0x00000D1E
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("10")]
		public string TextureCreationPerFrameSetting
		{
			get
			{
				return Conversions.ToString(this["TextureCreationPerFrameSetting"]);
			}
			set
			{
				this["TextureCreationPerFrameSetting"] = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000071E8 File Offset: 0x000053E8
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00002B2F File Offset: 0x00000D2F
		[DefaultSettingValue("10")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string MaxDynamicShadowsSetting
		{
			get
			{
				return Conversions.ToString(this["MaxDynamicShadowsSetting"]);
			}
			set
			{
				this["MaxDynamicShadowsSetting"] = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0000720C File Offset: 0x0000540C
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002B40 File Offset: 0x00000D40
		[DefaultSettingValue("65")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string ShadowFadeDistanceSetting
		{
			get
			{
				return Conversions.ToString(this["ShadowFadeDistanceSetting"]);
			}
			set
			{
				this["ShadowFadeDistanceSetting"] = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00007230 File Offset: 0x00005430
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002B51 File Offset: 0x00000D51
		[DebuggerNonUserCode]
		[DefaultSettingValue("5")]
		[UserScopedSetting]
		public string CharacterLODDistance1Setting
		{
			get
			{
				return Conversions.ToString(this["CharacterLODDistance1Setting"]);
			}
			set
			{
				this["CharacterLODDistance1Setting"] = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00007254 File Offset: 0x00005454
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00002B62 File Offset: 0x00000D62
		[DefaultSettingValue("15")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string CharacterLODDistance2Setting
		{
			get
			{
				return Conversions.ToString(this["CharacterLODDistance2Setting"]);
			}
			set
			{
				this["CharacterLODDistance2Setting"] = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00007278 File Offset: 0x00005478
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00002B73 File Offset: 0x00000D73
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("25")]
		public string VehicleLODDistanceSetting
		{
			get
			{
				return Conversions.ToString(this["VehicleLODDistanceSetting"]);
			}
			set
			{
				this["VehicleLODDistanceSetting"] = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000729C File Offset: 0x0000549C
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00002B84 File Offset: 0x00000D84
		[DefaultSettingValue("100")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string VehicleCullDistanceSetting
		{
			get
			{
				return Conversions.ToString(this["VehicleCullDistanceSetting"]);
			}
			set
			{
				this["VehicleCullDistanceSetting"] = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000072C0 File Offset: 0x000054C0
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00002B95 File Offset: 0x00000D95
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("3")]
		public string PedestrianLODDistanceSetting
		{
			get
			{
				return Conversions.ToString(this["PedestrianLODDistanceSetting"]);
			}
			set
			{
				this["PedestrianLODDistanceSetting"] = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000072E4 File Offset: 0x000054E4
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002BA6 File Offset: 0x00000DA6
		[DebuggerNonUserCode]
		[DefaultSettingValue("50")]
		[UserScopedSetting]
		public string PedestrianCullDistanceSetting
		{
			get
			{
				return Conversions.ToString(this["PedestrianCullDistanceSetting"]);
			}
			set
			{
				this["PedestrianCullDistanceSetting"] = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00007308 File Offset: 0x00005508
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002BB7 File Offset: 0x00000DB7
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("3")]
		public string DriverLODDistanceSetting
		{
			get
			{
				return Conversions.ToString(this["DriverLODDistanceSetting"]);
			}
			set
			{
				this["DriverLODDistanceSetting"] = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000732C File Offset: 0x0000552C
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[DefaultSettingValue("70")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string DriverCullDistanceSetting
		{
			get
			{
				return Conversions.ToString(this["DriverCullDistanceSetting"]);
			}
			set
			{
				this["DriverCullDistanceSetting"] = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00007350 File Offset: 0x00005550
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002BD9 File Offset: 0x00000DD9
		[DefaultSettingValue("10")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string LCVehicleLODDistanceSetting
		{
			get
			{
				return Conversions.ToString(this["LCVehicleLODDistanceSetting"]);
			}
			set
			{
				this["LCVehicleLODDistanceSetting"] = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00007374 File Offset: 0x00005574
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00002BEA File Offset: 0x00000DEA
		[DefaultSettingValue("70")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string LCVehicleCullDistanceSetting
		{
			get
			{
				return Conversions.ToString(this["LCVehicleCullDistanceSetting"]);
			}
			set
			{
				this["LCVehicleCullDistanceSetting"] = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00007398 File Offset: 0x00005598
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002BFB File Offset: 0x00000DFB
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("1")]
		public int QualityBarSetting
		{
			get
			{
				return Conversions.ToInteger(this["QualityBarSetting"]);
			}
			set
			{
				this["QualityBarSetting"] = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000073BC File Offset: 0x000055BC
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002C11 File Offset: 0x00000E11
		[UserScopedSetting]
		[DefaultSettingValue("Default")]
		[DebuggerNonUserCode]
		public string QualityLabelSetting
		{
			get
			{
				return Conversions.ToString(this["QualityLabelSetting"]);
			}
			set
			{
				this["QualityLabelSetting"] = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000073E0 File Offset: 0x000055E0
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002C22 File Offset: 0x00000E22
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string ResXSetting
		{
			get
			{
				return Conversions.ToString(this["ResXSetting"]);
			}
			set
			{
				this["ResXSetting"] = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00007404 File Offset: 0x00005604
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002C33 File Offset: 0x00000E33
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string ResYSetting
		{
			get
			{
				return Conversions.ToString(this["ResYSetting"]);
			}
			set
			{
				this["ResYSetting"] = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00007428 File Offset: 0x00005628
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002C44 File Offset: 0x00000E44
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool MouseAccelSetting
		{
			get
			{
				return Conversions.ToBoolean(this["MouseAccelSetting"]);
			}
			set
			{
				this["MouseAccelSetting"] = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000744C File Offset: 0x0000564C
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002C5A File Offset: 0x00000E5A
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string Setting
		{
			get
			{
				return Conversions.ToString(this["Setting"]);
			}
			set
			{
				this["Setting"] = value;
			}
		}

		// Token: 0x04000030 RID: 48
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04000031 RID: 49
		private static bool addedHandler;

		// Token: 0x04000032 RID: 50
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
