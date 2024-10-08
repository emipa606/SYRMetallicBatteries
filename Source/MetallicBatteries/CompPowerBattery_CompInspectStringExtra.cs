using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;

namespace MetallicBatteries;

[HarmonyPatch(typeof(CompPowerBattery), nameof(CompPowerBattery.CompInspectStringExtra))]
public static class CompPowerBattery_CompInspectStringExtra
{
    public static void Postfix(ref string __result, CompPowerBattery __instance)
    {
        if (__instance?.parent?.def != null && __instance.parent.def == MetallicBatteriesDefOf.Battery_Uranium)
        {
            __result += "\n" + "PowerBatteryHeatLoss".Translate() + ": " +
                        (__instance.Props.efficiency * 100f *
                         Mathf.InverseLerp(80f, 20f, __instance.parent.AmbientTemperature)).ToString("F0") + "%";
        }
    }
}