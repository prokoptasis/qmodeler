using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Q_Modeler
{
	public class FormFLOOpe : Q_Modeler.FormFLO
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_operationpre;
		private System.Windows.Forms.TextBox tb_operation;
		private System.Windows.Forms.TextBox tb_operationsite;
		private System.Windows.Forms.TextBox tb_routingpre;
		private System.Windows.Forms.TextBox tb_routing;
		private System.Windows.Forms.NumericUpDown nud_operationseq;
		private System.Windows.Forms.NumericUpDown nud_runtime;
		private System.Windows.Forms.NumericUpDown nud_releasefence;
		private System.ComponentModel.IContainer components = null;

		#region initializer
		public FormFLOOpe()
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
			this.tb_operationpre = new System.Windows.Forms.TextBox();
			this.tb_operation = new System.Windows.Forms.TextBox();
			this.tb_operationsite = new System.Windows.Forms.TextBox();
			this.tb_routingpre = new System.Windows.Forms.TextBox();
			this.tb_routing = new System.Windows.Forms.TextBox();
			this.nud_operationseq = new System.Windows.Forms.NumericUpDown();
			this.nud_runtime = new System.Windows.Forms.NumericUpDown();
			this.nud_releasefence = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nud_operationseq)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_runtime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_releasefence)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Operation";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "OperationSite";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "Routing";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 21);
			this.label4.TabIndex = 1;
			this.label4.Text = "Avg.FixedRT";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 21);
			this.label5.TabIndex = 1;
			this.label5.Text = "Rel.Fence";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_operationpre
			// 
			this.tb_operationpre.Enabled = false;
			this.tb_operationpre.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_operationpre.Location = new System.Drawing.Point(104, 40);
			this.tb_operationpre.Name = "tb_operationpre";
			this.tb_operationpre.Size = new System.Drawing.Size(32, 21);
			this.tb_operationpre.TabIndex = 0;
			this.tb_operationpre.TabStop = false;
			this.tb_operationpre.Text = "";
			this.tb_operationpre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_operation
			// 
			this.tb_operation.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_operation.Location = new System.Drawing.Point(136, 40);
			this.tb_operation.Name = "tb_operation";
			this.tb_operation.Size = new System.Drawing.Size(136, 21);
			this.tb_operation.TabIndex = 0;
			this.tb_operation.Text = "";
			this.tb_operation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_operationsite
			// 
			this.tb_operationsite.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_operationsite.Location = new System.Drawing.Point(104, 72);
			this.tb_operationsite.Name = "tb_operationsite";
			this.tb_operationsite.Size = new System.Drawing.Size(128, 21);
			this.tb_operationsite.TabIndex = 1;
			this.tb_operationsite.Text = "";
			this.tb_operationsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_routingpre
			// 
			this.tb_routingpre.Enabled = false;
			this.tb_routingpre.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_routingpre.Location = new System.Drawing.Point(104, 104);
			this.tb_routingpre.Name = "tb_routingpre";
			this.tb_routingpre.Size = new System.Drawing.Size(32, 21);
			this.tb_routingpre.TabIndex = 0;
			this.tb_routingpre.TabStop = false;
			this.tb_routingpre.Text = "";
			this.tb_routingpre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_routing
			// 
			this.tb_routing.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.tb_routing.Location = new System.Drawing.Point(136, 104);
			this.tb_routing.Name = "tb_routing";
			this.tb_routing.Size = new System.Drawing.Size(136, 21);
			this.tb_routing.TabIndex = 2;
			this.tb_routing.Text = "";
			this.tb_routing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_operationseq
			// 
			this.nud_operationseq.Location = new System.Drawing.Point(232, 72);
			this.nud_operationseq.Name = "nud_operationseq";
			this.nud_operationseq.Size = new System.Drawing.Size(40, 21);
			this.nud_operationseq.TabIndex = 3;
			this.nud_operationseq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_runtime
			// 
			this.nud_runtime.Location = new System.Drawing.Point(104, 136);
			this.nud_runtime.Name = "nud_runtime";
			this.nud_runtime.Size = new System.Drawing.Size(168, 21);
			this.nud_runtime.TabIndex = 4;
			this.nud_runtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nud_releasefence
			// 
			this.nud_releasefence.Location = new System.Drawing.Point(104, 168);
			this.nud_releasefence.Name = "nud_releasefence";
			this.nud_releasefence.Size = new System.Drawing.Size(168, 21);
			this.nud_releasefence.TabIndex = 5;
			this.nud_releasefence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormFLOOpe
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.nud_operationseq);
			this.Controls.Add(this.tb_operationpre);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tb_operation);
			this.Controls.Add(this.tb_operationsite);
			this.Controls.Add(this.tb_routingpre);
			this.Controls.Add(this.tb_routing);
			this.Controls.Add(this.nud_runtime);
			this.Controls.Add(this.nud_releasefence);
			this.Name = "FormFLOOpe";
			this.Controls.SetChildIndex(this.nud_releasefence, 0);
			this.Controls.SetChildIndex(this.nud_runtime, 0);
			this.Controls.SetChildIndex(this.tb_routing, 0);
			this.Controls.SetChildIndex(this.tb_routingpre, 0);
			this.Controls.SetChildIndex(this.tb_operationsite, 0);
			this.Controls.SetChildIndex(this.tb_operation, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.tb_operationpre, 0);
			this.Controls.SetChildIndex(this.nud_operationseq, 0);
			((System.ComponentModel.ISupportInitialize)(this.nud_operationseq)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_runtime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_releasefence)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region initizlizer
		public FormFLOOpe(int locktype)
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
					this.tb_operationpre.Enabled = false;
					this.tb_operation.Enabled = true;
					this.tb_operationsite.Enabled = true;
					this.tb_routingpre.Enabled = false;
					this.tb_routing.Enabled = true;
					this.nud_operationseq.Enabled = true;
					this.nud_releasefence.Enabled = true;
					this.nud_runtime.Enabled = true;
				} break;
				case 1:
				{
					this.tb_operationpre.Enabled = false;
					this.tb_operation.Enabled = false;
					this.tb_operationsite.Enabled = false;
					this.tb_routingpre.Enabled = false;
					this.tb_routing.Enabled = false;
					this.nud_operationseq.Enabled = false;
					this.nud_releasefence.Enabled = true;
					this.nud_runtime.Enabled = true;
				} break;
				case 99:
				{
					this.tb_operationpre.Enabled = false;
					this.tb_operation.Enabled = false;
					this.tb_operationsite.Enabled = true;
					this.nud_operationseq.Enabled = false;
					this.tb_routingpre.Enabled = false;
					this.tb_routing.Enabled = true;
					this.nud_releasefence.Enabled = true;
					this.nud_runtime.Enabled = true;
				} break;
			}
		}
		#endregion

		#region setattr
		public override void SetAttr(FLOObj O)
		{
			FLOOpe o = (FLOOpe)O;

			this.tb_operationpre.Text = o.Ope_operationpre;
			this.tb_operation.Text = o.Ope_operation;
			this.tb_operationsite.Text = o.Ope_operationsite;
			this.tb_routingpre.Text = o.Ope_routingpre;
			this.tb_routing.Text = o.Ope_routing;
			this.nud_operationseq.Value = (decimal)o.Ope_operationseq;
			this.nud_runtime.Value = (decimal)o.Ope_runtime;
			this.nud_releasefence.Value = (decimal)o.Ope_releasefence;
		}

		private bool init = true;

		public override void SetAttrMulti(FLOObj O)
		{
			FLOOpe o = (FLOOpe)O;

			if(init)
			{
				this.tb_operationpre.Text = o.Ope_operationpre;
				this.tb_operation.Text = o.Ope_operation;
				this.tb_operationsite.Text = o.Ope_operationsite;
				this.tb_routingpre.Text = o.Ope_routingpre;
				this.tb_routing.Text = o.Ope_routing;
				this.nud_operationseq.Value = (decimal)o.Ope_operationseq;
				this.nud_runtime.Value = (decimal)o.Ope_runtime;
				this.nud_releasefence.Value = (decimal)o.Ope_releasefence;			
			}

			init = false;

			if(this.tb_operationpre.Text != o.Ope_operationpre)
				this.tb_operationpre.Text = "";
			if(this.tb_operation.Text != o.Ope_operation)
				this.tb_operation.Text = "";
			if(this.tb_operationsite.Text != o.Ope_operationsite)
				this.tb_operationsite.Text = "";
			if(this.tb_operationpre.Text != o.Ope_routingpre)
				this.tb_operationpre.Text = "";
			if(this.tb_routing.Text != o.Ope_routing)
				this.tb_routing.Text = "";
			if(this.nud_operationseq.Value != (decimal)o.Ope_operationseq)
				this.nud_operationseq.Value = 0;
			if(this.nud_runtime.Value != (decimal)o.Ope_runtime)
				this.nud_runtime.Value = 0;
			if(this.nud_releasefence.Value != (decimal)o.Ope_releasefence)
				this.nud_releasefence.Value = 0;

		}
		#endregion

		#region getattr
		public override void GetAttr(FLOObj O)
		{			
			FLOOpe o = (FLOOpe)O;

			o.Ope_operationpre = this.tb_operationpre.Text;
			o.Ope_operation = this.tb_operation.Text;
			o.Ope_operationsite = this.tb_operationsite.Text;
			o.Ope_routingpre = this.tb_routingpre.Text;
			o.Ope_routing = this.tb_routing.Text;
			o.Ope_operationseq = (int)this.nud_operationseq.Value;
			o.Ope_runtime = (int)this.nud_runtime.Value;
			o.Ope_releasefence = (int)this.nud_releasefence.Value;
		}

		public override void GetAttrMulti(FLOObj O)
		{			
			FLOOpe o = (FLOOpe)O;

			o.Ope_operationsite = this.tb_operationsite.Text;
			o.Ope_routingpre = this.tb_routingpre.Text;
			o.Ope_routing = this.tb_routing.Text;
			o.Ope_runtime = (int)this.nud_runtime.Value;
			o.Ope_releasefence = (int)this.nud_releasefence.Value;
		}
		#endregion
		
		#region getobj/disname
		public override string GetObjName()
		{
			return this.tb_operationpre.Text + this.tb_operation.Text + "@" + this.tb_operationsite.Text + "_" + this.nud_operationseq.Value.ToString();
		}
		
		public override string GetDisName()
		{
			return this.tb_operation.Text;
		}

		public override string GetObjName(FLOObj o)
		{
			return o.Ope_operationpre + o.Ope_operation + "@" + this.tb_operationsite.Text + "_" + o.Ope_operationseq.ToString();
		}

		public override string GetDisName(FLOObj o)
		{
			return o.Ope_operation;
		}
		#endregion

		#region checkformlogic
		public override bool CheckFormLogic()
		{
			if(this.tb_operation.Text.Length < 1)
				return true;

			if(this.tb_operationsite.Text.Length < 1)
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
	}
}

