using System;
using System.Drawing;
using System.Windows.Forms;

namespace Q_Modeler
{
	/// <summary>
	/// ToolConnection�� ���� ��� �����Դϴ�.
	/// </summary>
	public class ToolConnection : Q_Modeler.ToolObject
	{
		public ToolConnection()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
			//
		}

		public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
		{
			drawArea.Mgr.Gudcon.Show(drawArea.Mgr,e.X,e.Y);
		}

		public override void OnMouseMove(DrawArea drawArea, MouseEventArgs e)
		{
			if ( e.Button == MouseButtons.Left )
			{
				drawArea.Mgr.Gudcon.Move(e.X,e.Y);
			}

			drawArea.Mgr.Gudcon.ShowConPoint(drawArea.Mgr, e.X, e.Y);
			drawArea.Refresh();
		}

		public override void OnMouseUp(DrawArea drawArea, MouseEventArgs e)
		{
			drawArea.Mgr.Gudcon.Hide(drawArea.Mgr,e.X,e.Y);
			AddNewObject(drawArea, drawArea.Mgr.AddFLOCon(drawArea));
		}
	}
}
