//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Xml.Linq;

//namespace Advanced_APB_Launcher.My
//{
//	// Token: 0x02000008 RID: 8
//	[EditorBrowsable(EditorBrowsableState.Never)]
//	[CompilerGenerated]
//	[DebuggerNonUserCode]
//	internal sealed class InternalXmlHelper
//	{
//		// Token: 0x06000021 RID: 33 RVA: 0x000020E5 File Offset: 0x000002E5
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		private InternalXmlHelper()
//		{
//		}

//		// Token: 0x17000009 RID: 9
//		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000390C File Offset: 0x00001B0C
//		// (set) Token: 0x06000023 RID: 35 RVA: 0x0000396C File Offset: 0x00001B6C
//		public static string Value
//		{
//			get
//			{
//				try
//				{
//					IEnumerator<XElement> enumerator = source.GetEnumerator();
//					if (enumerator.MoveNext())
//					{
//						XElement xelement = enumerator.Current;
//						return xelement.Value;
//					}
//				}
//				finally
//				{
//					IEnumerator<XElement> enumerator;
//					bool flag = enumerator != null;
//					if (flag)
//					{
//						enumerator.Dispose();
//					}
//				}
//				return null;
//			}
//			set
//			{
//				try
//				{
//					IEnumerator<XElement> enumerator = source.GetEnumerator();
//					if (enumerator.MoveNext())
//					{
//						XElement xelement = enumerator.Current;
//						xelement.Value = value;
//					}
//				}
//				finally
//				{
//					IEnumerator<XElement> enumerator;
//					bool flag = enumerator != null;
//					if (flag)
//					{
//						enumerator.Dispose();
//					}
//				}
//			}
//		}

//		// Token: 0x1700000A RID: 10
//		// (get) Token: 0x06000024 RID: 36 RVA: 0x000039CC File Offset: 0x00001BCC
//		// (set) Token: 0x06000025 RID: 37 RVA: 0x00003A34 File Offset: 0x00001C34
//		public static string AttributeValue
//		{
//			get
//			{
//				try
//				{
//					IEnumerator<XElement> enumerator = source.GetEnumerator();
//					if (enumerator.MoveNext())
//					{
//						XElement xelement = enumerator.Current;
//						return (string)xelement.Attribute(name);
//					}
//				}
//				finally
//				{
//					IEnumerator<XElement> enumerator;
//					bool flag = enumerator != null;
//					if (flag)
//					{
//						enumerator.Dispose();
//					}
//				}
//				return null;
//			}
//			set
//			{
//				try
//				{
//					IEnumerator<XElement> enumerator = source.GetEnumerator();
//					if (enumerator.MoveNext())
//					{
//						XElement xelement = enumerator.Current;
//						xelement.SetAttributeValue(name, value);
//					}
//				}
//				finally
//				{
//					IEnumerator<XElement> enumerator;
//					bool flag = enumerator != null;
//					if (flag)
//					{
//						enumerator.Dispose();
//					}
//				}
//			}
//		}

//		// Token: 0x06000028 RID: 40 RVA: 0x00003AB4 File Offset: 0x00001CB4
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		public static XAttribute CreateAttribute(XName name, object value)
//		{
//			bool flag = value == null;
//			XAttribute result;
//			if (flag)
//			{
//				result = null;
//			}
//			else
//			{
//				result = new XAttribute(name, RuntimeHelpers.GetObjectValue(value));
//			}
//			return result;
//		}

//		// Token: 0x06000029 RID: 41 RVA: 0x00003AE0 File Offset: 0x00001CE0
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		public static XAttribute CreateNamespaceAttribute(XName name, XNamespace ns)
//		{
//			XAttribute xattribute = new XAttribute(name, ns.NamespaceName);
//			xattribute.AddAnnotation(ns);
//			return xattribute;
//		}

//		// Token: 0x0600002A RID: 42 RVA: 0x00003B08 File Offset: 0x00001D08
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		public static object RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, object obj)
//		{
//			bool flag = obj != null;
//			if (flag)
//			{
//				XElement xelement = obj as XElement;
//				flag = (xelement != null);
//				if (flag)
//				{
//					return InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, xelement);
//				}
//				IEnumerable enumerable = obj as IEnumerable;
//				flag = (enumerable != null);
//				if (flag)
//				{
//					return InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, enumerable);
//				}
//			}
//			return obj;
//		}

//		// Token: 0x0600002B RID: 43 RVA: 0x00003B68 File Offset: 0x00001D68
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		public static IEnumerable RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, IEnumerable obj)
//		{
//			bool flag = obj != null;
//			IEnumerable result;
//			if (flag)
//			{
//				IEnumerable<XElement> enumerable = obj as IEnumerable<XElement>;
//				flag = (enumerable != null);
//				if (flag)
//				{
//					result = enumerable.Select(new Func<XElement, XElement>(new InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessXElement));
//				}
//				else
//				{
//					result = obj.Cast<object>().Select(new Func<object, object>(new InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessObject));
//				}
//			}
//			else
//			{
//				result = obj;
//			}
//			return result;
//		}

//		// Token: 0x0600002C RID: 44 RVA: 0x00003BDC File Offset: 0x00001DDC
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		public static XElement RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, XElement e)
//		{
//			bool flag = e != null;
//			checked
//			{
//				if (flag)
//				{
//					XAttribute nextAttribute;
//					for (XAttribute xattribute = e.FirstAttribute; xattribute != null; xattribute = nextAttribute)
//					{
//						nextAttribute = xattribute.NextAttribute;
//						flag = xattribute.IsNamespaceDeclaration;
//						if (flag)
//						{
//							XNamespace xnamespace = xattribute.Annotation<XNamespace>();
//							string localName = xattribute.Name.LocalName;
//							flag = (xnamespace != null);
//							if (flag)
//							{
//								bool flag2 = inScopePrefixes != null && inScopeNs != null;
//								if (flag2)
//								{
//									int num = inScopePrefixes.Length - 1;
//									int num2 = 0;
//									int num3 = num;
//									int num4 = num2;
//									XNamespace right;
//									for (;;)
//									{
//										int num5 = num4;
//										int num6 = num3;
//										if (num5 > num6)
//										{
//											goto IL_C0;
//										}
//										string value = inScopePrefixes[num4];
//										right = inScopeNs[num4];
//										flag2 = localName.Equals(value);
//										if (flag2)
//										{
//											break;
//										}
//										num4++;
//									}
//									flag = (xnamespace == right);
//									if (flag)
//									{
//										xattribute.Remove();
//									}
//									xattribute = null;
//								}
//								IL_C0:
//								flag2 = (xattribute != null);
//								if (flag2)
//								{
//									flag = (attributes != null);
//									bool flag3;
//									if (flag)
//									{
//										int num7 = attributes.Count - 1;
//										int num8 = 0;
//										int num9 = num7;
//										int num10 = num8;
//										XNamespace xnamespace2;
//										for (;;)
//										{
//											int num11 = num10;
//											int num6 = num9;
//											if (num11 > num6)
//											{
//												goto IL_15D;
//											}
//											XAttribute xattribute2 = attributes[num10];
//											string localName2 = xattribute2.Name.LocalName;
//											xnamespace2 = xattribute2.Annotation<XNamespace>();
//											flag2 = (xnamespace2 != null);
//											if (flag2)
//											{
//												flag = localName.Equals(localName2);
//												if (flag)
//												{
//													break;
//												}
//											}
//											num10++;
//										}
//										flag3 = (xnamespace == xnamespace2);
//										if (flag3)
//										{
//											xattribute.Remove();
//										}
//										xattribute = null;
//									}
//									IL_15D:
//									flag3 = (xattribute != null);
//									if (flag3)
//									{
//										xattribute.Remove();
//										attributes.Add(xattribute);
//									}
//								}
//							}
//						}
//					}
//				}
//				return e;
//			}
//		}

//		// Token: 0x02000009 RID: 9
//		[CompilerGenerated]
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		[DebuggerNonUserCode]
//		private sealed class RemoveNamespaceAttributesClosure
//		{
//			// Token: 0x0600002D RID: 45 RVA: 0x000020FD File Offset: 0x000002FD
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			internal RemoveNamespaceAttributesClosure(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes)
//			{
//				this.m_inScopePrefixes = inScopePrefixes;
//				this.m_inScopeNs = inScopeNs;
//				this.m_attributes = attributes;
//			}

//			// Token: 0x0600002E RID: 46 RVA: 0x00003D80 File Offset: 0x00001F80
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			internal XElement ProcessXElement(XElement elem)
//			{
//				return InternalXmlHelper.RemoveNamespaceAttributes(this.m_inScopePrefixes, this.m_inScopeNs, this.m_attributes, elem);
//			}

//			// Token: 0x0600002F RID: 47 RVA: 0x00003DAC File Offset: 0x00001FAC
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			internal object ProcessObject(object obj)
//			{
//				XElement xelement = obj as XElement;
//				bool flag = xelement != null;
//				object result;
//				if (flag)
//				{
//					result = InternalXmlHelper.RemoveNamespaceAttributes(this.m_inScopePrefixes, this.m_inScopeNs, this.m_attributes, xelement);
//				}
//				else
//				{
//					result = obj;
//				}
//				return result;
//			}

//			// Token: 0x0400000B RID: 11
//			private readonly string[] m_inScopePrefixes;

//			// Token: 0x0400000C RID: 12
//			private readonly XNamespace[] m_inScopeNs;

//			// Token: 0x0400000D RID: 13
//			private readonly List<XAttribute> m_attributes;
//		}
//	}
//}
