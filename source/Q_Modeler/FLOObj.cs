using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Globalization;
using System.Diagnostics;
using System.Reflection;

namespace Q_Modeler
{
	/// <summary>
	/// FLOObj에 대한 요약 설명입니다.
	/// </summary>
	[Serializable]
	public abstract class FLOObj
	{
		#region public enum
		public enum OBJTYPE	{Buf,Ope,Res,Cal,Dmd,Stt,B2C,B2D,B2O,C2R,O2B,O2C,O2O,R2O,NULL,NumberOfObjType}
		public enum BOMTYPE	{Normal,Alternate,NULL,NumberOfBomType}
		public enum OPETYPE {Normal,CoByProd,AltRouting,NULL,NumberOfOpeType}
		public enum RESTYPE {Normal,Simultaneous,Alternate,NULL,NumberOfResType}
		public enum CALTYPE {REP_QTY,AVAILABLE_CAPACITY,YIELD,MIN_ON_HAND,MAX_ON_HAND,EFFICIENCY,NULL,NumberOfCalType}
		public enum CPTTYPE {EVERYDAY,DAYS_OF_WEEK,EVERY_N_DAYS,DAY_OF_MONTH,DAY_OF_YEAR,NULL,NumberOfCPTType}
		public enum CDWTYPE {Mo,Tu,We,Th,Fr,Sa,Su,NULL,NumberOfCDWType}
		#endregion

		#region const variables
		public const string OPPRE = "O_";
		public const string RTPRE = "RT_";
		public const string RSPRE = "R_";
		public const string BMPRE = "B_";
		public const string RCPRE = "RC_";
		public const string SCPRE = "SC_";
		public const string NCPRE = "NC_";
		public const string XCPRE = "XC_";
		public const string ECPRE = "EC_";
		public const string YCPRE = "YC_";
		public const string DEMANDNAME = "DEMAND";
		#endregion

		#region static variables
		public static string WORKCENTER = "WORKCENTER";
		#endregion

		#region local variables
		private int			seq;
		private string		objname;
		private string		oldname;
		private string		disname;
		private OBJTYPE		objtype;
		private bool		selected;
		private	DRWObj		drwobj;
		private ArrayList	uplist;
		private ArrayList	dnlist;
		private ArrayList	ltlist;
		private ArrayList	rtlist;
		#endregion

		#region local variables accessor
		public int Seq
		{
			get { return seq; }
			set { seq = value; }
		}

		public DRWObj Drwobj
		{
			get { return drwobj; }
			set { drwobj = value; }
		}

		public FLOObj UPlist(int n)
		{
			return (FLOObj)uplist[n];
		}

		public virtual ArrayList Uplist
		{
			get { return uplist; }
			set { uplist = value; }
		}

		public virtual ArrayList Dnlist
		{
			get { return dnlist; }
			set { dnlist = value; }
		}

		public FLOObj DNlist(int n)
		{
			return (FLOObj)dnlist[n];
		}

		public virtual ArrayList Ltlist
		{
			get { return ltlist; }
			set { ltlist = value; }
		}

		public FLOObj LTlist(int n)
		{
			if(ltlist.Count < 1)
				return null;

			return (FLOObj)ltlist[n];
		}

		public virtual ArrayList Rtlist
		{
			get { return rtlist; }
			set { rtlist = value; }
		}

		public FLOObj RTlist(int n)
		{
			return (FLOObj)rtlist[n];
		}

		public string Objname
		{
			get { return objname; }
			set { objname = value; }
		}

		public string Oldname
		{
			get { return oldname; }
			set { oldname = value; }
		}

		public OBJTYPE Objtype
		{
			get { return objtype; }
			set { objtype = value; }
		}

		public bool Selected
		{
			get { return selected; }
			set { selected = value; }
		}

		public string Disname
		{
			get { return this.disname; }
			set { this.disname = value; }
		}

		public bool Switchtext
		{
			get { return this.Drwobj.Switchtext; }
			set { this.Drwobj.Switchtext = value; }
		}
		#endregion

		#region flosubobj virtual variables accessor
		public virtual string Buf_item
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Buf_site
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Buf_stage
		{
			get { return null; }
			set { value = value; }
		}

		public virtual int Buf_sellable
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Buf_isresponsebuffer
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Buf_isproductionplanbuffer
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual BOMTYPE B2O_constype
		{
			get { return BOMTYPE.NULL; }
			set { value = value; }
		}

		public virtual string B2O_altbuf
		{
			get { return null; }
			set { value = value; }
		}

		public virtual int B2O_cosqty
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int B2O_altpriority
		{
			get { return -1; }
			set { value = value; }
		}
		public virtual OPETYPE O2B_prodtype
		{
			get { return OPETYPE.NULL; }
			set { value = value; }
		}

		public virtual int O2B_prodqty
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int O2B_altpriority
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int O2B_altproportion
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int O2B_basedqty
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int O2B_cobyprod
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int O2B_cobyprodqty
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int O2B_cobyprodrate
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual string Cal_calendarpre
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Cal_calendar
		{
			get { return null; }
			set { value = value; }
		}

		public virtual CALTYPE Cal_caltype
		{
			get { return CALTYPE.NULL; }
			set { value = value; }
		}

		public virtual CPTTYPE Cal_pattern
		{
			get { return CPTTYPE.NULL; }
			set { value = value; }
		}

		public virtual CDWTYPE Cal_dayofweek
		{
			get { return CDWTYPE.NULL; }
			set { value = value; }
		}

		public virtual int Cal_numofday
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual ArrayList Cal_details
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Dmd_sorderid
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Dmd_ordereddate
		{
			get { return null; }
			set { value = value; }
		}

		public virtual int Dmd_orderqty
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Dmd_orderpriority
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Dmd_latenesstolerance
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual string Ope_operationpre
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Ope_operation
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Ope_operationsite
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Ope_routingpre
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Ope_routing
		{
			get { return null; }
			set { value = value; }
		}

		public virtual int Ope_operationseq
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Ope_runtime
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Ope_releasefence
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual string Res_resourcepre
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Res_resource
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Res_resourcesite
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string O2C_effresource
		{
			get { return null; }
			set { value = value; }
		}

		public virtual int O2O_prodqty
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int R2O_qtyper
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int R2O_altpriority
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual RESTYPE R2O_restype
		{
			get { return RESTYPE.NULL; }
			set { value = value; }
		}

		public virtual string R2O_altresource
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Stt_instanceid
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Stt_enterprise
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Stt_supplychainid
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Stt_organizationid
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Stt_workcenter
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Stt_planid
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Stt_planstartdate
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Stt_planenddate
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Stt_plancurrentdate
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Stt_bucketname
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Stt_boundaryid
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Stt_effstartdate
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Stt_bucketsizeuom
		{
			get { return null; }
			set { value = value; }
		}

		public virtual string Stt_mpa_solver
		{
			get { return null; }
			set { value = value; }
		}

		public virtual int Stt_bitposition
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Stt_engine_id
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Stt_firstdayofweek
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Stt_patternsequence
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Stt_bucketsize
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Stt_numberofbuckets
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Stt_keep_or_better
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Stt_export_unpegged_material
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Stt_export_unpegged_capacity
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Stt_export_date_range
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Stt_export_source_peggings
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual int Stt_use_transport_capacity
		{
			get { return -1; }
			set { value = value; }
		}

		public virtual ArrayList Stt_lplayers
		{
			get { return null; }
			set { value = value; }
		}

		public virtual ArrayList Stt_oblevels
		{
			get { return null; }
			set { value = value; }
		}
		#endregion

		#region init
		public virtual void Init()
		{
		}

		public virtual void Init(int n)
		{
		}
		#endregion
		
		#region popup
		public virtual bool PopUp(FLOMgr mgr, FormFLO f)
		{
			return false;
		}

		public virtual bool PopUp(DrawArea drawArea, FormFLOStt f)
		{
			return false;
		}

		public virtual bool PopUp(FLOMgr mgr, FormFLO f, int x, int y)
		{
			return false;
		}	
		public virtual void UpdateCon()
		{
		}

		public virtual int CheckLockType()
		{
			return -1;
		}

		public virtual bool CheckFLOLogic(FLOObj s, FLOObj e)
		{
			return false;
		}
		#endregion

		#region dump & nomalize
		/// <summary>
		/// Dump (for debugging)
		/// </summary>
		public virtual void Dump()
		{
			Trace.WriteLine("");
			Trace.WriteLine(this.GetType().Name);
			Trace.WriteLine("Selected = " + selected.ToString(CultureInfo.InvariantCulture));
		}

		/// <summary>
		/// Normalize object.
		/// Call this function in the end of object resizing.
		/// </summary>
		public virtual void Normalize()
		{
		}
		#endregion

		#region entry variables
		private const string entryseq	  = "seq";
		private const string entryobjname = "objname";
		private const string entryoldname = "oldname";
		private const string entrydisname = "disname";
		private const string entryobjtype = "objtype";
		private const string entryselected = "selected";
		private const string entrydrwobj = "drwobj";
		private const string entryuplist = "uplist";
		private const string entrydnlist = "dnlist";
		private const string entryltlist = "ltlist";
		private const string entryrtlist = "rtlist";
		protected ArrayList upnamelist = new ArrayList();
		protected ArrayList dnnamelist = new ArrayList();
		protected ArrayList ltnamelist = new ArrayList();
		protected ArrayList rtnamelist = new ArrayList();
		#endregion

		#region savetostream
		/// <summary>
		/// Save object to serialization stream
		/// </summary>
		/// <param name="info"></param>
		/// <param name="orderNumber"></param>
		public virtual void SaveToStream(SerializationInfo info, int orderNumber)
		{
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryseq, orderNumber),	this.seq);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryobjname, orderNumber),	this.objname);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryoldname, orderNumber),	this.oldname);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrydisname, orderNumber),	this.disname);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryobjtype, orderNumber),	this.objtype);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryselected, orderNumber),	this.selected);

			upnamelist = MakeNameList(uplist);
			dnnamelist = MakeNameList(dnlist);
			ltnamelist = MakeNameList(ltlist);
			rtnamelist = MakeNameList(rtlist);

			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryuplist, orderNumber),this.upnamelist);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrydnlist, orderNumber),this.dnnamelist);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryltlist, orderNumber),this.ltnamelist);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryrtlist, orderNumber),this.rtnamelist);
		}
		#endregion

		#region namelist
		private ArrayList MakeNameList(ArrayList list)
		{
			if(list == null)
				return null;

			if(list.Count < 1)
				return null;

			ArrayList namelist = new ArrayList();

			foreach(FLOObj o in list)
			{
				namelist.Add(o.objname);
			}

			return namelist;
		}

		public ArrayList TakeNameList(FLOList flolist, ArrayList namelist)
		{
			if(namelist == null)
				return new ArrayList();

			if(namelist.Count < 1)
				return new ArrayList();

			ArrayList list = new ArrayList();

			foreach(string str in namelist)
			{
				list.Add(flolist.GetObjByName(str));
			}

			return list;
		}
		#endregion

		#region restorearraylist
		public virtual void RestoreArrayList(FLOList flolist)
		{
		}
		#endregion

		#region loadfromstream
		public virtual void LoadFromStream(SerializationInfo info, int orderNumber)
		{
			this.seq = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryseq, orderNumber),typeof(int));			
			this.objname = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryobjname, orderNumber),typeof(string));
			this.oldname = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryoldname, orderNumber),typeof(string));
			this.disname = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrydisname, orderNumber),typeof(string));
			this.objtype = (FLOObj.OBJTYPE)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryobjtype, orderNumber),typeof(FLOObj.OBJTYPE));
			this.selected = (bool)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryselected, orderNumber),typeof(bool));

			this.upnamelist = (ArrayList)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryuplist, orderNumber),typeof(ArrayList));
			this.dnnamelist = (ArrayList)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrydnlist, orderNumber),typeof(ArrayList));
			this.ltnamelist = (ArrayList)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryltlist, orderNumber),typeof(ArrayList));
			this.rtnamelist = (ArrayList)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryrtlist, orderNumber),typeof(ArrayList));
		}
		#endregion

	}
}
