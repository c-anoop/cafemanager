using System;
using System.Net ;
using System.Net.Sockets;
using System.Text ;

namespace CafeManager
{
	/// <summary>
	/// Summary description for UserConnection.
	/// </summary>
	public class UserConnection
	{

		const int READ_BUFFER_SIZE = 255;
		private TcpClient client;
		private byte[] readBuffer= new byte[READ_BUFFER_SIZE];
		private string strName; 

		public UserConnection(TcpClient client)
		{
			this.client=client;
			this.client.GetStream().BeginRead(readBuffer, 0, READ_BUFFER_SIZE, new AsyncCallback(StreamReceiver), null);
		}
		public void SendData(string Data)
		{
			lock(client.GetStream())
			{
				System.IO.StreamWriter writer;
				writer=new System.IO.StreamWriter(client.GetStream());
				writer.Write(Data + (char)13 + (char)10);
				writer.Flush();
			}
		}	

		public event MyEventHandler1 LineReceived;

		private void StreamReceiver(IAsyncResult ar)
		{
			int BytesRead;
			string strMessage;
			try
			{
				lock(client.GetStream())
				{
					BytesRead = client.GetStream().EndRead(ar) ;
				}
				strMessage = Encoding.ASCII.GetString(readBuffer, 0, BytesRead - 1);
				
				this.onEvent(this, strMessage);
		
				lock(client.GetStream())
				{
					client.GetStream().BeginRead(readBuffer, 0, READ_BUFFER_SIZE, new AsyncCallback(StreamReceiver), null);
				}
			}																				 
			catch
			{
			}
	  	}
		private void onEvent(UserConnection temp1, string temp2)
		{
			if (LineReceived!=null)
				LineReceived(temp1,temp2);
		}
		public string Name
		{
			get
			{
				return strName;
			}
			set
			{
				strName = value;
			}
		}
	}
}
