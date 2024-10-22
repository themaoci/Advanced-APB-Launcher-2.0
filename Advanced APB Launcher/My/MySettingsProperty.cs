using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Advanced_APB_Launcher.My
{
	// Token: 0x0200000D RID: 13
	[HideModuleName]
	[StandardModule]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal sealed class MySettingsProperty
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00007470 File Offset: 0x00005670
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
