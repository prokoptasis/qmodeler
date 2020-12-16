using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Q_Modeler
{
	public class FormFLOB2O : Q_Modeler.FormFLO
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tb_bompre;
		private System.Windows.Forms.TextBox tb_bom;
		private System.Windows.Forms.TextBox tb_bomsite;
		private System.Windows.Forms.TextBox tb_item;
		private System.Windows.Forms.TextBox tb_site;
		private System.Windows.Forms.NumericUpDown nud_bomseq;
		private System.Windows.Forms.NumericUpDown nud_consqty;
		private System.Windows.Forms.NumericUpDown nud_altpriority;
		private System.Windows.Forms.ComboBox cb_constype;
		private System.Windows.Forms.ComboBox cb_altbuffer;
		private System.ComponentModel.IContainer components = null;

		#region initializer
		public FormFLOB2O()
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tb_bompre = new System.Windows.Forms.TextBox();
			this.tb_bom = new System.Windows.Forms.TextBox();
			this.tb_bomsite = new System.Windows.Forms.TextBox();
			this.tb_item = new System.Windows.Forms.TextBox();
			this.tb_site = new System.Windows.Forms.TextBox();
			this.cb_constype = new System.Windows.Forms.ComboBox();
			this.cb_altbuffer = new System.Windows.Forms.ComboBox();
			this.nud_bomseq = new System.Windows.Forms.NumericUpDown();
			this.nud_consqty = new System.Windows.Forms.NumericUpDown();
			this.nud_altpriority = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nud_bomseq)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_consqty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_altpriority)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bom";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "BomSite";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "Item/Site";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 21);
			this.label4.TabIndex = 1;
			this.label4.Text = "ConsType";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 21);
			this.label5.TabIndex = 1;
			this.label5.Text = "ConsQty";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 21);
			this.label6.TabIndex = 1;
			this.label6.Text = "AltWith";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 176);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 21);
			this.label7.TabIndex = 1;
			this.label7.Text = "AltPriority";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_bompre
			// 
			this.tb_bompre.Enabled = false;
			this.tb_bompre.Location = new System.Drawing.Point(88, 32);
			this.tb_bompre.Name = "tb_bompre";
			this.tb_bompre.Size = new System.Drawing.Size(40, 21);
			this.tb_bompre.TabIndex = 0;
			this.tb_bompre.Text = "";
			this.tb_bompre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_bom
			// 
			this.tb_bom.Enabled = false;
			this.tb_bom.Location = new System.Drawing.Point(128, 32);
			this.tb_bom.Name = "tb_bom";
			this.tb_bom.Size = new System.Drawing.Size(144, 21);
			this.tb_bom.TabIndex = 0;
			this.tb_bom.Text = "";
			this.tb_bom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_bomsite
			// 
			this.tb_bomsite.Enabled = false;
			this.tb_bomsite.Location = new System.Drawing.Point(88, 56);
			this.tb_bomsite.Name = "tb_bomsite";
			this.tb_bomsite.Size = new System.Drawing.Size(144, 21);
			this.tb_bomsite.TabIndex = 0;
			this.tb_bomsite.Text = "";
			this.tb_bomsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_item
			// 
			this.tb_item.Enabled = false;
			this.tb_item.Location = new System.Drawing.Point(88, 80);
			this.tb_item.Name = "tb_item";
			this.tb_item.Size = new System.Drawing.Size(88, 21);
			this.tb_item.TabIndex = 0;
			this.tb_item.Text = "";
			this.tb_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_site
			// 
			this.tb_site.Enabled = false;
			this.tb_site.Location = new System.Drawing.Point(176, 80);
			this.tb_site.Name = "tb_site";
			this.tb_site.Size = new System.Drawing.Size(96, 21);
			this.tb_site.TabIndex = 0;
			this.tb_site.Text = "";
			this.tb_site.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cb_constype
			// 
			this.cb_constype.Location = new System.Drawing.Point(88, 104);
			this.cb_constype.Name = "cb_constype";
			this.cb_constype.Size = new System.Drawing.Size(184, 20);
			this.cb_constype.TabIndex = 1;
			this.cb_constype.SelectedIndexChanged += new System.EventHandler(this.cb_constype_SelectedIndexChanged);
			// 
			// cb_altbuffer
			// 
			this.cb_altbuffer.Enabled = false;
			this.cb_altbuffer.Location = new System.Drawing.Point(88, 152);
			this.cb_altbuffer.Name = "cb_altbuffer";
			this.cb_altbuffer.Size = new System.Drawing.Size(184, 20);
			this.cb_altbuffer.TabIndex = 3;
			// 
			// nud_bomseq
			// 
			this.nud_bomseq.Enabled = false;
			this.nud_bomseq.Location = new System.Drawing.Point(232, 56);
			this.nud_bomseq.Name = "nud_bomseq";
			this.nud_bomseq.Size = new System.Drawing.Size(40, 21);
			this.nud_bomseq.TabIndex = 0;
			this.nud_bomseq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_consqty
			// 
			this.nud_consqty.Location = new System.Drawing.Point(88, 128);
			this.nud_consqty.Name = "nud_consqty";
			this.nud_consqty.Size = new System.Drawing.Size(184, 21);
			this.nud_consqty.TabIndex = 2;
			this.nud_consqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_altpriority
			// 
			this.nud_altpriority.Enabled = false;
			this.nud_altpriority.Location = new System.Drawing.Point(88, 176);
			this.nud_altpriority.Name = "nud_altpriority";
			this.nud_altpriority.Size = new System.Drawing.Size(184, 21);
			this.nud_altpriority.TabIndex = 4;
			this.nud_altpriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormFLOB2O
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.nud_bomseq);
			this.Controls.Add(this.cb_constype);
			this.Controls.Add(this.tb_bompre);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tb_bom);
			this.Controls.Add(this.tb_bomsite);
			this.Controls.Add(this.tb_item);
			this.Controls.Add(this.tb_site);
			this.Controls.Add(this.cb_altbuffer);
			this.Controls.Add(this.nud_consqty);
			this.Controls.Add(this.nud_altpriority);
			this.Name = "FormFLOB2O";
			this.Controls.SetChildIndex(this.nud_altpriority, 0);
			this.Controls.SetChildIndex(this.nud_consqty, 0);
			this.Controls.SetChildIndex(this.cb_altbuffer, 0);
			this.Controls.SetChildIndex(this.tb_site, 0);
			this.Controls.SetChildIndex(this.tb_item, 0);
			this.Controls.SetChildIndex(this.tb_bomsite, 0);
			this.Controls.SetChildIndex(this.tb_bom, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.tb_bompre, 0);
			this.Controls.SetChildIndex(this.cb_constype, 0);
			this.Controls.SetChildIndex(this.nud_bomseq, 0);
			((System.ComponentModel.ISupportInitialize)(this.nud_bomseq)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_consqty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_altpriority)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region initizlizer
		public FormFLOB2O(int locktype, ArrayList b2o_altbufs)
		{
			InitializeComponent();

			foreach(string str in b2o_altbufs)
			{
				this.cb_altbuffer.Items.Add(str);
			}

			if(!this.cb_constype.Items.Contains(FLOObj.BOMTYPE.Normal))
				this.cb_constype.Items.Add(FLOObj.BOMTYPE.Normal);

			if(this.cb_altbuffer.Items.Count > 0)
			{
				if(!this.cb_constype.Items.Contains(FLOObj.BOMTYPE.Alternate))
					this.cb_constype.Items.Add(FLOObj.BOMTYPE.Alternate);

				this.cb_altbuffer.SelectedIndex = 0;
			}

			this.cb_constype.SelectedIndex = 0;

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
					this.tb_item.Enabled = false;
					this.tb_site.Enabled = false;
					this.nud_consqty.Enabled = true;
					this.cb_constype.Enabled = true;
					this.cb_altbuffer.Enabled = false;
					this.nud_altpriority.Enabled = false;
					
				} break;
				case 1:
				{
					this.tb_bompre.Enabled = false;
					this.tb_bom.Enabled = false;
					this.tb_bomsite.Enabled = false;
					this.nud_bomseq.Enabled = false;
					this.tb_item.Enabled = false;
					this.tb_site.Enabled = false;
					this.nud_consqty.Enabled = true;
					this.cb_constype.Enabled = false;
					this.cb_altbuffer.Enabled = false;
					this.nud_altpriority.Enabled = false;
				} break;
				case 98:
				{
					this.tb_bompre.Enabled = false;
					this.tb_bom.Enabled = false;
					this.tb_bomsite.Enabled = false;
					this.nud_bomseq.Enabled = false;
					this.tb_item.Enabled = false;
					this.tb_site.Enabled = false;
					this.nud_consqty.Enabled = true;
					this.cb_constype.Enabled = false;
					this.cb_altbuffer.Enabled = false;
					this.nud_altpriority.Enabled = true;
				} break;
				case 99:
				{
					this.tb_bompre.Enabled = false;
					this.tb_bom.Enabled = false;
					this.tb_bomsite.Enabled = false;
					this.nud_bomseq.Enabled = false;
					this.tb_item.Enabled = false;
					this.tb_site.Enabled = false;
					this.nud_consqty.Enabled = true;
					this.cb_constype.Enabled = false;
					this.cb_altbuffer.Enabled = false;
					this.nud_altpriority.Enabled = false;
				} break;
			}
		}
		#endregion

		#region setattr
		public override void SetAttr(FLOObj O)
		{
			FLOB2O o = (FLOB2O)O;

			this.tb_bompre.Text = FLOObj.BMPRE;
			this.tb_bom.Text = o.RTlist(0).Ope_operation;
			this.tb_bomsite.Text = o.RTlist(0).Ope_operationsite;
			this.nud_bomseq.Value = (decimal)o.RTlist(0).Ope_operationseq;
			this.tb_item.Text = o.LTlist(0).Buf_item;
			this.tb_site.Text = o.LTlist(0).Buf_site;
			this.nud_consqty.Value = (decimal)o.B2O_cosqty;
			this.cb_constype.SelectedItem = o.B2O_constype;
			this.cb_altbuffer.SelectedItem = o.B2O_altbuf;
			this.nud_altpriority.Value = (decimal)o.B2O_altpriority;
		}

		private bool init = true;

		public override void SetAttrMulti(FLOObj O)
		{
			FLOB2O o = (FLOB2O)O;

			if(init)
			{
				this.tb_bompre.Text = FLOObj.BMPRE;
				this.tb_bom.Text = o.RTlist(0).Ope_operation;
				this.tb_bomsite.Text = o.RTlist(0).Ope_operationsite;
				this.nud_bomseq.Value = (decimal)o.RTlist(0).Ope_operationseq;
				this.tb_item.Text = o.LTlist(0).Buf_item;
				this.tb_site.Text = o.LTlist(0).Buf_site;
				this.nud_consqty.Value = (decimal)o.B2O_cosqty;
				this.cb_constype.SelectedItem = o.B2O_constype;
				this.cb_altbuffer.SelectedItem = o.B2O_altbuf;
				this.nud_altpriority.Value = (decimal)o.B2O_altpriority;
			}

			init = false;

			if(this.tb_bom.Text != o.RTlist(0).Ope_operation)
				this.tb_bom.Text = "";
			if(this.tb_bomsite.Text != o.RTlist(0).Ope_operationsite)
				this.tb_bomsite.Text = "";
			if(this.tb_item.Text != o.LTlist(0).Buf_item)
				this.tb_item.Text = "";
			if(this.tb_site.Text != o.LTlist(0).Buf_site)
				this.tb_site.Text = "";
			if(this.nud_bomseq.Value != (decimal)o.RTlist(0).Ope_operationseq)
				this.nud_bomseq.Value = 0;
			if(this.nud_consqty.Value != (decimal)o.B2O_cosqty)
				this.nud_consqty.Value = 0;
			if(this.nud_altpriority.Value != (decimal)o.B2O_altpriority)
				this.nud_altpriority.Value = 0;
			if(this.cb_constype.SelectedItem != null)
				if(this.cb_constype.SelectedItem.ToString() != o.B2O_constype.ToString())
					this.cb_constype.SelectedItem = "";
			if(this.cb_altbuffer.SelectedItem != null)	
				if(this.cb_altbuffer.SelectedItem.ToString() != o.B2O_altbuf.ToString())
					this.cb_altbuffer.SelectedItem = "";
		}
		#endregion

		#region getattr
		public override void GetAttr(FLOObj O)
		{			
			FLOB2O o = (FLOB2O)O;

			o.B2O_cosqty = (int)this.nud_consqty.Value;
			o.B2O_constype = (FLOObj.BOMTYPE)this.cb_constype.SelectedItem;

			if(this.cb_altbuffer.SelectedItem != null)
				o.B2O_altbuf = this.cb_altbuffer.SelectedItem.ToString();

			o.B2O_altpriority = (int)this.nud_altpriority.Value;
		}

		public override void GetAttrMulti(FLOObj O)
		{			
			FLOB2O o = (FLOB2O)O;

			o.B2O_cosqty = (int)this.nud_consqty.Value;

			if(this.nud_altpriority.Enabled)
				o.B2O_altpriority = (int)this.nud_altpriority.Value;

		}
		#endregion
		
		#region getobj/disname
		public override string GetObjName()
		{
			return this.tb_item.Text + "@" + this.tb_site.Text + ">>>" + FLOObj.OPPRE + this.tb_bom.Text + "@" + this.tb_bomsite.Text + "_" + this.nud_bomseq.Value.ToString();
		}
		
		public override string GetDisName()
		{
			return this.nud_consqty.Value.ToString();
		}

		public override string GetObjName(FLOObj o)
		{
			return o.Objname;
		}

		public override string GetDisName(FLOObj o)
		{
			return this.nud_consqty.Value.ToString();
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

		#region cb constype selected item changed
		private void cb_constype_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if((FLOObj.BOMTYPE)cb_constype.SelectedItem == FLOObj.BOMTYPE.Alternate)
			{
				this.cb_altbuffer.Enabled = true;
				this.nud_altpriority.Enabled = true;
			}
			else
			{
				this.cb_altbuffer.Enabled = false;
				this.nud_altpriority.Enabled = false;
			}
		}
		#endregion
	}
}

