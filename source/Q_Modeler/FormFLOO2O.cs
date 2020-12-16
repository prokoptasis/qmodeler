using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Q_Modeler
{
	public class FormFLOO2O : Q_Modeler.FormFLO
	{
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_routingpre;
		private System.Windows.Forms.TextBox tb_routing;
		private System.Windows.Forms.TextBox tb_foperationpre;
		private System.Windows.Forms.TextBox tb_foperation;
		private System.Windows.Forms.TextBox tb_foperationsite;
		private System.Windows.Forms.NumericUpDown nud_foperationseq;
		private System.Windows.Forms.TextBox tb_toperationpre;
		private System.Windows.Forms.TextBox tb_toperation;
		private System.Windows.Forms.TextBox tb_toperationsite;
		private System.Windows.Forms.NumericUpDown nud_toperationseq;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown nud_prodqty;
		private System.ComponentModel.IContainer components = null;

		#region initializer
		public FormFLOO2O()
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
			this.tb_routingpre = new System.Windows.Forms.TextBox();
			this.tb_routing = new System.Windows.Forms.TextBox();
			this.tb_foperationpre = new System.Windows.Forms.TextBox();
			this.tb_foperation = new System.Windows.Forms.TextBox();
			this.tb_foperationsite = new System.Windows.Forms.TextBox();
			this.nud_foperationseq = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_toperationpre = new System.Windows.Forms.TextBox();
			this.tb_toperation = new System.Windows.Forms.TextBox();
			this.tb_toperationsite = new System.Windows.Forms.TextBox();
			this.nud_toperationseq = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.nud_prodqty = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nud_foperationseq)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_toperationseq)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_prodqty)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "Routing";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_routingpre
			// 
			this.tb_routingpre.Enabled = false;
			this.tb_routingpre.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_routingpre.Location = new System.Drawing.Point(104, 24);
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
			this.tb_routing.Location = new System.Drawing.Point(136, 24);
			this.tb_routing.Name = "tb_routing";
			this.tb_routing.Size = new System.Drawing.Size(136, 21);
			this.tb_routing.TabIndex = 2;
			this.tb_routing.Text = "";
			this.tb_routing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_foperationpre
			// 
			this.tb_foperationpre.Enabled = false;
			this.tb_foperationpre.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_foperationpre.Location = new System.Drawing.Point(104, 56);
			this.tb_foperationpre.Name = "tb_foperationpre";
			this.tb_foperationpre.Size = new System.Drawing.Size(32, 21);
			this.tb_foperationpre.TabIndex = 0;
			this.tb_foperationpre.TabStop = false;
			this.tb_foperationpre.Text = "";
			this.tb_foperationpre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_foperation
			// 
			this.tb_foperation.Enabled = false;
			this.tb_foperation.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_foperation.Location = new System.Drawing.Point(136, 56);
			this.tb_foperation.Name = "tb_foperation";
			this.tb_foperation.Size = new System.Drawing.Size(136, 21);
			this.tb_foperation.TabIndex = 0;
			this.tb_foperation.Text = "";
			this.tb_foperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_foperationsite
			// 
			this.tb_foperationsite.Enabled = false;
			this.tb_foperationsite.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_foperationsite.Location = new System.Drawing.Point(104, 88);
			this.tb_foperationsite.Name = "tb_foperationsite";
			this.tb_foperationsite.Size = new System.Drawing.Size(128, 21);
			this.tb_foperationsite.TabIndex = 1;
			this.tb_foperationsite.Text = "";
			this.tb_foperationsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_foperationseq
			// 
			this.nud_foperationseq.Enabled = false;
			this.nud_foperationseq.Location = new System.Drawing.Point(232, 88);
			this.nud_foperationseq.Name = "nud_foperationseq";
			this.nud_foperationseq.Size = new System.Drawing.Size(40, 21);
			this.nud_foperationseq.TabIndex = 3;
			this.nud_foperationseq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "From Ope.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "From Ope.Site";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_toperationpre
			// 
			this.tb_toperationpre.Enabled = false;
			this.tb_toperationpre.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_toperationpre.Location = new System.Drawing.Point(104, 120);
			this.tb_toperationpre.Name = "tb_toperationpre";
			this.tb_toperationpre.Size = new System.Drawing.Size(32, 21);
			this.tb_toperationpre.TabIndex = 0;
			this.tb_toperationpre.TabStop = false;
			this.tb_toperationpre.Text = "";
			this.tb_toperationpre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_toperation
			// 
			this.tb_toperation.Enabled = false;
			this.tb_toperation.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_toperation.Location = new System.Drawing.Point(136, 120);
			this.tb_toperation.Name = "tb_toperation";
			this.tb_toperation.Size = new System.Drawing.Size(136, 21);
			this.tb_toperation.TabIndex = 0;
			this.tb_toperation.Text = "";
			this.tb_toperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_toperationsite
			// 
			this.tb_toperationsite.Enabled = false;
			this.tb_toperationsite.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_toperationsite.Location = new System.Drawing.Point(104, 152);
			this.tb_toperationsite.Name = "tb_toperationsite";
			this.tb_toperationsite.Size = new System.Drawing.Size(128, 21);
			this.tb_toperationsite.TabIndex = 1;
			this.tb_toperationsite.Text = "";
			this.tb_toperationsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_toperationseq
			// 
			this.nud_toperationseq.Enabled = false;
			this.nud_toperationseq.Location = new System.Drawing.Point(232, 152);
			this.nud_toperationseq.Name = "nud_toperationseq";
			this.nud_toperationseq.Size = new System.Drawing.Size(40, 21);
			this.nud_toperationseq.TabIndex = 3;
			this.nud_toperationseq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 21);
			this.label4.TabIndex = 1;
			this.label4.Text = "To Ope.";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 21);
			this.label5.TabIndex = 1;
			this.label5.Text = "To Ope.Site";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 184);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 21);
			this.label6.TabIndex = 1;
			this.label6.Text = "ProdQty";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_prodqty
			// 
			this.nud_prodqty.DecimalPlaces = 2;
			this.nud_prodqty.Enabled = false;
			this.nud_prodqty.Location = new System.Drawing.Point(104, 184);
			this.nud_prodqty.Maximum = new System.Decimal(new int[] {
																		100000000,
																		0,
																		0,
																		0});
			this.nud_prodqty.Name = "nud_prodqty";
			this.nud_prodqty.Size = new System.Drawing.Size(168, 21);
			this.nud_prodqty.TabIndex = 3;
			this.nud_prodqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nud_prodqty.Value = new System.Decimal(new int[] {
																	  1,
																	  0,
																	  0,
																	  0});
			// 
			// FormFLOO2O
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_routingpre);
			this.Controls.Add(this.tb_routing);
			this.Controls.Add(this.tb_foperationpre);
			this.Controls.Add(this.tb_foperation);
			this.Controls.Add(this.tb_foperationsite);
			this.Controls.Add(this.nud_foperationseq);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_toperationpre);
			this.Controls.Add(this.tb_toperation);
			this.Controls.Add(this.tb_toperationsite);
			this.Controls.Add(this.nud_toperationseq);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.nud_prodqty);
			this.Name = "FormFLOO2O";
			this.Controls.SetChildIndex(this.nud_prodqty, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.nud_toperationseq, 0);
			this.Controls.SetChildIndex(this.tb_toperationsite, 0);
			this.Controls.SetChildIndex(this.tb_toperation, 0);
			this.Controls.SetChildIndex(this.tb_toperationpre, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.nud_foperationseq, 0);
			this.Controls.SetChildIndex(this.tb_foperationsite, 0);
			this.Controls.SetChildIndex(this.tb_foperation, 0);
			this.Controls.SetChildIndex(this.tb_foperationpre, 0);
			this.Controls.SetChildIndex(this.tb_routing, 0);
			this.Controls.SetChildIndex(this.tb_routingpre, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			((System.ComponentModel.ISupportInitialize)(this.nud_foperationseq)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_toperationseq)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_prodqty)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region local variables
		#endregion

		#region initizlizer
		public FormFLOO2O(int locktype)
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
					this.tb_routingpre.Enabled = false;
					this.tb_routing.Enabled = false;
					this.tb_foperationpre.Enabled = false;
					this.tb_foperation.Enabled = false;
					this.tb_foperationsite.Enabled = false;
					this.nud_foperationseq.Enabled = false;
					this.tb_toperationpre.Enabled = false;
					this.tb_toperation.Enabled = false;
					this.tb_toperationsite.Enabled = false;
					this.nud_toperationseq.Enabled = false;
					this.nud_prodqty.Enabled = true;

				} break;
				case 1:
				{
					this.tb_routingpre.Enabled = false;
					this.tb_routing.Enabled = false;
					this.tb_foperationpre.Enabled = false;
					this.tb_foperation.Enabled = false;
					this.tb_foperationsite.Enabled = false;
					this.nud_foperationseq.Enabled = false;
					this.tb_toperationpre.Enabled = false;
					this.tb_toperation.Enabled = false;
					this.tb_toperationsite.Enabled = false;
					this.nud_toperationseq.Enabled = false;
					this.nud_prodqty.Enabled = true;
				} break;
				case 99:
				{
					this.tb_routingpre.Enabled = false;
					this.tb_routing.Enabled = false;
					this.tb_foperationpre.Enabled = false;
					this.tb_foperation.Enabled = false;
					this.tb_foperationsite.Enabled = false;
					this.nud_foperationseq.Enabled = false;
					this.tb_toperationpre.Enabled = false;
					this.tb_toperation.Enabled = false;
					this.tb_toperationsite.Enabled = false;
					this.nud_toperationseq.Enabled = false;
					this.nud_prodqty.Enabled = true;
				} break;
			}
		}
		#endregion

		#region setattr
		public override void SetAttr(FLOObj O)
		{
			FLOO2O o = (FLOO2O)O;
			
			this.tb_routingpre.Text = o.LTlist(0).Ope_routingpre;
			this.tb_routing.Text = o.LTlist(0).Ope_routing;
			this.tb_foperationpre.Text = o.LTlist(0).Ope_operationpre;
			this.tb_foperation.Text = o.LTlist(0).Ope_operation;
			this.tb_foperationsite.Text = o.LTlist(0).Ope_operationsite;
			this.nud_foperationseq.Value = (decimal)o.LTlist(0).Ope_operationseq;
			this.tb_toperationpre.Text = o.RTlist(0).Ope_operationpre;
			this.tb_toperation.Text = o.RTlist(0).Ope_operation;
			this.tb_toperationsite.Text = o.RTlist(0).Ope_operationsite;
			this.nud_toperationseq.Value = (decimal)o.RTlist(0).Ope_operationseq;
			this.nud_prodqty.Value = (decimal)o.O2O_prodqty;
		}
		#endregion

		#region getattr
		public override void GetAttr(FLOObj O)
		{
			FLOO2O o = (FLOO2O)O;
			
			o.O2O_prodqty = (int)this.nud_prodqty.Value;
		}
		#endregion
		
		#region getobj/disname
		public override string GetObjName()
		{
			return this.tb_foperationpre.Text + this.tb_foperation + "@" + this.tb_foperationsite + "_" + this.nud_foperationseq.ToString() + ">>>" + this.tb_toperationpre.Text + this.tb_toperation + "@" + this.tb_toperationsite + "_" + this.nud_toperationseq.ToString();
		}
		
		public override string GetDisName()
		{
			return this.nud_prodqty.Value.ToString();
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

