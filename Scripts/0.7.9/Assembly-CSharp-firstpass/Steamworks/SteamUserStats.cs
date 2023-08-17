using System;
using System.Runtime.InteropServices;

namespace Steamworks;

public static class SteamUserStats
{
	public static bool RequestCurrentStats()
	{
		return NativeMethods.ISteamUserStats_RequestCurrentStats();
	}

	public static bool GetStat(string pchName, out int pData)
	{
		return NativeMethods.ISteamUserStats_GetStat(new InteropHelp.UTF8String(pchName), out pData);
	}

	public static bool GetStat(string pchName, out float pData)
	{
		return NativeMethods.ISteamUserStats_GetStat_(new InteropHelp.UTF8String(pchName), out pData);
	}

	public static bool SetStat(string pchName, int nData)
	{
		return NativeMethods.ISteamUserStats_SetStat(new InteropHelp.UTF8String(pchName), nData);
	}

	public static bool SetStat(string pchName, float fData)
	{
		return NativeMethods.ISteamUserStats_SetStat_(new InteropHelp.UTF8String(pchName), fData);
	}

	public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength)
	{
		return NativeMethods.ISteamUserStats_UpdateAvgRateStat(new InteropHelp.UTF8String(pchName), flCountThisSession, dSessionLength);
	}

	public static bool GetAchievement(string pchName, out bool pbAchieved)
	{
		return NativeMethods.ISteamUserStats_GetAchievement(new InteropHelp.UTF8String(pchName), out pbAchieved);
	}

	public static bool SetAchievement(string pchName)
	{
		return NativeMethods.ISteamUserStats_SetAchievement(new InteropHelp.UTF8String(pchName));
	}

	public static bool ClearAchievement(string pchName)
	{
		return NativeMethods.ISteamUserStats_ClearAchievement(new InteropHelp.UTF8String(pchName));
	}

	public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime)
	{
		return NativeMethods.ISteamUserStats_GetAchievementAndUnlockTime(new InteropHelp.UTF8String(pchName), out pbAchieved, out punUnlockTime);
	}

	public static bool StoreStats()
	{
		return NativeMethods.ISteamUserStats_StoreStats();
	}

	public static int GetAchievementIcon(string pchName)
	{
		return NativeMethods.ISteamUserStats_GetAchievementIcon(new InteropHelp.UTF8String(pchName));
	}

	public static string GetAchievementDisplayAttribute(string pchName, string pchKey)
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUserStats_GetAchievementDisplayAttribute(new InteropHelp.UTF8String(pchName), new InteropHelp.UTF8String(pchKey)));
	}

	public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
	{
		return NativeMethods.ISteamUserStats_IndicateAchievementProgress(new InteropHelp.UTF8String(pchName), nCurProgress, nMaxProgress);
	}

	public static uint GetNumAchievements()
	{
		return NativeMethods.ISteamUserStats_GetNumAchievements();
	}

	public static string GetAchievementName(uint iAchievement)
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUserStats_GetAchievementName(iAchievement));
	}

	public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
	{
		return NativeMethods.ISteamUserStats_RequestUserStats(steamIDUser);
	}

	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
	{
		return NativeMethods.ISteamUserStats_GetUserStat(steamIDUser, new InteropHelp.UTF8String(pchName), out pData);
	}

	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
	{
		return NativeMethods.ISteamUserStats_GetUserStat_(steamIDUser, new InteropHelp.UTF8String(pchName), out pData);
	}

	public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
	{
		return NativeMethods.ISteamUserStats_GetUserAchievement(steamIDUser, new InteropHelp.UTF8String(pchName), out pbAchieved);
	}

	public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime)
	{
		return NativeMethods.ISteamUserStats_GetUserAchievementAndUnlockTime(steamIDUser, new InteropHelp.UTF8String(pchName), out pbAchieved, out punUnlockTime);
	}

	public static bool ResetAllStats(bool bAchievementsToo)
	{
		return NativeMethods.ISteamUserStats_ResetAllStats(bAchievementsToo);
	}

	public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType)
	{
		return NativeMethods.ISteamUserStats_FindOrCreateLeaderboard(new InteropHelp.UTF8String(pchLeaderboardName), eLeaderboardSortMethod, eLeaderboardDisplayType);
	}

	public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName)
	{
		return NativeMethods.ISteamUserStats_FindLeaderboard(new InteropHelp.UTF8String(pchLeaderboardName));
	}

	public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard)
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUserStats_GetLeaderboardName(hSteamLeaderboard));
	}

	public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard)
	{
		return NativeMethods.ISteamUserStats_GetLeaderboardEntryCount(hSteamLeaderboard);
	}

	public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard)
	{
		return NativeMethods.ISteamUserStats_GetLeaderboardSortMethod(hSteamLeaderboard);
	}

	public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard)
	{
		return NativeMethods.ISteamUserStats_GetLeaderboardDisplayType(hSteamLeaderboard);
	}

	public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
	{
		return NativeMethods.ISteamUserStats_DownloadLeaderboardEntries(hSteamLeaderboard, eLeaderboardDataRequest, nRangeStart, nRangeEnd);
	}

	public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers)
	{
		return NativeMethods.ISteamUserStats_DownloadLeaderboardEntriesForUsers(hSteamLeaderboard, prgUsers, cUsers);
	}

	public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, out int pDetails, int cDetailsMax)
	{
		return NativeMethods.ISteamUserStats_GetDownloadedLeaderboardEntry(hSteamLeaderboardEntries, index, out pLeaderboardEntry, out pDetails, cDetailsMax);
	}

	public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount)
	{
		return NativeMethods.ISteamUserStats_UploadLeaderboardScore(hSteamLeaderboard, eLeaderboardUploadScoreMethod, nScore, pScoreDetails, cScoreDetailsCount);
	}

	public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC)
	{
		return NativeMethods.ISteamUserStats_AttachLeaderboardUGC(hSteamLeaderboard, hUGC);
	}

	public static SteamAPICall_t GetNumberOfCurrentPlayers()
	{
		return NativeMethods.ISteamUserStats_GetNumberOfCurrentPlayers();
	}

	public static SteamAPICall_t RequestGlobalAchievementPercentages()
	{
		return NativeMethods.ISteamUserStats_RequestGlobalAchievementPercentages();
	}

	public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
	{
		IntPtr intPtr = Marshal.AllocHGlobal((int)unNameBufLen);
		int num = NativeMethods.ISteamUserStats_GetMostAchievedAchievementInfo(intPtr, unNameBufLen, out pflPercent, out pbAchieved);
		pchName = ((num == 0) ? null : InteropHelp.PtrToStringUTF8(intPtr));
		Marshal.FreeHGlobal(intPtr);
		return num;
	}

	public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
	{
		IntPtr intPtr = Marshal.AllocHGlobal((int)unNameBufLen);
		int num = NativeMethods.ISteamUserStats_GetNextMostAchievedAchievementInfo(iIteratorPrevious, intPtr, unNameBufLen, out pflPercent, out pbAchieved);
		pchName = ((num == 0) ? null : InteropHelp.PtrToStringUTF8(intPtr));
		Marshal.FreeHGlobal(intPtr);
		return num;
	}

	public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent)
	{
		return NativeMethods.ISteamUserStats_GetAchievementAchievedPercent(new InteropHelp.UTF8String(pchName), out pflPercent);
	}

	public static SteamAPICall_t RequestGlobalStats(int nHistoryDays)
	{
		return NativeMethods.ISteamUserStats_RequestGlobalStats(nHistoryDays);
	}

	public static bool GetGlobalStat(string pchStatName, out long pData)
	{
		return NativeMethods.ISteamUserStats_GetGlobalStat(new InteropHelp.UTF8String(pchStatName), out pData);
	}

	public static bool GetGlobalStat(string pchStatName, out double pData)
	{
		return NativeMethods.ISteamUserStats_GetGlobalStat_(new InteropHelp.UTF8String(pchStatName), out pData);
	}

	public static int GetGlobalStatHistory(string pchStatName, long[] pData, uint cubData)
	{
		return NativeMethods.ISteamUserStats_GetGlobalStatHistory(new InteropHelp.UTF8String(pchStatName), pData, cubData);
	}

	public static int GetGlobalStatHistory(string pchStatName, double[] pData, uint cubData)
	{
		return NativeMethods.ISteamUserStats_GetGlobalStatHistory_(new InteropHelp.UTF8String(pchStatName), pData, cubData);
	}
}
