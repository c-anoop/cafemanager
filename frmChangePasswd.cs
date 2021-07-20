using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CafeManager
{
	/// <summary>
	/// Summary description for frmChangePasswd.
	/// </summary>
	public class frmChangePasswd : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtConfPass;
		private System.Windows.Forms.TextBox txtNewPass;
		private System.Windows.Forms.TextBox txtOldPass;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblPass;
		private string tempPass1;
		private bool tempPass3;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;

		public frmChangePasswd(string tempPass)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			tempPass1=tempPass;
		}

		/// <summary>
		/// Clean up any resources being used.
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmChangePasswd));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtConfPass = new System.Windows.Forms.TextBox();
			this.txtNewPass = new System.Windows.Forms.TextBox();
			this.txtOldPass = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblPass = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.txtConfPass,
																					this.txtNewPass,
																					this.txtOldPass,
																					this.btnCancel,
																					this.btnOK,
																					this.label3,
																					this.label2,
																					this.label1,
																					this.lblPass});
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(240, 160);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Required information :";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// txtConfPass
			// 
			this.txtConfPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtConfPass.Location = new System.Drawing.Point(128, 72);
			this.txtConfPass.Name = "txtConfPass";
			this.txtConfPass.PasswordChar = '*';
			this.txtConfPass.Size = new System.Drawing.Size(96, 20);
			this.txtConfPass.TabIndex = 2;
			this.txtConfPass.Text = "";
			this.txtConfPass.TextChanged += new System.EventHandler(this.txtConfPass_TextChanged);
			// 
			// txtNewPass
			// 
			this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNewPass.Location = new System.Drawing.Point(128, 48);
			this.txtNewPass.Name = "txtNewPass";
			this.txtNewPass.PasswordChar = '*';
			this.txtNewPass.Size = new System.Drawing.Size(96, 20);
			this.txtNewPass.TabIndex = 1;
			this.txtNewPass.Text = "";
			this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
			// 
			// txtOldPass
			// 
			this.txtOldPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtOldPass.Location = new System.Drawing.Point(128, 24);
			this.txtOldPass.Name = "txtOldPass";
			this.txtOldPass.PasswordChar = '*';
			this.txtOldPass.Size = new System.Drawing.Size(96, 20);
			this.txtOldPass.TabIndex = 0;
			this.txtOldPass.Text = "";
			this.txtOldPass.TextChanged += new System.EventHandler(this.txtOldPass_TextChanged);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCancel.Location = new System.Drawing.Point(152, 104);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(72, 24);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOK.Location = new System.Drawing.Point(64, 104);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(72, 24);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "&OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Confirm PassCode  :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "New PassCode      :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Old PassCode        :";
			// 
			// lblPass
			// 
			this.lblPass.Location = new System.Drawing.Point(8, 136);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(224, 13);
			this.lblPass.TabIndex = 1;
			this.lblPass.Text = "Old PassCode Incorrect !!!";
			this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblPass.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 2000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// frmChangePasswd
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.MediumPurple;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(256, 168);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChangePasswd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "  Change PassCode...";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmChangePasswd_Closing);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if(tempPass1!=this.txtOldPass.Text)
			{
				this.lblPass.Text="Old PassCode Incorrect!!!";
				this.txtOldPass.Clear();
				this.lblPass.Visible =true;
				this.txtOldPass.Focus();
				return;
			}
			if(this.txtNewPass.Text!=this.txtConfPass.Text)
			{
				this.lblPass.Text ="New PassCode doesn't match!!!";
				this.txtNewPass.Clear();
				this.txtConfPass.Clear();
				this.lblPass.Visible =true;
				this.txtNewPass.Focus();
				return;
			}
			if(txtNewPass.Text.Length <4)
			{
				this.lblPass.Text ="Minimum PassCode Limit is 4 characters!!!";
				this.txtNewPass.Clear();
				this.txtConfPass.Clear();
				this.lblPass.Visible =true;
				this.txtNewPass.Focus();
				return;
			}
			tempPass3=true;
			this.lblPass.Visible=true; 
			this.lblPass.Text="PassCode successfully changed !!!"; 
		    timer1.Start();  

		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmChangePasswd_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(tempPass3)
			this.Tag=this.txtNewPass.Text.Trim();
			else
			this.Tag="Password Not Selected";
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void txtOldPass_TextChanged(object sender, System.EventArgs e)
		{
			this.lblPass.Visible=false;

		}

		private void txtNewPass_TextChanged(object sender, System.EventArgs e)
		{
		this.lblPass.Visible=false;
		}

		private void txtConfPass_TextChanged(object sender, System.EventArgs e)
		{
			this.lblPass.Visible=false;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			timer1.Stop();
			this.Close();
		}
	}
}
