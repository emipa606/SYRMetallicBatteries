using System.Reflection;
using HarmonyLib;
using UnityEngine;
using Verse;

namespace MetallicBatteries;

[StaticConstructorOnStartup]
public static class HarmonyPatches
{
    public static Material BatteryBarFilledMateralOverride;

    static HarmonyPatches()
    {
        new Harmony("Syrchalis.Rimworld.MetallicBatteries").PatchAll(Assembly.GetExecutingAssembly());
    }
}