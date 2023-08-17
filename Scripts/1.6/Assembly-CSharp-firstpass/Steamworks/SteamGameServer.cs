using System;

namespace Steamworks;

public static class SteamGameServer
{
	public static bool InitGameServer(uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, string pchVersionString)
	{
		return NativeMethods.ISteamGameServer_InitGameServer(unIP, usGamePort, usQueryPort, unFlags, nGameAppId, new InteropHelp.UTF8String(pchVersionString));
	}

	public static void SetProduct(string pszProduct)
	{
		NativeMethods.ISteamGameServer_SetProduct(new InteropHelp.UTF8String(pszProduct));
	}

	public static void SetGameDescription(string pszGameDescription)
	{
		NativeMethods.ISteamGameServer_SetGameDescription(new InteropHelp.UTF8String(pszGameDescription));
	}

	public static void SetModDir(string pszModDir)
	{
		NativeMethods.ISteamGameServer_SetModDir(new InteropHelp.UTF8String(pszModDir));
	}

	public static void SetDedicatedServer(bool bDedicated)
	{
		NativeMethods.ISteamGameServer_SetDedicatedServer(bDedicated);
	}

	public static void LogOnAnonymous()
	{
		NativeMethods.ISteamGameServer_LogOnAnonymous();
	}

	public static void LogOff()
	{
		NativeMethods.ISteamGameServer_LogOff();
	}

	public static bool BLoggedOn()
	{
		return NativeMethods.ISteamGameServer_BLoggedOn();
	}

	public static bool BSecure()
	{
		return NativeMethods.ISteamGameServer_BSecure();
	}

	public static CSteamID GetSteamID()
	{
		return NativeMethods.ISteamGameServer_GetSteamID();
	}

	public static bool WasRestartRequested()
	{
		return NativeMethods.ISteamGameServer_WasRestartRequested();
	}

	public static void SetMaxPlayerCount(int cPlayersMax)
	{
		NativeMethods.ISteamGameServer_SetMaxPlayerCount(cPlayersMax);
	}

	public static void SetBotPlayerCount(int cBotplayers)
	{
		NativeMethods.ISteamGameServer_SetBotPlayerCount(cBotplayers);
	}

	public static void SetServerName(string pszServerName)
	{
		NativeMethods.ISteamGameServer_SetServerName(new InteropHelp.UTF8String(pszServerName));
	}

	public static void SetMapName(string pszMapName)
	{
		NativeMethods.ISteamGameServer_SetMapName(new InteropHelp.UTF8String(pszMapName));
	}

	public static void SetPasswordProtected(bool bPasswordProtected)
	{
		NativeMethods.ISteamGameServer_SetPasswordProtected(bPasswordProtected);
	}

	public static void SetSpectatorPort(ushort unSpectatorPort)
	{
		NativeMethods.ISteamGameServer_SetSpectatorPort(unSpectatorPort);
	}

	public static void SetSpectatorServerName(string pszSpectatorServerName)
	{
		NativeMethods.ISteamGameServer_SetSpectatorServerName(new InteropHelp.UTF8String(pszSpectatorServerName));
	}

	public static void ClearAllKeyValues()
	{
		NativeMethods.ISteamGameServer_ClearAllKeyValues();
	}

	public static void SetKeyValue(string pKey, string pValue)
	{
		NativeMethods.ISteamGameServer_SetKeyValue(new InteropHelp.UTF8String(pKey), new InteropHelp.UTF8String(pValue));
	}

	public static void SetGameTags(string pchGameTags)
	{
		NativeMethods.ISteamGameServer_SetGameTags(new InteropHelp.UTF8String(pchGameTags));
	}

	public static void SetGameData(string pchGameData)
	{
		NativeMethods.ISteamGameServer_SetGameData(new InteropHelp.UTF8String(pchGameData));
	}

	public static void SetRegion(string pszRegion)
	{
		NativeMethods.ISteamGameServer_SetRegion(new InteropHelp.UTF8String(pszRegion));
	}

	public static bool SendUserConnectAndAuthenticate(uint unIPClient, IntPtr pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser)
	{
		return NativeMethods.ISteamGameServer_SendUserConnectAndAuthenticate(unIPClient, pvAuthBlob, cubAuthBlobSize, out pSteamIDUser);
	}

	public static CSteamID CreateUnauthenticatedUserConnection()
	{
		return NativeMethods.ISteamGameServer_CreateUnauthenticatedUserConnection();
	}

	public static void SendUserDisconnect(CSteamID steamIDUser)
	{
		NativeMethods.ISteamGameServer_SendUserDisconnect(steamIDUser);
	}

	public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore)
	{
		return NativeMethods.ISteamGameServer_BUpdateUserData(steamIDUser, new InteropHelp.UTF8String(pchPlayerName), uScore);
	}

	public static HAuthTicket GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, out uint pcbTicket)
	{
		return NativeMethods.ISteamGameServer_GetAuthSessionTicket(pTicket, cbMaxTicket, out pcbTicket);
	}

	public static EBeginAuthSessionResult BeginAuthSession(IntPtr pAuthTicket, int cbAuthTicket, CSteamID steamID)
	{
		return NativeMethods.ISteamGameServer_BeginAuthSession(pAuthTicket, cbAuthTicket, steamID);
	}

	public static void EndAuthSession(CSteamID steamID)
	{
		NativeMethods.ISteamGameServer_EndAuthSession(steamID);
	}

	public static void CancelAuthTicket(HAuthTicket hAuthTicket)
	{
		NativeMethods.ISteamGameServer_CancelAuthTicket(hAuthTicket);
	}

	public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
	{
		return NativeMethods.ISteamGameServer_UserHasLicenseForApp(steamID, appID);
	}

	public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup)
	{
		return NativeMethods.ISteamGameServer_RequestUserGroupStatus(steamIDUser, steamIDGroup);
	}

	public static void GetGameplayStats()
	{
		NativeMethods.ISteamGameServer_GetGameplayStats();
	}

	public static SteamAPICall_t GetServerReputation()
	{
		return NativeMethods.ISteamGameServer_GetServerReputation();
	}

	public static uint GetPublicIP()
	{
		return NativeMethods.ISteamGameServer_GetPublicIP();
	}

	public static bool HandleIncomingPacket(IntPtr pData, int cbData, uint srcIP, ushort srcPort)
	{
		return NativeMethods.ISteamGameServer_HandleIncomingPacket(pData, cbData, srcIP, srcPort);
	}

	public static int GetNextOutgoingPacket(IntPtr pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort)
	{
		return NativeMethods.ISteamGameServer_GetNextOutgoingPacket(pOut, cbMaxOut, out pNetAdr, out pPort);
	}

	public static void EnableHeartbeats(bool bActive)
	{
		NativeMethods.ISteamGameServer_EnableHeartbeats(bActive);
	}

	public static void SetHeartbeatInterval(int iHeartbeatInterval)
	{
		NativeMethods.ISteamGameServer_SetHeartbeatInterval(iHeartbeatInterval);
	}

	public static void ForceHeartbeat()
	{
		NativeMethods.ISteamGameServer_ForceHeartbeat();
	}

	public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan)
	{
		return NativeMethods.ISteamGameServer_AssociateWithClan(steamIDClan);
	}

	public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer)
	{
		return NativeMethods.ISteamGameServer_ComputeNewPlayerCompatibility(steamIDNewPlayer);
	}
}
