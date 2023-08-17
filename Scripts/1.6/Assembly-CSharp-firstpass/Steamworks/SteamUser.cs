using System;
using System.Runtime.InteropServices;

namespace Steamworks;

public static class SteamUser
{
	public static HSteamUser GetHSteamUser()
	{
		return NativeMethods.ISteamUser_GetHSteamUser();
	}

	public static bool BLoggedOn()
	{
		return NativeMethods.ISteamUser_BLoggedOn();
	}

	public static CSteamID GetSteamID()
	{
		return NativeMethods.ISteamUser_GetSteamID();
	}

	public static int InitiateGameConnection(IntPtr pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure)
	{
		return NativeMethods.ISteamUser_InitiateGameConnection(pAuthBlob, cbMaxAuthBlob, steamIDGameServer, unIPServer, usPortServer, bSecure);
	}

	public static void TerminateGameConnection(uint unIPServer, ushort usPortServer)
	{
		NativeMethods.ISteamUser_TerminateGameConnection(unIPServer, usPortServer);
	}

	public static void TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo = "")
	{
		NativeMethods.ISteamUser_TrackAppUsageEvent(gameID, eAppUsageEvent, new InteropHelp.UTF8String(pchExtraInfo));
	}

	public static bool GetUserDataFolder(out string pchBuffer, int cubBuffer)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(cubBuffer);
		bool flag = NativeMethods.ISteamUser_GetUserDataFolder(intPtr, cubBuffer);
		pchBuffer = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr));
		Marshal.FreeHGlobal(intPtr);
		return flag;
	}

	public static void StartVoiceRecording()
	{
		NativeMethods.ISteamUser_StartVoiceRecording();
	}

	public static void StopVoiceRecording()
	{
		NativeMethods.ISteamUser_StopVoiceRecording();
	}

	public static EVoiceResult GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed, uint nUncompressedVoiceDesiredSampleRate)
	{
		return NativeMethods.ISteamUser_GetAvailableVoice(out pcbCompressed, out pcbUncompressed, nUncompressedVoiceDesiredSampleRate);
	}

	public static EVoiceResult GetVoice(bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed, byte[] pUncompressedDestBuffer, uint cbUncompressedDestBufferSize, out uint nUncompressBytesWritten, uint nUncompressedVoiceDesiredSampleRate)
	{
		return NativeMethods.ISteamUser_GetVoice(bWantCompressed, pDestBuffer, cbDestBufferSize, out nBytesWritten, bWantUncompressed, pUncompressedDestBuffer, cbUncompressedDestBufferSize, out nUncompressBytesWritten, nUncompressedVoiceDesiredSampleRate);
	}

	public static EVoiceResult DecompressVoice(byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate)
	{
		return NativeMethods.ISteamUser_DecompressVoice(pCompressed, cbCompressed, pDestBuffer, cbDestBufferSize, out nBytesWritten, nDesiredSampleRate);
	}

	public static uint GetVoiceOptimalSampleRate()
	{
		return NativeMethods.ISteamUser_GetVoiceOptimalSampleRate();
	}

	public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
	{
		return NativeMethods.ISteamUser_GetAuthSessionTicket(pTicket, cbMaxTicket, out pcbTicket);
	}

	public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
	{
		return NativeMethods.ISteamUser_BeginAuthSession(pAuthTicket, cbAuthTicket, steamID);
	}

	public static void EndAuthSession(CSteamID steamID)
	{
		NativeMethods.ISteamUser_EndAuthSession(steamID);
	}

	public static void CancelAuthTicket(HAuthTicket hAuthTicket)
	{
		NativeMethods.ISteamUser_CancelAuthTicket(hAuthTicket);
	}

	public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
	{
		return NativeMethods.ISteamUser_UserHasLicenseForApp(steamID, appID);
	}

	public static bool BIsBehindNAT()
	{
		return NativeMethods.ISteamUser_BIsBehindNAT();
	}

	public static void AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer)
	{
		NativeMethods.ISteamUser_AdvertiseGame(steamIDGameServer, unIPServer, usPortServer);
	}

	public static SteamAPICall_t RequestEncryptedAppTicket(byte[] pDataToInclude, int cbDataToInclude)
	{
		return NativeMethods.ISteamUser_RequestEncryptedAppTicket(pDataToInclude, cbDataToInclude);
	}

	public static bool GetEncryptedAppTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
	{
		return NativeMethods.ISteamUser_GetEncryptedAppTicket(pTicket, cbMaxTicket, out pcbTicket);
	}

	public static int GetGameBadgeLevel(int nSeries, bool bFoil)
	{
		return NativeMethods.ISteamUser_GetGameBadgeLevel(nSeries, bFoil);
	}

	public static int GetPlayerSteamLevel()
	{
		return NativeMethods.ISteamUser_GetPlayerSteamLevel();
	}
}
