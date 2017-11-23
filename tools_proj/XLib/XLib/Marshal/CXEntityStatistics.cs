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
    
    
    public class CXEntityStatistics {
        
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct RowData {
			int uid;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string name;
			uint presentid;
			int type;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string tag;
			int fightgroup;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string summongroup;
			float walkspeed;
			float runspeed;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
			float[] floatheight;
			float rotatespeed;
			int attackspeed;
			int skillcd;
			float attackprob;
			float sight;
			float fighttogetherdis;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string belocked;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string inbornbuff;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string maxsuperarmor;
			bool weakstatus;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string superarmorbrokenbuff;
			int superarmorrecoveryvalue;
			int superarmorrecoverymax;
			int attackbase;
			int magicattackbase;
			float maxhp;
			int mobaexp;
			int mobaexprange;
			bool mobakillneedhint;
			int posindex;
			int hpsection;
			bool iswander;
			bool block;
			bool dynamicblock;
			bool usinggeneralcutscene;
			bool soloshow;
			bool endshow;
			int fov;
			float aistarttime;
			float aiactiongap;
			bool isfixedincd;
			int fashiontemplate;
			bool highlight;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string usemymesh;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string extrareward;
			int aihit;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string aibehavior;
			int initenmity;
			bool alwayshpbar;
			bool hidename;
			float ratioleft;
			float ratioright;
			float ratioidle;
			float ratiodistance;
			float ratioskill;
			float ratioexp;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string navigation;
			int isnavpingpong;
			bool hideinminimap;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string access;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string samebillboard;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string pandoradropids;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string dropids;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			string bigmeleepoints;

			public int UID { get { return uid; } }

			public string Name { get { return name; } }

			public uint PresentID { get { return presentid; } }

			public int Type { get { return type; } }

			public string Tag { get { return tag; } }

			public int Fightgroup { get { return fightgroup; } }

			public string SummonGroup { get { return summongroup; } }

			public float WalkSpeed { get { return walkspeed; } }

			public float RunSpeed { get { return runspeed; } }

			float[] Floatheight { 
				get { 
					if (floatheight.Length == 16) {
					List<float> list = new List<float>();
					for (int i = floatheight.Length - 1; i >= 0; i--)
					{
						if (floatheight[i] != -1) list.Add(floatheight[i]);
					}
					floatheight = list.ToArray();
					}
					 return floatheight;
				}
			}

			public float RotateSpeed { get { return rotatespeed; } }

			public int AttackSpeed { get { return attackspeed; } }

			public int SkillCD { get { return skillcd; } }

			public float AttackProb { get { return attackprob; } }

			public float Sight { get { return sight; } }

			public float FightTogetherDis { get { return fighttogetherdis; } }

			public string BeLocked { get { return belocked; } }

			public string InBornBuff { get { return inbornbuff; } }

			public string MaxSuperArmor { get { return maxsuperarmor; } }

			public bool WeakStatus { get { return weakstatus; } }

			public string SuperArmorBrokenBuff { get { return superarmorbrokenbuff; } }

			public int SuperArmorRecoveryValue { get { return superarmorrecoveryvalue; } }

			public int SuperArmorRecoveryMax { get { return superarmorrecoverymax; } }

			public int AttackBase { get { return attackbase; } }

			public int MagicAttackBase { get { return magicattackbase; } }

			public float MaxHP { get { return maxhp; } }

			public int MobaExp { get { return mobaexp; } }

			public int MobaExpRange { get { return mobaexprange; } }

			public bool MobaKillNeedHint { get { return mobakillneedhint; } }

			public int PosIndex { get { return posindex; } }

			public int HpSection { get { return hpsection; } }

			public bool IsWander { get { return iswander; } }

			public bool Block { get { return block; } }

			public bool DynamicBlock { get { return dynamicblock; } }

			public bool UsingGeneralCutscene { get { return usinggeneralcutscene; } }

			public bool SoloShow { get { return soloshow; } }

			public bool EndShow { get { return endshow; } }

			public int Fov { get { return fov; } }

			public float AIStartTime { get { return aistarttime; } }

			public float AIActionGap { get { return aiactiongap; } }

			public bool IsFixedInCD { get { return isfixedincd; } }

			public int FashionTemplate { get { return fashiontemplate; } }

			public bool Highlight { get { return highlight; } }

			public string UseMyMesh { get { return usemymesh; } }

			public string ExtraReward { get { return extrareward; } }

			public int Aihit { get { return aihit; } }

			public string AiBehavior { get { return aibehavior; } }

			public int InitEnmity { get { return initenmity; } }

			public bool AlwaysHpBar { get { return alwayshpbar; } }

			public bool HideName { get { return hidename; } }

			public float Ratioleft { get { return ratioleft; } }

			public float Ratioright { get { return ratioright; } }

			public float Ratioidle { get { return ratioidle; } }

			public float Ratiodistance { get { return ratiodistance; } }

			public float Ratioskill { get { return ratioskill; } }

			public float Ratioexp { get { return ratioexp; } }

			public string Navigation { get { return navigation; } }

			public int IsNavPingpong { get { return isnavpingpong; } }

			public bool HideInMiniMap { get { return hideinminimap; } }

			public string Access { get { return access; } }

			public string SameBillBoard { get { return samebillboard; } }

			public string PandoraDropIDs { get { return pandoradropids; } }

			public string DropIDs { get { return dropids; } }

			public string BigMeleePoints { get { return bigmeleepoints; } }
		}


		[DllImport("XTable")]
		static extern void iGetXEntityStatisticsRow(int idx, ref RowData row);

		[DllImport("XTable")]
		static extern int iGetXEntityStatisticsLength();
        
        private static RowData m_data;
        
        public static int length {
            get {
				return iGetXEntityStatisticsLength();
            }
        }
        
        public static RowData GetRow(int idx) {
			iGetXEntityStatisticsRow(idx, ref m_data);
			return m_data;
        }
    }
}
