using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;

namespace MetallicBatteries;

[HarmonyPatch(typeof(Building_Battery), "DrawAt")]
public static class Building_Battery_DrawAt
{
    public static Material BatteryBarFilledMateralOverride;

    public static void Prefix(Building_Battery __instance)
    {
        var comp = __instance.GetComp<CompPowerBattery>();
        if (comp == null)
        {
            return;
        }

        BatteryBarFilledMateralOverride = GetMatColor(comp);
    }

    public static void Postfix()
    {
        BatteryBarFilledMateralOverride = null;
    }

    public static Material GetMatColor(CompPowerBattery comp)
    {
        var fillPercent = comp.StoredEnergy / comp.Props.storedEnergyMax;
        return SolidColorMaterials.SimpleSolidColorMaterial(new Color(GenMath.LerpDouble(0.5f, 1f, 1f, 0f, fillPercent),
            GenMath.LerpDouble(0f, 0.5f, 0f, 1f, fillPercent), 0.2f));
    }
}