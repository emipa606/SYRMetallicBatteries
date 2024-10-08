using HarmonyLib;
using Verse;

namespace MetallicBatteries;

[HarmonyPatch(typeof(GenDraw), nameof(GenDraw.DrawFillableBar))]
public static class GenDraw_DrawFillableBar
{
    public static void Prefix(ref GenDraw.FillableBarRequest r)
    {
        if (Building_Battery_DrawAt.BatteryBarFilledMateralOverride != null)
        {
            r.filledMat = Building_Battery_DrawAt.BatteryBarFilledMateralOverride;
        }
    }
}