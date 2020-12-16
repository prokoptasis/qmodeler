using System;
using System.Collections;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Globalization;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// FLOCal에 대한 요약 설명입니다.
	/// </summary>
	public class FLOCal : Q_Modeler.FLOObj
	{
		public FLOCal()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		#region public struct
		[Serializable]
		public struct Cal_Detail
		{
			public int		cal_detaildx;
			public double	cal_qtyper;
			public string	cal_effstart;
			public string	cal_effend;
		}
		#endregion

		#region local variables
		private string		cal_calendarpre;
		private string		cal_calendar;
		private CALTYPE		cal_caltype;
		private CPTTYPE		cal_pattern;
		private CDWTYPE		cal_dayofweek;
		private int			cal_numofday;
		private ArrayList	cal_details;
		#endregion

		#region local variables accessor
		public override string Cal_calendarpre
		{
			get { return cal_calendarpre; }
			set { cal_calendarpre = value; }
		}

		public override string Cal_calendar
		{
			get { return cal_calendar; }
			set { cal_calendar = value; }
		}

		public override CALTYPE Cal_caltype
		{
			get { return cal_caltype; }
			set { cal_caltype = value; }
		}

		public override CPTTYPE Cal_pattern
		{
			get { return cal_pattern; }
			set { cal_pattern = value; }
		}

		public override CDWTYPE Cal_dayofweek
		{
			get { return cal_dayofweek; }
			set { cal_dayofweek = value; }
		}

		public override int Cal_numofday
		{
			get { return cal_numofday; }
			set { cal_numofday = value; }
		}

		public override ArrayList Cal_details
		{
			get { return cal_details; }
			set { cal_details = value; }
		}
		#endregion

		#region initializer
		public FLOCal(FLOMgr mgr, int x, int y)
		{
			Objtype = OBJTYPE.Cal;
			this.Cal_caltype = mgr.LastCalType;
			Init(mgr.Flolist.GetObjSeq(this.Objtype));

			if(PopUp(mgr,new FormFLO()))
				this.Drwobj = new DRWCal(this,x,y);
		}
		#endregion

		#region init variables
		public override void Init(int n)
		{
			this.Seq = n;
			this.Uplist = new ArrayList();
			this.Dnlist = new ArrayList();

			cal_details = new ArrayList();
//			cal_calendarpre = FLOObj.SCPRE;
			cal_calendar = "Calendar" + n;
//			cal_caltype = CALTYPE.REP_QTY;
			cal_pattern = CPTTYPE.EVERYDAY;
			cal_numofday = 1;
			cal_dayofweek = CDWTYPE.Mo;
		}
		#endregion

		#region popup properties
		public override bool PopUp(FLOMgr mgr, FormFLO f)
		{
			f = new FormFLOCal(CheckLockType());

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

				mgr.LastCalType = this.cal_caltype;

				return true;
			}
			else
			{
				return false;
			}
		}

		public override void UpdateCon()
		{
			if(this.Uplist.Count > 0)
				foreach(FLOObj o in this.Uplist)
				{
					o.Disname = ((FLOCal.Cal_Detail)this.Cal_details[0]).cal_qtyper.ToString();
				}

			if(this.Dnlist.Count > 0)
				foreach(FLOObj o in this.Dnlist)
				{
					o.Disname = ((FLOCal.Cal_Detail)this.Cal_details[0]).cal_qtyper.ToString();
				}
		}
		#endregion

		#region lock type check
		public override int CheckLockType()
		{
			if(this.Uplist.Count > 0 || this.Dnlist.Count > 0)
				return 1;

			return 0;
		}
		#endregion	

		#region entry variables
		private const string entrycalcalendarpre = "cal_calendarpre";
		private const string entrycalcalendar = "cal_calendar";
		private const string entrycalcaltype = "cal_caltype";
		private const string entrycalpattern = "cal_pattern";
		private const string entrycaldayofweek = "cal_dayofweek";
		private const string entrycalnumofday = "cal_numofday";
		private const string entrycaldetails = "cal_details";
		private const string entryctct = "ctct";
		private const string entryswitchtest = "switchtest";
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
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrycalcalendarpre, orderNumber),	this.cal_calendarpre);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrycalcalendar, orderNumber),	this.cal_calendar);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrycalcaltype, orderNumber),	this.cal_caltype);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrycalpattern, orderNumber),	this.cal_pattern);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrycaldayofweek, orderNumber),	this.cal_dayofweek);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrycalnumofday, orderNumber),	this.cal_numofday);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrycaldetails, orderNumber),	this.cal_details);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryctct, orderNumber),	this.Drwobj.CtCt);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryswitchtest, orderNumber),	this.Drwobj.Switchtext);

			base.SaveToStream (info, orderNumber);
		}
		#endregion

		#region loadfromstream
		public override void LoadFromStream(SerializationInfo info, int orderNumber)
		{
			this.cal_calendarpre = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrycalcalendarpre, orderNumber),typeof(string));
			this.cal_calendar = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrycalcalendar, orderNumber),typeof(string));
			this.cal_caltype = (FLOObj.CALTYPE)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrycalcaltype, orderNumber),typeof(FLOObj.CALTYPE));
			this.cal_pattern = (FLOObj.CPTTYPE)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrycalpattern, orderNumber),typeof(FLOObj.CPTTYPE));
			this.cal_dayofweek = (FLOObj.CDWTYPE)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrycaldayofweek, orderNumber),typeof(FLOObj.CDWTYPE));
			this.cal_numofday = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrycalnumofday, orderNumber),typeof(int));
			this.cal_details = (ArrayList)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrycaldetails, orderNumber),typeof(ArrayList));
			
			Point ctct = (Point)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryctct, orderNumber),typeof(Point));
			this.Drwobj = new DRWCal(this,ctct.X, ctct.Y);
			this.Drwobj.Switchtext = (bool)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryswitchtest, orderNumber),typeof(bool));

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
