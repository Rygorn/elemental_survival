using HarmonyLib;

[HarmonyPatch(typeof(PlayerEntityStats), "UpdateWeatherStats")]
public class Patch_UpdateWeatherStats
{
    static void Postfix(PlayerEntityStats __instance)
    {
        ElementalSurvivalLogger.LogWeatherStats(__instance.m_entity);
    }
}
