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
	/// Summary description for frmEditMemOK.
	/// </summary>
	public class frmEditMemOK : frmMem
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		/// 
		private DataRowView RecordNo;
		private CafeManager.dsMem dsTemp1; 
		private System.ComponentModel.Container components = null;
        
		public frmEditMemOK(DataRowView recNo, CafeManager.dsMem dsTemp1 )
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.dsTemp1=dsTemp1; 
            RecordNo=recNo;
			oleDbDataAdapter1.Fill(dsTemp1);
			 
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
			this.Size = new System.Drawing.Size(380,469);
			this.Text = "  Updates Member Informaton";
			this.Load += new System.EventHandler(this.Form_Load);  
		}
		#endregion

		private new bool Validation()
		{
			bool boolTemp=false;
			//
			// This part checks the proper entry of the Record
			// 
			if (txtName.Text=="")
			{  
				boolTemp=true;
				label1.ForeColor =Color.Red;
			}
			if (txtAmtPaid.Text=="")
			{
				label10.ForeColor =Color.Red;
				boolTemp=true;
			}

			if (txtAdd.Text=="") 
			{
				label2.ForeColor =Color.Red;
				boolTemp=true;
			}

			if (txtPassCode.Text=="")
			{
				label8.ForeColor =Color.Red;
				boolTemp=true;
			}
			if (txtUsrId.Text=="")
			{
				label7.ForeColor =Color.Red;
				boolTemp=true;
			}

			if (txtConfirmPassCode.Text=="")
			{
				label9.ForeColor =Color.Red;
				boolTemp=true;
			}

			if (boolTemp==true)
			{
				MessageBox.Show("Fields in Red are needed","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning );
				boolTemp=false;
				if(label2.ForeColor==Color.Red)  txtAdd.Focus();
				if(label10.ForeColor==Color.Red)  txtAmtPaid.Focus();
				if(label9.ForeColor==Color.Red)  txtConfirmPassCode.Focus();
				if(label8.ForeColor==Color.Red)  txtPassCode.Focus();
				if(label7.ForeColor==Color.Red)  txtUsrId.Focus();
				if(label1.ForeColor==Color.Red)  txtName.Focus();
				return true;
			}
			
			
			if (txtPassCode.Text != txtConfirmPassCode.Text)
			{
				MessageBox.Show("Error in PassCode","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				this.txtPassCode.Clear(); 
				this.txtConfirmPassCode.Clear();
				this.txtPassCode.Focus();
				return true;
			} 

			cmpIsNum temp = new cmpIsNum();

			if (temp.isNumric(txtAmtPaid.Text)==false)
			{
				MessageBox.Show(this,"Invalid Amount","WARNING",MessageBoxButtons.OK ,MessageBoxIcon.Warning); 
				txtAmtPaid.Clear();
				txtAmtPaid.Focus();
				return true;
			}  
			return false;
		}


		

		protected override void btnOk_Click(object sender, System.EventArgs e)
		{
			
			/****************************************\
		   {    Updates information of the member     }
			\****************************************/ 

			bool boolTemp;
			boolTemp=Validation();

			if (boolTemp==true)
				return;
            RecordNo.BeginEdit();  
//			RecordNo["Parentage"]=this.txtParent.Text;
//			RecordNo["User ID"]=this.txtUsrId.Text;
			RecordNo["Address"]=this.txtAdd.Text.Trim();
			RecordNo["E-Mail ID"]=this.txtID.Text.Trim() + "@" + this.txtSite.Text.Trim();
			RecordNo["PassCode"]=this.txtConfirmPassCode.Text.Trim();
//			RecordNo["Amount Paid"]=this.txtAmtPaid.Text;
			RecordNo["Favourite Sites"]=this.txtFavour.Text.Trim();
            RecordNo.EndEdit();
			
			DataRow[] myDataRowArray = dsGm2.Tables[0].Select(null, null, DataViewRowState.ModifiedCurrent);
			oleDbDataAdapter1.Update(dsTemp1);
			
			this.Close();

       }


		protected override void txtName_TextChanged(object sender, System.EventArgs e)
		{
			label1.ForeColor =Color.Black;
		
		}

		protected override void txtUsrId_TextChanged(object sender, System.EventArgs e)
		{
			label7.ForeColor =Color.Black;
		}

		protected override void txtPassCode_TextChanged(object sender, System.EventArgs e)
		{
			label8.ForeColor =Color.Black;
		}

		protected override void txtConfirmPassCode_TextChanged(object sender, System.EventArgs e)
		{
			label9.ForeColor =Color.Black;
		}

		protected override void txtAmtPaid_TextChanged(object sender, System.EventArgs e)
		{
			label10.ForeColor =Color.Black;		
		}

		protected override void txtAdd_TextChanged(object sender, System.EventArgs e)
		{
			label2.ForeColor =Color.Black;
		}
		private void Form_Load(object sender, System.EventArgs e)
		{
			this.txtName.Enabled=false;
			this.txtParent.Enabled=false;
			this.txtUsrId.Enabled=false;
			this.txtAmtPaid.Enabled=false;
			this.txtName.Text =RecordNo["Name"].ToString();  
			this.txtUsrId.Text =RecordNo["User ID"].ToString();  
			this.txtParent.Text =RecordNo["Parentage"].ToString();
			this.txtPassCode.Text =RecordNo["PassCode"].ToString();
			this.txtConfirmPassCode.Text =RecordNo["PassCode"].ToString();
			this.txtAdd.Text =RecordNo["Address"].ToString();
			this.txtAmtPaid.Text=RecordNo["Amount"].ToString();
			this.txtFavour.Text =RecordNo["Favourite Sites"].ToString();

			                /************split*************/
            string[] tempArray = new string[2];
			tempArray=RecordNo["E-Mail ID"].ToString().Split(new char[]{'@'},2) ;
			this.txtID.Text =tempArray[0].ToString();  
			this.txtSite.Text =tempArray[1].ToString() ;  
		}


	}
}

