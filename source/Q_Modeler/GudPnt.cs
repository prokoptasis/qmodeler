using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Q_Modeler
{
	/// <summary>
	/// GudPnt에 대한 요약 설명입니다.
	/// </summary>
	public class GudPnt
	{
		public GudPnt()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		#region local variables
		private Point spoint;
		private Point epoint;
		private bool  handng;
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
		#endregion

		#region mouse handle
		public void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
		{
			int cx = e.X - e.X%drawArea.Mgr.Gudsrt.GridpointX + drawArea.Mgr.Gudsrt.GridpointX/2 ;
			int cy = e.Y - e.Y%drawArea.Mgr.Gudsrt.GridpointY + drawArea.Mgr.Gudsrt.GridpointY/2 ;
			
			this.Spoint = new Point(cx,cy);
			handng = true;
		}

		public void OnMouseMove(DrawArea drawArea, MouseEventArgs e)
		{
			if ( e.Button == MouseButtons.None || e.Button != MouseButtons.Left )
				return;

			this.Epoint = new Point(e.X,e.Y);
			
			int gridx = e.X - e.X%drawArea.Mgr.Gudsrt.GridpointX + drawArea.Mgr.Gudsrt.GridpointX/2;
			int gridy = e.Y - e.Y%drawArea.Mgr.Gudsrt.GridpointY + drawArea.Mgr.Gudsrt.GridpointY/2;

			Point gridanch = new Point(0,0);
			
			if(Spoint.X != 0 && Spoint.Y != 0)
				gridanch = new Point(Spoint.X, Spoint.Y);
			
			int dx = gridx - gridanch.X;
			int dy = gridy - gridanch.Y;

			if ( e.Button == MouseButtons.Left && handng)
				drawArea.Mgr.Flolist.GetAllObjMove(dx,dy);

			this.Spoint = new Point(Spoint.X + dx, Spoint.Y + dy);
		}

		public void OnMouseUp(DrawArea drawArea, MouseEventArgs e)
		{
			this.Spoint = new Point(0,0);
			this.Epoint = new Point(0,0);
			handng = false;
		}

		public void OnMouseWheel(DrawArea drawArea, MouseEventArgs e)
		{
			if( e.Delta == 0)
				return;

			int delta = (int)(e.Delta*0.01)*drawArea.Mgr.Gudsrt.GridpointY;

			drawArea.Mgr.Flolist.GetAllObjMove(0,delta);
		}
		#endregion
	}
}
