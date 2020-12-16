using System;
using System.Windows.Forms;
using System.Drawing;


namespace Q_Modeler
{
	/// <summary>
	/// Tool�� ���� ��� �����Դϴ�.
	/// </summary>
	public abstract class Tool
	{
		public virtual void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
		{
		}

		public virtual void OnMouseMove(DrawArea drawArea, MouseEventArgs e)
		{
		}

		public virtual void OnMouseUp(DrawArea drawArea, MouseEventArgs e)
		{
		}	

		public virtual void OnMouseDoubleDown(DrawArea drawArea, MouseEventArgs e)
		{
			drawArea.Mgr.PopUp(drawArea, e);
		}

		public virtual void OnMouseWheel(DrawArea drawArea, MouseEventArgs e)
		{
		}
	}
}
