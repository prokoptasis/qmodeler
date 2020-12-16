using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Q_Modeler
{
	public class FormFLODmd : Q_Modeler.FormFLO
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tb_sorderid;
		private System.Windows.Forms.TextBox tb_item;
		private System.Windows.Forms.TextBox tb_site;
		private System.Windows.Forms.NumericUpDown nud_orderqty;
		private System.Windows.Forms.DateTimePicker dtp_ordereddate;
		private System.Windows.Forms.NumericUpDown nud_orderprirority;
		private System.Windows.Forms.NumericUpDown nud_latenesstolerance;
		private System.ComponentModel.IContainer components = null;

		#region initializer
		public FormFLODmd()
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
			this.tb_sorderid = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_item = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_site = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.nud_orderqty = new System.Windows.Forms.NumericUpDown();
			this.dtp_ordereddate = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.nud_orderprirority = new System.Windows.Forms.NumericUpDown();
			this.nud_latenesstolerance = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nud_orderqty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_orderprirority)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_latenesstolerance)).BeginInit();
			this.SuspendLayout();
			// 
			// tb_sorderid
			// 
			this.tb_sorderid.Enabled = false;
			this.tb_sorderid.Location = new System.Drawing.Point(88, 24);
			this.tb_sorderid.Name = "tb_sorderid";
			this.tb_sorderid.Size = new System.Drawing.Size(184, 21);
			this.tb_sorderid.TabIndex = 0;
			this.tb_sorderid.Text = "";
			this.tb_sorderid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "OrderID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_item
			// 
			this.tb_item.Enabled = false;
			this.tb_item.Location = new System.Drawing.Point(88, 52);
			this.tb_item.Name = "tb_item";
			this.tb_item.Size = new System.Drawing.Size(184, 21);
			this.tb_item.TabIndex = 0;
			this.tb_item.Text = "";
			this.tb_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Item";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_site
			// 
			this.tb_site.Enabled = false;
			this.tb_site.Location = new System.Drawing.Point(88, 80);
			this.tb_site.Name = "tb_site";
			this.tb_site.Size = new System.Drawing.Size(184, 21);
			this.tb_site.TabIndex = 0;
			this.tb_site.Text = "";
			this.tb_site.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "Site";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 21);
			this.label4.TabIndex = 1;
			this.label4.Text = "Oder.Qty";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 21);
			this.label5.TabIndex = 1;
			this.label5.Text = "DueDate";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_orderqty
			// 
			this.nud_orderqty.Location = new System.Drawing.Point(88, 108);
			this.nud_orderqty.Maximum = new System.Decimal(new int[] {
																		 1000000000,
																		 0,
																		 0,
																		 0});
			this.nud_orderqty.Name = "nud_orderqty";
			this.nud_orderqty.Size = new System.Drawing.Size(184, 21);
			this.nud_orderqty.TabIndex = 101;
			this.nud_orderqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dtp_ordereddate
			// 
			this.dtp_ordereddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ordereddate.Location = new System.Drawing.Point(88, 136);
			this.dtp_ordereddate.Name = "dtp_ordereddate";
			this.dtp_ordereddate.Size = new System.Drawing.Size(184, 21);
			this.dtp_ordereddate.TabIndex = 102;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 192);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 21);
			this.label7.TabIndex = 1;
			this.label7.Text = "Lateness";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 21);
			this.label6.TabIndex = 1;
			this.label6.Text = "O.Priority";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_orderprirority
			// 
			this.nud_orderprirority.Location = new System.Drawing.Point(88, 164);
			this.nud_orderprirority.Name = "nud_orderprirority";
			this.nud_orderprirority.Size = new System.Drawing.Size(184, 21);
			this.nud_orderprirority.TabIndex = 101;
			this.nud_orderprirority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_latenesstolerance
			// 
			this.nud_latenesstolerance.Location = new System.Drawing.Point(88, 192);
			this.nud_latenesstolerance.Name = "nud_latenesstolerance";
			this.nud_latenesstolerance.Size = new System.Drawing.Size(184, 21);
			this.nud_latenesstolerance.TabIndex = 101;
			this.nud_latenesstolerance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormFLODmd
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.dtp_ordereddate);
			this.Controls.Add(this.nud_orderqty);
			this.Controls.Add(this.tb_sorderid);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_item);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_site);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.nud_orderprirority);
			this.Controls.Add(this.nud_latenesstolerance);
			this.Name = "FormFLODmd";
			this.Controls.SetChildIndex(this.nud_latenesstolerance, 0);
			this.Controls.SetChildIndex(this.nud_orderprirority, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.tb_site, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.tb_item, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.tb_sorderid, 0);
			this.Controls.SetChildIndex(this.nud_orderqty, 0);
			this.Controls.SetChildIndex(this.dtp_ordereddate, 0);
			((System.ComponentModel.ISupportInitialize)(this.nud_orderqty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_orderprirority)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_latenesstolerance)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region initizlizer
		public FormFLODmd(int locktype)
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
					this.tb_sorderid.Enabled = false;
					this.tb_item.Enabled = false;
					this.tb_site.Enabled = false;
					this.nud_orderqty.Enabled = true;
					this.nud_orderprirority.Enabled = true;
					this.nud_latenesstolerance.Enabled = true;
					this.dtp_ordereddate.Enabled = true;
				} break;
				case 1:
				{
					this.tb_sorderid.Enabled = false;
					this.tb_item.Enabled = false;
					this.tb_site.Enabled = false;
					this.nud_orderqty.Enabled = false;
					this.nud_orderprirority.Enabled = false;
					this.nud_latenesstolerance.Enabled = false;
					this.dtp_ordereddate.Enabled = false;
				} break;
				case 99:
				{
					this.tb_sorderid.Enabled = false;
					this.tb_item.Enabled = false;
					this.tb_site.Enabled = false;
					this.nud_orderqty.Enabled = true;
					this.nud_orderprirority.Enabled = true;
					this.nud_latenesstolerance.Enabled = true;
					this.dtp_ordereddate.Enabled = true;
				} break;
			}
		}
		#endregion

		#region setattr
		public override void SetAttr(FLOObj O)
		{
			FLODmd o = (FLODmd)O;
		
			this.tb_sorderid.Text = o.Dmd_sorderid;
			this.dtp_ordereddate.Value = Convert.ToDateTime(o.Dmd_ordereddate);
			this.nud_orderqty.Value = (decimal)o.Dmd_orderqty;
			this.nud_orderprirority.Value = (decimal)o.Dmd_orderpriority;
			this.nud_latenesstolerance.Value = (decimal)o.Dmd_latenesstolerance;
			
			if(o.Ltlist.Count > 0)
			{
				this.tb_item.Text = o.LTlist(0).Buf_item;
				this.tb_site.Text = o.LTlist(0).Buf_site;
			}
		}

		private bool init = true;

		public override void SetAttrMulti(FLOObj O)
		{
			FLODmd o = (FLODmd)O;

			if(init)
			{
				this.tb_sorderid.Text = o.Dmd_sorderid;
				this.dtp_ordereddate.Value = Convert.ToDateTime(o.Dmd_ordereddate);
				this.nud_orderqty.Value = (decimal)o.Dmd_orderqty;
				this.nud_orderprirority.Value = (decimal)o.Dmd_orderpriority;
				this.nud_latenesstolerance.Value = (decimal)o.Dmd_latenesstolerance;

				if(o.Ltlist.Count > 0)
				{
					this.tb_item.Text = o.LTlist(0).LTlist(0).Buf_item;
					this.tb_site.Text = o.LTlist(0).LTlist(0).Buf_site;
				}
			}

			init = false;

			if(this.tb_sorderid.Text != o.Dmd_sorderid)
				this.tb_sorderid.Text = "";
			if(this.dtp_ordereddate.Value.ToShortDateString() != o.Dmd_ordereddate)
				this.dtp_ordereddate.Value = DateTime.Now;
			if(this.nud_orderqty.Value != (decimal)o.Dmd_orderqty)
				this.nud_orderqty.Value = 0;
			if(this.nud_orderprirority.Value != (decimal)o.Dmd_orderpriority)
				this.nud_orderprirority.Value = 1;
			if(this.nud_latenesstolerance.Value != (decimal)o.Dmd_latenesstolerance)
				this.nud_latenesstolerance.Value = 0;

			if(o.Ltlist.Count > 0)
			{
				if(this.tb_item.Text != o.LTlist(0).LTlist(0).Buf_item)
					tb_item.Text = "";
				if(this.tb_site.Text != o.LTlist(0).LTlist(0).Buf_site)
					tb_site.Text = "";
			}
		}
		#endregion

		#region getattr
		public override void GetAttr(FLOObj O)
		{			
			FLODmd o = (FLODmd)O;

			o.Dmd_sorderid = this.tb_sorderid.Text;
			o.Dmd_orderqty = (int)this.nud_orderqty.Value;
			o.Dmd_orderpriority = (int)this.nud_orderprirority.Value;
			o.Dmd_ordereddate = this.dtp_ordereddate.Value.ToShortDateString();
			o.Dmd_latenesstolerance = (int)this.nud_latenesstolerance.Value;
		}

		public override void GetAttrMulti(FLOObj O)
		{			
			FLODmd o = (FLODmd)O;
			o.Dmd_orderqty = (int)this.nud_orderqty.Value;
			o.Dmd_orderpriority = (int)this.nud_orderprirority.Value;
			o.Dmd_ordereddate = this.dtp_ordereddate.Value.ToShortDateString();
			o.Dmd_latenesstolerance = (int)this.nud_latenesstolerance.Value;
		}
		#endregion
		
		#region getobj/disname
		public override string GetObjName()
		{
			return this.tb_sorderid.Text;
		}

		public override string GetObjName(FLOObj o)
		{
			return o.Dmd_sorderid;
		}
		
		public override string GetDisName()
		{
			return this.tb_sorderid.Text;
		}
		
		public override string GetDisName(FLOObj o)
		{
			return o.Dmd_sorderid;
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

