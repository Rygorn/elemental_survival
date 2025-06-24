
using UnityEngine;


public static class ElementalSurvivalLogger
{
    public static bool EnableDebugLogging = true;

    public static void LogWeatherStats(EntityAlive entity)
    {
        if (!EnableDebugLogging || entity == null) return;

        var buffs = entity.Buffs;

        Log.Out("[ElementalSurvival] WeatherSurvivalEnabled: " + EntityStats.WeatherSurvivalEnabled);
        Log.Out("[ElementalSurvival] InGracePeriod: " + WeatherManager.inWeatherGracePeriod);
        Log.Out("[ElementalSurvival] GodMode: " + entity.IsGodMode.Value);
        Log.Out("[ElementalSurvival] Biome is null: " + (entity.biomeStandingOn == null));
        Log.Out("[ElementalSurvival] Has god buff: " + buffs.HasBuff("god"));
    }
}