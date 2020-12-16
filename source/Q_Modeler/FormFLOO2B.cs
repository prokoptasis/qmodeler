using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Q_Modeler
{
	public class FormFLOO2B : Q_Modeler.FormFLO
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_bom;
		private System.Windows.Forms.TextBox tb_bomsite;
		private System.Windows.Forms.NumericUpDown nud_bomseq;
		private System.Windows.Forms.TextBox tb_bompre;
		private System.Windows.Forms.NumericUpDown nud_prodqty;
		private System.Windows.Forms.NumericUpDown nud_altpriority;
		private System.Windows.Forms.NumericUpDown nud_cobyprodrate;
		private System.Windows.Forms.CheckBox ck_basedqty;
		private System.Windows.Forms.CheckBox ck_cobyprod;
		private System.Windows.Forms.NumericUpDown nud_cobyprodqty;
		private System.Windows.Forms.NumericUpDown nud_altproportion;
		private System.Windows.Forms.RadioButton rb_priority;
		private System.Windows.Forms.RadioButton rb_proportion;
		private System.Windows.Forms.TextBox tb_prodtype;
		private System.ComponentModel.IContainer components = null;

		#region initializer
		public FormFLOO2B()
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
			this.tb_bom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_bomsite = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nud_bomseq = new System.Windows.Forms.NumericUpDown();
			this.tb_bompre = new System.Windows.Forms.TextBox();
			this.nud_prodqty = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nud_altpriority = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.nud_cobyprodrate = new System.Windows.Forms.NumericUpDown();
			this.ck_basedqty = new System.Windows.Forms.CheckBox();
			this.ck_cobyprod = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.nud_cobyprodqty = new System.Windows.Forms.NumericUpDown();
			this.nud_altproportion = new System.Windows.Forms.NumericUpDown();
			this.rb_priority = new System.Windows.Forms.RadioButton();
			this.rb_proportion = new System.Windows.Forms.RadioButton();
			this.tb_prodtype = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.nud_bomseq)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_prodqty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_altpriority)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_cobyprodrate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_cobyprodqty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_altproportion)).BeginInit();
			this.SuspendLayout();
			// 
			// tb_bom
			// 
			this.tb_bom.Enabled = false;
			this.tb_bom.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_bom.Location = new System.Drawing.Point(136, 24);
			this.tb_bom.Name = "tb_bom";
			this.tb_bom.Size = new System.Drawing.Size(136, 21);
			this.tb_bom.TabIndex = 0;
			this.tb_bom.Text = "";
			this.tb_bom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bom";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_bomsite
			// 
			this.tb_bomsite.Enabled = false;
			this.tb_bomsite.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_bomsite.Location = new System.Drawing.Point(104, 48);
			this.tb_bomsite.Name = "tb_bomsite";
			this.tb_bomsite.Size = new System.Drawing.Size(120, 21);
			this.tb_bomsite.TabIndex = 1;
			this.tb_bomsite.Text = "";
			this.tb_bomsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "BomSite";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_bomseq
			// 
			this.nud_bomseq.Enabled = false;
			this.nud_bomseq.Location = new System.Drawing.Point(224, 48);
			this.nud_bomseq.Name = "nud_bomseq";
			this.nud_bomseq.Size = new System.Drawing.Size(48, 21);
			this.nud_bomseq.TabIndex = 3;
			this.nud_bomseq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_bompre
			// 
			this.tb_bompre.Enabled = false;
			this.tb_bompre.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_bompre.Location = new System.Drawing.Point(104, 24);
			this.tb_bompre.Name = "tb_bompre";
			this.tb_bompre.Size = new System.Drawing.Size(32, 21);
			this.tb_bompre.TabIndex = 0;
			this.tb_bompre.TabStop = false;
			this.tb_bompre.Text = "";
			this.tb_bompre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_prodqty
			// 
			this.nud_prodqty.DecimalPlaces = 2;
			this.nud_prodqty.Location = new System.Drawing.Point(208, 72);
			this.nud_prodqty.Maximum = new System.Decimal(new int[] {
																		100000000,
																		0,
																		0,
																		0});
			this.nud_prodqty.Name = "nud_prodqty";
			this.nud_prodqty.Size = new System.Drawing.Size(64, 21);
			this.nud_prodqty.TabIndex = 24;
			this.nud_prodqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 21);
			this.label5.TabIndex = 25;
			this.label5.Text = "ProdType/Qty";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 21);
			this.label3.TabIndex = 26;
			this.label3.Text = "Alt Priority";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_altpriority
			// 
			this.nud_altpriority.Enabled = false;
			this.nud_altpriority.Location = new System.Drawing.Point(104, 96);
			this.nud_altpriority.Maximum = new System.Decimal(new int[] {
																			10000,
																			0,
																			0,
																			0});
			this.nud_altpriority.Name = "nud_altpriority";
			this.nud_altpriority.Size = new System.Drawing.Size(152, 21);
			this.nud_altpriority.TabIndex = 24;
			this.nud_altpriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nud_altpriority.Value = new System.Decimal(new int[] {
																		  1,
																		  0,
																		  0,
																		  0});
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 120);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 21);
			this.label6.TabIndex = 26;
			this.label6.Text = "Alt Proportion";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 192);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 21);
			this.label7.TabIndex = 26;
			this.label7.Text = "CoByProdRate";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_cobyprodrate
			// 
			this.nud_cobyprodrate.DecimalPlaces = 2;
			this.nud_cobyprodrate.Enabled = false;
			this.nud_cobyprodrate.Location = new System.Drawing.Point(104, 192);
			this.nud_cobyprodrate.Name = "nud_cobyprodrate";
			this.nud_cobyprodrate.Size = new System.Drawing.Size(168, 21);
			this.nud_cobyprodrate.TabIndex = 24;
			this.nud_cobyprodrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ck_basedqty
			// 
			this.ck_basedqty.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ck_basedqty.Checked = true;
			this.ck_basedqty.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck_basedqty.Enabled = false;
			this.ck_basedqty.Location = new System.Drawing.Point(24, 144);
			this.ck_basedqty.Name = "ck_basedqty";
			this.ck_basedqty.Size = new System.Drawing.Size(120, 24);
			this.ck_basedqty.TabIndex = 31;
			this.ck_basedqty.Text = "BasedQty";
			this.ck_basedqty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ck_basedqty.CheckedChanged += new System.EventHandler(this.ck_basedqty_CheckedChanged);
			// 
			// ck_cobyprod
			// 
			this.ck_cobyprod.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ck_cobyprod.Checked = true;
			this.ck_cobyprod.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck_cobyprod.Enabled = false;
			this.ck_cobyprod.Location = new System.Drawing.Point(152, 144);
			this.ck_cobyprod.Name = "ck_cobyprod";
			this.ck_cobyprod.Size = new System.Drawing.Size(120, 24);
			this.ck_cobyprod.TabIndex = 31;
			this.ck_cobyprod.Text = "CoByProd";
			this.ck_cobyprod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 21);
			this.label4.TabIndex = 26;
			this.label4.Text = "CoByProdQty";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_cobyprodqty
			// 
			this.nud_cobyprodqty.DecimalPlaces = 2;
			this.nud_cobyprodqty.Enabled = false;
			this.nud_cobyprodqty.Location = new System.Drawing.Point(104, 168);
			this.nud_cobyprodqty.Maximum = new System.Decimal(new int[] {
																			1000000,
																			0,
																			0,
																			0});
			this.nud_cobyprodqty.Name = "nud_cobyprodqty";
			this.nud_cobyprodqty.Size = new System.Drawing.Size(168, 21);
			this.nud_cobyprodqty.TabIndex = 24;
			this.nud_cobyprodqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_altproportion
			// 
			this.nud_altproportion.DecimalPlaces = 2;
			this.nud_altproportion.Enabled = false;
			this.nud_altproportion.Location = new System.Drawing.Point(104, 120);
			this.nud_altproportion.Name = "nud_altproportion";
			this.nud_altproportion.Size = new System.Drawing.Size(152, 21);
			this.nud_altproportion.TabIndex = 24;
			this.nud_altproportion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rb_priority
			// 
			this.rb_priority.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rb_priority.Enabled = false;
			this.rb_priority.Location = new System.Drawing.Point(256, 96);
			this.rb_priority.Name = "rb_priority";
			this.rb_priority.Size = new System.Drawing.Size(16, 24);
			this.rb_priority.TabIndex = 101;
			this.rb_priority.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.rb_priority.CheckedChanged += new System.EventHandler(this.rb_priority_CheckedChanged);
			// 
			// rb_proportion
			// 
			this.rb_proportion.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rb_proportion.Enabled = false;
			this.rb_proportion.Location = new System.Drawing.Point(256, 120);
			this.rb_proportion.Name = "rb_proportion";
			this.rb_proportion.Size = new System.Drawing.Size(16, 24);
			this.rb_proportion.TabIndex = 101;
			this.rb_proportion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tb_prodtype
			// 
			this.tb_prodtype.Enabled = false;
			this.tb_prodtype.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_prodtype.Location = new System.Drawing.Point(104, 72);
			this.tb_prodtype.Name = "tb_prodtype";
			this.tb_prodtype.Size = new System.Drawing.Size(104, 21);
			this.tb_prodtype.TabIndex = 1;
			this.tb_prodtype.Text = "";
			this.tb_prodtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tb_prodtype.TextChanged += new System.EventHandler(this.tb_prodtype_TextChanged);
			// 
			// FormFLOO2B
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.rb_priority);
			this.Controls.Add(this.tb_bom);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_bomsite);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nud_bomseq);
			this.Controls.Add(this.tb_bompre);
			this.Controls.Add(this.nud_prodqty);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nud_altpriority);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.nud_cobyprodrate);
			this.Controls.Add(this.ck_basedqty);
			this.Controls.Add(this.ck_cobyprod);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nud_cobyprodqty);
			this.Controls.Add(this.nud_altproportion);
			this.Controls.Add(this.rb_proportion);
			this.Controls.Add(this.tb_prodtype);
			this.Name = "FormFLOO2B";
			this.Controls.SetChildIndex(this.tb_prodtype, 0);
			this.Controls.SetChildIndex(this.rb_proportion, 0);
			this.Controls.SetChildIndex(this.nud_altproportion, 0);
			this.Controls.SetChildIndex(this.nud_cobyprodqty, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.ck_cobyprod, 0);
			this.Controls.SetChildIndex(this.ck_basedqty, 0);
			this.Controls.SetChildIndex(this.nud_cobyprodrate, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.nud_altpriority, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.nud_prodqty, 0);
			this.Controls.SetChildIndex(this.tb_bompre, 0);
			this.Controls.SetChildIndex(this.nud_bomseq, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.tb_bomsite, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.tb_bom, 0);
			this.Controls.SetChildIndex(this.rb_priority, 0);
			((System.ComponentModel.ISupportInitialize)(this.nud_bomseq)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_prodqty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_altpriority)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_cobyprodrate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_cobyprodqty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_altproportion)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region local variables
		private string buf_item;
		private string buf_site;
		#endregion

		#region initizlizer
		public FormFLOO2B(int locktype)
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
					this.tb_bompre.Enabled = false;
					this.tb_bom.Enabled = false;
					this.tb_bomsite.Enabled = false;
					this.nud_bomseq.Enabled = false;
					this.tb_prodtype.Enabled = false;
					this.nud_prodqty.Enabled = true;
					this.rb_priority.Enabled = false;
					this.rb_proportion.Enabled = false;
					this.nud_altpriority.Enabled = false;
					this.nud_altproportion.Enabled = false;
					this.ck_basedqty.Enabled = false;
					this.ck_cobyprod.Enabled = false;
					this.nud_cobyprodqty.Enabled = false;
					this.nud_cobyprodrate.Enabled = false;
				} break;
				case 1:
				{
					this.tb_bompre.Enabled = false;
					this.tb_bom.Enabled = false;
					this.tb_bomsite.Enabled = false;
					this.nud_bomseq.Enabled = false;
					this.tb_prodtype.Enabled = true;
					this.nud_prodqty.Enabled = true;
					this.rb_priority.Enabled = false;
					this.rb_proportion.Enabled = false;
					this.nud_altpriority.Enabled = false;
					this.nud_altproportion.Enabled = false;
					this.ck_basedqty.Enabled = false;
					this.ck_cobyprod.Enabled = false;
					this.nud_cobyprodqty.Enabled = false;
					this.nud_cobyprodrate.Enabled = false;	
				} break;
				case 97:
				{
					this.tb_bompre.Enabled = false;
					this.tb_bom.Enabled = false;
					this.tb_bomsite.Enabled = false;
					this.nud_bomseq.Enabled = false;
					this.tb_prodtype.Enabled = false;
					this.nud_prodqty.Enabled = true;
					this.rb_priority.Enabled = true;
					this.rb_proportion.Enabled = true;
					this.nud_altpriority.Enabled = true;
					this.nud_altproportion.Enabled = false;
					this.ck_basedqty.Enabled = false;
					this.ck_cobyprod.Enabled = false;
					this.nud_cobyprodqty.Enabled = false;
					this.nud_cobyprodrate.Enabled = false;	
				} break;
				case 98:
				{
					this.tb_bompre.Enabled = false;
					this.tb_bom.Enabled = false;
					this.tb_bomsite.Enabled = false;
					this.nud_bomseq.Enabled = false;
					this.tb_prodtype.Enabled = false;
					this.nud_prodqty.Enabled = false;
					this.rb_priority.Enabled = false;
					this.rb_proportion.Enabled = false;
					this.nud_altpriority.Enabled = false;
					this.nud_altproportion.Enabled = false;
					this.ck_basedqty.Enabled = true;
					this.ck_cobyprod.Enabled = true;
					this.nud_cobyprodqty.Enabled = true;
					this.nud_cobyprodrate.Enabled = false;	
				} break;
				case 99:
				{
					this.tb_bompre.Enabled = false;
					this.tb_bom.Enabled = false;
					this.tb_bomsite.Enabled = false;
					this.nud_bomseq.Enabled = false;
					this.tb_prodtype.Enabled = false;
					this.nud_prodqty.Enabled = true;
					this.rb_priority.Enabled = false;
					this.rb_proportion.Enabled = false;
					this.nud_altpriority.Enabled = false;
					this.nud_altproportion.Enabled = false;
					this.ck_basedqty.Enabled = false;
					this.ck_cobyprod.Enabled = false;
					this.nud_cobyprodqty.Enabled = false;
					this.nud_cobyprodrate.Enabled = false;	
				} break;
			}
		}
		#endregion

		#region setattr
		public override void SetAttr(FLOObj O)
		{
			FLOO2B o = (FLOO2B)O;
			
			this.tb_bompre.Text = FLOObj.BMPRE;
			this.tb_bom.Text = o.LTlist(0).Ope_operation;
			this.tb_bomsite.Text = o.LTlist(0).Ope_operationsite;
			
			this.tb_prodtype.Text = o.O2B_prodtype.ToString();
			this.nud_prodqty.Value = (decimal)o.O2B_prodqty;
			this.rb_priority.Checked = o.O2B_altpriority > 0?true:false;
			this.rb_proportion.Checked = o.O2B_altproportion > 0?true:false;
			this.nud_altpriority.Value = (decimal)o.O2B_altpriority;
			this.nud_altproportion.Value = (decimal)o.O2B_altproportion;
			this.ck_basedqty.Checked = o.O2B_basedqty == 1?true:false;
			this.ck_cobyprod.Checked = o.O2B_cobyprod == 1?true:false;
			this.nud_cobyprodqty.Value = (decimal)o.O2B_cobyprodqty;
			this.nud_cobyprodrate.Value = (decimal)o.O2B_cobyprodrate;

			this.buf_item = o.RTlist(0).Buf_item;
			this.buf_site = o.RTlist(0).Buf_site;
		}

		private bool init = true;

		public override void SetAttrMulti(FLOObj O)
		{
			FLOO2B o = (FLOO2B)O;

			if(init)
			{
				this.buf_item = o.RTlist(0).Buf_item;
				this.buf_site = o.RTlist(0).Buf_site;

				this.tb_bompre.Text = FLOObj.BMPRE;
				this.tb_bom.Text = o.LTlist(0).Ope_operation;
				this.tb_bomsite.Text = o.LTlist(0).Ope_operationsite;			
				this.tb_prodtype.Text = o.O2B_prodtype.ToString();
				
				this.nud_prodqty.Value = (decimal)o.O2B_prodqty;
				this.nud_altpriority.Value = (decimal)o.O2B_altpriority;
				this.nud_altproportion.Value = (decimal)o.O2B_altproportion;
				this.nud_cobyprodqty.Value = (decimal)o.O2B_cobyprodqty;
				this.nud_cobyprodrate.Value = (decimal)o.O2B_cobyprodrate;

				this.rb_priority.Checked = o.O2B_altpriority > 0?true:false;
				this.rb_proportion.Checked = o.O2B_altproportion > 0?true:false;
				this.ck_basedqty.Checked = o.O2B_basedqty == 1?true:false;
				this.ck_cobyprod.Checked = o.O2B_cobyprod == 1?true:false;
			}

			init = false;

			if(this.tb_bom.Text != o.RTlist(0).Ope_operation)
				this.tb_bom.Text = "";
			if(this.tb_bomsite.Text != o.RTlist(0).Ope_operationsite)
				this.tb_bomsite.Text = "";
			if(this.tb_prodtype.Text != o.O2B_prodtype.ToString())
			{
				this.tb_prodtype.Text = FLOObj.OPETYPE.NULL.ToString();
				this.nud_prodqty.Enabled = true;
			}
			if(this.nud_prodqty.Value != (decimal)o.O2B_prodqty)
				this.nud_prodqty.Value = 0;
			if(this.nud_altpriority.Value != (decimal)o.O2B_altpriority)
				this.nud_altpriority.Value = 0;
			if(this.nud_altproportion.Value != (decimal)o.O2B_altproportion)
				this.nud_altproportion.Value = 0;
			if(this.nud_cobyprodqty.Value != (decimal)o.O2B_cobyprodqty)
				this.nud_cobyprodqty.Value = 0;
			if(this.nud_cobyprodrate.Value != (decimal)o.O2B_cobyprodrate)
				this.nud_cobyprodrate.Value = 0;
			if(this.rb_priority.Checked != (o.O2B_altpriority > 0?true:false))
				this.rb_priority.Checked = true;
			if(this.rb_proportion.Checked != (o.O2B_altproportion > 0?true:false))
				this.rb_proportion.Checked = false;
			if(this.ck_basedqty.Checked != (o.O2B_basedqty == 1?true:false))
				this.ck_basedqty.Checked = true;
			if(this.ck_cobyprod.Checked != (o.O2B_cobyprod == 1?true:false))
				this.ck_cobyprod.Checked = true;
		}
		#endregion

		#region getattr
		public override void GetAttr(FLOObj O)
		{
			FLOO2B o = (FLOO2B)O;
			
			o.O2B_prodqty = (int)this.nud_prodqty.Value;
			o.O2B_altpriority = (int)this.nud_altpriority.Value;
			o.O2B_altproportion = (int)this.nud_altproportion.Value;
			o.O2B_basedqty = this.ck_basedqty.Checked == true?1:0;
			o.O2B_cobyprod = this.ck_cobyprod.Checked == true?1:0;
			o.O2B_cobyprodqty = (int)this.nud_cobyprodqty.Value;
			o.O2B_cobyprodrate = (int)this.nud_cobyprodrate.Value;
		}

		public override void GetAttrMulti(FLOObj O)
		{
			FLOO2B o = (FLOO2B)O;
			
			if(this.nud_prodqty.Enabled)
				o.O2B_prodqty = (int)this.nud_prodqty.Value;

			if(this.rb_priority.Enabled && this.rb_priority.Checked)
			{
				o.O2B_altpriority = (int)this.nud_altpriority.Value;
				o.O2B_altproportion = 0;
			}
			if(this.rb_proportion.Enabled && this.rb_proportion.Checked)
			{
				o.R2O_altpriority = 0;
				o.O2B_altproportion = (int)this.nud_altproportion.Value;
			}

			if(this.ck_basedqty.Enabled && this.ck_basedqty.Checked)
			{
				o.O2B_basedqty = this.ck_basedqty.Checked == true?1:0;
				o.O2B_cobyprodqty = (int)this.nud_cobyprodqty.Value;
				o.O2B_cobyprod = this.ck_cobyprod.Checked == true?1:0;
				o.O2B_cobyprodrate = 0;
			}

			if(this.ck_basedqty.Enabled && !this.ck_basedqty.Checked)
			{
				o.O2B_cobyprodrate = (int)this.nud_cobyprodrate.Value;
				o.O2B_basedqty = this.ck_basedqty.Checked == true?1:0;
				o.O2B_cobyprod = this.ck_cobyprod.Checked == true?1:0;
				o.O2B_cobyprodqty = 0;
			}
		}
		#endregion
		
		#region getobj/disname
		public override string GetObjName()
		{
			return FLOObj.OPPRE + this.tb_bom.Text + "@" + this.tb_bomsite.Text + this.nud_bomseq.Value.ToString() + ">>>" + this.buf_item + "@" + this.buf_site; 
		}
		
		public override string GetDisName()
		{
			if(this.tb_prodtype.Text == FLOObj.OPETYPE.CoByProd.ToString())
			{
				if(this.ck_basedqty.Checked)
					return this.nud_cobyprodqty.Value.ToString();
				else
					return this.nud_cobyprodrate.Value.ToString();
			}
			else
			{
				return this.nud_prodqty.Value.ToString();
			}
		}

		public override string GetObjName(FLOObj o)
		{
			return o.Objname; 
		}
		
		public override string GetDisName(FLOObj o)
		{
			if(o.O2B_prodtype == FLOObj.OPETYPE.CoByProd)
			{
				if(this.ck_basedqty.Enabled)
				{
					if(this.ck_basedqty.Checked)
						return this.nud_cobyprodqty.Value.ToString();
					else
						return this.nud_cobyprodrate.Value.ToString();
				}
				else
				{
					if(o.O2B_basedqty == 1)
						return o.O2B_cobyprodqty.ToString();
					else
						return o.O2B_cobyprodrate.ToString();
				}
			}
			else
			{
				if(this.nud_prodqty.Enabled)
					return this.nud_prodqty.Value.ToString();
				else
					return o.O2B_prodqty.ToString();
			}
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

		#region control enable/disable by form condition 
		private void tb_prodtype_TextChanged(object sender, System.EventArgs e)
		{
			if(tb_prodtype.Text == FLOObj.OPETYPE.AltRouting.ToString())
			{
				this.nud_altpriority.Enabled = true;
				this.nud_altproportion.Enabled = false;
				this.rb_priority.Enabled = true;
				this.rb_proportion.Enabled = true;
				this.rb_priority.Checked = true;
				this.rb_proportion.Checked = false;

				this.ck_basedqty.Enabled = false;
				this.ck_cobyprod.Enabled = false;
				this.nud_cobyprodqty.Enabled = false;
				this.nud_cobyprodrate.Enabled = false;;
			}
			else if (tb_prodtype.Text == FLOObj.OPETYPE.CoByProd.ToString())
			{
				this.nud_prodqty.Enabled = false;

				this.nud_altpriority.Enabled = false;
				this.nud_altproportion.Enabled = false;
				this.rb_priority.Enabled = false;
				this.rb_proportion.Enabled = false;

				this.ck_basedqty.Enabled = true;
				this.ck_cobyprod.Enabled = true;
				this.ck_basedqty.Checked = true;
				this.ck_cobyprod.Checked = true;
				this.nud_cobyprodqty.Enabled = true;
				this.nud_cobyprodrate.Enabled = false;;
			}
			else
			{
				this.rb_priority.Enabled = false;
				this.rb_proportion.Enabled = false;
				this.nud_altpriority.Enabled = false;
				this.nud_altproportion.Enabled = false;
				this.ck_basedqty.Enabled = false;
				this.ck_cobyprod.Enabled = false;
				this.nud_cobyprodqty.Enabled = false;
				this.nud_cobyprodrate.Enabled = false;	
			}
		
		}

		private void rb_priority_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.tb_prodtype.Text == FLOObj.OPETYPE.AltRouting.ToString())
				if(this.rb_priority.Checked)
				{
					this.nud_altpriority.Enabled = true;
					this.nud_altpriority.Value = 1;
					this.nud_altproportion.Enabled = false;
					this.nud_altproportion.Value = 0;
					this.rb_proportion.Checked = false;
				}
				else
				{
					this.nud_altpriority.Enabled = false;
					this.nud_altpriority.Value = 0;
					this.nud_altproportion.Enabled = true;
					this.nud_altproportion.Value = 1;
					this.rb_proportion.Checked = true;
				}
		}

		private void ck_basedqty_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.tb_prodtype.Text == FLOObj.OPETYPE.CoByProd.ToString())
				if(this.ck_basedqty.Checked)
				{
					this.nud_cobyprodqty.Enabled = true;
					this.nud_cobyprodrate.Enabled = false;
				}
				else
				{
					this.nud_cobyprodqty.Enabled = false;
					this.nud_cobyprodrate.Enabled = true;
				}
		}	
		#endregion
	}
}

