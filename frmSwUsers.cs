using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data; 
using System.Data.OleDb;


namespace CafeManager
{
	/// <summary>
	/// Summary description for frmSwUsers.
	/// </summary>
	public class frmSwUsers : System.Windows.Forms.Form
	{
		protected System.Windows.Forms.TextBox txtConfPassCode;
		protected System.Windows.Forms.GroupBox groupBox1;
		protected System.Windows.Forms.TextBox txtPassCode;
		protected System.Windows.Forms.TextBox txtUsrId;
		protected System.Windows.Forms.GroupBox groupBox3;
		protected System.Windows.Forms.GroupBox groupBox2;
		protected System.Windows.Forms.TextBox txtSite;
		protected System.Windows.Forms.TextBox txtId;
		protected System.Windows.Forms.TextBox txtAdd;
		protected System.Windows.Forms.TextBox txtDesig;
		protected System.Windows.Forms.TextBox txtFathersName;
		protected System.Windows.Forms.TextBox txtName;
		protected System.Windows.Forms.Label label7;
		protected System.Windows.Forms.Label label6;
		protected System.Windows.Forms.Label label5;
		protected System.Windows.Forms.Label label4;
		protected System.Windows.Forms.Label label10;
		protected System.Windows.Forms.Label label11;
		protected System.Windows.Forms.Label label12;
		protected System.Windows.Forms.Label label1;
		protected System.Windows.Forms.Label label2;
		private string tempPath=Application.StartupPath + @"\member.mdb";
		protected System.Windows.Forms.Button btnAdd;
		protected System.Windows.Forms.Button btnCancel;
		protected System.Windows.Forms.ToolTip toolTip1;
		protected System.Windows.Forms.Button btnOK;
		protected System.Windows.Forms.CheckBox chkPass;
		protected System.Windows.Forms.GroupBox groupBox4;
		protected System.Windows.Forms.RadioButton radioButton1;
		protected System.Windows.Forms.RadioButton radioButton2;
		protected System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		protected System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		protected System.Data.OleDb.OleDbConnection oleDbConnection1;
		protected CafeManager.dsSuser dsSuser1;
		private System.ComponentModel.IContainer components;

		public frmSwUsers()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//oleDbConnection
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=" + tempPath + @";Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			dsSuser1.Clear();
			oleDbDataAdapter1.Fill(dsSuser1);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSwUsers));
			this.txtConfPassCode = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.chkPass = new System.Windows.Forms.CheckBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtPassCode = new System.Windows.Forms.TextBox();
			this.txtUsrId = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSite = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtAdd = new System.Windows.Forms.TextBox();
			this.txtDesig = new System.Windows.Forms.TextBox();
			this.txtFathersName = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dsSuser1 = new CafeManager.dsSuser();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsSuser1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtConfPassCode
			// 
			this.txtConfPassCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtConfPassCode.Location = new System.Drawing.Point(128, 88);
			this.txtConfPassCode.Name = "txtConfPassCode";
			this.txtConfPassCode.PasswordChar = '*';
			this.txtConfPassCode.TabIndex = 2;
			this.txtConfPassCode.Text = "";
			this.txtConfPassCode.TextChanged += new System.EventHandler(this.txtConfPassCode_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.groupBox4,
																					this.chkPass,
																					this.label12,
																					this.label11,
																					this.label10,
																					this.txtConfPassCode,
																					this.txtPassCode,
																					this.txtUsrId});
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 232);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 224);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Security :";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.radioButton2,
																					this.radioButton1});
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Location = new System.Drawing.Point(8, 120);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(232, 64);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Account Type :";
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton2.Location = new System.Drawing.Point(16, 40);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(208, 16);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Limited";
			// 
			// radioButton1
			// 
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton1.Location = new System.Drawing.Point(16, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(200, 16);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.Text = "Administrative";
			// 
			// chkPass
			// 
			this.chkPass.Checked = true;
			this.chkPass.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkPass.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkPass.Location = new System.Drawing.Point(8, 192);
			this.chkPass.Name = "chkPass";
			this.chkPass.Size = new System.Drawing.Size(232, 24);
			this.chkPass.TabIndex = 4;
			this.chkPass.Text = "User must change PassCode on next log";
			this.chkPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(16, 96);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(105, 13);
			this.label12.TabIndex = 20;
			this.label12.Text = "Confirm PassCode :";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(16, 64);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(102, 13);
			this.label11.TabIndex = 19;
			this.label11.Text = "PassCode              :";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(16, 32);
			this.label10.Name = "label10";
			this.label10.TabIndex = 18;
			this.label10.Text = "User ID                  :";
			// 
			// txtPassCode
			// 
			this.txtPassCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassCode.Location = new System.Drawing.Point(128, 56);
			this.txtPassCode.Name = "txtPassCode";
			this.txtPassCode.PasswordChar = '*';
			this.txtPassCode.TabIndex = 1;
			this.txtPassCode.Text = "";
			this.txtPassCode.TextChanged += new System.EventHandler(this.txtPassCode_TextChanged);
			// 
			// txtUsrId
			// 
			this.txtUsrId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsrId.Location = new System.Drawing.Point(128, 24);
			this.txtUsrId.Name = "txtUsrId";
			this.txtUsrId.TabIndex = 0;
			this.txtUsrId.Text = "";
			this.txtUsrId.TextChanged += new System.EventHandler(this.txtUsrId_TextChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.btnOK,
																					this.btnCancel,
																					this.groupBox2,
																					this.groupBox1,
																					this.btnAdd});
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(8, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(272, 496);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Required information :";
			// 
			// btnOK
			// 
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOK.Location = new System.Drawing.Point(112, 464);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(72, 24);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "&OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCancel.Location = new System.Drawing.Point(192, 464);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(72, 24);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "&Cancel";
			this.toolTip1.SetToolTip(this.btnCancel, "Close without Saving");
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label2,
																					this.label1,
																					this.txtSite,
																					this.txtId,
																					this.txtAdd,
																					this.txtDesig,
																					this.txtFathersName,
																					this.txtName,
																					this.label7,
																					this.label6,
																					this.label5,
																					this.label4});
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(8, 16);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(256, 208);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Personnel :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(184, 184);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 13);
			this.label2.TabIndex = 19;
			this.label2.Text = "@";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 184);
			this.label1.Name = "label1";
			this.label1.TabIndex = 18;
			this.label1.Text = "E-Mail                    :";
			// 
			// txtSite
			// 
			this.txtSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSite.Location = new System.Drawing.Point(200, 176);
			this.txtSite.Name = "txtSite";
			this.txtSite.Size = new System.Drawing.Size(32, 20);
			this.txtSite.TabIndex = 5;
			this.txtSite.Text = "";
			// 
			// txtId
			// 
			this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtId.Location = new System.Drawing.Point(128, 176);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(56, 20);
			this.txtId.TabIndex = 4;
			this.txtId.Text = "";
			// 
			// txtAdd
			// 
			this.txtAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAdd.Location = new System.Drawing.Point(128, 120);
			this.txtAdd.Multiline = true;
			this.txtAdd.Name = "txtAdd";
			this.txtAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtAdd.Size = new System.Drawing.Size(112, 48);
			this.txtAdd.TabIndex = 3;
			this.txtAdd.Text = "";
			this.txtAdd.TextChanged += new System.EventHandler(this.txtAdd_TextChanged);
			// 
			// txtDesig
			// 
			this.txtDesig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDesig.Location = new System.Drawing.Point(128, 88);
			this.txtDesig.Name = "txtDesig";
			this.txtDesig.TabIndex = 2;
			this.txtDesig.Text = "";
			this.txtDesig.TextChanged += new System.EventHandler(this.txtDesig_TextChanged);
			// 
			// txtFathersName
			// 
			this.txtFathersName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFathersName.Location = new System.Drawing.Point(128, 56);
			this.txtFathersName.Name = "txtFathersName";
			this.txtFathersName.TabIndex = 1;
			this.txtFathersName.Text = "";
			this.txtFathersName.TextChanged += new System.EventHandler(this.txtFathersName_TextChanged);
			// 
			// txtName
			// 
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtName.Location = new System.Drawing.Point(128, 24);
			this.txtName.Name = "txtName";
			this.txtName.TabIndex = 0;
			this.txtName.Text = "";
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.label7.Location = new System.Drawing.Point(16, 128);
			this.label7.Name = "label7";
			this.label7.TabIndex = 17;
			this.label7.Text = "Address                 :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.label6.Location = new System.Drawing.Point(16, 96);
			this.label6.Name = "label6";
			this.label6.TabIndex = 16;
			this.label6.Text = "Designation           :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.label5.Location = new System.Drawing.Point(16, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Father\'s Name       :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.label4.Location = new System.Drawing.Point(16, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Name                    :";
			// 
			// btnAdd
			// 
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAdd.Location = new System.Drawing.Point(112, 464);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(72, 24);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "&Add More";
			this.toolTip1.SetToolTip(this.btnAdd, "Add more Records");
			this.btnAdd.Visible = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "SwUsers", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("Name", "Name"),
																																																				   new System.Data.Common.DataColumnMapping("Father\'s Name", "Father\'s Name"),
																																																				   new System.Data.Common.DataColumnMapping("Designation", "Designation"),
																																																				   new System.Data.Common.DataColumnMapping("Address", "Address"),
																																																				   new System.Data.Common.DataColumnMapping("E-Mail", "E-Mail"),
																																																				   new System.Data.Common.DataColumnMapping("PassCode", "PassCode"),
																																																				   new System.Data.Common.DataColumnMapping("User Id", "User Id"),
																																																				   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																				   new System.Data.Common.DataColumnMapping("Passwd", "Passwd"),
																																																				   new System.Data.Common.DataColumnMapping("Account Type", "Account Type")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM SwUsers WHERE (ID = ?) AND ([User Id] = ?) AND ([Account Type] = ? OR ? IS NULL AND [Account Type] IS NULL) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND ([E-Mail] = ? OR ? IS NULL AND [E-Mail] IS NULL) AND ([Father's Name] = ? OR ? IS NULL AND [Father's Name] IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (PassCode = ? OR ? IS NULL AND PassCode IS NULL) AND (Passwd = ? OR ? IS NULL AND Passwd IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_User_Id", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "User Id", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Account_Type", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Account Type", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Account_Type1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Account Type", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Father\'s_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Father\'s Name", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Father\'s_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Father\'s Name", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PassCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PassCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PassCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PassCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Passwd", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Passwd", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Passwd1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Passwd", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Documents and Settings\Anoop\My Documents\Visual Studio Projects\CafeManager\bin\Debug\member.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO SwUsers([Account Type], Address, Designation, [E-Mail], [Father\'s Nam" +
				"e], ID, Name, PassCode, Passwd, [User Id]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" +
				"";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Account_Type", System.Data.OleDb.OleDbType.VarWChar, 50, "Account Type"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E-Mail", System.Data.OleDb.OleDbType.VarWChar, 50, "E-Mail"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Father\'s_Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Father\'s Name"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.VarWChar, 50, "ID"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PassCode", System.Data.OleDb.OleDbType.VarWChar, 50, "PassCode"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Passwd", System.Data.OleDb.OleDbType.VarWChar, 50, "Passwd"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("User_Id", System.Data.OleDb.OleDbType.VarWChar, 50, "User Id"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT [Account Type], Address, Designation, [E-Mail], [Father\'s Name], ID, Name," +
				" PassCode, Passwd, [User Id] FROM SwUsers";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE SwUsers SET [Account Type] = ?, Address = ?, Designation = ?, [E-Mail] = ?, [Father's Name] = ?, ID = ?, Name = ?, PassCode = ?, Passwd = ?, [User Id] = ? WHERE (ID = ?) AND ([User Id] = ?) AND ([Account Type] = ? OR ? IS NULL AND [Account Type] IS NULL) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND ([E-Mail] = ? OR ? IS NULL AND [E-Mail] IS NULL) AND ([Father's Name] = ? OR ? IS NULL AND [Father's Name] IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (PassCode = ? OR ? IS NULL AND PassCode IS NULL) AND (Passwd = ? OR ? IS NULL AND Passwd IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Account_Type", System.Data.OleDb.OleDbType.VarWChar, 50, "Account Type"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 50, "Designation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E-Mail", System.Data.OleDb.OleDbType.VarWChar, 50, "E-Mail"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Father\'s_Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Father\'s Name"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.VarWChar, 50, "ID"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PassCode", System.Data.OleDb.OleDbType.VarWChar, 50, "PassCode"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Passwd", System.Data.OleDb.OleDbType.VarWChar, 50, "Passwd"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("User_Id", System.Data.OleDb.OleDbType.VarWChar, 50, "User Id"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_User_Id", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "User Id", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Account_Type", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Account Type", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Account_Type1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Account Type", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E-Mail1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E-Mail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Father\'s_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Father\'s Name", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Father\'s_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Father\'s Name", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PassCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PassCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PassCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PassCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Passwd", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Passwd", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Passwd1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Passwd", System.Data.DataRowVersion.Original, null));
			// 
			// dsSuser1
			// 
			this.dsSuser1.DataSetName = "dsSuser";
			this.dsSuser1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsSuser1.Namespace = "http://www.tempuri.org/dsSuser.xsd";
			// 
			// frmSwUsers
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.ClientSize = new System.Drawing.Size(288, 503);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox3});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSwUsers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "  Software Users";
			this.groupBox1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsSuser1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

				
				
		protected virtual bool Validation()
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

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
         this.Close();		
		}

		

		protected virtual void txtName_TextChanged(object sender, System.EventArgs e)
		{
			label4.ForeColor=Color.Black;
		}

		protected virtual void txtFathersName_TextChanged(object sender, System.EventArgs e)
		{
			label5.ForeColor=Color.Black;
		}

		protected virtual void txtDesig_TextChanged(object sender, System.EventArgs e)
		{
			label6.ForeColor=Color.Black;
		}

		protected virtual void txtUsrId_TextChanged(object sender, System.EventArgs e)
		{
			label10.ForeColor=Color.Black;
		}

		protected virtual void txtPassCode_TextChanged(object sender, System.EventArgs e)
		{
		label11.ForeColor=Color.Black;
		}

		protected virtual void txtConfPassCode_TextChanged(object sender, System.EventArgs e)
		{
		label12.ForeColor=Color.Black;
		}

	    protected virtual void txtAdd_TextChanged(object sender, System.EventArgs e)
		{
		label7.ForeColor=Color.Black;
		}
		
		protected virtual void btnOK_Click(object sender, System.EventArgs e)
		{
		
			bool Temp;

			Temp = Validation();

			DataView dtvTemp= new DataView(dsSuser1.Tables[0],"","User Id",DataViewRowState.CurrentRows);
			int rowIndex=dtvTemp.Find(txtUsrId.Text);
			if (rowIndex!=-1)
			{
				MessageBox.Show("User Id already there!!!","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				this.txtUsrId.Focus();
				return;
			}

			
			if(Temp == true)
			{
				DataRow anyRow = dsSuser1.SwUsers.NewRow();

				// ID(Primary Key) as Autonumber
				if (dsSuser1.Tables[0].Rows.Count==0)
				{
					anyRow["ID"]="SwUser-" + "1";
				}
				else
				{
					for (int i=1;i<=dsSuser1.Tables[0].Rows.Count+1;i++)
					{
						DataView dtvTemp2 = new DataView(dsSuser1.Tables[0] ,"","ID",DataViewRowState.CurrentRows );
						int intTemp1 = dtvTemp2.Find("SwUser-" + i.ToString());
						if (intTemp1!=-1)
						{
							continue;
						}
						else
						{
							anyRow["ID"]="SwUser-" + i.ToString();
							break;
						}
					}
	
				}
			  
				anyRow["Name"]  = txtName.Text.Trim();
				anyRow["Father's Name"] = txtFathersName.Text.Trim();
				anyRow["Designation"] = txtDesig.Text.Trim() ;
				anyRow["Address"] = txtAdd.Text.Trim();
				anyRow["User Id"] = txtUsrId.Text.Trim() ;
				anyRow["E-Mail"]=txtId.Text + "@" + txtSite.Text.Trim();
				anyRow["PassCode"] = txtPassCode.Text.Trim();

				if (radioButton2.Checked)
 			    anyRow["Account Type"] ="Limited";
				else
                anyRow["Account Type"] ="Admin";
                
				if(chkPass.Checked)
    			anyRow["Passwd"]="True";
				else
				anyRow["Passwd"]="False";

				dsSuser1.SwUsers.Rows.Add(anyRow);
			
				DataRow[] myDataRowArray = dsSuser1.Tables[0].Select(null, null, DataViewRowState.Added);
				oleDbDataAdapter1.Update(myDataRowArray);
				this.btnAdd.Visible = true;
				this.btnOK.Visible = false;

			}
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			this.txtAdd.Clear();
			this.txtConfPassCode.Clear();
			this.txtDesig.Clear();
			this.txtFathersName.Clear();
			this.txtId.Clear();
			this.txtName.Clear();
			this.txtPassCode.Clear();
			this.txtSite.Clear();
			this.txtUsrId.Clear();
			this.chkPass.Checked =true;
			this.btnOK.Visible =true;
			this.btnAdd.Visible =false;
			this.txtName.Focus();

		}

	}
}
