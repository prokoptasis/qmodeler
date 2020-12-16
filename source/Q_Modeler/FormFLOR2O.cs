using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Q_Modeler
{
	public class FormFLOR2O : Q_Modeler.FormFLO
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tb_resource;
		private System.Windows.Forms.TextBox tb_resourcesite;
		private System.Windows.Forms.TextBox tb_resourcepre;
		private System.Windows.Forms.TextBox tb_routingpre;
		private System.Windows.Forms.TextBox tb_routing;
		private System.Windows.Forms.TextBox tb_operationpre;
		private System.Windows.Forms.TextBox tb_operation;
		private System.Windows.Forms.TextBox tb_operationsite;
		private System.Windows.Forms.NumericUpDown nud_operationseq;
		private System.Windows.Forms.ComboBox cb_resourcetype;
		private System.Windows.Forms.ComboBox cb_altresource;
		private System.Windows.Forms.NumericUpDown nud_qtyper;
		private System.Windows.Forms.NumericUpDown nud_altpriority;
		private System.ComponentModel.IContainer components = null;

		#region initializer
		public FormFLOR2O()
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
			this.tb_resource = new System.Windows.Forms.TextBox();
			this.tb_resourcesite = new System.Windows.Forms.TextBox();
			this.tb_resourcepre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_routingpre = new System.Windows.Forms.TextBox();
			this.tb_routing = new System.Windows.Forms.TextBox();
			this.tb_operationpre = new System.Windows.Forms.TextBox();
			this.tb_operation = new System.Windows.Forms.TextBox();
			this.tb_operationsite = new System.Windows.Forms.TextBox();
			this.nud_operationseq = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cb_resourcetype = new System.Windows.Forms.ComboBox();
			this.cb_altresource = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.nud_qtyper = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.nud_altpriority = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nud_operationseq)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_qtyper)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_altpriority)).BeginInit();
			this.SuspendLayout();
			// 
			// tb_resource
			// 
			this.tb_resource.Enabled = false;
			this.tb_resource.Location = new System.Drawing.Point(120, 24);
			this.tb_resource.Name = "tb_resource";
			this.tb_resource.Size = new System.Drawing.Size(152, 21);
			this.tb_resource.TabIndex = 0;
			this.tb_resource.Text = "";
			this.tb_resource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_resourcesite
			// 
			this.tb_resourcesite.Enabled = false;
			this.tb_resourcesite.Location = new System.Drawing.Point(88, 48);
			this.tb_resourcesite.Name = "tb_resourcesite";
			this.tb_resourcesite.Size = new System.Drawing.Size(184, 21);
			this.tb_resourcesite.TabIndex = 1;
			this.tb_resourcesite.Text = "";
			this.tb_resourcesite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_resourcepre
			// 
			this.tb_resourcepre.Enabled = false;
			this.tb_resourcepre.Location = new System.Drawing.Point(88, 24);
			this.tb_resourcepre.Name = "tb_resourcepre";
			this.tb_resourcepre.Size = new System.Drawing.Size(34, 21);
			this.tb_resourcepre.TabIndex = 1;
			this.tb_resourcepre.TabStop = false;
			this.tb_resourcepre.Text = "";
			this.tb_resourcepre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Resc.Site";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Resource";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "Routing";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_routingpre
			// 
			this.tb_routingpre.Enabled = false;
			this.tb_routingpre.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_routingpre.Location = new System.Drawing.Point(88, 72);
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
			this.tb_routing.Location = new System.Drawing.Point(120, 72);
			this.tb_routing.Name = "tb_routing";
			this.tb_routing.Size = new System.Drawing.Size(152, 21);
			this.tb_routing.TabIndex = 2;
			this.tb_routing.Text = "";
			this.tb_routing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_operationpre
			// 
			this.tb_operationpre.Enabled = false;
			this.tb_operationpre.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_operationpre.Location = new System.Drawing.Point(88, 96);
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
			this.tb_operation.Location = new System.Drawing.Point(120, 96);
			this.tb_operation.Name = "tb_operation";
			this.tb_operation.Size = new System.Drawing.Size(152, 21);
			this.tb_operation.TabIndex = 0;
			this.tb_operation.Text = "";
			this.tb_operation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_operationsite
			// 
			this.tb_operationsite.Enabled = false;
			this.tb_operationsite.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_operationsite.Location = new System.Drawing.Point(88, 120);
			this.tb_operationsite.Name = "tb_operationsite";
			this.tb_operationsite.Size = new System.Drawing.Size(144, 21);
			this.tb_operationsite.TabIndex = 1;
			this.tb_operationsite.Text = "";
			this.tb_operationsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_operationseq
			// 
			this.nud_operationseq.Enabled = false;
			this.nud_operationseq.Location = new System.Drawing.Point(232, 120);
			this.nud_operationseq.Name = "nud_operationseq";
			this.nud_operationseq.Size = new System.Drawing.Size(40, 21);
			this.nud_operationseq.TabIndex = 3;
			this.nud_operationseq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 21);
			this.label4.TabIndex = 1;
			this.label4.Text = "Operation";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 21);
			this.label5.TabIndex = 1;
			this.label5.Text = "Ope.Site";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cb_resourcetype
			// 
			this.cb_resourcetype.Location = new System.Drawing.Point(88, 168);
			this.cb_resourcetype.Name = "cb_resourcetype";
			this.cb_resourcetype.Size = new System.Drawing.Size(144, 20);
			this.cb_resourcetype.TabIndex = 37;
			this.cb_resourcetype.SelectedIndexChanged += new System.EventHandler(this.cb_resourcetype_SelectedIndexChanged);
			// 
			// cb_altresource
			// 
			this.cb_altresource.Enabled = false;
			this.cb_altresource.Location = new System.Drawing.Point(88, 192);
			this.cb_altresource.Name = "cb_altresource";
			this.cb_altresource.Size = new System.Drawing.Size(184, 20);
			this.cb_altresource.TabIndex = 39;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 21);
			this.label6.TabIndex = 35;
			this.label6.Text = "QtyPer";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 168);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 21);
			this.label7.TabIndex = 36;
			this.label7.Text = "Type";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_qtyper
			// 
			this.nud_qtyper.Location = new System.Drawing.Point(88, 144);
			this.nud_qtyper.Maximum = new System.Decimal(new int[] {
																	   100000000,
																	   0,
																	   0,
																	   0});
			this.nud_qtyper.Name = "nud_qtyper";
			this.nud_qtyper.Size = new System.Drawing.Size(184, 21);
			this.nud_qtyper.TabIndex = 34;
			this.nud_qtyper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(24, 192);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 21);
			this.label8.TabIndex = 38;
			this.label8.Text = "AltFor";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_altpriority
			// 
			this.nud_altpriority.Enabled = false;
			this.nud_altpriority.Location = new System.Drawing.Point(232, 168);
			this.nud_altpriority.Name = "nud_altpriority";
			this.nud_altpriority.Size = new System.Drawing.Size(40, 21);
			this.nud_altpriority.TabIndex = 3;
			this.nud_altpriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormFLOR2O
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.tb_resource);
			this.Controls.Add(this.tb_resourcesite);
			this.Controls.Add(this.tb_resourcepre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_routingpre);
			this.Controls.Add(this.tb_routing);
			this.Controls.Add(this.tb_operationpre);
			this.Controls.Add(this.tb_operation);
			this.Controls.Add(this.tb_operationsite);
			this.Controls.Add(this.nud_operationseq);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cb_resourcetype);
			this.Controls.Add(this.cb_altresource);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.nud_qtyper);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.nud_altpriority);
			this.Name = "FormFLOR2O";
			this.Controls.SetChildIndex(this.nud_altpriority, 0);
			this.Controls.SetChildIndex(this.label8, 0);
			this.Controls.SetChildIndex(this.nud_qtyper, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.cb_altresource, 0);
			this.Controls.SetChildIndex(this.cb_resourcetype, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.nud_operationseq, 0);
			this.Controls.SetChildIndex(this.tb_operationsite, 0);
			this.Controls.SetChildIndex(this.tb_operation, 0);
			this.Controls.SetChildIndex(this.tb_operationpre, 0);
			this.Controls.SetChildIndex(this.tb_routing, 0);
			this.Controls.SetChildIndex(this.tb_routingpre, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.tb_resourcepre, 0);
			this.Controls.SetChildIndex(this.tb_resourcesite, 0);
			this.Controls.SetChildIndex(this.tb_resource, 0);
			((System.ComponentModel.ISupportInitialize)(this.nud_operationseq)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_qtyper)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_altpriority)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region local variables
		#endregion

		#region initizlizer
		public FormFLOR2O(int locktype, ArrayList r2o_effresources)
		{
			InitializeComponent();

			this.cb_altresource.Items.Clear();

			foreach(string str in r2o_effresources)
			{
				if(!this.cb_altresource.Items.Contains(str))
					this.cb_altresource.Items.Add(str);
			}			

			if(this.cb_altresource.Items.Count > 0)
			{
				if(!this.cb_resourcetype.Items.Contains(FLOObj.RESTYPE.Alternate))
					this.cb_resourcetype.Items.Add(FLOObj.RESTYPE.Alternate);

				this.cb_altresource.SelectedIndex = 0;
			}

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
					this.tb_operation.Enabled = false;
					this.tb_operationpre.Enabled = false;
					this.tb_operationsite.Enabled = false;
					this.tb_resource.Enabled = false;
					this.tb_resourcepre.Enabled = false;
					this.tb_resourcesite.Enabled = false;
					this.tb_routing.Enabled = false;
					this.tb_routingpre.Enabled = false;
					this.nud_operationseq.Enabled = false;
					this.nud_qtyper.Enabled = true;
					this.nud_altpriority.Enabled = false;
					this.cb_altresource.Enabled = false;
					this.cb_resourcetype.Enabled = true;
				} break;
				case 1:
				{
					this.tb_operation.Enabled = false;
					this.tb_operationpre.Enabled = false;
					this.tb_operationsite.Enabled = false;
					this.tb_resource.Enabled = false;
					this.tb_resourcepre.Enabled = false;
					this.tb_resourcesite.Enabled = false;
					this.tb_routing.Enabled = false;
					this.tb_routingpre.Enabled = false;
					this.nud_operationseq.Enabled = false;
					this.nud_qtyper.Enabled = true;
					this.nud_altpriority.Enabled = true;
					this.cb_altresource.Enabled = true;
					this.cb_resourcetype.Enabled = true;
				} break;
				case 99:
				{
					this.tb_operation.Enabled = false;
					this.tb_operationpre.Enabled = false;
					this.tb_operationsite.Enabled = false;
					this.tb_resource.Enabled = false;
					this.tb_resourcepre.Enabled = false;
					this.tb_resourcesite.Enabled = false;
					this.tb_routing.Enabled = false;
					this.tb_routingpre.Enabled = false;
					this.nud_operationseq.Enabled = false;
					this.nud_qtyper.Enabled = true;
					this.nud_altpriority.Enabled = false;
					this.cb_altresource.Enabled = false;
					this.cb_resourcetype.Enabled = false;
				} break;
			} 
		}
		#endregion

		#region setattr
		public override void SetAttr(FLOObj O)
		{
			FLOR2O o = (FLOR2O)O;

			if(!this.cb_resourcetype.Items.Contains(o.R2O_restype))
			{
				this.cb_resourcetype.Items.Add(o.R2O_restype);
				this.cb_resourcetype.SelectedItem = o.R2O_restype;
			}
			
			this.tb_routingpre.Text = o.DNlist(0).Ope_routingpre;
			this.tb_routing.Text = o.DNlist(0).Ope_routing;
			this.tb_operationpre.Text = o.DNlist(0).Ope_operationpre;
			this.tb_operation.Text = o.DNlist(0).Ope_operation;
			this.tb_operationsite.Text = o.DNlist(0).Ope_operationsite;
			this.nud_operationseq.Value = (decimal)o.DNlist(0).Ope_operationseq;

			this.tb_resourcepre.Text = o.UPlist(0).Res_resourcepre;
			this.tb_resource.Text = o.UPlist(0).Res_resource;
			this.tb_resourcesite.Text = o.UPlist(0).Res_resourcesite;
			
			this.cb_altresource.SelectedItem = o.R2O_altresource;
			this.cb_resourcetype.SelectedItem = o.R2O_restype;
			this.nud_altpriority.Value = (decimal)o.R2O_altpriority;
			this.nud_qtyper.Value = (decimal)o.R2O_qtyper;
		}

		private bool init = true;

		public override void SetAttrMulti(FLOObj O)
		{
			FLOR2O o = (FLOR2O)O;

			if(init)
			{
				this.tb_routingpre.Text = o.DNlist(0).Ope_routingpre;
				this.tb_routing.Text = o.DNlist(0).Ope_routing;
				this.tb_operationpre.Text = o.DNlist(0).Ope_operationpre;
				this.tb_operation.Text = o.DNlist(0).Ope_operation;
				this.tb_operationsite.Text = o.DNlist(0).Ope_operationsite;
				this.tb_resourcepre.Text = o.UPlist(0).Res_resourcepre;
				this.tb_resource.Text = o.UPlist(0).Res_resource;
				this.tb_resourcesite.Text = o.UPlist(0).Res_resourcesite;

				this.nud_operationseq.Value = (decimal)o.DNlist(0).Ope_operationseq;
				this.nud_altpriority.Value = (decimal)o.R2O_altpriority;
				this.nud_qtyper.Value = (decimal)o.R2O_qtyper;

				this.cb_altresource.SelectedItem = o.R2O_altresource;
				this.cb_resourcetype.SelectedItem = o.R2O_restype;
			}

			init = false;

			if(this.tb_routingpre.Text != o.DNlist(0).Ope_routingpre)
				this.tb_routingpre.Text = "";
			if(this.tb_routing.Text != o.DNlist(0).Ope_routing)
				this.tb_routing.Text = "";
			if(this.tb_operationpre.Text != o.DNlist(0).Ope_operationpre)
				this.tb_operationpre.Text = "";
			if(this.tb_operation.Text != o.DNlist(0).Ope_operation)
				this.tb_operation.Text = "";
			if(this.tb_operationsite.Text != o.DNlist(0).Ope_operationsite)
				this.tb_operationsite.Text = "";
			if(this.tb_resourcepre.Text != o.UPlist(0).Res_resourcepre)
				this.tb_resourcepre.Text = "";
			if(this.tb_resource.Text != o.UPlist(0).Res_resource)
				this.tb_resource.Text = "";
			if(this.tb_resourcesite.Text != o.UPlist(0).Res_resourcesite)
				this.tb_resourcesite.Text = "";

			if(this.nud_operationseq.Value != (decimal)o.Ope_operationseq)
				this.nud_operationseq.Value = 0;
			if(this.nud_altpriority.Value != (decimal)o.R2O_altpriority)
				this.nud_altpriority.Value = 0;
			if(this.nud_qtyper.Value != (decimal)o.R2O_qtyper)
				this.nud_qtyper.Value = 0;

			if(this.cb_altresource.Text != o.R2O_altresource)
				this.cb_altresource.Text = "";
			if(this.cb_resourcetype.Text != o.R2O_restype.ToString())
				this.cb_resourcetype.Text = "";
		}
		#endregion

		#region getattr
		public override void GetAttr(FLOObj O)
		{
			FLOR2O o = (FLOR2O)O;
						
			if(this.cb_altresource.SelectedItem != null)
				o.R2O_altresource = this.cb_altresource.SelectedItem.ToString();

			o.R2O_restype = (FLOObj.RESTYPE)this.cb_resourcetype.SelectedItem;
			o.R2O_altpriority = (int)this.nud_altpriority.Value;
			o.R2O_qtyper = (int)this.nud_qtyper.Value;
		}

		public override void GetAttrMulti(FLOObj O)
		{
			FLOR2O o = (FLOR2O)O;

			o.R2O_qtyper = (int)this.nud_qtyper.Value;
		}
		#endregion
		
		#region getobj/disname
		public override string GetObjName()
		{
			return this.tb_resourcepre.Text + this.tb_resource.Text + "@" + this.tb_resourcesite.Text + ">>>" + this.tb_operationpre.Text + this.tb_operation.Text + "@" + this.tb_operationsite.Text + "_" + this.nud_operationseq.Value.ToString();
		}
		
		public override string GetDisName()
		{
			return this.nud_qtyper.Value.ToString();
		}

		public override string GetObjName(FLOObj o)
		{
			return o.Objname;
		}
		
		public override string GetDisName(FLOObj o)
		{
			return this.nud_qtyper.Value.ToString();
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

		#region resource type selected index changed
		private void cb_resourcetype_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(FLOObj.RESTYPE.Alternate.Equals(this.cb_resourcetype.SelectedItem))
			{
				this.cb_altresource.Enabled = true;
				this.nud_altpriority.Enabled = true;
			}
			else
			{
				this.cb_altresource.Enabled = false;
				this.nud_altpriority.Enabled = false;
			}
		}	
		#endregion
	}
}

