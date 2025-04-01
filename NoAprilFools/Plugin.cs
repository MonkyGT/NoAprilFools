using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace NoAprilFools
{
    [BepInPlugin("monky.noaprilfools", "NoAprilFools", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {

        void Start()
        {
            
            GorillaTagger.OnPlayerSpawned(OnGameInitialized);
        }

        void OnGameInitialized()
        {
            GameObject April;
            April = VRRig.LocalRig.transform.GetChild(13).gameObject; 
            if (April.transform.name == "AprilFools") 
            { 
                April.SetActive(false); 
            }
        }

        void Update()
        {
            foreach (VRRig vrig in GorillaParent.instance.vrrigs)
            {
                if (!vrig.isLocal)
                {
                    GameObject April;
                    April = vrig.transform.GetChild(13).gameObject;
                    if (April.transform.name == "AprilFools")
                    {
                        April.SetActive(false);
                    }
                }
            }
        }
    }
}