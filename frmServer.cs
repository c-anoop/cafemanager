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
 {    Code for class frmServer goes here    }
  \****************************************/

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace CafeManager
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmServer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mnuMain;
		private System.Windows.Forms.MenuItem mnuNew;
		private System.Windows.Forms.MenuItem submnuNewUser;
		private System.Windows.Forms.MenuItem submnuNewMember;
		private System.Windows.Forms.MenuItem mnuTools;
		private System.Windows.Forms.MenuItem submnuToolsConf;
		private System.Windows.Forms.MenuItem submnuToolsConfClients;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem submnuHelpCafe;
		private System.Windows.Forms.MenuItem submnuHelpTopics;
		private System.Windows.Forms.ToolBar tlbrServer;
		private System.Windows.Forms.ToolBarButton BttnNewUsr;
		private System.Windows.Forms.ToolBarButton bttnNewMem;
		private System.Windows.Forms.ImageList imgServer;
		private System.Windows.Forms.MenuItem submnuToolsConfCafeSettings;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MenuItem submnuToolsConfSwUsers;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.ToolBarButton bttnCafe;
		private System.Windows.Forms.ToolBarButton bttnSwUsers;
		private System.Windows.Forms.MenuItem submnuViewUser;
		private System.Windows.Forms.MenuItem submnuViewMember;
		private System.Windows.Forms.MenuItem submnuViewUserSngUsr;
		private System.Windows.Forms.MenuItem submnuViewUserFullDb;
		private System.Windows.Forms.MenuItem submnuViewMemSngMem;
		private System.Windows.Forms.MenuItem submnuViewMemFullDb;
		private System.Windows.Forms.MenuItem mnuEdit;
		private System.Windows.Forms.MenuItem submnuEditUsr;
		private System.Windows.Forms.MenuItem submnuEditMem;
		private System.Windows.Forms.MenuItem submnuEditSwUsr;
		private System.Windows.Forms.MenuItem submnuEditPassCode;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem submnuNewExit;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem21;
        public bool boolValid1=false; 

		public frmServer()
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
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmServer));
			this.mnuMain = new System.Windows.Forms.MainMenu();
			this.mnuNew = new System.Windows.Forms.MenuItem();
			this.submnuNewUser = new System.Windows.Forms.MenuItem();
			this.submnuNewMember = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.submnuNewExit = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.mnuEdit = new System.Windows.Forms.MenuItem();
			this.submnuEditUsr = new System.Windows.Forms.MenuItem();
			this.submnuEditMem = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.submnuEditSwUsr = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.submnuEditPassCode = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.submnuViewUser = new System.Windows.Forms.MenuItem();
			this.submnuViewUserSngUsr = new System.Windows.Forms.MenuItem();
			this.submnuViewUserFullDb = new System.Windows.Forms.MenuItem();
			this.submnuViewMember = new System.Windows.Forms.MenuItem();
			this.submnuViewMemSngMem = new System.Windows.Forms.MenuItem();
			this.submnuViewMemFullDb = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.mnuTools = new System.Windows.Forms.MenuItem();
			this.submnuToolsConf = new System.Windows.Forms.MenuItem();
			this.submnuToolsConfClients = new System.Windows.Forms.MenuItem();
			this.submnuToolsConfCafeSettings = new System.Windows.Forms.MenuItem();
			this.submnuToolsConfSwUsers = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.submnuHelpCafe = new System.Windows.Forms.MenuItem();
			this.submnuHelpTopics = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.tlbrServer = new System.Windows.Forms.ToolBar();
			this.BttnNewUsr = new System.Windows.Forms.ToolBarButton();
			this.bttnNewMem = new System.Windows.Forms.ToolBarButton();
			this.bttnCafe = new System.Windows.Forms.ToolBarButton();
			this.bttnSwUsers = new System.Windows.Forms.ToolBarButton();
			this.imgServer = new System.Windows.Forms.ImageList(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuNew,
																					this.mnuEdit,
																					this.menuItem4,
																					this.mnuTools,
																					this.menuItem2});
			// 
			// mnuNew
			// 
			this.mnuNew.Index = 0;
			this.mnuNew.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.submnuNewUser,
																				   this.submnuNewMember,
																				   this.menuItem5,
																				   this.submnuNewExit,
																				   this.menuItem7,
																				   this.menuItem8});
			this.mnuNew.Text = "&New";
			// 
			// submnuNewUser
			// 
			this.submnuNewUser.Index = 0;
			this.submnuNewUser.Shortcut = System.Windows.Forms.Shortcut.CtrlU;
			this.submnuNewUser.Text = "User";
			this.submnuNewUser.Click += new System.EventHandler(this.submnuNewUser_Click);
			// 
			// submnuNewMember
			// 
			this.submnuNewMember.Index = 1;
			this.submnuNewMember.Shortcut = System.Windows.Forms.Shortcut.CtrlM;
			this.submnuNewMember.Text = "Member";
			this.submnuNewMember.Click += new System.EventHandler(this.submnuNewMember_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.Text = "-";
			// 
			// submnuNewExit
			// 
			this.submnuNewExit.Index = 3;
			this.submnuNewExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
			this.submnuNewExit.Text = "Exit";
			this.submnuNewExit.Click += new System.EventHandler(this.submnuNewExit_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 4;
			this.menuItem7.Text = "-";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 5;
			this.menuItem8.Text = "-";
			// 
			// mnuEdit
			// 
			this.mnuEdit.Index = 1;
			this.mnuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.submnuEditUsr,
																					this.submnuEditMem,
																					this.menuItem9,
																					this.submnuEditSwUsr,
																					this.menuItem10,
																					this.submnuEditPassCode,
																					this.menuItem11,
																					this.menuItem12});
			this.mnuEdit.Text = "&Edit";
			// 
			// submnuEditUsr
			// 
			this.submnuEditUsr.Index = 0;
			this.submnuEditUsr.Text = "User";
			this.submnuEditUsr.Click += new System.EventHandler(this.submnuEditUsr_Click);
			// 
			// submnuEditMem
			// 
			this.submnuEditMem.Index = 1;
			this.submnuEditMem.Text = "Member";
			this.submnuEditMem.Click += new System.EventHandler(this.submnuEditMem_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 2;
			this.menuItem9.Text = "-";
			// 
			// submnuEditSwUsr
			// 
			this.submnuEditSwUsr.Index = 3;
			this.submnuEditSwUsr.Text = "Software Users";
			this.submnuEditSwUsr.Click += new System.EventHandler(this.submnuEditSwUsr_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 4;
			this.menuItem10.Text = "-";
			// 
			// submnuEditPassCode
			// 
			this.submnuEditPassCode.Index = 5;
			this.submnuEditPassCode.Text = "PassCode";
			this.submnuEditPassCode.Click += new System.EventHandler(this.submnuEditPassCode_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 6;
			this.menuItem11.Text = "-";
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 7;
			this.menuItem12.Text = "-";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.submnuViewUser,
																					  this.submnuViewMember,
																					  this.menuItem13,
																					  this.menuItem14});
			this.menuItem4.Text = "&View";
			// 
			// submnuViewUser
			// 
			this.submnuViewUser.Index = 0;
			this.submnuViewUser.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.submnuViewUserSngUsr,
																						   this.submnuViewUserFullDb});
			this.submnuViewUser.Text = "User";
			// 
			// submnuViewUserSngUsr
			// 
			this.submnuViewUserSngUsr.Index = 0;
			this.submnuViewUserSngUsr.Text = "Single User";
			this.submnuViewUserSngUsr.Click += new System.EventHandler(this.submnuViewUserSngUsr_Click);
			// 
			// submnuViewUserFullDb
			// 
			this.submnuViewUserFullDb.Index = 1;
			this.submnuViewUserFullDb.Text = "Full Database";
			this.submnuViewUserFullDb.Click += new System.EventHandler(this.submnuViewUserFullDb_Click);
			// 
			// submnuViewMember
			// 
			this.submnuViewMember.Index = 1;
			this.submnuViewMember.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							 this.submnuViewMemSngMem,
																							 this.submnuViewMemFullDb});
			this.submnuViewMember.Text = "Member";
			// 
			// submnuViewMemSngMem
			// 
			this.submnuViewMemSngMem.Index = 0;
			this.submnuViewMemSngMem.Text = "Single Member";
			this.submnuViewMemSngMem.Click += new System.EventHandler(this.submnuViewMemSngMem_Click);
			// 
			// submnuViewMemFullDb
			// 
			this.submnuViewMemFullDb.Index = 1;
			this.submnuViewMemFullDb.Text = "Full Database";
			this.submnuViewMemFullDb.Click += new System.EventHandler(this.submnuViewMemFullDb_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 2;
			this.menuItem13.Text = "-";
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 3;
			this.menuItem14.Text = "-";
			// 
			// mnuTools
			// 
			this.mnuTools.Index = 3;
			this.mnuTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.submnuToolsConf,
																					 this.menuItem15,
																					 this.menuItem16,
																					 this.menuItem6,
																					 this.menuItem21});
			this.mnuTools.Text = "&Tools";
			// 
			// submnuToolsConf
			// 
			this.submnuToolsConf.Index = 0;
			this.submnuToolsConf.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.submnuToolsConfClients,
																							this.submnuToolsConfCafeSettings,
																							this.submnuToolsConfSwUsers});
			this.submnuToolsConf.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.submnuToolsConf.Text = "Configurations";
			// 
			// submnuToolsConfClients
			// 
			this.submnuToolsConfClients.Index = 0;
			this.submnuToolsConfClients.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftC;
			this.submnuToolsConfClients.Text = "Clients";
			this.submnuToolsConfClients.Click += new System.EventHandler(this.submnuToolsConfClients_Click);
			// 
			// submnuToolsConfCafeSettings
			// 
			this.submnuToolsConfCafeSettings.Index = 1;
			this.submnuToolsConfCafeSettings.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftA;
			this.submnuToolsConfCafeSettings.Text = "Cafe Settings";
			this.submnuToolsConfCafeSettings.Click += new System.EventHandler(this.submnuToolsConfCafeSettings_Click);
			// 
			// submnuToolsConfSwUsers
			// 
			this.submnuToolsConfSwUsers.Index = 2;
			this.submnuToolsConfSwUsers.Text = "Software Users";
			this.submnuToolsConfSwUsers.Click += new System.EventHandler(this.submnuToolsConfSwUsers_Click);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 1;
			this.menuItem15.Text = "-";
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 2;
			this.menuItem16.Text = "Shutdown All";
			this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 3;
			this.menuItem6.Text = "LogOff All";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 4;
			this.menuItem21.Text = "Reboot All";
			this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 4;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.submnuHelpCafe,
																					  this.submnuHelpTopics,
																					  this.menuItem19,
																					  this.menuItem20});
			this.menuItem2.Text = "&Help";
			// 
			// submnuHelpCafe
			// 
			this.submnuHelpCafe.Index = 0;
			this.submnuHelpCafe.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.submnuHelpCafe.Text = "About Cafe Manager";
			this.submnuHelpCafe.Click += new System.EventHandler(this.submnuHelpCafe_Click);
			// 
			// submnuHelpTopics
			// 
			this.submnuHelpTopics.Index = 1;
			this.submnuHelpTopics.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
			this.submnuHelpTopics.Text = "Help Topics";
			this.submnuHelpTopics.Click += new System.EventHandler(this.submnuHelpTopics_Click);
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 2;
			this.menuItem19.Text = "-";
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 3;
			this.menuItem20.Text = "-";
			// 
			// tlbrServer
			// 
			this.tlbrServer.AccessibleName = "tlbrServer";
			this.tlbrServer.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.tlbrServer.AutoSize = false;
			this.tlbrServer.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						  this.BttnNewUsr,
																						  this.bttnNewMem,
																						  this.bttnCafe,
																						  this.bttnSwUsers});
			this.tlbrServer.ButtonSize = new System.Drawing.Size(50, 60);
			this.tlbrServer.Divider = false;
			this.tlbrServer.DropDownArrows = true;
			this.tlbrServer.ImageList = this.imgServer;
			this.tlbrServer.Name = "tlbrServer";
			this.tlbrServer.ShowToolTips = true;
			this.tlbrServer.Size = new System.Drawing.Size(400, 32);
			this.tlbrServer.TabIndex = 0;
			this.tlbrServer.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tlbrServer_ButtonClick);
			// 
			// BttnNewUsr
			// 
			this.BttnNewUsr.ImageIndex = 0;
			this.BttnNewUsr.ToolTipText = "New User";
			// 
			// bttnNewMem
			// 
			this.bttnNewMem.ImageIndex = 1;
			this.bttnNewMem.ToolTipText = "New Member";
			// 
			// bttnCafe
			// 
			this.bttnCafe.ImageIndex = 2;
			this.bttnCafe.ToolTipText = "Cafe Settings";
			// 
			// bttnSwUsers
			// 
			this.bttnSwUsers.ImageIndex = 3;
			this.bttnSwUsers.ToolTipText = "Software Users";
			// 
			// imgServer
			// 
			this.imgServer.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgServer.ImageSize = new System.Drawing.Size(30, 30);
			this.imgServer.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgServer.ImageStream")));
			this.imgServer.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// frmServer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.DodgerBlue;
			this.ClientSize = new System.Drawing.Size(400, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tlbrServer});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.mnuMain;
			this.Name = "frmServer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "  Cyber Cafe Manager";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmServer_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]

		/****************************************\
	   {        Main function goes here           }
		\****************************************/ 
		static void Main() 
		{
			Application.Run(new frmServer());
		}

		private void submnuNewUser_Click(object sender, System.EventArgs e)
		{
			//  This part shows the form for new User
			frmUser frmUsr = new frmUser();
			frmUsr.ShowDialog();
		}

		private void frmServer_Load(object sender, System.EventArgs e)
		{
			// This part checks the permissions
			frmSecurity frmUsr = new frmSecurity();
			frmUsr.ShowDialog();

			// This part displays the Nodes				
			frmDisp frmTemp=new frmDisp ();
            frmTemp.MdiParent=this;
			frmTemp.Show(); 
		}

		private void tlbrServer_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch(tlbrServer.Buttons.IndexOf(e.Button))
			{
					// This part checks which button is pressed 
					// on the toolbar
					case 0:
						  submnuNewUser_Click(sender,e);
					break;
				    case 1:
					      submnuNewMember_Click(sender,e);
					break;
					case 2:
						 submnuToolsConfCafeSettings_Click(sender,e);
					break;
			}
		}

		private void submnuNewMember_Click(object sender, System.EventArgs e)
		{
		    // This part shows the new member form
			frmMem frmUsr = new frmMem();
			frmUsr.ShowDialog();   
		}

		private void submnuToolsConfCafeSettings_Click(object sender, System.EventArgs e)
		{
			// This part shows the cafe settings form 
			// after checking the necessary super user
			// permissions
			frmSuperUser frmSuper= new frmSuperUser();
			frmSuper.ShowDialog();
			if((string)frmSuper.Tag=="Access Granted")
			{
				frmCafe frmTemp=new frmCafe();
				frmTemp.ShowDialog();
			}
	 	}

//		private void submnuToolsConfServer_Click(object sender, System.EventArgs e)
//		{
//			
//			// This part shows the server configurations form 
//			// after checking the necessary super user
//			// permissions
//			frmSuperUser frmSuper = new frmSuperUser();
//			frmSuper.ShowDialog();
//			if((string)frmSuper.Tag=="Access Granted")
//			{
//				frmCafe frmTemp=new frmCafe();
//				frmTemp.ShowDialog();
//			}
//		}

		private void submnuToolsConfSwUsers_Click(object sender, System.EventArgs e)
		{
			// This part shows the Software users form 
			// after checking the necessary super user
			// permissions
			frmSuperUser frmSuper=new frmSuperUser();
			frmSuper.ShowDialog();
			
			if ((string)frmSuper.Tag=="Access Granted")
			{
				frmSwUsers frmTemp=new frmSwUsers();
				frmTemp.ShowDialog();
			}
		}

		private void submnuToolsConfClients_Click(object sender, System.EventArgs e)
		{   
			// This part shows the IPNodes form
			frmIpNodes frmNodes = new frmIpNodes();
			frmNodes.ShowDialog();
		}

		private void submnuViewUserFullDb_Click(object sender, System.EventArgs e)
		{
			// This part shows the full database
			// of the users
            frmViewUser frmTemp=new frmViewUser();
			frmTemp.MdiParent=this;
			frmTemp.Show(); 
		}

		private void submnuViewUserSngUsr_Click(object sender, System.EventArgs e)
		{
			// This part shows the single user search form
			frmViewSngUsr frmSngUsr=new frmViewSngUsr();
			frmSngUsr.ShowDialog();
		}

		private void submnuViewMemSngMem_Click(object sender, System.EventArgs e)
		{
			//This part shows the single member search form
			frmViewSngMem frmSngMem=new frmViewSngMem();
			frmSngMem.ShowDialog();
		}

		private void submnuViewMemFullDb_Click(object sender, System.EventArgs e)
		{
			// this part shows the full database of the 
			// members
			frmViewMem frmTemp=new frmViewMem();
			frmTemp.MdiParent=this;
			frmTemp.Show(); 
		}

		private void submnuNewExit_Click(object sender, System.EventArgs e)
		{
            // This part closes the application
			this.Close(); 
		}

		private void submnuEditUsr_Click(object sender, System.EventArgs e)
		{		
			// This part updates the information of the
			// the user        
		    frmEditUser frmTemp= new frmEditUser();
		    frmTemp.ShowDialog();
       }

		private void submnuHelpCafe_Click(object sender, System.EventArgs e)
		{
			// This part shows aboutcafe manager form
           frmHlpAbout frmTemp=new frmHlpAbout();
		   frmTemp.ShowDialog();
 		}

		private void submnuHelpTopics_Click(object sender, System.EventArgs e)
		{
			// This part shows the help topics form
		   Form1 frmTemp=new Form1();
		   frmTemp.ShowDialog();
        }

		private void submnuEditMem_Click(object sender, System.EventArgs e)
		{
			// This part editd the member information
			frmEditMem frmTemp=new frmEditMem();
			frmTemp.ShowDialog(); 
		}

		private void submnuEditSwUsr_Click(object sender, System.EventArgs e)
		{
			// This part checks for the necessary permissions
			frmSecurity2 frmS=new frmSecurity2();
			frmS.ShowDialog();

			// If access is granted then shows form edit software users
			if ((string)frmS.Tag=="Access Granted")
			{
				frmEditSwUsers frmTemp=new frmEditSwUsers(frmSecurity2.temp1);
				frmTemp.ShowDialog();
			}
		}

		private void submnuEditPassCode_Click(object sender, System.EventArgs e)
		{
			// This part shows the edit passcode form
			frmChngPassCode frmTemp1= new frmChngPassCode();
			frmTemp1.ShowDialog();
 		}

		// This event is for shutdowning all the systems 
		public static event ShutdownHandler MessageReceived;

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			// This part fires the event for shutdowning the
			// Systems
			this.onEvent(this);
		}

		private void onEvent(frmServer temp1)
		{
			// This part is for fires the event
			if (MessageReceived!=null)
				MessageReceived(temp1);
		}

		// This event is for shutdowning all the systems 
		public static event LogOffHandler MessageRec;

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
		this.onLogOffEvent(this);
		}
		
		private void onLogOffEvent(frmServer temp1)
		{
			// This part is for fires the event
			if (MessageRec!=null)
				MessageRec(temp1);
		}

		public static event RebootHandler RecMessage;

		private void menuItem21_Click(object sender, System.EventArgs e)
		{
		this.onRebootEvent(this);
		}
		private void onRebootEvent(frmServer temp1)
		{
			if(RecMessage!=null)
				RecMessage(temp1);
		}

		private void submnuBillsNetCharges_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
