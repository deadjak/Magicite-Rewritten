using System;
using System.Runtime.InteropServices;

namespace Steamworks;

public static class SteamGameServerUtils
{
	public static uint GetSecondsSinceAppActive()
	{
		return NativeMethods.ISteamGameServerUtils_GetSecondsSinceAppActive();
	}

	public static uint GetSecondsSinceComputerActive()
	{
		return NativeMethods.ISteamGameServerUtils_GetSecondsSinceComputerActive();
	}

	public static EUniverse GetConnectedUniverse()
	{
		return NativeMethods.ISteamGameServerUtils_GetConnectedUniverse();
	}

	public static uint GetServerRealTime()
	{
		return NativeMethods.ISteamGameServerUtils_GetServerRealTime();
	}

	public static string GetIPCountry()
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamGameServerUtils_GetIPCountry());
	}

	public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
	{
		return NativeMethods.ISteamGameServerUtils_GetImageSize(iImage, out pnWidth, out pnHeight);
	}

	public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
	{
		return NativeMethods.ISteamGameServerUtils_GetImageRGBA(iImage, pubDest, nDestBufferSize);
	}

	public static bool GetCSERIPPort(out uint unIP, out ushort usPort)
	{
		return NativeMethods.ISteamGameServerUtils_GetCSERIPPort(out unIP, out usPort);
	}

	public static byte GetCurrentBatteryPower()
	{
		return NativeMethods.ISteamGameServerUtils_GetCurrentBatteryPower();
	}

	public static uint GetAppID()
	{
		return NativeMethods.ISteamGameServerUtils_GetAppID();
	}

	public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
	{
		NativeMethods.ISteamGameServerUtils_SetOverlayNotificationPosition(eNotificationPosition);
	}

	public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
	{
		return NativeMethods.ISteamGameServerUtils_IsAPICallCompleted(hSteamAPICall, out pbFailed);
	}

	public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
	{
		return NativeMethods.ISteamGameServerUtils_GetAPICallFailureReason(hSteamAPICall);
	}

	public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
	{
		return NativeMethods.ISteamGameServerUtils_GetAPICallResult(hSteamAPICall, pCallback, cubCallback, iCallbackExpected, out pbFailed);
	}

	public static void RunFrame()
	{
		NativeMethods.ISteamGameServerUtils_RunFrame();
	}

	public static uint GetIPCCallCount()
	{
		return NativeMethods.ISteamGameServerUtils_GetIPCCallCount();
	}

	public static void SetWarningMessageHook(IntPtr pFunction)
	{
		NativeMethods.ISteamGameServerUtils_SetWarningMessageHook(pFunction);
	}

	public static bool IsOverlayEnabled()
	{
		return NativeMethods.ISteamGameServerUtils_IsOverlayEnabled();
	}

	public static bool BOverlayNeedsPresent()
	{
		return NativeMethods.ISteamGameServerUtils_BOverlayNeedsPresent();
	}

	public static SteamAPICall_t CheckFileSignature(string szFileName)
	{
		return NativeMethods.ISteamGameServerUtils_CheckFileSignature(new InteropHelp.UTF8String(szFileName));
	}

	public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax)
	{
		return NativeMethods.ISteamGameServerUtils_ShowGamepadTextInput(eInputMode, eLineInputMode, new InteropHelp.UTF8String(pchDescription), unCharMax);
	}

	public static uint GetEnteredGamepadTextLength()
	{
		return NativeMethods.ISteamGameServerUtils_GetEnteredGamepadTextLength();
	}

	public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
	{
		IntPtr intPtr = Marshal.AllocHGlobal((int)cchText);
		bool flag = NativeMethods.ISteamUtils_GetEnteredGamepadTextInput(intPtr, cchText);
		pchText = ((!flag) ? null : InteropHelp.PtrToStringUTF8(intPtr));
		Marshal.FreeHGlobal(intPtr);
		return flag;
	}

	public static string GetSteamUILanguage()
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamGameServerUtils_GetSteamUILanguage());
	}

	public static bool IsSteamRunningInVR()
	{
		return NativeMethods.ISteamGameServerUtils_IsSteamRunningInVR();
	}
}
