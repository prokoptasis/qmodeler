using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;

namespace Q_Modeler
{
	/// <summary>
	/// DRWBuf에 대한 요약 설명입니다.
	/// </summary>
	public class DRWBuf : DRWObj
	{
		public DRWBuf()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		#region local variables
		private Point ctup;
		private Point ltdn;
		private Point rtdn;
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
		public DRWBuf(FLOObj owner, int x, int y)
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			this.Owner = owner;
			ltdn = new Point(x-BFWIDTH/2,y+BFHEIGHT/2);
			rtdn = new Point(x+BFWIDTH/2,y+BFHEIGHT/2);
			ctup = new Point(x,y-BFHEIGHT/2);
			ctct = new Point(x,y);
			anch = new Point(x-BFWIDTH/2,y-BFHEIGHT/2);
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
				b = new SolidBrush(COLOR);
			}

			string s = this.Owner.Disname;
			SizeF sizefText = g.MeasureString(s,f);

			float sx = ctct.X - sizefText.Width/2;
			float sy = ctct.Y + FONTYMARGIN;

			g.DrawString(s,f,b,sx,sy);

			g.DrawLine(p,ltdn,ctup);
			g.DrawLine(p,ctup,rtdn);
			g.DrawLine(p,rtdn,ltdn);

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
			Rectangle brect = new Rectangle(ltdn.X, ctup.Y,BFWIDTH,BFHEIGHT);
			return brect.Contains(point);
		}

		public override bool IntersectsWith(Rectangle rect)
		{
			Rectangle brect = new Rectangle(ltdn.X, ctup.Y,BFWIDTH,BFHEIGHT);
			return brect.IntersectsWith(rect);
		}
		#endregion

		#region move
		public override void Move(int dx, int dy)
		{
			ltdn.X += dx;
			ltdn.Y += dy;

			ctup.X += dx;
			ctup.Y += dy;

			rtdn.X += dx;
			rtdn.Y += dy;

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
				case DRWObj.CONPONT.LtCt:
					rpoint = new Point(ltdn.X+5, ctct.Y);
					break;
				case DRWObj.CONPONT.RtCt:
					rpoint = new Point(rtdn.X-5, ctct.Y);
					break;
				case DRWObj.CONPONT.CtUp:
					rpoint = ctup;
					break;
				case DRWObj.CONPONT.CtDn:
					rpoint = new Point(ctct.X, ltdn.Y);
					break;
				case DRWObj.CONPONT.LtDn:
					rpoint = ltdn;
					break;
				case DRWObj.CONPONT.RtDn:
					rpoint = rtdn;
					break;
				case DRWObj.CONPONT.AnCh:
					rpoint = anch;
					break;
			}

			return rpoint;
		}

		public override DRWObj.CONPONT GetConPointType(Point point)
		{
			if(point.Y > ctct.Y + 3)
				return DRWObj.CONPONT.CtDn;
			else if(point.X > ctct.X)
				return DRWObj.CONPONT.RtCt;
			else
				return DRWObj.CONPONT.LtCt;
		}
		#endregion
	}
}
