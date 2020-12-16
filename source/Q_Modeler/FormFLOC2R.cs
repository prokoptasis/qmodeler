using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Q_Modeler
{
	public class FormFLOC2R : Q_Modeler.FormFLO
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_resource;
		private System.Windows.Forms.TextBox tb_resourcepre;
		private System.Windows.Forms.TextBox tb_resourcesite;
		private System.Windows.Forms.TextBox tb_workcenter;
		private System.Windows.Forms.TextBox tb_calendar;
		private System.Windows.Forms.TextBox tb_calendarpre;
		private System.Windows.Forms.TextBox tb_calendartype;
		private System.ComponentModel.IContainer components = null;

		#region initializer
		public FormFLOC2R()
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_resource = new System.Windows.Forms.TextBox();
			this.tb_resourcepre = new System.Windows.Forms.TextBox();
			this.tb_resourcesite = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_workcenter = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_calendar = new System.Windows.Forms.TextBox();
			this.tb_calendarpre = new System.Windows.Forms.TextBox();
			this.tb_calendartype = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Resc.Site";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Resource";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_resource
			// 
			this.tb_resource.Enabled = false;
			this.tb_resource.Location = new System.Drawing.Point(120, 32);
			this.tb_resource.Name = "tb_resource";
			this.tb_resource.Size = new System.Drawing.Size(152, 21);
			this.tb_resource.TabIndex = 0;
			this.tb_resource.Text = "";
			this.tb_resource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_resourcepre
			// 
			this.tb_resourcepre.Enabled = false;
			this.tb_resourcepre.Location = new System.Drawing.Point(88, 32);
			this.tb_resourcepre.Name = "tb_resourcepre";
			this.tb_resourcepre.Size = new System.Drawing.Size(32, 21);
			this.tb_resourcepre.TabIndex = 1;
			this.tb_resourcepre.TabStop = false;
			this.tb_resourcepre.Text = "";
			this.tb_resourcepre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_resourcesite
			// 
			this.tb_resourcesite.Enabled = false;
			this.tb_resourcesite.Location = new System.Drawing.Point(88, 64);
			this.tb_resourcesite.Name = "tb_resourcesite";
			this.tb_resourcesite.Size = new System.Drawing.Size(184, 21);
			this.tb_resourcesite.TabIndex = 1;
			this.tb_resourcesite.Text = "";
			this.tb_resourcesite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "Workcntr.";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_workcenter
			// 
			this.tb_workcenter.Enabled = false;
			this.tb_workcenter.Location = new System.Drawing.Point(88, 96);
			this.tb_workcenter.Name = "tb_workcenter";
			this.tb_workcenter.Size = new System.Drawing.Size(184, 21);
			this.tb_workcenter.TabIndex = 1;
			this.tb_workcenter.Text = "";
			this.tb_workcenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 21);
			this.label4.TabIndex = 1;
			this.label4.Text = "Cal.Name";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_calendar
			// 
			this.tb_calendar.Enabled = false;
			this.tb_calendar.Location = new System.Drawing.Point(120, 128);
			this.tb_calendar.Name = "tb_calendar";
			this.tb_calendar.Size = new System.Drawing.Size(152, 21);
			this.tb_calendar.TabIndex = 0;
			this.tb_calendar.Text = "";
			this.tb_calendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_calendarpre
			// 
			this.tb_calendarpre.Enabled = false;
			this.tb_calendarpre.Location = new System.Drawing.Point(88, 128);
			this.tb_calendarpre.Name = "tb_calendarpre";
			this.tb_calendarpre.Size = new System.Drawing.Size(32, 21);
			this.tb_calendarpre.TabIndex = 2;
			this.tb_calendarpre.TabStop = false;
			this.tb_calendarpre.Text = "";
			this.tb_calendarpre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_calendartype
			// 
			this.tb_calendartype.Enabled = false;
			this.tb_calendartype.Location = new System.Drawing.Point(88, 160);
			this.tb_calendartype.Name = "tb_calendartype";
			this.tb_calendartype.Size = new System.Drawing.Size(184, 21);
			this.tb_calendartype.TabIndex = 36;
			this.tb_calendartype.Text = "";
			this.tb_calendartype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label5.Location = new System.Drawing.Point(24, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 21);
			this.label5.TabIndex = 38;
			this.label5.Text = "Cal.Type";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormFLOC2R
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_resource);
			this.Controls.Add(this.tb_resourcepre);
			this.Controls.Add(this.tb_resourcesite);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_workcenter);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tb_calendar);
			this.Controls.Add(this.tb_calendarpre);
			this.Controls.Add(this.tb_calendartype);
			this.Controls.Add(this.label5);
			this.Name = "FormFLOC2R";
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.tb_calendartype, 0);
			this.Controls.SetChildIndex(this.tb_calendarpre, 0);
			this.Controls.SetChildIndex(this.tb_calendar, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.tb_workcenter, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.tb_resourcesite, 0);
			this.Controls.SetChildIndex(this.tb_resourcepre, 0);
			this.Controls.SetChildIndex(this.tb_resource, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.ResumeLayout(false);

		}
		#endregion

		#region local variables
		private int qtyper;
		#endregion

		#region initizlizer
		public FormFLOC2R(int locktype)
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
					this.tb_calendartype.Enabled = false;
					this.tb_resource.Enabled = false;
					this.tb_resourcepre.Enabled = false;
					this.tb_resourcesite.Enabled = false;
					this.tb_workcenter.Enabled = false;			
				} break;
				case 1:
				{
					this.tb_calendarpre.Enabled = false;
					this.tb_calendar.Enabled = false;
					this.tb_calendartype.Enabled = false;
					this.tb_resource.Enabled = false;
					this.tb_resourcepre.Enabled = false;
					this.tb_resourcesite.Enabled = false;
					this.tb_workcenter.Enabled = false;			
				} break;
				case 99:
				{
					this.tb_calendarpre.Enabled = false;
					this.tb_calendar.Enabled = false;
					this.tb_calendartype.Enabled = false;
					this.tb_resource.Enabled = false;
					this.tb_resourcepre.Enabled = false;
					this.tb_resourcesite.Enabled = false;
					this.tb_workcenter.Enabled = false;			
				} break;
			}
		}
		#endregion

		#region setattr
		public override void SetAttr(FLOObj O)
		{
			FLOC2R o = (FLOC2R)O;
			
			this.tb_calendarpre.Text = o.UPlist(0).Cal_calendarpre;
			this.tb_calendar.Text = o.UPlist(0).Cal_calendar;
			this.tb_calendartype.Text = o.UPlist(0).Cal_caltype.ToString();
			this.tb_resource.Text = o.DNlist(0).Res_resource;
			this.tb_resourcepre.Text = o.DNlist(0).Res_resourcepre;
			this.tb_resourcesite.Text = o.DNlist(0).Res_resourcesite;
			this.tb_workcenter.Text = FLOObj.WORKCENTER;	

			this.qtyper = (int)((FLOCal.Cal_Detail)o.UPlist(0).Cal_details[0]).cal_qtyper;
		}
		#endregion

		#region getattr
		public override void GetAttr(FLOObj O)
		{			
		}
		#endregion
		
		#region getobj/disname
		public override string GetObjName()
		{
			return this.tb_calendarpre.Text + this.tb_calendar.Text + ">>>" + this.tb_resourcepre.Text + this.tb_resource.Text + "@" + this.tb_resourcesite.Text;
		}
		
		public override string GetDisName()
		{
			return this.qtyper.ToString();
		}
		#endregion

		#region checkformlogic
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
	}
}

