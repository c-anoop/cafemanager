using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CafeManager
{
	/// <summary>
	/// Summary description for frmEditUser.
	/// </summary>
	/// 
	
	public class frmEditUser : frmViewSngUsr
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		/// 
		private System.ComponentModel.Container components = null;

		public frmEditUser()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.btnCancel.Visible =true;
			this.btnOK.Location =new System.Drawing.Point(128,320);
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			// 
			// frmEditUser
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(318, 363);
			this.Name = "frmEditUser";
			this.Text = "  Single User Search...";

		}
		#endregion

		protected override void btnOK_Click(object sender, System.EventArgs e)
		{
            
			if(lblName.Text !="")
			{
				frmEditUserOK frmTemp=new frmEditUserOK(this.dsSngUsr1,this.intTemp2);
				frmTemp.ShowDialog();
			}
			else
			{
				MessageBox.Show(this,"No Record Selected","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				this.txtUsrName.Focus();
			}
							
		}

		protected override void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

	}

}
