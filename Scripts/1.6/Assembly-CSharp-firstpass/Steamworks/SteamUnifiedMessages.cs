using System;

namespace Steamworks;

public static class SteamUnifiedMessages
{
	public static ClientUnifiedMessageHandle SendMethod(string pchServiceMethod, IntPtr pRequestBuffer, uint unRequestBufferSize, ulong unContext)
	{
		return NativeMethods.ISteamUnifiedMessages_SendMethod(new InteropHelp.UTF8String(pchServiceMethod), pRequestBuffer, unRequestBufferSize, unContext);
	}

	public static bool GetMethodResponseInfo(ClientUnifiedMessageHandle hHandle, out uint punResponseSize, out EResult peResult)
	{
		return NativeMethods.ISteamUnifiedMessages_GetMethodResponseInfo(hHandle, out punResponseSize, out peResult);
	}

	public static bool GetMethodResponseData(ClientUnifiedMessageHandle hHandle, IntPtr pResponseBuffer, uint unResponseBufferSize, bool bAutoRelease)
	{
		return NativeMethods.ISteamUnifiedMessages_GetMethodResponseData(hHandle, pResponseBuffer, unResponseBufferSize, bAutoRelease);
	}

	public static bool ReleaseMethod(ClientUnifiedMessageHandle hHandle)
	{
		return NativeMethods.ISteamUnifiedMessages_ReleaseMethod(hHandle);
	}

	public static bool SendNotification(string pchServiceNotification, IntPtr pNotificationBuffer, uint unNotificationBufferSize)
	{
		return NativeMethods.ISteamUnifiedMessages_SendNotification(new InteropHelp.UTF8String(pchServiceNotification), pNotificationBuffer, unNotificationBufferSize);
	}
}
