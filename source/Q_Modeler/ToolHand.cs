using System;
using System.Drawing;
using System.Windows.Forms;

namespace Q_Modeler
{
	/// <summary>
	/// ToolHand에 대한 요약 설명입니다.
	/// </summary>
	public class ToolHand : Q_Modeler.ToolObject
	{
		public ToolHand()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
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
