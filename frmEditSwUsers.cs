using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CafeManager
{
	/// <summary>
	/// Summary description for frmEditSwUsers.
	/// </summary>
	public class frmEditSwUsers : frmSwUsers
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		/// 
		private int temp1;
		private System.ComponentModel.Container components = null;

		public frmEditSwUsers(int recno)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			temp1=recno;

			dsSuser1.Clear();
			oleDbDataAdapter1.Fill(dsSuser1);

			ViewSwUsers();

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
			this.Size = new System.Drawing.Size(294,536);
			this.Text = "Edit Software User";
		}
		#endregion


		  private new bool Validation()
		{
			bool boolTemp = false;
			if (txtName.Text == "")
			{
				label4.ForeColor = Color.Red ;
				boolTemp = true;
			}
			if(txtFathersName.Text == "")
			{
				label5.ForeColor = Color.Red ;
				boolTemp = true;
			}
			if(txtDesig.Text == "")
			{
				label6.ForeColor = Color.Red ;
				boolTemp = true ;
			}
			if(txtPassCode.Text == "")
			{
				label11.ForeColor = Color.Red;
				boolTemp = true ;
			}
			if(txtConfPassCode.Text == "")
			{
				label12.ForeColor = Color.Red;
				boolTemp = true ;
			}
			if(txtUsrId.Text == "")
			{
				label10.ForeColor = Color.Red ;
				boolTemp = true ;
			}
			if(txtAdd.Text =="")
			{
				label7.ForeColor = Color.Red;
				boolTemp = true ;
			}
			

			if(boolTemp == true)
			{
				MessageBox.Show("Fields in Red are needed","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning );
				
				if (label12.ForeColor  == Color.Red ) txtConfPassCode.Focus ();
				if (label11.ForeColor == Color.Red ) txtPassCode.Focus ();
				if (label10.ForeColor == Color.Red ) txtUsrId.Focus ();
				if (label7.ForeColor  == Color.Red ) txtAdd.Focus ();
				if (label6.ForeColor  == Color.Red ) txtDesig.Focus ();
				if (label5.ForeColor  == Color.Red ) txtFathersName.Focus ();
				if (label4.ForeColor  == Color.Red ) txtName.Focus ();
							
				return false;  	         
			}
			if (txtPassCode.Text != txtConfPassCode.Text)
			{
				MessageBox.Show("Error in PassCode","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				this.txtPassCode.Clear(); 
				this.txtConfPassCode.Clear();
				this.txtPassCode.Focus();
				return false;	
			} 
			return true;
		}


		
		private void ViewSwUsers()
		{
			

			this.txtUsrId.Enabled =false;
			this.txtName.Text =dsSuser1.Tables[0].Rows[temp1]["Name"].ToString();  
			this.txtFathersName.Text =dsSuser1.Tables[0].Rows[temp1]["Father's Name"].ToString();  
			this.txtDesig.Text =dsSuser1.Tables[0].Rows[temp1]["Designation"].ToString();
			this.txtAdd.Text =dsSuser1.Tables[0].Rows[temp1]["Address"].ToString();
			string[] tempArray= new string[2];
		    tempArray=dsSuser1.Tables[0].Rows[temp1]["E-Mail"].ToString().Split(new char[]{'@'},2);
			this.txtId.Text =tempArray[0].ToString();
			this.txtSite.Text =tempArray[1].ToString();  
			
			this.txtPassCode.Text =dsSuser1.Tables[0].Rows[temp1]["PassCode"].ToString();
			this.txtConfPassCode.Text =dsSuser1.Tables[0].Rows[temp1]["PassCode"].ToString();
			this.txtUsrId.Text =dsSuser1.Tables[0].Rows[temp1]["User Id"].ToString();
			this.groupBox4.Enabled=false;
		  
			if(dsSuser1.Tables[0].Rows[temp1]["Passwd"].ToString()=="True")
				this.chkPass.Checked=true;
			else
				this.chkPass.Checked=false;

			if(dsSuser1.Tables[0].Rows[temp1]["Account Type"].ToString()=="Admin")
				this.radioButton1.Checked=true ;
			else
				this.radioButton2.Checked=true; 

			
		}

		protected override void txtName_TextChanged(object sender, System.EventArgs e)
		{
			label4.ForeColor=Color.Black;
		}

		protected override void txtFathersName_TextChanged(object sender, System.EventArgs e)
		{
			label5.ForeColor=Color.Black;
		}

		protected override void txtDesig_TextChanged(object sender, System.EventArgs e)
		{
			label6.ForeColor=Color.Black;
		}

		protected override void txtUsrId_TextChanged(object sender, System.EventArgs e)
		{
			label10.ForeColor=Color.Black;
		}

		
		protected override void txtPassCode_TextChanged(object sender, System.EventArgs e)
		{
			label11.ForeColor=Color.Black;
		}

		protected override void txtConfPassCode_TextChanged(object sender, System.EventArgs e)
		{
			label12.ForeColor=Color.Black;
		}

		protected override void txtAdd_TextChanged(object sender, System.EventArgs e)
		{
			label7.ForeColor=Color.Black;
		}
		
		
		
		protected override void btnOK_Click(object sender, System.EventArgs e)
		{

			/**Updates SwUsers record**/

				
			bool Temp;
			Temp = Validation();
			DialogResult drTemp=MessageBox.Show(this,"Confirm Updation !!!","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
			if (drTemp==DialogResult.No)
				return;

			
			if(Temp == true)
			{
				dsSuser1.Tables[0].Rows[temp1]["Name"]=this.txtName.Text.Trim();
				dsSuser1.Tables[0].Rows[temp1]["Father's Name"]=this.txtFathersName.Text.Trim();
				dsSuser1.Tables[0].Rows[temp1]["Designation"]=this.txtDesig.Text.Trim();
				dsSuser1.Tables[0].Rows[temp1]["Address"]=this.txtAdd.Text.Trim();
				dsSuser1.Tables[0].Rows[temp1]["E-Mail"]=this.txtId.Text.Trim() + "@" + this.txtSite.Text.Trim();
				dsSuser1.Tables[0].Rows[temp1]["PassCode"]=this.txtConfPassCode.Text.Trim();

				if(this.chkPass.Checked)
					dsSuser1.Tables[0].Rows[temp1]["Passwd"]="True";
				else
					dsSuser1.Tables[0].Rows[temp1]["Passwd"]="False";
                
				// checking whether updated user = userLogged in
				if (dsSuser1.Tables[0].Rows[temp1]["User Id"].ToString()==currentUser.currentUserId)
					currentUser.currentPassCode=txtPassCode.Text.Trim();
 
	
				DataRow[] myDataRowArray = dsSuser1.Tables[0].Select(null, null, DataViewRowState.ModifiedCurrent);
				oleDbDataAdapter1.Update(myDataRowArray);
                
				MessageBox.Show("Database successfully updated !!!");
				this.Close ();
			}
		}



	}
}
