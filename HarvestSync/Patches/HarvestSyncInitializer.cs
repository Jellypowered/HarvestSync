using HarmonyLib;
using System.Reflection;
using Verse;

namespace HarvestSync
{
	[StaticConstructorOnStartup]
	class HarvestSyncInitializer
	{
		static HarvestSyncInitializer()
		{
			var harmony = new Harmony("com.jelly.harvestsync");
			harmony.PatchAll(Assembly.GetExecutingAssembly());
		}
	}
}
