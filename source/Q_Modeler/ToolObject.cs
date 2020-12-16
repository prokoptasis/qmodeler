using System;
using System.Windows.Forms;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// ToolObject�� ���� ��� �����Դϴ�.
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
