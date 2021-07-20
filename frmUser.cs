/*********************************************************\
|****************This Code is written by******************|
|******Rupish Arora, Anoop Chargotra, Raj Dev Manhas******|
|**********************of GCET Jammu**********************|
|****************as their Final Year Project**************|
|******************code named "CafeManager"***************|
|**********************under guidance of******************|
|*****Mrs. Bhawna Sharma(Sr. Lecturer, Computer Deptt.****|
\*********************************************************/

  /****************************************\
 {    Code for class frmUser goes here      }
  \****************************************/

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using clsLibIsNum.tmpComp;  
 
namespace CafeManager
{
	///
	/// <summary>
	/// Summary description for frmUser.
	/// </summary>
	/// 
	public class frmUser : System.Windows.Forms.Form
	{
		protected System.Windows.Forms.GroupBox groupBox1;
		protected System.Windows.Forms.Label label1;
		protected System.Windows.Forms.Label label2;
		protected System.Windows.Forms.Label label3;
		protected System.Windows.Forms.Label label4;
		protected System.Windows.Forms.Label label5;
		protected System.Windows.Forms.Label label6;
		protected System.Windows.Forms.TextBox txtName;
		protected System.Windows.Forms.TextBox txtAmount;
		protected System.Windows.Forms.Button btnOk;
		protected System.Windows.Forms.Button btnCancel;
		protected System.Windows.Forms.TextBox txtSite;
		protected System.Windows.Forms.TextBox txtTimeHrs;
		protected System.Windows.Forms.Label label7;
		protected System.Windows.Forms.TextBox txtTimeMin;
		protected System.Windows.Forms.ToolTip toolTip1;
		protected System.Windows.Forms.TextBox txtId;
		protected System.Windows.Forms.Label lblDate;
		protected  System.Windows.Forms.Button btnAdd;
		private System.ComponentModel.IContainer components;
		protected System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		protected System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		protected System.Data.OleDb.OleDbConnection oleDbConnection1;
		protected CafeManager.dsGmx dsGmx2;
		private string tempPath=Application.StartupPath + @"\member.mdb";

		public frmUser()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			// This part sets Date in the Form
			lblDate.Text=DateTime.Now.ToLongDateString(); 
 
			//oleDbConnection
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=" + tempPath + @";Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";

			// This part clears the DataSet
            dsGmx2.Clear();

			// This part fills the DataSet with Data from the Database
			oleDbDataAdapter1.Fill(dsGmx2);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmUser));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblDate = new System.Windows.Forms.Label();
			this.txtTimeMin = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtSite = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.txtTimeHrs = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dsGmx2 = new CafeManager.dsGmx();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsGmx2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.btnOk,
																					this.btnAdd,
																					this.lblDate,
																					this.txtTimeMin,
																					this.label7,
																					this.txtSite,
																					this.label6,
																					this.txtId,
																					this.label5,
																					this.btnCancel,
																					this.label4,
																					this.label3,
																					this.label2,
																					this.txtAmount,
																					this.txtTimeHrs,
																					this.txtName,
																					this.label1});
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 240);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "User Information :";
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOk.Location = new System.Drawing.Point(104, 208);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(72, 24);
			this.btnOk.TabIndex = 6;
			this.btnOk.Text = "&OK";
			this.toolTip1.SetToolTip(this.btnOk, "Save Changes");
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAdd.Location = new System.Drawing.Point(104, 208);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(72, 24);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "&Add More";
			this.btnAdd.Visible = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(104, 16);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(0, 13);
			this.lblDate.TabIndex = 13;
			// 
			// txtTimeMin
			// 
			this.txtTimeMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTimeMin.Location = new System.Drawing.Point(136, 120);
			this.txtTimeMin.Name = "txtTimeMin";
			this.txtTimeMin.Size = new System.Drawing.Size(24, 20);
			this.txtTimeMin.TabIndex = 4;
			this.txtTimeMin.Text = "";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(128, 120);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(16, 24);
			this.label7.TabIndex = 12;
			this.label7.Text = ":";
			// 
			// txtSite
			// 
			this.txtSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSite.Location = new System.Drawing.Point(200, 80);
			this.txtSite.Name = "txtSite";
			this.txtSite.Size = new System.Drawing.Size(48, 20);
			this.txtSite.TabIndex = 2;
			this.txtSite.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(184, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(16, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "@";
			// 
			// txtId
			// 
			this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtId.Location = new System.Drawing.Point(104, 80);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(80, 20);
			this.txtId.TabIndex = 1;
			this.txtId.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(32, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "E-Mail ID   :";
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCancel.Location = new System.Drawing.Point(192, 208);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(72, 24);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Tag = "";
			this.btnCancel.Text = "&Cancel";
			this.toolTip1.SetToolTip(this.btnCancel, "Cancel");
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(40, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "OR";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Amount      :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Total Time :";
			// 
			// txtAmount
			// 
			this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAmount.Location = new System.Drawing.Point(104, 176);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(104, 20);
			this.txtAmount.TabIndex = 5;
			this.txtAmount.Text = "";
			// 
			// txtTimeHrs
			// 
			this.txtTimeHrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTimeHrs.Location = new System.Drawing.Point(104, 120);
			this.txtTimeHrs.Name = "txtTimeHrs";
			this.txtTimeHrs.Size = new System.Drawing.Size(24, 20);
			this.txtTimeHrs.TabIndex = 3;
			this.txtTimeHrs.Text = "";
			// 
			// txtName
			// 
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtName.Location = new System.Drawing.Point(104, 40);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(104, 20);
			this.txtName.TabIndex = 0;
			this.txtName.Text = "";
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name        :";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "user", new System.Data.Common.DataColumnMapping[] {
																																																				new System.Data.Common.DataColumnMapping("Name", "Name"),
																																																				new System.Data.Common.DataColumnMapping("E-Mail ID", "E-Mail ID"),
																																																				new System.Data.Common.DataColumnMapping("Total Time", "Total Time"),
																																																				new System.Data.Common.DataColumnMapping("Amount", "Amount"),
																																																				new System.Data.Common.DataColumnMapping("Date", "Date"),
																																																				new System.Data.Common.DataColumnMapping("User ID", "User ID"),
																																																				new System.Data.Common.DataColumnMapping("Login", "Login"),
																																																				new System.Data.Common.DataColumnMapping("Logout", "Logout")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM [user] WHERE ([User ID] = ?) AND (Amount = ? OR ? IS NULL AND Amount IS NULL) AND ([Date] = ? OR ? IS NULL AND [Date] IS NULL) AND ([E-Mail ID] = ? OR ? IS NULL AND [E-Mail ID] IS NULL) AND (Login = ? OR ? IS NULL AND Login IS NULL) AND (Logout = ? OR ? IS NULL AND Logout IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND ([Total Time] = ? OR ? IS NULL AND [Total Time] IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "User ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Login", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Login", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Login1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Login", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Logout", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Logout", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Logout1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Logout", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total Time", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total Time", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO [user] (Amount, [Date], [E-Mail ID], Login, Logout, Name, [Total Time" +
				"], [User ID]) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "E-Mail ID"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Login", System.Data.OleDb.OleDbType.DBDate, 0, "Login"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Logout", System.Data.OleDb.OleDbType.DBDate, 0, "Logout"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_Time", System.Data.OleDb.OleDbType.VarWChar, 50, "Total Time"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "User ID"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Amount, [Date], [E-Mail ID], Login, Logout, Name, [Total Time], [User ID] " +
				"FROM [user]";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE [user] SET Amount = ?, [Date] = ?, [E-Mail ID] = ?, Login = ?, Logout = ?, Name = ?, [Total Time] = ?, [User ID] = ? WHERE ([User ID] = ?) AND (Amount = ? OR ? IS NULL AND Amount IS NULL) AND ([Date] = ? OR ? IS NULL AND [Date] IS NULL) AND ([E-Mail ID] = ? OR ? IS NULL AND [E-Mail ID] IS NULL) AND (Login = ? OR ? IS NULL AND Login IS NULL) AND (Logout = ? OR ? IS NULL AND Logout IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND ([Total Time] = ? OR ? IS NULL AND [Total Time] IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "E-Mail ID"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Login", System.Data.OleDb.OleDbType.DBDate, 0, "Login"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Logout", System.Data.OleDb.OleDbType.DBDate, 0, "Logout"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_Time", System.Data.OleDb.OleDbType.VarWChar, 50, "Total Time"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, "User ID"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_User_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "User ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Amount1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(19)), ((System.Byte)(0)), "Amount", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail_ID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Login", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Login", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Login1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Login", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Logout", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Logout", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Logout1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Logout", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total Time", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_Time1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total Time", System.Data.DataRowVersion.Original, null));
			// 
			// dsGmx2
			// 
			this.dsGmx2.DataSetName = "dsGmx";
			this.dsGmx2.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsGmx2.Namespace = "http://www.tempuri.org/dsGmx.xsd";
			// 
			// frmUser
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.ClientSize = new System.Drawing.Size(298, 247);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "  New User";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsGmx2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			// This Part closes the Form
		    this.Close();
		}

		protected virtual void btnOk_Click(object sender, System.EventArgs e)
		{
		    //  This Function Adds the record in the DataBase
            bool boolTemp;

			// This part call the function validation
			boolTemp=Validation();

			// If successful adds to the databse
			// depending on the user selection the message box
			// Returns if Validation fails
            if (boolTemp==true) return;
			MessageBoxButtons Button = MessageBoxButtons.YesNo ;
			DialogResult result=MessageBox.Show(this,"Confirm Addition","Warning",Button,MessageBoxIcon.Exclamation);
			
			//Returns when No is selected
			if(result==DialogResult.No) return;

			// Creates a new DataRow Object   	   
			DataRow anyRow = dsGmx2.user.NewRow();
			
			// This part sets the User ID
			if (dsGmx2.Tables[0].Rows.Count==0)
			{
				anyRow["User ID"]="User-" + "1";
				
				
			}
			else
			{
				for (int i=1;i<=dsGmx2.Tables[0].Rows.Count+1;i++)
				{
					DataView dtvTemp = new DataView(dsGmx2.Tables[0] ,"","User ID",DataViewRowState.CurrentRows );
					int intTemp1 = dtvTemp.Find("User-" + i.ToString());
					if (intTemp1!=-1)
					{
						continue;
					}
					else
					{
						anyRow["User ID"]="User-" + i.ToString();
						break;
					}
				}
	    	}

			// Displays User Id
			if(result==DialogResult.Yes)
			MessageBox.Show("User Id Number assigned is :- " + anyRow["User ID"]);

    		 // This Part actually adds the data in the Dataset
			anyRow["Name"]  = txtName.Text.Trim();
			anyRow["E-Mail ID"]=txtId.Text.Trim() + "@" + txtSite.Text.Trim();

			// This part sets the default settings, if user 
			// doesn't fill the data
			if ((txtTimeHrs.Text!="" ) && (txtTimeMin.Text!=""))
			   anyRow["Total Time"]=txtTimeHrs.Text.Trim() + ":" + txtTimeMin.Text.Trim();
			if ((txtTimeHrs.Text!="" ) && (txtTimeMin.Text==""))
                anyRow["Total Time"]=txtTimeHrs.Text.Trim() + ":" + "00";
			if (txtAmount.Text!="")
 			anyRow["Amount"] = txtAmount.Text.Trim();
			anyRow["Date"] = DateTime.Now.ToShortDateString();
			dsGmx2.user.Rows.Add(anyRow);
		
		//  This part updates the changes in Dataset to the DataBase
			DataRow[] myDataRowArray = dsGmx2.Tables[0].Select(null, null, DataViewRowState.Added);
			oleDbDataAdapter1.Update(myDataRowArray);
			
			// This part sets the button addMore to visible
			btnOk.Visible =false;
			btnAdd.Visible =true;
		    btnAdd.Focus();       
		}

		private bool Validation()
		{
			// This part does the validations for textBoxes
			// And calls the function written in VB .NET
			cmpIsNum temp = new cmpIsNum();
			
			// This part confirs that user has entered 
			//  his name and sets the color of the label
			// to red if left empty			
			if (txtName.Text =="")
			{
				label1.ForeColor=Color.Red ;
				MessageBox.Show(this,"Fields in Red are compulsory","WARNING",MessageBoxButtons.OK ,MessageBoxIcon.Warning); 
				txtName.Focus(); 
				return true;
			}
			// Validates the time for numeric values			
			if ((temp.isNum(txtTimeHrs.Text) == false) || (temp.isNum(txtTimeMin.Text) == false))
			{
				MessageBox.Show(this,"Invalid Time","WARNING",MessageBoxButtons.OK ,MessageBoxIcon.Warning); 
				txtTimeHrs.Clear();
				txtTimeMin.Clear(); 
				txtTimeHrs.Focus();
				return true;
			}

            // Validates the amount for numeric values
			if (temp.isNum(txtAmount.Text)==false)
			{
				MessageBox.Show(this,"Invalid Amount","WARNING",MessageBoxButtons.OK ,MessageBoxIcon.Warning); 
				txtAmount.Clear();
				txtAmount.Focus();
				return true;
			}    

			// Returns false if validation is correct
			return false;  
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			// This part clears the textboxes if user 
			// wants to add more records
    		btnAdd.Visible =false;
	    	btnOk.Visible =true;
            txtName.Clear();
			txtId.Clear();
			txtSite.Clear();
			txtTimeHrs.Clear();
			txtTimeMin.Clear();
			txtAmount.Clear();
			txtName.Focus();
       	}

		private void txtName_TextChanged(object sender, System.EventArgs e)
		{
			// This part changes the label color to black
			// when user writes some thing in the correponding
			// text box
			label1.ForeColor =Color.Black;
		}
    }
}