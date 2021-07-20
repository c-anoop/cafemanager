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
 {    Code for class frmChat goes here      }
  \****************************************/

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading ;
using System.Text;
using System.IO;
using System.Net.Sockets;  
using System.Runtime.InteropServices ;

namespace CafeManager
{
	/// <summary>
	/// Summary description for frmChat.
	/// </summary>
	/// 
	public delegate void MyEventHandler1(UserConnection sender, string data);
	public delegate void ShutdownHandler(frmServer sender);
	public delegate void LogOffHandler(frmServer sender);
	public delegate void RebootHandler(frmServer sender);
	
	
	public class frmChat : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupbox1;
		private System.Windows.Forms.ListBox lstStatus;
		private System.Windows.Forms.TextBox txtBroadCast;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSend;
		private const int PORT_NUM = 10000;
		private Hashtable clients= new Hashtable() ;
		private TcpListener listener;
		private Thread listenerThread;
		public string msgnodename;
		public string message;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;
		private string neton="NotCon";
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private CafeManager.dsC dsC1;
		private string tempPath = Application.StartupPath + @"\member.mdb";
		private string netoff;
       
		public frmChat()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//oleDbConnection
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=" + tempPath + @";Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			dsC1.Clear();
			oleDbDataAdapter1.Fill(dsC1);
			//oleDbConnection
			
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmChat));
			this.groupbox1 = new System.Windows.Forms.GroupBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBroadCast = new System.Windows.Forms.TextBox();
			this.lstStatus = new System.Windows.Forms.ListBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.dsC1 = new CafeManager.dsC();
			this.groupbox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsC1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupbox1
			// 
			this.groupbox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.btnSend,
																					this.label1,
																					this.txtBroadCast,
																					this.lstStatus});
			this.groupbox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupbox1.Location = new System.Drawing.Point(8, 0);
			this.groupbox1.Name = "groupbox1";
			this.groupbox1.Size = new System.Drawing.Size(376, 336);
			this.groupbox1.TabIndex = 0;
			this.groupbox1.TabStop = false;
			this.groupbox1.Text = "Server Listening :";
			// 
			// btnSend
			// 
			this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSend.Location = new System.Drawing.Point(192, 296);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(72, 24);
			this.btnSend.TabIndex = 3;
			this.btnSend.Text = "&Send";
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 264);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Server Message :";
			// 
			// txtBroadCast
			// 
			this.txtBroadCast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBroadCast.Location = new System.Drawing.Point(120, 264);
			this.txtBroadCast.Name = "txtBroadCast";
			this.txtBroadCast.Size = new System.Drawing.Size(240, 20);
			this.txtBroadCast.TabIndex = 1;
			this.txtBroadCast.Text = "";
			// 
			// lstStatus
			// 
			this.lstStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstStatus.Location = new System.Drawing.Point(16, 16);
			this.lstStatus.Name = "lstStatus";
			this.lstStatus.Size = new System.Drawing.Size(344, 236);
			this.lstStatus.TabIndex = 0;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Charges", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("IntCharges", "IntCharges"),
																																																				   new System.Data.Common.DataColumnMapping("ScanCharges", "ScanCharges"),
																																																				   new System.Data.Common.DataColumnMapping("BlackPrint", "BlackPrint"),
																																																				   new System.Data.Common.DataColumnMapping("ColorPrint", "ColorPrint")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT BlackPrint, ColorPrint, IntCharges, ScanCharges FROM Charges";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Charges(BlackPrint, ColorPrint, IntCharges, ScanCharges) VALUES (?, ?" +
				", ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("BlackPrint", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "BlackPrint", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ColorPrint", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "ColorPrint", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("IntCharges", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "IntCharges", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ScanCharges", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "ScanCharges", System.Data.DataRowVersion.Current, null));
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE Charges SET BlackPrint = ?, ColorPrint = ?, IntCharges = ?, ScanCharges = " +
				"? WHERE (IntCharges = ?)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("BlackPrint", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "BlackPrint", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ColorPrint", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "ColorPrint", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("IntCharges", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "IntCharges", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ScanCharges", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "ScanCharges", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_IntCharges", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "IntCharges", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM Charges WHERE (IntCharges = ?)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_IntCharges", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "IntCharges", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\CafeManager\bin\Debug\member.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// dsC1
			// 
			this.dsC1.DataSetName = "dsC";
			this.dsC1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsC1.Namespace = "http://www.tempuri.org/dsC.xsd";
			// 
			// frmChat
			// 
			this.AcceptButton = this.btnSend;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.ClientSize = new System.Drawing.Size(392, 341);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupbox1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmChat";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "  Chat Window";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmChat_Closing);
			this.Load += new System.EventHandler(this.frmChat_Load);
			this.groupbox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsC1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmChat_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{ 
			//This part stops the listener as well as thread
            listener.Stop(); 
			listenerThread.Abort(); 			
		}

		private void Broadcast(string  strMessage)
		{
			//This part call the user connection class
			UserConnection client;
			foreach (DictionaryEntry entry in clients)
			{
				// This part retreive the value from dictionary Entry
				client = (UserConnection)entry.Value;
				client.SendData(strMessage);
			}
		}

		private void ConnectUser(string userName, UserConnection sender )
		{  
			// This part connect client if it is not in 
			// Dictionaty Entry
			if (clients.Contains(userName))
				ReplyToSender("REFUSE", sender);
			else
			{
				sender.Name = userName;
				UpdateStatus(userName + " has joined the chat.");
				clients.Add(userName, sender);

				// Sends the client join message
				ReplyToSender("JOIN", sender);
				// Sends the client message that it has joined the chat 
				SendToClients("CHAT|" + sender.Name + " has joined the chat.", sender);
				
			//	ActNode(userName);
			}
		}
           
		private void DisconnectUser(string msgDataNode, UserConnection sender)
		{
			// This part remove client from dictionary and
			// send the client message that has left the chat
			UpdateStatus(sender.Name + " has left the chat.");
			SendToClients("CHAT|" + sender.Name + " has left the chat.", sender);
			clients.Remove(sender.Name);
		}

		private void DoListen()
		{
			// This Creates the listener and listens the client 
			// request 
			try
			{
				listener = new TcpListener(PORT_NUM);
				listener.Start();
				do
				{
					UserConnection client = new UserConnection(listener.AcceptTcpClient());
					client.LineReceived += new MyEventHandler1(OnLineReceived); 
					UpdateStatus("New connection found: waiting for log-in");
				}while (true);
			}
			catch
			{
			}
		}

		private void OnLineReceived(UserConnection sender, string data)
		{
			// This part actually identifies the client messages
			// and does the appropirate action
			string[] dataArray = new string[100];
			dataArray = data.Split((char)124);
			switch (dataArray[0])
			{
				case "CONNECT":
                    ActNode(dataArray[0],dataArray[1]);
					ConnectUser(dataArray[1], sender);
					break;
				case "CHAT":
					SendChat(dataArray[1], sender);
					break;
				case "DISCONNECT":
					ActNode(dataArray[0],dataArray[1]);
					DisconnectUser(dataArray[1],sender);
					break;
				case "PATH":
					sendPath(sender);
   					break;
				case "COLOR": 
					ActNode(dataArray[0],dataArray[1]);
					break;
				case "LOGOUT":
					ActNode(dataArray[0],dataArray[1]);
					DisconnectUser(dataArray[1],sender);
					break;

				case "DELETED":
					MessageBox.Show(dataArray[1].ToString());
					break;
                case "TIME":
                    calTime(dataArray[1]);
					break;
				default:
					UpdateStatus("Unknown message:" + data);
					break;
			}
		}

		private void ReplyToSender(string strMessage, UserConnection sender)
		{
			// This part sends the message to client
			sender.SendData(strMessage);
		}

		private void SendChat(string message, UserConnection sender)
		{
			// This part sends chat messages
			UpdateStatus(sender.Name + ": " + message);
			SendToClients("CHAT|" + sender.Name  + ": " + message, sender);
		}

		private void SendToClients(string strMessage, UserConnection sender)
		{
			// This part sends the message to the particular client
			UserConnection client;
			foreach (DictionaryEntry entry in clients)
			{
				client = (UserConnection)entry.Value;
				if (client.Name!=sender.Name)
					client.SendData(strMessage);
			}
		}

		private void UpdateStatus(string statusMessage)
		{ 
			// This part update the list box
			lstStatus.Items.Add(statusMessage);
		}

		private void sendPath(UserConnection sender)
		{
			// This part sends the path of Server database to 
			// the clients
			string path;
			path=Application.StartupPath; 
			ReplyToSender("PATH|" + path, sender);
		}

		private void frmChat_Load(object sender, System.EventArgs e)
		{
			// This part creates and starts new listener thread
			listenerThread = new Thread(new ThreadStart(DoListen));
			listenerThread.Start();
			frmServer.MessageReceived +=new ShutdownHandler(OnMessageReceived);
			frmServer.MessageRec +=new LogOffHandler(OnMessageRec);
			frmServer.RecMessage +=new RebootHandler(OnRecMessage);
		}

		private void btnSend_Click(object sender, System.EventArgs e)
		{
			// This part broadcast message to the clients
			if (txtBroadCast.Text != "")
			{
				UpdateStatus("Broadcasting: " + txtBroadCast.Text);
				Broadcast("BROAD|" + txtBroadCast.Text);
				txtBroadCast.Text = "";
			}		
		}

		private void ActNode(string caseMessage,string msgDataNode)
		{
			// This part uses method invoker object to communicate 
			// with another thread 
			message=caseMessage;
			msgnodename=msgDataNode;
					
			try
			{
				MethodInvoker mi = new MethodInvoker(this.UpdateProgress);
				this.BeginInvoke(mi);
				Thread.Sleep(10);	
			}
			catch(Exception)
			{
			}
			
		}
		private void UpdateProgress()
		{
			// This part changes the color of the buttons
			try
			{
				for(int i=0;i<frmDisp.btnTemp.Length ;i++)
				{
					
					if(msgnodename.ToUpper() ==frmDisp.btnTemp[i].Name && message =="CONNECT" )
					{
						frmDisp.btnTemp[i].Image = Image.FromFile(Application.StartupPath + @"\temp.bmp");
						
					}
					else if (msgnodename.ToUpper()==frmDisp.btnTemp[i].Name && message == "COLOR")
					{
						frmDisp.btnTemp[i].Image = Image.FromFile(Application.StartupPath + @"\on.bmp");
						
					}
					else if(msgnodename.ToUpper() ==frmDisp.btnTemp[i].Name && message == "DISCONNECT")
					{
						frmDisp.btnTemp[i].Image = Image.FromFile(Application.StartupPath + @"\off.bmp");
						

					}
					else if(msgnodename.ToUpper()== frmDisp.btnTemp[i].Name && message == "LOGOUT")
					{
 						frmDisp.btnTemp[i].Image = Image.FromFile(Application.StartupPath + @"\temp.bmp");
					}
				}
			}
			catch(Exception)
			{
			}
		}
		private void OnMessageReceived(frmServer sender)
		{
			// Sends the shutdown message to all the clients
	        Broadcast("SHUTDOWN|" );
		}
		private void OnMessageRec(frmServer sender)
		{
			// Sends the logoff message to all the clients
			Broadcast("LOGOFFALL|" );
		}

		private void OnRecMessage(frmServer sender)
		{
			Broadcast("REBOOTALL|");
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			// This part checks connection and disconnection 
			// of internet connection and broadcasts corresponding
			// messages
			if (ConnectionState1.IsModemConnected()&& neton == "NotCon")
			{
				this.neton  = "Con";
				Broadcast("NETON");
			}

			if (!ConnectionState1.IsModemConnected()&& neton == "Con") 
			{
				this.neton  = "NotCon";
				Broadcast("NETOFF");
			}
		}
		private void calTime(string strTemp)
		{
//			string[] array1 = new string[2];
//			array1=strTemp.Split(new char[]{':'},2);
            int timeCount, intTimeCount;
//			recNo=array1[0].ToString(); 

            string rt= dsC1.Charges.Rows[0]["IntCharges"].ToString(); 
			int ch=Convert.ToInt32(rt);
			timeCount=Convert.ToInt32(strTemp);
//			int intTimeCount=Convert.ToInt32(timeCount);
			intTimeCount=timeCount/ch;
			MessageBox.Show("Your bill is " + intTimeCount.ToString()); 
            
		}
	}
}
