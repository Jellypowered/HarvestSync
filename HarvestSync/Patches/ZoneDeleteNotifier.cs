using HarmonyLib;
using Verse;

namespace HarvestSync
{
	[HarmonyPatch(typeof(Zone), "Delete")]
	public static class ZoneDeleteNotifier
	{
		[HarmonyPrefix]
		static void Prefix(Zone __instance)
		{
			__instance.Map.GetComponent<HarvestManager_MapComponent>().OnAreaRemoved(__instance);
		}
	}
}