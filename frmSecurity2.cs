using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CafeManager
{
	/// <summary>
	/// Summary description for frmSecurity2.
	/// </summary>
	public class frmSecurity2 : frmSecurity
	{
	    /// <summary>
		/// Required designer variable.
		/// </summary>
		/// 
        private System.Windows.Forms.Timer tempTimer;   
		private System.ComponentModel.Container components = null;
       
		public static int temp1;
		
		public frmSecurity2()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
			this.tempTimer = new System.Windows.Forms.Timer(); 
			// 
			// frmSecurity2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(234,152);
			this.Name = "frmSecurity2";
			this.Text = "  Checking Permissions...";

			this.tempTimer.Tick += new System.EventHandler(this.tempTimer_Tick);      

		}
		#endregion

		protected override void frmSecurity_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{  
			this.Close();
		}
		protected override void btnOk_Click(object sender, System.EventArgs e)
		{   
			tempTimer.Interval= 1000;
 
			DataView dtvTemp1 = new DataView(dsSecurity1.SwUsers,"","User Id",DataViewRowState.CurrentRows);
			int intTemp1=dtvTemp1.Find(txtId.Text );
			
			if (intTemp1==-1 || dsSecurity1.SwUsers.Rows[intTemp1]["PassCode"].ToString()!=txtPassCode.Text)
			{
				txtId.Clear();
				txtPassCode.Clear();
				label1.Visible =true;
				txtId.Focus();
			}
			else
			{
				label1.Visible = true;
				temp1=intTemp1;
				label1.Text = "Access Granted !!!";
				this.Tag="Access Granted";
				tempTimer.Start(); 
		     }
		}

		protected override void timer1_Tick(object sender, System.EventArgs e)
		{
			//udana mat
			
		}
		private void tempTimer_Tick(object sender, System.EventArgs e)
		{
			tempTimer.Stop();
			this.Close();
		}

	
	}

}
