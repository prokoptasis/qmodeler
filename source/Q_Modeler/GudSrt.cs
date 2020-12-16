using System;
using System.Windows.Forms;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// GudSrt에 대한 요약 설명입니다.
	/// </summary>
	public class GudSrt
	{
		public GudSrt()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		#region enum
		public enum SelMode
		{
			SelNon,
			SelNet,				// group selection is active
			SelMov				// object(s) are moves			
		}
		#endregion

		#region local variables
		private Point	 spoint;
		private Point	 epoint;
		private Rectangle selrect;
		private SelMode	 selmode;
		private bool	 seldraw;
		private int		 gridpointx;
		private int		 gridpointy;
		private FLOObj gridobj;
		#endregion

		#region local variables accessor
		public SelMode Selmode
		{
			get { return selmode; }
			set { selmode = value; }
		}

		public Rectangle Selrect
		{
			get { return selrect; }
			set { selrect = value; }
		}

		public bool Seldraw
		{
			get { return seldraw; }
			set { seldraw = value; }
		}

		public int GridpointX
		{
			get { return gridpointx; }
			set { gridpointx = value; }
		}

		public int GridpointY
		{
			get { return gridpointy; }
			set { gridpointy = value; }
		}
		#endregion

		#region draw
		public void Draw(Graphics g)
		{
			ControlPaint.DrawFocusRectangle(g, selrect, Color.Black, Color.Transparent);
		}
		#endregion

		#region mouse handle
		public void SelModeDown(FLOMgr mgr, MouseEventArgs e)
		{
			if(this.Selmode == SelMode.SelNon)
			{
				FLOObj o = mgr.Flolist.GetObjByPoint(new Point(e.X,e.Y));

				if( o != null)
				{
					if((Control.ModifierKeys & Keys.Control) == 0  && !o.Selected)
						mgr.Flolist.UnselectAll();

					this.Selmode = GudSrt.SelMode.SelMov;
					this.gridobj = o;

					if((Control.ModifierKeys & Keys.Control) != 0)
					{
						o.Selected = !o.Selected;
						this.Selmode = GudSrt.SelMode.SelNon;
					}
					else
						o.Selected = true;
				}				
			}

			if (this.Selmode == SelMode.SelNon)
			{
				if((Control.ModifierKeys & Keys.Control) == 0)
					mgr.Flolist.UnselectAll();

				this.selrect = GetNormilizedRect(spoint,epoint);
				
				this.Selmode = GudSrt.SelMode.SelNet;

				this.Seldraw = true;
			}

			this.spoint = new Point(e.X, e.Y);
			this.epoint = new Point(e.X, e.Y);
		}

		private Rectangle GetNormilizedRect(Point spoint, Point epoint)
		{
			int x1 = spoint.X;
			int y1 = spoint.Y;
			int x2 = epoint.X;
			int y2 = epoint.Y;

			if ( x2 < x1 )
			{
				int tmp = x2;
				x2 = x1;				
				x1 = tmp;
			}

			if ( y2 < y1 )
			{
				int tmp = y2;
				y2 = y1;
				y1 = tmp;
			}

			Rectangle rectangle = new Rectangle(x1, y1, x2-x1, y2-y1);
			return rectangle;
		}

		public void SelModeMove(FLOMgr mgr, MouseEventArgs e)
		{
			if ( e.Button == MouseButtons.None || e.Button != MouseButtons.Left )
				return;

			epoint = new Point(e.X,e.Y);

			int gridx = e.X - this.GridpointX/2 + (this.GridpointX- ((e.X-this.GridpointX/2)%this.GridpointX));
			int gridy = e.Y - this.GridpointY/2 + (this.GridpointY- ((e.Y-this.GridpointY/2)%this.GridpointY));

			Point gridanch = new Point(0,0);

			if(gridobj != null)
                gridanch = gridobj.Drwobj.GetConPoint(DRWObj.CONPONT.AnCh);

			int dx = gridx - gridanch.X;
			int dy = gridy - gridanch.Y;

			if ( this.Selmode == GudSrt.SelMode.SelMov )
				mgr.Flolist.GetSelectedObjMove(dx, dy);

			if ( this.Selmode == GudSrt.SelMode.SelNet )
				mgr.Gudsrt.Selrect = mgr.Gudsrt.GetNormilizedRect(spoint,epoint);
		}

		public void SelModeUp(FLOMgr mgr, MouseEventArgs e)
		{
			if ( this.Selmode == GudSrt.SelMode.SelNet )			
			{
				mgr.Flolist.SelectByRect(this.selrect);
				this.Selmode = GudSrt.SelMode.SelNon;
				this.Seldraw = false;
			}

			this.selrect = new Rectangle(0,0,0,0);
			this.spoint = new Point(0,0);
			this.epoint = new Point(0,0);
			this.gridobj = null;

			this.Selmode = GudSrt.SelMode.SelNon;
		}
		#endregion
	}
}
