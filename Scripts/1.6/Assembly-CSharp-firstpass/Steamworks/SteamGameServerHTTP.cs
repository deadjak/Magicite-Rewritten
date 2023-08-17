namespace Steamworks;

public static class SteamGameServerHTTP
{
	public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
	{
		return NativeMethods.ISteamGameServerHTTP_CreateHTTPRequest(eHTTPRequestMethod, new InteropHelp.UTF8String(pchAbsoluteURL));
	}

	public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
	{
		return NativeMethods.ISteamGameServerHTTP_SetHTTPRequestContextValue(hRequest, ulContextValue);
	}

	public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
	{
		return NativeMethods.ISteamGameServerHTTP_SetHTTPRequestNetworkActivityTimeout(hRequest, unTimeoutSeconds);
	}

	public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
	{
		return NativeMethods.ISteamGameServerHTTP_SetHTTPRequestHeaderValue(hRequest, new InteropHelp.UTF8String(pchHeaderName), new InteropHelp.UTF8String(pchHeaderValue));
	}

	public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
	{
		return NativeMethods.ISteamGameServerHTTP_SetHTTPRequestGetOrPostParameter(hRequest, new InteropHelp.UTF8String(pchParamName), new InteropHelp.UTF8String(pchParamValue));
	}

	public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
	{
		return NativeMethods.ISteamGameServerHTTP_SendHTTPRequest(hRequest, out pCallHandle);
	}

	public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
	{
		return NativeMethods.ISteamGameServerHTTP_SendHTTPRequestAndStreamResponse(hRequest, out pCallHandle);
	}

	public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
	{
		return NativeMethods.ISteamGameServerHTTP_DeferHTTPRequest(hRequest);
	}

	public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
	{
		return NativeMethods.ISteamGameServerHTTP_PrioritizeHTTPRequest(hRequest);
	}

	public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
	{
		return NativeMethods.ISteamGameServerHTTP_GetHTTPResponseHeaderSize(hRequest, new InteropHelp.UTF8String(pchHeaderName), out unResponseHeaderSize);
	}

	public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
	{
		return NativeMethods.ISteamGameServerHTTP_GetHTTPResponseHeaderValue(hRequest, new InteropHelp.UTF8String(pchHeaderName), pHeaderValueBuffer, unBufferSize);
	}

	public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
	{
		return NativeMethods.ISteamGameServerHTTP_GetHTTPResponseBodySize(hRequest, out unBodySize);
	}

	public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
	{
		return NativeMethods.ISteamGameServerHTTP_GetHTTPResponseBodyData(hRequest, pBodyDataBuffer, unBufferSize);
	}

	public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
	{
		return NativeMethods.ISteamGameServerHTTP_GetHTTPStreamingResponseBodyData(hRequest, cOffset, pBodyDataBuffer, unBufferSize);
	}

	public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
	{
		return NativeMethods.ISteamGameServerHTTP_ReleaseHTTPRequest(hRequest);
	}

	public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
	{
		return NativeMethods.ISteamGameServerHTTP_GetHTTPDownloadProgressPct(hRequest, out pflPercentOut);
	}

	public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
	{
		return NativeMethods.ISteamGameServerHTTP_SetHTTPRequestRawPostBody(hRequest, new InteropHelp.UTF8String(pchContentType), pubBody, unBodyLen);
	}
}
