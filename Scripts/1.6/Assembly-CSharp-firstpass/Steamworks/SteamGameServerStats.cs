namespace Steamworks;

public static class SteamGameServerStats
{
	public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
	{
		return NativeMethods.ISteamGameServerStats_RequestUserStats(steamIDUser);
	}

	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
	{
		return NativeMethods.ISteamGameServerStats_GetUserStat(steamIDUser, new InteropHelp.UTF8String(pchName), out pData);
	}

	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
	{
		return NativeMethods.ISteamGameServerStats_GetUserStat_(steamIDUser, new InteropHelp.UTF8String(pchName), out pData);
	}

	public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
	{
		return NativeMethods.ISteamGameServerStats_GetUserAchievement(steamIDUser, new InteropHelp.UTF8String(pchName), out pbAchieved);
	}

	public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData)
	{
		return NativeMethods.ISteamGameServerStats_SetUserStat(steamIDUser, new InteropHelp.UTF8String(pchName), nData);
	}

	public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData)
	{
		return NativeMethods.ISteamGameServerStats_SetUserStat_(steamIDUser, new InteropHelp.UTF8String(pchName), fData);
	}

	public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength)
	{
		return NativeMethods.ISteamGameServerStats_UpdateUserAvgRateStat(steamIDUser, new InteropHelp.UTF8String(pchName), flCountThisSession, dSessionLength);
	}

	public static bool SetUserAchievement(CSteamID steamIDUser, string pchName)
	{
		return NativeMethods.ISteamGameServerStats_SetUserAchievement(steamIDUser, new InteropHelp.UTF8String(pchName));
	}

	public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName)
	{
		return NativeMethods.ISteamGameServerStats_ClearUserAchievement(steamIDUser, new InteropHelp.UTF8String(pchName));
	}

	public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser)
	{
		return NativeMethods.ISteamGameServerStats_StoreUserStats(steamIDUser);
	}
}
