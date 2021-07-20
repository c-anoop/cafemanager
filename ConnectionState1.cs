using System;
using System.Runtime.InteropServices ;

namespace CafeManager
{
	/// <summary>
	/// Summary description for ConnectionState.
	/// </summary>
	public class ConnectionState1
	{
		public ConnectionState1()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		private enum ConnectionStateEnum 
		{ 
			//Local system has a valid connection to the Internet, but it might or might not be currently connected. 
			ConnectionConfigured = 64, 
			//Local system uses a local area network to connect to the Internet. 
			ConnectionLan = 2, 
			//Local system uses a modem to connect to the Internet. 
			ConnectionModem = 1, 
			//No longer used. 
			ConnectionModemBusy = 8, 
			//Local system is in offline mode. 
			ConnectionOffline = 32, 
			//Local system uses a proxy server to connect to the Internet. 
			ConnectionProxy = 4, 
			//Local system has RAS installed. 
			RasInstalled = 16 

		} 

		private class Win32 
		{ 
			[DllImport("Wininet.dll", CharSet=CharSet.Auto)] 
			public static extern int 

				InternetGetConnectedState(out int Flag, int Reserved); 
            
		} 

		private static int GetConnectionFlag() 
		{ 
			int Flag; 
			Win32.InternetGetConnectedState(out Flag,0); 
			return Flag; 
		} 

		public static bool IsModemConnected() 
		{ 
			return ((GetConnectionFlag() & (int) ConnectionStateEnum.ConnectionModem)==0) ? 
				false : true; 
		} 
	
	
	}
}
