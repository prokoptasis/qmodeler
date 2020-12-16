using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Q_Modeler
{
	/// <summary>
	/// DRWOpe에 대한 요약 설명입니다.
	/// </summary>
	public class DRWOpe : DRWObj
	{
		public DRWOpe()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		#region local variables
		private Rectangle operation;
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
		public DRWOpe(FLOObj owner, int x, int y)
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			this.Owner = owner;
			operation = new Rectangle(x - OPWIDTH/2,y - OPHEIGHT/2,OPWIDTH,OPHEIGHT);
			ctct = new Point(x,y);
			anch = new Point(operation.X,operation.Y);
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

			g.DrawRectangle(p, operation);

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
			Rectangle rrect = new Rectangle(operation.X, operation.Y,OPWIDTH,OPHEIGHT);
			return rrect.Contains(point);
		}

		public override bool IntersectsWith(Rectangle rect)
		{
			Rectangle rrect = new Rectangle(operation.X, operation.Y,OPWIDTH,OPHEIGHT);
			return rrect.IntersectsWith(rect);
		}
		#endregion

		#region move
		public override void Move(int dx, int dy)
		{
			operation.X += dx;
			operation.Y += dy;

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
				case DRWObj.CONPONT.RtCt:
					rpoint = new Point(operation.Right, ctct.Y);
					break;
				case DRWObj.CONPONT.LtCt:
					rpoint = new Point(operation.Left, ctct.Y);
					break;
				case DRWObj.CONPONT.CtDn:
					rpoint = new Point(ctct.X, operation.Bottom);
					break;
				case DRWObj.CONPONT.CtUp:
					rpoint = new Point(ctct.X, operation.Top);
					break;
				case DRWObj.CONPONT.AnCh:
					rpoint = anch;
					break;
			}

			return rpoint;
		}

		public override DRWObj.CONPONT GetConPointType(Point point)
		{
			if(point.X > ctct.X + 4)
				return DRWObj.CONPONT.RtCt;
			else if(point.X < ctct.X - 4)
				return DRWObj.CONPONT.LtCt;
			else if(point.Y > ctct.Y)
				return DRWObj.CONPONT.CtDn;
			else
				return DRWObj.CONPONT.CtUp;
		}
		#endregion
	}
}
