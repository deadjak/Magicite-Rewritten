namespace Steamworks;

public static class SteamScreenshots
{
	public static ScreenshotHandle WriteScreenshot(byte[] pubRGB, uint cubRGB, int nWidth, int nHeight)
	{
		return NativeMethods.ISteamScreenshots_WriteScreenshot(pubRGB, cubRGB, nWidth, nHeight);
	}

	public static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
	{
		return NativeMethods.ISteamScreenshots_AddScreenshotToLibrary(new InteropHelp.UTF8String(pchFilename), new InteropHelp.UTF8String(pchThumbnailFilename), nWidth, nHeight);
	}

	public static void TriggerScreenshot()
	{
		NativeMethods.ISteamScreenshots_TriggerScreenshot();
	}

	public static void HookScreenshots(bool bHook)
	{
		NativeMethods.ISteamScreenshots_HookScreenshots(bHook);
	}

	public static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation)
	{
		return NativeMethods.ISteamScreenshots_SetLocation(hScreenshot, new InteropHelp.UTF8String(pchLocation));
	}

	public static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID)
	{
		return NativeMethods.ISteamScreenshots_TagUser(hScreenshot, steamID);
	}

	public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID)
	{
		return NativeMethods.ISteamScreenshots_TagPublishedFile(hScreenshot, unPublishedFileID);
	}
}
