using HarmonyLib;
using Il2Cpp;

namespace UnlimitedRockCaches
{
    [HarmonyPatch(typeof(RockCacheManager), "HasReachedMaxRockCacheCount")]
    internal class RockCacheManager_HasReachedMaxRockCacheCount
    {
        private static void Postfix(ref bool __result)
        {
            __result = false;
        }
    }
}
