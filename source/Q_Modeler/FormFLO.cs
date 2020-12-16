using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Q_Modeler
{
	/// <summary>
	/// FormFLO에 대한 요약 설명입니다.
	/// </summary>
	public class FormFLO : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		#region initializer
		public FormFLO()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
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
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(22, 224);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 32);
			this.button1.TabIndex = 99;
			this.button1.Text = "Save";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(150, 224);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 32);
			this.button2.TabIndex = 100;
			this.button2.Text = "Cancle";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// FormFLO
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormFLO";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FLO";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFLO_KeyDown);
			this.ResumeLayout(false);

		}
		#endregion

		#region set/get attr
		public virtual void SetAttr(FLOObj o)
		{
		}
		
		public virtual void GetAttr(FLOObj o)
		{
		}

		public virtual void SetAttrMulti(FLOObj o)
		{
		}
		
		public virtual void GetAttrMulti(FLOObj o)
		{
		}
		#endregion

		#region lockedform
		public virtual void LockedForm(int locktype)
		{
		}
		#endregion
		
		#region get obj/disname
		public virtual string GetObjName()
		{
			return null;
		}
		
		public virtual string GetDisName()
		{
			return null;
		}
		
		public virtual string GetDisName(FLOObj o)
		{
			return GetDisName();
		}

		public virtual string GetObjName(FLOObj o)
		{
			return GetObjName();
		}
		#endregion

		#region check logic
		public virtual bool CheckFormLogic()
		{
			return false;
		}
		#endregion

		#region button click
		public virtual void button1_Click(object sender, System.EventArgs e)
		{		
		}

		public virtual void button2_Click(object sender, System.EventArgs e)
		{		
		}
		#endregion

		#region keydown
		private void FormFLO_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch(e.KeyData)
			{
				case Keys.Escape:
					this.button2_Click(sender,e);
					break;
				case Keys.Enter:
				{
					this.DialogResult = DialogResult.OK;
					this.button1_Click(sender,e);
					break;
				}
			}
		}
		#endregion
	}
}
