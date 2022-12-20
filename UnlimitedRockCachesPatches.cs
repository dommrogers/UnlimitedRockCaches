using HarmonyLib;
using Il2Cpp;


namespace UnlimitedRockCaches
{
    [HarmonyPatch(typeof(GameManager), "Awake")]
    internal class GameManager_Awake
    {
        private static void Postfix()
        {
            GameManager.GetRockCacheManager().m_MaxRockCachesPerRegion = 999;
            GameManager.GetRockCacheManager().m_MinDistanceBetweenRockCaches = 0.25f;
        }
    }
}
