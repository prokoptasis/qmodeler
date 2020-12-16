using System;
using System.Windows.Forms;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// ToolObject에 대한 요약 설명입니다.
	/// </summary>
	public abstract class ToolObject : Q_Modeler.Tool
	{
		protected void AddNewObject(DrawArea drawArea, FLOObj o)
		{
			drawArea.Mgr.AddFLOObj(drawArea,o);
			drawArea.Refresh();
		}
	}
}
