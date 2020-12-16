using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Q_Modeler
{
	public class FormFLOB2C : Q_Modeler.FormFLO
	{
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tb_calendarpre;
		private System.Windows.Forms.TextBox tb_calendar;
		private System.Windows.Forms.TextBox tb_item;
		private System.Windows.Forms.TextBox tb_site;
		private System.Windows.Forms.NumericUpDown nud_qtyper;
		private System.Windows.Forms.TextBox tb_calpattern;
		private System.Windows.Forms.TextBox tb_caltype;
		private System.ComponentModel.IContainer components = null;

		#region initializer
		public FormFLOB2C()
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
			this.tb_calendarpre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_calendar = new System.Windows.Forms.TextBox();
			this.tb_item = new System.Windows.Forms.TextBox();
			this.tb_site = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.nud_qtyper = new System.Windows.Forms.NumericUpDown();
			this.tb_calpattern = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tb_caltype = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.nud_qtyper)).BeginInit();
			this.SuspendLayout();
			// 
			// tb_calendarpre
			// 
			this.tb_calendarpre.Enabled = false;
			this.tb_calendarpre.Location = new System.Drawing.Point(88, 88);
			this.tb_calendarpre.Name = "tb_calendarpre";
			this.tb_calendarpre.Size = new System.Drawing.Size(32, 21);
			this.tb_calendarpre.TabIndex = 2;
			this.tb_calendarpre.TabStop = false;
			this.tb_calendarpre.Text = "";
			this.tb_calendarpre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "Cal.Name";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Site";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_calendar
			// 
			this.tb_calendar.Enabled = false;
			this.tb_calendar.Location = new System.Drawing.Point(120, 88);
			this.tb_calendar.Name = "tb_calendar";
			this.tb_calendar.Size = new System.Drawing.Size(152, 21);
			this.tb_calendar.TabIndex = 0;
			this.tb_calendar.Text = "";
			this.tb_calendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_item
			// 
			this.tb_item.Enabled = false;
			this.tb_item.Location = new System.Drawing.Point(88, 24);
			this.tb_item.Name = "tb_item";
			this.tb_item.Size = new System.Drawing.Size(184, 21);
			this.tb_item.TabIndex = 0;
			this.tb_item.Text = "";
			this.tb_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_site
			// 
			this.tb_site.Enabled = false;
			this.tb_site.Location = new System.Drawing.Point(88, 56);
			this.tb_site.Name = "tb_site";
			this.tb_site.Size = new System.Drawing.Size(184, 21);
			this.tb_site.TabIndex = 0;
			this.tb_site.Text = "";
			this.tb_site.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Item";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 21);
			this.label4.TabIndex = 1;
			this.label4.Text = "Cal.Attrbt.";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_qtyper
			// 
			this.nud_qtyper.Enabled = false;
			this.nud_qtyper.Location = new System.Drawing.Point(88, 152);
			this.nud_qtyper.Maximum = new System.Decimal(new int[] {
																	   99999999,
																	   0,
																	   0,
																	   0});
			this.nud_qtyper.Name = "nud_qtyper";
			this.nud_qtyper.Size = new System.Drawing.Size(184, 21);
			this.nud_qtyper.TabIndex = 3;
			this.nud_qtyper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_calpattern
			// 
			this.tb_calpattern.Enabled = false;
			this.tb_calpattern.Location = new System.Drawing.Point(88, 184);
			this.tb_calpattern.Name = "tb_calpattern";
			this.tb_calpattern.Size = new System.Drawing.Size(184, 21);
			this.tb_calpattern.TabIndex = 0;
			this.tb_calpattern.Text = "";
			this.tb_calpattern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 153);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 21);
			this.label5.TabIndex = 1;
			this.label5.Text = "Qtyper";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 184);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 21);
			this.label6.TabIndex = 1;
			this.label6.Text = "Cal.Pattn.";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_caltype
			// 
			this.tb_caltype.Enabled = false;
			this.tb_caltype.Location = new System.Drawing.Point(88, 120);
			this.tb_caltype.Name = "tb_caltype";
			this.tb_caltype.Size = new System.Drawing.Size(184, 21);
			this.tb_caltype.TabIndex = 0;
			this.tb_caltype.Text = "";
			this.tb_caltype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormFLOB2C
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.tb_calendarpre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_calendar);
			this.Controls.Add(this.tb_item);
			this.Controls.Add(this.tb_site);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nud_qtyper);
			this.Controls.Add(this.tb_calpattern);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tb_caltype);
			this.Name = "FormFLOB2C";
			this.Controls.SetChildIndex(this.tb_caltype, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.tb_calpattern, 0);
			this.Controls.SetChildIndex(this.nud_qtyper, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.tb_site, 0);
			this.Controls.SetChildIndex(this.tb_item, 0);
			this.Controls.SetChildIndex(this.tb_calendar, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.tb_calendarpre, 0);
			((System.ComponentModel.ISupportInitialize)(this.nud_qtyper)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region initilizer
		public FormFLOB2C(int locktype)
		{
			InitializeComponent();
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
					this.tb_calendar.Enabled = false;
					this.tb_item.Enabled = false;
					this.tb_site.Enabled = false;
					this.nud_qtyper.Enabled = false;
					this.tb_calpattern.Enabled = false;
					this.tb_caltype.Enabled = false;
				} break;
				case 1:
				{
					this.tb_calendarpre.Enabled = false;
					this.tb_calendar.Enabled = false;
					this.tb_item.Enabled = false;
					this.tb_site.Enabled = false;
					this.nud_qtyper.Enabled = false;
					this.tb_calpattern.Enabled = false;
					this.tb_caltype.Enabled = false;
				} break;
				case 99:
				{
					this.tb_calendarpre.Enabled = false;
					this.tb_calendar.Enabled = false;
					this.tb_item.Enabled = false;
					this.tb_site.Enabled = false;
					this.nud_qtyper.Enabled = false;
					this.tb_calpattern.Enabled = false;
					this.tb_caltype.Enabled = false;
				} break;
			}
		}
		#endregion

		#region setattribute
		public override void SetAttr(FLOObj O)
		{
			FLOB2C o = (FLOB2C)O;
			this.tb_calendarpre.Text = o.DNlist(0).Cal_calendarpre;
			this.tb_calendar.Text = o.DNlist(0).Cal_calendar;
			this.tb_calpattern.Text = o.DNlist(0).Cal_pattern.ToString();
			this.nud_qtyper.Value = (decimal)((FLOCal.Cal_Detail)o.DNlist(0).Cal_details[0]).cal_qtyper;

			this.tb_item.Text = o.UPlist(0).Buf_item;
			this.tb_site.Text = o.UPlist(0).Buf_site;

			this.tb_caltype.Text = o.DNlist(0).Cal_caltype.ToString();
		}
		#endregion

		#region getattribute
		public override void GetAttr(FLOObj O)
		{			
			FLOB2C o = (FLOB2C)O;
			o.DNlist(0).Cal_calendarpre = this.tb_calendarpre.Text;
			o.DNlist(0).Cal_calendar = this.tb_calendar.Text;

			if(this.tb_calpattern.Text == FLOObj.CPTTYPE.EVERYDAY.ToString())
				o.DNlist(0).Cal_pattern = FLOObj.CPTTYPE.EVERYDAY;
			if(this.tb_calpattern.Text == FLOObj.CPTTYPE.EVERY_N_DAYS.ToString())
				o.DNlist(0).Cal_pattern = FLOObj.CPTTYPE.EVERY_N_DAYS;
			if(this.tb_calpattern.Text == FLOObj.CPTTYPE.DAYS_OF_WEEK.ToString())
				o.DNlist(0).Cal_pattern = FLOObj.CPTTYPE.DAYS_OF_WEEK;
			if(this.tb_calpattern.Text == FLOObj.CPTTYPE.DAY_OF_YEAR.ToString())
				o.DNlist(0).Cal_pattern = FLOObj.CPTTYPE.DAY_OF_YEAR;
			if(this.tb_calpattern.Text == FLOObj.CPTTYPE.DAY_OF_MONTH.ToString())
				o.DNlist(0).Cal_pattern = FLOObj.CPTTYPE.DAY_OF_MONTH;
			else 
				o.DNlist(0).Cal_pattern = FLOObj.CPTTYPE.NULL;

			
			o.UPlist(0).Buf_item = this.tb_item.Text;
			o.UPlist(0).Buf_site = this.tb_site.Text;
			
			if(this.tb_caltype.Text == FLOObj.CALTYPE.REP_QTY.ToString())
                o.DNlist(0).Cal_caltype = FLOObj.CALTYPE.REP_QTY;
			if(this.tb_caltype.Text == FLOObj.CALTYPE.MAX_ON_HAND.ToString())
				o.DNlist(0).Cal_caltype = FLOObj.CALTYPE.MAX_ON_HAND;
			if(this.tb_caltype.Text == FLOObj.CALTYPE.MIN_ON_HAND.ToString())
				o.DNlist(0).Cal_caltype = FLOObj.CALTYPE.MIN_ON_HAND;
		}
		#endregion
	
		#region checkformlogic
		public override bool CheckFormLogic()
		{
			return false;
		}
		#endregion
	
		#region getobj/disname
		public override string GetObjName()
		{
			return this.tb_item.Text + "@" + this.tb_site.Text + ">>>" + this.tb_calendarpre.Text + this.tb_calendar.Text;
		}
		
		public override string GetDisName()
		{
			return this.nud_qtyper.Value.ToString();
		}
		#endregion
	}
}

