using System;
using System.Windows.Forms;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// ToolDemand에 대한 요약 설명입니다.
	/// </summary>
	public class ToolDemand : Q_Modeler.ToolObject
	{
		public ToolDemand()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
		{
			AddNewObject(drawArea, new FLODmd(drawArea.Mgr, e.X, e.Y));
		}

		public override void OnMouseMove(DrawArea drawArea, MouseEventArgs e)
		{
			if ( e.Button == MouseButtons.Left && drawArea.ActiveTool == DrawArea.DrawToolType.Pointer )
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
