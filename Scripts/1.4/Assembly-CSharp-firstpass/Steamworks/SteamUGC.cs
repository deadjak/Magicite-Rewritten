namespace Steamworks;

public static class SteamUGC
{
	public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
	{
		return NativeMethods.ISteamUGC_CreateQueryUserUGCRequest(unAccountID, eListType, eMatchingUGCType, eSortOrder, nCreatorAppID, nConsumerAppID, unPage);
	}

	public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
	{
		return NativeMethods.ISteamUGC_CreateQueryAllUGCRequest(eQueryType, eMatchingeMatchingUGCTypeFileType, nCreatorAppID, nConsumerAppID, unPage);
	}

	public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
	{
		return NativeMethods.ISteamUGC_SendQueryUGCRequest(handle);
	}

	public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails)
	{
		return NativeMethods.ISteamUGC_GetQueryUGCResult(handle, index, ref pDetails);
	}

	public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
	{
		return NativeMethods.ISteamUGC_ReleaseQueryUGCRequest(handle);
	}

	public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
	{
		return NativeMethods.ISteamUGC_AddRequiredTag(handle, new InteropHelp.UTF8String(pTagName));
	}

	public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
	{
		return NativeMethods.ISteamUGC_AddExcludedTag(handle, new InteropHelp.UTF8String(pTagName));
	}

	public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
	{
		return NativeMethods.ISteamUGC_SetReturnLongDescription(handle, bReturnLongDescription);
	}

	public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
	{
		return NativeMethods.ISteamUGC_SetReturnTotalOnly(handle, bReturnTotalOnly);
	}

	public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
	{
		return NativeMethods.ISteamUGC_SetCloudFileNameFilter(handle, new InteropHelp.UTF8String(pMatchCloudFileName));
	}

	public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
	{
		return NativeMethods.ISteamUGC_SetMatchAnyTag(handle, bMatchAnyTag);
	}

	public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
	{
		return NativeMethods.ISteamUGC_SetSearchText(handle, new InteropHelp.UTF8String(pSearchText));
	}

	public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
	{
		return NativeMethods.ISteamUGC_SetRankedByTrendDays(handle, unDays);
	}

	public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID)
	{
		return NativeMethods.ISteamUGC_RequestUGCDetails(nPublishedFileID);
	}
}
