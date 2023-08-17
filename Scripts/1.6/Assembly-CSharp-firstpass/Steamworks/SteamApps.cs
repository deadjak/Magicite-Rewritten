using System;
using System.Runtime.InteropServices;

namespace Steamworks;

public static class SteamApps
{
	public static bool BIsSubscribed()
	{
		return NativeMethods.ISteamApps_BIsSubscribed();
	}

	public static bool BIsLowViolence()
	{
		return NativeMethods.ISteamApps_BIsLowViolence();
	}

	public static bool BIsCybercafe()
	{
		return NativeMethods.ISteamApps_BIsCybercafe();
	}

	public static bool BIsVACBanned()
	{
		return NativeMethods.ISteamApps_BIsVACBanned();
	}

	public static string GetCurrentGameLanguage()
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamApps_GetCurrentGameLanguage());
	}

	public static string GetAvailableGameLanguages()
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamApps_GetAvailableGameLanguages());
	}

	public static bool BIsSubscribedApp(AppId_t appID)
	{
		return NativeMethods.ISteamApps_BIsSubscribedApp(appID);
	}

	public static bool BIsDlcInstalled(AppId_t appID)
	{
		return NativeMethods.ISteamApps_BIsDlcInstalled(appID);
	}

	public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID)
	{
		return NativeMethods.ISteamApps_GetEarliestPurchaseUnixTime(nAppID);
	}

	public static bool BIsSubscribedFromFreeWeekend()
	{
		return NativeMethods.ISteamApps_BIsSubscribedFromFreeWeekend();
	}

	public static int GetDLCCount()
	{
		return NativeMethods.ISteamApps_GetDLCCount();
	}

	public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(cchNameBufferSize);
		bool flag = NativeMethods.ISteamApps_BGetDLCDataByIndex(iDLC, out pAppID, out pbAvailable, intPtr, cchNameBufferSize);
		pchName = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr));
		Marshal.FreeHGlobal(intPtr);
		return flag;
	}

	public static void InstallDLC(AppId_t nAppID)
	{
		NativeMethods.ISteamApps_InstallDLC(nAppID);
	}

	public static void UninstallDLC(AppId_t nAppID)
	{
		NativeMethods.ISteamApps_UninstallDLC(nAppID);
	}

	public static void RequestAppProofOfPurchaseKey(AppId_t nAppID)
	{
		NativeMethods.ISteamApps_RequestAppProofOfPurchaseKey(nAppID);
	}

	public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(cchNameBufferSize);
		bool flag = NativeMethods.ISteamApps_GetCurrentBetaName(intPtr, cchNameBufferSize);
		pchName = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr));
		Marshal.FreeHGlobal(intPtr);
		return flag;
	}

	public static bool MarkContentCorrupt(bool bMissingFilesOnly)
	{
		return NativeMethods.ISteamApps_MarkContentCorrupt(bMissingFilesOnly);
	}

	public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots)
	{
		return NativeMethods.ISteamApps_GetInstalledDepots(appID, pvecDepots, cMaxDepots);
	}

	public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize)
	{
		IntPtr intPtr = Marshal.AllocHGlobal((int)cchFolderBufferSize);
		uint num = NativeMethods.ISteamApps_GetAppInstallDir(appID, intPtr, cchFolderBufferSize);
		pchFolder = ((num == 0) ? null : InteropHelp.PtrToStringUTF8(intPtr));
		Marshal.FreeHGlobal(intPtr);
		return num;
	}

	public static bool BIsAppInstalled(AppId_t appID)
	{
		return NativeMethods.ISteamApps_BIsAppInstalled(appID);
	}

	public static CSteamID GetAppOwner()
	{
		return NativeMethods.ISteamApps_GetAppOwner();
	}

	public static string GetLaunchQueryParam(string pchKey)
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamApps_GetLaunchQueryParam(new InteropHelp.UTF8String(pchKey)));
	}
}
