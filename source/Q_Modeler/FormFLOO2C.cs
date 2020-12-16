using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Q_Modeler
{
	public class FormFLOO2C : Q_Modeler.FormFLO
	{
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tb_operationpre;
		private System.Windows.Forms.TextBox tb_operation;
		private System.Windows.Forms.TextBox tb_operationsite;
		private System.Windows.Forms.TextBox tb_routingpre;
		private System.Windows.Forms.TextBox tb_routing;
		private System.Windows.Forms.NumericUpDown nud_operationseq;
		private System.Windows.Forms.TextBox tb_calendar;
		private System.Windows.Forms.TextBox tb_calendarpre;
		private System.Windows.Forms.ComboBox cb_effresource;
		private System.Windows.Forms.TextBox tb_caltype;
		private System.ComponentModel.IContainer components = null;

		#region initializer
		public FormFLOO2C()
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
			this.label3 = new System.Windows.Forms.Label();
			this.tb_operationpre = new System.Windows.Forms.TextBox();
			this.tb_operation = new System.Windows.Forms.TextBox();
			this.tb_operationsite = new System.Windows.Forms.TextBox();
			this.tb_routingpre = new System.Windows.Forms.TextBox();
			this.tb_routing = new System.Windows.Forms.TextBox();
			this.nud_operationseq = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_calendar = new System.Windows.Forms.TextBox();
			this.tb_calendarpre = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cb_effresource = new System.Windows.Forms.ComboBox();
			this.tb_caltype = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.nud_operationseq)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "Routing";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_operationpre
			// 
			this.tb_operationpre.Enabled = false;
			this.tb_operationpre.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_operationpre.Location = new System.Drawing.Point(104, 24);
			this.tb_operationpre.Name = "tb_operationpre";
			this.tb_operationpre.Size = new System.Drawing.Size(32, 21);
			this.tb_operationpre.TabIndex = 0;
			this.tb_operationpre.TabStop = false;
			this.tb_operationpre.Text = "";
			this.tb_operationpre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_operation
			// 
			this.tb_operation.Enabled = false;
			this.tb_operation.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_operation.Location = new System.Drawing.Point(136, 24);
			this.tb_operation.Name = "tb_operation";
			this.tb_operation.Size = new System.Drawing.Size(136, 21);
			this.tb_operation.TabIndex = 0;
			this.tb_operation.Text = "";
			this.tb_operation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_operationsite
			// 
			this.tb_operationsite.Enabled = false;
			this.tb_operationsite.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_operationsite.Location = new System.Drawing.Point(104, 56);
			this.tb_operationsite.Name = "tb_operationsite";
			this.tb_operationsite.Size = new System.Drawing.Size(128, 21);
			this.tb_operationsite.TabIndex = 0;
			this.tb_operationsite.Text = "";
			this.tb_operationsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_routingpre
			// 
			this.tb_routingpre.Enabled = false;
			this.tb_routingpre.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_routingpre.Location = new System.Drawing.Point(104, 88);
			this.tb_routingpre.Name = "tb_routingpre";
			this.tb_routingpre.Size = new System.Drawing.Size(32, 21);
			this.tb_routingpre.TabIndex = 0;
			this.tb_routingpre.TabStop = false;
			this.tb_routingpre.Text = "";
			this.tb_routingpre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_routing
			// 
			this.tb_routing.Enabled = false;
			this.tb_routing.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_routing.Location = new System.Drawing.Point(136, 88);
			this.tb_routing.Name = "tb_routing";
			this.tb_routing.Size = new System.Drawing.Size(136, 21);
			this.tb_routing.TabIndex = 0;
			this.tb_routing.Text = "";
			this.tb_routing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_operationseq
			// 
			this.nud_operationseq.Enabled = false;
			this.nud_operationseq.Location = new System.Drawing.Point(232, 56);
			this.nud_operationseq.Name = "nud_operationseq";
			this.nud_operationseq.Size = new System.Drawing.Size(40, 21);
			this.nud_operationseq.TabIndex = 0;
			this.nud_operationseq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Operation";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "OperationSite";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 21);
			this.label4.TabIndex = 1;
			this.label4.Text = "Cal.Attrbt.";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 21);
			this.label5.TabIndex = 1;
			this.label5.Text = "Cal.Name";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_calendar
			// 
			this.tb_calendar.Enabled = false;
			this.tb_calendar.Location = new System.Drawing.Point(136, 120);
			this.tb_calendar.Name = "tb_calendar";
			this.tb_calendar.Size = new System.Drawing.Size(136, 21);
			this.tb_calendar.TabIndex = 0;
			this.tb_calendar.Text = "";
			this.tb_calendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_calendarpre
			// 
			this.tb_calendarpre.Enabled = false;
			this.tb_calendarpre.Location = new System.Drawing.Point(104, 120);
			this.tb_calendarpre.Name = "tb_calendarpre";
			this.tb_calendarpre.Size = new System.Drawing.Size(32, 21);
			this.tb_calendarpre.TabIndex = 0;
			this.tb_calendarpre.TabStop = false;
			this.tb_calendarpre.Text = "";
			this.tb_calendarpre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 184);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 21);
			this.label7.TabIndex = 1;
			this.label7.Text = "Resource";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cb_effresource
			// 
			this.cb_effresource.Enabled = false;
			this.cb_effresource.Location = new System.Drawing.Point(104, 184);
			this.cb_effresource.Name = "cb_effresource";
			this.cb_effresource.Size = new System.Drawing.Size(168, 20);
			this.cb_effresource.TabIndex = 1;
			// 
			// tb_caltype
			// 
			this.tb_caltype.Enabled = false;
			this.tb_caltype.Location = new System.Drawing.Point(104, 152);
			this.tb_caltype.Name = "tb_caltype";
			this.tb_caltype.Size = new System.Drawing.Size(168, 21);
			this.tb_caltype.TabIndex = 0;
			this.tb_caltype.Text = "";
			this.tb_caltype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormFLOO2C
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_operationpre);
			this.Controls.Add(this.tb_operation);
			this.Controls.Add(this.tb_operationsite);
			this.Controls.Add(this.tb_routingpre);
			this.Controls.Add(this.tb_routing);
			this.Controls.Add(this.nud_operationseq);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tb_calendar);
			this.Controls.Add(this.tb_calendarpre);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cb_effresource);
			this.Controls.Add(this.tb_caltype);
			this.Name = "FormFLOO2C";
			this.Controls.SetChildIndex(this.tb_caltype, 0);
			this.Controls.SetChildIndex(this.cb_effresource, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.tb_calendarpre, 0);
			this.Controls.SetChildIndex(this.tb_calendar, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.nud_operationseq, 0);
			this.Controls.SetChildIndex(this.tb_routing, 0);
			this.Controls.SetChildIndex(this.tb_routingpre, 0);
			this.Controls.SetChildIndex(this.tb_operationsite, 0);
			this.Controls.SetChildIndex(this.tb_operation, 0);
			this.Controls.SetChildIndex(this.tb_operationpre, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			((System.ComponentModel.ISupportInitialize)(this.nud_operationseq)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region local variables
		private int cal_prodqty;
		#endregion

		#region initizlizer
		public FormFLOO2C(int locktype,ArrayList o2c_effresources)
		{
			InitializeComponent();

			this.cb_effresource.Items.Clear();

			foreach(string str in o2c_effresources)
			{
				if(!this.cb_effresource.Items.Contains(str))
					this.cb_effresource.Items.Add(str);
			}

			if(this.cb_effresource.Items.Count>0)
				this.cb_effresource.SelectedIndex = 0;

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
					this.tb_operationpre.Enabled = false;
					this.tb_operation.Enabled = false;
					this.tb_operationsite.Enabled = false;
					this.nud_operationseq.Enabled = false;
					this.tb_routingpre.Enabled = false;
					this.tb_routing.Enabled = false;
					this.tb_calendarpre.Enabled = false;
					this.tb_calendar.Enabled = false;
					this.tb_caltype.Enabled = false;
					this.cb_effresource.Enabled = false;
				} break;
				case 1:
				{
					this.tb_operationpre.Enabled = false;
					this.tb_operation.Enabled = false;
					this.tb_operationsite.Enabled = false;
					this.nud_operationseq.Enabled = false;
					this.tb_routingpre.Enabled = false;
					this.tb_routing.Enabled = false;
					this.tb_calendarpre.Enabled = false;
					this.tb_calendar.Enabled = false;					
					this.tb_caltype.Enabled = false;
					this.cb_effresource.Enabled = true;

				} break;
				case 99:
				{
					this.tb_operationpre.Enabled = false;
					this.tb_operation.Enabled = false;
					this.tb_operationsite.Enabled = false;
					this.nud_operationseq.Enabled = false;
					this.tb_routingpre.Enabled = false;
					this.tb_routing.Enabled = false;
					this.tb_calendarpre.Enabled = false;
					this.tb_calendar.Enabled = false;					
					this.tb_caltype.Enabled = false;
					this.cb_effresource.Enabled = false;
				} break;
			}
		}
		#endregion

		#region setattr
		public override void SetAttr(FLOObj O)
		{
			FLOO2C o = (FLOO2C)O;
			
			this.tb_operationpre.Text = o.UPlist(0).Ope_operationpre;
			this.tb_operation.Text = o.UPlist(0).Ope_operation;
			this.tb_operationsite.Text = o.UPlist(0).Ope_operationsite;
			this.nud_operationseq.Value = o.UPlist(0).Ope_operationseq;

			this.tb_routingpre.Text = o.UPlist(0).Ope_routingpre;
			this.tb_routing.Text = o.UPlist(0).Ope_routing;

			this.tb_calendarpre.Text = o.DNlist(0).Cal_calendarpre;
			this.tb_calendar.Text = o.DNlist(0).Cal_calendar;

			this.tb_caltype.Text = o.DNlist(0).Cal_caltype.ToString();
			this.cb_effresource.SelectedItem = o.O2C_effresource;

			this.cal_prodqty = (int)((FLOCal.Cal_Detail)o.DNlist(0).Cal_details[0]).cal_qtyper;
		}
		#endregion

		#region getattr
		public override void GetAttr(FLOObj O)
		{
			FLOO2C o = (FLOO2C)O;

			if(this.cb_effresource.SelectedItem != null)
				o.O2C_effresource = this.cb_effresource.SelectedItem.ToString();			
		}
		#endregion
		
		#region getobj/disname
		public override string GetObjName()
		{
			return this.tb_operationpre.Text + this.tb_operation.Text + "@" + this.tb_operationsite.Text + this.nud_operationseq.ToString() +  ">>>" + this.tb_calendarpre.Text + this.tb_calendar.Text; 
		}
		
		public override string GetDisName()
		{
			return this.cal_prodqty.ToString();
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

