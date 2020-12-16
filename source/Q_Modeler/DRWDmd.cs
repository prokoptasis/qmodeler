using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Q_Modeler
{
	/// <summary>
	/// DRWDmd에 대한 요약 설명입니다.
	/// </summary>
	public class DRWDmd : DRWObj
	{
		public DRWDmd()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		#region local variables
		private Point ctct;
		private Point ltct;
		private Point ctup;
		private Point rtup;
		private Point rtdn;
		private Point ctdn;
		private Point anch;
		#endregion

		#region local variables
		public override Point CtCt
		{
			get { return ctct; }
			set { ctct = value; }
		}
		#endregion

		#region Initilizer
		public DRWDmd(FLOObj owner, int x, int y)
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			this.Owner = owner;
			ltct = new Point(x - DMDWIDTH/2,y);
			ctup = new Point(x - (int)(DMDWIDTH/4),y - DMDHEIGHT/2);
			rtup = new Point(x + DMDWIDTH/2,y - DMDHEIGHT/2);
			ctdn = new Point(x - (int)(DMDWIDTH/4),y + DMDHEIGHT/2);
			rtdn = new Point(x + DMDWIDTH/2,y + DMDHEIGHT/2);
			ctct = new Point(x,y);
			anch = new Point(x - DMDWIDTH/2, y - DMDHEIGHT/2);
		}
		#endregion

		#region draw
		public override void Draw(Graphics g)
		{
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
			float sy = ctct.Y + FONTYMARGIN;

			g.DrawString(s,f,b,sx,sy);
            
			g.DrawLine(p,ltct,ctup);
			g.DrawLine(p,ctup,rtup);
			g.DrawLine(p,rtup,rtdn);
			g.DrawLine(p,rtdn,ctdn);
			g.DrawLine(p,ctdn,ltct);

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
			Rectangle drect = new Rectangle(ltct.X, ctup.Y,DMDWIDTH,DMDHEIGHT);
			return drect.Contains(point);
		}

		public override bool IntersectsWith(Rectangle rect)
		{
			Rectangle drect = new Rectangle(ltct.X, ctup.Y,DMDWIDTH,DMDHEIGHT);
			return drect.IntersectsWith(rect);
		}
		#endregion

		#region move
		public override void Move(int dx, int dy)
		{
			ltct.X += dx;
			ltct.Y += dy;

			ctup.X += dx;
			ctup.Y += dy;

			rtup.X += dx;
			rtup.Y += dy;

			rtdn.X += dx;
			rtdn.Y += dy;

			ctdn.X += dx;
			ctdn.Y += dy;

			ctct.X += dx;
			ctct.Y += dy;

			anch.X += dx;
			anch.Y += dy;
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
				case DRWObj.CONPONT.CtUp:
					rpoint = ctup;
					break;
				case DRWObj.CONPONT.RtUp:
					rpoint = rtup;
					break;
				case DRWObj.CONPONT.RtDn:
					rpoint = rtdn;
					break;
				case DRWObj.CONPONT.CtDn:
					rpoint = ctdn;
					break;
				case DRWObj.CONPONT.LtCt:
					rpoint = ltct;
					break;
				case DRWObj.CONPONT.AnCh:
					rpoint = anch;
					break;
			}

			return rpoint;
		}

		public override DRWObj.CONPONT GetConPointType(Point point)
		{
			return DRWObj.CONPONT.LtCt;
		}
		#endregion
	}
}
