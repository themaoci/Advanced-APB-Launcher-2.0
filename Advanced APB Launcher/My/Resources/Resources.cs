using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Advanced_APB_Launcher.My.Resources
{
	// Token: 0x0200000B RID: 11
	[DebuggerNonUserCode]
	[HideModuleName]
	[StandardModule]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal sealed class Resources
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000060B4 File Offset: 0x000042B4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = object.ReferenceEquals(Resources.resourceMan, null);
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Advanced_APB_Launcher.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000060FC File Offset: 0x000042FC
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002213 File Offset: 0x00000413
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00006114 File Offset: 0x00004314
		internal static Bitmap status_banner_1_
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("status banner 1.", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00006148 File Offset: 0x00004348
		internal static Bitmap Status_Logo
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Status Logo", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x0400002E RID: 46
		private static ResourceManager resourceMan;

		// Token: 0x0400002F RID: 47
		private static CultureInfo resourceCulture;
	}
}
