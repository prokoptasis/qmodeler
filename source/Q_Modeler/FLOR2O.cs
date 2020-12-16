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
	/// FLOR2O에 대한 요약 설명입니다.
	/// </summary>
	public class FLOR2O : Q_Modeler.FLOObj
	{
		public FLOR2O()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		#region local variables
		private int			r2o_qtyper;
		private RESTYPE		r2o_restype;
		private string		r2o_altresource;
		private int			r2o_altpriority;
		private ArrayList	r2o_altresources;
		#endregion

		#region local variables accessor
		public override int R2O_qtyper
		{
			get { return r2o_qtyper; }
			set { r2o_qtyper = value; }
		}

		public override int R2O_altpriority
		{
			get { return r2o_altpriority; }
			set { r2o_altpriority = value; }
		}

		public override RESTYPE R2O_restype
		{
			get { return r2o_restype; }
			set { r2o_restype = value; }
		}

		public override string R2O_altresource
		{
			get { return r2o_altresource; }
			set { r2o_altresource = value; }
		}
		#endregion

		#region initializer
		public FLOR2O(FLOMgr mgr, FLOObj s, FLOObj e, FormFLO f)
		{
			Objtype = OBJTYPE.R2O;
			Init(mgr.Flolist.GetObjSeq(this.Objtype));

			this.Uplist.Clear();
			this.Dnlist.Clear();

			this.Uplist.Insert(0,s);
			this.Dnlist.Insert(0,e);

			if(CheckFLOLogic(this.UPlist(0),this.DNlist(0)))
				if(PopUp(mgr,new FormFLO()))
				{
					this.Drwobj = new DRWCon(mgr, this);
					this.UPlist(0).Dnlist.Add(this);
					this.DNlist(0).Uplist.Add(this);
				}
		}
		#endregion

		#region init variables
		public override void Init(int n)
		{
			this.Seq = n;
			this.Uplist = new ArrayList();
			this.Dnlist = new ArrayList();

			r2o_altresources = new ArrayList();
			r2o_qtyper	= 1;
			r2o_restype	= RESTYPE.NULL;
			r2o_altresource = "";
			r2o_altpriority = 1;
		}
		#endregion

		#region popup properties
		public override bool PopUp(FLOMgr mgr, FormFLO f)
		{
			f = new FormFLOR2O(CheckLockType(),r2o_altresources);

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
			foreach(FLOObj c in this.DNlist(0).Uplist)
			{
				if(!c.Equals(this))
				{
					if(!r2o_altresources.Contains(c.UPlist(0).Objname))
						r2o_altresources.Add(c.UPlist(0).Objname);

					if(c.R2O_restype == FLOObj.RESTYPE.Normal)
						this.R2O_restype = FLOObj.RESTYPE.Simultaneous;
				}
			}

			if(this.R2O_restype == FLOObj.RESTYPE.NULL)
				this.R2O_restype = FLOObj.RESTYPE.Normal;

			return true;
		}
		#endregion

		#region entry variables
		private const string entryr2oqtyper = "r2o_qtyper";
		private const string entryr2orestype = "r2o_restype";
		private const string entryr2oaltresource = "r2o_altresource";
		private const string entryr2oaltpriority = "r2o_altpriority";
		private const string entryr2oaltresources = "r2o_altresources";

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
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryr2oqtyper, orderNumber),	this.r2o_qtyper);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryr2orestype, orderNumber),	this.r2o_restype);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryr2oaltresource, orderNumber),	this.r2o_altresource);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryr2oaltpriority, orderNumber),	this.r2o_altpriority);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryr2oaltresources, orderNumber),	this.r2o_altresources);

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
			this.r2o_qtyper = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryr2oqtyper, orderNumber),typeof(int));
			this.r2o_restype = (RESTYPE)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryr2orestype, orderNumber),typeof(RESTYPE));
			this.r2o_altresource = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryr2oaltresource, orderNumber),typeof(string));
			this.r2o_altpriority = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryr2oaltpriority, orderNumber),typeof(int));
			this.r2o_altresources = (ArrayList)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryr2oaltresources, orderNumber),typeof(ArrayList));

			Point ctct = (Point)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryctct, orderNumber),typeof(Point));
			Point ltct = (Point)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryltct, orderNumber),typeof(Point));
			Point rtct = (Point)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryrtct, orderNumber),typeof(Point));
			int distype = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrydistype, orderNumber),typeof(int));
			
			DRWObj.CONPONT lttp = (DRWObj.CONPONT)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrylttp, orderNumber),typeof(DRWObj.CONPONT));
			DRWObj.CONPONT rttp = (DRWObj.CONPONT)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryrttp, orderNumber),typeof(DRWObj.CONPONT));

			this.Uplist = new ArrayList();
			this.Dnlist = new ArrayList();

			this.Drwobj = new DRWCon(ltct,rtct,DRWObj.CONPONT.LtCt,DRWObj.CONPONT.RtCt,this);
			
			this.Drwobj.Stype = lttp;
			this.Drwobj.Etype = rttp;
			this.Drwobj.Distype = distype;

			base.LoadFromStream (info, orderNumber);
		}
		#endregion

		#region restorearray
		public override void RestoreArrayList(FLOList flolist)
		{
			this.Uplist = TakeNameList(flolist,this.upnamelist);
			this.Dnlist = TakeNameList(flolist,this.dnnamelist);
		}
		#endregion
	}
}
