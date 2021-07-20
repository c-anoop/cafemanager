using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CafeManager
{
	/// <summary>
	/// Summary description for frmEditMem.
	/// </summary>
	public class frmEditMem : frmViewSngMem
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmEditMem()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			
			this.btnCancel.Visible =true; 
			this.btnOk.Location = new System.Drawing.Point(160,352);
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
			this.Size = new System.Drawing.Size(374,430);
			this.Text = "  Single Member Search ... ";
		}
		#endregion


		protected override void btnOk_Click(object sender, System.EventArgs e)
		{
			if(lblName.Text!="")
			{
				frmEditMemOK frmTemp=new frmEditMemOK(this.recNo,this.dsMem1);
				frmTemp.Show();
			}
			else
			{
				MessageBox.Show(this,"No Record Selected","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				this.txtMemName.Focus();
			}
					
		}

		protected override void btnCancel_Click(object sender, System.EventArgs e)
		{
		   this.Close();
		}


	}
}
