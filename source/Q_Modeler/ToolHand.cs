using System;
using System.Drawing;
using System.Windows.Forms;

namespace Q_Modeler
{
	/// <summary>
	/// ToolHand�� ���� ��� �����Դϴ�.
	/// </summary>
	public class ToolHand : Q_Modeler.ToolObject
	{
		public ToolHand()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
			//
		}

		public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
		{
			drawArea.Mgr.Gudpnt.OnMouseDown(drawArea, e);
		}

		public override void OnMouseMove(DrawArea drawArea, MouseEventArgs e)
		{	
			drawArea.Mgr.Gudpnt.OnMouseMove(drawArea, e);
			drawArea.Refresh();
		}

		public override void OnMouseUp(DrawArea drawArea, MouseEventArgs e)
		{
			drawArea.Mgr.Gudpnt.OnMouseUp(drawArea, e);
		}

		public override void OnMouseWheel(DrawArea drawArea, MouseEventArgs e)
		{
			drawArea.Mgr.Gudpnt.OnMouseWheel(drawArea, e);
			drawArea.Refresh();
		}
	}
}
