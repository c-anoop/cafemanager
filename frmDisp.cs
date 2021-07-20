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
 {    Code for class frmDisp goes here      }
  \****************************************/

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CafeManager
{
	/// <summary>
	/// Summary description for frmDisp.
	/// </summary>
	/// 
	
	public class frmDisp : System.Windows.Forms.Form
	{    
		public static System.Windows.Forms.Button[] btnTemp;
		private System.Windows.Forms.Panel pnlNodes;
		private System.Windows.Forms.MenuItem menuItem1;
		private frmChat frmTemp1;
		public static string data = null;
		private string tempPath = Application.StartupPath + @"\member.mdb";
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private CafeManager.dsNode dsNode1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;

		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDisp()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//oleDbConnection
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=" + tempPath + @";Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";

			// This part clears the DataSet
			dsNode1.Clear();

			// This part fills the Data Set from the database
			oleDbDataAdapter1.Fill(dsNode1);

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmDisp));
			this.pnlNodes = new System.Windows.Forms.Panel();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dsNode1 = new CafeManager.dsNode();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dsNode1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlNodes
			// 
			this.pnlNodes.AutoScroll = true;
			this.pnlNodes.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.pnlNodes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlNodes.Name = "pnlNodes";
			this.pnlNodes.Size = new System.Drawing.Size(292, 266);
			this.pnlNodes.TabIndex = 0;
			// 
			// menuItem1
			// 
			this.menuItem1.Index = -1;
			this.menuItem1.Text = "";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Nodes", new System.Data.Common.DataColumnMapping[] {
																																																				 new System.Data.Common.DataColumnMapping("Nodes", "Nodes")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM Nodes WHERE (Nodes = ?)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nodes", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Nodes", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Nodes(Nodes) VALUES (?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nodes", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Nodes", System.Data.DataRowVersion.Current, null));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Nodes FROM Nodes";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE Nodes SET Nodes = ? WHERE (Nodes = ?)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nodes", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Nodes", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nodes", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Nodes", System.Data.DataRowVersion.Original, null));
			// 
			// dsNode1
			// 
			this.dsNode1.DataSetName = "dsNode";
			this.dsNode1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsNode1.Namespace = "http://www.tempuri.org/dsNode.xsd";
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem2,
																						 this.menuItem3,
																						 this.menuItem4,
																						 this.menuItem5,
																						 this.menuItem6});
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "&Status";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "&Login Time";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "&Log Off";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 3;
			this.menuItem5.Text = "&Shutdown";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 4;
			this.menuItem6.Text = "&Reboot";
			// 
			// frmDisp
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.MediumPurple;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pnlNodes});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmDisp";
			this.Text = "Nodes";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmDisp_Closing);
			this.Load += new System.EventHandler(this.frmDisp_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsNode1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
        
	   	
		private void frmDisp_Load(object sender, System.EventArgs e)
		{   
			// This part shows the nodes
			//by calling function Nodes
			nodes();

			// This part shows the form frmChat
			frmTemp1= new frmChat();
			frmTemp1.Show ();
		}
      
		// Creates a public DataView Object
		public DataView dv;
		string n;
		public int nod;
		private void nodes()
		{
			
			int intTemp=47,j=47;
			
			dv=new DataView(dsNode1.Tables[0],"","Nodes",DataViewRowState.CurrentRows);
			// n stores the value retreived from database

            foreach(DataRowView drv in dv)
				n = drv.Row[0].ToString();
			
			// nod stores the integer value of n
			nod = System.Convert.ToInt32(n);

			// This part creates the array of button dynamically
			btnTemp = new System.Windows.Forms.Button[nod];  
			for (int i=0;i<nod;i++)
			{   
				frmDisp.btnTemp[i]=new System.Windows.Forms.Button();
				frmDisp.btnTemp[i].Name="NODE-" + (i+1);
				frmDisp.btnTemp[i].Text="Node" + (i+1);
				this.pnlNodes.Controls.AddRange(new System.Windows.Forms.Control[]{frmDisp.btnTemp[i]}); 
				frmDisp.btnTemp[i].Location = new System.Drawing.Point(intTemp,j);
				frmDisp.btnTemp[i].FlatStyle=FlatStyle.Flat; 
				frmDisp.btnTemp[i].Size=new System.Drawing.Size (60,55);
				frmDisp.btnTemp[i].Image=Image.FromFile(Application.StartupPath + @"\off.bmp");
				
			    frmDisp.btnTemp[i].ContextMenu =this.contextMenu1;

				intTemp+=80;
				if (intTemp>700)
				{
					j+=80;
					intTemp=47;
				}
			}
		}
		
		private void frmDisp_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{	
			// This part actually closes the same form
			DialogResult r1= MessageBox.Show("Are you sure to quit?","WARNING",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
			if(r1==DialogResult.OK )
			{
				e.Cancel =false;
				frmTemp1.Dispose(); 
			}
			else
				e.Cancel =true;	
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			for(int i=1;i<nod;i++)
			{
				if(this.contextMenu1.SourceControl ==frmDisp.btnTemp[i])
					MessageBox.Show("Node-" + (i+1));
			}
		
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
//			for(int i=1;i<nod;i++)
//			{
//				if(this.contextMenu1.SourceControl ==frmDisp.btnTemp[i])
//				{
//					
//				}
//					
//			}
		}
	

			
		
	}
}