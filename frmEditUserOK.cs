using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using clsLibIsNum.tmpComp;

namespace CafeManager
{
	/// <summary>
	/// Summary description for frmEditUserOK.
	/// </summary>
	public class frmEditUserOK : frmUser
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		/// 
		private CafeManager.dsSngUsr dsTemp1;
		private DataRowView recordno;
		private System.ComponentModel.Container components = null;

		public frmEditUserOK(CafeManager.dsSngUsr dsTemp1, DataRowView recordno)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.btnAdd.Visible=false;
			this.dsTemp1=dsTemp1;
			this.recordno =recordno;
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
			this.Size = new System.Drawing.Size(304,281);
			this.Text = "  Updates User Information...";
			this.Load += new System.EventHandler(frmEditUserOK_Load);  
		}
		#endregion



		protected override void btnOk_Click(object sender, System.EventArgs e)
		{
			bool boolTemp;

			boolTemp=Validation();
			if (boolTemp==true) return;
			MessageBoxButtons Button = MessageBoxButtons.YesNo ;
			DialogResult result=MessageBox.Show(this,"Confirm updation","Warning",Button,MessageBoxIcon.Exclamation);
			if(result==DialogResult.No) return;

			recordno["Name"]  = txtName.Text.Trim();
			recordno["E-Mail ID"]=txtId.Text.Trim() + "@" + txtSite.Text.Trim();

			if ((txtTimeHrs.Text!="" ) && (txtTimeMin.Text!=""))
				recordno["Total Time"]=txtTimeHrs.Text.Trim() + ":" + txtTimeMin.Text.Trim();
			if ((txtTimeHrs.Text!="" ) && (txtTimeMin.Text==""))
				recordno["Total Time"]=txtTimeHrs.Text.Trim() + ":" + "00";
			if (txtAmount.Text!="")
				recordno["Amount"] = txtAmount.Text.Trim();
 			oleDbDataAdapter1.Update(this.dsTemp1); 
			MessageBox.Show("Database successfully updated !!!");
			this.Close();
 
		}
		
		private void frmEditUserOK_Load(object sender, System.EventArgs e)
		{
			this.txtName.Text =recordno["Name"].ToString() ;
			
			string[] tempArray = new string[2];
			tempArray=recordno["E-Mail ID"].ToString().Split(new char[]{'@'},2) ;
			this.txtId.Text =tempArray[0].ToString();  
			this.txtSite.Text =tempArray[1].ToString();

			this.txtAmount.Text = recordno["Amount"].ToString(); 
			
			string[] tempArray1 = new string[2];
			tempArray1=recordno["Total Time"].ToString().Split(new char[]{':'},2) ;
			this.txtTimeHrs.Text =tempArray1[0].ToString();  
			this.txtTimeMin.Text =tempArray1[1].ToString();
  
		}
		private bool Validation()
		{
			// This part does the validations for textBoxes
			cmpIsNum temp = new cmpIsNum();
									
			if (txtName.Text =="")
			{
				label1.ForeColor=Color.Red ;
				MessageBox.Show(this,"Fields in Red are compulsory","WARNING",MessageBoxButtons.OK ,MessageBoxIcon.Warning); 
				txtName.Focus(); 
				return true;
			}
						
			if ((temp.isNum(txtTimeHrs.Text) == false) || (temp.isNum(txtTimeMin.Text) == false))
			{
				MessageBox.Show(this,"Invalid Time","WARNING",MessageBoxButtons.OK ,MessageBoxIcon.Warning); 
				txtTimeHrs.Clear();
				txtTimeMin.Clear(); 
				txtTimeHrs.Focus();
				return true;
			}

			if (temp.isNum(txtAmount.Text)==false)
			{
				MessageBox.Show(this,"Invalid Amount","WARNING",MessageBoxButtons.OK ,MessageBoxIcon.Warning); 
				txtAmount.Clear();
				txtAmount.Focus();
				return true;
			}    
			return false;  
		}



	}
}
