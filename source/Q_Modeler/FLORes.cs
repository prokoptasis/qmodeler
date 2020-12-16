using System;
using System.Collections;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Globalization;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// FLORes에 대한 요약 설명입니다.
	/// </summary>
	public class FLORes : Q_Modeler.FLOObj
	{
		public FLORes()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			Init();
		}

		#region local variables
		private string res_resourcepre;
		private string res_resource;
		private string res_resourcesite;
		#endregion

		#region local variables accessor
		public override string Res_resourcepre
		{
			get { return res_resourcepre; }
			set { res_resourcepre = value; }
		}

		public override string Res_resource
		{
			get { return res_resource; }
			set { res_resource = value; }
		}

		public override string Res_resourcesite
		{
			get { return res_resourcesite; }
			set { res_resourcesite = value; }
		}
		#endregion

		#region initializer
		public FLORes(FLOMgr mgr, int x, int y)
		{
			Objtype = OBJTYPE.Res;
			Init(mgr.Flolist.GetObjSeq(this.Objtype));

			if(PopUp(mgr,new FormFLO()))
				this.Drwobj = new DRWRes(this,x,y);
		}
		#endregion

		#region init variables
		public override void Init(int n)
		{
			this.Seq = n;
			this.Uplist = new ArrayList();
			this.Dnlist = new ArrayList();

			res_resourcepre = RSPRE;
			res_resource = "Resource" + n.ToString();
			res_resourcesite = "Site";
		}
		#endregion

		#region popup properties
		public override bool PopUp(FLOMgr mgr, FormFLO f)
		{
			f = new FormFLORes(CheckLockType());

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
			foreach(FLOObj o in this.Dnlist)
			{
				foreach(FLOObj c in o.DNlist(0).Uplist)
				{
					if(c.R2O_restype == RESTYPE.Alternate && c.R2O_altresource == this.Objname)
						return 1;
				}

				foreach(FLOObj c in o.DNlist(0).Dnlist)
				{
					if(c.DNlist(0).Cal_caltype == CALTYPE.EFFICIENCY && c.O2C_effresource == this.Objname)
						return 1;
				}
			}

			return 0;
		}
		#endregion	

		#region entry variables
		private const string entryresresourcepre	= "res_resourcepre";
		private const string entryresresource		= "res_resource";
		private const string entryresresourcesite	= "res_resourcesite";
		private const string entryctct				= "ctct";
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
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryresresourcepre, orderNumber),	this.res_resourcepre);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryresresource, orderNumber),	this.res_resource);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryresresourcesite, orderNumber),	this.res_resourcesite);
			
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryctct, orderNumber),	this.Drwobj.CtCt);

			base.SaveToStream (info, orderNumber);
		}
		#endregion

		#region loadtostream
		public override void LoadFromStream(SerializationInfo info, int orderNumber)
		{
			this.res_resourcepre = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryresresourcepre, orderNumber),typeof(string));
			this.res_resource = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryresresource, orderNumber),typeof(string));
			this.res_resourcesite = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryresresourcesite, orderNumber),typeof(string));
			
			Point ctct = (Point)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryctct, orderNumber),typeof(Point));

			this.Drwobj = new DRWRes(this,ctct.X, ctct.Y);

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
