using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Advanced_APB_Launcher.My
{
	// Token: 0x02000004 RID: 4
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[StandardModule]
	[HideModuleName]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00003538 File Offset: 0x00001738
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00003554 File Offset: 0x00001754
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00003570 File Offset: 0x00001770
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000358C File Offset: 0x0000178C
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000035A8 File Offset: 0x000017A8
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000004 RID: 4
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000005 RID: 5
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000006 RID: 6
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x02000005 RID: 5
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyForms
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600000D RID: 13 RVA: 0x000035C4 File Offset: 0x000017C4
			// (set) Token: 0x0600000F RID: 15 RVA: 0x00003614 File Offset: 0x00001814
			public Launcher Launcher
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Launcher = MyProject.MyForms.Create__Instance__<Launcher>(this.m_Launcher);
					return this.m_Launcher;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Launcher;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Launcher>(ref this.m_Launcher);
					}
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600000E RID: 14 RVA: 0x000035EC File Offset: 0x000017EC
			// (set) Token: 0x06000010 RID: 16 RVA: 0x00003658 File Offset: 0x00001858
			public SettingsForm SettingsForm
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_SettingsForm = MyProject.MyForms.Create__Instance__<SettingsForm>(this.m_SettingsForm);
					return this.m_SettingsForm;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_SettingsForm;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SettingsForm>(ref this.m_SettingsForm);
					}
				}
			}

			// Token: 0x06000011 RID: 17 RVA: 0x0000369C File Offset: 0x0000189C
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				bool flag = Instance == null || Instance.IsDisposed;
				if (flag)
				{
					bool flag2 = MyProject.MyForms.m_FormBeingCreated != null;
					if (flag2)
					{
						bool flag3 = MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T));
						if (flag3)
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						});
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			// Token: 0x06000012 RID: 18 RVA: 0x000037D8 File Offset: 0x000019D8
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x06000013 RID: 19 RVA: 0x000020E5 File Offset: 0x000002E5
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			// Token: 0x06000014 RID: 20 RVA: 0x00003804 File Offset: 0x00001A04
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000015 RID: 21 RVA: 0x00003824 File Offset: 0x00001A24
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000016 RID: 22 RVA: 0x0000383C File Offset: 0x00001A3C
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x06000017 RID: 23 RVA: 0x00003858 File Offset: 0x00001A58
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x04000007 RID: 7
			public Launcher m_Launcher;

			// Token: 0x04000008 RID: 8
			public SettingsForm m_SettingsForm;

			// Token: 0x04000009 RID: 9
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;
		}

		// Token: 0x02000006 RID: 6
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x06000018 RID: 24 RVA: 0x00003804 File Offset: 0x00001A04
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000019 RID: 25 RVA: 0x00003824 File Offset: 0x00001A24
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600001A RID: 26 RVA: 0x00003870 File Offset: 0x00001A70
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x0600001B RID: 27 RVA: 0x00003858 File Offset: 0x00001A58
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x0600001C RID: 28 RVA: 0x0000388C File Offset: 0x00001A8C
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				bool flag = instance == null;
				T result;
				if (flag)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = instance;
				}
				return result;
			}

			// Token: 0x0600001D RID: 29 RVA: 0x000038B8 File Offset: 0x00001AB8
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x0600001E RID: 30 RVA: 0x000020E5 File Offset: 0x000002E5
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000007 RID: 7
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600001F RID: 31 RVA: 0x000038D8 File Offset: 0x00001AD8
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					bool flag = MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null;
					if (flag)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x06000020 RID: 32 RVA: 0x000020E5 File Offset: 0x000002E5
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x0400000A RID: 10
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;
		}
	}
}
