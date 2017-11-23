//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.8784
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace XTable {
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    
    
    public class CFashionSuit {
        
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct RowData {
			uint suitid;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string suitname;
			int suitquality;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string suitatlas;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string suiticon;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
			int[] fashionid;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string effect2;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string effect3;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string effect4;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string effect5;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string effect6;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string effect7;
			int all1;
			int all2;
			int all3;
			int all4;
			int all0sp;
			int all1sp;
			int all2sp;
			int all3sp;
			int all4sp;
			bool nosale;
			int showlevel;
			int overall;

			public uint SuitID { get { return suitid; } }

			public string SuitName { get { return suitname; } }

			public int SuitQuality { get { return suitquality; } }

			public string SuitAtlas { get { return suitatlas; } }

			public string SuitIcon { get { return suiticon; } }

			int[] Fashionid { 
				get { 
					if (fashionid.Length == 16) {
					List<int> list = new List<int>();
					for (int i = fashionid.Length - 1; i >= 0; i--)
					{
						if (fashionid[i] != -1) list.Add(fashionid[i]);
					}
					fashionid = list.ToArray();
					}
					 return fashionid;
				}
			}

			public string Effect2 { get { return effect2; } }

			public string Effect3 { get { return effect3; } }

			public string Effect4 { get { return effect4; } }

			public string Effect5 { get { return effect5; } }

			public string Effect6 { get { return effect6; } }

			public string Effect7 { get { return effect7; } }

			public int All1 { get { return all1; } }

			public int All2 { get { return all2; } }

			public int All3 { get { return all3; } }

			public int All4 { get { return all4; } }

			public int All0SP { get { return all0sp; } }

			public int All1SP { get { return all1sp; } }

			public int All2SP { get { return all2sp; } }

			public int All3SP { get { return all3sp; } }

			public int All4SP { get { return all4sp; } }

			public bool NoSale { get { return nosale; } }

			public int ShowLevel { get { return showlevel; } }

			public int OverAll { get { return overall; } }
		}


		[DllImport("XTable")]
		static extern void iGetFashionSuitRow(int idx, ref RowData row);

		[DllImport("XTable")]
		static extern int iGetFashionSuitLength();
        
        private static RowData m_data;
        
        public static int length {
            get {
				return iGetFashionSuitLength();
            }
        }
        
        public static RowData GetRow(int idx) {
			iGetFashionSuitRow(idx, ref m_data);
			return m_data;
        }
    }
}
