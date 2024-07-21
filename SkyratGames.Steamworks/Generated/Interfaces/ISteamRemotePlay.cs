using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Steamworks.Data;


namespace Steamworks
{
	internal unsafe class ISteamRemotePlay : SteamInterface
	{
		
		internal ISteamRemotePlay( bool IsGameServer )
		{
			SetupInterface( IsGameServer );
		}
		
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_SteamRemotePlay_v002", CallingConvention = Platform.CC)]
		internal static extern IntPtr SteamAPI_SteamRemotePlay_v002();
		public override IntPtr GetUserInterfacePointer() => SteamAPI_SteamRemotePlay_v002();
		
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionCount", CallingConvention = Platform.CC)]
		internal static extern uint _GetSessionCount( IntPtr self );
		
		#endregion
		internal uint GetSessionCount()
		{
			var returnValue = _GetSessionCount( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionID", CallingConvention = Platform.CC)]
		internal static extern RemotePlaySessionID_t _GetSessionID( IntPtr self, int iSessionIndex );
		
		#endregion
		internal RemotePlaySessionID_t GetSessionID( int iSessionIndex )
		{
			var returnValue = _GetSessionID( Self, iSessionIndex );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionSteamID", CallingConvention = Platform.CC)]
		internal static extern SteamId _GetSessionSteamID( IntPtr self, RemotePlaySessionID_t unSessionID );
		
		#endregion
		internal SteamId GetSessionSteamID( RemotePlaySessionID_t unSessionID )
		{
			var returnValue = _GetSessionSteamID( Self, unSessionID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionClientName", CallingConvention = Platform.CC)]
		internal static extern Utf8StringPointer _GetSessionClientName( IntPtr self, RemotePlaySessionID_t unSessionID );
		
		#endregion
		internal string GetSessionClientName( RemotePlaySessionID_t unSessionID )
		{
			var returnValue = _GetSessionClientName( Self, unSessionID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionClientFormFactor", CallingConvention = Platform.CC)]
		internal static extern SteamDeviceFormFactor _GetSessionClientFormFactor( IntPtr self, RemotePlaySessionID_t unSessionID );
		
		#endregion
		internal SteamDeviceFormFactor GetSessionClientFormFactor( RemotePlaySessionID_t unSessionID )
		{
			var returnValue = _GetSessionClientFormFactor( Self, unSessionID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_BGetSessionClientResolution", CallingConvention = Platform.CC)]
		[return: MarshalAs( UnmanagedType.I1 )]
		internal static extern bool _BGetSessionClientResolution( IntPtr self, RemotePlaySessionID_t unSessionID, ref int pnResolutionX, ref int pnResolutionY );
		
		#endregion
		internal bool BGetSessionClientResolution( RemotePlaySessionID_t unSessionID, ref int pnResolutionX, ref int pnResolutionY )
		{
			var returnValue = _BGetSessionClientResolution( Self, unSessionID, ref pnResolutionX, ref pnResolutionY );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_BStartRemotePlayTogether", CallingConvention = Platform.CC)]
		[return: MarshalAs( UnmanagedType.I1 )]
		internal static extern bool _BStartRemotePlayTogether( IntPtr self, [MarshalAs( UnmanagedType.U1 )] bool bShowOverlay );
		
		#endregion
		internal bool BStartRemotePlayTogether( [MarshalAs( UnmanagedType.U1 )] bool bShowOverlay )
		{
			var returnValue = _BStartRemotePlayTogether( Self, bShowOverlay );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_BSendRemotePlayTogetherInvite", CallingConvention = Platform.CC)]
		[return: MarshalAs( UnmanagedType.I1 )]
		internal static extern bool _BSendRemotePlayTogetherInvite( IntPtr self, SteamId steamIDFriend );
		
		#endregion
		internal bool BSendRemotePlayTogetherInvite( SteamId steamIDFriend )
		{
			var returnValue = _BSendRemotePlayTogetherInvite( Self, steamIDFriend );
			return returnValue;
		}
		
	}
}