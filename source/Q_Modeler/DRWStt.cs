using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;

namespace Q_Modeler
{
	/// <summary>
	/// DRWStt에 대한 요약 설명입니다.
	/// </summary>
	public class DRWStt : DRWObj
	{
		public DRWStt()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		#region local variables
		private Rectangle sttrect;
		private Point ctct;
		private Point anch;
		#endregion

		#region local variables
		public override Point CtCt
		{
			get { return anch; }
			set { anch = value; }
		}
		#endregion

		#region Initilizer
		public DRWStt(FLOObj owner, int x, int y)
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			this.Owner = owner;

			DRWObjResize(x, y);
		}

		public override void DRWObjResize(int x, int y)
		{
			sttrect = new Rectangle(x - STTWIDTH - 12, y + 12, STTWIDTH, STTHEIGHT);

			ctct	= new Point(sttrect.X + STTWIDTH/2, sttrect.Y + STTHEIGHT/2);
			anch	= new Point(sttrect.X,sttrect.Y);
		}
		#endregion

		#region draw
		public override void Draw(Graphics g)
		{
			g.SmoothingMode = SmoothingMode.AntiAlias;

			Pen p;
			Font f;
			SolidBrush b;

			p = new Pen(Color.Gray,PENWIDTH);
			f = new Font(FONTNAME,TEXTSIZE);
			b = new SolidBrush(Color.Gray);
			
			string s = this.Owner.Disname;
			SizeF sizefText = g.MeasureString(s,f);

			float sx = ctct.X - sizefText.Width/2;
			float sy = ctct.Y - sizefText.Height/2;

			g.FillRectangle(b,sttrect.X + 2, sttrect.Y + 2, sttrect.Width,sttrect.Height);

			b = new SolidBrush(Color.LightSkyBlue);
			g.FillRectangle(b, sttrect);

			if(this.Owner.Selected)
			{
				b = new SolidBrush(Color.BlueViolet);
				g.FillRectangle(b, sttrect.X - 1, sttrect.Y - 1, sttrect.Width + 2,sttrect.Height + 2);
			}

			b = new SolidBrush(Color.White);
			
			g.DrawString(s,f,b,sx,sy);

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
			Rectangle rrect = new Rectangle(sttrect.X, sttrect.Y,STTWIDTH,STTHEIGHT);
			return rrect.Contains(point);
		}

		public override bool IntersectsWith(Rectangle rect)
		{
			Rectangle srect = new Rectangle(sttrect.X, sttrect.Y,STTWIDTH,STTHEIGHT);
			return srect.IntersectsWith(rect);
		}
		#endregion

		#region move
		public override void Move(int dx, int dy)
		{
		}
		#endregion

		#region getconpoint/type
		public override Point GetConPoint(DRWObj.CONPONT cptype)
		{
			Point rpoint = new Point(0,0);
			return rpoint;
		}

		public override DRWObj.CONPONT GetConPointType(Point point)
		{
			return DRWObj.CONPONT.NULL;
		}
		#endregion
	}
}
