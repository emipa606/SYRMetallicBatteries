using System.Reflection;
using HarmonyLib;
using Verse;

namespace MetallicBatteries;

[StaticConstructorOnStartup]
public class HarmonyPatches
{
    static HarmonyPatches()
    {
        new Harmony("Syrchalis.Rimworld.MetallicBatteries").PatchAll(Assembly.GetExecutingAssembly());
    }
}