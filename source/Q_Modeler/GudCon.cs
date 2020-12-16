using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;

namespace Q_Modeler
{
	/// <summary>
	/// GudCon에 대한 요약 설명입니다.
	/// </summary>
	public class GudCon
	{
		public GudCon()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		#region locat variables
		private Point	spoint;
		private Point	epoint;
		private Point	cpoint;	
		private FLOObj	sobj;
		private FLOObj	eobj;
		private DRWObj.CONPONT sptype;
		private DRWObj.CONPONT eptype;
		private bool	connecting;
		private bool	conguiding;
		#endregion

		#region local variables accessor
		public Point Spoint
		{
			get { return spoint; }
			set { spoint = value; }
		}

		public Point Epoint
		{
			get { return epoint; }
			set { epoint = value; }
		}

		public FLOObj Sobj
		{
			get { return sobj; }
			set { sobj = value; }
		}

		public FLOObj Eobj
		{
			get { return eobj; }
			set { eobj = value; }
		}

		public DRWObj.CONPONT Sptype
		{
			get { return sptype; }
			set { sptype = value; }
		}

		public DRWObj.CONPONT Eptype
		{
			get { return eptype; }
			set { eptype = value; }
		}
		#endregion

		#region GudCon Initializer & Init
		public GudCon(FLOMgr mgr, int x, int y)
		{
			Init();		
		}
		#endregion

		#region init gudcon
		public void Init()
		{
			sobj = null;
			eobj = null;

			spoint = new Point(0,0);
			epoint = new Point(0,0);
			cpoint = new Point(0,0);
			
			connecting = false;		
			conguiding = false;
		
			sptype = DRWObj.CONPONT.NULL;
			eptype = DRWObj.CONPONT.NULL;
		}
		#endregion

		#region Draw
		public void Draw(Graphics g)
		{
			Pen pen = new Pen(Color.Gray, 2);

			if(this.connecting)
			{
				g.SmoothingMode = SmoothingMode.AntiAlias;
				pen.DashStyle = DashStyle.Dot;
				g.DrawLine(pen, spoint, epoint);
			}

			if(this.conguiding)
			{			
				pen = new Pen(Color.Red, 2);
				pen.DashStyle = DashStyle.Solid;				
				Rectangle rt = new Rectangle(cpoint.X-1,cpoint.Y-1,2,2);
				g.DrawRectangle(pen,rt);
			}
			
			pen.Dispose();
		}
		#endregion

		#region move
		public void Move(int dx, int dy)
		{
			epoint.X = epoint.X + dx;
			epoint.Y = epoint.Y + dy;
		}
		#endregion

		#region ShowConPoint
		public void ShowConPoint(FLOMgr mgr, int x, int y)
		{
			this.conguiding = false;

			epoint = new Point(x, y);

			FLOObj o = mgr.Flolist.GetObjByConPoint(epoint);

			if(o == null)
				return;

			Point conpoint = o.Drwobj.GetConPoint(o.Drwobj.GetConPointType(epoint));

			cpoint = conpoint;
			this.conguiding = true;
		}
		#endregion

		#region Show
		public void Show(FLOMgr mgr, int x, int y)
		{
			if(this.connecting)
				return;

			spoint = new Point(x, y);
			sobj   = mgr.Flolist.GetObjByPoint(spoint);
			
			if(sobj != null)
			{
				mgr.Flolist.UnselectAll();
				sptype = sobj.Drwobj.GetConPointType(spoint);
				spoint = sobj.Drwobj.GetConPoint(sptype);
				connecting = true;
				sobj.Selected = true;
			}
		}
		#endregion

		#region Hide
		public void Hide(FLOMgr mgr, int x, int y)
		{
			connecting = false;

            if(sobj == null)
				return;

			epoint = new Point(x,y);
			eobj = mgr.Flolist.GetObjByPoint(epoint);
			
			if(eobj == null)
				return;

			eptype = GetConPntTypeBySType();		// 일단 sptype의 반대를 가져옴
			GetConObjType();			// 이후 상황에 따라 둘을 스위치...
	
			spoint = Sobj.Drwobj.GetConPoint(sptype);	// Type에 따라 포인트를 가져옴
			epoint = Eobj.Drwobj.GetConPoint(eptype);	// Type에 따라 포인트를 가져옴

			Sobj.Selected = true;
			Eobj.Selected = true;
		}
		#endregion

		#region getcontype & getconpointbystype
		private DRWObj.CONPONT GetConPntTypeBySType()
		{
			if(sptype == DRWObj.CONPONT.CtUp)
				return DRWObj.CONPONT.CtDn;
			else if(sptype == DRWObj.CONPONT.CtDn)
				return DRWObj.CONPONT.CtUp;
			else if(sptype == DRWObj.CONPONT.LtCt)
				return DRWObj.CONPONT.RtCt;
			else if(sptype == DRWObj.CONPONT.RtCt)
				return DRWObj.CONPONT.LtCt;
			else
				return DRWObj.CONPONT.NULL;
		}

		private void GetConObjType()
		{
			bool switched = false;

			if(this.sptype == DRWObj.CONPONT.LtCt || this.sptype == DRWObj.CONPONT.CtUp)
				switched = true;

			if(switched)
			{
				FLOObj tmpobj = this.Sobj;
				this.Sobj = this.Eobj;
				this.Eobj = tmpobj;

				DRWObj.CONPONT tmptype = this.sptype;
				this.sptype = this.eptype;
				this.eptype = tmptype;				
			}
		}

		public FLOObj GetConObj(FLOMgr mgr)
		{
			if(Sobj == null)
				return null;

			if(Eobj == null)
				return null;


			if(Sobj != null && Eobj != null)
			{
				if(	Sobj.Objtype == FLOObj.OBJTYPE.Cal || Sobj.Objtype == FLOObj.OBJTYPE.Res ||
					Eobj.Objtype == FLOObj.OBJTYPE.Cal || Eobj.Objtype == FLOObj.OBJTYPE.Res )
				{
					if(Sptype == DRWObj.CONPONT.LtCt || Sptype == DRWObj.CONPONT.RtCt)
						return null;

					if(Eptype == DRWObj.CONPONT.LtCt || Eptype == DRWObj.CONPONT.RtCt)
						return null;
				}		
	

				if(	Sobj.Objtype != FLOObj.OBJTYPE.Cal && Sobj.Objtype != FLOObj.OBJTYPE.Res &&
					Eobj.Objtype != FLOObj.OBJTYPE.Cal && Eobj.Objtype != FLOObj.OBJTYPE.Res )
				{
					if(Sptype == DRWObj.CONPONT.CtUp || Sptype == DRWObj.CONPONT.CtDn)
						return null;

					if(Eptype == DRWObj.CONPONT.CtUp || Eptype == DRWObj.CONPONT.CtDn)
						return null;
				}
			}

			switch(Sobj.Objtype)
			{
				case FLOObj.OBJTYPE.Buf:
				{
					if(this.Eobj.Objtype == FLOObj.OBJTYPE.Ope)
						return new FLOB2O(mgr, Sobj, Eobj, new FormFLO());
					else if(this.Eobj.Objtype == FLOObj.OBJTYPE.Cal)
						return new FLOB2C(mgr, Sobj, Eobj, new FormFLO());
					else if(this.Eobj.Objtype == FLOObj.OBJTYPE.Dmd)
						return new FLOB2D(mgr, Sobj, Eobj, new FormFLO());
					else
						return null;
				} 

				case FLOObj.OBJTYPE.Cal:
				{
					if(this.Eobj.Objtype == FLOObj.OBJTYPE.Res)
						return new FLOC2R(mgr, Sobj, Eobj, new FormFLO());
					else 
						return null;
				} 

				case FLOObj.OBJTYPE.Ope:
				{
					if(this.Eobj.Objtype == FLOObj.OBJTYPE.Buf)
						return new FLOO2B(mgr, Sobj, Eobj, new FormFLO());
					else if(this.Eobj.Objtype == FLOObj.OBJTYPE.Cal)
						return new FLOO2C(mgr, Sobj, Eobj, new FormFLO());
					else if(this.Eobj.Objtype == FLOObj.OBJTYPE.Ope)
						return new FLOO2O(mgr, Sobj, Eobj, new FormFLO());
					else
						return null;
				} 

				case FLOObj.OBJTYPE.Res:
				{
					if(this.Eobj.Objtype == FLOObj.OBJTYPE.Ope)
						return new FLOR2O(mgr, Sobj, Eobj, new FormFLO());
					else
						return null;
				} 

				case FLOObj.OBJTYPE.Dmd:
				{
					return null;
				}
			}

			return null;
		}
		#endregion
	}
}
