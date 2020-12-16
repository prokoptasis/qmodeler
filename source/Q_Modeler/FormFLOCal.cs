using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Q_Modeler
{
	public class FormFLOCal : Q_Modeler.FormFLO
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ColumnHeader Seq;
		private System.Windows.Forms.ColumnHeader Start;
		private System.Windows.Forms.ColumnHeader End;
		private System.Windows.Forms.ColumnHeader Qty;
		private System.Windows.Forms.TextBox tb_calendar;
		private System.Windows.Forms.TextBox tb_calendarpre;
		private System.Windows.Forms.ComboBox cb_caltype;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_detailidx;
		private System.Windows.Forms.NumericUpDown nud_calqtyper;
		private System.Windows.Forms.ComboBox cb_pattern;
		private System.Windows.Forms.ComboBox cb_dayofweek;
		private System.Windows.Forms.NumericUpDown nud_numofday;
		private System.Windows.Forms.Button bt_deldetail;
		private System.Windows.Forms.DateTimePicker dtp_effstart;
		private System.Windows.Forms.DateTimePicker dtp_effend;
		private System.Windows.Forms.Button bt_adddetail;
		private System.Windows.Forms.Button bt_upddetail;
		private System.Windows.Forms.Button bt_insdetail;
		private System.Windows.Forms.ListView lv_details;
		private System.ComponentModel.IContainer components = null;

		#region initializer
		public FormFLOCal()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.tb_calendar = new System.Windows.Forms.TextBox();
			this.tb_calendarpre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_detailidx = new System.Windows.Forms.TextBox();
			this.nud_calqtyper = new System.Windows.Forms.NumericUpDown();
			this.bt_deldetail = new System.Windows.Forms.Button();
			this.dtp_effstart = new System.Windows.Forms.DateTimePicker();
			this.dtp_effend = new System.Windows.Forms.DateTimePicker();
			this.bt_adddetail = new System.Windows.Forms.Button();
			this.bt_upddetail = new System.Windows.Forms.Button();
			this.bt_insdetail = new System.Windows.Forms.Button();
			this.cb_pattern = new System.Windows.Forms.ComboBox();
			this.cb_dayofweek = new System.Windows.Forms.ComboBox();
			this.nud_numofday = new System.Windows.Forms.NumericUpDown();
			this.lv_details = new System.Windows.Forms.ListView();
			this.Seq = new System.Windows.Forms.ColumnHeader();
			this.Start = new System.Windows.Forms.ColumnHeader();
			this.End = new System.Windows.Forms.ColumnHeader();
			this.Qty = new System.Windows.Forms.ColumnHeader();
			this.cb_caltype = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nud_calqtyper)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_numofday)).BeginInit();
			this.SuspendLayout();
			// 
			// tb_calendar
			// 
			this.tb_calendar.Location = new System.Drawing.Point(120, 24);
			this.tb_calendar.Name = "tb_calendar";
			this.tb_calendar.Size = new System.Drawing.Size(152, 21);
			this.tb_calendar.TabIndex = 0;
			this.tb_calendar.Text = "";
			this.tb_calendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_calendarpre
			// 
			this.tb_calendarpre.Enabled = false;
			this.tb_calendarpre.Location = new System.Drawing.Point(88, 24);
			this.tb_calendarpre.Name = "tb_calendarpre";
			this.tb_calendarpre.Size = new System.Drawing.Size(32, 21);
			this.tb_calendarpre.TabIndex = 2;
			this.tb_calendarpre.TabStop = false;
			this.tb_calendarpre.Text = "";
			this.tb_calendarpre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cal.Attrbt.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 21);
			this.label4.TabIndex = 1;
			this.label4.Text = "Rep.Days.";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_detailidx
			// 
			this.tb_detailidx.Enabled = false;
			this.tb_detailidx.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_detailidx.Location = new System.Drawing.Point(16, 96);
			this.tb_detailidx.Name = "tb_detailidx";
			this.tb_detailidx.Size = new System.Drawing.Size(24, 20);
			this.tb_detailidx.TabIndex = 12;
			this.tb_detailidx.TabStop = false;
			this.tb_detailidx.Text = "";
			this.tb_detailidx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_calqtyper
			// 
			this.nud_calqtyper.DecimalPlaces = 2;
			this.nud_calqtyper.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.nud_calqtyper.Location = new System.Drawing.Point(40, 96);
			this.nud_calqtyper.Maximum = new System.Decimal(new int[] {
																		  9999999,
																		  0,
																		  0,
																		  0});
			this.nud_calqtyper.Name = "nud_calqtyper";
			this.nud_calqtyper.Size = new System.Drawing.Size(72, 20);
			this.nud_calqtyper.TabIndex = 4;
			this.nud_calqtyper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nud_calqtyper.ThousandsSeparator = true;
			// 
			// bt_deldetail
			// 
			this.bt_deldetail.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.bt_deldetail.Location = new System.Drawing.Point(152, 96);
			this.bt_deldetail.Name = "bt_deldetail";
			this.bt_deldetail.Size = new System.Drawing.Size(40, 20);
			this.bt_deldetail.TabIndex = 9;
			this.bt_deldetail.Tag = "Delete";
			this.bt_deldetail.Text = "Del";
			this.bt_deldetail.Click += new System.EventHandler(this.bt_deldetail_Click);
			// 
			// dtp_effstart
			// 
			this.dtp_effstart.CalendarFont = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.dtp_effstart.Font = new System.Drawing.Font("돋움", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.dtp_effstart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_effstart.Location = new System.Drawing.Point(16, 120);
			this.dtp_effstart.Name = "dtp_effstart";
			this.dtp_effstart.Size = new System.Drawing.Size(128, 20);
			this.dtp_effstart.TabIndex = 5;
			// 
			// dtp_effend
			// 
			this.dtp_effend.CalendarFont = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.dtp_effend.Font = new System.Drawing.Font("돋움", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.dtp_effend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_effend.Location = new System.Drawing.Point(144, 120);
			this.dtp_effend.Name = "dtp_effend";
			this.dtp_effend.Size = new System.Drawing.Size(128, 20);
			this.dtp_effend.TabIndex = 6;
			// 
			// bt_adddetail
			// 
			this.bt_adddetail.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.bt_adddetail.Location = new System.Drawing.Point(112, 96);
			this.bt_adddetail.Name = "bt_adddetail";
			this.bt_adddetail.Size = new System.Drawing.Size(40, 20);
			this.bt_adddetail.TabIndex = 7;
			this.bt_adddetail.Tag = "Add";
			this.bt_adddetail.Text = "Add";
			this.bt_adddetail.Click += new System.EventHandler(this.bt_adddetail_Click);
			// 
			// bt_upddetail
			// 
			this.bt_upddetail.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.bt_upddetail.Location = new System.Drawing.Point(192, 96);
			this.bt_upddetail.Name = "bt_upddetail";
			this.bt_upddetail.Size = new System.Drawing.Size(40, 20);
			this.bt_upddetail.TabIndex = 10;
			this.bt_upddetail.Tag = "Update";
			this.bt_upddetail.Text = "Upd";
			this.bt_upddetail.Click += new System.EventHandler(this.bt_upddetail_Click);
			// 
			// bt_insdetail
			// 
			this.bt_insdetail.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.bt_insdetail.Location = new System.Drawing.Point(232, 96);
			this.bt_insdetail.Name = "bt_insdetail";
			this.bt_insdetail.Size = new System.Drawing.Size(40, 20);
			this.bt_insdetail.TabIndex = 11;
			this.bt_insdetail.Tag = "Insert";
			this.bt_insdetail.Text = "Ins";
			this.bt_insdetail.Click += new System.EventHandler(this.bt_insdetail_Click);
			// 
			// cb_pattern
			// 
			this.cb_pattern.Items.AddRange(new object[] {	FLOObj.CPTTYPE.EVERYDAY,
															FLOObj.CPTTYPE.DAYS_OF_WEEK,
															FLOObj.CPTTYPE.EVERY_N_DAYS,
															FLOObj.CPTTYPE.DAY_OF_MONTH,
															FLOObj.CPTTYPE.DAY_OF_YEAR } );
			this.cb_pattern.Location = new System.Drawing.Point(184, 48);
			this.cb_pattern.Name = "cb_pattern";
			this.cb_pattern.Size = new System.Drawing.Size(88, 20);
			this.cb_pattern.TabIndex = 1;
			this.cb_pattern.SelectedIndexChanged += new System.EventHandler(this.cb_pattern_SelectedIndexChanged);
			// 
			// cb_dayofweek
			// 
			this.cb_dayofweek.Items.AddRange(new object[] {	FLOObj.CDWTYPE.Mo,
															  FLOObj.CDWTYPE.Tu,
															  FLOObj.CDWTYPE.We,
															  FLOObj.CDWTYPE.Th,
															  FLOObj.CDWTYPE.Fr,
															  FLOObj.CDWTYPE.Sa,
															  FLOObj.CDWTYPE.Su } );
			this.cb_dayofweek.Location = new System.Drawing.Point(88, 72);
			this.cb_dayofweek.Name = "cb_dayofweek";
			this.cb_dayofweek.Size = new System.Drawing.Size(96, 20);
			this.cb_dayofweek.TabIndex = 2;
			// 
			// nud_numofday
			// 
			this.nud_numofday.Location = new System.Drawing.Point(184, 72);
			this.nud_numofday.Name = "nud_numofday";
			this.nud_numofday.Size = new System.Drawing.Size(88, 21);
			this.nud_numofday.TabIndex = 3;
			this.nud_numofday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lv_details
			// 
			this.lv_details.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.lv_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						 this.Seq,
																						 this.Start,
																						 this.End,
																						 this.Qty});
			this.lv_details.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv_details.FullRowSelect = true;
			this.lv_details.HideSelection = false;
			this.lv_details.LabelWrap = false;
			this.lv_details.Location = new System.Drawing.Point(16, 144);
			this.lv_details.Name = "lv_details";
			this.lv_details.Size = new System.Drawing.Size(256, 74);
			this.lv_details.TabIndex = 7;
			this.lv_details.View = System.Windows.Forms.View.Details;
			this.lv_details.ItemActivate += new System.EventHandler(this.lv_details_ItemActivate);
			// 
			// Seq
			// 
			this.Seq.Text = "Seq";
			this.Seq.Width = 38;
			// 
			// Start
			// 
			this.Start.Text = "Start";
			this.Start.Width = 88;
			// 
			// End
			// 
			this.End.Text = "End";
			this.End.Width = 88;
			// 
			// Qty
			// 
			this.Qty.Text = "Qty";
			this.Qty.Width = 38;
			// 
			// cb_caltype
			// 
			this.cb_caltype.Items.AddRange(new object[] {
															FLOObj.CALTYPE.AVAILABLE_CAPACITY,
															FLOObj.CALTYPE.REP_QTY,
															FLOObj.CALTYPE.MAX_ON_HAND,
															FLOObj.CALTYPE.MIN_ON_HAND,
															FLOObj.CALTYPE.YIELD,
															FLOObj.CALTYPE.EFFICIENCY });
			this.cb_caltype.Location = new System.Drawing.Point(88, 48);
			this.cb_caltype.Name = "cb_caltype";
			this.cb_caltype.Size = new System.Drawing.Size(96, 20);
			this.cb_caltype.TabIndex = 101;
			this.cb_caltype.SelectedIndexChanged += new System.EventHandler(this.cb_caltype_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "Calendar";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormFLOCal
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.cb_caltype);
			this.Controls.Add(this.lv_details);
			this.Controls.Add(this.nud_numofday);
			this.Controls.Add(this.tb_calendar);
			this.Controls.Add(this.tb_calendarpre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tb_detailidx);
			this.Controls.Add(this.nud_calqtyper);
			this.Controls.Add(this.bt_deldetail);
			this.Controls.Add(this.dtp_effstart);
			this.Controls.Add(this.dtp_effend);
			this.Controls.Add(this.bt_adddetail);
			this.Controls.Add(this.bt_upddetail);
			this.Controls.Add(this.bt_insdetail);
			this.Controls.Add(this.cb_pattern);
			this.Controls.Add(this.cb_dayofweek);
			this.Controls.Add(this.label3);
			this.DockPadding.Bottom = 48;
			this.DockPadding.Left = 16;
			this.DockPadding.Right = 20;
			this.DockPadding.Top = 144;
			this.Name = "FormFLOCal";
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.cb_dayofweek, 0);
			this.Controls.SetChildIndex(this.cb_pattern, 0);
			this.Controls.SetChildIndex(this.bt_insdetail, 0);
			this.Controls.SetChildIndex(this.bt_upddetail, 0);
			this.Controls.SetChildIndex(this.bt_adddetail, 0);
			this.Controls.SetChildIndex(this.dtp_effend, 0);
			this.Controls.SetChildIndex(this.dtp_effstart, 0);
			this.Controls.SetChildIndex(this.bt_deldetail, 0);
			this.Controls.SetChildIndex(this.nud_calqtyper, 0);
			this.Controls.SetChildIndex(this.tb_detailidx, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.tb_calendarpre, 0);
			this.Controls.SetChildIndex(this.tb_calendar, 0);
			this.Controls.SetChildIndex(this.nud_numofday, 0);
			this.Controls.SetChildIndex(this.lv_details, 0);
			this.Controls.SetChildIndex(this.cb_caltype, 0);
			((System.ComponentModel.ISupportInitialize)(this.nud_calqtyper)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_numofday)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region initizlizer
		public FormFLOCal(int locktype)
		{
			InitializeComponent();
			
			this.cb_caltype.SelectedIndex = 0;
			this.cb_pattern.SelectedIndex = 0;
			this.cb_dayofweek.SelectedIndex = 0;

			LockedForm(locktype);
		}
		#endregion

		#region lockedform
		public override void LockedForm(int type)
		{
			switch(type)
			{
				case 0:
				{
					this.tb_calendarpre.Enabled = false;
					this.tb_calendar.Enabled = true;
					this.cb_caltype.Enabled = true;
					this.cb_dayofweek.Enabled = false;
					this.cb_pattern.Enabled = true;
					this.nud_numofday.Enabled = false;
					this.tb_detailidx.Enabled = false;
					this.dtp_effstart.Enabled = true;
					this.dtp_effend.Enabled = true;
					this.nud_calqtyper.Enabled = true;
					this.bt_adddetail.Enabled = true;
					this.bt_deldetail.Enabled = true;
					this.bt_insdetail.Enabled = true;
					this.bt_upddetail.Enabled = true;
				} break;
				case 1:
				{
					this.tb_calendarpre.Enabled = false;
					this.tb_calendar.Enabled = false;
					this.cb_caltype.Enabled = false;
					this.cb_pattern.Enabled = true;
					this.cb_dayofweek.Enabled = false;
					this.nud_numofday.Enabled = false;
					this.tb_detailidx.Enabled = false;
					this.dtp_effstart.Enabled = true;
					this.dtp_effend.Enabled = true;
					this.nud_calqtyper.Enabled = true;
					this.bt_adddetail.Enabled = true;
					this.bt_deldetail.Enabled = true;
					this.bt_insdetail.Enabled = true;
					this.bt_upddetail.Enabled = true;
				} break;
				case 98:
				{
					this.tb_calendarpre.Enabled = false;
					this.tb_calendar.Enabled = false;
					this.cb_caltype.Enabled = true;
					this.cb_pattern.Enabled = true;
					this.cb_dayofweek.Enabled = false;
					this.nud_numofday.Enabled = false;
					this.tb_detailidx.Enabled = false;
					this.dtp_effstart.Enabled = true;
					this.dtp_effend.Enabled = true;
					this.nud_calqtyper.Enabled = true;
					this.bt_adddetail.Enabled = true;
					this.bt_deldetail.Enabled = true;
					this.bt_insdetail.Enabled = true;
					this.bt_upddetail.Enabled = true;
				} break;
				case 99:
				{
					this.tb_calendarpre.Enabled = false;
					this.tb_calendar.Enabled = false;
					this.cb_caltype.Enabled = false;
					this.cb_pattern.Enabled = true;
					this.cb_dayofweek.Enabled = false;
					this.nud_numofday.Enabled = false;
					this.tb_detailidx.Enabled = true;
					this.dtp_effstart.Enabled = true;
					this.dtp_effend.Enabled = true;
					this.nud_calqtyper.Enabled = true;
					this.bt_adddetail.Enabled = true;
					this.bt_deldetail.Enabled = true;
					this.bt_insdetail.Enabled = true;
					this.bt_upddetail.Enabled = true;
				} break;
			}
		}
		#endregion

		#region setattr
		public override void SetAttr(FLOObj O)
		{
			FLOCal o = (FLOCal)O;

			//			this.tb_calendarpre.Text = o.Cal_calendarpre;
			this.tb_calendar.Text = o.Cal_calendar;
			this.cb_caltype.SelectedItem = o.Cal_caltype;
			this.tb_calendarpre_update();
			this.cb_pattern.SelectedItem = o.Cal_pattern;
			this.cb_dayofweek.SelectedItem = o.Cal_dayofweek;
			this.nud_numofday.Value = (decimal)o.Cal_numofday;

			foreach(FLOCal.Cal_Detail detail in o.Cal_details)
			{
				this.lv_details.Items.AddRange( new ListViewItem[] { new ListViewItem(new string[] { detail.cal_detaildx.ToString(), Convert.ToDateTime(detail.cal_effstart).ToShortDateString(), Convert.ToDateTime(detail.cal_effend).ToShortDateString(), detail.cal_qtyper.ToString() }, -1) });
			}

			if(this.lv_details.Items.Count < 1)
				lv_details.Items.AddRange(new ListViewItem[] {new ListViewItem(new string[] { (lv_details.Items.Count+1).ToString(),DateTime.Now.ToShortDateString(),DateTime.Now.ToShortDateString(),"1000"},-1)});
		}

		private bool init = true;

		public override void SetAttrMulti(FLOObj O)
		{
			FLOCal o = (FLOCal)O;

			if(init)
			{
				this.tb_calendarpre.Text = o.Cal_calendarpre;
				this.tb_calendar.Text = o.Cal_calendar;
				this.cb_caltype.SelectedItem = o.Cal_caltype;
				this.cb_pattern.SelectedItem = o.Cal_pattern;
				this.cb_dayofweek.SelectedItem = o.Cal_dayofweek;
				this.nud_numofday.Value = (decimal)o.Cal_numofday;

				foreach(FLOCal.Cal_Detail detail in o.Cal_details)
				{
					this.lv_details.Items.AddRange( new ListViewItem[] { new ListViewItem(new string[] { detail.cal_detaildx.ToString(), Convert.ToDateTime(detail.cal_effstart).ToShortDateString(), Convert.ToDateTime(detail.cal_effend).ToShortDateString(), detail.cal_qtyper.ToString() }, -1) });
				}

				if(this.lv_details.Items.Count < 1)
					lv_details.Items.AddRange(new ListViewItem[] {new ListViewItem(new string[] { (lv_details.Items.Count+1).ToString(),DateTime.Now.ToShortDateString(),DateTime.Now.ToShortDateString(),"1000"},-1)});			
			}

			init = false;

			if(this.tb_calendarpre.Text != o.Cal_calendarpre)
				this.tb_calendarpre.Text = FLOObj.SCPRE;
			if(this.tb_calendar.Text != o.Cal_calendar)
				this.tb_calendar.Text = "";
			if(this.cb_caltype.SelectedItem.ToString() != o.Cal_caltype.ToString())
				this.cb_caltype.SelectedItem = FLOObj.CALTYPE.REP_QTY;
			if(this.cb_pattern.SelectedItem.ToString() != o.Cal_pattern.ToString())
				this.cb_pattern.SelectedItem = FLOObj.CPTTYPE.EVERYDAY;
			if(this.cb_dayofweek.SelectedItem.ToString() != o.Cal_dayofweek.ToString())
				this.cb_dayofweek.SelectedItem = FLOObj.CDWTYPE.Mo;
			if(this.nud_numofday.Value != o.Cal_numofday)
				this.nud_numofday.Value = 0;

			for(int i = 0; i < this.lv_details.Items.Count; i++)
			{
				FLOCal.Cal_Detail sdetail;

				sdetail.cal_detaildx = Convert.ToInt32(this.lv_details.Items[i].SubItems[0].Text);
				sdetail.cal_effstart = this.lv_details.Items[i].SubItems[1].Text;
				sdetail.cal_effend = this.lv_details.Items[i].SubItems[2].Text;
				sdetail.cal_qtyper = Convert.ToInt32(this.lv_details.Items[i].SubItems[3].Text);

				if(!((FLOCal.Cal_Detail)o.Cal_details[i]).Equals(sdetail))
				{
					lv_details.Items.Clear();
					lv_details.Items.AddRange(new ListViewItem[] {new ListViewItem(new string[] { (lv_details.Items.Count+1).ToString(),DateTime.Now.ToShortDateString(),DateTime.Now.ToShortDateString(),"1000"},-1)});			
					break;
				}
			}	
		}
		#endregion

		#region getattr
		public override void GetAttr(FLOObj O)
		{			
			FLOCal o = (FLOCal)O;

			o.Cal_calendarpre = this.tb_calendarpre.Text;
			o.Cal_calendar = this.tb_calendar.Text;
			o.Cal_caltype = (FLOObj.CALTYPE)this.cb_caltype.SelectedItem;
			o.Cal_pattern = (FLOObj.CPTTYPE)this.cb_pattern.SelectedItem;
			o.Cal_dayofweek = (FLOObj.CDWTYPE)this.cb_dayofweek.SelectedItem;
			o.Cal_numofday = (int)this.nud_numofday.Value;

			o.Cal_details.Clear();

			for(int i = 0; i < this.lv_details.Items.Count; i++)
			{
				FLOCal.Cal_Detail detail;

				detail.cal_detaildx = Convert.ToInt32(this.lv_details.Items[i].SubItems[0].Text);
				detail.cal_effstart = this.lv_details.Items[i].SubItems[1].Text;
				detail.cal_effend = this.lv_details.Items[i].SubItems[2].Text;
				detail.cal_qtyper = Convert.ToInt32(this.lv_details.Items[i].SubItems[3].Text);
				
				o.Cal_details.Add(detail);				
			}
		}

		public override void GetAttrMulti(FLOObj O)
		{			
			FLOCal o = (FLOCal)O;

			o.Cal_calendarpre = this.tb_calendarpre.Text;
			
			if(this.cb_caltype.Enabled == true)
				o.Cal_caltype = (FLOObj.CALTYPE)this.cb_caltype.SelectedItem;
			
			o.Cal_pattern = (FLOObj.CPTTYPE)this.cb_pattern.SelectedItem;
			o.Cal_dayofweek = (FLOObj.CDWTYPE)this.cb_dayofweek.SelectedItem;
			o.Cal_numofday = (int)this.nud_numofday.Value;

			o.Cal_details.Clear();

			for(int i = 0; i < this.lv_details.Items.Count; i++)
			{
				FLOCal.Cal_Detail detail;

				detail.cal_detaildx = Convert.ToInt32(this.lv_details.Items[i].SubItems[0].Text);
				detail.cal_effstart = this.lv_details.Items[i].SubItems[1].Text;
				detail.cal_effend = this.lv_details.Items[i].SubItems[2].Text;
				detail.cal_qtyper = Convert.ToInt32(this.lv_details.Items[i].SubItems[3].Text);
				
				o.Cal_details.Add(detail);				
			}
		}
		#endregion
		
		#region getobj/disname
		public override string GetObjName()
		{
			return this.tb_calendarpre.Text + this.tb_calendar.Text;
		}
	
		public override string GetObjName(FLOObj o)
		{
			return this.tb_calendarpre.Text + o.Cal_calendar;
		}
	
		public override string GetDisName()
		{
			return this.tb_calendarpre.Text + this.lv_details.Items[0].SubItems[3].Text + "/" + (FLOObj.CPTTYPE.EVERYDAY.Equals(this.cb_pattern.SelectedItem)?"Day":(FLOObj.CPTTYPE.DAYS_OF_WEEK.Equals(this.cb_pattern.SelectedItem)?this.cb_dayofweek.SelectedItem.ToString():this.nud_numofday.ToString()));
		}
		
		public override string GetDisName(FLOObj o)
		{
			return this.tb_calendarpre.Text + this.lv_details.Items[0].SubItems[3].Text + "/" + (FLOObj.CPTTYPE.EVERYDAY.Equals(this.cb_pattern.SelectedItem)?"Day":(FLOObj.CPTTYPE.DAYS_OF_WEEK.Equals(this.cb_pattern.SelectedItem)?this.cb_dayofweek.SelectedItem.ToString():this.nud_numofday.ToString()));
		}
		#endregion

		#region checkformlogic
		public override bool CheckFormLogic()
		{
			if(this.tb_calendar.Text.Length < 1)
				return true;

			return false;
		}
		#endregion

		#region button click
		public override void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		public override void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region detail control button
		private void bt_adddetail_Click(object sender, System.EventArgs e)
		{
			lv_details.Items.AddRange(new ListViewItem[] {new ListViewItem(new string[] { (lv_details.Items.Count+1).ToString(),this.dtp_effstart.Value.ToShortDateString(),this.dtp_effend.Value.ToShortDateString(),this.nud_calqtyper.Value.ToString()},-1)});					
		}

		private void bt_deldetail_Click(object sender, System.EventArgs e)
		{
			if(lv_details.Items.Count < 1)
				return;

			if(lv_details.FocusedItem == null)
				return;

			foreach(ListViewItem items in lv_details.Items)
			{
				if(items.Selected && lv_details.Items.Count > 1)
					items.Remove();
			}

			for( int i = 0; i < lv_details.Items.Count; i++)
			{
				lv_details.Items[i].Text = Convert.ToString(i+1);
			}		
		}

		private void bt_upddetail_Click(object sender, System.EventArgs e)
		{
			if(lv_details.FocusedItem == null)
				return;

			lv_details.Items.Insert(lv_details.FocusedItem.Index,new ListViewItem(new string[] { (lv_details.FocusedItem.Index+1).ToString(),this.dtp_effstart.Value.ToShortDateString(),this.dtp_effend.Value.ToShortDateString(),this.nud_calqtyper.Value.ToString()},-1));
			lv_details.Items.RemoveAt(lv_details.FocusedItem.Index);		
		}

		private void bt_insdetail_Click(object sender, System.EventArgs e)
		{
			if(lv_details.FocusedItem == null)
				return;

			lv_details.Items.Insert(lv_details.FocusedItem.Index,new ListViewItem(new string[] { (lv_details.FocusedItem.Index+1).ToString(),this.dtp_effstart.Value.ToShortDateString(),this.dtp_effend.Value.ToShortDateString(),this.nud_calqtyper.Value.ToString()},-1));

			for( int i = 0; i < lv_details.Items.Count; i++)
			{
				lv_details.Items[i].Text = Convert.ToString(i+1);
			}		
		}

		private void lv_details_ItemActivate(object sender, System.EventArgs e)
		{
			ListViewItem item = lv_details.FocusedItem;
			this.tb_detailidx.Text = item.SubItems[0].Text;
			this.dtp_effstart.Value = Convert.ToDateTime(item.SubItems[1].Text);		
			this.dtp_effend.Value = Convert.ToDateTime(item.SubItems[2].Text);		
			this.nud_calqtyper.Value = (decimal)Convert.ToDouble(item.SubItems[3].Text);
		}
		#endregion

		#region combobox pattern selected changed
		private void cb_pattern_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.cb_pattern.SelectedItem.ToString() == FLOObj.CPTTYPE.EVERYDAY.ToString())
			{
				this.cb_dayofweek.Enabled = false;
				this.nud_numofday.Enabled = false;
			}
			else if(this.cb_pattern.SelectedItem.ToString() == FLOObj.CPTTYPE.DAYS_OF_WEEK.ToString())
			{
				this.cb_dayofweek.Enabled = true;
				this.nud_numofday.Enabled = false;
			}
			else
			{
				this.cb_dayofweek.Enabled = false;
				this.nud_numofday.Enabled = true;
			}
		}
		#endregion

		#region combobox caltype selected changed
		private void cb_caltype_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			tb_calendarpre_update();
		}
		#endregion

		#region tb_calendarpre_update
		private void tb_calendarpre_update()
		{			
			if(FLOObj.CALTYPE.AVAILABLE_CAPACITY.Equals(this.cb_caltype.SelectedItem))
				this.tb_calendarpre.Text = FLOObj.RCPRE.ToString();
			else if(FLOObj.CALTYPE.EFFICIENCY.Equals(this.cb_caltype.SelectedItem))
				this.tb_calendarpre.Text = FLOObj.ECPRE.ToString();
			else if(FLOObj.CALTYPE.MAX_ON_HAND.Equals(this.cb_caltype.SelectedItem))
				this.tb_calendarpre.Text = FLOObj.XCPRE.ToString();
			else if(FLOObj.CALTYPE.MIN_ON_HAND.Equals(this.cb_caltype.SelectedItem))
				this.tb_calendarpre.Text = FLOObj.NCPRE.ToString();
			else if(FLOObj.CALTYPE.REP_QTY.Equals(this.cb_caltype.SelectedItem))
				this.tb_calendarpre.Text = FLOObj.SCPRE.ToString();
			else if(FLOObj.CALTYPE.YIELD.Equals(this.cb_caltype.SelectedItem))
				this.tb_calendarpre.Text = FLOObj.YCPRE.ToString();
		}
		#endregion
	}
}

