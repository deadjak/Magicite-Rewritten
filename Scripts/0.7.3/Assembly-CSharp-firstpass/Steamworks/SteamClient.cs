using System;

namespace Steamworks;

public static class SteamClient
{
	public static HSteamPipe CreateSteamPipe()
	{
		return NativeMethods.ISteamClient_CreateSteamPipe();
	}

	public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
	{
		return NativeMethods.ISteamClient_BReleaseSteamPipe(hSteamPipe);
	}

	public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
	{
		return NativeMethods.ISteamClient_ConnectToGlobalUser(hSteamPipe);
	}

	public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType)
	{
		return NativeMethods.ISteamClient_CreateLocalUser(out phSteamPipe, eAccountType);
	}

	public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
	{
		NativeMethods.ISteamClient_ReleaseUser(hSteamPipe, hUser);
	}

	public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamUser(hSteamUser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamGameServer(hSteamUser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static void SetLocalIPBinding(uint unIP, ushort usPort)
	{
		NativeMethods.ISteamClient_SetLocalIPBinding(unIP, usPort);
	}

	public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamFriends(hSteamUser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamUtils(hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamMatchmaking(hSteamUser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamMatchmakingServers(hSteamUser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamGenericInterface(hSteamUser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamUserStats(hSteamUser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamGameServerStats(hSteamuser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamApps(hSteamUser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamNetworking(hSteamUser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamRemoteStorage(hSteamuser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamScreenshots(hSteamuser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static void RunFrame()
	{
		NativeMethods.ISteamClient_RunFrame();
	}

	public static uint GetIPCCallCount()
	{
		return NativeMethods.ISteamClient_GetIPCCallCount();
	}

	public static void SetWarningMessageHook(IntPtr pFunction)
	{
		NativeMethods.ISteamClient_SetWarningMessageHook(pFunction);
	}

	public static bool BShutdownIfAllPipesClosed()
	{
		return NativeMethods.ISteamClient_BShutdownIfAllPipesClosed();
	}

	public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamHTTP(hSteamuser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static IntPtr GetISteamUnifiedMessages(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamUnifiedMessages(hSteamuser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamController(hSteamUser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}

	public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		return NativeMethods.ISteamClient_GetISteamUGC(hSteamUser, hSteamPipe, new InteropHelp.UTF8String(pchVersion));
	}
}
