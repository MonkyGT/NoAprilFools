using HarmonyLib;
using UnityEngine;

namespace NoAprilFools
{
    [HarmonyPatch]
    public class Patches
    {
        [HarmonyPatch(typeof(AprilFools), nameof(AprilFools.GenerateSmoothTarget)), HarmonyPrefix]
        public static bool AprilFoolsPatch2023(ref float __result)
        {
            __result = 1f;
            return false;
        }

        [HarmonyPatch(typeof(ScalerUpper), "Update"), HarmonyPrefix]
        public static bool AprilFoolsPatch2025(ScalerUpper __instance, Transform[] ___target)
        {
            if (___target != null && ___target.Length == 1 && ___target[0].name.ToLower().StartsWith("head"))
            {
                __instance.enabled = false;
                return false;
            }
            return true;
        }
    }
}
