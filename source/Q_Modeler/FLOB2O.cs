using System;
using System.Collections;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Globalization;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// FLOB2O에 대한 요약 설명입니다.
	/// </summary>
	public class FLOB2O : Q_Modeler.FLOObj
	{
		public FLOB2O()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			Init();
		}
		
		#region b2o local variables
		private BOMTYPE		b2o_constype;
		private int			b2o_cosqty;
		private string		b2o_altbuf;
		private int			b2o_altpriority;
		private ArrayList	b2o_altbufs;
		#endregion

		#region b2o local variables accessor
		public override BOMTYPE B2O_constype
		{
			get { return b2o_constype; }
			set { b2o_constype = value; }
		}

		public override string B2O_altbuf
		{
			get { return b2o_altbuf; }
			set { b2o_altbuf = value; }
		}

		public override int B2O_cosqty
		{
			get { return b2o_cosqty; }
			set { b2o_cosqty = value; }
		}

		public override int B2O_altpriority
		{
			get { return b2o_altpriority; }
			set { b2o_altpriority = value; }
		}
		#endregion

		#region initializer
		public FLOB2O(FLOMgr mgr, FLOObj s, FLOObj e, FormFLO f)
		{
			Objtype = OBJTYPE.B2O;
			Init(mgr.Flolist.GetObjSeq(this.Objtype));

			this.Ltlist.Clear();
			this.Rtlist.Clear();

			this.Ltlist.Insert(0,s);
			this.Rtlist.Insert(0,e);

			if(CheckFLOLogic(this.LTlist(0),this.RTlist(0)))
				if(PopUp(mgr,new FormFLO()))
				{
					this.Drwobj = new DRWCon(mgr, this);

					this.LTlist(0).Rtlist.Add(this);
					this.RTlist(0).Ltlist.Add(this);
				}
		}
		#endregion

		#region init variables
		public override void Init(int n)
		{
			this.Seq = n;
			this.Rtlist = new ArrayList();
			this.Ltlist = new ArrayList();

			b2o_altbufs		= new ArrayList();
			b2o_constype	= BOMTYPE.NULL;
			b2o_altbuf		= "";
			b2o_cosqty		= 1;
			b2o_altpriority = 1;
		}
		#endregion

		#region popup properties
		public override bool PopUp(FLOMgr mgr, FormFLO f)
		{
			f = new FormFLOB2O(CheckLockType(),b2o_altbufs);

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
				
				this.Oldname = Objname;
				this.Objname = f.GetObjName();
				this.Disname = f.GetDisName();

				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion

		#region lock type check
		public override int CheckLockType()
		{
			foreach(FLOObj c in this.RTlist(0).Ltlist)
			{
				if(c.B2O_constype == FLOObj.BOMTYPE.Alternate && c.B2O_altbuf == this.Objname && !c.Equals(this))
					return 1;
			}

			return 0;			// Full Access
		}
		#endregion

		#region checklogicalflo
		public override bool CheckFLOLogic(FLOObj s, FLOObj e)
		{
			foreach(FLOObj c in e.Ltlist)
			{
				if(!c.Equals(this) && c.B2O_constype == BOMTYPE.Normal)
					this.b2o_altbufs.Add(c.LTlist(0).Objname);
			}

			return true;
		}
		#endregion

		#region entry variables
		private const string entryb2oconstype = "b2o_constype";
		private const string entryb2ocosqty = "b2o_cosqty";
		private const string entryb2oaltbuf = "b2o_altbuf";
		private const string entryb2oaltpriority = "b2o_altpriority";
		private const string entryb2oaltbufs = "b2o_altbufs";

		private const string entryctct = "ctct";
		private const string entryltct = "ltct";
		private const string entryrtct = "rtct";
		private const string entrylttp = "lttp";
		private const string entryrttp = "rttp";
		private const string entrydistype = "distype";
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
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryb2oconstype, orderNumber),	this.b2o_constype);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryb2ocosqty, orderNumber),	this.b2o_cosqty);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryb2oaltbuf, orderNumber),	this.b2o_altbuf);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryb2oaltpriority, orderNumber),	this.b2o_altpriority);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryb2oaltbufs, orderNumber),	this.b2o_altbufs);

			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryctct, orderNumber),	this.Drwobj.CtCt);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryltct, orderNumber),	this.Drwobj.Spoint);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryrtct, orderNumber),	this.Drwobj.Epoint);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrylttp, orderNumber),	this.Drwobj.Stype);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryrttp, orderNumber),	this.Drwobj.Etype);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrydistype, orderNumber),	this.Drwobj.Distype);
			
			base.SaveToStream (info, orderNumber);
		}
		#endregion

		#region loadfromstream
		public override void LoadFromStream(SerializationInfo info, int orderNumber)
		{
			this.b2o_constype = (BOMTYPE)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryb2oconstype, orderNumber),typeof(BOMTYPE));
			this.b2o_cosqty = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryb2ocosqty, orderNumber),typeof(int));
			this.b2o_altbuf = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryb2oaltbuf, orderNumber),typeof(string));
			this.b2o_altpriority = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryb2oaltpriority, orderNumber),typeof(int));
			this.b2o_altbufs = (ArrayList)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryb2oaltbufs, orderNumber),typeof(ArrayList));
			
			Point ctct = (Point)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryctct, orderNumber),typeof(Point));
			Point ltct = (Point)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryltct, orderNumber),typeof(Point));
			Point rtct = (Point)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryrtct, orderNumber),typeof(Point));
			int distype = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrydistype, orderNumber),typeof(int));
			
			DRWObj.CONPONT lttp = (DRWObj.CONPONT)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrylttp, orderNumber),typeof(DRWObj.CONPONT));
			DRWObj.CONPONT rttp = (DRWObj.CONPONT)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryrttp, orderNumber),typeof(DRWObj.CONPONT));

			this.Rtlist = new ArrayList();
			this.Ltlist = new ArrayList();

			this.Drwobj = new DRWCon(ltct,rtct,DRWObj.CONPONT.LtCt,DRWObj.CONPONT.RtCt,this);
			
			this.Drwobj.Stype = lttp;
			this.Drwobj.Etype = rttp;
			this.Drwobj.Distype = distype;

			base.LoadFromStream (info, orderNumber);
		}
		#endregion

		#region restorearraylist
		public override void RestoreArrayList(FLOList flolist)
		{
			this.Rtlist = TakeNameList(flolist,this.rtnamelist);
			this.Ltlist = TakeNameList(flolist,this.ltnamelist);
		}
		#endregion
	}
}
