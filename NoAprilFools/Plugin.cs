using BepInEx;
using HarmonyLib;

namespace NoAprilFools
{
    [BepInPlugin("monky.noaprilfools", "NoAprilFools", "1.0.2")]
    public class Plugin : BaseUnityPlugin
    {
        public void Awake()
        {
            Harmony.CreateAndPatchAll(GetType().Assembly, "monky.noaprilfools");
        }
    }
}