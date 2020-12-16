using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Microsoft.Win32;
using System.Diagnostics;
using System.Security;
using System.Runtime.Serialization;
using DocToolkit;
using ODS_Exporter;

namespace Q_Modeler
{
	/// <summary>
	/// Form1에 대한 요약 설명입니다.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Q_Modeler.DrawArea drawArea;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuFileNew;
		private System.Windows.Forms.MenuItem menuFileOpen;
		private System.Windows.Forms.MenuItem menuFileSave;
		private System.Windows.Forms.MenuItem menuFileSaveAs;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuEditSelectAll;
		private System.Windows.Forms.MenuItem menuEditUnselectAll;
		private System.Windows.Forms.MenuItem menuEditDelete;
		private System.Windows.Forms.MenuItem menuEditDeleteAll;
		private System.Windows.Forms.MenuItem menuDraw;
		private System.Windows.Forms.MenuItem menuDrawBuffer;
		private System.Windows.Forms.MenuItem menuDrawOperation;
		private System.Windows.Forms.MenuItem menuDrawResource;
		private System.Windows.Forms.MenuItem menuDrawCalendar;
		private System.Windows.Forms.MenuItem menuDrawDemand;
		private System.Windows.Forms.MenuItem menuDrawConnection;
		private System.Windows.Forms.MenuItem menuDrawPointer;
		private System.Windows.Forms.MenuItem menuDrawHand;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem27;
		private System.Windows.Forms.ToolBarButton tbNew;
		private System.Windows.Forms.ToolBarButton tbOpen;
		private System.Windows.Forms.ToolBarButton tbSave;
		private System.Windows.Forms.ToolBarButton tbBuffer;
		private System.Windows.Forms.ToolBarButton tbOperation;
		private System.Windows.Forms.ToolBarButton tbResource;
		private System.Windows.Forms.ToolBarButton tbCalendar;
		private System.Windows.Forms.ToolBarButton tbDemand;
		private System.Windows.Forms.ToolBarButton tbConnection;
		private System.Windows.Forms.ToolBarButton tbPointer;
		private System.Windows.Forms.ToolBarButton tbHand;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.MenuItem menuEditMoveToFront;
		private System.Windows.Forms.MenuItem menuEditMoveToBack;
		private System.Windows.Forms.ToolBarButton tbAbout;
		public System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuEditProperties;
		private System.ComponentModel.IContainer components;

		#region File members
		private ODSExporter			odsExporter;
		private DocManager			docManager;
		private DragDropManager		dragDropManager;
		private MruManager			mruManager;
		private PersistWindowState	persistState;
		private string				argumentFile	= "";
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuFileRecentFiles;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuViewGrid5pt;
		private System.Windows.Forms.MenuItem menuViewGrid10pt;
		private System.Windows.Forms.MenuItem menuViewGrid15pt;
		private System.Windows.Forms.MenuItem menuViewGrid20pt;
		private System.Windows.Forms.MenuItem menuViewGrid25pt;
		private System.Windows.Forms.MenuItem menuViewGrid30pt;
		private System.Windows.Forms.MenuItem menuViewGridOff;
		private System.Windows.Forms.MenuItem menuViewGridFitSize;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuFileExportCSV;
		private System.Windows.Forms.MenuItem menuDrawMaster;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.ToolBarButton tbMaster;   // file name from command line
		const	string registryPath	= "Software\\Jhook\\Q_Modeler";
		#endregion

		#region File members Accessor
		public string ArgumentFile
		{
			get { return argumentFile; }
			set { argumentFile = value; }
		}
		#endregion

		#region initializer
		public Form1()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
            persistState = new PersistWindowState(registryPath, this);
		}
		#endregion

		#region dispose
		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.drawArea = new Q_Modeler.DrawArea();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuFileNew = new System.Windows.Forms.MenuItem();
			this.menuFileOpen = new System.Windows.Forms.MenuItem();
			this.menuFileSave = new System.Windows.Forms.MenuItem();
			this.menuFileSaveAs = new System.Windows.Forms.MenuItem();
			this.menuItem27 = new System.Windows.Forms.MenuItem();
			this.menuFileRecentFiles = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuFileExportCSV = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuEditSelectAll = new System.Windows.Forms.MenuItem();
			this.menuEditUnselectAll = new System.Windows.Forms.MenuItem();
			this.menuEditDelete = new System.Windows.Forms.MenuItem();
			this.menuEditDeleteAll = new System.Windows.Forms.MenuItem();
			this.menuItem26 = new System.Windows.Forms.MenuItem();
			this.menuEditMoveToFront = new System.Windows.Forms.MenuItem();
			this.menuEditMoveToBack = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuEditProperties = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuViewGridOff = new System.Windows.Forms.MenuItem();
			this.menuViewGrid5pt = new System.Windows.Forms.MenuItem();
			this.menuViewGrid10pt = new System.Windows.Forms.MenuItem();
			this.menuViewGrid15pt = new System.Windows.Forms.MenuItem();
			this.menuViewGrid20pt = new System.Windows.Forms.MenuItem();
			this.menuViewGrid25pt = new System.Windows.Forms.MenuItem();
			this.menuViewGrid30pt = new System.Windows.Forms.MenuItem();
			this.menuViewGridFitSize = new System.Windows.Forms.MenuItem();
			this.menuDraw = new System.Windows.Forms.MenuItem();
			this.menuDrawPointer = new System.Windows.Forms.MenuItem();
			this.menuDrawHand = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuDrawMaster = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuDrawBuffer = new System.Windows.Forms.MenuItem();
			this.menuDrawOperation = new System.Windows.Forms.MenuItem();
			this.menuDrawResource = new System.Windows.Forms.MenuItem();
			this.menuDrawCalendar = new System.Windows.Forms.MenuItem();
			this.menuDrawDemand = new System.Windows.Forms.MenuItem();
			this.menuDrawConnection = new System.Windows.Forms.MenuItem();
			this.menuItem24 = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.tbNew = new System.Windows.Forms.ToolBarButton();
			this.tbOpen = new System.Windows.Forms.ToolBarButton();
			this.tbSave = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.tbPointer = new System.Windows.Forms.ToolBarButton();
			this.tbHand = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.tbBuffer = new System.Windows.Forms.ToolBarButton();
			this.tbOperation = new System.Windows.Forms.ToolBarButton();
			this.tbResource = new System.Windows.Forms.ToolBarButton();
			this.tbCalendar = new System.Windows.Forms.ToolBarButton();
			this.tbDemand = new System.Windows.Forms.ToolBarButton();
			this.tbConnection = new System.Windows.Forms.ToolBarButton();
			this.tbMaster = new System.Windows.Forms.ToolBarButton();
			this.tbAbout = new System.Windows.Forms.ToolBarButton();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.SuspendLayout();
			// 
			// drawArea
			// 
			this.drawArea.ActiveTool = Q_Modeler.DrawArea.DrawToolType.Pointer;
			this.drawArea.DocManager = null;
			this.drawArea.DrawNetRectangle = false;
			this.drawArea.Location = new System.Drawing.Point(24, 79);
			this.drawArea.Name = "drawArea";
			this.drawArea.NetRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
			this.drawArea.Owner = null;
			this.drawArea.Size = new System.Drawing.Size(272, 107);
			this.drawArea.TabIndex = 1;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.White;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem7,
																					  this.menuItem4,
																					  this.menuDraw,
																					  this.menuItem24});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuFileNew,
																					  this.menuFileOpen,
																					  this.menuFileSave,
																					  this.menuFileSaveAs,
																					  this.menuItem27,
																					  this.menuFileRecentFiles,
																					  this.menuItem3,
																					  this.menuItem8,
																					  this.menuItem6,
																					  this.menuFileExit});
			this.menuItem1.Text = "File";
			// 
			// menuFileNew
			// 
			this.menuFileNew.Index = 0;
			this.menuFileNew.Text = "New";
			this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
			// 
			// menuFileOpen
			// 
			this.menuFileOpen.Index = 1;
			this.menuFileOpen.Text = "Open";
			this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
			// 
			// menuFileSave
			// 
			this.menuFileSave.Index = 2;
			this.menuFileSave.Text = "Save";
			this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
			// 
			// menuFileSaveAs
			// 
			this.menuFileSaveAs.Index = 3;
			this.menuFileSaveAs.Text = "Save As";
			this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
			// 
			// menuItem27
			// 
			this.menuItem27.Index = 4;
			this.menuItem27.Text = "-";
			// 
			// menuFileRecentFiles
			// 
			this.menuFileRecentFiles.Index = 5;
			this.menuFileRecentFiles.Text = "Recent Files";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 6;
			this.menuItem3.Text = "-";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 7;
			this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuFileExportCSV});
			this.menuItem8.Text = "Export to ...";
			// 
			// menuFileExportCSV
			// 
			this.menuFileExportCSV.Index = 0;
			this.menuFileExportCSV.Text = "Flat FIles (*.dat)";
			this.menuFileExportCSV.Click += new System.EventHandler(this.menuFileExportCSV_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 8;
			this.menuItem6.Text = "-";
			// 
			// menuFileExit
			// 
			this.menuFileExit.Index = 9;
			this.menuFileExit.Text = "Exit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 1;
			this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuEditSelectAll,
																					  this.menuEditUnselectAll,
																					  this.menuEditDelete,
																					  this.menuEditDeleteAll,
																					  this.menuItem26,
																					  this.menuEditMoveToFront,
																					  this.menuEditMoveToBack,
																					  this.menuItem2,
																					  this.menuEditProperties});
			this.menuItem7.Text = "Edit";
			// 
			// menuEditSelectAll
			// 
			this.menuEditSelectAll.Index = 0;
			this.menuEditSelectAll.Text = "Select All";
			this.menuEditSelectAll.Click += new System.EventHandler(this.menuEditSelectAll_Click);
			// 
			// menuEditUnselectAll
			// 
			this.menuEditUnselectAll.Index = 1;
			this.menuEditUnselectAll.Text = "Unselect All";
			this.menuEditUnselectAll.Click += new System.EventHandler(this.menuEditUnselectAll_Click);
			// 
			// menuEditDelete
			// 
			this.menuEditDelete.Index = 2;
			this.menuEditDelete.Text = "Delete";
			this.menuEditDelete.Click += new System.EventHandler(this.menuEditDelete_Click);
			// 
			// menuEditDeleteAll
			// 
			this.menuEditDeleteAll.Index = 3;
			this.menuEditDeleteAll.Text = "Delete All";
			this.menuEditDeleteAll.Click += new System.EventHandler(this.menuEditDeleteAll_Click);
			// 
			// menuItem26
			// 
			this.menuItem26.Index = 4;
			this.menuItem26.Text = "-";
			// 
			// menuEditMoveToFront
			// 
			this.menuEditMoveToFront.Index = 5;
			this.menuEditMoveToFront.Text = "Move to Front";
			this.menuEditMoveToFront.Click += new System.EventHandler(this.menuEditMoveToFront_Click);
			// 
			// menuEditMoveToBack
			// 
			this.menuEditMoveToBack.Index = 6;
			this.menuEditMoveToBack.Text = "Move to Back";
			this.menuEditMoveToBack.Click += new System.EventHandler(this.menuEditMoveToBack_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 7;
			this.menuItem2.Text = "-";
			// 
			// menuEditProperties
			// 
			this.menuEditProperties.Index = 8;
			this.menuEditProperties.Text = "Properties";
			this.menuEditProperties.Click += new System.EventHandler(this.menuEditProperties_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem5});
			this.menuItem4.Text = "View";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 0;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuViewGridOff,
																					  this.menuViewGrid5pt,
																					  this.menuViewGrid10pt,
																					  this.menuViewGrid15pt,
																					  this.menuViewGrid20pt,
																					  this.menuViewGrid25pt,
																					  this.menuViewGrid30pt,
																					  this.menuViewGridFitSize});
			this.menuItem5.Text = "Grid";
			// 
			// menuViewGridOff
			// 
			this.menuViewGridOff.Index = 0;
			this.menuViewGridOff.Text = "Off";
			this.menuViewGridOff.Click += new System.EventHandler(this.menuViewGridOff_Click);
			// 
			// menuViewGrid5pt
			// 
			this.menuViewGrid5pt.Index = 1;
			this.menuViewGrid5pt.Text = "5pt";
			this.menuViewGrid5pt.Click += new System.EventHandler(this.menuViewGrid5pt_Click);
			// 
			// menuViewGrid10pt
			// 
			this.menuViewGrid10pt.Checked = true;
			this.menuViewGrid10pt.Index = 2;
			this.menuViewGrid10pt.Text = "10pt";
			this.menuViewGrid10pt.Click += new System.EventHandler(this.menuViewGrid10pt_Click);
			// 
			// menuViewGrid15pt
			// 
			this.menuViewGrid15pt.Index = 3;
			this.menuViewGrid15pt.Text = "15pt";
			this.menuViewGrid15pt.Click += new System.EventHandler(this.menuViewGrid15pt_Click);
			// 
			// menuViewGrid20pt
			// 
			this.menuViewGrid20pt.Index = 4;
			this.menuViewGrid20pt.Text = "20pt";
			this.menuViewGrid20pt.Click += new System.EventHandler(this.menuViewGrid20pt_Click);
			// 
			// menuViewGrid25pt
			// 
			this.menuViewGrid25pt.Index = 5;
			this.menuViewGrid25pt.Text = "25pt";
			this.menuViewGrid25pt.Click += new System.EventHandler(this.menuViewGrid25pt_Click);
			// 
			// menuViewGrid30pt
			// 
			this.menuViewGrid30pt.Index = 6;
			this.menuViewGrid30pt.Text = "30pt";
			this.menuViewGrid30pt.Click += new System.EventHandler(this.menuViewGrid30pt_Click);
			// 
			// menuViewGridFitSize
			// 
			this.menuViewGridFitSize.Index = 7;
			this.menuViewGridFitSize.Text = "FitSize";
			this.menuViewGridFitSize.Click += new System.EventHandler(this.menuViewGridFitSize_Click);
			// 
			// menuDraw
			// 
			this.menuDraw.Index = 3;
			this.menuDraw.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuDrawPointer,
																					 this.menuDrawHand,
																					 this.menuItem23,
																					 this.menuDrawMaster,
																					 this.menuItem9,
																					 this.menuDrawBuffer,
																					 this.menuDrawOperation,
																					 this.menuDrawResource,
																					 this.menuDrawCalendar,
																					 this.menuDrawDemand,
																					 this.menuDrawConnection});
			this.menuDraw.Text = "Draw";
			// 
			// menuDrawPointer
			// 
			this.menuDrawPointer.Index = 0;
			this.menuDrawPointer.Text = "Pointer";
			this.menuDrawPointer.Click += new System.EventHandler(this.menuDrawPointer_Click);
			// 
			// menuDrawHand
			// 
			this.menuDrawHand.Index = 1;
			this.menuDrawHand.Text = "Hand";
			this.menuDrawHand.Click += new System.EventHandler(this.menuDrawHand_Click);
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 2;
			this.menuItem23.Text = "-";
			// 
			// menuDrawMaster
			// 
			this.menuDrawMaster.Index = 3;
			this.menuDrawMaster.Text = "Master";
			this.menuDrawMaster.Click += new System.EventHandler(this.menuDrawMaster_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 4;
			this.menuItem9.Text = "-";
			// 
			// menuDrawBuffer
			// 
			this.menuDrawBuffer.Index = 5;
			this.menuDrawBuffer.Text = "Buffer";
			this.menuDrawBuffer.Click += new System.EventHandler(this.menuDrawBuffer_Click);
			// 
			// menuDrawOperation
			// 
			this.menuDrawOperation.Index = 6;
			this.menuDrawOperation.Text = "Operation";
			this.menuDrawOperation.Click += new System.EventHandler(this.menuDrawOperation_Click);
			// 
			// menuDrawResource
			// 
			this.menuDrawResource.Index = 7;
			this.menuDrawResource.Text = "Resource";
			this.menuDrawResource.Click += new System.EventHandler(this.menuDrawResource_Click);
			// 
			// menuDrawCalendar
			// 
			this.menuDrawCalendar.Index = 8;
			this.menuDrawCalendar.Text = "Calendar";
			this.menuDrawCalendar.Click += new System.EventHandler(this.menuDrawCalendar_Click);
			// 
			// menuDrawDemand
			// 
			this.menuDrawDemand.Index = 9;
			this.menuDrawDemand.Text = "Demand";
			this.menuDrawDemand.Click += new System.EventHandler(this.menuDrawDemand_Click);
			// 
			// menuDrawConnection
			// 
			this.menuDrawConnection.Index = 10;
			this.menuDrawConnection.Text = "Connection";
			this.menuDrawConnection.Click += new System.EventHandler(this.menuDrawConnection_Click);
			// 
			// menuItem24
			// 
			this.menuItem24.Index = 4;
			this.menuItem24.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuHelpAbout});
			this.menuItem24.Text = "Help";
			// 
			// menuHelpAbout
			// 
			this.menuHelpAbout.Index = 0;
			this.menuHelpAbout.Text = "About";
			this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.tbNew,
																						this.tbOpen,
																						this.tbSave,
																						this.toolBarButton1,
																						this.tbPointer,
																						this.tbHand,
																						this.toolBarButton2,
																						this.tbBuffer,
																						this.tbOperation,
																						this.tbResource,
																						this.tbCalendar,
																						this.tbDemand,
																						this.tbConnection,
																						this.tbMaster,
																						this.tbAbout});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(511, 28);
			this.toolBar1.TabIndex = 0;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// tbNew
			// 
			this.tbNew.ImageIndex = 8;
			// 
			// tbOpen
			// 
			this.tbOpen.ImageIndex = 9;
			// 
			// tbSave
			// 
			this.tbSave.ImageIndex = 10;
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbPointer
			// 
			this.tbPointer.ImageIndex = 6;
			// 
			// tbHand
			// 
			this.tbHand.ImageIndex = 7;
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbBuffer
			// 
			this.tbBuffer.ImageIndex = 0;
			// 
			// tbOperation
			// 
			this.tbOperation.ImageIndex = 1;
			// 
			// tbResource
			// 
			this.tbResource.ImageIndex = 2;
			// 
			// tbCalendar
			// 
			this.tbCalendar.ImageIndex = 3;
			// 
			// tbDemand
			// 
			this.tbDemand.ImageIndex = 4;
			// 
			// tbConnection
			// 
			this.tbConnection.ImageIndex = 5;
			// 
			// tbMaster
			// 
			this.tbMaster.ImageIndex = 11;
			// 
			// tbAbout
			// 
			this.tbAbout.ImageIndex = 12;
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 241);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(511, 22);
			this.statusBar1.TabIndex = 2;
			this.statusBar1.Text = "statusBar1";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(511, 263);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.drawArea);
			this.Controls.Add(this.toolBar1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Q_Modeler";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		#region main
		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main(string[] args) 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
			
			if( args.Length > 1 ) 
			{
				MessageBox.Show("Incorrect number of arguments. Usage: Q_Modler.exe [file]", "Q_Modelers");
			}

			Form1 form = new Form1();

			if ( args.Length == 1 ) 
				form.ArgumentFile = args[0];

			Application.Run(new Form1());
		}
		#endregion

		#region form1_load
		private void Form1_Load(object sender, System.EventArgs e)
		{
			InitializeHelperObjects();
			LoadSettingsFromRegistry();

			ResizeDrawArea(); 
			drawArea.Initialize(this, docManager);

			this.drawArea.Mgr.Gudsrt.GridpointX = persistState.GridpointX;
			this.drawArea.Mgr.Gudsrt.GridpointY = persistState.GridpointY;

			Application.Idle += new EventHandler(Application_Idle);

			// Open file passed in the command line
			if ( ArgumentFile.Length > 0 )
				OpenDocument(ArgumentFile);
		}
		#endregion

		#region initializehelperobjects
		private void InitializeHelperObjects()
		{
			// DocManager
			DocManagerData data = new DocManagerData();
			data.FormOwner = this;
			data.UpdateTitle = true;
			data.FileDialogFilter = "MaBongPal files (*.mbp)|*.mbp|All Files (*.*)|*.*";
			data.NewDocName = "Untitled.mbp";
			data.RegistryPath = registryPath;
			docManager = new DocManager(data);
			docManager.RegisterFileType("mbp", "mbpfile", "MaBongPal File");
			docManager.SaveEvent +=new SaveEventHandler(docManager_SaveEvent);
			docManager.LoadEvent +=new LoadEventHandler(docManager_LoadEvent);
			docManager.OpenEvent += new OpenFileEventHandler(docManager_OpenEvent);
			docManager.DocChangedEvent += new EventHandler(docManager_DocChangedEvent);
			docManager.ClearEvent += new EventHandler(docManager_ClearEvent);
			docManager.NewDocument();
			// DragDropManager
			dragDropManager = new DragDropManager(this);
			dragDropManager.FileDroppedEvent += new FileDroppedEventHandler(this.dragDropManager_FileDroppedEvent); 
			// MruManager
			mruManager = new MruManager();
			mruManager.Initialize(this,menuFileRecentFiles,registryPath);
			mruManager.MruOpenEvent += new MruFileOpenEventHandler(mruManager_MruOpenEvent);

			// ODSExporter
			odsExporter = new ODSExporter();
		}
		#endregion

		#region docmanager saveevent
		private void docManager_SaveEvent(object sender, SerializationEventArgs e)
		{
			// DocManager asks to save document to supplied stream
			try
			{
				e.Formatter.Serialize(e.SerializationStream, drawArea.Mgr.Flolist);
			}
			catch ( ArgumentNullException ex )
			{
				HandleSaveException(ex, e);
			}
			catch ( SerializationException ex )
			{
				HandleSaveException(ex, e);
			}
			catch ( SecurityException ex )
			{
				HandleSaveException(ex, e);
			}
		}

		private void HandleSaveException(Exception ex, SerializationEventArgs e)
		{
			MessageBox.Show(this, "Save File operation failed. File name: " + e.FileName + "\n" + "Reason: " + ex.Message, Application.ProductName);
			e.Error = true;
		}
		#endregion

		#region docmanager load event
		private void docManager_LoadEvent(object sender, SerializationEventArgs e)
		{
			// DocManager asks to load document from supplied stream
			try
			{
				drawArea.Mgr.Flolist = (FLOList)e.Formatter.Deserialize(e.SerializationStream);
			}
			catch ( ArgumentNullException ex )
			{
				HandleLoadException(ex, e);
			}
			catch ( SerializationException ex )
			{
				HandleLoadException(ex, e);
			}
			catch ( SecurityException ex )
			{
				HandleLoadException(ex, e);
			}
		}

		private void HandleLoadException(Exception ex, SerializationEventArgs e)
		{
			MessageBox.Show(this, 
				"Open File operation failed. File name: " + e.FileName + "\n" +
				"Reason: " + ex.Message, 
				Application.ProductName);

			e.Error = true;
		}
		#endregion

		#region docmanager open event
		private void docManager_OpenEvent(object sender, OpenFileEventArgs e)
		{
			// Update MRU List
			if ( e.Succeeded )
				mruManager.Add(e.FileName);
			else
				mruManager.Remove(e.FileName);
		}
		#endregion

		#region docmanager doc cange event
		private void docManager_DocChangedEvent(object sender, EventArgs e)
		{
			//drawArea.Initialize(this,this.docManager);
			drawArea.Refresh();
		}
		#endregion

		#region docmanager clear event
		private void docManager_ClearEvent(object sender, EventArgs e)
		{
			if ( drawArea.Mgr.Flolist != null )
			{
				drawArea.Mgr.Flolist.Clear();
				drawArea.Refresh();
			}
		}
		#endregion

		#region dragdropmanager file dropped event
		private void dragDropManager_FileDroppedEvent(object sender, FileDroppedEventArgs e)
		{
			OpenDocument(e.FileArray.GetValue(0).ToString());
		}
		#endregion

		#region mrumanager mru open event
		private void mruManager_MruOpenEvent(object sender, MruFileOpenEventArgs e)
		{
			OpenDocument(e.FileName);
		}

		public void OpenDocument(string file)
		{
			docManager.OpenDocument(file);
		}
		#endregion

		#region loadsettingsfromregistry
		void LoadSettingsFromRegistry()
		{
			try
			{
				RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath);
			}
			catch (ArgumentNullException ex)
			{
				HandleRegistryException(ex);
			}
			catch (SecurityException ex)
			{
				HandleRegistryException(ex);
			}
			catch (ArgumentException ex)
			{
				HandleRegistryException(ex);
			}
			catch (ObjectDisposedException ex)
			{
				HandleRegistryException(ex);
			}
			catch (UnauthorizedAccessException ex)
			{
				HandleRegistryException(ex);
			}
		}
		#endregion

		#region savesettingtoregistry
		void SaveSettingsToRegistry()
		{
			try
			{
				RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath);
			}
			catch (SecurityException ex)
			{
				HandleRegistryException(ex);
			}
			catch (ArgumentException ex)
			{
				HandleRegistryException(ex);
			}
			catch (ObjectDisposedException ex)
			{
				HandleRegistryException(ex);
			}
			catch (UnauthorizedAccessException ex)
			{
				HandleRegistryException(ex);
			}
		}

		private void HandleRegistryException(Exception ex)
		{
			Trace.WriteLine("Registry operation failed: " + ex.Message);
		}
		#endregion

		#region form closing
		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ( ! docManager.CloseDocument() )
				e.Cancel = true;

			SaveSettingsToRegistry();
		}
		#endregion 

		#region form resize
		private void Form1_Resize(object sender, System.EventArgs e)
		{
			if ( this.WindowState != FormWindowState.Minimized )
			{
				ResizeDrawArea();
			}
		}

		private void ResizeDrawArea()
		{
			Rectangle rect = this.ClientRectangle;

			drawArea.Left	= rect.Left;
			drawArea.Top	= rect.Top + toolBar1.Height;
			drawArea.Width	= rect.Width;
			drawArea.Height = rect.Height - toolBar1.Height;
		}
		#endregion
		
		#region application idle
		private void Application_Idle(object sender, EventArgs e)
		{
			SetStateOfControls();
		}
		#endregion

		#region setstateofcontrols
		public void SetStateOfControls()
		{
			tbPointer.Pushed = (drawArea.ActiveTool == DrawArea.DrawToolType.Pointer);
			tbHand.Pushed = (drawArea.ActiveTool == DrawArea.DrawToolType.Hand);
			tbBuffer.Pushed = (drawArea.ActiveTool == DrawArea.DrawToolType.Buffer);
			tbOperation.Pushed = (drawArea.ActiveTool == DrawArea.DrawToolType.Operation);
			tbResource.Pushed = (drawArea.ActiveTool == DrawArea.DrawToolType.Resource);
			tbCalendar.Pushed = (drawArea.ActiveTool == DrawArea.DrawToolType.Calendar);
			tbDemand.Pushed = (drawArea.ActiveTool == DrawArea.DrawToolType.Demand);
			tbConnection.Pushed = (drawArea.ActiveTool == DrawArea.DrawToolType.Connection);

			menuDrawPointer.Checked = (drawArea.ActiveTool == DrawArea.DrawToolType.Pointer);
			menuDrawHand.Checked = (drawArea.ActiveTool == DrawArea.DrawToolType.Hand);
			menuDrawBuffer.Checked = (drawArea.ActiveTool == DrawArea.DrawToolType.Buffer);
			menuDrawOperation.Checked = (drawArea.ActiveTool == DrawArea.DrawToolType.Operation);
			menuDrawResource.Checked = (drawArea.ActiveTool == DrawArea.DrawToolType.Resource);
			menuDrawCalendar.Checked = (drawArea.ActiveTool == DrawArea.DrawToolType.Calendar);
			menuDrawDemand.Checked = (drawArea.ActiveTool == DrawArea.DrawToolType.Demand);
			menuDrawConnection.Checked = (drawArea.ActiveTool == DrawArea.DrawToolType.Connection);

			menuViewGridOff.Checked = (drawArea.Mgr.Gudsrt.GridpointX == 1);
			menuViewGrid5pt.Checked = (drawArea.Mgr.Gudsrt.GridpointX  == 5);
			menuViewGrid10pt.Checked = (drawArea.Mgr.Gudsrt.GridpointX  == 10);
			menuViewGrid15pt.Checked = (drawArea.Mgr.Gudsrt.GridpointX  == 15);
			menuViewGrid20pt.Checked = (drawArea.Mgr.Gudsrt.GridpointX  == 20);
			menuViewGrid25pt.Checked = (drawArea.Mgr.Gudsrt.GridpointX  == 25);
			menuViewGrid30pt.Checked = (drawArea.Mgr.Gudsrt.GridpointX  == 30);
			menuViewGridFitSize.Checked = (drawArea.Mgr.Gudsrt.GridpointX  == 24);

			bool objects = ( drawArea.Mgr.Flolist.Count > 0 );
			bool selectedObjects = ( drawArea.Mgr.Flolist.GetSelectedObjCnt() > 0);

			// File operations
			menuFileSave.Enabled = objects;
			tbSave.Enabled = objects;

			// Edit operations
			menuEditDelete.Enabled = selectedObjects;
			menuEditDeleteAll.Enabled = objects;
			menuEditSelectAll.Enabled = objects;
			menuEditUnselectAll.Enabled = objects;
			menuEditMoveToFront.Enabled = selectedObjects;
			menuEditMoveToBack.Enabled = selectedObjects;
			menuEditProperties.Enabled = selectedObjects;
		}
		#endregion

		#region menu file
		private void menuFileNew_Click(object sender, System.EventArgs e)
		{
			CommandNew();	
		}

		private void menuFileOpen_Click(object sender, System.EventArgs e)
		{
			CommandOpen();				
		}

		private void menuFileSave_Click(object sender, System.EventArgs e)
		{
			CommandSave();			 		
		}

		private void menuFileSaveAs_Click(object sender, System.EventArgs e)
		{
			CommandSaveAs();
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			CommandClose();	
		}

		private void menuFileExportCSV_Click(object sender, System.EventArgs e)
		{
			CommandExportCSV();
		}
		#endregion

		#region menu edit
		private void menuEditSelectAll_Click(object sender, System.EventArgs e)
		{
			drawArea.Mgr.Flolist.SelectAll();
			drawArea.Refresh();
		}

		private void menuEditUnselectAll_Click(object sender, System.EventArgs e)
		{
			drawArea.Mgr.Flolist.UnselectAll();
			drawArea.Refresh();
		}

		private void menuEditDelete_Click(object sender, System.EventArgs e)
		{
			drawArea.Mgr.Flolist.Delete();
			drawArea.SetDirty();
			drawArea.Refresh();
		}

		private void menuEditDeleteAll_Click(object sender, System.EventArgs e)
		{
			drawArea.Mgr.Flolist.Clear();
			drawArea.SetDirty();
			drawArea.Refresh();
		}

		private void menuEditMoveToFront_Click(object sender, System.EventArgs e)
		{
			drawArea.Mgr.Flolist.MoveSelectionToFront();
			drawArea.SetDirty();
			drawArea.Refresh();
		}

		private void menuEditMoveToBack_Click(object sender, System.EventArgs e)
		{
			drawArea.Mgr.Flolist.MoveSelectionToBack();
			drawArea.SetDirty();
			drawArea.Refresh();		
		}

		private void menuEditProperties_Click(object sender, System.EventArgs e)
		{
			CommandProperties();
		}
		#endregion

		#region menu view
		private void menuViewGridCheck(System.Windows.Forms.MenuItem menu)
		{
			
			for(int i = 0; i < menu.Parent.MenuItems.Count; i++)
			{
				menu.Parent.MenuItems[i].Checked = false;
			}
			
			menu.Checked = true;
			persistState.GridpointX = drawArea.Mgr.Gudsrt.GridpointX;
			persistState.GridpointY = drawArea.Mgr.Gudsrt.GridpointY;
			this.drawArea.Refresh();
		}

		private void menuViewGrid5pt_Click(object sender, System.EventArgs e)
		{
			drawArea.Mgr.Gudsrt.GridpointX = 5;
			drawArea.Mgr.Gudsrt.GridpointY = 5;
			menuViewGridCheck(menuViewGrid5pt);
		}

		private void menuViewGrid10pt_Click(object sender, System.EventArgs e)
		{
			drawArea.Mgr.Gudsrt.GridpointX = 10;
			drawArea.Mgr.Gudsrt.GridpointY = 10;
			menuViewGridCheck(menuViewGrid10pt);
		}

		private void menuViewGrid15pt_Click(object sender, System.EventArgs e)
		{
			drawArea.Mgr.Gudsrt.GridpointX = 15;
			drawArea.Mgr.Gudsrt.GridpointY = 15;
			menuViewGridCheck(menuViewGrid15pt);			
		}

		private void menuViewGrid20pt_Click(object sender, System.EventArgs e)
		{
			drawArea.Mgr.Gudsrt.GridpointX = 20;
			drawArea.Mgr.Gudsrt.GridpointY = 20;
			menuViewGridCheck(menuViewGrid20pt);			
		}

		private void menuViewGrid25pt_Click(object sender, System.EventArgs e)
		{
			drawArea.Mgr.Gudsrt.GridpointX = 25;
			drawArea.Mgr.Gudsrt.GridpointY = 25;
			menuViewGridCheck(menuViewGrid25pt);			
		}

		private void menuViewGrid30pt_Click(object sender, System.EventArgs e)
		{
			drawArea.Mgr.Gudsrt.GridpointX = 30;
			drawArea.Mgr.Gudsrt.GridpointY = 30;
			menuViewGridCheck(menuViewGrid30pt);			
		}

		private void menuViewGridOff_Click(object sender, System.EventArgs e)
		{
			drawArea.Mgr.Gudsrt.GridpointX = 1;
			drawArea.Mgr.Gudsrt.GridpointY = 1;
			menuViewGridCheck(menuViewGridOff);			
		}

		private void menuViewGridFitSize_Click(object sender, System.EventArgs e)
		{
			drawArea.Mgr.Gudsrt.GridpointX = 24;
			drawArea.Mgr.Gudsrt.GridpointY = 18;
			menuViewGridCheck(menuViewGridFitSize);
		}
		#endregion

		#region menu draw
		private void menuDrawPointer_Click(object sender, System.EventArgs e)
		{
			CommandPointer();
		}

		private void menuDrawHand_Click(object sender, System.EventArgs e)
		{
			CommandHand();		
		}

		private void menuDrawBuffer_Click(object sender, System.EventArgs e)
		{
			CommandBuffer();
		}

		private void menuDrawOperation_Click(object sender, System.EventArgs e)
		{
			CommandOperation();		
		}

		private void menuDrawResource_Click(object sender, System.EventArgs e)
		{
			CommandResource();		
		}

		private void menuDrawCalendar_Click(object sender, System.EventArgs e)
		{
			CommandCalendar();		
		}

		private void menuDrawDemand_Click(object sender, System.EventArgs e)
		{
			CommandDemand();
		}

		private void menuDrawConnection_Click(object sender, System.EventArgs e)
		{
			CommandConnection();
		}

		private void menuDrawMaster_Click(object sender, System.EventArgs e)
		{
			CommandMaster();
		}
		#endregion

		#region menu help
		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			CommandAbout();				
		}
		#endregion

		#region tool bar1 button click
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if ( e.Button == tbNew )
				CommandNew();
			else if ( e.Button == tbOpen )
				CommandOpen();		
			else if ( e.Button == tbSave )
				CommandSave();
			else if ( e.Button == tbPointer )
				CommandPointer();
			else if ( e.Button == tbHand)
				CommandHand();
			else if ( e.Button == tbBuffer)
				CommandBuffer();
			else if ( e.Button == tbOperation)
				CommandOperation();
			else if ( e.Button == tbResource)
				CommandResource();
			else if ( e.Button == tbCalendar )
				CommandCalendar();
			else if ( e.Button == tbDemand )
				CommandDemand();
			else if ( e.Button == tbConnection )
				CommandConnection();
			else if ( e.Button == tbAbout)
				CommandAbout();
			else if ( e.Button == tbMaster)
				CommandMaster();
		}
		#endregion

		#region command file
		private void CommandNew()
		{
            docManager.NewDocument();
		}
		private void CommandOpen()
		{
            docManager.OpenDocument("");
		}
		private void CommandSave()
		{
            docManager.SaveDocument(DocManager.SaveType.Save);
		}
		private void CommandSaveAs()
		{
            docManager.SaveDocument(DocManager.SaveType.SaveAs);
		}
		private void CommandExportCSV()
		{
			drawArea.Mgr.FLOExport(odsExporter);
		}
		#endregion

		#region command edit
		private void CommandPointer()
		{
			drawArea.ActiveTool = DrawArea.DrawToolType.Pointer;
		}
		private void CommandHand()
		{
			drawArea.ActiveTool = DrawArea.DrawToolType.Hand;
		}
		private void CommandBuffer()
		{
			drawArea.ActiveTool = DrawArea.DrawToolType.Buffer;
		}
		private void CommandOperation()
		{
			drawArea.ActiveTool = DrawArea.DrawToolType.Operation;
		}
		private void CommandResource()
		{
			drawArea.ActiveTool = DrawArea.DrawToolType.Resource;
		}
		private void CommandCalendar()
		{
			drawArea.ActiveTool = DrawArea.DrawToolType.Calendar;
		}
		private void CommandDemand()
		{
			drawArea.ActiveTool = DrawArea.DrawToolType.Demand;
		}
		private void CommandConnection()
		{
			drawArea.ActiveTool = DrawArea.DrawToolType.Connection;
		}
		#endregion

		#region command about
		private void CommandAbout()
		{
		}
		#endregion

		#region command properties
		private void CommandProperties()
		{
			drawArea.MouseDoubleDown();
		}
		#endregion

		#region command close
		public void CommandClose()
		{
			DialogResult r = MessageBox.Show(this,"완전!닫습니다!","Q_Modeler",MessageBoxButtons.OKCancel);

			if(r == DialogResult.OK)
				this.Close();
		}
		#endregion

		#region command mater
		public void CommandMaster()
		{
			this.drawArea.Mgr.AddFLOStt(drawArea);
			this.drawArea.Refresh();
		}
		#endregion
	}
}