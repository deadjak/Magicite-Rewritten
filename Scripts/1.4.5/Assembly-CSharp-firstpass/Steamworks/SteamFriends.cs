using System;
using System.Runtime.InteropServices;

namespace Steamworks;

public static class SteamFriends
{
	public static string GetPersonaName()
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetPersonaName());
	}

	public static SteamAPICall_t SetPersonaName(string pchPersonaName)
	{
		return NativeMethods.ISteamFriends_SetPersonaName(new InteropHelp.UTF8String(pchPersonaName));
	}

	public static EPersonaState GetPersonaState()
	{
		return NativeMethods.ISteamFriends_GetPersonaState();
	}

	public static int GetFriendCount(EFriendFlags iFriendFlags)
	{
		return NativeMethods.ISteamFriends_GetFriendCount(iFriendFlags);
	}

	public static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags)
	{
		return NativeMethods.ISteamFriends_GetFriendByIndex(iFriend, iFriendFlags);
	}

	public static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend)
	{
		return NativeMethods.ISteamFriends_GetFriendRelationship(steamIDFriend);
	}

	public static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend)
	{
		return NativeMethods.ISteamFriends_GetFriendPersonaState(steamIDFriend);
	}

	public static string GetFriendPersonaName(CSteamID steamIDFriend)
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendPersonaName(steamIDFriend));
	}

	public static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo)
	{
		return NativeMethods.ISteamFriends_GetFriendGamePlayed(steamIDFriend, out pFriendGameInfo);
	}

	public static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName)
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendPersonaNameHistory(steamIDFriend, iPersonaName));
	}

	public static string GetPlayerNickname(CSteamID steamIDPlayer)
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetPlayerNickname(steamIDPlayer));
	}

	public static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags)
	{
		return NativeMethods.ISteamFriends_HasFriend(steamIDFriend, iFriendFlags);
	}

	public static int GetClanCount()
	{
		return NativeMethods.ISteamFriends_GetClanCount();
	}

	public static CSteamID GetClanByIndex(int iClan)
	{
		return NativeMethods.ISteamFriends_GetClanByIndex(iClan);
	}

	public static string GetClanName(CSteamID steamIDClan)
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetClanName(steamIDClan));
	}

	public static string GetClanTag(CSteamID steamIDClan)
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetClanTag(steamIDClan));
	}

	public static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting)
	{
		return NativeMethods.ISteamFriends_GetClanActivityCounts(steamIDClan, out pnOnline, out pnInGame, out pnChatting);
	}

	public static SteamAPICall_t DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest)
	{
		return NativeMethods.ISteamFriends_DownloadClanActivityCounts(psteamIDClans, cClansToRequest);
	}

	public static int GetFriendCountFromSource(CSteamID steamIDSource)
	{
		return NativeMethods.ISteamFriends_GetFriendCountFromSource(steamIDSource);
	}

	public static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend)
	{
		return NativeMethods.ISteamFriends_GetFriendFromSourceByIndex(steamIDSource, iFriend);
	}

	public static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource)
	{
		return NativeMethods.ISteamFriends_IsUserInSource(steamIDUser, steamIDSource);
	}

	public static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking)
	{
		NativeMethods.ISteamFriends_SetInGameVoiceSpeaking(steamIDUser, bSpeaking);
	}

	public static void ActivateGameOverlay(string pchDialog)
	{
		NativeMethods.ISteamFriends_ActivateGameOverlay(new InteropHelp.UTF8String(pchDialog));
	}

	public static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID)
	{
		NativeMethods.ISteamFriends_ActivateGameOverlayToUser(new InteropHelp.UTF8String(pchDialog), steamID);
	}

	public static void ActivateGameOverlayToWebPage(string pchURL)
	{
		NativeMethods.ISteamFriends_ActivateGameOverlayToWebPage(new InteropHelp.UTF8String(pchURL));
	}

	public static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag)
	{
		NativeMethods.ISteamFriends_ActivateGameOverlayToStore(nAppID, eFlag);
	}

	public static void SetPlayedWith(CSteamID steamIDUserPlayedWith)
	{
		NativeMethods.ISteamFriends_SetPlayedWith(steamIDUserPlayedWith);
	}

	public static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby)
	{
		NativeMethods.ISteamFriends_ActivateGameOverlayInviteDialog(steamIDLobby);
	}

	public static int GetSmallFriendAvatar(CSteamID steamIDFriend)
	{
		return NativeMethods.ISteamFriends_GetSmallFriendAvatar(steamIDFriend);
	}

	public static int GetMediumFriendAvatar(CSteamID steamIDFriend)
	{
		return NativeMethods.ISteamFriends_GetMediumFriendAvatar(steamIDFriend);
	}

	public static int GetLargeFriendAvatar(CSteamID steamIDFriend)
	{
		return NativeMethods.ISteamFriends_GetLargeFriendAvatar(steamIDFriend);
	}

	public static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly)
	{
		return NativeMethods.ISteamFriends_RequestUserInformation(steamIDUser, bRequireNameOnly);
	}

	public static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan)
	{
		return NativeMethods.ISteamFriends_RequestClanOfficerList(steamIDClan);
	}

	public static CSteamID GetClanOwner(CSteamID steamIDClan)
	{
		return NativeMethods.ISteamFriends_GetClanOwner(steamIDClan);
	}

	public static int GetClanOfficerCount(CSteamID steamIDClan)
	{
		return NativeMethods.ISteamFriends_GetClanOfficerCount(steamIDClan);
	}

	public static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer)
	{
		return NativeMethods.ISteamFriends_GetClanOfficerByIndex(steamIDClan, iOfficer);
	}

	public static uint GetUserRestrictions()
	{
		return NativeMethods.ISteamFriends_GetUserRestrictions();
	}

	public static bool SetRichPresence(string pchKey, string pchValue)
	{
		return NativeMethods.ISteamFriends_SetRichPresence(new InteropHelp.UTF8String(pchKey), new InteropHelp.UTF8String(pchValue));
	}

	public static void ClearRichPresence()
	{
		NativeMethods.ISteamFriends_ClearRichPresence();
	}

	public static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey)
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendRichPresence(steamIDFriend, new InteropHelp.UTF8String(pchKey)));
	}

	public static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend)
	{
		return NativeMethods.ISteamFriends_GetFriendRichPresenceKeyCount(steamIDFriend);
	}

	public static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey)
	{
		return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendRichPresenceKeyByIndex(steamIDFriend, iKey));
	}

	public static void RequestFriendRichPresence(CSteamID steamIDFriend)
	{
		NativeMethods.ISteamFriends_RequestFriendRichPresence(steamIDFriend);
	}

	public static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString)
	{
		return NativeMethods.ISteamFriends_InviteUserToGame(steamIDFriend, new InteropHelp.UTF8String(pchConnectString));
	}

	public static int GetCoplayFriendCount()
	{
		return NativeMethods.ISteamFriends_GetCoplayFriendCount();
	}

	public static CSteamID GetCoplayFriend(int iCoplayFriend)
	{
		return NativeMethods.ISteamFriends_GetCoplayFriend(iCoplayFriend);
	}

	public static int GetFriendCoplayTime(CSteamID steamIDFriend)
	{
		return NativeMethods.ISteamFriends_GetFriendCoplayTime(steamIDFriend);
	}

	public static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend)
	{
		return NativeMethods.ISteamFriends_GetFriendCoplayGame(steamIDFriend);
	}

	public static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan)
	{
		return NativeMethods.ISteamFriends_JoinClanChatRoom(steamIDClan);
	}

	public static bool LeaveClanChatRoom(CSteamID steamIDClan)
	{
		return NativeMethods.ISteamFriends_LeaveClanChatRoom(steamIDClan);
	}

	public static int GetClanChatMemberCount(CSteamID steamIDClan)
	{
		return NativeMethods.ISteamFriends_GetClanChatMemberCount(steamIDClan);
	}

	public static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser)
	{
		return NativeMethods.ISteamFriends_GetChatMemberByIndex(steamIDClan, iUser);
	}

	public static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText)
	{
		return NativeMethods.ISteamFriends_SendClanChatMessage(steamIDClanChat, new InteropHelp.UTF8String(pchText));
	}

	public static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(cchTextMax);
		int num = NativeMethods.ISteamFriends_GetClanChatMessage(steamIDClanChat, iMessage, intPtr, cchTextMax, out peChatEntryType, out psteamidChatter);
		prgchText = ((num == 0) ? null : InteropHelp.PtrToStringUTF8(intPtr));
		Marshal.FreeHGlobal(intPtr);
		return num;
	}

	public static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser)
	{
		return NativeMethods.ISteamFriends_IsClanChatAdmin(steamIDClanChat, steamIDUser);
	}

	public static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat)
	{
		return NativeMethods.ISteamFriends_IsClanChatWindowOpenInSteam(steamIDClanChat);
	}

	public static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat)
	{
		return NativeMethods.ISteamFriends_OpenClanChatWindowInSteam(steamIDClanChat);
	}

	public static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat)
	{
		return NativeMethods.ISteamFriends_CloseClanChatWindowInSteam(steamIDClanChat);
	}

	public static bool SetListenForFriendsMessages(bool bInterceptEnabled)
	{
		return NativeMethods.ISteamFriends_SetListenForFriendsMessages(bInterceptEnabled);
	}

	public static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend)
	{
		return NativeMethods.ISteamFriends_ReplyToFriendMessage(steamIDFriend, new InteropHelp.UTF8String(pchMsgToSend));
	}

	public static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(cubData);
		int num = NativeMethods.ISteamFriends_GetFriendMessage(steamIDFriend, iMessageID, intPtr, cubData, out peChatEntryType);
		pvData = ((num == 0) ? null : InteropHelp.PtrToStringUTF8(intPtr));
		Marshal.FreeHGlobal(intPtr);
		return num;
	}

	public static SteamAPICall_t GetFollowerCount(CSteamID steamID)
	{
		return NativeMethods.ISteamFriends_GetFollowerCount(steamID);
	}

	public static SteamAPICall_t IsFollowing(CSteamID steamID)
	{
		return NativeMethods.ISteamFriends_IsFollowing(steamID);
	}

	public static SteamAPICall_t EnumerateFollowingList(uint unStartIndex)
	{
		return NativeMethods.ISteamFriends_EnumerateFollowingList(unStartIndex);
	}
}
