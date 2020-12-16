using System;
using System.Windows.Forms;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// ToolPointer에 대한 요약 설명입니다.
	/// </summary>
	public class ToolPointer : Q_Modeler.ToolObject
	{
		public ToolPointer()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
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
