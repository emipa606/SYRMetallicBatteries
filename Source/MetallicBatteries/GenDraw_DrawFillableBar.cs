using HarmonyLib;
using Verse;

namespace MetallicBatteries;

[HarmonyPatch(typeof(GenDraw), nameof(GenDraw.DrawFillableBar))]
public static class GenDraw_DrawFillableBar
{
    public static void Prefix(ref GenDraw.FillableBarRequest r)
    {
        if (HarmonyPatches.BatteryBarFilledMateralOverride != null)
        {
            r.filledMat = HarmonyPatches.BatteryBarFilledMateralOverride;
        }
    }
}