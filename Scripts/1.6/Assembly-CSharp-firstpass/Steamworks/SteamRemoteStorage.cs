using System;
using System.Collections.Generic;

namespace Steamworks;

public static class SteamRemoteStorage
{
	public static bool FileWrite(string pchFile, byte[] pvData, int cubData)
	{
		return NativeMethods.ISteamRemoteStorage_FileWrite(new InteropHelp.UTF8String(pchFile), pvData, cubData);
	}

	public static int FileRead(string pchFile, byte[] pvData, int cubDataToRead)
	{
		return NativeMethods.ISteamRemoteStorage_FileRead(new InteropHelp.UTF8String(pchFile), pvData, cubDataToRead);
	}

	public static bool FileForget(string pchFile)
	{
		return NativeMethods.ISteamRemoteStorage_FileForget(new InteropHelp.UTF8String(pchFile));
	}

	public static bool FileDelete(string pchFile)
	{
		return NativeMethods.ISteamRemoteStorage_FileDelete(new InteropHelp.UTF8String(pchFile));
	}

	public static SteamAPICall_t FileShare(string pchFile)
	{
		return NativeMethods.ISteamRemoteStorage_FileShare(new InteropHelp.UTF8String(pchFile));
	}

	public static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform)
	{
		return NativeMethods.ISteamRemoteStorage_SetSyncPlatforms(new InteropHelp.UTF8String(pchFile), eRemoteStoragePlatform);
	}

	public static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile)
	{
		return NativeMethods.ISteamRemoteStorage_FileWriteStreamOpen(new InteropHelp.UTF8String(pchFile));
	}

	public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData)
	{
		return NativeMethods.ISteamRemoteStorage_FileWriteStreamWriteChunk(writeHandle, pvData, cubData);
	}

	public static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle)
	{
		return NativeMethods.ISteamRemoteStorage_FileWriteStreamClose(writeHandle);
	}

	public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle)
	{
		return NativeMethods.ISteamRemoteStorage_FileWriteStreamCancel(writeHandle);
	}

	public static bool FileExists(string pchFile)
	{
		return NativeMethods.ISteamRemoteStorage_FileExists(new InteropHelp.UTF8String(pchFile));
	}

	public static bool FilePersisted(string pchFile)
	{
		return NativeMethods.ISteamRemoteStorage_FilePersisted(new InteropHelp.UTF8String(pchFile));
	}

	public static int GetFileSize(string pchFile)
	{
		return NativeMethods.ISteamRemoteStorage_GetFileSize(new InteropHelp.UTF8String(pchFile));
	}

	public static long GetFileTimestamp(string pchFile)
	{
		return NativeMethods.ISteamRemoteStorage_GetFileTimestamp(new InteropHelp.UTF8String(pchFile));
	}

	public static ERemoteStoragePlatform GetSyncPlatforms(string pchFile)
	{
		return NativeMethods.ISteamRemoteStorage_GetSyncPlatforms(new InteropHelp.UTF8String(pchFile));
	}

	public static int GetFileCount()
	{
		return NativeMethods.ISteamRemoteStorage_GetFileCount();
	}

	public static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes)
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamRemoteStorage_GetFileNameAndSize(iFile, out pnFileSizeInBytes));
	}

	public static bool GetQuota(out int pnTotalBytes, out int puAvailableBytes)
	{
		return NativeMethods.ISteamRemoteStorage_GetQuota(out pnTotalBytes, out puAvailableBytes);
	}

	public static bool IsCloudEnabledForAccount()
	{
		return NativeMethods.ISteamRemoteStorage_IsCloudEnabledForAccount();
	}

	public static bool IsCloudEnabledForApp()
	{
		return NativeMethods.ISteamRemoteStorage_IsCloudEnabledForApp();
	}

	public static void SetCloudEnabledForApp(bool bEnabled)
	{
		NativeMethods.ISteamRemoteStorage_SetCloudEnabledForApp(bEnabled);
	}

	public static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority)
	{
		return NativeMethods.ISteamRemoteStorage_UGCDownload(hContent, unPriority);
	}

	public static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected)
	{
		return NativeMethods.ISteamRemoteStorage_GetUGCDownloadProgress(hContent, out pnBytesDownloaded, out pnBytesExpected);
	}

	public static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner)
	{
		IntPtr ppchName2;
		bool flag = NativeMethods.ISteamRemoteStorage_GetUGCDetails(hContent, out pnAppID, out ppchName2, out pnFileSizeInBytes, out pSteamIDOwner);
		ppchName = ((!flag) ? null : InteropHelp.PtrToStringUTF8(ppchName2));
		return flag;
	}

	public static int UGCRead(UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction)
	{
		return NativeMethods.ISteamRemoteStorage_UGCRead(hContent, pvData, cubDataToRead, cOffset, eAction);
	}

	public static int GetCachedUGCCount()
	{
		return NativeMethods.ISteamRemoteStorage_GetCachedUGCCount();
	}

	public static UGCHandle_t GetCachedUGCHandle(int iCachedContent)
	{
		return NativeMethods.ISteamRemoteStorage_GetCachedUGCHandle(iCachedContent);
	}

	public static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags, EWorkshopFileType eWorkshopFileType)
	{
		return NativeMethods.ISteamRemoteStorage_PublishWorkshopFile(new InteropHelp.UTF8String(pchFile), new InteropHelp.UTF8String(pchPreviewFile), nConsumerAppId, new InteropHelp.UTF8String(pchTitle), new InteropHelp.UTF8String(pchDescription), eVisibility, new InteropHelp.SteamParamStringArray(pTags), eWorkshopFileType);
	}

	public static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId)
	{
		return NativeMethods.ISteamRemoteStorage_CreatePublishedFileUpdateRequest(unPublishedFileId);
	}

	public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile)
	{
		return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileFile(updateHandle, new InteropHelp.UTF8String(pchFile));
	}

	public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile)
	{
		return NativeMethods.ISteamRemoteStorage_UpdatePublishedFilePreviewFile(updateHandle, new InteropHelp.UTF8String(pchPreviewFile));
	}

	public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle)
	{
		return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileTitle(updateHandle, new InteropHelp.UTF8String(pchTitle));
	}

	public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription)
	{
		return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileDescription(updateHandle, new InteropHelp.UTF8String(pchDescription));
	}

	public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility)
	{
		return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileVisibility(updateHandle, eVisibility);
	}

	public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<string> pTags)
	{
		return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileTags(updateHandle, new InteropHelp.SteamParamStringArray(pTags));
	}

	public static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle)
	{
		return NativeMethods.ISteamRemoteStorage_CommitPublishedFileUpdate(updateHandle);
	}

	public static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld)
	{
		return NativeMethods.ISteamRemoteStorage_GetPublishedFileDetails(unPublishedFileId, unMaxSecondsOld);
	}

	public static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId)
	{
		return NativeMethods.ISteamRemoteStorage_DeletePublishedFile(unPublishedFileId);
	}

	public static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex)
	{
		return NativeMethods.ISteamRemoteStorage_EnumerateUserPublishedFiles(unStartIndex);
	}

	public static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId)
	{
		return NativeMethods.ISteamRemoteStorage_SubscribePublishedFile(unPublishedFileId);
	}

	public static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex)
	{
		return NativeMethods.ISteamRemoteStorage_EnumerateUserSubscribedFiles(unStartIndex);
	}

	public static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId)
	{
		return NativeMethods.ISteamRemoteStorage_UnsubscribePublishedFile(unPublishedFileId);
	}

	public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription)
	{
		return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(updateHandle, new InteropHelp.UTF8String(pchChangeDescription));
	}

	public static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
	{
		return NativeMethods.ISteamRemoteStorage_GetPublishedItemVoteDetails(unPublishedFileId);
	}

	public static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp)
	{
		return NativeMethods.ISteamRemoteStorage_UpdateUserPublishedItemVote(unPublishedFileId, bVoteUp);
	}

	public static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
	{
		return NativeMethods.ISteamRemoteStorage_GetUserPublishedItemVoteDetails(unPublishedFileId);
	}

	public static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<string> pRequiredTags, IList<string> pExcludedTags)
	{
		return NativeMethods.ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(steamId, unStartIndex, new InteropHelp.SteamParamStringArray(pRequiredTags), new InteropHelp.SteamParamStringArray(pExcludedTags));
	}

	public static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags)
	{
		return NativeMethods.ISteamRemoteStorage_PublishVideo(eVideoProvider, new InteropHelp.UTF8String(pchVideoAccount), new InteropHelp.UTF8String(pchVideoIdentifier), new InteropHelp.UTF8String(pchPreviewFile), nConsumerAppId, new InteropHelp.UTF8String(pchTitle), new InteropHelp.UTF8String(pchDescription), eVisibility, new InteropHelp.SteamParamStringArray(pTags));
	}

	public static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction)
	{
		return NativeMethods.ISteamRemoteStorage_SetUserPublishedFileAction(unPublishedFileId, eAction);
	}

	public static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex)
	{
		return NativeMethods.ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(eAction, unStartIndex);
	}

	public static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<string> pTags, IList<string> pUserTags)
	{
		return NativeMethods.ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(eEnumerationType, unStartIndex, unCount, unDays, new InteropHelp.SteamParamStringArray(pTags), new InteropHelp.SteamParamStringArray(pUserTags));
	}

	public static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority)
	{
		return NativeMethods.ISteamRemoteStorage_UGCDownloadToLocation(hContent, new InteropHelp.UTF8String(pchLocation), unPriority);
	}
}
