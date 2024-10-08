using HarmonyLib;
using RimWorld;
using UnityEngine;

namespace MetallicBatteries;

[HarmonyPatch(typeof(CompPowerBattery), nameof(CompPowerBattery.AddEnergy))]
public static class CompPowerBattery_AddEnergy
{
    public static void Prefix(ref float amount, CompPowerBattery __instance)
    {
        if (__instance?.parent?.def != null && __instance.parent.def == MetallicBatteriesDefOf.Battery_Uranium)
        {
            amount *= Mathf.InverseLerp(80f, 20f, __instance.parent.AmbientTemperature);
        }
    }
}