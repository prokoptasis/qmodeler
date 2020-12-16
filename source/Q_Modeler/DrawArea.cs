using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using DocToolkit;

namespace Q_Modeler
{
	/// <summary>
	/// DrawArea�� ���� ��� �����Դϴ�.
	/// </summary>
	public class DrawArea : System.Windows.Forms.UserControl
	{
		#region private variables
		/// <summary> 
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private Form1 owner;
		private DocManager docManager;
		#endregion

		#region private variables accessor
		public Form1 Owner
		{
			get	{ return owner;	 }
			set	{ owner = value; }
		}

		public DocManager DocManager
		{
			get { return docManager; }
			set { docManager = value; }
		}
		#endregion

		#region initializer
		public DrawArea()
		{
			// �� ȣ���� Windows.Forms Form �����̳ʿ� �ʿ��մϴ�.
			InitializeComponent();
			// TODO: InitializeComponent�� ȣ���� ���� �ʱ�ȭ �۾��� �߰��մϴ�.
		}
		#endregion

		#region ���� ��� �����̳ʿ��� ������ �ڵ�
		/// <summary> 
		/// �����̳� ������ �ʿ��� �޼����Դϴ�. 
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// DrawArea
			// 
			this.Name = "DrawArea";
			this.Resize += new System.EventHandler(this.DrawArea_Resize);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseUp);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawArea_Paint);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DrawArea_KeyDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseMove);
			this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseWheel);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseDown);
		}
		#endregion

		#region ��ο���Ÿ�� �γ�
		/// <summary>
		/// DrawToolType Enum
		/// </summary>
		public enum DrawToolType
		{
			Pointer,
			Hand,
			Buffer,
			Operation,
			Resource,
			Calendar,
			Demand,
			Connection,
			NumberOfDrawTools
		};
		#endregion

		#region ��Į����
		/// <summary>
		/// ��ο쿡���� ��Į ����
		/// </summary>
		private FLOMgr			mgr = new FLOMgr();
		private DrawToolType	activeTool;
		private Tool[]			tools;
		private Rectangle		netRectangle;
		private bool			drawNetRectangle = false;
		#endregion

		#region ��ο쿡���� ��Į���� ������
		/// <summary>
		/// ��ο쿡���� ������
		/// </summary>
		public FLOMgr Mgr
		{
			get { return mgr; }
			set { mgr = value; }
		}

		public Rectangle NetRectangle
		{
			get { return netRectangle; }
			set	{ netRectangle = value; }
		}

		public bool DrawNetRectangle
		{
			get { return drawNetRectangle; }
			set { drawNetRectangle = value; }
		}

		public DrawToolType ActiveTool
		{
			get { return activeTool; }
			set { activeTool = value; }
		}
		#endregion

		#region ���콺 �̺�Ʈ �ڵ鷯
		/// <summary>
		/// ���콺 �̺�Ʈ �ڵ鷯
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DrawArea_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			tools[(int)DrawToolType.Hand].OnMouseWheel(this, e);
		}

		private void DrawArea_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Clicks > 1 && activeTool == DrawToolType.Pointer)
				tools[(int)activeTool].OnMouseDoubleDown(this, e);
			else if ( e.Clicks == 1 && e.Button == MouseButtons.Left )
				tools[(int)activeTool].OnMouseDown(this, e);
			else if ( e.Button == MouseButtons.Right && activeTool == DrawToolType.Pointer)
				OnContextMenu(e);			
		}

		private void DrawArea_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ( e.Button == MouseButtons.Left  ||  e.Button == MouseButtons.None )
				tools[(int)activeTool].OnMouseMove(this, e);
		}

		private void DrawArea_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ( e.Button == MouseButtons.Left )
				tools[(int)activeTool].OnMouseUp(this, e);
		}

		public void MouseDoubleDown()
		{
			tools[(int)activeTool].OnMouseDoubleDown(this,null);
		}
		#endregion

		#region �̴ϼȶ�����
		/// <summary>
		/// �̴ϼȶ�����
		/// </summary>
		/// <param name="f"></param>
		public void Initialize(Form1 f, DocManager docManager)
		{
			this.ActiveTool = Q_Modeler.DrawArea.DrawToolType.Pointer;
//
//			this.Location = new System.Drawing.Point(24, 79);
			this.Name = "drawArea";
//			this.NetRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
//			this.Size = new System.Drawing.Size(272, 107);
//			this.TabIndex = 1;
//			
			this.Mgr.Gudcon = new GudCon();
			this.Mgr.Gudsrt = new GudSrt();
			this.Mgr.Gudpnt = new GudPnt();
			
			this.Mgr.Gudsrt.GridpointX = 1;
			this.Mgr.Gudsrt.GridpointY = 1;

			this.Owner = f;
			this.DocManager = docManager;

			SetStyle(ControlStyles.AllPaintingInWmPaint|ControlStyles.UserPaint|ControlStyles.DoubleBuffer, true);

			Mgr.Flolist = new FLOList();

			tools = new Tool[(int)DrawToolType.NumberOfDrawTools];
			tools[(int)DrawToolType.Pointer]	= new ToolPointer();
			tools[(int)DrawToolType.Hand]		= new ToolHand();
			tools[(int)DrawToolType.Buffer]		= new ToolBuffer();
			tools[(int)DrawToolType.Operation]	= new ToolOperation();
			tools[(int)DrawToolType.Resource]	= new ToolResource();
			tools[(int)DrawToolType.Calendar]	= new ToolCalendar();
			tools[(int)DrawToolType.Demand]		= new ToolDemand();
			tools[(int)DrawToolType.Connection] = new ToolConnection();
		}
		#endregion
		
		#region setdirty
		public void SetDirty()
		{
			DocManager.Dirty = true;
		}
		#endregion

		#region dispose
		/// <summary> 
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region DrawArea Paint
		/// <summary>
		/// ��ο쿡���� ����Ʈ �������̵�
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DrawArea_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255));
			e.Graphics.FillRectangle(brush,this.ClientRectangle);

			if(Mgr.Flolist.Count > 0 || Mgr.Gudcon != null || Mgr.Gudsrt != null)
			{
				FLOObj o = Mgr.Flolist.GetFLOSttObj();
				
				if(o != null && o.Drwobj == null)
					o.Drwobj = new DRWStt(o,this.ClientRectangle.Right,this.ClientRectangle.Top);

				Mgr.Draw(e.Graphics);
			}
		
			if(this.Mgr.Gudsrt.GridpointX != 1)
				ControlPaint.DrawGrid(e.Graphics,this.ClientRectangle,new Size((this.Mgr.Gudsrt.GridpointX),(this.Mgr.Gudsrt.GridpointY)),Color.Gray);

			this.owner.statusBar1.Text = this.Mgr.Gudsrt.Seldraw.ToString();

			brush.Dispose();
		}
		#endregion

		#region DrawNetSelection
		/// <summary> 
		/// ������ �簢���� �׷��ش�
		/// </summary>
		private void DrawNetSelection(Graphics g)
		{
			if ( ! DrawNetRectangle )
				return;

			ControlPaint.DrawFocusRectangle(g, NetRectangle, Color.Black, Color.Transparent);
		}
		#endregion

		#region Drawarea keydown
		/// <summary> 
		/// Ű�̺�Ʈ ó��
		/// </summary>
		private void DrawArea_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch(e.KeyData)
			{
				case Keys.Escape:
					owner.CommandClose();
					break;
				case Keys.Delete:
					Mgr.Flolist.Delete();
					this.Refresh();
					break;
				case (Keys.Control|Keys.A):
					Mgr.Flolist.SelectAll();
					this.Refresh();
					break;
				case (Keys.Control|Keys.U):
					Mgr.Flolist.UnselectAll();
					this.Refresh();
					break;
				case (Keys.T):
					ActiveTool = DrawArea.DrawToolType.Pointer;
					break;
				case (Keys.H):
					ActiveTool = DrawArea.DrawToolType.Hand;
					break;
				case (Keys.C):
					ActiveTool = DrawArea.DrawToolType.Connection;
					break;
				case (Keys.B):
					ActiveTool = DrawArea.DrawToolType.Buffer;
					break;
				case (Keys.A):
					ActiveTool = DrawArea.DrawToolType.Operation;
					break;
				case (Keys.R):
					ActiveTool = DrawArea.DrawToolType.Resource;
					break;
				case (Keys.E):
					ActiveTool = DrawArea.DrawToolType.Calendar;
					break;
				case (Keys.D):
					ActiveTool = DrawArea.DrawToolType.Demand;
					break;
			}
		}
		#endregion

		#region Oncontext menu
		/// <summary>
		/// �����ؽ�Ʈ �޴�
		/// </summary>
		/// <param name="e"></param>
		private void OnContextMenu(MouseEventArgs e)
		{
			// Change current selection if necessary
			Point point = new Point(e.X, e.Y);

			int n = Mgr.Flolist.Count;

			FLOObj o = null;

			for ( int i = 0; i < n; i++ )
			{
				if(Mgr.Flolist[i].Drwobj.HitTest(point))
				{
					o = mgr.Flolist[i];
					break;
				}
			}

			if ( o != null )
			{
				if ( ! o.Selected )
					mgr.Flolist.UnselectAll();

				// Select clicked object
				o.Selected = true;
			}	
			else
			{
				mgr.Flolist.UnselectAll();
			}

			Refresh();

			MainMenu mainMenu = owner.Menu;					// Main menu
			MenuItem editItem = mainMenu.MenuItems[1];      // Edit submenu
			MenuItem[] items = new MenuItem[editItem.MenuItems.Count];

			for ( int i = 0; i < editItem.MenuItems.Count; i++ )
			{
				items[i] = editItem.MenuItems[i];
			}

			owner.SetStateOfControls();
			ContextMenu menu = new ContextMenu(items);
			menu.Show(this, point);
			editItem.MergeMenu(menu);
		}
		#endregion

		private void DrawArea_Resize(object sender, System.EventArgs e)
		{
			this.Mgr.FLOSttResize(this);
			this.Refresh();
		}
	}
}
