using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Q_Modeler
{
	public class FormFLORes : Q_Modeler.FormFLO
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_resourcepre;
		private System.Windows.Forms.TextBox tb_resource;
		private System.Windows.Forms.TextBox tb_resourcesite;
		private System.ComponentModel.IContainer components = null;

		#region initializer
		public FormFLORes()
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
			this.tb_resourcepre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_resource = new System.Windows.Forms.TextBox();
			this.tb_resourcesite = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tb_resourcepre
			// 
			this.tb_resourcepre.Enabled = false;
			this.tb_resourcepre.Location = new System.Drawing.Point(86, 32);
			this.tb_resourcepre.Name = "tb_resourcepre";
			this.tb_resourcepre.Size = new System.Drawing.Size(34, 21);
			this.tb_resourcepre.TabIndex = 1;
			this.tb_resourcepre.TabStop = false;
			this.tb_resourcepre.Text = "";
			this.tb_resourcepre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(22, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Resc.Site";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Resource";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_resource
			// 
			this.tb_resource.Location = new System.Drawing.Point(120, 32);
			this.tb_resource.Name = "tb_resource";
			this.tb_resource.Size = new System.Drawing.Size(152, 21);
			this.tb_resource.TabIndex = 0;
			this.tb_resource.Text = "";
			this.tb_resource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_resourcesite
			// 
			this.tb_resourcesite.Location = new System.Drawing.Point(88, 64);
			this.tb_resourcesite.Name = "tb_resourcesite";
			this.tb_resourcesite.Size = new System.Drawing.Size(184, 21);
			this.tb_resourcesite.TabIndex = 1;
			this.tb_resourcesite.Text = "";
			this.tb_resourcesite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormFLORes
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.tb_resourcepre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_resource);
			this.Controls.Add(this.tb_resourcesite);
			this.Name = "FormFLORes";
			this.Controls.SetChildIndex(this.tb_resourcesite, 0);
			this.Controls.SetChildIndex(this.tb_resource, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.tb_resourcepre, 0);
			this.ResumeLayout(false);

		}
		#endregion

		#region initizlizer
		public FormFLORes(int locktype)
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
					this.tb_resourcepre.Enabled = false;
					this.tb_resource.Enabled = true;
					this.tb_resourcesite.Enabled = true;
				} break;
				case 1:
				{
					this.tb_resourcepre.Enabled = false;
					this.tb_resource.Enabled = false;
					this.tb_resourcesite.Enabled = false;
				} break;
				case 99:
				{
					this.tb_resourcepre.Enabled = false;
					this.tb_resource.Enabled = false;
				} break;
			}
		}
		#endregion

		#region setattr
		public override void SetAttr(FLOObj O)
		{
			FLORes o = (FLORes)O;

			this.tb_resourcepre.Text = o.Res_resourcepre;
			this.tb_resource.Text = o.Res_resource;
			this.tb_resourcesite.Text = o.Res_resourcesite;
		}

		private bool init = true;

		public override void SetAttrMulti(FLOObj O)
		{
			FLORes o = (FLORes)O;

			if(init)
			{
				this.tb_resourcepre.Text = o.Res_resourcepre;
				this.tb_resource.Text = o.Res_resource;
				this.tb_resourcesite.Text = o.Res_resourcesite;	
			}

			init = false;

			if(this.tb_resourcepre.Text != o.Res_resourcepre)
				this.tb_resourcepre.Text = "";
			if(this.tb_resource.Text != o.Res_resource)
				this.tb_resource.Text = "";
			if(this.tb_resourcesite.Text != o.Res_resourcesite)
				this.tb_resourcesite.Text = "";
		}
		#endregion

		#region getattr
		public override void GetAttr(FLOObj O)
		{			
			FLORes o = (FLORes)O;

			o.Res_resourcepre = this.tb_resourcepre.Text;
			o.Res_resource = this.tb_resource.Text;
			o.Res_resourcesite = this.tb_resourcesite.Text;
		}

		public override void GetAttrMulti(FLOObj O)
		{			
			FLORes o = (FLORes)O;

			o.Res_resourcesite = this.tb_resourcesite.Text;
		}
		#endregion
		
		#region getobj/disname
		public override string GetObjName()
		{
			return this.tb_resourcepre.Text + this.tb_resource.Text + "@" + this.tb_resourcesite.Text;
		}
		
		public override string GetDisName()
		{
			return this.tb_resource.Text;
		}

		public override string GetObjName(FLOObj o)
		{
			return o.Res_resourcepre + o.Res_resource + "@" + this.tb_resourcesite.Text;
		}

		public override string GetDisName(FLOObj o)
		{
			return o.Res_resource;
		}
		#endregion

		#region checkformlogic
		public override bool CheckFormLogic()
		{
			if(this.tb_resource.Text.Length < 1)
				return true;

			if(this.tb_resourcesite.Text.Length < 1)
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

