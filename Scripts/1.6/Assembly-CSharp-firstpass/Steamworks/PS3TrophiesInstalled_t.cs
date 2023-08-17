using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(1112)]
public struct PS3TrophiesInstalled_t
{
	public const int k_iCallback = 1112;

	public ulong m_nGameID;

	public EResult m_eResult;

	public ulong m_ulRequiredDiskSpace;
}
