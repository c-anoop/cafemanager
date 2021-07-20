using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CafeManager
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageContents;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ImageList imgButtons;
		private System.Windows.Forms.RichTextBox rtb;
		private System.ComponentModel.IContainer components;

		public Form1()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageContents = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.imgButtons = new System.Windows.Forms.ImageList(this.components);
			this.rtb = new System.Windows.Forms.RichTextBox();
			this.tabControl1.SuspendLayout();
			this.tabPageContents.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPageContents});
			this.tabControl1.ImageList = this.imageList1;
			this.tabControl1.Location = new System.Drawing.Point(8, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.ShowToolTips = true;
			this.tabControl1.Size = new System.Drawing.Size(216, 336);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
			// 
			// tabPageContents
			// 
			this.tabPageContents.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabPageContents.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.panel1});
			this.tabPageContents.Location = new System.Drawing.Point(4, 23);
			this.tabPageContents.Name = "tabPageContents";
			this.tabPageContents.Size = new System.Drawing.Size(208, 309);
			this.tabPageContents.TabIndex = 0;
			this.tabPageContents.Text = "Contents";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.treeView1});
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 296);
			this.panel1.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.treeView1.HotTracking = true;
			this.treeView1.ImageList = this.imageList1;
			this.treeView1.Location = new System.Drawing.Point(8, 8);
			this.treeView1.Name = "treeView1";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
																				  new System.Windows.Forms.TreeNode("Cafe Manager", new System.Windows.Forms.TreeNode[] {
																																											new System.Windows.Forms.TreeNode("Cafe Manager Overview", 1, 1),
																																											new System.Windows.Forms.TreeNode("Create New  User , Member or Software User", 2, 2),
																																											new System.Windows.Forms.TreeNode("Change information of user, member or software user", 2, 2),
																																											new System.Windows.Forms.TreeNode("View the information of particular user, member or software user", 6, 6),
																																											new System.Windows.Forms.TreeNode("Cafe Settings", 3, 3)})});
			this.treeView1.PathSeparator = "";
			this.treeView1.ShowLines = false;
			this.treeView1.ShowPlusMinus = false;
			this.treeView1.ShowRootLines = false;
			this.treeView1.Size = new System.Drawing.Size(184, 272);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseMove);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imgButtons
			// 
			this.imgButtons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imgButtons.ImageSize = new System.Drawing.Size(16, 16);
			this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
			this.imgButtons.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// rtb
			// 
			this.rtb.AutoSize = true;
			this.rtb.AutoWordSelection = true;
			this.rtb.Cursor = System.Windows.Forms.Cursors.No;
			this.rtb.Location = new System.Drawing.Point(232, 24);
			this.rtb.Name = "rtb";
			this.rtb.ReadOnly = true;
			this.rtb.Size = new System.Drawing.Size(248, 336);
			this.rtb.TabIndex = 4;
			this.rtb.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(496, 376);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.rtb,
																		  this.tabControl1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "  Help Topics";
			this.Click += new System.EventHandler(this.Form1_Click);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPageContents.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if(e.Node.Text=="Cafe Manager")
			{
				this.Text ="Cafe Manager";
			}
			
	    	if(e.Node.Text=="Cafe Manager Overview")
			{
				this.Text ="Cafe Manager Overview";
			}
			if(e.Node.Text=="Create New  User , Member or Software User")
			{
				this.Text="Create New  User , Member or Software User";
			}
			if(e.Node.Text=="Change information of user, member or software user")
			{
				this.Text="Change information of user, member or software user";
			}
			if(e.Node.Text=="View the information of particular user, member or software user")
			{
				this.Text="View information of particular user, member or software user";
			}
			if(e.Node.Text=="Cafe Settings")
			{
				this.Text="Cafe Settings";
			}
			
     		page();

			
		}

		private void treeView1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
//			treeView1.SelectedNode.ForeColor=System.Drawing.Color.Red;
//			

		}

		private void txtOverView_TextChanged(object sender, System.EventArgs e)
		{
		
		}
		
		private void page()
		{
			if(treeView1.SelectedNode.Text=="Cafe Manager")
			{
              rtb.LoadFile(Application.StartupPath + @"\overview.rtf",RichTextBoxStreamType.RichText);
			} 
			if(treeView1.SelectedNode.Text=="Cafe Manager Overview")
			{
				rtb.LoadFile(Application.StartupPath + @"\overview.rtf",RichTextBoxStreamType.RichText);
			}
			if(treeView1.SelectedNode.Text=="Create New  User , Member or Software User")
			{
				rtb.LoadFile(Application.StartupPath + @"\Create.rtf",RichTextBoxStreamType.RichText);
			}

			if(treeView1.SelectedNode.Text=="Change information of user, member or software user")
			{
			rtb.LoadFile(Application.StartupPath + @"\Change.rtf",RichTextBoxStreamType.RichText);	
			}

			if(treeView1.SelectedNode.Text=="View the information of particular user, member or software user")
			{
             rtb.LoadFile(Application.StartupPath + @"\View.rtf",RichTextBoxStreamType.RichText);					
			}

			if(treeView1.SelectedNode.Text=="Cafe Settings")
			{
				rtb.LoadFile(Application.StartupPath + @"\CafeSettings.rtf",RichTextBoxStreamType.RichText);					
				
			}
			

		    
		}

		private void tabPageSearch_Click(object sender, System.EventArgs e)
		{
		
		}

		private void Form1_Click(object sender, System.EventArgs e)
		{
			
		}

		private void tabPageSearch_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
		}

		

		private void tabControl1_TabIndexChanged(object sender, System.EventArgs e)
		{
			

		
		}

		private void tabPageIndex_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{


		}
	}
}
