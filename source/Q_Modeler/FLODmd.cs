using System;
using System.Collections;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Globalization;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// FLODmd에 대한 요약 설명입니다.
	/// </summary>
	public class FLODmd : Q_Modeler.FLOObj
	{
		public FLODmd()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			Init();
		}

		#region local variables
		private string	dmd_sorderid;
		private string	dmd_ordereddate;
		private int		dmd_orderqty;
		private int		dmd_orderpriority;
		private int		dmd_latenesstolerance;
		#endregion

		#region local variables accessor
		public override string Dmd_sorderid
		{
			get { return dmd_sorderid; }
			set { dmd_sorderid = value; }
		}

		public override string Dmd_ordereddate
		{
			get { return dmd_ordereddate; }
			set { dmd_ordereddate = value; }
		}

		public override int Dmd_orderqty
		{
			get { return dmd_orderqty; }
			set { dmd_orderqty = value; }
		}

		public override int Dmd_orderpriority
		{
			get { return dmd_orderpriority; }
			set { dmd_orderpriority = value; }
		}

		public override int Dmd_latenesstolerance
		{
			get { return dmd_latenesstolerance; }
			set { dmd_latenesstolerance = value; }
		}
		#endregion

		#region initializer
		public FLODmd(FLOMgr mgr, int x, int y)
		{
			Objtype = OBJTYPE.Dmd;
			Init(mgr.Flolist.GetObjSeq(this.Objtype));

			if(PopUp(mgr,new FormFLO()))
				this.Drwobj = new DRWDmd(this,x,y);
		}
		#endregion

		#region init variables
		public override void Init(int n)
		{
			this.Seq = n;
			this.Ltlist = new ArrayList();

			dmd_sorderid = "Demand" + n.ToString();
			dmd_ordereddate = DateTime.Now.ToShortDateString();
			dmd_orderqty = 1;
			dmd_orderpriority = 1;
			dmd_latenesstolerance = 0;			
		}
		#endregion

		#region popup properties
		public override bool PopUp(FLOMgr mgr, FormFLO f)
		{
			f = new FormFLODmd(CheckLockType());

			if(mgr == null)
				return false;

			f.SetAttr(this);
			DialogResult r = f.ShowDialog();
			
			if(r == DialogResult.OK)
			{
				if(mgr.Flolist.CheckObjNameUnique(f.GetObjName(),this))	// objname 유일성 테스트
					return false;
				
				if(f.CheckFormLogic())
					return false;
				
				f.GetAttr(this);

				Oldname = Objname;
				Objname = f.GetObjName();
				this.Disname = f.GetDisName();

				UpdateCon();

				return true;
			}
			else
			{
				return false;
			}
		}

		public override void UpdateCon()
		{
			if(this.Ltlist.Count > 0)
				this.LTlist(0).Disname = this.Dmd_orderqty.ToString();
		}
		#endregion

		#region lock type check
		public override int CheckLockType()
		{
			return 0;
		}
		#endregion	

		#region entry variables
		private const string entrydmdsorderid = "dmd_sorderid";
		private const string entrydmdordereddate = "dmd_ordereddate";
		private const string entrydmdorderqty = "dmd_orderqty";
		private const string entrydmdorderpriority = "dmd_orderpriority";
		private const string entrydmdlatenesstolerance = "dmd_latenesstolerance";
		private const string entryctct = "ctct";
		#endregion

		#region dump
		public override void Dump()
		{
			base.Dump ();
		}
		#endregion

		#region savetostream
		public override void SaveToStream(System.Runtime.Serialization.SerializationInfo info, int orderNumber)
		{
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrydmdsorderid, orderNumber),	this.dmd_sorderid);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrydmdordereddate, orderNumber),	this.dmd_ordereddate);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrydmdorderqty, orderNumber),	this.dmd_orderqty);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrydmdorderpriority, orderNumber),	this.dmd_orderpriority);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrydmdlatenesstolerance, orderNumber),	this.dmd_latenesstolerance);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryctct, orderNumber),	this.Drwobj.CtCt);

			base.SaveToStream (info, orderNumber);
		}
		#endregion

		#region loadfromstream
		public override void LoadFromStream(SerializationInfo info, int orderNumber)
		{
			this.dmd_sorderid = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrydmdsorderid, orderNumber),typeof(string));
			this.dmd_ordereddate = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrydmdordereddate, orderNumber),typeof(string));
			this.dmd_orderqty = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrydmdorderqty, orderNumber),typeof(int));
			this.dmd_orderpriority = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrydmdorderpriority, orderNumber),typeof(int));
			this.dmd_latenesstolerance = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrydmdlatenesstolerance, orderNumber),typeof(int));
			
			Point ctct = (Point)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryctct, orderNumber),typeof(Point));

			this.Drwobj = new DRWDmd(this,ctct.X, ctct.Y);

			base.LoadFromStream (info, orderNumber);
		}
		#endregion

		#region restorearraylist
		public override void RestoreArrayList(FLOList flolist)
		{
			this.Ltlist = TakeNameList(flolist,this.ltnamelist);
		}
		#endregion
	}
}
