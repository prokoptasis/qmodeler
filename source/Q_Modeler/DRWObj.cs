using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using System.Drawing.Drawing2D;

namespace Q_Modeler
{
	/// <summary>
	/// DRWObj에 대한 요약 설명입니다.
	/// </summary>
	[Serializable]
	public abstract class DRWObj
	{
		#region public enum
		public enum CONPONT { LtUp, CtUp, RtUp, LtCt, CtCt, RtCt, LtDn, CtDn, RtDn, AnCh, NULL, NumberOfCPTType	}
		#endregion

		#region public const
		public const int	OPWIDTH		= 24;
		public const int	OPHEIGHT	= 18;
		public const int	BFWIDTH		= 24;
		public const int	BFHEIGHT	= 18;
		public const int	RESWIDTH	= 24;
		public const int	RESHEIGHT	= 18;
		public const int	PENWIDTH	= 1;
		public const int	CALWIDTH	= 24;
		public const int	CALHEIGHT	= 18;
		public const int	DMDWIDTH	= 24;
		public const int	DMDHEIGHT	= 18;
		public const int	STTWIDTH	= 54;
		public const int	STTHEIGHT	= 24;
		public const int	TEXTSIZE	= 8;
		public const int	FONTYMARGIN = 10;
		public static Color	COLOR		= Color.Black;
		public const string FONTNAME	= "Arial";
		#endregion

		#region local	variables
		private FLOObj	owner;
		public	bool	switchtext;
		#endregion

		#region local variables accessor
		public FLOObj Owner
		{
			get	{ return owner;	 }
			set	{ owner = value; }
		}
		#endregion

		#region virtual variable accessor
		public virtual Point CtCt
		{
			get { return new Point(0,0); }
			set { value = value; }
		}

		public virtual Point Spoint
		{
			get { return new Point(0,0); }
			set { value = value; }
		}

		public virtual Point Epoint
		{
			get { return new Point(0,0); }
			set { value = value; }
		}
		public virtual DRWObj.CONPONT Stype
		{
			get { return DRWObj.CONPONT.NULL; }
			set { value = value; }
		}
		public virtual DRWObj.CONPONT Etype
		{
			get { return DRWObj.CONPONT.NULL; }
			set { value = value; }
		}
		public virtual int Distype
		{
			get { return -1; }
			set { value = value; }
		}
		public virtual bool Switchtext
		{
			get { return switchtext; }
			set { switchtext = value; }
		}
		#endregion

		#region draw
		public virtual void Draw(Graphics g)
		{
		}
		#endregion

		#region move
		public virtual void Move(int dx, int dy)
		{
		}
		#endregion

		#region hittest
		public virtual bool HitTest(Point point)
		{
			bool result = false;

			return result;
		}
		#endregion

		#region pointinobject
		protected virtual bool PointInObject(Point point)
		{
			return false;
		}
		#endregion
		
		#region intersectswith
		public virtual bool IntersectsWith(Rectangle rect)
		{
			return false;
		}
		#endregion

		#region conpoint
		public virtual Point GetConPoint(DRWObj.CONPONT cptype)
		{
			Point rpoint = new Point(0,0);
			return rpoint;
		}

		public virtual DRWObj.CONPONT GetConPointType(Point point)
		{			
			return DRWObj.CONPONT.NULL;
		}

		public virtual void SetConPoint(FLOObj S, FLOObj E)
		{
		}
		#endregion

		#region drawobj resize
		public virtual void  DRWObjResize(int x, int y)
		{
		}
		#endregion
	}
}
