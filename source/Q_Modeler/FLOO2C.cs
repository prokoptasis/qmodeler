using System;
using System.Collections;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Globalization;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// FLOO2C에 대한 요약 설명입니다.
	/// </summary>
	public class FLOO2C : Q_Modeler.FLOObj
	{
		public FLOO2C()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		#region local variables
		private string		o2c_effresource;
		private ArrayList	o2c_effresources;
		#endregion

		#region local variables accessor
		public override string O2C_effresource
		{
			get { return o2c_effresource; }
			set { o2c_effresource = value; }
		}
		#endregion

		#region initializer
		public FLOO2C(FLOMgr mgr, FLOObj s, FLOObj e, FormFLO f)
		{
			Objtype = OBJTYPE.O2C;
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

			o2c_effresource = "";
			o2c_effresources = new ArrayList();
		}
		#endregion

		#region popup properties
		public override bool PopUp(FLOMgr mgr, FormFLO f)
		{
			f = new FormFLOO2C(CheckLockType(),o2c_effresources);

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
			if(this.DNlist(0).Cal_caltype == FLOObj.CALTYPE.EFFICIENCY)
				return 1;

			return 0;			// Yield Calendar (Full Lock
		}
		#endregion

		#region checklogicalflo
		public override bool CheckFLOLogic(FLOObj s, FLOObj e)
		{
			if(e.Uplist.Count > 0 || e.Dnlist.Count > 0 )
				return false;

			if( e.Cal_caltype != CALTYPE.YIELD &&
				e.Cal_caltype != CALTYPE.EFFICIENCY )
				return false;

			if( s.Dnlist.Count > 0)
			{
				foreach(FLOObj c in s.Dnlist)
				{
					if(c.DNlist(0).Cal_caltype == CALTYPE.YIELD && !c.Equals(this))
						if(e.Cal_caltype == CALTYPE.YIELD)
							return false;
				}
			}

			if(e.Cal_caltype == CALTYPE.EFFICIENCY)
			{
				foreach(FLOObj c in s.Uplist)
				{
					this.o2c_effresources.Add(c.UPlist(0).Objname);
				}

				foreach(FLOObj c in s.Dnlist)
				{
					if(c.DNlist(0).Cal_caltype == CALTYPE.EFFICIENCY)
						this.o2c_effresources.Remove(c.O2C_effresource);
				}

				if(this.o2c_effresources.Count < 1)
					return false;
			}
			
			return true;
		}
		#endregion

		#region entry variables
		private const string entryo2ceffresource = "o2c_effresource";
		private const string entryo2ceffresources = "o2c_effresources";

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
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryo2ceffresource, orderNumber),	this.o2c_effresource);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryo2ceffresources, orderNumber),	this.o2c_effresources);

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
			this.o2c_effresource = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryo2ceffresource, orderNumber),typeof(string));
			this.o2c_effresources = (ArrayList)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryo2ceffresources, orderNumber),typeof(ArrayList));

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

		#region restorearraylist
		public override void RestoreArrayList(FLOList flolist)
		{
			this.Uplist = TakeNameList(flolist,this.upnamelist);
			this.Dnlist = TakeNameList(flolist,this.dnnamelist);
		}
		#endregion
	}
}
