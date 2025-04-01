using BepInEx;
using HarmonyLib;

namespace NoAprilFools
{
    [BepInPlugin("monky.noaprilfools", "NoAprilFools", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        bool inRoom;

        void Start()
        {
            var harmony = Harmony.CreateAndPatchAll(GetType().Assembly, "monky.noaprilfools");
            
            GorillaTagger.OnPlayerSpawned(OnGameInitialized);
        }

        void OnGameInitialized()
        {
            
        }

        void Update()
        {
            if (NetworkSystem.Instance.InRoom)
            {
                if (!inRoom)
                {
                    inRoom = true;
                }
            }
            else
            {
                if (inRoom)
                {
                    inRoom = false;
                }
            }

            if (inRoom)
            {
                foreach (VRRig vrig in GorillaParent.instance.vrrigs)
                {
                    vrig.transform.GetChild(13).gameObject.SetActive(false);
                }
            }
        }
    }
}