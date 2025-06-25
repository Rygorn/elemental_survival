using HarmonyLib;
using UnityEngine;

public class ElementalSurvivalMain : IModApi
{
    public void InitMod(Mod mod)
    {
        Log.Out("[ElementalSurvival] Initializing mod and applying Harmony patches...");
        var harmony = new Harmony("com.rygorn85.elementalsurvival");
        harmony.PatchAll();
    }
}

