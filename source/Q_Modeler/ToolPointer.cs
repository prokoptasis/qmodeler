using System;
using System.Windows.Forms;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// ToolPointer�� ���� ��� �����Դϴ�.
	/// </summary>
	public class ToolPointer : Q_Modeler.ToolObject
	{
		public ToolPointer()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
			//
		}

		public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
		{
			drawArea.Mgr.Gudsrt.SelModeDown(drawArea.Mgr, e);
			drawArea.Refresh();
		}

		public override void OnMouseMove(DrawArea drawArea, MouseEventArgs e)
		{
			drawArea.Mgr.Gudsrt.SelModeMove(drawArea.Mgr, e);
			drawArea.Refresh();
		}

		public override void OnMouseUp(DrawArea drawArea, MouseEventArgs e)
		{
			drawArea.Mgr.Gudsrt.SelModeUp(drawArea.Mgr, e);
			drawArea.Capture = false;

			drawArea.Refresh();
		}
	}
}
