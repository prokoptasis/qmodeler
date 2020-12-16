using System;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// FLOBuf에 대한 요약 설명입니다.
	/// </summary>
	public class FLOBuf : Q_Modeler.FLOObj
	{
		public FLOBuf()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			Init();
		}

		#region buf local variables
		private string	buf_item;
		private string	buf_site;
		private string	buf_stage;		
		private int		buf_sellable;
		private int		buf_isresponsebuffer;
		private int		buf_isproductionplanbuffer;
		#endregion

		#region buf local variables accessor
		public override string Buf_item
		{
			get { return buf_item; }
			set { buf_item = value; }
		}

		public override string Buf_site
		{
			get { return buf_site; }
			set { buf_site = value; }
		}

		public override string Buf_stage
		{
			get { return buf_stage; }
			set { buf_stage = value; }
		}

		public override int Buf_sellable
		{
			get { return buf_sellable; }
			set { buf_sellable = value; }
		}

		public override int Buf_isresponsebuffer
		{
			get { return buf_isresponsebuffer; }
			set { buf_isresponsebuffer = value; }
		}

		public override int Buf_isproductionplanbuffer
		{
			get { return buf_isproductionplanbuffer; }
			set { buf_isproductionplanbuffer = value; }
		}
		#endregion

		#region initializer
		public FLOBuf(FLOMgr mgr, int x, int y)
		{
			Objtype = OBJTYPE.Buf;
			Init(mgr.Flolist.GetObjSeq(this.Objtype));

			if(PopUp(mgr,new FormFLO()))
				this.Drwobj = new DRWBuf(this,x,y);
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
			this.Seq = n;

			buf_item = "Item" + n.ToString();
			buf_site = "Site";
			buf_stage = "";
			buf_sellable = 0;
			buf_isresponsebuffer = 1;
			buf_isproductionplanbuffer = 1;
		}
		#endregion

		#region popup properties
		public override bool PopUp(FLOMgr mgr, FormFLO f)
		{
			f = new FormFLOBuf(CheckLockType());

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
			if(this.Rtlist.Count < 1 && this.Ltlist.Count < 1)
				return 0;		// Full Access

			foreach(FLOObj c in this.Rtlist)
			{
				if(c.Objtype == OBJTYPE.B2D)
					return 2;	// Full Lock : Demand와 묶였음 (Sellabe False)

				if(c.Objtype == OBJTYPE.B2O)
					foreach(FLOObj cc in c.RTlist(0).Ltlist)
					{
						if(cc.B2O_constype == BOMTYPE.Alternate && cc.B2O_altbuf == Objname)
							return 1; // FUll Lock : 자재 Alternate에 묶였음
					}			
			}

			foreach(FLOObj c in this.Ltlist)
			{
				if(c.Objtype == OBJTYPE.O2B)
					foreach(FLOObj cc in c.LTlist(0).Rtlist)
					{
						if(cc.O2B_prodtype == OPETYPE.CoByProd)
							return 1; // Full Lock : 코바이 프로드와 묶였음
					}
			}

			return 0;
		}
		#endregion

		#region entry variables
        private const string entrybufitem = "buf_item";
        private const string entrybufsite = "buf_site";
		private const string entrybufstage = "buf_stage";
		private const string entrybufsellable = "buf_sellable";
		private const string entrybufisresponsebuffer = "buf_isresponsebuffer";
		private const string entrybufisproductionplanbuffer = "buf_isproductionplanbuffer";
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
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrybufitem, orderNumber),	this.buf_item);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrybufsite, orderNumber),	this.buf_site);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrybufstage, orderNumber),	this.buf_stage);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrybufsellable, orderNumber),	this.buf_sellable);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrybufisresponsebuffer, orderNumber),	this.buf_isresponsebuffer);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrybufisproductionplanbuffer, orderNumber),	this.buf_isproductionplanbuffer);

			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entryctct, orderNumber),	this.Drwobj.CtCt);

			base.SaveToStream (info, orderNumber);
		}
		#endregion

		#region loadfromstream
		public override void LoadFromStream(SerializationInfo info, int orderNumber)
		{
			this.buf_item = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrybufitem, orderNumber),typeof(string));
			this.buf_site = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrybufsite, orderNumber),typeof(string));
			this.buf_stage = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrybufstage, orderNumber),typeof(string));
			this.buf_sellable = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrybufsellable, orderNumber),typeof(int));
			this.buf_isresponsebuffer = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrybufisresponsebuffer, orderNumber),typeof(int));
			this.buf_isproductionplanbuffer = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entrybufisproductionplanbuffer, orderNumber),typeof(int));

			Point ctct = (Point)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}", entryctct, orderNumber),typeof(Point));

			this.Drwobj = new DRWBuf(this,ctct.X, ctct.Y);

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
