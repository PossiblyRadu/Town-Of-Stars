using HarmonyLib;
using MiraAPI.Utilities.Assets;
using TouExtensionExample.Assets;
using TownOfUs.Assets;
using UnityEngine;

namespace TouExtensionExample.Patches;

[HarmonyPatch]
public static class LogoPatch
{
    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.Banner), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool Prefix(ref LoadableAsset<Sprite> __result)
    {
        __result = ExampleAssets.Banner;
        return false;
    }
}