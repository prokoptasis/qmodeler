using System;
using System.Windows.Forms;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// ToolOperation�� ���� ��� �����Դϴ�.
	/// </summary>
	public class ToolOperation : Q_Modeler.ToolObject
	{
		public ToolOperation()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
			//
		}

		public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
		{
			AddNewObject(drawArea, new FLOOpe(drawArea.Mgr, e.X, e.Y));
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
