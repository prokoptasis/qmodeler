using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Q_Modeler
{
	/// <summary>
	/// FormFLOStt에 대한 요약 설명입니다.
	/// </summary>
	public class FormFLOStt : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpTop;
		private System.Windows.Forms.TabPage tpPlan;
		private System.Windows.Forms.TabPage tpPram;
		private System.Windows.Forms.TabPage tpBucket;
		private System.Windows.Forms.TabPage tpLayer;
		private System.Windows.Forms.TabPage tpOblevel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_instanceid;
		private System.Windows.Forms.NumericUpDown nud_bitposition;
		private System.Windows.Forms.TextBox tb_enterprise;
		private System.Windows.Forms.NumericUpDown nud_engineid;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_supplychainid;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_organizationid;
		private System.Windows.Forms.TextBox tb_workcenter;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox tb_bucketname;
		private System.Windows.Forms.NumericUpDown nud_firstdayofweek;
		private System.Windows.Forms.TextBox tb_boundaryid;
		private System.Windows.Forms.DateTimePicker dtp_effstartdate;
		private System.Windows.Forms.NumericUpDown nud_patternsequence;
		private System.Windows.Forms.NumericUpDown nud_bucketsize;
		private System.Windows.Forms.ComboBox cb_bucketsizeuom;
		private System.Windows.Forms.NumericUpDown nud_numberofbuckets;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox tb_planid;
		private System.Windows.Forms.DateTimePicker dtp_planstartdate;
		private System.Windows.Forms.DateTimePicker dtp_planenddate;
		private System.Windows.Forms.DateTimePicker dtp_plancurrentdate;
		private System.Windows.Forms.NumericUpDown nud_keeporbetter;
		private System.Windows.Forms.NumericUpDown nud_exportunpeggedmaterial;
		private System.Windows.Forms.NumericUpDown nud_exportunpeggedcapacity;
		private System.Windows.Forms.NumericUpDown nud_exportdaterange;
		private System.Windows.Forms.NumericUpDown nud_exportsourcepegging;
		private System.Windows.Forms.ComboBox cb_mpasolver;
		private System.Windows.Forms.NumericUpDown nud_usetransportcapacity;
		private System.Windows.Forms.ListView lv_lplayer;
		private System.Windows.Forms.ComboBox cb_layertype;
		private System.Windows.Forms.NumericUpDown nud_priority;
		private System.Windows.Forms.NumericUpDown nud_demandprioritystart;
		private System.Windows.Forms.NumericUpDown nud_demandpriorityend;
		private System.Windows.Forms.TextBox tb_demandbands;
		private System.Windows.Forms.Button bt_lplayeradd;
		private System.Windows.Forms.Button bt_lplayerinsert;
		private System.Windows.Forms.Button bt_lplayerupdate;
		private System.Windows.Forms.Button bt_lplayerdelete;
		private System.Windows.Forms.ComboBox cb_oblevel;
		private System.Windows.Forms.NumericUpDown nud_obpriority;
		private System.Windows.Forms.NumericUpDown nud_istimeweighted;
		private System.Windows.Forms.TextBox tb_lpmethod;
		private System.Windows.Forms.Button bt_obleveladd;
		private System.Windows.Forms.Button bt_oblevelinsert;
		private System.Windows.Forms.Button bt_oblevelupdate;
		private System.Windows.Forms.Button bt_obleveldelete;
		private System.Windows.Forms.Button bt_generate;
		private System.Windows.Forms.Button bt_save;
		private System.Windows.Forms.Button bt_cancle;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.ListView lv_oblevels;
		private System.Windows.Forms.ColumnHeader layername;
		private System.Windows.Forms.ColumnHeader LayerType;
		private System.Windows.Forms.ColumnHeader LayerPriority;
		private System.Windows.Forms.ColumnHeader PriorityStart;
		private System.Windows.Forms.ColumnHeader PriorityEnd;
		private System.Windows.Forms.ColumnHeader demandbands;
		private System.Windows.Forms.ColumnHeader oblevel;
		private System.Windows.Forms.ColumnHeader priority;
		private System.Windows.Forms.ColumnHeader qualifier;
		private System.Windows.Forms.ColumnHeader istimeweighted;
		private System.Windows.Forms.TextBox tb_layername;
		private System.Windows.Forms.TextBox tb_qualifier;
		private System.Windows.Forms.ColumnHeader lpmethod;

		public FormFLOStt()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpTop = new System.Windows.Forms.TabPage();
			this.nud_bitposition = new System.Windows.Forms.NumericUpDown();
			this.tb_instanceid = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_enterprise = new System.Windows.Forms.TextBox();
			this.nud_engineid = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_supplychainid = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_organizationid = new System.Windows.Forms.TextBox();
			this.tb_workcenter = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tpPlan = new System.Windows.Forms.TabPage();
			this.dtp_planstartdate = new System.Windows.Forms.DateTimePicker();
			this.tb_planid = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.dtp_planenddate = new System.Windows.Forms.DateTimePicker();
			this.dtp_plancurrentdate = new System.Windows.Forms.DateTimePicker();
			this.tpPram = new System.Windows.Forms.TabPage();
			this.label15 = new System.Windows.Forms.Label();
			this.cb_mpasolver = new System.Windows.Forms.ComboBox();
			this.nud_keeporbetter = new System.Windows.Forms.NumericUpDown();
			this.nud_exportunpeggedmaterial = new System.Windows.Forms.NumericUpDown();
			this.nud_exportunpeggedcapacity = new System.Windows.Forms.NumericUpDown();
			this.nud_exportdaterange = new System.Windows.Forms.NumericUpDown();
			this.nud_exportsourcepegging = new System.Windows.Forms.NumericUpDown();
			this.nud_usetransportcapacity = new System.Windows.Forms.NumericUpDown();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.tpBucket = new System.Windows.Forms.TabPage();
			this.cb_bucketsizeuom = new System.Windows.Forms.ComboBox();
			this.dtp_effstartdate = new System.Windows.Forms.DateTimePicker();
			this.nud_firstdayofweek = new System.Windows.Forms.NumericUpDown();
			this.tb_bucketname = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tb_boundaryid = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.nud_patternsequence = new System.Windows.Forms.NumericUpDown();
			this.nud_bucketsize = new System.Windows.Forms.NumericUpDown();
			this.nud_numberofbuckets = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.tpLayer = new System.Windows.Forms.TabPage();
			this.bt_lplayeradd = new System.Windows.Forms.Button();
			this.tb_demandbands = new System.Windows.Forms.TextBox();
			this.nud_priority = new System.Windows.Forms.NumericUpDown();
			this.lv_lplayer = new System.Windows.Forms.ListView();
			this.layername = new System.Windows.Forms.ColumnHeader();
			this.LayerType = new System.Windows.Forms.ColumnHeader();
			this.LayerPriority = new System.Windows.Forms.ColumnHeader();
			this.PriorityStart = new System.Windows.Forms.ColumnHeader();
			this.PriorityEnd = new System.Windows.Forms.ColumnHeader();
			this.demandbands = new System.Windows.Forms.ColumnHeader();
			this.cb_layertype = new System.Windows.Forms.ComboBox();
			this.nud_demandprioritystart = new System.Windows.Forms.NumericUpDown();
			this.nud_demandpriorityend = new System.Windows.Forms.NumericUpDown();
			this.bt_lplayerinsert = new System.Windows.Forms.Button();
			this.bt_lplayerupdate = new System.Windows.Forms.Button();
			this.bt_lplayerdelete = new System.Windows.Forms.Button();
			this.tb_layername = new System.Windows.Forms.TextBox();
			this.tpOblevel = new System.Windows.Forms.TabPage();
			this.lv_oblevels = new System.Windows.Forms.ListView();
			this.oblevel = new System.Windows.Forms.ColumnHeader();
			this.priority = new System.Windows.Forms.ColumnHeader();
			this.qualifier = new System.Windows.Forms.ColumnHeader();
			this.istimeweighted = new System.Windows.Forms.ColumnHeader();
			this.lpmethod = new System.Windows.Forms.ColumnHeader();
			this.bt_obleveladd = new System.Windows.Forms.Button();
			this.bt_oblevelinsert = new System.Windows.Forms.Button();
			this.bt_oblevelupdate = new System.Windows.Forms.Button();
			this.bt_obleveldelete = new System.Windows.Forms.Button();
			this.tb_lpmethod = new System.Windows.Forms.TextBox();
			this.nud_obpriority = new System.Windows.Forms.NumericUpDown();
			this.cb_oblevel = new System.Windows.Forms.ComboBox();
			this.nud_istimeweighted = new System.Windows.Forms.NumericUpDown();
			this.tb_qualifier = new System.Windows.Forms.TextBox();
			this.bt_generate = new System.Windows.Forms.Button();
			this.bt_save = new System.Windows.Forms.Button();
			this.bt_cancle = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tpTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_bitposition)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_engineid)).BeginInit();
			this.tpPlan.SuspendLayout();
			this.tpPram.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_keeporbetter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_exportunpeggedmaterial)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_exportunpeggedcapacity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_exportdaterange)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_exportsourcepegging)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_usetransportcapacity)).BeginInit();
			this.tpBucket.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_firstdayofweek)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_patternsequence)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_bucketsize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_numberofbuckets)).BeginInit();
			this.tpLayer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_priority)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_demandprioritystart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_demandpriorityend)).BeginInit();
			this.tpOblevel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_obpriority)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_istimeweighted)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpTop);
			this.tabControl1.Controls.Add(this.tpPlan);
			this.tabControl1.Controls.Add(this.tpPram);
			this.tabControl1.Controls.Add(this.tpBucket);
			this.tabControl1.Controls.Add(this.tpLayer);
			this.tabControl1.Controls.Add(this.tpOblevel);
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(272, 232);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tpTop
			// 
			this.tpTop.Controls.Add(this.nud_bitposition);
			this.tpTop.Controls.Add(this.tb_instanceid);
			this.tpTop.Controls.Add(this.label1);
			this.tpTop.Controls.Add(this.tb_enterprise);
			this.tpTop.Controls.Add(this.nud_engineid);
			this.tpTop.Controls.Add(this.label2);
			this.tpTop.Controls.Add(this.tb_supplychainid);
			this.tpTop.Controls.Add(this.label3);
			this.tpTop.Controls.Add(this.label4);
			this.tpTop.Controls.Add(this.tb_organizationid);
			this.tpTop.Controls.Add(this.tb_workcenter);
			this.tpTop.Controls.Add(this.label5);
			this.tpTop.Location = new System.Drawing.Point(4, 21);
			this.tpTop.Name = "tpTop";
			this.tpTop.Size = new System.Drawing.Size(264, 207);
			this.tpTop.TabIndex = 0;
			this.tpTop.Text = "Master";
			// 
			// nud_bitposition
			// 
			this.nud_bitposition.Location = new System.Drawing.Point(208, 16);
			this.nud_bitposition.Maximum = new System.Decimal(new int[] {
																			1410065408,
																			2,
																			0,
																			0});
			this.nud_bitposition.Name = "nud_bitposition";
			this.nud_bitposition.Size = new System.Drawing.Size(40, 21);
			this.nud_bitposition.TabIndex = 2;
			this.nud_bitposition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nud_bitposition.ValueChanged += new System.EventHandler(this.nud_bitposition_ValueChanged);
			// 
			// tb_instanceid
			// 
			this.tb_instanceid.Location = new System.Drawing.Point(80, 16);
			this.tb_instanceid.Name = "tb_instanceid";
			this.tb_instanceid.Size = new System.Drawing.Size(128, 21);
			this.tb_instanceid.TabIndex = 1;
			this.tb_instanceid.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "InstID/BitP";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_enterprise
			// 
			this.tb_enterprise.Location = new System.Drawing.Point(80, 56);
			this.tb_enterprise.Name = "tb_enterprise";
			this.tb_enterprise.Size = new System.Drawing.Size(128, 21);
			this.tb_enterprise.TabIndex = 1;
			this.tb_enterprise.Text = "";
			// 
			// nud_engineid
			// 
			this.nud_engineid.Enabled = false;
			this.nud_engineid.Location = new System.Drawing.Point(208, 56);
			this.nud_engineid.Maximum = new System.Decimal(new int[] {
																		 1410065408,
																		 2,
																		 0,
																		 0});
			this.nud_engineid.Name = "nud_engineid";
			this.nud_engineid.Size = new System.Drawing.Size(40, 21);
			this.nud_engineid.TabIndex = 2;
			this.nud_engineid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Enter/Eng";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_supplychainid
			// 
			this.tb_supplychainid.Location = new System.Drawing.Point(80, 92);
			this.tb_supplychainid.Name = "tb_supplychainid";
			this.tb_supplychainid.Size = new System.Drawing.Size(168, 21);
			this.tb_supplychainid.TabIndex = 1;
			this.tb_supplychainid.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 24);
			this.label3.TabIndex = 0;
			this.label3.Text = "Supply";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 24);
			this.label4.TabIndex = 0;
			this.label4.Text = "Org.ID";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_organizationid
			// 
			this.tb_organizationid.Location = new System.Drawing.Point(80, 130);
			this.tb_organizationid.Name = "tb_organizationid";
			this.tb_organizationid.Size = new System.Drawing.Size(168, 21);
			this.tb_organizationid.TabIndex = 1;
			this.tb_organizationid.Text = "";
			// 
			// tb_workcenter
			// 
			this.tb_workcenter.Location = new System.Drawing.Point(80, 168);
			this.tb_workcenter.Name = "tb_workcenter";
			this.tb_workcenter.Size = new System.Drawing.Size(168, 21);
			this.tb_workcenter.TabIndex = 1;
			this.tb_workcenter.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 24);
			this.label5.TabIndex = 0;
			this.label5.Text = "Workcenter";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tpPlan
			// 
			this.tpPlan.Controls.Add(this.dtp_planstartdate);
			this.tpPlan.Controls.Add(this.tb_planid);
			this.tpPlan.Controls.Add(this.label6);
			this.tpPlan.Controls.Add(this.label7);
			this.tpPlan.Controls.Add(this.label8);
			this.tpPlan.Controls.Add(this.label9);
			this.tpPlan.Controls.Add(this.dtp_planenddate);
			this.tpPlan.Controls.Add(this.dtp_plancurrentdate);
			this.tpPlan.Location = new System.Drawing.Point(4, 21);
			this.tpPlan.Name = "tpPlan";
			this.tpPlan.Size = new System.Drawing.Size(264, 207);
			this.tpPlan.TabIndex = 1;
			this.tpPlan.Text = "Plan";
			// 
			// dtp_planstartdate
			// 
			this.dtp_planstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_planstartdate.Location = new System.Drawing.Point(72, 73);
			this.dtp_planstartdate.Name = "dtp_planstartdate";
			this.dtp_planstartdate.Size = new System.Drawing.Size(176, 21);
			this.dtp_planstartdate.TabIndex = 2;
			this.dtp_planstartdate.ValueChanged += new System.EventHandler(this.dtp_planstartdate_ValueChanged);
			// 
			// tb_planid
			// 
			this.tb_planid.Location = new System.Drawing.Point(72, 26);
			this.tb_planid.Name = "tb_planid";
			this.tb_planid.Size = new System.Drawing.Size(176, 21);
			this.tb_planid.TabIndex = 1;
			this.tb_planid.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 24);
			this.label6.TabIndex = 0;
			this.label6.Text = "PlanID";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 24);
			this.label7.TabIndex = 0;
			this.label7.Text = "PlanStart";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 168);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 24);
			this.label8.TabIndex = 0;
			this.label8.Text = "PlanEnd";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 120);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 24);
			this.label9.TabIndex = 0;
			this.label9.Text = "Current";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtp_planenddate
			// 
			this.dtp_planenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_planenddate.Location = new System.Drawing.Point(72, 168);
			this.dtp_planenddate.Name = "dtp_planenddate";
			this.dtp_planenddate.Size = new System.Drawing.Size(176, 21);
			this.dtp_planenddate.TabIndex = 2;
			this.dtp_planenddate.ValueChanged += new System.EventHandler(this.dtp_planenddate_ValueChanged);
			// 
			// dtp_plancurrentdate
			// 
			this.dtp_plancurrentdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_plancurrentdate.Location = new System.Drawing.Point(72, 120);
			this.dtp_plancurrentdate.Name = "dtp_plancurrentdate";
			this.dtp_plancurrentdate.Size = new System.Drawing.Size(176, 21);
			this.dtp_plancurrentdate.TabIndex = 2;
			this.dtp_plancurrentdate.ValueChanged += new System.EventHandler(this.dtp_plancurrentdate_ValueChanged);
			// 
			// tpPram
			// 
			this.tpPram.Controls.Add(this.label15);
			this.tpPram.Controls.Add(this.cb_mpasolver);
			this.tpPram.Controls.Add(this.nud_keeporbetter);
			this.tpPram.Controls.Add(this.nud_exportunpeggedmaterial);
			this.tpPram.Controls.Add(this.nud_exportunpeggedcapacity);
			this.tpPram.Controls.Add(this.nud_exportdaterange);
			this.tpPram.Controls.Add(this.nud_exportsourcepegging);
			this.tpPram.Controls.Add(this.nud_usetransportcapacity);
			this.tpPram.Controls.Add(this.label16);
			this.tpPram.Controls.Add(this.label17);
			this.tpPram.Controls.Add(this.label18);
			this.tpPram.Controls.Add(this.label19);
			this.tpPram.Controls.Add(this.label20);
			this.tpPram.Controls.Add(this.label21);
			this.tpPram.Location = new System.Drawing.Point(4, 21);
			this.tpPram.Name = "tpPram";
			this.tpPram.Size = new System.Drawing.Size(264, 207);
			this.tpPram.TabIndex = 6;
			this.tpPram.Text = "Param";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(8, 16);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(136, 24);
			this.label15.TabIndex = 2;
			this.label15.Text = "keep_or_better";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cb_mpasolver
			// 
			this.cb_mpasolver.Items.AddRange(new object[] {
															  "false",
															  "true"});
			this.cb_mpasolver.Location = new System.Drawing.Point(144, 146);
			this.cb_mpasolver.Name = "cb_mpasolver";
			this.cb_mpasolver.Size = new System.Drawing.Size(104, 20);
			this.cb_mpasolver.TabIndex = 1;
			this.cb_mpasolver.Text = "false";
			// 
			// nud_keeporbetter
			// 
			this.nud_keeporbetter.Location = new System.Drawing.Point(144, 16);
			this.nud_keeporbetter.Maximum = new System.Decimal(new int[] {
																			 1,
																			 0,
																			 0,
																			 0});
			this.nud_keeporbetter.Name = "nud_keeporbetter";
			this.nud_keeporbetter.Size = new System.Drawing.Size(104, 21);
			this.nud_keeporbetter.TabIndex = 0;
			this.nud_keeporbetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_exportunpeggedmaterial
			// 
			this.nud_exportunpeggedmaterial.Location = new System.Drawing.Point(144, 42);
			this.nud_exportunpeggedmaterial.Maximum = new System.Decimal(new int[] {
																					   1,
																					   0,
																					   0,
																					   0});
			this.nud_exportunpeggedmaterial.Name = "nud_exportunpeggedmaterial";
			this.nud_exportunpeggedmaterial.Size = new System.Drawing.Size(104, 21);
			this.nud_exportunpeggedmaterial.TabIndex = 0;
			this.nud_exportunpeggedmaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_exportunpeggedcapacity
			// 
			this.nud_exportunpeggedcapacity.Location = new System.Drawing.Point(144, 68);
			this.nud_exportunpeggedcapacity.Maximum = new System.Decimal(new int[] {
																					   1,
																					   0,
																					   0,
																					   0});
			this.nud_exportunpeggedcapacity.Name = "nud_exportunpeggedcapacity";
			this.nud_exportunpeggedcapacity.Size = new System.Drawing.Size(104, 21);
			this.nud_exportunpeggedcapacity.TabIndex = 0;
			this.nud_exportunpeggedcapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_exportdaterange
			// 
			this.nud_exportdaterange.Enabled = false;
			this.nud_exportdaterange.Location = new System.Drawing.Point(144, 94);
			this.nud_exportdaterange.Maximum = new System.Decimal(new int[] {
																				1410065408,
																				2,
																				0,
																				0});
			this.nud_exportdaterange.Name = "nud_exportdaterange";
			this.nud_exportdaterange.Size = new System.Drawing.Size(104, 21);
			this.nud_exportdaterange.TabIndex = 0;
			this.nud_exportdaterange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_exportsourcepegging
			// 
			this.nud_exportsourcepegging.Location = new System.Drawing.Point(144, 120);
			this.nud_exportsourcepegging.Maximum = new System.Decimal(new int[] {
																					1,
																					0,
																					0,
																					0});
			this.nud_exportsourcepegging.Name = "nud_exportsourcepegging";
			this.nud_exportsourcepegging.Size = new System.Drawing.Size(104, 21);
			this.nud_exportsourcepegging.TabIndex = 0;
			this.nud_exportsourcepegging.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_usetransportcapacity
			// 
			this.nud_usetransportcapacity.Location = new System.Drawing.Point(144, 171);
			this.nud_usetransportcapacity.Maximum = new System.Decimal(new int[] {
																					 1,
																					 0,
																					 0,
																					 0});
			this.nud_usetransportcapacity.Name = "nud_usetransportcapacity";
			this.nud_usetransportcapacity.Size = new System.Drawing.Size(104, 21);
			this.nud_usetransportcapacity.TabIndex = 0;
			this.nud_usetransportcapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(8, 42);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(136, 24);
			this.label16.TabIndex = 2;
			this.label16.Text = "exp_unpegged_mat";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(8, 68);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(136, 24);
			this.label17.TabIndex = 2;
			this.label17.Text = "exp_unpegged_capa";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(8, 94);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(136, 24);
			this.label18.TabIndex = 2;
			this.label18.Text = "exp_date_range";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(8, 119);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(136, 24);
			this.label19.TabIndex = 2;
			this.label19.Text = "exp_source_pegging";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(8, 145);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(136, 24);
			this.label20.TabIndex = 2;
			this.label20.Text = "mpa_solver";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(8, 170);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(136, 24);
			this.label21.TabIndex = 2;
			this.label21.Text = "use_transport_capa";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tpBucket
			// 
			this.tpBucket.Controls.Add(this.cb_bucketsizeuom);
			this.tpBucket.Controls.Add(this.dtp_effstartdate);
			this.tpBucket.Controls.Add(this.nud_firstdayofweek);
			this.tpBucket.Controls.Add(this.tb_bucketname);
			this.tpBucket.Controls.Add(this.label10);
			this.tpBucket.Controls.Add(this.tb_boundaryid);
			this.tpBucket.Controls.Add(this.label11);
			this.tpBucket.Controls.Add(this.label12);
			this.tpBucket.Controls.Add(this.nud_patternsequence);
			this.tpBucket.Controls.Add(this.nud_bucketsize);
			this.tpBucket.Controls.Add(this.nud_numberofbuckets);
			this.tpBucket.Controls.Add(this.label13);
			this.tpBucket.Controls.Add(this.label14);
			this.tpBucket.Location = new System.Drawing.Point(4, 21);
			this.tpBucket.Name = "tpBucket";
			this.tpBucket.Size = new System.Drawing.Size(264, 207);
			this.tpBucket.TabIndex = 2;
			this.tpBucket.Text = "Bucket";
			// 
			// cb_bucketsizeuom
			// 
			this.cb_bucketsizeuom.Items.AddRange(new object[] {
																  "day",
																  "week"});
			this.cb_bucketsizeuom.Location = new System.Drawing.Point(168, 176);
			this.cb_bucketsizeuom.Name = "cb_bucketsizeuom";
			this.cb_bucketsizeuom.Size = new System.Drawing.Size(80, 20);
			this.cb_bucketsizeuom.TabIndex = 5;
			this.cb_bucketsizeuom.Text = "day";
			this.cb_bucketsizeuom.SelectedIndexChanged += new System.EventHandler(this.cb_bucketsizeuom_SelectedIndexChanged);
			// 
			// dtp_effstartdate
			// 
			this.dtp_effstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_effstartdate.Location = new System.Drawing.Point(88, 96);
			this.dtp_effstartdate.Name = "dtp_effstartdate";
			this.dtp_effstartdate.Size = new System.Drawing.Size(104, 21);
			this.dtp_effstartdate.TabIndex = 4;
			this.dtp_effstartdate.ValueChanged += new System.EventHandler(this.dtp_effstartdate_ValueChanged);
			// 
			// nud_firstdayofweek
			// 
			this.nud_firstdayofweek.Location = new System.Drawing.Point(192, 96);
			this.nud_firstdayofweek.Name = "nud_firstdayofweek";
			this.nud_firstdayofweek.Size = new System.Drawing.Size(56, 21);
			this.nud_firstdayofweek.TabIndex = 3;
			this.nud_firstdayofweek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_bucketname
			// 
			this.tb_bucketname.Location = new System.Drawing.Point(88, 16);
			this.tb_bucketname.Name = "tb_bucketname";
			this.tb_bucketname.Size = new System.Drawing.Size(160, 21);
			this.tb_bucketname.TabIndex = 2;
			this.tb_bucketname.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 24);
			this.label10.TabIndex = 1;
			this.label10.Text = "Bucketname";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_boundaryid
			// 
			this.tb_boundaryid.Location = new System.Drawing.Point(88, 56);
			this.tb_boundaryid.Name = "tb_boundaryid";
			this.tb_boundaryid.Size = new System.Drawing.Size(160, 21);
			this.tb_boundaryid.TabIndex = 2;
			this.tb_boundaryid.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 56);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 24);
			this.label11.TabIndex = 1;
			this.label11.Text = "BoundaryID";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 136);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 24);
			this.label12.TabIndex = 1;
			this.label12.Text = "P.Seq/NOB";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_patternsequence
			// 
			this.nud_patternsequence.Location = new System.Drawing.Point(88, 136);
			this.nud_patternsequence.Minimum = new System.Decimal(new int[] {
																				1,
																				0,
																				0,
																				0});
			this.nud_patternsequence.Name = "nud_patternsequence";
			this.nud_patternsequence.Size = new System.Drawing.Size(80, 21);
			this.nud_patternsequence.TabIndex = 3;
			this.nud_patternsequence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nud_patternsequence.Value = new System.Decimal(new int[] {
																			  1,
																			  0,
																			  0,
																			  0});
			// 
			// nud_bucketsize
			// 
			this.nud_bucketsize.Location = new System.Drawing.Point(88, 176);
			this.nud_bucketsize.Minimum = new System.Decimal(new int[] {
																		   1,
																		   0,
																		   0,
																		   0});
			this.nud_bucketsize.Name = "nud_bucketsize";
			this.nud_bucketsize.Size = new System.Drawing.Size(80, 21);
			this.nud_bucketsize.TabIndex = 3;
			this.nud_bucketsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nud_bucketsize.Value = new System.Decimal(new int[] {
																		 1,
																		 0,
																		 0,
																		 0});
			this.nud_bucketsize.ValueChanged += new System.EventHandler(this.nud_bucketsize_ValueChanged);
			// 
			// nud_numberofbuckets
			// 
			this.nud_numberofbuckets.Enabled = false;
			this.nud_numberofbuckets.Location = new System.Drawing.Point(168, 136);
			this.nud_numberofbuckets.Maximum = new System.Decimal(new int[] {
																				10000000,
																				0,
																				0,
																				0});
			this.nud_numberofbuckets.Name = "nud_numberofbuckets";
			this.nud_numberofbuckets.Size = new System.Drawing.Size(80, 21);
			this.nud_numberofbuckets.TabIndex = 3;
			this.nud_numberofbuckets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 176);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 24);
			this.label13.TabIndex = 1;
			this.label13.Text = "B.Size/UOM";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(8, 96);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 24);
			this.label14.TabIndex = 1;
			this.label14.Text = "EffStart/First";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tpLayer
			// 
			this.tpLayer.Controls.Add(this.bt_lplayeradd);
			this.tpLayer.Controls.Add(this.tb_demandbands);
			this.tpLayer.Controls.Add(this.nud_priority);
			this.tpLayer.Controls.Add(this.lv_lplayer);
			this.tpLayer.Controls.Add(this.cb_layertype);
			this.tpLayer.Controls.Add(this.nud_demandprioritystart);
			this.tpLayer.Controls.Add(this.nud_demandpriorityend);
			this.tpLayer.Controls.Add(this.bt_lplayerinsert);
			this.tpLayer.Controls.Add(this.bt_lplayerupdate);
			this.tpLayer.Controls.Add(this.bt_lplayerdelete);
			this.tpLayer.Controls.Add(this.tb_layername);
			this.tpLayer.Location = new System.Drawing.Point(4, 21);
			this.tpLayer.Name = "tpLayer";
			this.tpLayer.Size = new System.Drawing.Size(264, 207);
			this.tpLayer.TabIndex = 4;
			this.tpLayer.Text = "LpLayer";
			// 
			// bt_lplayeradd
			// 
			this.bt_lplayeradd.Location = new System.Drawing.Point(20, 63);
			this.bt_lplayeradd.Name = "bt_lplayeradd";
			this.bt_lplayeradd.Size = new System.Drawing.Size(56, 24);
			this.bt_lplayeradd.TabIndex = 4;
			this.bt_lplayeradd.Text = "Add";
			this.bt_lplayeradd.Click += new System.EventHandler(this.bt_lplayeradd_Click);
			// 
			// tb_demandbands
			// 
			this.tb_demandbands.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_demandbands.Location = new System.Drawing.Point(160, 40);
			this.tb_demandbands.Name = "tb_demandbands";
			this.tb_demandbands.Size = new System.Drawing.Size(88, 20);
			this.tb_demandbands.TabIndex = 3;
			this.tb_demandbands.Text = "";
			// 
			// nud_priority
			// 
			this.nud_priority.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.nud_priority.Location = new System.Drawing.Point(16, 40);
			this.nud_priority.Name = "nud_priority";
			this.nud_priority.Size = new System.Drawing.Size(48, 20);
			this.nud_priority.TabIndex = 2;
			this.nud_priority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lv_lplayer
			// 
			this.lv_lplayer.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.lv_lplayer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						 this.layername,
																						 this.LayerType,
																						 this.LayerPriority,
																						 this.PriorityStart,
																						 this.PriorityEnd,
																						 this.demandbands});
			this.lv_lplayer.FullRowSelect = true;
			this.lv_lplayer.GridLines = true;
			this.lv_lplayer.HideSelection = false;
			this.lv_lplayer.LabelWrap = false;
			this.lv_lplayer.Location = new System.Drawing.Point(16, 88);
			this.lv_lplayer.Name = "lv_lplayer";
			this.lv_lplayer.Size = new System.Drawing.Size(232, 112);
			this.lv_lplayer.TabIndex = 0;
			this.lv_lplayer.View = System.Windows.Forms.View.Details;
			this.lv_lplayer.ItemActivate += new System.EventHandler(this.lv_lplayer_ItemActivate);
			this.lv_lplayer.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_lplayer_ColumnClick);
			// 
			// layername
			// 
			this.layername.Text = "Layer";
			// 
			// LayerType
			// 
			this.LayerType.Text = "Tyep";
			this.LayerType.Width = 48;
			// 
			// LayerPriority
			// 
			this.LayerPriority.Text = "Priority";
			this.LayerPriority.Width = 30;
			// 
			// PriorityStart
			// 
			this.PriorityStart.Text = "PriorityS";
			this.PriorityStart.Width = 30;
			// 
			// PriorityEnd
			// 
			this.PriorityEnd.Text = "PriorityE";
			this.PriorityEnd.Width = 30;
			// 
			// demandbands
			// 
			this.demandbands.Text = "Bands";
			this.demandbands.Width = 30;
			// 
			// cb_layertype
			// 
			this.cb_layertype.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.cb_layertype.Items.AddRange(new object[] {
															  "B",
															  "S"});
			this.cb_layertype.Location = new System.Drawing.Point(184, 16);
			this.cb_layertype.Name = "cb_layertype";
			this.cb_layertype.Size = new System.Drawing.Size(64, 19);
			this.cb_layertype.TabIndex = 1;
			this.cb_layertype.Text = "S";
			// 
			// nud_demandprioritystart
			// 
			this.nud_demandprioritystart.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.nud_demandprioritystart.Location = new System.Drawing.Point(64, 40);
			this.nud_demandprioritystart.Name = "nud_demandprioritystart";
			this.nud_demandprioritystart.Size = new System.Drawing.Size(48, 20);
			this.nud_demandprioritystart.TabIndex = 2;
			this.nud_demandprioritystart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_demandpriorityend
			// 
			this.nud_demandpriorityend.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.nud_demandpriorityend.Location = new System.Drawing.Point(112, 40);
			this.nud_demandpriorityend.Name = "nud_demandpriorityend";
			this.nud_demandpriorityend.Size = new System.Drawing.Size(48, 20);
			this.nud_demandpriorityend.TabIndex = 2;
			this.nud_demandpriorityend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// bt_lplayerinsert
			// 
			this.bt_lplayerinsert.Location = new System.Drawing.Point(76, 63);
			this.bt_lplayerinsert.Name = "bt_lplayerinsert";
			this.bt_lplayerinsert.Size = new System.Drawing.Size(56, 24);
			this.bt_lplayerinsert.TabIndex = 4;
			this.bt_lplayerinsert.Text = "Insert";
			this.bt_lplayerinsert.Click += new System.EventHandler(this.bt_lplayerinsert_Click);
			// 
			// bt_lplayerupdate
			// 
			this.bt_lplayerupdate.Location = new System.Drawing.Point(132, 63);
			this.bt_lplayerupdate.Name = "bt_lplayerupdate";
			this.bt_lplayerupdate.Size = new System.Drawing.Size(56, 24);
			this.bt_lplayerupdate.TabIndex = 4;
			this.bt_lplayerupdate.Text = "Update";
			this.bt_lplayerupdate.Click += new System.EventHandler(this.bt_lplayerupdate_Click);
			// 
			// bt_lplayerdelete
			// 
			this.bt_lplayerdelete.Location = new System.Drawing.Point(188, 63);
			this.bt_lplayerdelete.Name = "bt_lplayerdelete";
			this.bt_lplayerdelete.Size = new System.Drawing.Size(56, 24);
			this.bt_lplayerdelete.TabIndex = 4;
			this.bt_lplayerdelete.Text = "Delete";
			this.bt_lplayerdelete.Click += new System.EventHandler(this.bt_lplayerdelete_Click);
			// 
			// tb_layername
			// 
			this.tb_layername.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_layername.Location = new System.Drawing.Point(16, 16);
			this.tb_layername.Name = "tb_layername";
			this.tb_layername.Size = new System.Drawing.Size(168, 20);
			this.tb_layername.TabIndex = 3;
			this.tb_layername.Text = "";
			// 
			// tpOblevel
			// 
			this.tpOblevel.Controls.Add(this.lv_oblevels);
			this.tpOblevel.Controls.Add(this.bt_obleveladd);
			this.tpOblevel.Controls.Add(this.bt_oblevelinsert);
			this.tpOblevel.Controls.Add(this.bt_oblevelupdate);
			this.tpOblevel.Controls.Add(this.bt_obleveldelete);
			this.tpOblevel.Controls.Add(this.tb_lpmethod);
			this.tpOblevel.Controls.Add(this.nud_obpriority);
			this.tpOblevel.Controls.Add(this.cb_oblevel);
			this.tpOblevel.Controls.Add(this.nud_istimeweighted);
			this.tpOblevel.Controls.Add(this.tb_qualifier);
			this.tpOblevel.Location = new System.Drawing.Point(4, 21);
			this.tpOblevel.Name = "tpOblevel";
			this.tpOblevel.Size = new System.Drawing.Size(264, 207);
			this.tpOblevel.TabIndex = 5;
			this.tpOblevel.Text = "OBLevel";
			// 
			// lv_oblevels
			// 
			this.lv_oblevels.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.lv_oblevels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						  this.oblevel,
																						  this.priority,
																						  this.qualifier,
																						  this.istimeweighted,
																						  this.lpmethod});
			this.lv_oblevels.FullRowSelect = true;
			this.lv_oblevels.GridLines = true;
			this.lv_oblevels.HideSelection = false;
			this.lv_oblevels.LabelWrap = false;
			this.lv_oblevels.Location = new System.Drawing.Point(16, 88);
			this.lv_oblevels.Name = "lv_oblevels";
			this.lv_oblevels.Size = new System.Drawing.Size(232, 112);
			this.lv_oblevels.TabIndex = 0;
			this.lv_oblevels.View = System.Windows.Forms.View.Details;
			this.lv_oblevels.ItemActivate += new System.EventHandler(this.lv_oblevels_ItemActivate);
			this.lv_oblevels.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_oblevels_ColumnClick);
			// 
			// oblevel
			// 
			this.oblevel.Text = "OBLevel";
			// 
			// priority
			// 
			this.priority.Text = "Priority";
			this.priority.Width = 51;
			// 
			// qualifier
			// 
			this.qualifier.Text = "Qualifier";
			this.qualifier.Width = 57;
			// 
			// istimeweighted
			// 
			this.istimeweighted.Text = "TimeWeighted";
			this.istimeweighted.Width = 30;
			// 
			// lpmethod
			// 
			this.lpmethod.Text = "LPMethod";
			this.lpmethod.Width = 30;
			// 
			// bt_obleveladd
			// 
			this.bt_obleveladd.Location = new System.Drawing.Point(20, 62);
			this.bt_obleveladd.Name = "bt_obleveladd";
			this.bt_obleveladd.Size = new System.Drawing.Size(56, 24);
			this.bt_obleveladd.TabIndex = 7;
			this.bt_obleveladd.Text = "Add";
			this.bt_obleveladd.Click += new System.EventHandler(this.bt_obleveladd_Click);
			// 
			// bt_oblevelinsert
			// 
			this.bt_oblevelinsert.Location = new System.Drawing.Point(76, 62);
			this.bt_oblevelinsert.Name = "bt_oblevelinsert";
			this.bt_oblevelinsert.Size = new System.Drawing.Size(56, 24);
			this.bt_oblevelinsert.TabIndex = 8;
			this.bt_oblevelinsert.Text = "Insert";
			this.bt_oblevelinsert.Click += new System.EventHandler(this.bt_oblevelinsert_Click);
			// 
			// bt_oblevelupdate
			// 
			this.bt_oblevelupdate.Location = new System.Drawing.Point(132, 62);
			this.bt_oblevelupdate.Name = "bt_oblevelupdate";
			this.bt_oblevelupdate.Size = new System.Drawing.Size(56, 24);
			this.bt_oblevelupdate.TabIndex = 5;
			this.bt_oblevelupdate.Text = "Update";
			this.bt_oblevelupdate.Click += new System.EventHandler(this.bt_oblevelupdate_Click);
			// 
			// bt_obleveldelete
			// 
			this.bt_obleveldelete.Location = new System.Drawing.Point(188, 62);
			this.bt_obleveldelete.Name = "bt_obleveldelete";
			this.bt_obleveldelete.Size = new System.Drawing.Size(56, 24);
			this.bt_obleveldelete.TabIndex = 6;
			this.bt_obleveldelete.Text = "Delete";
			this.bt_obleveldelete.Click += new System.EventHandler(this.bt_obleveldelete_Click);
			// 
			// tb_lpmethod
			// 
			this.tb_lpmethod.Enabled = false;
			this.tb_lpmethod.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_lpmethod.Location = new System.Drawing.Point(216, 40);
			this.tb_lpmethod.Name = "tb_lpmethod";
			this.tb_lpmethod.Size = new System.Drawing.Size(32, 20);
			this.tb_lpmethod.TabIndex = 2;
			this.tb_lpmethod.Text = "P";
			this.tb_lpmethod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_obpriority
			// 
			this.nud_obpriority.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.nud_obpriority.Location = new System.Drawing.Point(184, 16);
			this.nud_obpriority.Maximum = new System.Decimal(new int[] {
																		   1000000000,
																		   0,
																		   0,
																		   0});
			this.nud_obpriority.Name = "nud_obpriority";
			this.nud_obpriority.Size = new System.Drawing.Size(64, 20);
			this.nud_obpriority.TabIndex = 1;
			this.nud_obpriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cb_oblevel
			// 
			this.cb_oblevel.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.cb_oblevel.Items.AddRange(new object[] {
															"amt_not_satisfied",
															"backlog",
															"min_safety_stock_violation",
															"min_time_safety_stock_violation",
															"min_amount_safety_stock_violation",
															"max_safety_stock_violation",
															"max_time_safety_stock_violation",
															"max_amount_safety_stock_violation",
															"alternates",
															"alternates_proportional_violation",
															"total_op_plans",
															"normalized_total_op_plans",
															"op_earliness",
															"inventory"});
			this.cb_oblevel.Location = new System.Drawing.Point(16, 16);
			this.cb_oblevel.Name = "cb_oblevel";
			this.cb_oblevel.Size = new System.Drawing.Size(168, 19);
			this.cb_oblevel.TabIndex = 0;
			// 
			// nud_istimeweighted
			// 
			this.nud_istimeweighted.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.nud_istimeweighted.Location = new System.Drawing.Point(184, 40);
			this.nud_istimeweighted.Maximum = new System.Decimal(new int[] {
																			   1,
																			   0,
																			   0,
																			   0});
			this.nud_istimeweighted.Name = "nud_istimeweighted";
			this.nud_istimeweighted.Size = new System.Drawing.Size(32, 20);
			this.nud_istimeweighted.TabIndex = 1;
			this.nud_istimeweighted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_qualifier
			// 
			this.tb_qualifier.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_qualifier.Location = new System.Drawing.Point(16, 40);
			this.tb_qualifier.Name = "tb_qualifier";
			this.tb_qualifier.Size = new System.Drawing.Size(168, 20);
			this.tb_qualifier.TabIndex = 2;
			this.tb_qualifier.Text = "";
			this.tb_qualifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// bt_generate
			// 
			this.bt_generate.Enabled = false;
			this.bt_generate.Location = new System.Drawing.Point(11, 245);
			this.bt_generate.Name = "bt_generate";
			this.bt_generate.Size = new System.Drawing.Size(90, 24);
			this.bt_generate.TabIndex = 1;
			this.bt_generate.Text = "Generate";
			this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
			// 
			// bt_save
			// 
			this.bt_save.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.bt_save.Location = new System.Drawing.Point(99, 245);
			this.bt_save.Name = "bt_save";
			this.bt_save.Size = new System.Drawing.Size(90, 24);
			this.bt_save.TabIndex = 1;
			this.bt_save.Text = "Save";
			this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
			// 
			// bt_cancle
			// 
			this.bt_cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bt_cancle.Location = new System.Drawing.Point(187, 245);
			this.bt_cancle.Name = "bt_cancle";
			this.bt_cancle.Size = new System.Drawing.Size(90, 24);
			this.bt_cancle.TabIndex = 1;
			this.bt_cancle.Text = "Cancle";
			this.bt_cancle.Click += new System.EventHandler(this.bt_cancle_Click);
			// 
			// FormFLOStt
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.bt_cancle;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.ControlBox = false;
			this.Controls.Add(this.bt_generate);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.bt_save);
			this.Controls.Add(this.bt_cancle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormFLOStt";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormFLOStt";
			this.tabControl1.ResumeLayout(false);
			this.tpTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nud_bitposition)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_engineid)).EndInit();
			this.tpPlan.ResumeLayout(false);
			this.tpPram.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nud_keeporbetter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_exportunpeggedmaterial)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_exportunpeggedcapacity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_exportdaterange)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_exportsourcepegging)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_usetransportcapacity)).EndInit();
			this.tpBucket.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nud_firstdayofweek)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_patternsequence)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_bucketsize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_numberofbuckets)).EndInit();
			this.tpLayer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nud_priority)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_demandprioritystart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_demandpriorityend)).EndInit();
			this.tpOblevel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nud_obpriority)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_istimeweighted)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region private variables	
		private DrawArea drawArea;
		private FLOStt o;
		private ArrayList lqualifier = new ArrayList();
		private ArrayList squalifier = new ArrayList();
		#endregion

		#region initizlizer
		public FormFLOStt(DrawArea Drawarea, FLOObj O)
		{
			drawArea = Drawarea;
			o = (FLOStt)O;
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}

		public FormFLOStt(DrawArea Drawarea, FLOStt O)
		{
			drawArea = Drawarea;
			o = O;
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}
		#endregion

		#region lockedform
		#endregion

		#region setattr
		public void SetAttr(FLOObj O)
		{
			o = (FLOStt)O;

			this.cb_bucketsizeuom.SelectedItem = o.Stt_bucketsizeuom;
			this.cb_mpasolver.SelectedItem = o.Stt_mpa_solver;

			this.dtp_planenddate.Value = Convert.ToDateTime("1999-01-01");
			this.dtp_plancurrentdate.Value = Convert.ToDateTime("1999-01-01");
			this.dtp_effstartdate.Value = Convert.ToDateTime("1999-01-01");
			this.dtp_planstartdate.Value = Convert.ToDateTime("1999-01-01");

			this.dtp_planenddate.Value = Convert.ToDateTime(o.Stt_planenddate);
			this.dtp_plancurrentdate.Value = Convert.ToDateTime(o.Stt_plancurrentdate);
			this.dtp_effstartdate.Value = Convert.ToDateTime(o.Stt_effstartdate);
			this.dtp_planstartdate.Value = Convert.ToDateTime(o.Stt_planstartdate);

			this.nud_bitposition.Value = (decimal)o.Stt_bitposition;
			this.nud_bucketsize.Value = (decimal)o.Stt_bucketsize;
			this.nud_engineid.Value = (decimal)o.Stt_engine_id;
			this.nud_exportdaterange.Value = (decimal)o.Stt_export_date_range;
			this.nud_exportsourcepegging.Value = (decimal)o.Stt_export_source_peggings;
			this.nud_exportunpeggedcapacity.Value = (decimal)o.Stt_export_unpegged_capacity;
			this.nud_exportunpeggedmaterial.Value = (decimal)o.Stt_export_unpegged_material;
			this.nud_firstdayofweek.Value = (decimal)o.Stt_firstdayofweek;
			this.nud_keeporbetter.Value = (decimal)o.Stt_keep_or_better;
			this.nud_numberofbuckets.Value = (decimal)o.Stt_numberofbuckets;
			this.nud_patternsequence.Value = (decimal)o.Stt_patternsequence;
			this.nud_usetransportcapacity.Value = (decimal)o.Stt_use_transport_capacity;
			this.tb_boundaryid.Text = o.Stt_boundaryid;
			this.tb_bucketname.Text = o.Stt_bucketname;
			this.tb_enterprise.Text = o.Stt_enterprise;
			this.tb_instanceid.Text = o.Stt_instanceid;
			this.tb_planid.Text = o.Stt_planid;
			this.tb_supplychainid.Text = o.Stt_supplychainid;
			this.tb_workcenter.Text = o.Stt_workcenter;
			this.tb_organizationid.Text = o.Stt_organizationid;

			this.cb_oblevel.SelectedIndex = 0;
            
			this.SetAttrLpLayers();
			this.SetAttrOBLevels();
		}
		#endregion

		#region getattr
		public void GetAttr(FLOObj O)
		{
			if(CheckFormLogic())
				return;

			o = (FLOStt)O;

			o.Stt_bucketsizeuom = cb_bucketsizeuom.SelectedItem.ToString();
			o.Stt_mpa_solver = cb_mpasolver.SelectedItem.ToString();
			o.Stt_effstartdate = dtp_effstartdate.Value.ToShortDateString();
			o.Stt_plancurrentdate = dtp_plancurrentdate.Value.ToShortDateString();
			o.Stt_planenddate = dtp_planenddate.Value.ToShortDateString();
			o.Stt_planstartdate = dtp_planstartdate.Value.ToShortDateString();
			o.Stt_bitposition = (int)nud_bitposition.Value;
			o.Stt_bucketsize = (int)nud_bucketsize.Value;
			o.Stt_engine_id = (int)nud_engineid.Value;
			o.Stt_export_date_range = (int)nud_exportdaterange.Value;
			o.Stt_export_source_peggings = (int)nud_exportsourcepegging.Value;
			o.Stt_export_unpegged_capacity = (int)nud_exportunpeggedcapacity.Value;
			o.Stt_export_unpegged_material = (int)nud_exportunpeggedmaterial.Value;
			o.Stt_firstdayofweek = (int)nud_firstdayofweek.Value;
			o.Stt_keep_or_better = (int)nud_keeporbetter.Value;
			o.Stt_numberofbuckets = (int)nud_numberofbuckets.Value;
			o.Stt_patternsequence = (int)nud_patternsequence.Value;
			o.Stt_use_transport_capacity = (int)nud_usetransportcapacity.Value;
			o.Stt_boundaryid = tb_boundaryid.Text;
			o.Stt_bucketname = tb_bucketname.Text;
			o.Stt_enterprise = tb_enterprise.Text;
			o.Stt_instanceid = tb_instanceid.Text;
			o.Stt_planid = tb_planid.Text;
			o.Stt_supplychainid = tb_supplychainid.Text;
			o.Stt_workcenter = tb_workcenter.Text;
			o.Stt_organizationid = tb_organizationid.Text;

			o.Stt_lplayers.Clear();
			o.Stt_oblevels.Clear();

			for(int i = 0; i < this.lv_lplayer.Items.Count; i++)
			{
				FLOStt.LPLayer layer;

				layer.stt_layername = this.lv_lplayer.Items[i].SubItems[0].Text;
				layer.stt_layertype = this.lv_lplayer.Items[i].SubItems[1].Text;
				layer.stt_priority = Convert.ToInt32(this.lv_lplayer.Items[i].SubItems[2].Text);
				layer.stt_demandprioritystart = Convert.ToInt32(this.lv_lplayer.Items[i].SubItems[3].Text);
				layer.stt_demandpriorityend = Convert.ToInt32(this.lv_lplayer.Items[i].SubItems[4].Text);
				layer.stt_demandbands = this.lv_lplayer.Items[i].SubItems[5].Text;

				o.Stt_lplayers.Add(layer);
			}

			for(int i = 0; i < this.lv_oblevels.Items.Count; i++)
			{
				FLOStt.OBLevel level;

				level.stt_oblevel = this.lv_oblevels.Items[i].SubItems[0].Text;
				level.stt_priority = Convert.ToInt32(this.lv_oblevels.Items[i].SubItems[1].Text);
				level.stt_qualifier = this.lv_oblevels.Items[i].SubItems[2].Text;
				level.stt_istimeweighted = Convert.ToInt32(this.lv_oblevels.Items[i].SubItems[3].Text);
				level.stt_lpmethod = this.lv_oblevels.Items[i].SubItems[4].Text;

				o.Stt_oblevels.Add(level);
			}
		}

		private void SetAttrLpLayers()
		{
			this.lv_lplayer.Items.Clear();

			foreach(FLOStt.LPLayer layer in o.Stt_lplayers)
			{
				this.lv_lplayer.Items.AddRange( 
					new ListViewItem[] { 
										   new ListViewItem(new string[] {
																			 layer.stt_layername,
																			 layer.stt_layertype,
																			 layer.stt_priority.ToString(),
																			 layer.stt_demandprioritystart.ToString(),
																			 layer.stt_demandpriorityend.ToString(),
																			 layer.stt_demandbands }, -1) });
			}
		}

		private void SetAttrOBLevels()
		{
			this.lv_oblevels.Items.Clear();

			foreach(FLOStt.OBLevel level in o.Stt_oblevels)
			{
				this.lv_oblevels.Items.AddRange( 
					new ListViewItem[] { 
										   new ListViewItem(new string[] {
																			 level.stt_oblevel,
																			 level.stt_priority.ToString(),
																			 level.stt_qualifier,
																			 level.stt_istimeweighted.ToString(),
																			 level.stt_lpmethod }, -1) });
			}
		}

		//		private void SetAttrOBLevels()
		//		{
		//			this.lv_oblevels.Items.Clear();
		//
		//			ArrayList Layers = new ArrayList();
		//
		//			if(this.lv_lplayer.Items.Count > 0)
		//				for(int i = 0; i < this.lv_lplayer.Items.Count; i++)
		//				{
		//					Layers.Add(this.lv_lplayer.Items[i].SubItems[0].Text);
		//					Layers.Add(Convert.ToInt32(this.lv_lplayer.Items[i].SubItems[2].Text));
		//				}
		//
		//			int x = 0;
		//
		//			if(Layers.Count > 1)
		//				x = (int)Layers[1];
		//
		//			for(int i = 0; i < Layers.Count; i = i +2)
		//			{
		//				if( x < (int)Layers[i+1] )
		//					x = (int)Layers[i+1];
		//			}
		//
		//			for(int i = 0; i < Layers.Count; i = i + 2)
		//			{
		//				lv_oblevels.Items.AddRange(
		//					new ListViewItem[] {
		//						new ListViewItem(new string[] { 
		//							"amt_not_satisfied",
		//							Convert.ToString(x*1000 - (int)Layers[i+1]*10),
		//							Layers[i].ToString(),
		//							"0",
		//							"P"},-1)});	
		//
		//				lv_oblevels.Items.AddRange(
		//					new ListViewItem[] {
		//						new ListViewItem(new string[] { 
		//							"backlog",
		//							Convert.ToString(x*1000 - (int)Layers[i+1]*10 -1),
		//							Layers[i].ToString(),
		//							"0",
		//							"P"},-1)});	
		//			}
		//		}
		#endregion
		
		#region getobj/disname
		#endregion

		#region checkformlogic
		public bool CheckFormLogic()
		{
			if(this.tb_enterprise.Text.Length < 1)
				return true;
			if(this.tb_instanceid.Text.Length < 1)
				return true;
			if(this.tb_supplychainid.Text.Length < 1)
				return true;
			if(this.tb_organizationid.Text.Length < 1)
				return true;
			if(this.tb_planid.Text.Length < 1)
				return true;
			if(this.tb_workcenter.Text.Length < 1)
				return true;
			if(this.tb_bucketname.Text.Length < 1)
				return true;
			if(this.tb_instanceid == this.tb_enterprise || this.tb_instanceid == this.tb_supplychainid || this.tb_instanceid == this.tb_organizationid || this.tb_instanceid == this.tb_workcenter)
				return true;
			if(this.tb_enterprise == this.tb_supplychainid || this.tb_enterprise == this.tb_organizationid || this.tb_enterprise == this.tb_workcenter)
				return true;
			if(this.tb_supplychainid == this.tb_organizationid || this.tb_supplychainid == this.tb_workcenter)
				return true;
			if(this.tb_organizationid == this.tb_workcenter)
				return true;

			return false;
		}
		#endregion

		#region button
		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.tabControl1.SelectedTab == this.tpLayer)	
				bt_generate.Enabled = true;
			else if(this.tabControl1.SelectedTab == this.tpOblevel)
				bt_generate.Enabled = true;
			else
				bt_generate.Enabled = false;
		}

		private void bt_generate_Click(object sender, System.EventArgs e)
		{
			if(this.tabControl1.SelectedTab == this.tpLayer)
			{
				o.GetLpLayers(this.drawArea);
				this.SetAttrLpLayers();
			}
			else if(this.tabControl1.SelectedTab == this.tpOblevel)
			{
				o.GetOBLevels(this.drawArea);
				this.SetAttrOBLevels();
			}
		}

		private void bt_save_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void bt_cancle_Click(object sender, System.EventArgs e)
		{
			this.Close();		
		}
		#endregion

		#region master
		private void nud_bitposition_ValueChanged(object sender, System.EventArgs e)
		{
			this.nud_engineid.Value = (decimal)Math.Pow(2,(double)this.nud_bitposition.Value);
		}

		private void dtp_planstartdate_ValueChanged(object sender, System.EventArgs e)
		{
			if(	dtp_planstartdate.Value > dtp_plancurrentdate.Value || 
				dtp_planstartdate.Value > dtp_effstartdate.Value || 
				dtp_planstartdate.Value > dtp_planenddate.Value)
				dtp_planstartdate.Value  = (dtp_plancurrentdate.Value > dtp_effstartdate.Value) ? Convert.ToDateTime(dtp_effstartdate.Value.ToShortDateString()):Convert.ToDateTime(dtp_plancurrentdate.Value.ToShortDateString());
		}

		private void dtp_plancurrentdate_ValueChanged(object sender, System.EventArgs e)
		{
			if(dtp_plancurrentdate.Value < dtp_planstartdate.Value)
				dtp_plancurrentdate.Value  = Convert.ToDateTime(dtp_planstartdate.Value.ToShortDateString());
			else if(dtp_plancurrentdate.Value > dtp_planenddate.Value)
				dtp_plancurrentdate.Value  = Convert.ToDateTime(dtp_planenddate.Value.ToShortDateString());
		}

		private void dtp_planenddate_ValueChanged(object sender, System.EventArgs e)
		{
			if(dtp_planenddate.Value < dtp_plancurrentdate.Value || dtp_planenddate.Value < dtp_effstartdate.Value || dtp_planenddate.Value < dtp_planenddate.Value)
				dtp_planenddate.Value  = (dtp_plancurrentdate.Value < dtp_effstartdate.Value) ? Convert.ToDateTime(dtp_effstartdate.Value.ToShortDateString()):Convert.ToDateTime(dtp_plancurrentdate.Value.ToShortDateString());

			GetNumberOfBucket();	
		}
		#endregion

		#region bucket
		private void dtp_effstartdate_ValueChanged(object sender, System.EventArgs e)
		{
			if(dtp_effstartdate.Value < dtp_planstartdate.Value)
				dtp_effstartdate.Value  = Convert.ToDateTime(dtp_planstartdate.Value.ToShortDateString());
			else if(dtp_effstartdate.Value > dtp_planenddate.Value)
				dtp_effstartdate.Value  = Convert.ToDateTime(dtp_planenddate.Value.ToShortDateString());

			GetNumberOfBucket();	
		}

		private void cb_bucketsizeuom_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			GetNumberOfBucket();
		}

		private void nud_bucketsize_ValueChanged(object sender, System.EventArgs e)
		{
			GetNumberOfBucket();		
		}

		private void GetNumberOfBucket()
		{
			TimeSpan a = new TimeSpan(dtp_planenddate.Value.Ticks);
			TimeSpan b = new TimeSpan(dtp_effstartdate.Value.Ticks);

			int r = Math.Abs(Convert.ToInt32(a.Subtract(b).TotalDays));
			int divider = 1;

			if(this.cb_bucketsizeuom.SelectedItem.ToString() == "week")
				divider = 7;

			if(this.nud_bucketsize.Value > 1)
				divider = divider * (int)this.nud_bucketsize.Value;

			this.nud_numberofbuckets.Value = r/divider;	
			this.nud_exportdaterange.Value = r/divider;
		}
		#endregion

		#region  lplayer buttons
		private void lv_lplayer_ItemActivate(object sender, System.EventArgs e)
		{
			if(this.lv_lplayer.Items.Count > 0)
			{
				ListViewItem item = lv_lplayer.FocusedItem;

				this.tb_layername.Text = item.SubItems[0].Text;
				this.cb_layertype.SelectedItem = item.SubItems[1].Text;
				this.nud_priority.Value = Convert.ToDecimal(item.SubItems[2].Text);
				this.nud_demandprioritystart.Value = Convert.ToDecimal(item.SubItems[3].Text);
				this.nud_demandpriorityend.Value = Convert.ToDecimal(item.SubItems[4].Text);
				this.tb_demandbands.Text = item.SubItems[5].Text;		
			}
		}

		private void bt_lplayeradd_Click(object sender, System.EventArgs e)
		{
			lv_lplayer.Items.AddRange(
				new ListViewItem[] {
									   new ListViewItem(new string[] { 
																		 this.tb_layername.Text,
																		 this.cb_layertype.SelectedItem.ToString(),
																		 this.nud_priority.Value.ToString(),
																		 this.nud_demandprioritystart.Value.ToString(),
																		 this.nud_demandpriorityend.Value.ToString(),
																		 this.tb_demandbands.Text},-1)});			
		}

		private void bt_lplayerinsert_Click(object sender, System.EventArgs e)
		{
			if(lv_lplayer.FocusedItem == null)
				return;

			lv_lplayer.Items.Insert(
				lv_lplayer.FocusedItem.Index,
				new ListViewItem(new string[] { 
												  this.tb_layername.Text,
												  this.cb_layertype.SelectedItem.ToString(),
												  this.nud_priority.Value.ToString(),
												  this.nud_demandprioritystart.Value.ToString(),
												  this.nud_demandpriorityend.Value.ToString(),
												  this.tb_demandbands.Text },-1));
		}

		private void bt_lplayerupdate_Click(object sender, System.EventArgs e)
		{
			if(lv_lplayer.FocusedItem == null)
				return;

			lv_lplayer.Items.Insert(lv_lplayer.FocusedItem.Index,
				new ListViewItem(
				new string[] { 
								 this.tb_layername.Text,
								 this.cb_layertype.SelectedItem.ToString(),
								 this.nud_priority.Value.ToString(),
								 this.nud_demandprioritystart.Value.ToString(),
								 this.nud_demandpriorityend.Value.ToString(),
								 this.tb_demandbands.Text },-1));
			
			lv_lplayer.Items.RemoveAt(lv_lplayer.FocusedItem.Index);	
		}

		private void bt_lplayerdelete_Click(object sender, System.EventArgs e)
		{
			if(lv_lplayer.Items.Count < 1)
				return;

			if(lv_lplayer.FocusedItem == null)
				return;

			foreach(ListViewItem items in lv_lplayer.Items)
			{
				if(items.Selected && lv_lplayer.Items.Count > 0)
					items.Remove();
			}
		}
		#endregion

		#region oblevel buttons
		private void lv_oblevels_ItemActivate(object sender, System.EventArgs e)
		{
			if(this.lv_oblevels.Items.Count > 0)
			{
				ListViewItem item = this.lv_oblevels.FocusedItem;

				this.cb_oblevel.SelectedItem = item.SubItems[0].Text;
				this.nud_obpriority.Value =  Convert.ToDecimal(item.SubItems[1].Text);
				this.tb_qualifier.Text = item.SubItems[2].Text;
				this.nud_istimeweighted.Value = Convert.ToDecimal(item.SubItems[3].Text);
				this.tb_lpmethod.Text = item.SubItems[4].Text;			
			}
		}

		private void bt_obleveladd_Click(object sender, System.EventArgs e)
		{
			lv_oblevels.Items.AddRange(
				new ListViewItem[] {
									   new ListViewItem(new string[] { 
																		 this.cb_oblevel.SelectedItem.ToString(),
																		 this.nud_obpriority.Value.ToString(),
																		 this.tb_qualifier.Text,
																		 this.nud_istimeweighted.Value.ToString(),
																		 this.tb_lpmethod.Text },-1)});
		}

		private void bt_oblevelinsert_Click(object sender, System.EventArgs e)
		{
			if(lv_oblevels.FocusedItem == null)
				return;

			lv_oblevels.Items.Insert(
				lv_oblevels.FocusedItem.Index,
				new ListViewItem(new string[] { 
												  this.cb_oblevel.SelectedItem.ToString(),
												  this.nud_obpriority.Value.ToString(),
												  this.tb_qualifier.Text,
												  this.nud_istimeweighted.Value.ToString(),
												  this.tb_lpmethod.Text },-1));		
		}

		private void bt_oblevelupdate_Click(object sender, System.EventArgs e)
		{
			if(lv_oblevels.FocusedItem == null)
				return;

			lv_oblevels.Items.Insert(lv_oblevels.FocusedItem.Index,
				new ListViewItem(
				new string[] { 
								 this.cb_oblevel.SelectedItem.ToString(),
								 this.nud_obpriority.Value.ToString(),
								 this.tb_qualifier.Text,
								 this.nud_istimeweighted.Value.ToString(),
								 this.tb_lpmethod.Text },-1));	
				
			lv_oblevels.Items.RemoveAt(lv_oblevels.FocusedItem.Index);		
		}

		private void bt_obleveldelete_Click(object sender, System.EventArgs e)
		{
			if(lv_oblevels.Items.Count < 1)
				return;

			if(lv_oblevels.FocusedItem == null)
				return;

			foreach(ListViewItem items in lv_oblevels.Items)
			{
				if(items.Selected && lv_oblevels.Items.Count > 0)
					items.Remove();
			}		
		}
		#endregion

		private bool click;

		private void lv_lplayer_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			if(!this.click)   // 여기서 this.click 는 bool click 입니다. 전역변수로 선언해 주세요.
			{
				this.lv_lplayer.ListViewItemSorter = new ListViewItemComparerASC(e.Column);
				this.lv_lplayer.Sort();
				this.click = true;
			}
			else
			{
				this.lv_lplayer.ListViewItemSorter = new ListViewItemComparerDES(e.Column);
				this.lv_lplayer.Sort();
				this.click = false;
			}
		}

		private void lv_oblevels_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			if(!this.click)   // 여기서 this.click 는 bool click 입니다. 전역변수로 선언해 주세요.
			{
				this.lv_oblevels.ListViewItemSorter = new ListViewItemComparerASC(e.Column);
				this.lv_oblevels.Sort();
				this.click = true;
			}
			else
			{
				this.lv_oblevels.ListViewItemSorter = new ListViewItemComparerDES(e.Column);
				this.lv_oblevels.Sort();
				this.click = false;
			}		
		}
	}
	
	public class ListViewItemComparerASC : IComparer
	{
		private int col;
		public ListViewItemComparerASC() 
		{
			col=0;
		}

		public ListViewItemComparerASC(int column) 
		{
			col=column;
		}

		public int Compare(object x, object y) 
		{
			try
			{
				// 숫자 비교
				if(Convert.ToInt32(((ListViewItem)x).SubItems[col].Text)> Convert.ToInt32(((ListViewItem)y).SubItems[col].Text))
				{
					return 1;
				}
				else
					return -1;
			}
			catch(Exception)
			{
				// 텍스트 비교
				return String.Compare( ((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text); 
			}                                                                       
		}
	}

	public class ListViewItemComparerDES : IComparer 
	{
		private int col;
		public ListViewItemComparerDES() 
		{
			col=0;
		}
		public ListViewItemComparerDES(int column) 
		{
			col=column;
		}

		public int Compare(object x, object y) 
		{
			try
			{
				if(Convert.ToInt32(((ListViewItem)x).SubItems[col].Text)< Convert.ToInt32(((ListViewItem)y).SubItems[col].Text))
				{
					return 1;
				}
				else
					return -1;
			}
			catch(Exception)
			{
				if(String.Compare( ((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text) == 1)
				{
					return -1;
				}
				else
					return 1;
			}                
		}
	}
}