using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Q_Modeler
{
	/// <summary>
	/// DRWB2C에 대한 요약 설명입니다.
	/// </summary>
	public class DRWCon : Q_Modeler.DRWObj
	{
		public DRWCon()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		#region local variables
		private Point			ltct;
		private Point			rtct;
		private DRWObj.CONPONT  lttp;
		private DRWObj.CONPONT  rttp;
		private Point			ctct;
		private int				distype;
		private Pen				areapen = null;
		private Region			arearegion = null;
		private GraphicsPath	areapath = null;
		#endregion

		#region local variables accessor
		public override Point Spoint
		{
			get { return ltct; }
			set { ltct = value; }
		}
		public override Point Epoint
		{
			get { return rtct; }
			set { rtct = value; }
		}
		public override DRWObj.CONPONT Stype
		{
			get { return lttp; }
			set { lttp = value; }
		}
		public override DRWObj.CONPONT Etype
		{
			get { return rttp; }
			set { rttp = value; }
		}
		public override Point CtCt
		{
			get { return ctct; }
			set { ctct = value; }
		}
		public override int Distype
		{
			get { return distype; }
			set { distype = value; }
		}
		#endregion
	
		#region initializer
		public DRWCon(Point spt, Point ept, DRWObj.CONPONT stp, DRWObj.CONPONT etp, FLOObj owner)
		{
			this.Owner = owner;
			ltct = spt;
			rtct = ept;
			lttp = stp;
			rttp = etp;
			ctct = new Point((int)(ltct.X + rtct.X)/2,(int)(ltct.Y+rtct.Y)/2);

			if(Owner.Objtype == (FLOObj.OBJTYPE.B2C|FLOObj.OBJTYPE.O2C|FLOObj.OBJTYPE.R2O))
				this.distype = 2;
			else if (Owner.Objtype == FLOObj.OBJTYPE.C2R)
				this.distype = 3;
			else
				this.distype = 1;
		}

		public DRWCon(FLOMgr mgr, FLOObj owner)
		{
			this.Owner = owner;
			ltct = mgr.Gudcon.Spoint;
			rtct = mgr.Gudcon.Epoint;
			lttp = mgr.Gudcon.Sptype;
			rttp = mgr.Gudcon.Eptype;
			ctct = new Point((int)(ltct.X + rtct.X)/2,(int)(ltct.Y+rtct.Y)/2);

			if(Owner.Objtype == (FLOObj.OBJTYPE.B2C|FLOObj.OBJTYPE.O2C))
				this.distype = 2;
			else if (Owner.Objtype == FLOObj.OBJTYPE.C2R)
				this.distype = 3;
			else if(Owner.Objtype == FLOObj.OBJTYPE.R2O)
				this.distype = 4;
			else
				this.distype = 1;
		}
		#endregion

		#region draw
		public override void Draw(Graphics g)
		{
			if(ltct.X > rtct.X)
				ctct = new Point((int)(rtct.X + ltct.X)/2,(int)(rtct.Y+ltct.Y)/2);
			else
				ctct = new Point((int)(ltct.X + rtct.X)/2,(int)(ltct.Y+rtct.Y)/2);
			
			g.SmoothingMode = SmoothingMode.AntiAlias;

			Pen p;
			Font f;
			SolidBrush b;

			if(this.Owner.Selected)
			{
				p = new Pen(System.Drawing.Color.Blue,PENWIDTH + 1);
				f = new Font(FONTNAME,TEXTSIZE,FontStyle.Bold);
				b = new SolidBrush(Color.Blue);
			}
			else
			{
				p = new Pen(COLOR,PENWIDTH);
				f = new Font(FONTNAME,TEXTSIZE);
				b = new SolidBrush(Color.Black);
			}

			string s = this.Owner.Disname;
			SizeF sizefText = g.MeasureString(s,f);

			float sx = ctct.X - sizefText.Width/2;
			float sy = ctct.Y + 2;

			// 세로 텍스트에 대한 변경
			if(this.distype == 2)
			{
				sx = ctct.X - sizefText.Width;
				sy = ctct.Y;
			}
			else if (this.distype == 3)
			{
				sx = ctct.X - sizefText.Width;
				sy = ctct.Y - sizefText.Height/2 - FONTYMARGIN/2;

				this.Owner.UPlist(0).Drwobj.Switchtext = true;
			}
			else if (this.distype == 4)
			{
				sx = ctct.X - sizefText.Width;
				sy = ctct.Y - sizefText.Height/2 - FONTYMARGIN/2;
			}

			g.DrawString(s,f,b,sx,sy);
            
			g.DrawLine(p, ltct.X, ltct.Y, rtct.X, rtct.Y);

			p.Dispose();
			b.Dispose();
			f.Dispose();
		}
		#endregion

		#region hittest
		public override bool HitTest(Point point)
		{
			if ( PointInObject(point) )
				return true;

			return false;
		}

		protected override bool PointInObject(Point point)
		{
			Areapath = null;
			Invalidate();
			CreateObjects();

			return Arearegion.IsVisible(point);
		}

		public override bool IntersectsWith(Rectangle rectangle)
		{
			Areapath = null;
			Invalidate();
			CreateObjects();

			return Arearegion.IsVisible(rectangle);
		}

		protected void Invalidate()
		{
			if ( Areapath != null )
			{
				Areapath.Dispose();
				Areapath = null;
			}

			if ( Areapen != null )
			{
				Areapen.Dispose();
				Areapen = null;
			}

			if ( Arearegion != null )
			{
				Arearegion.Dispose();
				Arearegion = null;
			}
		}

		protected virtual void CreateObjects()
		{
			if ( Areapath != null )
				return;

			// Create path which contains wide line
			// for easy mouse selection
			Areapath = new GraphicsPath();
			Areapen  = new Pen(Color.Black, 7);
			Areapath.AddLine(ltct.X, ltct.Y, rtct.X, rtct.Y);
			Areapath.Widen(Areapen);

			// Create region from the path
			Arearegion = new Region(Areapath);
		}

		protected GraphicsPath Areapath
		{
			get	{ return areapath; }
			set { areapath = value; }
		}

		protected Pen Areapen
		{
			get { return areapen; }
			set { areapen = value; }
		}

		protected Region Arearegion
		{
			get { return arearegion; }
			set { arearegion = value; }
		}
		#endregion

		#region move
		public override void Move(int deltaX, int deltaY)
		{
			ltct.X += deltaX;
			ltct.Y += deltaY;

			rtct.X += deltaX;
			rtct.Y += deltaY;
		}
		#endregion

		#region getconpoint/type
		public override Point GetConPoint(DRWObj.CONPONT cptype)
		{
			Point rpoint = new Point(0,0);

			switch( cptype)
			{
				case DRWObj.CONPONT.CtCt:
					rpoint = ctct;
					break;
				case DRWObj.CONPONT.LtCt:
					rpoint = ltct;
					break;
				case DRWObj.CONPONT.RtCt:
					rpoint = rtct;
					break;
			}

			return rpoint;
		}

		public override DRWObj.CONPONT GetConPointType(Point point)
		{
			if(point.X < ctct.X)
				return DRWObj.CONPONT.LtCt;
			else if(point.X > ctct.X)
				return DRWObj.CONPONT.RtCt;
			else
				return DRWObj.CONPONT.CtCt;
		}
		#endregion

		#region setconpoint
		public override void SetConPoint(FLOObj S, FLOObj E)
		{
			this.ltct = S.Drwobj.GetConPoint(lttp);
			this.rtct = E.Drwobj.GetConPoint(rttp);
		}
		#endregion
	}
}
