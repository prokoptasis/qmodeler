using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Q_Modeler
{
	/// <summary>
	/// DRWCal에 대한 요약 설명입니다.
	/// </summary>
	public class DRWCal : DRWObj
	{
		public DRWCal()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		#region local		variables
		private Point		ctct;
		private Point		anch;
		private Rectangle	calrect = new Rectangle(0,0,0,0);
		#endregion

		#region local variables accessor
		public override Point CtCt
		{
			get { return ctct; }
			set { ctct = value; }
		}
		#endregion

		#region Initilizer
		public DRWCal(FLOObj owner, int x, int y)
		{
			this.Owner		= owner;
			calrect.X		= x-CALWIDTH/2;
			calrect.Y		= y-CALHEIGHT/2;
			calrect.Width	= CALWIDTH;
			calrect.Height	= CALHEIGHT;
			ctct			= new Point(x,y);
			anch			= new Point(calrect.X,calrect.Y);
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

			if(this.Switchtext)
			{
				sx = ctct.X - sizefText.Width/2;
				sy = calrect.Y - sizefText.Height/2 - FONTYMARGIN/1;
			}

			g.DrawString(s,f,b,sx,sy);
            
			g.DrawLine(p,new Point(calrect.Left,calrect.Top), new Point(calrect.Right,calrect.Top));
			g.DrawLine(p,new Point(calrect.Right,calrect.Top), new Point(calrect.Right,calrect.Bottom - 4));
			g.DrawLine(p,new Point(calrect.Right,calrect.Bottom - 4), new Point(calrect.Left,calrect.Bottom));
			g.DrawLine(p,new Point(calrect.Left,calrect.Bottom), new Point(calrect.Left,calrect.Top));

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
			return calrect.Contains(point);
		}

		public override bool IntersectsWith(Rectangle rect)
		{
			return calrect.IntersectsWith(rect);
		}
		#endregion

		#region move
		public override void Move(int dx, int dy)
		{
			calrect.X += dx;
			calrect.Y += dy;

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
					rpoint = ctct;	// 중간
					break;
				case DRWObj.CONPONT.LtCt:
					rpoint = new Point (calrect.Left,ctct.Y);	// 왼쪽 중간
					break;
				case DRWObj.CONPONT.RtCt:
					rpoint = new Point (calrect.Right,ctct.Y);	// 오른쪽 중간
					break;
				case DRWObj.CONPONT.CtUp:
					rpoint = new Point (ctct.X,calrect.Top);		// 위쪽 중간
					break;
				case DRWObj.CONPONT.CtDn:
					rpoint = new Point (ctct.X, calrect.Bottom-2);		// 아래쪽 중간
					break;
				case DRWObj.CONPONT.LtUp:
					rpoint = new Point (calrect.X,calrect.Y);		// 왼쪽 모서리
					break;
				case DRWObj.CONPONT.RtUp:
					rpoint = new Point (calrect.Right,calrect.Y);	// 오른쪽 모서리
					break;
				case DRWObj.CONPONT.RtDn:
					rpoint = new Point (calrect.Right, calrect.Bottom-4);	// 오른쪽 아래 모서리
					break;
				case DRWObj.CONPONT.LtDn:
					rpoint = new Point (calrect.X, calrect.Bottom);	// 왼쪽 아래
					break;
				case DRWObj.CONPONT.AnCh:
					rpoint = anch;
					break;
			}

			return rpoint;
		}

		public override DRWObj.CONPONT GetConPointType(Point point)
		{
			if(point.Y > ctct.Y)
				return DRWObj.CONPONT.CtDn;
			else
				return DRWObj.CONPONT.CtUp;
		}
		#endregion
	}
}
