using System;
using System.Collections;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Globalization;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// FLOO2B에 대한 요약 설명입니다.
	/// </summary>
	public class FLOO2B : Q_Modeler.FLOObj
	{
		public FLOO2B()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}
		
		#region o2b local variables
		private OPETYPE o2b_prodtype;
		private int		o2b_prodqty;
		private int		o2b_altpriority;
		private int		o2b_altproportion;
		private int		o2b_basedqty;
		private int		o2b_cobyprod;
		private int		o2b_cobyprodqty;
		private int		o2b_cobyprodrate;
		#endregion

		#region o2b local variables accessor
		public override OPETYPE O2B_prodtype
		{
			get { return o2b_prodtype; }
			set { o2b_prodtype = value; }
		}

		public override int O2B_prodqty
		{
			get { return o2b_prodqty; }
			set { o2b_prodqty = value; }
		}

		public override int O2B_altpriority
		{
			get { return o2b_altpriority; }
			set { o2b_altpriority = value; }
		}

		public override int O2B_altproportion
		{
			get { return o2b_altproportion; }
			set { o2b_altproportion = value; }
		}

		public override int O2B_basedqty
		{
			get { return o2b_basedqty; }
			set { o2b_basedqty = value; }
		}

		public override int O2B_cobyprod
		{
			get { return o2b_cobyprod; }
			set { o2b_cobyprod = value; }
		}

		public override int O2B_cobyprodqty
		{
			get { return o2b_cobyprodqty; }
			set { o2b_cobyprodqty = value; }
		}

		public override int O2B_cobyprodrate
		{
			get { return o2b_cobyprodrate; }
			set { o2b_cobyprodrate = value; }
		}
		#endregion

		#region initializer
		public FLOO2B(FLOMgr mgr, FLOObj s, FLOObj e, FormFLO f)
		{
			Objtype = OBJTYPE.O2B;
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

			o2b_prodtype	= OPETYPE.NULL;
			o2b_prodqty		= 1;
			o2b_altpriority = 1;
			o2b_altproportion	= 0;
			o2b_basedqty		= 1;
			o2b_cobyprod		= 1;
			o2b_cobyprodqty		= 1;
			o2b_cobyprodrate	= 0;
		}
		#endregion

		#region popup properties
		public override bool PopUp(FLOMgr mgr, FormFLO f)
		{
			f = new FormFLOO2B(CheckLockType());

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
			return 0;			// Full Access
		}
		#endregion

		#region checklogicalflo
		public override bool CheckFLOLogic(FLOObj s, FLOObj e)
		{
			foreach(FLOObj c in e.Ltlist)
			{
				if(!c.LTlist(0).Equals(this.LTlist(0)))
					if(c.O2B_prodtype == OPETYPE.Normal)
						this.O2B_prodtype = OPETYPE.AltRouting;
			}

			foreach(FLOObj c in s.Rtlist)
			{
				if(!c.RTlist(0).Equals(this.RTlist(0)))
					if(c.O2B_prodtype == OPETYPE.Normal || c.O2B_prodtype == OPETYPE.AltRouting)
						this.O2B_prodtype = OPETYPE.CoByProd;
			}

			if(this.O2B_prodtype == OPETYPE.NULL)
				this.O2B_prodtype = OPETYPE.Normal;

			return true;
		}
		#endregion

		#region entry variables
		private const string entryo2bprodtype = "o2b_prodtype";
		private const string entryo2bprodqty = "o2b_prodqty";
		private const string entryo2baltpriority = "o2b_altpriority";
		private const string entryo2baltproportion = "o2b_altproportion";
		private const string entryo2bbasedqty = "o2b_basedqty";
		private const string entryo2bcobyprod = "o2b_cobyprod";
		private const string entryo2bcobyprodqty = "o2b_cobyprodqty";
		private const string entryo2bcobyprodrate = "o2b_cobyprodrate";

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
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryo2bprodtype, orderNumber),	this.o2b_prodtype);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryo2bprodqty, orderNumber),	this.o2b_prodqty);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryo2baltpriority, orderNumber),	this.o2b_altpriority);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryo2baltproportion, orderNumber),	this.o2b_altproportion);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryo2bbasedqty, orderNumber),	this.o2b_basedqty);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryo2bcobyprod, orderNumber),	this.o2b_cobyprod);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryo2bcobyprodqty, orderNumber),	this.o2b_cobyprodqty);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryo2bcobyprodrate, orderNumber),	this.o2b_cobyprodrate);

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
			this.o2b_prodtype = (OPETYPE)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryo2bprodtype, orderNumber),typeof(OPETYPE));
			this.o2b_prodqty = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryo2bprodqty, orderNumber),typeof(int));
			this.o2b_altpriority = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryo2baltpriority, orderNumber),typeof(int));
			this.o2b_altproportion = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryo2baltproportion, orderNumber),typeof(int));
			this.o2b_basedqty = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryo2bbasedqty, orderNumber),typeof(int));
			this.o2b_cobyprod = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryo2bcobyprod, orderNumber),typeof(int));
			this.o2b_cobyprodqty = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryo2bcobyprodqty, orderNumber),typeof(int));
			this.o2b_cobyprodrate = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryo2bcobyprodrate, orderNumber),typeof(int));

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
