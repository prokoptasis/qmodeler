using System;
using System.Collections;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Globalization;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// FLOOpe에 대한 요약 설명입니다.
	/// </summary>
	public class FLOOpe : Q_Modeler.FLOObj
	{
		public FLOOpe()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		#region local variables
		private string	ope_operationpre;
		private string	ope_operation;
		private string	ope_operationsite;
		private string	ope_routingpre;
		private string	ope_routing;
		private int		ope_operationseq;
		private int		ope_runtime;
		private int		ope_releasefence;
		#endregion

		#region local variables accessor
		public override string Ope_operationpre
		{
			get { return ope_operationpre; }
			set { ope_operationpre = value; }
		}

		public override string Ope_operation
		{
			get { return ope_operation; }
			set { ope_operation = value; }
		}

		public override string Ope_operationsite
		{
			get { return ope_operationsite; }
			set { ope_operationsite = value; }
		}

		public override string Ope_routingpre
		{
			get { return ope_routingpre; }
			set { ope_routingpre = value; }
		}

		public override string Ope_routing
		{
			get { return ope_routing; }
			set { ope_routing = value; }
		}

		public override int Ope_operationseq
		{
			get { return ope_operationseq; }
			set { ope_operationseq = value; }
		}

		public override int Ope_runtime
		{
			get { return ope_runtime; }
			set { ope_runtime = value; }
		}

		public override int Ope_releasefence
		{
			get { return ope_releasefence; }
			set { ope_releasefence = value; }
		}
		#endregion

		#region initializer
		public FLOOpe(FLOMgr mgr, int x, int y)
		{
			Objtype = OBJTYPE.Ope;
			Init(mgr.Flolist.GetObjSeq(this.Objtype));

			if(PopUp(mgr,new FormFLO()))
				this.Drwobj = new DRWOpe(this,x,y);
		}
		#endregion

		#region init variables
		public override void Init(int n)
		{
			this.Seq = n;
			this.Uplist = new ArrayList();
			this.Dnlist = new ArrayList();
			this.Rtlist = new ArrayList();
			this.Ltlist = new ArrayList();

			ope_operationpre = OPPRE;
			ope_operation = "Operation" + n.ToString();
			ope_operationsite = "Site";
			ope_routingpre = RTPRE;
			ope_routing = "Routing" + n.ToString();
			ope_operationseq = 0;
			ope_runtime = 0;
			ope_releasefence = 0;
		}
		#endregion

		#region popup properties
		public override bool PopUp(FLOMgr mgr, FormFLO f)
		{
			f = new FormFLOOpe(CheckLockType());

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
			foreach(FLOObj o in this.Ltlist)
			{
				if(o.Objtype == OBJTYPE.O2O)
					return 1;
			}

			foreach(FLOObj c in this.Rtlist)
			{
				if(c.Objtype == OBJTYPE.O2O)
					return 1;
			}

			return 0;
		}
		#endregion	

		#region entry variables
		private const string entryopeoperationpre = "ope_operationpre";
		private const string entryopeoperation = "ope_operation";
		private const string entryopeoperationsite = "ope_operationsite";
		private const string entryoperoutingpre = "ope_routingpre";
		private const string entryoperouting = "ope_routing";
		private const string entryopeoperationseq = "ope_operationseq";
		private const string entryoperuntime = "ope_runtime";
		private const string entryopereleasefence = "ope_releasefence";

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
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryopeoperationpre, orderNumber),	this.ope_operationpre);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryopeoperation, orderNumber),	this.ope_operation);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryopeoperationsite, orderNumber),	this.ope_operationsite);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryoperoutingpre, orderNumber),	this.ope_routingpre);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryoperouting, orderNumber),	this.ope_routing);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryopeoperationseq, orderNumber),	this.ope_operationseq);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryoperuntime, orderNumber),	this.ope_runtime);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryopereleasefence, orderNumber),	this.ope_releasefence);
			
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryctct, orderNumber),	this.Drwobj.CtCt);

			base.SaveToStream (info, orderNumber);
		}
		#endregion

		#region loadfromstream
		public override void LoadFromStream(SerializationInfo info, int orderNumber)
		{
			this.ope_operationpre = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryopeoperationpre, orderNumber),typeof(string));
			this.ope_operation = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryopeoperation, orderNumber),typeof(string));
			this.ope_operationsite = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryopeoperationsite, orderNumber),typeof(string));
			this.ope_routingpre = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryoperoutingpre, orderNumber),typeof(string));
			this.ope_routing = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryoperouting, orderNumber),typeof(string));
			this.ope_operationseq = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryopeoperationseq, orderNumber),typeof(int));
			this.ope_runtime = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryoperuntime, orderNumber),typeof(int));
			this.ope_releasefence = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryopereleasefence, orderNumber),typeof(int));
			
			Point ctct = (Point)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryctct, orderNumber),typeof(Point));

			this.Drwobj = new DRWOpe(this,ctct.X, ctct.Y);

			base.LoadFromStream (info, orderNumber);
		}
		#endregion

		#region restorearraylist
		public override void RestoreArrayList(FLOList flolist)
		{
			this.Uplist = TakeNameList(flolist,this.upnamelist);
			this.Dnlist = TakeNameList(flolist,this.dnnamelist);
			this.Ltlist = TakeNameList(flolist,this.ltnamelist);
			this.Rtlist = TakeNameList(flolist,this.rtnamelist);
		}
		#endregion
	}
}
