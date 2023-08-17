namespace Steamworks;

public static class SteamController
{
	public static bool Init(string pchAbsolutePathToControllerConfigVDF)
	{
		return NativeMethods.ISteamController_Init(new InteropHelp.UTF8String(pchAbsolutePathToControllerConfigVDF));
	}

	public static bool Shutdown()
	{
		return NativeMethods.ISteamController_Shutdown();
	}

	public static void RunFrame()
	{
		NativeMethods.ISteamController_RunFrame();
	}

	public static bool GetControllerState(uint unControllerIndex, out SteamControllerState_t pState)
	{
		return NativeMethods.ISteamController_GetControllerState(unControllerIndex, out pState);
	}

	public static void TriggerHapticPulse(uint unControllerIndex, ESteamControllerPad eTargetPad, ushort usDurationMicroSec)
	{
		NativeMethods.ISteamController_TriggerHapticPulse(unControllerIndex, eTargetPad, usDurationMicroSec);
	}

	public static void SetOverrideMode(string pchMode)
	{
		NativeMethods.ISteamController_SetOverrideMode(new InteropHelp.UTF8String(pchMode));
	}
}
