using HarmonyLib;

namespace NoAprilFools.Patches
{
    [HarmonyPatch(typeof(AprilFools), "GenerateSmoothTarget")]
    public static class Patch_AprilFools
    {
        static bool Prefix(ref float __result)
        {
            __result = 1.0f; // Disable AprilFools effect by returning a neutral value
            return false; // Skip the original method
        }
    }
}