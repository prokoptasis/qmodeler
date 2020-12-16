using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Q_Modeler
{
	public class FormFLOBuf : Q_Modeler.FormFLO
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_item;
		private System.Windows.Forms.TextBox tb_site;
		private System.Windows.Forms.TextBox tb_stage;
		private System.Windows.Forms.CheckBox ck_sellable;
		private System.Windows.Forms.CheckBox ck_isresponsebuffer;
		private System.Windows.Forms.CheckBox ck_isproductionplanbuffer;
		private System.ComponentModel.IContainer components = null;

		#region initializer
		public FormFLOBuf()
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
			this.ck_sellable = new System.Windows.Forms.CheckBox();
			this.ck_isresponsebuffer = new System.Windows.Forms.CheckBox();
			this.ck_isproductionplanbuffer = new System.Windows.Forms.CheckBox();
			this.tb_item = new System.Windows.Forms.TextBox();
			this.tb_site = new System.Windows.Forms.TextBox();
			this.tb_stage = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Item";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Site";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "Stage";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ck_sellable
			// 
			this.ck_sellable.Location = new System.Drawing.Point(40, 92);
			this.ck_sellable.Name = "ck_sellable";
			this.ck_sellable.Size = new System.Drawing.Size(232, 21);
			this.ck_sellable.TabIndex = 2;
			this.ck_sellable.Text = "Sellable";
			// 
			// ck_isresponsebuffer
			// 
			this.ck_isresponsebuffer.Location = new System.Drawing.Point(40, 122);
			this.ck_isresponsebuffer.Name = "ck_isresponsebuffer";
			this.ck_isresponsebuffer.Size = new System.Drawing.Size(232, 21);
			this.ck_isresponsebuffer.TabIndex = 3;
			this.ck_isresponsebuffer.Text = "IsResponseBuffer";
			// 
			// ck_isproductionplanbuffer
			// 
			this.ck_isproductionplanbuffer.Location = new System.Drawing.Point(40, 152);
			this.ck_isproductionplanbuffer.Name = "ck_isproductionplanbuffer";
			this.ck_isproductionplanbuffer.Size = new System.Drawing.Size(232, 21);
			this.ck_isproductionplanbuffer.TabIndex = 4;
			this.ck_isproductionplanbuffer.Text = "IsProductionPlanBuffer";
			// 
			// tb_item
			// 
			this.tb_item.Location = new System.Drawing.Point(88, 32);
			this.tb_item.Name = "tb_item";
			this.tb_item.Size = new System.Drawing.Size(184, 21);
			this.tb_item.TabIndex = 0;
			this.tb_item.Text = "";
			this.tb_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_site
			// 
			this.tb_site.Location = new System.Drawing.Point(88, 64);
			this.tb_site.Name = "tb_site";
			this.tb_site.Size = new System.Drawing.Size(184, 21);
			this.tb_site.TabIndex = 0;
			this.tb_site.Text = "";
			this.tb_site.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_stage
			// 
			this.tb_stage.Location = new System.Drawing.Point(88, 184);
			this.tb_stage.Name = "tb_stage";
			this.tb_stage.Size = new System.Drawing.Size(184, 21);
			this.tb_stage.TabIndex = 0;
			this.tb_stage.Text = "";
			this.tb_stage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormFLOBuf
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ck_sellable);
			this.Controls.Add(this.ck_isresponsebuffer);
			this.Controls.Add(this.ck_isproductionplanbuffer);
			this.Controls.Add(this.tb_item);
			this.Controls.Add(this.tb_site);
			this.Controls.Add(this.tb_stage);
			this.Name = "FormFLOBuf";
			this.Controls.SetChildIndex(this.tb_stage, 0);
			this.Controls.SetChildIndex(this.tb_site, 0);
			this.Controls.SetChildIndex(this.tb_item, 0);
			this.Controls.SetChildIndex(this.ck_isproductionplanbuffer, 0);
			this.Controls.SetChildIndex(this.ck_isresponsebuffer, 0);
			this.Controls.SetChildIndex(this.ck_sellable, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.ResumeLayout(false);

		}
		#endregion

		#region initilizer
		public FormFLOBuf(int locktype)
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
					this.tb_item.Enabled = true;
					this.tb_site.Enabled = true;
					this.tb_stage.Enabled = true;
					this.ck_sellable.Enabled = true;
					this.ck_isresponsebuffer.Enabled = true;
					this.ck_isproductionplanbuffer.Enabled = true;
				} break;
				case 1:
				{
					this.tb_item.Enabled = false;
					this.tb_site.Enabled = false;
					this.tb_stage.Enabled = true;
					this.ck_sellable.Enabled = true;
					this.ck_isresponsebuffer.Enabled = true;
					this.ck_isproductionplanbuffer.Enabled = true;
				} break;
				case 2:
				{
					this.tb_item.Enabled = false;
					this.tb_site.Enabled = false;
					this.tb_stage.Enabled = true;
					this.ck_sellable.Enabled = false;
					this.ck_isresponsebuffer.Enabled = true;
					this.ck_isproductionplanbuffer.Enabled = true;
				} break;
				case 98:
				{
					this.tb_item.Enabled = false;
					this.tb_stage.Enabled = true;
					this.ck_sellable.Enabled = false;
					this.ck_isresponsebuffer.Enabled = true;
					this.ck_isproductionplanbuffer.Enabled = true;
				} break;
				case 99:
				{
					this.tb_item.Enabled = false;
					this.tb_stage.Enabled = true;
					this.ck_sellable.Enabled = true;
					this.ck_isresponsebuffer.Enabled = true;
					this.ck_isproductionplanbuffer.Enabled = true;
				} break;
			}
		}
		#endregion

		#region setattribute
		public override void SetAttr(FLOObj O)
		{
			FLOBuf o = (FLOBuf)O;
			this.tb_item.Text = o.Buf_item;
			this.tb_site.Text = o.Buf_site;
			this.tb_stage.Text = o.Buf_stage;
			this.ck_sellable.Checked = o.Buf_sellable == 1?true:false;
			this.ck_isresponsebuffer.Checked = o.Buf_isresponsebuffer == 1?true:false;
			this.ck_isproductionplanbuffer.Checked = o.Buf_isproductionplanbuffer == 1?true:false; 
		}

		private bool init = true;

		public override void SetAttrMulti(FLOObj O)
		{
			FLOBuf o = (FLOBuf)O;

			if(init)
			{
				this.tb_item.Text = o.Buf_item;
				this.tb_site.Text = o.Buf_site;
				this.tb_stage.Text = o.Buf_stage;
				this.ck_sellable.Checked = o.Buf_sellable == 1?true:false;
				this.ck_isresponsebuffer.Checked = o.Buf_isresponsebuffer == 1?true:false;
				this.ck_isproductionplanbuffer.Checked = o.Buf_isproductionplanbuffer == 1?true:false; 
			}

			init = false;

			if(this.tb_item.Text != o.Buf_item)
				this.tb_item.Text = "";
			if(this.tb_site.Text != o.Buf_site)
				this.tb_site.Text = "";
			if(this.tb_stage.Text != o.Buf_stage)
				this.tb_stage.Text = "";
			if(this.ck_sellable.Checked != (o.Buf_sellable == 1?true:false))
				this.ck_sellable.Checked = false;
			if(this.ck_isresponsebuffer.Checked != (o.Buf_isresponsebuffer == 1?true:false))
				this.ck_isresponsebuffer.Checked = true;
			if(this.ck_isproductionplanbuffer.Checked != (o.Buf_isproductionplanbuffer == 1?true:false))
				ck_isproductionplanbuffer.Checked = true;
		}
		#endregion

		#region getattribute
		public override void GetAttr(FLOObj O)
		{			
			FLOBuf o = (FLOBuf)O;
			o.Buf_item = this.tb_item.Text;
			o.Buf_site = this.tb_site.Text;
			o.Buf_stage = this.tb_stage.Text;
			o.Buf_sellable = this.ck_sellable.Checked == true?1:0;
			o.Buf_isresponsebuffer = this.ck_isresponsebuffer.Checked == true?1:0;
			o.Buf_isproductionplanbuffer = this.ck_isproductionplanbuffer.Checked == true?1:0;
		}

		public override void GetAttrMulti(FLOObj O)
		{			
			FLOBuf o = (FLOBuf)O;
			o.Buf_site = this.tb_site.Text;
			o.Buf_stage = this.tb_stage.Text;
			if(this.ck_sellable.Enabled == true)
				o.Buf_sellable = this.ck_sellable.Checked == true?1:0;
			o.Buf_isresponsebuffer = this.ck_isresponsebuffer.Checked == true?1:0;
			o.Buf_isproductionplanbuffer = this.ck_isproductionplanbuffer.Checked == true?1:0;
		}
		#endregion
	
		#region checkformlogic
		public override bool CheckFormLogic()
		{
			if(this.tb_item.Text.Length < 1)
				return true;

			if(this.tb_site.Text.Length < 1)
				return true;

			return false;
		}
		#endregion
	
		#region getobj/disname
		public override string GetObjName()
		{
			return this.tb_item.Text + "@" + this.tb_site.Text;
		}

		public override string GetObjName(FLOObj o)
		{
			return o.Buf_item + "@" + this.tb_site.Text;
		}
		
		public override string GetDisName()
		{
			return this.tb_item.Text;
		}
		
		public override string GetDisName(FLOObj o)
		{
			return o.Buf_item;
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

