namespace Steamworks;

public static class SteamHTTP
{
	public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
	{
		return NativeMethods.ISteamHTTP_CreateHTTPRequest(eHTTPRequestMethod, new InteropHelp.UTF8String(pchAbsoluteURL));
	}

	public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
	{
		return NativeMethods.ISteamHTTP_SetHTTPRequestContextValue(hRequest, ulContextValue);
	}

	public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
	{
		return NativeMethods.ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(hRequest, unTimeoutSeconds);
	}

	public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
	{
		return NativeMethods.ISteamHTTP_SetHTTPRequestHeaderValue(hRequest, new InteropHelp.UTF8String(pchHeaderName), new InteropHelp.UTF8String(pchHeaderValue));
	}

	public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
	{
		return NativeMethods.ISteamHTTP_SetHTTPRequestGetOrPostParameter(hRequest, new InteropHelp.UTF8String(pchParamName), new InteropHelp.UTF8String(pchParamValue));
	}

	public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
	{
		return NativeMethods.ISteamHTTP_SendHTTPRequest(hRequest, out pCallHandle);
	}

	public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
	{
		return NativeMethods.ISteamHTTP_SendHTTPRequestAndStreamResponse(hRequest, out pCallHandle);
	}

	public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
	{
		return NativeMethods.ISteamHTTP_DeferHTTPRequest(hRequest);
	}

	public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
	{
		return NativeMethods.ISteamHTTP_PrioritizeHTTPRequest(hRequest);
	}

	public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
	{
		return NativeMethods.ISteamHTTP_GetHTTPResponseHeaderSize(hRequest, new InteropHelp.UTF8String(pchHeaderName), out unResponseHeaderSize);
	}

	public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
	{
		return NativeMethods.ISteamHTTP_GetHTTPResponseHeaderValue(hRequest, new InteropHelp.UTF8String(pchHeaderName), pHeaderValueBuffer, unBufferSize);
	}

	public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
	{
		return NativeMethods.ISteamHTTP_GetHTTPResponseBodySize(hRequest, out unBodySize);
	}

	public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
	{
		return NativeMethods.ISteamHTTP_GetHTTPResponseBodyData(hRequest, pBodyDataBuffer, unBufferSize);
	}

	public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
	{
		return NativeMethods.ISteamHTTP_GetHTTPStreamingResponseBodyData(hRequest, cOffset, pBodyDataBuffer, unBufferSize);
	}

	public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
	{
		return NativeMethods.ISteamHTTP_ReleaseHTTPRequest(hRequest);
	}

	public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
	{
		return NativeMethods.ISteamHTTP_GetHTTPDownloadProgressPct(hRequest, out pflPercentOut);
	}

	public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
	{
		return NativeMethods.ISteamHTTP_SetHTTPRequestRawPostBody(hRequest, new InteropHelp.UTF8String(pchContentType), pubBody, unBodyLen);
	}
}
