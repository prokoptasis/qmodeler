using System;
using System.Windows.Forms;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// ToolCalendar에 대한 요약 설명입니다.
	/// </summary>
	public class ToolCalendar : Q_Modeler.ToolObject
	{
		public ToolCalendar()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
		{
			AddNewObject(drawArea, new FLOCal(drawArea.Mgr, e.X, e.Y));
		}

		public override void OnMouseMove(DrawArea drawArea, MouseEventArgs e)
		{
			if ( e.Button == MouseButtons.Left && drawArea.ActiveTool == DrawArea.DrawToolType.Pointer  )
			{
				drawArea.Mgr.Flolist[0].Drwobj.Move(e.X,e.Y);
				drawArea.Refresh();
			}
		}

		public override void OnMouseUp(DrawArea drawArea, MouseEventArgs e)
		{
			drawArea.Capture = false;
			drawArea.Refresh();
		}
	}
}
