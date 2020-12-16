using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Q_Modeler
{
	/// <summary>
	/// DRWRes에 대한 요약 설명입니다.
	/// </summary>
	public class DRWRes : DRWObj
	{
		public DRWRes()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		#region local variables
		private Point ltup;
		private Point rtup;
		private Point ctdn;
		private Point ctct;
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
		public DRWRes(FLOObj owner, int x, int y)
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			this.Owner = owner;
			ltup = new Point(x - RESWIDTH/2,y - RESHEIGHT/2);
			rtup = new Point(x + RESWIDTH/2,y - RESHEIGHT/2);
			ctdn = new Point(x,y + RESHEIGHT/2);
			ctct = new Point(x,y);
			anch = new Point(x - RESWIDTH/2,y - RESHEIGHT/2); 
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
			float sy = ctct.Y - (FONTYMARGIN + sizefText.Height + 2);

			g.DrawString(s,f,b,sx,sy);
       
			g.DrawLine(p,ltup,rtup);
			g.DrawLine(p,rtup,ctdn);
			g.DrawLine(p,ltup,ctdn);

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
			Rectangle rrect = new Rectangle(ltup.X, ltup.Y,RESWIDTH,RESHEIGHT);
			return rrect.Contains(point);
		}

		public override bool IntersectsWith(Rectangle rect)
		{
			Rectangle rrect = new Rectangle(ltup.X, ltup.Y,RESWIDTH,RESHEIGHT);
			return rrect.IntersectsWith(rect);
		}
		#endregion

		#region move
		public override void Move(int dx, int dy)
		{
			ltup.X += dx;
			ltup.Y += dy;

			rtup.X += dx;
			rtup.Y += dy;

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
				case DRWObj.CONPONT.LtUp:
					rpoint = ltup;
					break;
				case DRWObj.CONPONT.RtUp:
					rpoint = rtup;
					break;
				case DRWObj.CONPONT.CtDn:
					rpoint = ctdn;
					break;
				case DRWObj.CONPONT.CtUp:
					rpoint = new Point(ctct.X, ltup.Y);
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
